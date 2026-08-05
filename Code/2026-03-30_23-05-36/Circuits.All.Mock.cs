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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x28BD670", Offset = "0x28BC470", VA = "0x1828BD670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
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
		internal sealed class EQTJYROAYBC : AFHJZSXUXUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public EQTJYROAYBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xBD1650", Offset = "0xBD0450", VA = "0x180BD1650", Slot = "4")]
			public AFHJZSXUXUT TQDDUKLGGYD(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xBD1650", Offset = "0xBD0450", VA = "0x180BD1650", Slot = "5")]
			public AFHJZSXUXUT VMHYACQWKEW(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBD1650", Offset = "0xBD0450", VA = "0x180BD1650", Slot = "6")]
			public AFHJZSXUXUT ZTBQKSDGJUK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			public void LSLJVZFFPFX()
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
	public static class MPALQGSVYAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IOBBVAODQCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public JQAVOXTFMGO UZZHPDQPXIH;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IOBBVAODQCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x28BC650", Offset = "0x28BB450", VA = "0x1828BC650")]
			internal MBCVFYIDIHC HFNQOPQJULU(GetNetworkObjectDelegate a)
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
			public IXXCQUDTOLA dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public RPLYECVWMOB network;

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
			[Cpp2IlInjected.Address(RVA = "0x28C6290", Offset = "0x28C5090", VA = "0x1828C6290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x28C6930", Offset = "0x28C5730", VA = "0x1828C6930", Slot = "5")]
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
			public RPLYECVWMOB network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public IXXCQUDTOLA dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<UEWLFKNRYNB>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private QYNLRMWOSJV <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x28C69A0", Offset = "0x28C57A0", VA = "0x1828C69A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x28C6F30", Offset = "0x28C5D30", VA = "0x1828C6F30", Slot = "5")]
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
			public JQAVOXTFMGO roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x28C6FA0", Offset = "0x28C5DA0", VA = "0x1828C6FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x28C74B0", Offset = "0x28C62B0", VA = "0x1828C74B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28BCEA0", Offset = "0x28BBCA0", VA = "0x1828BCEA0")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? QLHEDJXCSSA([Optional] JQAVOXTFMGO? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28BCF90", Offset = "0x28BBD90", VA = "0x1828BCF90")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> TZZUEVONEFD(RPLYECVWMOB a, [Optional] IXXCQUDTOLA? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28BD110", Offset = "0x28BBF10", VA = "0x1828BD110")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> TZZUEVONEFD(RPLYECVWMOB a, IXXCQUDTOLA b, RegistryV2 c, Id32<UEWLFKNRYNB>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28BD2A0", Offset = "0x28BC0A0", VA = "0x1828BD2A0")]
		public static (RuntimeFnRegistry, RuntimeFns) YQOTZBRIOYB()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28BCDA0", Offset = "0x28BBBA0", VA = "0x1828BCDA0")]
		public static (ExternalFnRegistry, ExternalFns) OIKFSLOOHFQ()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28BD370", Offset = "0x28BC170", VA = "0x1828BD370")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static RPLYECVWMOB YXZCXRZWMDF(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class YNRKVMFKRJH
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate MBCVFYIDIHC CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public YNRKVMFKRJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x28C5EA0", Offset = "0x28C4CA0", VA = "0x1828C5EA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28C6220", Offset = "0x28C5020", VA = "0x1828C6220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly RPLYECVWMOB XGTGCIQBNPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? MFEBGIQNQPZ;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		private YNRKVMFKRJH(RPLYECVWMOB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28C8820", Offset = "0x28C7620", VA = "0x1828C8820")]
		public static YNRKVMFKRJH LZSOKMSMVLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8710", Offset = "0x28C7510", VA = "0x1828C8710")]
		public YNRKVMFKRJH BDWXFCBIKRW(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28C8730", Offset = "0x28C7530", VA = "0x1828C8730")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> LSLJVZFFPFX()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class TQXERAMNMOT : QYNLRMWOSJV.WROGKVZRMEZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate PNFRNYGBIVD NewCircuitsLifecycleDelegate(CKLHBYYABAA.WROGKVZRMEZ deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(QYNLRMWOSJV circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(QYNLRMWOSJV circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate ARCRDCHWKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate AJMHOCBXSTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate CIGOOXLXEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate RLDXLIAJQRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate KSUPJCCAKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate MULTKCHNSIG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int LMPYBIKJZWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x10861E0", Offset = "0x1084FE0", VA = "0x1810861E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28C3620", Offset = "0x28C2420", VA = "0x1828C3620", Slot = "6")]
		public void QNHZTCLZYHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28C3650", Offset = "0x28C2450", VA = "0x1828C3650", Slot = "7")]
		public void TTGAPJWZAZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28C35F0", Offset = "0x28C23F0", VA = "0x1828C35F0", Slot = "5")]
		public PNFRNYGBIVD NVGDKSKNKLE(CKLHBYYABAA.WROGKVZRMEZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCDE310", Offset = "0xCDD110", VA = "0x180CDE310", Slot = "8")]
		public void YEETJGZSYXN(QYNLRMWOSJV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCDE220", Offset = "0xCDD020", VA = "0x180CDE220", Slot = "9")]
		public void XBBAFQBEWJW(QYNLRMWOSJV a, CLHMCDDVOKO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28C3680", Offset = "0x28C2480", VA = "0x1828C3680")]
		public TQXERAMNMOT([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly CYONTVTWVUG<RPLYECVWMOB, RPLYECVWMOB.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly ZJJNMORMQIW<RPLYECVWMOB, RPLYECVWMOB.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly QYNLRMWOSJV CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<YMXYNUJKSYU> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly RPLYECVWMOB Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28B9470", Offset = "0x28B8270", VA = "0x1828B9470")]
		public EVCreationResult(CYONTVTWVUG<RPLYECVWMOB, RPLYECVWMOB.MockStaticNetSysDeps> staticNetSys, ZJJNMORMQIW<RPLYECVWMOB, RPLYECVWMOB.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, QYNLRMWOSJV circuitsManager, Id32<YMXYNUJKSYU> clientId, RPLYECVWMOB network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly QYNLRMWOSJV _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 FLXGDBQJXMT
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x28BCD70", Offset = "0x28BBB70", VA = "0x1828BCD70")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request LEWTZXSQFOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x28BCCE0", Offset = "0x28BBAE0", VA = "0x1828BCCE0")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public OAEIHKOZNCW? ZHKGFAWCQJT
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x28BCBF0", Offset = "0x28BB9F0", VA = "0x1828BCBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public PWYZVPLOZDE? LTQAQXMOOHD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x28BCD10", Offset = "0x28BBB10", VA = "0x1828BCD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
		internal LimitedCircuits(QYNLRMWOSJV circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class RGOJGYBTJCT : IXXCQUDTOLA
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class YRRMHUNOWMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public MBCVFYIDIHC XUALFBUBKSM;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public YRRMHUNOWMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			internal MBCVFYIDIHC KJLSBOHPVCG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public CKLHBYYABAA.WROGKVZRMEZ XEARRWVNHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public QYNLRMWOSJV.WROGKVZRMEZ QRZWUIWFNDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KSDCTIOOBTE.WROGKVZRMEZ ZNJCPGEQFCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public XXWVBQTGMDO.ZSAXAUTJBCY<ActionKind, CLHMCDDVOKO, QYNLRMWOSJV> FOAWHUQDHEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.WROGKVZRMEZ BQZKFGIFAOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OBCNIXZMAQE WXCHMYKAYKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JRGKQLWFHOJ AFQOSLFAMQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GBOCFJGVLDP EXPJIPUZVYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MEPNXTLNVVD CKNEUMTDFOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAC63E0", Offset = "0xAC51E0", VA = "0x180AC63E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LHZXDNJIZQT FUVYZMPRAOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAC6400", Offset = "0xAC5200", VA = "0x180AC6400", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28C3400", Offset = "0x28C2200", VA = "0x1828C3400")]
		private RGOJGYBTJCT(CKLHBYYABAA.WROGKVZRMEZ a, QYNLRMWOSJV.WROGKVZRMEZ b, KSDCTIOOBTE.WROGKVZRMEZ c, XXWVBQTGMDO.ZSAXAUTJBCY<ActionKind, CLHMCDDVOKO, QYNLRMWOSJV> d, CV2Request.WROGKVZRMEZ e, OBCNIXZMAQE f, JRGKQLWFHOJ g, GBOCFJGVLDP h, MEPNXTLNVVD i, LHZXDNJIZQT j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28C30A0", Offset = "0x28C1EA0", VA = "0x1828C30A0")]
		public static RGOJGYBTJCT? UTBUZITNFLO(KSDCTIOOBTE.WROGKVZRMEZ cv2RootSysDeps, [Optional] CKLHBYYABAA.WROGKVZRMEZ? a, [Optional] QYNLRMWOSJV.WROGKVZRMEZ? b, [Optional] XXWVBQTGMDO.ZSAXAUTJBCY<ActionKind, CLHMCDDVOKO, QYNLRMWOSJV>? reducerDeps, [Optional] CV2Request.WROGKVZRMEZ? c, [Optional] OBCNIXZMAQE? d, [Optional] JRGKQLWFHOJ? e, [Optional] GBOCFJGVLDP? f, [Optional] MEPNXTLNVVD? g, [Optional] LHZXDNJIZQT? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28C2BD0", Offset = "0x28C19D0", VA = "0x1828C2BD0")]
		public static RGOJGYBTJCT ODRGHRWJKJG(MBCVFYIDIHC a, [Optional] CKLHBYYABAA.WROGKVZRMEZ? circuitsLifecycleDeps, [Optional] QYNLRMWOSJV.WROGKVZRMEZ? circuitsManagerDeps, [Optional] XXWVBQTGMDO.ZSAXAUTJBCY<ActionKind, CLHMCDDVOKO, QYNLRMWOSJV>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28C2D20", Offset = "0x28C1B20", VA = "0x1828C2D20")]
		public static RGOJGYBTJCT OGSQZPCOTAS(GetNetworkObjectDelegate a, [Optional] CKLHBYYABAA.WROGKVZRMEZ? circuitsLifecycleDeps, [Optional] QYNLRMWOSJV.WROGKVZRMEZ? circuitsManagerDeps, [Optional] XXWVBQTGMDO.ZSAXAUTJBCY<ActionKind, CLHMCDDVOKO, QYNLRMWOSJV>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class PEZVHPPYPRQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class NHMYBFFRWAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public GetNetworkObjectDelegate OJODCBDMAZE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int QDBPKEXLGGI;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public NHMYBFFRWAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x28BD600", Offset = "0x28BC400", VA = "0x1828BD600")]
			internal PRMHRUKFPMT AYOBFONJVAR(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x28BD4A0", Offset = "0x28BC2A0", VA = "0x1828BD4A0")]
			internal PRMHRUKFPMT[] AVNBURAXJMM(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAD4260", Offset = "0xAD3060", VA = "0x180AD4260")]
			internal int PUHJSVBDCNG()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NHHRDYLUMPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public DynamicEnvironmentNetworkId XOXTTFKVRGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public NHMYBFFRWAV CNVJRMTDZSZ;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public NHHRDYLUMPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28BD3F0", Offset = "0x28BC1F0", VA = "0x1828BD3F0")]
			internal PRMHRUKFPMT IVQVSSKADEJ(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly SIFIYGRIVBJ KAKAKMOSHKY;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28C1DE0", Offset = "0x28C0BE0", VA = "0x1828C1DE0")]
		public static PRMHRUKFPMT? SYEPUZMHZFS(Id32<UEWLFKNRYNB>? networkObject, [Optional] QZBHLIRMBSG.SerializesIntoSavesDelegate? a, [Optional] QZBHLIRMBSG.SerializesIntoInventionsDelegate? b, [Optional] QZBHLIRMBSG.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28BD810", Offset = "0x28BC610", VA = "0x1828BD810")]
		public static MBCVFYIDIHC? CXKDPKYKWCR(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] WEUMFXGSBZZ? b, [Optional] IILVERLCETR? c, [Optional] FWWDVKHHOOT? d, [Optional] JQAVOXTFMGO? e, int f = 300000, bool g = false, bool h = false, [Optional] PFJZTVBYDGP? i, [Optional] XBPROGFLAJZ? j, [Optional] JZCTAOTAQBC? k, [Optional] YRYMGTIHVUX? l, [Optional] SHNAPDXGSNW? m, [Optional] MIVKONKSUSH? n, [Optional] KKJTIHGUWMR.WROGKVZRMEZ? o, [Optional] EqualsNodeV2.WROGKVZRMEZ? p, [Optional] HJQGHWVVMFR? q, [Optional] MBCVFYIDIHC.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] MBCVFYIDIHC.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] MBCVFYIDIHC.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] MBCVFYIDIHC.GetLocalRoomIdDelegate? u, [Optional] MBCVFYIDIHC.GetLocalSubroomIdDelegate? v, [Optional] MBCVFYIDIHC.GetSubroomIdsForLocalRoomDelegate? w, [Optional] MBCVFYIDIHC.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] MBCVFYIDIHC.SaveRoomOnPlayerBehalfDelegate? z, [Optional] MBCVFYIDIHC.ReportCloudDataLedgerChangedDelegate? ba, [Optional] MBCVFYIDIHC.GetColorNameByIdDelegate? bb, [Optional] MBCVFYIDIHC.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] MBCVFYIDIHC.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] MBCVFYIDIHC.GetTaggableNameFromSignalDelegate? be, [Optional] MBCVFYIDIHC.GetAudioNameFromSignalDelegate? bf, [Optional] MBCVFYIDIHC.GetDestinationNameFromSignalDelegate? bg, [Optional] MBCVFYIDIHC.GetPlayerEventNameFromSignalDelegate? bh, [Optional] MBCVFYIDIHC.GetRoomKeyNameFromSignalDelegate? bi, [Optional] MBCVFYIDIHC.GetRewardNameFromSignalDelegate? bj, [Optional] MBCVFYIDIHC.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] MBCVFYIDIHC.ReportPreloadedAudioChangedDelegate? bl, [Optional] MBCVFYIDIHC.ReportRewardDataChangedDelegate? bm, [Optional] MBCVFYIDIHC.GetConsumableNameFromSignalDelegate? bn, [Optional] MBCVFYIDIHC.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] MBCVFYIDIHC.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] MBCVFYIDIHC.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] MBCVFYIDIHC.GetInventoryItemNameFromSignalDelegate? br, [Optional] MBCVFYIDIHC.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] MBCVFYIDIHC.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] MBCVFYIDIHC.GetRoomOfferNameFromSignalDelegate? bu, [Optional] MBCVFYIDIHC.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] MBCVFYIDIHC.GetObjectIdFromCreationObjectDelegate? bw, [Optional] MBCVFYIDIHC.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] MBCVFYIDIHC.GetCostInBytesDelegate? by, [Optional] MBCVFYIDIHC.GetAvatarItemNameFromSignalDelegate? bz, [Optional] MBCVFYIDIHC.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] MBCVFYIDIHC.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] MBCVFYIDIHC.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] MBCVFYIDIHC.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] MBCVFYIDIHC.GetStoreItemNameFromSignalDelegate? ce, [Optional] MBCVFYIDIHC.GetBodyPartNameFromSignalDelegate? cf, [Optional] MBCVFYIDIHC.GetDependenciesForGraphInstanceDelegate? cg, [Optional] MBCVFYIDIHC.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] MBCVFYIDIHC.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] MBCVFYIDIHC.GetRecNetImageNameFromSignalDelegate? cj, [Optional] MBCVFYIDIHC.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] MBCVFYIDIHC.IsFunctionValidForAIDelegate? cm, [Optional] MBCVFYIDIHC.GetAIFunctionNameFromSignalDelegate? cn, [Optional] MBCVFYIDIHC.FromSerializableObjectDelegate? co, [Optional] MBCVFYIDIHC.ToSerializableObjectDelegate? cp)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<UEWLFKNRYNB>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class OJNRQCBSDZH : JZCTAOTAQBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly OJNRQCBSDZH PKFRARWZTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly GetLocalPlayerDelegate? RUQEMYJLIIQ;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x28BD6F0", Offset = "0x28BC4F0", VA = "0x1828BD6F0", Slot = "4")]
		public (HWZFZCEBWGV, HWZFZCEBWGV, HWZFZCEBWGV, HWZFZCEBWGV, HWZFZCEBWGV) ALBPZVSAILJ(object a)
		{
			return default((HWZFZCEBWGV, HWZFZCEBWGV, HWZFZCEBWGV, HWZFZCEBWGV, HWZFZCEBWGV));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x28BD760", Offset = "0x28BC560", VA = "0x1828BD760", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "6")]
		public bool CDREJRHTSIC(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xB2C700", Offset = "0xB2B500", VA = "0x180B2C700", Slot = "7")]
		public string BPBMUFYGUGA(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public OJNRQCBSDZH([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class QZBHLIRMBSG : PRMHRUKFPMT
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(QZBHLIRMBSG self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(QZBHLIRMBSG self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(QZBHLIRMBSG self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly SerializesIntoSavesDelegate GXEJTFGTJUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly SerializesIntoInventionsDelegate VTKRGMMKDJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly CanPublishInInventionsDelegate CGSRJLTSVKL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? CANLOGIQDOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OXKPJCPEXFX? MZDUXSWJIQN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId KLOUQOKTAFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD96F10", Offset = "0xD95D10", VA = "0x180D96F10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CGPFMXHRADL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x28C2BA0", Offset = "0x28C19A0", VA = "0x1828C2BA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool WMHOEYDWWAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x28C2B70", Offset = "0x28C1970", VA = "0x1828C2B70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool BSBUBMERIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x28C2B40", Offset = "0x28C1940", VA = "0x1828C2B40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public SQLZSEDPPEE? DHDNLWNDKSP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<UEWLFKNRYNB>? TIHVAYXCIZD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x28C29F0", Offset = "0x28C17F0", VA = "0x1828C29F0", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x28C2480", Offset = "0x28C1280", VA = "0x1828C2480", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(SIFIYGRIVBJ e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810", Slot = "13")]
		public void Bind(OXKPJCPEXFX controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x28C2A90", Offset = "0x28C1890", VA = "0x1828C2A90")]
		private QZBHLIRMBSG(Id32<UEWLFKNRYNB>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x28C2520", Offset = "0x28C1320", VA = "0x1828C2520")]
		public static QZBHLIRMBSG? New(Id32<UEWLFKNRYNB>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class HJHUMEDHSFI : PFJZTVBYDGP
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
		public static readonly HJHUMEDHSFI PKFRARWZTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly RoundToDecimalPlaceDelegate? OWDWBEERPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly TruncateToDecimalPlaceDelegate? XRXZGBLSYNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsColorLerpDelegate? WHTKVKAJHZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsColorInverseLerpDelegate? BIBWAXKXUYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4GetPositionDelegate? VFRKMUZWZCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4GetRotationDelegate? KTLDWLKYCCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsMtx4x4InverseDelegate? WWZGDDSZCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsMtx4x4MultiplyDelegate? OIKFPLVBFTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? TUNJLJMZDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatDotDelegate? ZYIDEPKOPMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromAngleAxisDelegate? JFJXQVICVKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? ABZLSQMMRQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatFromFromToRotationDelegate? SRILGKKJFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatFromLookRotationDelegate? ZSUWELETBQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? CPUWOTXLQSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseDelegate? UHGLDXFIHOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatLerpDelegate? IWMOWIHCFZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatLerpUnclampedDelegate? CKRRAELPTYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatInverseLerpDelegate? QZIVREPVYSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatMultiplyDelegate? YHPPNEBSNDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatNormalizeDelegate? UQCAMGWHEXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatRotateTowardsDelegate? PWAKBGUQQFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatRotateVectorDelegate? BEGHAHQBSEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatSlerpDelegate? YVYWLLXDMZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsQuatToAngleAxisDelegate? FEPCHVOSEZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsQuatToEulerAnglesDelegate? FIHXUJRGRGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3AddDelegate? CAOHGSGUQWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? UXSOAHPRPZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? REKEYNVFIJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3CrossDelegate? AUOQZEDXUYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3DotDelegate? LOCGBZJKFTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3AngleDelegate? FBAWKHQPNGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3GetMagnitudeDelegate? QVTOMFFFRNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3LerpDelegate? VPIXYQRAJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3LerpUnclampedDelegate? WCWSRGIEKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3InverseLerpDelegate? IRHYSFTVLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3MoveTowardsDelegate? GWXFYBPOQCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3NegateDelegate? ERPUZIJYMUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3NormalizeDelegate? VQCZANGAIPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ProjectDelegate? HLMFMCUZZTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? NZDBUBPQQWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3ScaleDelegate? YIXNFRXSSUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SmoothDampDelegate? JBGFMCXRADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3SubtractDelegate? IMOVFTEXSCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3SlerpDelegate? UJPEIRFRNIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly CircuitsVec3TransformDelegate? AWASADRFBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CircuitsVec3InverseTransformDelegate? HIOQPXXBLXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly RealtimeSinceStartupDelegate? YFGRJGLKAID;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28BC170", Offset = "0x28BAF70", VA = "0x1828BC170")]
		public HJHUMEDHSFI([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28BB850", Offset = "0x28BA650", VA = "0x1828BB850")]
		public float UNUSIRQZODN([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28BA9F0", Offset = "0x28B97F0", VA = "0x1828BA9F0")]
		public float GDYAQCWPBIN([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28BB3D0", Offset = "0x28BA1D0", VA = "0x1828BB3D0")]
		public CircuitsColor OKPVHUVLPDE([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28BA9C0", Offset = "0x28B97C0", VA = "0x1828BA9C0")]
		public float UYTWNDAUMSI([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28BB010", Offset = "0x28B9E10", VA = "0x1828BB010")]
		public CircuitsVec3 KRCAPMLSZEU([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28BAA10", Offset = "0x28B9810", VA = "0x1828BAA10")]
		public CircuitsQuat GEHICEGBHIZ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28BBB60", Offset = "0x28BA960", VA = "0x1828BBB60")]
		public CircuitsMtx4x4 VNOWADIZYWT([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28BA020", Offset = "0x28B8E20", VA = "0x1828BA020")]
		public CircuitsMtx4x4 AFTKDFIWBKR([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28BBE70", Offset = "0x28BAC70", VA = "0x1828BBE70")]
		public CircuitsMtx4x4 YHPGTNGZGOJ([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28BAD60", Offset = "0x28B9B60", VA = "0x1828BAD60")]
		public float IKJKWIUDJSK([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28BA910", Offset = "0x28B9710", VA = "0x1828BA910")]
		public CircuitsQuat FVVXVRHPURF(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28BA7D0", Offset = "0x28B95D0", VA = "0x1828BA7D0")]
		public CircuitsQuat IPMANZMCFUM([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28BB620", Offset = "0x28BA420", VA = "0x1828BB620")]
		public CircuitsQuat TUWFNYFCBNC([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28BA090", Offset = "0x28B8E90", VA = "0x1828BA090")]
		public CircuitsQuat DDDYVUBRXZI([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28BB430", Offset = "0x28BA230", VA = "0x1828BB430")]
		public CircuitsQuat WQUIGIGTLYV([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28BA320", Offset = "0x28B9120", VA = "0x1828BA320")]
		public CircuitsQuat BRJBVHADPWG([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28BA4F0", Offset = "0x28B92F0", VA = "0x1828BA4F0")]
		public CircuitsQuat TFHRMUPGARD([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28BA8E0", Offset = "0x28B96E0", VA = "0x1828BA8E0")]
		public float WEEZZAZTFZG([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28BA210", Offset = "0x28B9010", VA = "0x1828BA210")]
		public CircuitsQuat BFGMMOEAEBV([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28BAD80", Offset = "0x28B9B80", VA = "0x1828BAD80")]
		public CircuitsQuat WEDQVMBLEWW([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28BAF50", Offset = "0x28B9D50", VA = "0x1828BAF50")]
		public CircuitsQuat WJUFBTIXDXG([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28BAC60", Offset = "0x28B9A60", VA = "0x1828BAC60")]
		public CircuitsVec3 ICDCMMMSETN([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28BA6B0", Offset = "0x28B94B0", VA = "0x1828BA6B0")]
		public CircuitsQuat XKHEPNNWFKV([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x28BAAD0", Offset = "0x28B98D0", VA = "0x1828BAAD0")]
		public void HMAENPCNXKQ([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28BB0E0", Offset = "0x28B9EE0", VA = "0x1828BB0E0")]
		public CircuitsVec3 LUBYFDSWQAL([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28BB5B0", Offset = "0x28BA3B0", VA = "0x1828BB5B0")]
		public CircuitsVec3 QISMHGPAJTM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28BACF0", Offset = "0x28B9AF0", VA = "0x1828BACF0")]
		public CircuitsVec3 IKCTDTVWYSQ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28BAB80", Offset = "0x28B9980", VA = "0x1828BAB80")]
		public CircuitsVec3 HZYWRLMYAVP([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x28BBEE0", Offset = "0x28BACE0", VA = "0x1828BBEE0")]
		public CircuitsVec3 YOXVLFXSLSJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28BA5B0", Offset = "0x28B93B0", VA = "0x1828BA5B0")]
		public float CJAWOLTGDLM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28BACD0", Offset = "0x28B9AD0", VA = "0x1828BACD0")]
		public float IDREYZALPSC([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28BB800", Offset = "0x28BA600", VA = "0x1828BB800")]
		public float SAUVOPJEFDT([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28BA140", Offset = "0x28B8F40", VA = "0x1828BA140")]
		public CircuitsVec3 ATSVSLOMOXU([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28BB2D0", Offset = "0x28BA0D0", VA = "0x1828BB2D0")]
		public CircuitsVec3 NNQVCJSKQIR([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28BB3A0", Offset = "0x28BA1A0", VA = "0x1828BB3A0")]
		public float RBFNXQVKILC([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28BBC60", Offset = "0x28BAA60", VA = "0x1828BBC60")]
		public CircuitsVec3 WRQOJDEYTTY([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28BBCD0", Offset = "0x28BAAD0", VA = "0x1828BBCD0")]
		public CircuitsVec3 WYTFNRUENKZ([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28BA770", Offset = "0x28B9570", VA = "0x1828BA770")]
		public CircuitsVec3 DDYTPGKONZI([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28BB790", Offset = "0x28BA590", VA = "0x1828BB790")]
		public CircuitsVec3 RGPMUPQBDWY([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28BB4D0", Offset = "0x28BA2D0", VA = "0x1828BB4D0")]
		public CircuitsVec3 PYNQPHQZVAF([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28BAE20", Offset = "0x28B9C20", VA = "0x1828BAE20")]
		public CircuitsVec3 IOPGSIMOFAP([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x28BA3E0", Offset = "0x28B91E0", VA = "0x1828BA3E0")]
		public CircuitsVec3 BYUSNZZXYXJ([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28BBE00", Offset = "0x28BAC00", VA = "0x1828BBE00")]
		public CircuitsVec3 YBLTGBSQAVN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28BA870", Offset = "0x28B9670", VA = "0x1828BA870")]
		public CircuitsVec3 EFZFRDQEJZT([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x28BB140", Offset = "0x28B9F40", VA = "0x1828BB140")]
		public CircuitsVec3 LUKBMOEBFTD([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28BB070", Offset = "0x28B9E70", VA = "0x1828BB070")]
		public CircuitsVec3 KUTOXDGNZVV([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28BB820", Offset = "0x28BA620", VA = "0x1828BB820", Slot = "50")]
		public Task SCSNTKLDEFX(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "51")]
		public void BMVGPZYIGQN([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28BB280", Offset = "0x28BA080", VA = "0x1828BB280", Slot = "52")]
		public NLMVNRYYJPS<DHOLAANDPCA> MXPLTZZHGBX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28BBF50", Offset = "0x28BAD50", VA = "0x1828BBF50", Slot = "53")]
		public NLMVNRYYJPS<DHOLAANDPCA> ZHUEGDYJEWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28BBC40", Offset = "0x28BAA40", VA = "0x1828BBC40", Slot = "54")]
		public float WMBEAAUAKVY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28BB850", Offset = "0x28BA650", VA = "0x1828BB850", Slot = "4")]
		private float SPGRKDXMPGJ([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28BA9F0", Offset = "0x28B97F0", VA = "0x1828BA9F0", Slot = "5")]
		private float RGOXJYAVSGX([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x28BA490", Offset = "0x28B9290", VA = "0x1828BA490", Slot = "6")]
		private CircuitsColor CEJMETVRYZG([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28BA9C0", Offset = "0x28B97C0", VA = "0x1828BA9C0", Slot = "7")]
		private float GBTEBLRQTSK([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28BB340", Offset = "0x28BA140", VA = "0x1828BB340", Slot = "8")]
		private CircuitsVec3 OEUXQIXPXXQ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28BAF00", Offset = "0x28B9D00", VA = "0x1828BAF00", Slot = "9")]
		private CircuitsQuat JVEHLHQFJZJ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA30", Offset = "0x28BA830", VA = "0x1828BBA30", Slot = "10")]
		private CircuitsMtx4x4 VFZHTYSCBHT([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28BBDA0", Offset = "0x28BABA0", VA = "0x1828BBDA0", Slot = "11")]
		private CircuitsMtx4x4 XSXGNRVGTKT([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28BA2C0", Offset = "0x28B90C0", VA = "0x1828BA2C0", Slot = "12")]
		private CircuitsMtx4x4 BOZIFTICGFR([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28BAD60", Offset = "0x28B9B60", VA = "0x1828BAD60", Slot = "13")]
		private float YNRIXSIROTO([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28BA910", Offset = "0x28B9710", VA = "0x1828BA910", Slot = "14")]
		private CircuitsQuat NCJYFOPFVBP(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28BA7D0", Offset = "0x28B95D0", VA = "0x1828BA7D0", Slot = "15")]
		private CircuitsQuat EEZLGIUBHKK([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x28BB620", Offset = "0x28BA420", VA = "0x1828BB620", Slot = "16")]
		private CircuitsQuat QOGNCQBASDA([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x28BA090", Offset = "0x28B8E90", VA = "0x1828BA090", Slot = "17")]
		private CircuitsQuat AJHQSGJASPC([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x28BB430", Offset = "0x28BA230", VA = "0x1828BB430", Slot = "18")]
		private CircuitsQuat PYAZNRXURBZ([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x28BA320", Offset = "0x28B9120", VA = "0x1828BA320", Slot = "19")]
		private CircuitsQuat TSMTBKPCGEE([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x28BA4F0", Offset = "0x28B92F0", VA = "0x1828BA4F0", Slot = "20")]
		private CircuitsQuat CISJEULNLJB([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28BA8E0", Offset = "0x28B96E0", VA = "0x1828BA8E0", Slot = "21")]
		private float FQZJRIBEVQK([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28BA210", Offset = "0x28B9010", VA = "0x1828BA210", Slot = "22")]
		private CircuitsQuat SMZUNJZNRYN([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x28BAD80", Offset = "0x28B9B80", VA = "0x1828BAD80", Slot = "23")]
		private CircuitsQuat INBMVPINHMM([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x28BAF50", Offset = "0x28B9D50", VA = "0x1828BAF50", Slot = "24")]
		private CircuitsQuat JXBZUPXDVGG([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x28BB540", Offset = "0x28BA340", VA = "0x1828BB540", Slot = "25")]
		private CircuitsVec3 QBYRGKGOPFP([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28BA6B0", Offset = "0x28B94B0", VA = "0x1828BA6B0", Slot = "26")]
		private CircuitsQuat CYOTPTNKVLJ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28BAAD0", Offset = "0x28B98D0", VA = "0x1828BAAD0", Slot = "27")]
		private void NHULKUUZOJE([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28BA1B0", Offset = "0x28B8FB0", VA = "0x1828BA1B0", Slot = "28")]
		private CircuitsVec3 AZMRIFRKTAR([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28BB8E0", Offset = "0x28BA6E0", VA = "0x1828BB8E0", Slot = "29")]
		private CircuitsVec3 TBLCNGTNKQI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28BBAF0", Offset = "0x28BA8F0", VA = "0x1828BBAF0", Slot = "30")]
		private CircuitsVec3 VKXLKMFSADQ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x28BABF0", Offset = "0x28B99F0", VA = "0x1828BABF0", Slot = "31")]
		private CircuitsVec3 IADIGGCYFZJ([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x28BAE90", Offset = "0x28B9C90", VA = "0x1828BAE90", Slot = "32")]
		private CircuitsVec3 JPPZREOUIFV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x28BBBD0", Offset = "0x28BA9D0", VA = "0x1828BBBD0", Slot = "33")]
		private CircuitsVec3 VZKBCOEXKXB([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x28BB950", Offset = "0x28BA750", VA = "0x1828BB950", Slot = "34")]
		private CircuitsVec3 TIKTNZAHTMN([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x28BA5B0", Offset = "0x28B93B0", VA = "0x1828BA5B0", Slot = "35")]
		private float DICBVZDHWSI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28BACD0", Offset = "0x28B9AD0", VA = "0x1828BACD0", Slot = "36")]
		private float MAZWZPSTFQQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28BB800", Offset = "0x28BA600", VA = "0x1828BB800", Slot = "37")]
		private float SCRSNFBXIOL([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28BBD30", Offset = "0x28BAB30", VA = "0x1828BBD30", Slot = "38")]
		private CircuitsVec3 WYWUMRJZLXK([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28BA640", Offset = "0x28B9440", VA = "0x1828BA640", Slot = "39")]
		private CircuitsVec3 CNROUHRBAFV([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28BB3A0", Offset = "0x28BA1A0", VA = "0x1828BB3A0", Slot = "40")]
		private float OJWHIUGDCOC([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x28BB870", Offset = "0x28BA670", VA = "0x1828BB870", Slot = "41")]
		private CircuitsVec3 SRKASTUUSJK([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA90", Offset = "0x28BA890", VA = "0x1828BBA90", Slot = "42")]
		private CircuitsVec3 VGBYBILTBHN([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28BB1B0", Offset = "0x28B9FB0", VA = "0x1828BB1B0", Slot = "43")]
		private CircuitsVec3 LZWQTPGIDWA([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28BAA60", Offset = "0x28B9860", VA = "0x1828BAA60", Slot = "44")]
		private CircuitsVec3 HKIUQUJSWTU([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28BA5D0", Offset = "0x28B93D0", VA = "0x1828BA5D0", Slot = "45")]
		private CircuitsVec3 CNIEZPFTXCT([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x28BB210", Offset = "0x28BA010", VA = "0x1828BB210", Slot = "46")]
		private CircuitsVec3 MEVPBGPKIAF([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x28BB6D0", Offset = "0x28BA4D0", VA = "0x1828BB6D0", Slot = "47")]
		private CircuitsVec3 RCNKUXLHROZ([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x28BB9C0", Offset = "0x28BA7C0", VA = "0x1828BB9C0", Slot = "48")]
		private CircuitsVec3 TQOZUBYGXSF([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28BAB10", Offset = "0x28B9910", VA = "0x1828BAB10", Slot = "49")]
		private CircuitsVec3 HYKWOVOVLWL([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class STLSBPMLPTY : RTBGTVCLZST
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x10FF5A0", Offset = "0x10FE3A0", VA = "0x1810FF5A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xF00F10", Offset = "0xEFFD10", VA = "0x180F00F10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x28C35A0", Offset = "0x28C23A0", VA = "0x1828C35A0")]
		public STLSBPMLPTY(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class XOVURHSBWUK : XBPROGFLAJZ
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(PCKZPCRIQKY e, XAFSJFNWPXV invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly XOVURHSBWUK PKFRARWZTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly GetCircuitsColorFromColorIndexDelegate? GTTAVUETUOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? QIVOGXGPNZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly InvisibleCollisionSetEnabledDelegate? LAPEBYULJES;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xBB0930", Offset = "0xBAF730", VA = "0x180BB0930")]
		public XOVURHSBWUK([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x28C8620", Offset = "0x28C7420", VA = "0x1828C8620", Slot = "4")]
		public CircuitsColor KFEVDPRWSAS(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8600", Offset = "0x28C7400", VA = "0x1828C8600")]
		public int JOPZIMKMYUK([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x28C8600", Offset = "0x28C7400", VA = "0x1828C8600", Slot = "5")]
		private int RCSCPSEOHZB([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class PIBPQTOJCIF : OACLBLMYMPQ
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class JKEXXPMKHPM
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid XZPGMDTWTIC
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xCDB8A0", Offset = "0xCDA6A0", VA = "0x180CDB8A0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long HINRMOZEQXV
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int GAUABDWYGLP
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xAD3AA0", Offset = "0xAD28A0", VA = "0x180AD3AA0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool QZSYWSLHLMA
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x18D90F0", Offset = "0x18D7EF0", VA = "0x1818D90F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool CCLBTXOYAWU
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x18D8C80", Offset = "0x18D7A80", VA = "0x1818D8C80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool ZPULZMDDAIZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x28BCB70", Offset = "0x28BB970", VA = "0x1828BCB70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x28BCB90", Offset = "0x28BB990", VA = "0x1828BCB90")]
			public JKEXXPMKHPM(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<Id128<DERVXWIACXB>, JKEXXPMKHPM> GHJYUYUTTNF;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x28C1EE0", Offset = "0x28C0CE0", VA = "0x1828C1EE0")]
		public bool GWOOAXVBRRE([In] Id128<DERVXWIACXB> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x28C2110", Offset = "0x28C0F10", VA = "0x1828C2110")]
		public void QEKGXNQUDXM([In] Id128<DERVXWIACXB> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x28C21E0", Offset = "0x28C0FE0", VA = "0x1828C21E0")]
		public void QEKGXNQUDXM([In] Id128<DERVXWIACXB> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x28C1FF0", Offset = "0x28C0DF0", VA = "0x1828C1FF0")]
		public void ZMOSZZWLWXR([In] Id128<DERVXWIACXB> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x28C1E80", Offset = "0x28C0C80", VA = "0x1828C1E80")]
		public void LOKYWWQSVPG([In] Id128<DERVXWIACXB> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x28C22C0", Offset = "0x28C10C0", VA = "0x1828C22C0")]
		public bool QZSYWSLHLMA([In] Id128<DERVXWIACXB> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x28C2350", Offset = "0x28C1150", VA = "0x1828C2350")]
		public PIBPQTOJCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x28C1EE0", Offset = "0x28C0CE0", VA = "0x1828C1EE0", Slot = "4")]
		private bool DMJGQFEMSFJ([In] Id128<DERVXWIACXB> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x28C2110", Offset = "0x28C0F10", VA = "0x1828C2110", Slot = "5")]
		private void JOWCBCLCSZV([In] Id128<DERVXWIACXB> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x28C1FF0", Offset = "0x28C0DF0", VA = "0x1828C1FF0", Slot = "6")]
		private void ILVNPMZPTUC([In] Id128<DERVXWIACXB> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x28C1E80", Offset = "0x28C0C80", VA = "0x1828C1E80", Slot = "7")]
		private void AOZBVIRGLMR([In] Id128<DERVXWIACXB> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x28C22C0", Offset = "0x28C10C0", VA = "0x1828C22C0", Slot = "8")]
		private bool UUIHRLEMCDZ([In] Id128<DERVXWIACXB> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class FFBAYLHZOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x28B94E0", Offset = "0x28B82E0", VA = "0x1828B94E0")]
		public static LogDeps TAYUMADERPH()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class DAGIKXQZJZJ : MeshLibrary.WROGKVZRMEZ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "4")]
		public byte[]? JVHUTSWAHVS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void DSATBDEVVRJ(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public DAGIKXQZJZJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class TUXWOACKKYE : WEUMFXGSBZZ
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
		public delegate void ConfigureAttachedObjectDelegate(QMJDXXHRYUN controlPanel, XPWIJZBOGMR staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<RLHROLKKTES> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, WWZNUEBGASM>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, WWZNUEBGASM>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, WWZNUEBGASM>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, WWZNUEBGASM>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<BKAOMLDYVRN>, WWZNUEBGASM>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<BKAOMLDYVRN>, WWZNUEBGASM>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, WWZNUEBGASM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public Task<Result<MultiResult, WWZNUEBGASM>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private TaskAwaiter<Result<MultiResult, WWZNUEBGASM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x28C7520", Offset = "0x28C6320", VA = "0x1828C7520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x28C77E0", Offset = "0x28C65E0", VA = "0x1828C77E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<BKAOMLDYVRN>, WWZNUEBGASM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Task<Result<Id32<BKAOMLDYVRN>, WWZNUEBGASM>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<Result<Id32<BKAOMLDYVRN>, WWZNUEBGASM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x28C7850", Offset = "0x28C6650", VA = "0x1828C7850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x28C7B10", Offset = "0x28C6910", VA = "0x1828C7B10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, WWZNUEBGASM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Task<Result<None, WWZNUEBGASM>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private TaskAwaiter<Result<None, WWZNUEBGASM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x28C7B80", Offset = "0x28C6980", VA = "0x1828C7B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x28C7E40", Offset = "0x28C6C40", VA = "0x1828C7E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Dictionary<string, EnumChoiceData> ZAJNPXHWYWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Dictionary<int, string> FKSZJAZXLQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly List<object> PAPWZENWVDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly List<Guid> EWEOUGEKTTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly CanLocalPlayerCreateCurrencyDelegate XGOUJMPQRWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ShowRoomCurrencyCreationUIDelegate FHYFUZRRBGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipOptionsDelegate MMZZLDYVSYV;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<Guid, int> FNVYPYEQSMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipGuidToIndexMapDelegate UXJNYAMZHIX;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<int, Guid> CWEDYBNOBFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAudioClipIndexToGuidMapDelegate REKEBJKUGLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipOptionsDelegate QMQTKNXKOWQ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<Guid, int> RQCNYWOGOHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate VJOHJDJTKDG;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly IReadOnlyDictionary<int, Guid> KUAMWEASBIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate ARMBXQITEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly PlayAudioPreviewDelegate YQVGAQLSNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly StopAudioPreviewDelegate ZEGOVZYDOZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly SubscriptionIsActiveDelegate LOIYCWCWSQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate IFOSAGZRZSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Dictionary<string, EnumChoiceData> WXDJYGSPDSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly ShowQuickChatEditMenuDelegate OCUJSIGVPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly ConfigureAttachedObjectDelegate YGQUPCVPMKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly DisplayInvalidNameErrorMessageDelegate ZOYGGNEGZHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly IsStringPureDelegate HNSPLKJNDSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly TryGetSpecificChipConfigSummaryDelegate AZRPPHJDJXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReleaseIconIdDelegate SFEFSCXBPVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate YIMRNRXIIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 MBINCDNZUIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 MBNTZKHXDUD;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment FYFSZVZJKNL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool JONHKXFLVZK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xB1DD80", Offset = "0xB1CB80", VA = "0x180B1DD80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> JQHXFMEHQDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> FKSJMZKJHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> JEUOIZXJLGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> TDKPJYQDVZF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAD5FE0", Offset = "0xAD4DE0", VA = "0x180AD5FE0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion GTLELWDXHZH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xDE6EB0", Offset = "0xDE5CB0", VA = "0x180DE6EB0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool TUHHLRCJDTN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xCC6490", Offset = "0xCC5290", VA = "0x180CC6490", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool MBIPTVJPYOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x28C4270", Offset = "0x28C3070", VA = "0x1828C4270", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ZHJYIHUATOV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x28C4880", Offset = "0x28C3680", VA = "0x1828C4880", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool SPGMIUVJFYB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xAC9550", Offset = "0xAC8350", VA = "0x180AC9550", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x28C4A10", Offset = "0x28C3810", VA = "0x1828C4A10")]
		public TUXWOACKKYE([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x28C4710", Offset = "0x28C3510", VA = "0x1828C4710", Slot = "9")]
		public bool XDGTCIVAAVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960")]
		public static bool UGKCULSKNBG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x28C46B0", Offset = "0x28C34B0", VA = "0x1828C46B0", Slot = "10")]
		public bool VLHEKZKUZTB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		public static void DCEJBVATOOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xCCD330", Offset = "0xCCC130", VA = "0x180CCD330", Slot = "11")]
		public void TTTFHNRQQOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x28C43D0", Offset = "0x28C31D0", VA = "0x1828C43D0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> MRWHAVJEQJR(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x28C4400", Offset = "0x28C3200", VA = "0x1828C4400", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NKMKPCBEIAW(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x28C47D0", Offset = "0x28C35D0", VA = "0x1828C47D0")]
		private static IReadOnlyDictionary<Guid, int> XIKPZAQYUMD(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x28C4300", Offset = "0x28C3100", VA = "0x1828C4300", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> IBXAMQATJLM(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x28C45A0", Offset = "0x28C33A0", VA = "0x1828C45A0")]
		private static IReadOnlyDictionary<int, Guid> QPVRYHKVGTZ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x28C3FC0", Offset = "0x28C2DC0", VA = "0x1828C3FC0", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> CACRKAGEHPY(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x28C3F90", Offset = "0x28C2D90", VA = "0x1828C3F90")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BRTBLKLOAYG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x28B0C20", Offset = "0x28AFA20", VA = "0x1828B0C20", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> UOMLRNBISKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x28C42B0", Offset = "0x28C30B0", VA = "0x1828C42B0")]
		private static IReadOnlyDictionary<Guid, int> HGHPUSYNFMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x28C3F30", Offset = "0x28C2D30", VA = "0x1828C3F30", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> ACLWGRICXVV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x28C4820", Offset = "0x28C3620", VA = "0x1828C4820", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> XUOKKTRJRKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void NNFUOMQXEKR(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x28C4050", Offset = "0x28C2E50", VA = "0x1828C4050", Slot = "18")]
		public void DMHCIFYWSIY(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void ZJQBFKPFGUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x28C45F0", Offset = "0x28C33F0", VA = "0x1828C45F0", Slot = "19")]
		public void RMEIEMMMUNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960")]
		private static bool CELVLHYFDTC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x28C4280", Offset = "0x28C3080", VA = "0x1828C4280", Slot = "20")]
		public bool EOXZTFYGXPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960")]
		public static bool UBXXHMVYQAL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x28C4360", Offset = "0x28C3160", VA = "0x1828C4360", Slot = "21")]
		public bool MMINEZOQXUS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x28C46E0", Offset = "0x28C34E0", VA = "0x1828C46E0", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> WTCDYSBKFFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> KHKOBBCEKJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> BRUWMHEMFPX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x28C4850", Offset = "0x28C3650", VA = "0x1828C4850", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> YDDKOJVYQIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> BERXWWXHGLS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> YNADFAGEPEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		public static void JQISKKHEXOW(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x28C4520", Offset = "0x28C3320", VA = "0x1828C4520", Slot = "29")]
		public void ORRVCYQQIWZ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void LCBADWJGFOY(QMJDXXHRYUN a, XPWIJZBOGMR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x28C3F60", Offset = "0x28C2D60", VA = "0x1828C3F60", Slot = "35")]
		public void BHKIPOSIDYT(QMJDXXHRYUN a, XPWIJZBOGMR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "36")]
		public Dictionary<string, EnumChoiceData> WHXBGLQTCDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "37")]
		public Dictionary<string, EnumChoiceData> CCSFKBOGIPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void NBXGBKBMMXK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x28C3FF0", Offset = "0x28C2DF0", VA = "0x1828C3FF0")]
		private static Task<bool> CEOPHWCETIE(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x28C4570", Offset = "0x28C3370", VA = "0x1828C4570", Slot = "38")]
		public Task<bool> QCPBFTVPQWT(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x28C4560", Offset = "0x28C3360", VA = "0x1828C4560")]
		private static bool PVNSAPIAMMC(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x28C4390", Offset = "0x28C3190", VA = "0x1828C4390", Slot = "39")]
		public bool MQTDCUNGOBH(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private static void SOOMKAUECRE(Id32<RLHROLKKTES> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x28C4330", Offset = "0x28C3130", VA = "0x1828C4330", Slot = "40")]
		public void MEQOXPRCNXD(Id32<RLHROLKKTES> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x28C4430", Offset = "0x28C3230", VA = "0x1828C4430")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, WWZNUEBGASM>> ORQSPSAFCWI(Task<Result<None, WWZNUEBGASM>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x28C4620", Offset = "0x28C3420", VA = "0x1828C4620", Slot = "41")]
		public Task<Result<None, WWZNUEBGASM>> TLBROYIMIML(Task<Result<None, WWZNUEBGASM>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x28C4090", Offset = "0x28C2E90", VA = "0x1828C4090")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, WWZNUEBGASM>> DZDCUKYKKKW(Task<Result<MultiResult, WWZNUEBGASM>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x28C4680", Offset = "0x28C3480", VA = "0x1828C4680", Slot = "42")]
		public Task<Result<MultiResult, WWZNUEBGASM>> TLBROYIMIML(Task<Result<MultiResult, WWZNUEBGASM>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x28C4180", Offset = "0x28C2F80", VA = "0x1828C4180")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<BKAOMLDYVRN>, WWZNUEBGASM>> DZIJRRSHTWF(Task<Result<Id32<BKAOMLDYVRN>, WWZNUEBGASM>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x28C4650", Offset = "0x28C3450", VA = "0x1828C4650", Slot = "43")]
		public Task<Result<Id32<BKAOMLDYVRN>, WWZNUEBGASM>> TLBROYIMIML(Task<Result<Id32<BKAOMLDYVRN>, WWZNUEBGASM>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class FWWDVKHHOOT : XWEZHVPWKRM
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(SIFIYGRIVBJ e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? AUYPIRAUMYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly InteropDelegate YYOKKSTMDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly InteropDelegate QKGIQUXHTRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private InteropDelegate? RPDDMQRZEOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private InvokeStudioFunctionDelegate? BLZYBVPSKMV;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "5")]
		public LegacyCV2Result<None> OJRXGMOVRLX(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00")]
		private static LegacyCV2Result<None> Default(SIFIYGRIVBJ _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "6")]
		public LegacyCV2Result<None> PSQQOPVJEPK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "7")]
		public LegacyCV2Result<None> FFRMCYWPZQV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "8")]
		public LegacyCV2Result<None> MBMLWYGEAYA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "9")]
		public LegacyCV2Result<None> PRWUMHCIDFG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "15")]
		public LegacyCV2Result<None> RKXTAFKHEYN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PSVXKUJOIFJ(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NTTYRESAKWJ(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BBFNRIOZWYK(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GSMACQTZQZV(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EOTBFSKHCRS(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MQYXLUDZQFY(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AKONLPWRGMF(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "93")]
		public LegacyCV2Result<None> DSCFAQEQMCQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "94")]
		public LegacyCV2Result<None> VQQXXQISXBQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "95")]
		public LegacyCV2Result<None> DTAZBOLQUKH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VMEKVUUSPCT(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(SIFIYGRIVBJ e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MFXDGINAOPT(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TLCISFUSFRP(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MLIQVQBDHSO(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XKCIZZLEWGH(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RBYJCSOCDOK(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LGHKDNZGNKU(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BUGTIOKADEE(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MJBKHMYVEZX(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1300B50", Offset = "0x12FF950", VA = "0x181300B50", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LCZZEAOGUPC(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FCVRLCYYKCP(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "119")]
		public LegacyCV2Result<None> FLUBBXHASSL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VJKZZZKHOQA(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "121")]
		public LegacyCV2Result<None> EDPAQBWPZKU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "122")]
		public LegacyCV2Result<None> KYDCISKMRIU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "123")]
		public LegacyCV2Result<None> NQVOIZCIMSA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "124")]
		public LegacyCV2Result<None> BNXBYLIMNDS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "125")]
		public LegacyCV2Result<None> NIETRWDOKYS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "126")]
		public LegacyCV2Result<None> TYDLIDAXJTJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "818")]
		public LegacyCV2Result<None> TJDBRBTNJWR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "819")]
		public LegacyCV2Result<None> NUIQKPWNLDX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "147")]
		public LegacyCV2Result<None> VHXKDLHBEAD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "148")]
		public LegacyCV2Result<None> MYBOAVYRUAP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "149")]
		public LegacyCV2Result<None> QEXYXRSOUOC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "150")]
		public LegacyCV2Result<None> WUDOCMLIBAG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "151")]
		public LegacyCV2Result<None> NXKWTWKQGFN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(SIFIYGRIVBJ e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(SIFIYGRIVBJ e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(SIFIYGRIVBJ e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, XWEZHVPWKRM.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(SIFIYGRIVBJ e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, XWEZHVPWKRM.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "174")]
		public LegacyCV2Result<None> GOPNMVWWFYC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "175")]
		public LegacyCV2Result<None> WIALJIXUTJJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "176")]
		public LegacyCV2Result<None> NJXVCTTCOFJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "197")]
		public LegacyCV2Result<None> BJRIOOEACRT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "198")]
		public LegacyCV2Result<None> RSETYANRPVS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "199")]
		public LegacyCV2Result<None> EYDTBZCCVUL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "200")]
		public LegacyCV2Result<None> RMUYDPEINFJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "201")]
		public LegacyCV2Result<None> CNSLCMSDHVL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "202")]
		public LegacyCV2Result<None> ZGMRDOSODFO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "203")]
		public LegacyCV2Result<None> TESAHTKNGSC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "204")]
		public LegacyCV2Result<None> HJASHDDEYTE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "205")]
		public LegacyCV2Result<None> WZAEMSCJNIK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "206")]
		public LegacyCV2Result<None> JJIQORVIYAK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "207")]
		public LegacyCV2Result<None> AYVRJWFLXWO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "208")]
		public LegacyCV2Result<None> PYDUYOEASFQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "209")]
		public LegacyCV2Result<None> LGRTMGANREC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "210")]
		public LegacyCV2Result<None> VHBNXKCACKB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "211")]
		public LegacyCV2Result<None> WRVPUSFUUFG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "212")]
		public LegacyCV2Result<None> EZORXYYBURP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "213")]
		public LegacyCV2Result<None> DRGRDVVPZYO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "214")]
		public LegacyCV2Result<None> GYDKXDCHIDF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "215")]
		public LegacyCV2Result<None> VJVSPXAWQVQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "274")]
		public LegacyCV2Result<None> IISNNMBQXLQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "277")]
		public LegacyCV2Result<None> LAXCUKZQQHS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "279")]
		public LegacyCV2Result<None> NSMXVKLYEZX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "280")]
		public LegacyCV2Result<None> QOBQYURQVVV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "281")]
		public LegacyCV2Result<None> ZGQRLUBJEQQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "282")]
		public LegacyCV2Result<None> DDFOEGJSVYZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "283")]
		public LegacyCV2Result<None> HMBTUTZJXKY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "287")]
		public LegacyCV2Result<None> FBWPZHDWNMN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "288")]
		public LegacyCV2Result<None> MRVUIASPBYU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "317")]
		public LegacyCV2Result<None> UAAFBCKQQSR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "406")]
		public LegacyCV2Result<None> VWTXVJWNTJG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UMEFDKZJEDR(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AFZUVJYPOKT(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DSENLNGYVJT(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IGSAHOYBRBI(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KCVAYLAVVER(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "416")]
		public LegacyCV2Result<XSKDQTRUCQJ.CV2DiscoverySectionType> VILTLYIBVLI(SIFIYGRIVBJ e, CircuitSignal a)
		{
			return default(LegacyCV2Result<XSKDQTRUCQJ.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "417")]
		public LegacyCV2Result<None> LCAHLQMSJQO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(SIFIYGRIVBJ e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OLPZEOCRRZQ(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DICRAYIMVMJ(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LDKSBKJOVBU(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "462")]
		public LegacyCV2Result<None> IHAMNJMLVEZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "463")]
		public LegacyCV2Result<None> NFHEOFPIJOI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "464")]
		public LegacyCV2Result<None> VQPFIXTRVOX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "465")]
		public LegacyCV2Result<None> ANZXUSKFYMG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "466")]
		public LegacyCV2Result<None> SABFEOTXUVW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "467")]
		public LegacyCV2Result<None> KNPDQQVNKAE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "468")]
		public LegacyCV2Result<None> QAVBKGFVOXZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "469")]
		public LegacyCV2Result<None> YHSVDBUYWNL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "474")]
		public LegacyCV2Result<None> IBOEWZIHEUN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "475")]
		public LegacyCV2Result<None> AGADQQZQJTB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "476")]
		public LegacyCV2Result<None> NHYOBHZRQPS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "477")]
		public LegacyCV2Result<None> OEWAVDKHTZT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "478")]
		public LegacyCV2Result<None> AYGTAQFYMKD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "479")]
		public LegacyCV2Result<None> WYWLXKRCKFC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(SIFIYGRIVBJ executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(SIFIYGRIVBJ executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "472")]
		public LegacyCV2Result<None> FQYLBAMNIVW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "473")]
		public LegacyCV2Result<None> GBIJRNAFWRC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "480")]
		public LegacyCV2Result<None> CKJXOFYXDNI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "481")]
		public LegacyCV2Result<None> QWXRJJDKMBW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "482")]
		public LegacyCV2Result<None> VDNJFMNGECR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "483")]
		public LegacyCV2Result<None> JEIDSQPURAH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "484")]
		public LegacyCV2Result<None> AVEIRQAXMSP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "485")]
		public LegacyCV2Result<None> ZBRDBAZWMKF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "486")]
		public LegacyCV2Result<None> AEFZPDBAZIH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "487")]
		public LegacyCV2Result<None> DLQOJKYQOHX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "488")]
		public LegacyCV2Result<None> NOWPQDGKXNB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "489")]
		public LegacyCV2Result<None> VFFTCMPHYHR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "490")]
		public LegacyCV2Result<None> DTJBSAIPFZL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "491")]
		public LegacyCV2Result<None> JYDRWFWSVGP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "492")]
		public LegacyCV2Result<None> HMXGVVRAZWN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "493")]
		public LegacyCV2Result<None> YSMKZXATMVB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "494")]
		public LegacyCV2Result<None> RGIMXRXJSGD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "495")]
		public LegacyCV2Result<None> QQUHSYFKWDD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "496")]
		public LegacyCV2Result<None> KHBHAIZZVFP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "497")]
		public LegacyCV2Result<None> FBNYODMGGPL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "498")]
		public LegacyCV2Result<None> MUAEPWGPGIZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "499")]
		public LegacyCV2Result<None> OZCHIHHQASH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x28B9A60", Offset = "0x28B8860", VA = "0x1828B9A60", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "507")]
		public LegacyCV2Result<None> FGYDSVHHEXJ(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "508")]
		public LegacyCV2Result<None> FOZNZRTNCKN(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "509")]
		public LegacyCV2Result<None> KERSHYCBNTT(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "510")]
		public LegacyCV2Result<None> NMKEDPJRLTS(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(SIFIYGRIVBJ e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(SIFIYGRIVBJ e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(SIFIYGRIVBJ e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.KWNAWYMQBXT> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "522")]
		public LegacyCV2Result<None> ZSRGXVGGJFK(SIFIYGRIVBJ e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "525")]
		public LegacyCV2Result<None> IJMXARLELZG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "527")]
		public LegacyCV2Result<None> XHTMKLNDLBD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "528")]
		public LegacyCV2Result<None> NEPLMPIKQIT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "530")]
		public LegacyCV2Result<None> RPLYBSLCORF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "531")]
		public LegacyCV2Result<None> CJTFLPIZWZM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x28B99D0", Offset = "0x28B87D0", VA = "0x1828B99D0", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "533")]
		public LegacyCV2Result<None> FXCRDGLWWOQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x28B9AA0", Offset = "0x28B88A0", VA = "0x1828B9AA0", Slot = "535")]
		public LegacyCV2Result<None> YJRXYQSLCFQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "534")]
		public LegacyCV2Result<None> QFRIHXPQOCT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "536")]
		public LegacyCV2Result<None> AKXOBXUSDPX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "537")]
		public LegacyCV2Result<None> KJPGUUCVJNQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "538")]
		public LegacyCV2Result<None> GEOQGBINCSY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "539")]
		public LegacyCV2Result<None> GFYUGTEMJAE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "540")]
		public LegacyCV2Result<None> XDWFGHRUOGS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "583")]
		public LegacyCV2Result<None> Raycast(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "584")]
		public LegacyCV2Result<None> BHVNDGKSDVJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "587")]
		public LegacyCV2Result<None> XDLUWLGNCKS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "591")]
		public LegacyCV2Result<None> SXGXQJXYBZL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "592")]
		public LegacyCV2Result<None> SFLBLVHRMNE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "641")]
		public LegacyCV2Result<None> MAHHOMKCZKX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "642")]
		public LegacyCV2Result<None> FLDHCPTUEKH(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "643")]
		public LegacyCV2Result<None> TBIGQHUGVIW(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "644")]
		public LegacyCV2Result<None> UFUPPAMENXD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "645")]
		public LegacyCV2Result<None> NNGYONWKOZP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "646")]
		public LegacyCV2Result<None> UXHXEVKTYPA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "649")]
		public LegacyCV2Result<None> PYZTLYMHRHP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "650")]
		public LegacyCV2Result<None> PDNUWVUQUMN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "651")]
		public LegacyCV2Result<None> QXCBCFNEIQS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "661")]
		public LegacyCV2Result<None> IBORYTBJERX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "660")]
		public LegacyCV2Result<None> WKBJSGEMBDO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "662")]
		public LegacyCV2Result<None> KSRXZCLJMGX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "663")]
		public LegacyCV2Result<None> VKITVQFLPOK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "670")]
		public LegacyCV2Result<None> YHRJWDCWQIB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "671")]
		public LegacyCV2Result<None> VPQMLQXWKBG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "674")]
		public LegacyCV2Result<None> GOQLHLVWQHA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "675")]
		public LegacyCV2Result<None> SWOFQWLXLUJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(SIFIYGRIVBJ e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "696")]
		public LegacyCV2Result<None> SGMZUIHIRWX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "697")]
		public LegacyCV2Result<None> RDLNVSYFDHP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "698")]
		public LegacyCV2Result<None> AGJVDOEFUFV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "699")]
		public LegacyCV2Result<None> ALSHOKKGHZK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "700")]
		public LegacyCV2Result<None> DYRKZMVWRJY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "676")]
		public LegacyCV2Result<None> PXEOHRKPXKZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "677")]
		public LegacyCV2Result<None> RSZCZSALJHB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "678")]
		public LegacyCV2Result<None> FOWVPLUJVSS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "679")]
		public LegacyCV2Result<None> SUUZGQCWXEP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "680")]
		public LegacyCV2Result<None> DXXSDVDSMIE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "681")]
		public LegacyCV2Result<None> VIMBORXJSMF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "682")]
		public LegacyCV2Result<None> KBZCVNVUKBR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "683")]
		public LegacyCV2Result<None> LTGKURQAIFU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "684")]
		public LegacyCV2Result<None> DEIWLRRBLAI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "685")]
		public LegacyCV2Result<None> ERYUZFLMXTZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "686")]
		public LegacyCV2Result<None> BDMILAMNRIH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "687")]
		public LegacyCV2Result<None> JWMFGZBDSMO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "688")]
		public LegacyCV2Result<None> VJFBYGOHBDH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "689")]
		public LegacyCV2Result<None> VXUPPXATADL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "690")]
		public LegacyCV2Result<None> DXDWSNGSBOC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "691")]
		public LegacyCV2Result<None> PCUWIKSDFGI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "692")]
		public LegacyCV2Result<None> AVMFWXXCQGK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "693")]
		public LegacyCV2Result<None> TABQRTASBUF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "765")]
		public LegacyCV2Result<None> ENYSCUBSWBJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "711")]
		public LegacyCV2Result<None> GMJMSYBBEWM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "712")]
		public LegacyCV2Result<None> UZOIYBZAULW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "713")]
		public LegacyCV2Result<None> VYVATKVHFLA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "714")]
		public LegacyCV2Result<None> CJSVSBXAESI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "717")]
		public LegacyCV2Result<None> TLOZNDTYCOG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "721")]
		public LegacyCV2Result<None> HLJZGCRTHBJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "722")]
		public LegacyCV2Result<None> OJHMWZRTNVP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "723")]
		public LegacyCV2Result<None> YMZRYQIYZGQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "724")]
		public LegacyCV2Result<None> GSYRXAZOVRG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "725")]
		public LegacyCV2Result<None> IYLNAYZWRJK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "726")]
		public LegacyCV2Result<None> HOFZMGSYUTN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "727")]
		public LegacyCV2Result<None> WXOJNFKSRNY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "728")]
		public LegacyCV2Result<None> CCMBSVNBCZL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "729")]
		public LegacyCV2Result<None> ZKZPHCZIIPV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "730")]
		public LegacyCV2Result<None> OZPTQFOCQUR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "731")]
		public LegacyCV2Result<None> NEPOOOBEMYR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "732")]
		public LegacyCV2Result<None> YNJPSUJRSHF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "733")]
		public LegacyCV2Result<None> EPMVABQLVWX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "734")]
		public LegacyCV2Result<None> LVZCOAIXCMK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "735")]
		public LegacyCV2Result<None> LWENJXXSIRZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "736")]
		public LegacyCV2Result<None> FCGYZRLMPTL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "737")]
		public LegacyCV2Result<None> OQOXRCZQTAQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "738")]
		public LegacyCV2Result<None> WFNBMHXFRUT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "740")]
		public LegacyCV2Result<None> FOHTDJGNPHP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "739")]
		public LegacyCV2Result<None> BVKASIAVEUN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "741")]
		public LegacyCV2Result<None> MLGIVTRFEEU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "742")]
		public LegacyCV2Result<None> CZUVKDKSKFR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "743")]
		public LegacyCV2Result<None> ZQLTRRURZMA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "744")]
		public LegacyCV2Result<None> ZOOUVUOJHXM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "745")]
		public LegacyCV2Result<None> NOENPARGZCZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "746")]
		public LegacyCV2Result<None> WWDUBHTMJFG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "747")]
		public LegacyCV2Result<None> XSCSSLIOEUM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "748")]
		public LegacyCV2Result<None> LXGKPVOTKAH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "749")]
		public LegacyCV2Result<None> JZNRZLSQLBX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "750")]
		public LegacyCV2Result<None> CYYSABCYRCJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "751")]
		public LegacyCV2Result<None> BDVPUQATDXZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "752")]
		public LegacyCV2Result<None> XTSCYUFXRPV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "753")]
		public LegacyCV2Result<None> YWRGPPAOQAX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "754")]
		public LegacyCV2Result<None> KNJOGVPDVGT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "755")]
		public LegacyCV2Result<None> NAAQYOOTERU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "756")]
		public LegacyCV2Result<None> OXJVAMHUFYE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "757")]
		public LegacyCV2Result<None> RRGGQZWYNNC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "758")]
		public LegacyCV2Result<None> OTCDAQPJIAU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "759")]
		public LegacyCV2Result<None> QRJQGUXPTFN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "760")]
		public LegacyCV2Result<None> RGELSFNCWDP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "761")]
		public LegacyCV2Result<None> ZPINLBJLGTZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "762")]
		public LegacyCV2Result<None> WJRUDFIHWJS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "763")]
		public LegacyCV2Result<None> VGGKACMKUQS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "764")]
		public LegacyCV2Result<None> WHMPAHIRJVR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "771")]
		public LegacyCV2Result<None> RVUYJOQVRIZ(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "772")]
		public LegacyCV2Result<None> LHJZJRCNZKD(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "773")]
		public LegacyCV2Result<None> YGUWPUJXALO(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(SIFIYGRIVBJ ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "775")]
		public LegacyCV2Result<None> ULBHOODUZHM(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "776")]
		public LegacyCV2Result<None> UZHGZDYTPXA(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "777")]
		public LegacyCV2Result<None> EAZGDXPMZWV(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "778")]
		public LegacyCV2Result<None> ISVYPBRAGJZ(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "779")]
		public LegacyCV2Result<None> SRHDTDYEFHN(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "707")]
		public LegacyCV2Result<None> IYAKPIVDNYF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "801")]
		public LegacyCV2Result<None> EBVVAOQEWNZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "802")]
		public LegacyCV2Result<None> GLRSDCMQJAT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "803")]
		public LegacyCV2Result<None> APOMFFMSSZX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "804")]
		public LegacyCV2Result<None> SJSKSXEHYQB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "805")]
		public LegacyCV2Result<None> MUPUKIBAGTF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "806")]
		public LegacyCV2Result<None> BZYUNAXHOJV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "807")]
		public LegacyCV2Result<None> MAJFGTYLOZX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "808")]
		public LegacyCV2Result<None> MWTEVLYRSIB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "809")]
		public LegacyCV2Result<None> BCMLRJLRZZV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "810")]
		public LegacyCV2Result<None> NQFTKAIRHMB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "811")]
		public LegacyCV2Result<None> QWXGQEHZHHX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "812")]
		public LegacyCV2Result<None> IEPBZYOENAK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "817")]
		public LegacyCV2Result<None> BKLYPFZTFMF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "821")]
		public LegacyCV2Result<None> PMQUPJYCZNQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "822")]
		public LegacyCV2Result<None> FFYDIZEQTKC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "823")]
		public LegacyCV2Result<None> RHINFKTQHKY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "824")]
		public LegacyCV2Result<None> BAXFIZKIVLS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "826")]
		public LegacyCV2Result<None> RWKDCUCJZQY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "827")]
		public LegacyCV2Result<None> FZMIQDHVXQD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "828")]
		public LegacyCV2Result<None> YZOMCBBOAWB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "831")]
		public LegacyCV2Result<None> WITBQFEDQTN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "832")]
		public LegacyCV2Result<None> MKOPTOPIKIY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "833")]
		public LegacyCV2Result<None> QHFAVKKGUKH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(SIFIYGRIVBJ e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(SIFIYGRIVBJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "836")]
		public LegacyCV2Result<None> LXJFQQOHVDI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MELVFLHZUMM(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SCPZSSBYGRI(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PGDEMMQXXGV(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FRDVSETUABY(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TNXRLMPLXXJ(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(SIFIYGRIVBJ e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(SIFIYGRIVBJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(SIFIYGRIVBJ e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(SIFIYGRIVBJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(SIFIYGRIVBJ e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(SIFIYGRIVBJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(SIFIYGRIVBJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "856")]
		public LegacyCV2Result<None> KQDKKNVVITQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "859")]
		public LegacyCV2Result<None> ECOCERGZDPI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "860")]
		public LegacyCV2Result<None> PESXHDZLYSM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "861")]
		public LegacyCV2Result<None> UPHNJOGLSSA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "862")]
		public LegacyCV2Result<None> YNTCWVDOZMZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "864")]
		public LegacyCV2Result<None> IWUTEUXLSYK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "865")]
		public LegacyCV2Result<None> ZENECEDTTPK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(SIFIYGRIVBJ e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "869")]
		public LegacyCV2Result<None> FNADWIXJHBW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "879")]
		public LegacyCV2Result<None> JERMJPJKIMO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "880")]
		public LegacyCV2Result<None> BLAZKJEMWCE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "881")]
		public LegacyCV2Result<None> ERBKJRSBKIR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "882")]
		public LegacyCV2Result<None> DOCVOSPFDMA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(SIFIYGRIVBJ e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(SIFIYGRIVBJ e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(SIFIYGRIVBJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(SIFIYGRIVBJ e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(SIFIYGRIVBJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "889")]
		public LegacyCV2Result<None> KPLVYHVHSDG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "890")]
		public LegacyCV2Result<None> MXLFPZHFTZB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "891")]
		public LegacyCV2Result<None> VVISFIYLIBQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "892")]
		public LegacyCV2Result<None> HIFWAAFKFBY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "893")]
		public LegacyCV2Result<None> YGGYJCHEYOU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "897")]
		public LegacyCV2Result<None> KPUVIOXIRAV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "898")]
		public LegacyCV2Result<None> OZUBXDBVXZP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "899")]
		public LegacyCV2Result<None> OKUFEGCBVKU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "901")]
		public LegacyCV2Result<None> LXKFOKUBMUY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "900")]
		public LegacyCV2Result<None> OLQRTVGDXVO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "902")]
		public LegacyCV2Result<None> QNVTQTKYOJP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "904")]
		public LegacyCV2Result<None> ZFVHQQBNLZX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "903")]
		public LegacyCV2Result<None> LRAQTITTZXV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "905")]
		public LegacyCV2Result<None> OEZPRLLVSSE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "906")]
		public LegacyCV2Result<None> JCNUOJJDJDC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "907")]
		public LegacyCV2Result<None> IDHCNVAENCN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "908")]
		public LegacyCV2Result<None> DXGKOEAJZJJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "909")]
		public LegacyCV2Result<None> IKBRIJZHGLR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "910")]
		public LegacyCV2Result<None> XWRAUTVETBF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "911")]
		public LegacyCV2Result<None> EGWPTBSXXCP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "918")]
		public LegacyCV2Result<None> SMLKRTFUXEV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "919")]
		public LegacyCV2Result<None> CEMHJOKVJNL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(SIFIYGRIVBJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(SIFIYGRIVBJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(SIFIYGRIVBJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(SIFIYGRIVBJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(SIFIYGRIVBJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(SIFIYGRIVBJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(SIFIYGRIVBJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(SIFIYGRIVBJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(SIFIYGRIVBJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "941")]
		public LegacyCV2Result<None> VSSPYDEHAAT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "942")]
		public LegacyCV2Result<None> FROPJIYOFTJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "943")]
		public LegacyCV2Result<None> YOYHVKOPAGM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "944")]
		public LegacyCV2Result<None> VIQWUFOIJLY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "945")]
		public LegacyCV2Result<None> KETTVJRSJIZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "946")]
		public LegacyCV2Result<None> EEWUQXJVOOT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "947")]
		public LegacyCV2Result<None> FADIEXKQILA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "948")]
		public LegacyCV2Result<None> GVWSGJQKQZY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "949")]
		public LegacyCV2Result<None> FFDMBDBMJAS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "950")]
		public LegacyCV2Result<None> ZJDGCHXUKHP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "968")]
		public LegacyCV2Result<None> BUISEUCPYFD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "967")]
		public LegacyCV2Result<None> WFYWZEXUKNI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "969")]
		public LegacyCV2Result<None> MLPCXCHJLJS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "970")]
		public LegacyCV2Result<None> ZJEPQRDNHQV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "971")]
		public LegacyCV2Result<None> LALSPHLNNGG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "972")]
		public LegacyCV2Result<None> JRXLAKDAUEI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "973")]
		public LegacyCV2Result<None> UETJZTZNRWB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "975")]
		public LegacyCV2Result<None> WKMQACWNMQW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "982")]
		public LegacyCV2Result<None> LUCXIJWPZXD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "983")]
		public LegacyCV2Result<None> CFXZMKBNKNF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "991")]
		public LegacyCV2Result<None> NAPCUCOMCGS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "993")]
		public LegacyCV2Result<None> GASRGHFNKBU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "994")]
		public LegacyCV2Result<None> TTJJYMAEBXM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "995")]
		public LegacyCV2Result<None> QODGSSYUNOI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "996")]
		public LegacyCV2Result<None> FKLXGHBFHHW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "997")]
		public LegacyCV2Result<None> WHWRQWKECAG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "998")]
		public LegacyCV2Result<None> ECGPETOSQDU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "999")]
		public LegacyCV2Result<None> UCUJFEGNRFG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1000")]
		public LegacyCV2Result<None> PMOKCIMZIYA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1001")]
		public LegacyCV2Result<None> KBJMGEARGGU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1002")]
		public LegacyCV2Result<None> DTHKJVAPHWM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1009")]
		public LegacyCV2Result<None> MNIXCDIZCZU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1017")]
		public LegacyCV2Result<None> WGCQZYEZNVH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1018")]
		public LegacyCV2Result<None> UZYDDTQZQMI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1019")]
		public LegacyCV2Result<None> NJLFVHXGVYV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1020")]
		public LegacyCV2Result<None> PYVYCXMJSIU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1021")]
		public LegacyCV2Result<None> ITSFVUUFVEZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1022")]
		public LegacyCV2Result<None> ZJBXGJFFKEO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1023")]
		public LegacyCV2Result<None> JPRPGQWOHQT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1024")]
		public LegacyCV2Result<None> BRSRHJLEPLZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1025")]
		public LegacyCV2Result<None> JUANVFDEUMG(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1026")]
		public LegacyCV2Result<None> DXHOPVTUTOR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1027")]
		public LegacyCV2Result<None> KLNUIQEAFUF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1028")]
		public LegacyCV2Result<None> LOSYRPEMHES(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1029")]
		public LegacyCV2Result<None> TRXPZFCVILI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1030")]
		public LegacyCV2Result<None> YSFLVNLBMEN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1031")]
		public LegacyCV2Result<None> STCSCEFVQUS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1032")]
		public LegacyCV2Result<None> RUORVSJLUUJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1033")]
		public LegacyCV2Result<None> ZEIMIYYDYWN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1047")]
		public LegacyCV2Result<None> SWKNOEXUOJR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1048")]
		public LegacyCV2Result<None> UKBVJCNUCFN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1049")]
		public LegacyCV2Result<None> HLWENIZHWKP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1050")]
		public LegacyCV2Result<None> MVOCMMFRHDV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1051")]
		public LegacyCV2Result<None> JWPZAEOLXKE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1052")]
		public LegacyCV2Result<None> JYIYTWFDHBS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1053")]
		public LegacyCV2Result<None> QZTELPYYSJV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1054")]
		public LegacyCV2Result<None> IUWWZNGOYMO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1055")]
		public LegacyCV2Result<None> ZRHPQHJDWLT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1056")]
		public LegacyCV2Result<None> BTEDUAHFLMC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1057")]
		public LegacyCV2Result<None> ZZEGNZMKUHU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1058")]
		public LegacyCV2Result<None> XURITGOIPAH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1059")]
		public LegacyCV2Result<None> ZMTLMJEJLRM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1060")]
		public LegacyCV2Result<None> ZHTBMIOXEKY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1061")]
		public LegacyCV2Result<None> BXTGZPQHQPC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1062")]
		public LegacyCV2Result<None> CMDJZILTYUY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1063")]
		public LegacyCV2Result<None> ARQMPHFHSZC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1064")]
		public LegacyCV2Result<None> BYWVGUIVJLD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1065")]
		public LegacyCV2Result<None> FMSFBENGQGV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1066")]
		public LegacyCV2Result<None> AGILEERTUBM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1067")]
		public LegacyCV2Result<None> XQGVDKVFMFY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1068")]
		public LegacyCV2Result<None> CUTJMGXDFJO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1069")]
		public LegacyCV2Result<None> XMQZGPDCXTW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1070")]
		public LegacyCV2Result<None> LEISXWTLSKR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1071")]
		public LegacyCV2Result<None> ILJITIYZYMJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x28B9A10", Offset = "0x28B8810", VA = "0x1828B9A10", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(SIFIYGRIVBJ e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(SIFIYGRIVBJ e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1092")]
		public LegacyCV2Result<None> QYTSRDLKDYE(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1093")]
		public LegacyCV2Result<None> AFUNDIBJCOL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1094")]
		public LegacyCV2Result<None> KRAEWKBONVV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1095")]
		public LegacyCV2Result<None> HFTHMMCIDAP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1096")]
		public LegacyCV2Result<None> IEMOLPYLWPR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1097")]
		public LegacyCV2Result<None> CUPKIVKHWZD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1098")]
		public LegacyCV2Result<None> PWNOCJABTIF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1099")]
		public LegacyCV2Result<None> MMOAASVWKDT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1100")]
		public LegacyCV2Result<None> ZFHFRMZZWKB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1101")]
		public LegacyCV2Result<None> YYWOSAYKMOF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1102")]
		public LegacyCV2Result<None> MFWJYMGGZXT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1103")]
		public LegacyCV2Result<None> GUTTFGSMRRM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1104")]
		public LegacyCV2Result<None> QECVNLWCBUK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1105")]
		public LegacyCV2Result<None> LPXKKTLIZJU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1106")]
		public LegacyCV2Result<None> NKWSEGJOFYS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1107")]
		public LegacyCV2Result<None> SZOSXCFPFAZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1108")]
		public LegacyCV2Result<None> NRYDDMRRAXL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1109")]
		public LegacyCV2Result<None> PEBCMIVYAVS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1110")]
		public LegacyCV2Result<None> WKNFVJHRKUA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1111")]
		public LegacyCV2Result<None> EPUUEXATMIY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1112")]
		public LegacyCV2Result<None> RDLQUFXYCKI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1113")]
		public LegacyCV2Result<None> ZYYJTDSSHAB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1114")]
		public LegacyCV2Result<None> RLJJGXDTPUN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1115")]
		public LegacyCV2Result<None> TDQKEUTSEPC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1116")]
		public LegacyCV2Result<None> OWWOCSPGJKU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1117")]
		public LegacyCV2Result<None> XGYFMTLJRRS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1118")]
		public LegacyCV2Result<None> MVECNNORHAY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1119")]
		public LegacyCV2Result<None> CLQTVZPKDMZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1120")]
		public LegacyCV2Result<None> LNZQXVKYWVQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1121")]
		public LegacyCV2Result<None> GNXOSDHIEFM(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1122")]
		public LegacyCV2Result<None> EXYFUTFENOC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1123")]
		public LegacyCV2Result<None> FTQKZNNPOPP(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1124")]
		public LegacyCV2Result<None> UWEBJKYBECN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1125")]
		public LegacyCV2Result<None> ONAFRSYKGJX(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1126")]
		public LegacyCV2Result<None> FXEAABBZMTH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1127")]
		public LegacyCV2Result<None> TFOJBMWQPAF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1128")]
		public LegacyCV2Result<None> PGTCDNTYGXX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1129")]
		public LegacyCV2Result<None> FPNAYZVQRDF(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1130")]
		public LegacyCV2Result<None> EOSNYCVEHUM(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1131")]
		public LegacyCV2Result<None> LTXYZZPHIXP(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1132")]
		public LegacyCV2Result<None> AAWSZUWTSXO(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1133")]
		public LegacyCV2Result<None> UAOPHWNDMQB(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1134")]
		public LegacyCV2Result<None> PVELSTGEGPX(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1135")]
		public LegacyCV2Result<None> RHHBKTSTWGS(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1136")]
		public LegacyCV2Result<None> ZWFIBESIXBI(PCKZPCRIQKY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1140")]
		public LegacyCV2Result<None> IWDQXAOJWFY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1166")]
		public LegacyCV2Result<None> GEMDJTONELS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1168")]
		public LegacyCV2Result<None> ZEKKVKNBAKK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1169")]
		public LegacyCV2Result<None> GQBFFXSWJXH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1170")]
		public LegacyCV2Result<None> EMCWADQSHPW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1171")]
		public LegacyCV2Result<None> NEZSKMHNIIR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1182")]
		public LegacyCV2Result<None> SSSTSQSPGGF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1183")]
		public LegacyCV2Result<None> FAYNJGDNMDF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1184")]
		public LegacyCV2Result<None> ZJAPJYXYGAL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1185")]
		public LegacyCV2Result<None> MMVDPMXHNMZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1186")]
		public LegacyCV2Result<None> HKRBEXLHWVQ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1187")]
		public LegacyCV2Result<None> YSVTATQOLXY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1188")]
		public LegacyCV2Result<None> CUOLFRWZDTS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1189")]
		public LegacyCV2Result<None> CFCYPJGMFYA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1190")]
		public LegacyCV2Result<None> MFZFPSVXMAX(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1191")]
		public LegacyCV2Result<None> CPPKRYPXLST(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1192")]
		public LegacyCV2Result<None> GRJULFUDFAA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1193")]
		public LegacyCV2Result<None> CVOFJVINOPP(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "184")]
		public LegacyCV2Result<None> CYCQWRQMACB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x28B9A50", Offset = "0x28B8850", VA = "0x1828B9A50", Slot = "191")]
		public bool MYBFGOWTVYT(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1194")]
		public LegacyCV2Result<None> ETYOCROTDWR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1195")]
		public LegacyCV2Result<None> EUTWHOBWFXW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1196")]
		public LegacyCV2Result<None> FJQKSZCKJJZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(SIFIYGRIVBJ e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1205")]
		public LegacyCV2Result<None> LSXIIZIYIKA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1206")]
		public LegacyCV2Result<None> WSNLKGXWLNK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(SIFIYGRIVBJ e, InOut io, JYWESBHDHUQ objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "250")]
		public LegacyCV2Result<None> AOPHBFGATQF(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "251")]
		public LegacyCV2Result<None> MVULQSCPXRJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "252")]
		public LegacyCV2Result<None> RDUQSSUZVIH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "254")]
		public LegacyCV2Result<None> EPDKNNOLDSA(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "255")]
		public LegacyCV2Result<None> JRRYELAETXS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "256")]
		public LegacyCV2Result<None> UMPJXVOOLDW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "257")]
		public LegacyCV2Result<None> OIPTCGAIHPB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "258")]
		public LegacyCV2Result<None> OFFMVJMFIFN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "259")]
		public LegacyCV2Result<None> AWIINKTFLHS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "260")]
		public LegacyCV2Result<None> UEJGDWDANYU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "261")]
		public LegacyCV2Result<None> CJJCVGGZMIK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "262")]
		public LegacyCV2Result<None> NHAEJEMGWXY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "263")]
		public LegacyCV2Result<None> GZRRCXJVDGZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "264")]
		public LegacyCV2Result<None> YYTHDEBTGJD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "265")]
		public LegacyCV2Result<None> MVFUKFACRNJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "266")]
		public LegacyCV2Result<None> MXNERQSGVHR(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "267")]
		public LegacyCV2Result<None> IEGIQAQIDRB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "268")]
		public LegacyCV2Result<None> BDXRUTRXLVT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "269")]
		public LegacyCV2Result<None> OSDYJKPRBBH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00")]
		private static LegacyCV2Result<None> Default(SIFIYGRIVBJ e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x28B9940", Offset = "0x28B8740", VA = "0x1828B9940", Slot = "1209")]
		public LegacyCV2Result<None> EKUKFBWPTNM(SIFIYGRIVBJ a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1212")]
		public LegacyCV2Result<None> CUSZJGTCSDT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1213")]
		public LegacyCV2Result<None> GXHJHDHVAIH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1214")]
		public LegacyCV2Result<None> UGXFXYIGPLN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1215")]
		public LegacyCV2Result<None> UMVTYPYLFDC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(SIFIYGRIVBJ e, InOut io, YYICAURWJZG quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1036")]
		public LegacyCV2Result<None> KPEPXISRHGV(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1037")]
		public LegacyCV2Result<None> LHVUUUMRRVD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1038")]
		public LegacyCV2Result<None> XCTYPTWPEPZ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1039")]
		public LegacyCV2Result<None> QWECPPOETSL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1040")]
		public LegacyCV2Result<None> GZUZZPLIHJH(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1041")]
		public LegacyCV2Result<None> RCXICPSZKLT(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1042")]
		public LegacyCV2Result<None> CFCYBISMBDH(SIFIYGRIVBJ a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1043")]
		public LegacyCV2Result<None> HKMGDNRMYUL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1044")]
		public LegacyCV2Result<None> GXEVEVWZLLN(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1045")]
		public LegacyCV2Result<None> HPFKITGZEYW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1046")]
		public LegacyCV2Result<None> PTEAZBMPBMW(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JZNLEJSKSEK(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1234")]
		public LegacyCV2Result<None> NGQFEUBROZL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1236")]
		public LegacyCV2Result<None> NUPKSZOKEBK(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1229")]
		public LegacyCV2Result<None> KCHZOCPMCBY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1241")]
		public LegacyCV2Result<None> WMRYZESKZFY(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1242")]
		public LegacyCV2Result<None> MOLAJOFFJLD(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1243")]
		public LegacyCV2Result<None> KBYEPHHXBAB(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1244")]
		public LegacyCV2Result<None> VZEXNHBJWQL(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1245")]
		public LegacyCV2Result<None> XIJEPVSIKRO(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OEOMBZLSKPA(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UTNLWPUEFVM(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FJVCZNCTFHW(SIFIYGRIVBJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1259")]
		public LegacyCV2Result<None> WREBRCGFQQM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1260")]
		public LegacyCV2Result<None> XGOSUPWNVCS(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1261")]
		public LegacyCV2Result<None> LVGTLRNHHAC(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1262")]
		public LegacyCV2Result<None> TPFIRYGULXI(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x28B9AE0", Offset = "0x28B88E0", VA = "0x1828B9AE0")]
		public FWWDVKHHOOT([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(SIFIYGRIVBJ e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1280")]
		public LegacyCV2Result<None> YVUCTMYSVIJ(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1281")]
		public LegacyCV2Result<None> RDYUZQHXGKU(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "599")]
		public LegacyCV2Result<None> EHJYPRNEHDM(SIFIYGRIVBJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1293")]
		public LegacyCV2Result<None> HTESLJSQJRH(PCKZPCRIQKY e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1294")]
		public LegacyCV2Result<None> SLKJVBTRZJG(PCKZPCRIQKY e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1295")]
		public LegacyCV2Result<None> WCUFMTRGOCN(PCKZPCRIQKY e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1296")]
		public LegacyCV2Result<None> ZAAQQZWAYIL(PCKZPCRIQKY e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1297")]
		public LegacyCV2Result<None> EGQGWQCIVCO(PCKZPCRIQKY e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00")]
		public LegacyCV2Result<None> ConstantStorefrontItem(SIFIYGRIVBJ e, InOut io, [In] RCVAXQRRBHL storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(SIFIYGRIVBJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> VVOMFSHHWIS(SIFIYGRIVBJ a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, XWEZHVPWKRM.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> TAJFLGKVYCI(SIFIYGRIVBJ a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, XWEZHVPWKRM.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1207")]
		private LegacyCV2Result<None> MOJEIVTCMNZ(SIFIYGRIVBJ a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1216")]
		private LegacyCV2Result<None> ZLYOCWLJNJC(SIFIYGRIVBJ a, InOut b, [In] RCVAXQRRBHL storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00", Slot = "1257")]
		private LegacyCV2Result<None> RNDPWRYCXOU(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class PGSEUQNAJCS : IILVERLCETR
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(LFHITMRNHAE node);

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly PGSEUQNAJCS ZMRLUQHZNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate HZRRVTQXGOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate QOVAYDNZJQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private bool BPCYTWRQXSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private bool VZHOEXEYDZH;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6B0", Offset = "0x28C94B0", VA = "0x1828CA6B0", Slot = "4")]
		public Task<bool> ZYFIIDJTEAI(LFHITMRNHAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x28CB670", Offset = "0x28CA470", VA = "0x1828CB670", Slot = "5")]
		public Task<bool> VLNSUAPBBDR(LFHITMRNHAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x28CB720", Offset = "0x28CA520", VA = "0x1828CB720")]
		public PGSEUQNAJCS([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x28CB650", Offset = "0x28CA450", VA = "0x1828CB650", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? QOLLGOOOOUY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xACC870", Offset = "0xACB670", VA = "0x180ACC870", Slot = "7")]
		public bool UBWMRMEUMBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x13C86C0", Offset = "0x13C74C0", VA = "0x1813C86C0", Slot = "8")]
		public bool IWHTZBUXKAV()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class CERPWJMWATU : EQLMNINKRRX
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid QKUINNMAVHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xCDB8A0", Offset = "0xCDA6A0", VA = "0x180CDB8A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void Bind(XIVHYOIAOKZ pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xEFB1A0", Offset = "0xEF9FA0", VA = "0x180EFB1A0")]
		public CERPWJMWATU(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x28C8D40", Offset = "0x28C7B40", VA = "0x1828C8D40")]
		public static CERPWJMWATU New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class BMATKLSEWVW : JQAVOXTFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<IFDXSBOVKOD> nodeDefId, Id128<VTHPCPYYILP>? legacyInnerGraphId, IReadOnlyDictionary<Id128<VTHPCPYYILP>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IsNodeRestrictedDelegate? UDNDLUTRJRN;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool TUHHLRCJDTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xB1DD80", Offset = "0xB1CB80", VA = "0x180B1DD80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CNQFJCJUDHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x28C8C60", Offset = "0x28C7A60", VA = "0x1828C8C60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool CRCZIYJTROM
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xF00F10", Offset = "0xEFFD10", VA = "0x180F00F10", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "6")]
		public bool SPSNKIDCHIB(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "7")]
		public CanSaveObjectIntoInventionResultType XLMZLEYDXAO(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x28C8C70", Offset = "0x28C7A70", VA = "0x1828C8C70", Slot = "8")]
		public bool VXGZXHHVGAN(Id128<IFDXSBOVKOD> nodeDefId, Id128<VTHPCPYYILP>? legacyInnerGraphId, IReadOnlyDictionary<Id128<VTHPCPYYILP>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "9")]
		public bool YCBJYLBWFBQ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "10")]
		public bool IJNPJIJRFRC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x28C8CC0", Offset = "0x28C7AC0", VA = "0x1828C8CC0")]
		public BMATKLSEWVW(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class UEDTADLEUUW : HJQGHWVVMFR
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly UEDTADLEUUW ZMRLUQHZNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly ShouldLogEventSenderToMakerPenDelegate GZECOASNJRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate VTJBRIVDYHK;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool YEVQGBRZVIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x10861E0", Offset = "0x1084FE0", VA = "0x1810861E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool QFSPEYMXJRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x28CF5F0", Offset = "0x28CE3F0", VA = "0x1828CF5F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x28CF690", Offset = "0x28CE490", VA = "0x1828CF690")]
		public UEDTADLEUUW([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class HKLGHKESLJG : NLMVNRYYJPS<DHOLAANDPCA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class HCCTBFRAFLB : DHOLAANDPCA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly HCCTBFRAFLB PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool UWJBLFXKALL
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x28CA2C0", Offset = "0x28C90C0", VA = "0x1828CA2C0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			public void FMJIDINXVPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HCCTBFRAFLB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly HKLGHKESLJG PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private HKLGHKESLJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x28CA360", Offset = "0x28C9160", VA = "0x1828CA360", Slot = "4")]
		public DHOLAANDPCA WYHHBUUWOYJ()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class ZJJNMORMQIW<a, b> : IDisposable, DJMRNOIPAQN where a : notnull where b : notnull, CHOQXBWLQKE.ZSLKVIHDTZQ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly b PDDKCLIEEXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly a SAQGQBBLTJX;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<YMXYNUJKSYU> TBEAKAQOFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xAD8650", Offset = "0xAD7450", VA = "0x180AD8650", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<YMXYNUJKSYU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC8A0", Offset = "0x3DFB6A0", VA = "0x183DFC8A0")]
		public ZJJNMORMQIW(b a, a b, Id32<YMXYNUJKSYU> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x3FD6820", Offset = "0x3FD5620", VA = "0x183FD6820", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x3FD65A0", Offset = "0x3FD53A0", VA = "0x183FD65A0")]
		public Id32<UEWLFKNRYNB> CPCGHDDCRIG([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<UEWLFKNRYNB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8000", Offset = "0x3FD6E00", VA = "0x183FD8000", Slot = "6")]
		public void WYGYNYDGAXT(Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x3FD6A70", Offset = "0x3FD5870", VA = "0x183FD6A70", Slot = "7")]
		public void EIUTMHOOIYL(Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8040", Offset = "0x3FD6E40", VA = "0x183FD8040", Slot = "8")]
		public void ZHYDGNGSAGE(Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x3FD72A0", Offset = "0x3FD60A0", VA = "0x183FD72A0", Slot = "10")]
		public void QXTKMOFUZYH(Id32<UEWLFKNRYNB> objectId, Id32<YMXYNUJKSYU> clientId, IDXWQJYKOQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x3FD7B20", Offset = "0x3FD6920", VA = "0x183FD7B20", Slot = "9")]
		public void WLZSTBUKAMR(Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x3FD6FE0", Offset = "0x3FD5DE0", VA = "0x183FD6FE0", Slot = "11")]
		public void JWTUJWGEWUB(Id32<UEWLFKNRYNB> objectId, HBZQSXBMNSY? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x3FD7A50", Offset = "0x3FD6850", VA = "0x183FD7A50", Slot = "12")]
		public Id32<YMXYNUJKSYU> UUPVHBNUNPY(Id32<UEWLFKNRYNB> objectId)
		{
			return default(Id32<YMXYNUJKSYU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x3FD6AB0", Offset = "0x3FD58B0", VA = "0x183FD6AB0", Slot = "13")]
		public Id32<GDGSZWIIVHX> HRCUHZGADMK(Id32<UEWLFKNRYNB> objectId, string a, object b, bool c, CJRDZWTLPWL d, MVVQZZKTVAZ e)
		{
			return default(Id32<GDGSZWIIVHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x3FD7260", Offset = "0x3FD6060", VA = "0x183FD7260", Slot = "14")]
		public void NHRDYOCNMNE(Id32<GDGSZWIIVHX> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x3FD7780", Offset = "0x3FD6580", VA = "0x183FD7780", Slot = "15")]
		public void RAIPXELYWUY(Id32<GDGSZWIIVHX> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class CHOQXBWLQKE
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface ZSLKVIHDTZQ<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void XQTVRTMDSIO(a a, Id32<YMXYNUJKSYU> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<YMXYNUJKSYU>? TPCABXNMSTL(a a);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<UEWLFKNRYNB> CPCGHDDCRIG(a a, Id32<YMXYNUJKSYU> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void WYGYNYDGAXT(a a, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void EIUTMHOOIYL(a a, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void QXTKMOFUZYH(a a, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK b);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void WLZSTBUKAMR(a a, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK b);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void JWTUJWGEWUB(a a, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, HBZQSXBMNSY? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<YMXYNUJKSYU>? UUPVHBNUNPY(a a, Id32<UEWLFKNRYNB> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<GDGSZWIIVHX> HRCUHZGADMK(a a, Id32<YMXYNUJKSYU> clientId, string b, object c, CJRDZWTLPWL d, MVVQZZKTVAZ e);

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void NHRDYOCNMNE(a a, Id32<YMXYNUJKSYU> clientId, Id32<GDGSZWIIVHX> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void RAIPXELYWUY(a a, Id32<YMXYNUJKSYU> clientId, Id32<GDGSZWIIVHX> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class XEHQLHKQNIS
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly HashSet<Id32<UEWLFKNRYNB>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAId32Field<GDGSZWIIVHX, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public readonly Dictionary<Id32<GDGSZWIIVHX>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<GDGSZWIIVHX>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public SOAField<UEWLFKNRYNB, HBZQSXBMNSY?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x28CB2F0", Offset = "0x28CA0F0", VA = "0x1828CB2F0")]
			private MockCV2DynamicNetSys(HashSet<Id32<UEWLFKNRYNB>> authorityOf, [In] SOAId32Field<GDGSZWIIVHX, MockCV2SyncField> syncFields, Dictionary<Id32<GDGSZWIIVHX>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<GDGSZWIIVHX>> mockSyncFieldToSyncField, [In] SOAField<UEWLFKNRYNB, HBZQSXBMNSY?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x28CB130", Offset = "0x28C9F30", VA = "0x1828CB130")]
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
			public Id32<YMXYNUJKSYU>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x28CB390", Offset = "0x28CA190", VA = "0x1828CB390")]
			public MockCV2ObjectShared(Id32<YMXYNUJKSYU> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public MVVQZZKTVAZ SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public CJRDZWTLPWL SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xEB4670", Offset = "0xEB3470", VA = "0x180EB4670")]
			internal MockCV2SyncField(MVVQZZKTVAZ syncField, CJRDZWTLPWL syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x28CB4B0", Offset = "0x28CA2B0", VA = "0x1828CB4B0")]
			public static MockCV2SyncField New(MVVQZZKTVAZ syncField, CJRDZWTLPWL syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x28CB460", Offset = "0x28CA260", VA = "0x1828CB460")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x28CB410", Offset = "0x28CA210", VA = "0x1828CB410")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<UEWLFKNRYNB, MockCV2ObjectShared> BJFCNKDTBGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<UEWLFKNRYNB>> UOHYLKTPIRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> LSIIESKPMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> EOHIVROESZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private SOAField<YMXYNUJKSYU, MockCV2DynamicNetSys> XOAXSLXRYZF;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<UEWLFKNRYNB>? FTNHQRZJTFR
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xBAD820", Offset = "0xBAC620", VA = "0x180BAD820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x1051F50", Offset = "0x1050D50", VA = "0x181051F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x28CFE70", Offset = "0x28CEC70", VA = "0x1828CFE70")]
		public void Destroy([In] SOAId32<YMXYNUJKSYU> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x28D0D70", Offset = "0x28CFB70", VA = "0x1828D0D70")]
		public void XEVYPHCSBAK(Id32<YMXYNUJKSYU> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x28D11D0", Offset = "0x28CFFD0", VA = "0x1828D11D0")]
		public void XQTVRTMDSIO(Id32<YMXYNUJKSYU> clientId, Id32<YMXYNUJKSYU>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x28CF990", Offset = "0x28CE790", VA = "0x1828CF990")]
		public Id32<UEWLFKNRYNB> CPCGHDDCRIG(Id32<YMXYNUJKSYU> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<YMXYNUJKSYU> clientIds)
		{
			return default(Id32<UEWLFKNRYNB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x28D01F0", Offset = "0x28CEFF0", VA = "0x1828D01F0")]
		public Id32<GDGSZWIIVHX> HRCUHZGADMK(Id32<YMXYNUJKSYU> clientId, string a, object b, CJRDZWTLPWL c, MVVQZZKTVAZ d)
		{
			return default(Id32<GDGSZWIIVHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x28D0520", Offset = "0x28CF320", VA = "0x1828D0520")]
		public void NHRDYOCNMNE(Id32<YMXYNUJKSYU> clientId, Id32<GDGSZWIIVHX> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x28CFDA0", Offset = "0x28CEBA0", VA = "0x1828CFDA0")]
		public Id32<UEWLFKNRYNB>? CRYZPUMTOGD([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x28D0CF0", Offset = "0x28CFAF0", VA = "0x1828D0CF0")]
		public void WYGYNYDGAXT([In] SOAId32<YMXYNUJKSYU> clientIds, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x28D00B0", Offset = "0x28CEEB0", VA = "0x1828D00B0")]
		public void EIUTMHOOIYL(Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x28D06B0", Offset = "0x28CF4B0", VA = "0x1828D06B0")]
		public void QXTKMOFUZYH(Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x28D0B70", Offset = "0x28CF970", VA = "0x1828D0B70")]
		public void WLZSTBUKAMR([In] SOAId32<YMXYNUJKSYU> clientIds, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x28D0450", Offset = "0x28CF250", VA = "0x1828D0450")]
		public void JWTUJWGEWUB(Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, HBZQSXBMNSY? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x28D0B20", Offset = "0x28CF920", VA = "0x1828D0B20")]
		public Id32<YMXYNUJKSYU>? UUPVHBNUNPY(Id32<UEWLFKNRYNB> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x28D07B0", Offset = "0x28CF5B0", VA = "0x1828D07B0")]
		public void RAIPXELYWUY([In] SOAId32<YMXYNUJKSYU> clientIds, Id32<YMXYNUJKSYU> clientId, Id32<GDGSZWIIVHX> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x28D1520", Offset = "0x28D0320", VA = "0x1828D1520")]
		public XEHQLHKQNIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class KOLMGHWBKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x28CA650", Offset = "0x28C9450", VA = "0x1828CA650")]
		public static void Destroy(this XEHQLHKQNIS.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class SLYVFYJGFGB : KKJTIHGUWMR.WROGKVZRMEZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static SLYVFYJGFGB NGFSCIOBGQC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate LRDGEEREPQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate LNIPEPVYUYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xAD31B0", Offset = "0xAD1FB0", VA = "0x180AD31B0")]
		public SLYVFYJGFGB(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class RPLYECVWMOB : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : MTGYOANFZQO.BMXMFFKRFMT<CLHMCDDVOKO, RPLYECVWMOB>
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
				public AsyncTaskMethodBuilder<Result<object, WWZNUEBGASM>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public RPLYECVWMOB root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public Id32<YMXYNUJKSYU> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public CLHMCDDVOKO action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				private TaskAwaiter<Result<object, WWZNUEBGASM>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0x28CE740", Offset = "0x28CD540", VA = "0x1828CE740", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0x28CE980", Offset = "0x28CD780", VA = "0x1828CE980", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "4")]
			public int SHOUXIGTKWT(RPLYECVWMOB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x28CC860", Offset = "0x28CB660", VA = "0x1828CC860", Slot = "5")]
			public int MFCPLENTLNT(RPLYECVWMOB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x28CC6F0", Offset = "0x28CB4F0", VA = "0x1828CC6F0", Slot = "6")]
			public int DHHZZBCSLRE(RPLYECVWMOB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x28CC880", Offset = "0x28CB680", VA = "0x1828CC880", Slot = "7")]
			public int MGHDHCGGZKK(RPLYECVWMOB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x28CC8A0", Offset = "0x28CB6A0", VA = "0x1828CC8A0", Slot = "8")]
			public void UWGJWGDHJYF(RPLYECVWMOB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "9")]
			public bool STFLURDMCDQ(RPLYECVWMOB a, Id32<YMXYNUJKSYU> actorId, CLHMCDDVOKO[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "10")]
			public bool KGIYFPYVGDK(RPLYECVWMOB a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x28CC710", Offset = "0x28CB510", VA = "0x1828CC710", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, WWZNUEBGASM>> MDBEZPKEWEE(RPLYECVWMOB a, Id32<YMXYNUJKSYU> senderId, CLHMCDDVOKO b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : MTGYOANFZQO.ZSAXAUTJBCY<ActionDeps, QYNLRMWOSJV.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps HVBHFWILFVG
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public QYNLRMWOSJV.StaticNetSysReceiverDeps GLSTCLQFCRF
			{
				[Cpp2IlInjected.Token(Token = "0x60007AD")]
				[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "5")]
				get
				{
					return default(QYNLRMWOSJV.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps LDXMZWETNZA
			{
				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : CAALTCBVRFO.ZSLKVIHDTZQ<RPLYECVWMOB>
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
				public AsyncTaskMethodBuilder<Result<object?, WWZNUEBGASM>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public RPLYECVWMOB root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public Id32<YMXYNUJKSYU> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public CLHMCDDVOKO action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				private TaskAwaiter<Result<object?, WWZNUEBGASM>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007B0")]
				[Cpp2IlInjected.Address(RVA = "0x28CE420", Offset = "0x28CD220", VA = "0x1828CE420", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007B1")]
				[Cpp2IlInjected.Address(RVA = "0x28CE6D0", Offset = "0x28CD4D0", VA = "0x1828CE6D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x28CB4F0", Offset = "0x28CA2F0", VA = "0x1828CB4F0", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, WWZNUEBGASM>> MDBEZPKEWEE(RPLYECVWMOB a, Id32<YMXYNUJKSYU> clientId, CLHMCDDVOKO b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : CHOQXBWLQKE.ZSLKVIHDTZQ<RPLYECVWMOB>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x28CB100", Offset = "0x28C9F00", VA = "0x1828CB100", Slot = "4")]
			public void XQTVRTMDSIO(RPLYECVWMOB a, Id32<YMXYNUJKSYU> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xD36160", Offset = "0xD34F60", VA = "0x180D36160", Slot = "5")]
			public Id32<YMXYNUJKSYU>? TPCABXNMSTL(RPLYECVWMOB a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x28CAAD0", Offset = "0x28C98D0", VA = "0x1828CAAD0")]
			public Id32<UEWLFKNRYNB> CPCGHDDCRIG(RPLYECVWMOB a, Id32<YMXYNUJKSYU> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<UEWLFKNRYNB>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x28CB070", Offset = "0x28C9E70", VA = "0x1828CB070", Slot = "7")]
			public void WYGYNYDGAXT(RPLYECVWMOB a, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x28CAB30", Offset = "0x28C9930", VA = "0x1828CAB30", Slot = "8")]
			public void EIUTMHOOIYL(RPLYECVWMOB a, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x28CAF70", Offset = "0x28C9D70", VA = "0x1828CAF70", Slot = "9")]
			public void QXTKMOFUZYH(RPLYECVWMOB a, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x28CB040", Offset = "0x28C9E40", VA = "0x1828CB040", Slot = "10")]
			public void WLZSTBUKAMR(RPLYECVWMOB a, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, IDXWQJYKOQK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x28CACF0", Offset = "0x28C9AF0", VA = "0x1828CACF0", Slot = "11")]
			public void JWTUJWGEWUB(RPLYECVWMOB a, Id32<YMXYNUJKSYU> clientId, Id32<UEWLFKNRYNB> objectId, HBZQSXBMNSY? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x28CAFE0", Offset = "0x28C9DE0", VA = "0x1828CAFE0", Slot = "12")]
			public Id32<YMXYNUJKSYU>? UUPVHBNUNPY(RPLYECVWMOB a, Id32<UEWLFKNRYNB> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x28CAC90", Offset = "0x28C9A90", VA = "0x1828CAC90", Slot = "13")]
			public Id32<GDGSZWIIVHX> HRCUHZGADMK(RPLYECVWMOB a, Id32<YMXYNUJKSYU> clientId, string b, object c, CJRDZWTLPWL d, MVVQZZKTVAZ e)
			{
				return default(Id32<GDGSZWIIVHX>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x28CADD0", Offset = "0x28C9BD0", VA = "0x1828CADD0", Slot = "14")]
			public void NHRDYOCNMNE(RPLYECVWMOB a, Id32<YMXYNUJKSYU> clientId, Id32<GDGSZWIIVHX> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x28CAFB0", Offset = "0x28C9DB0", VA = "0x1828CAFB0", Slot = "15")]
			public void RAIPXELYWUY(RPLYECVWMOB a, Id32<YMXYNUJKSYU> clientId, Id32<GDGSZWIIVHX> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x28CAAD0", Offset = "0x28C98D0", VA = "0x1828CAAD0", Slot = "6")]
			private Id32<UEWLFKNRYNB> CUZFYRINCPU(RPLYECVWMOB a, Id32<YMXYNUJKSYU> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<UEWLFKNRYNB>);
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
			public RPLYECVWMOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public Id32<UEWLFKNRYNB>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public IXXCQUDTOLA deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private Id32<YMXYNUJKSYU> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private CYONTVTWVUG<RPLYECVWMOB, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private ZJJNMORMQIW<RPLYECVWMOB, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private QYNLRMWOSJV <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x28CDD60", Offset = "0x28CCB60", VA = "0x1828CDD60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x28CE3B0", Offset = "0x28CD1B0", VA = "0x1828CE3B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly ORTFINRBIKG<CLHMCDDVOKO, None, QYNLRMWOSJV, ActionDeps, QYNLRMWOSJV.StaticNetSysReceiverDeps, RootDeps, RPLYECVWMOB, Deps> NPUITSGVQFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly XEHQLHKQNIS DRMVKMMAEQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAId32<YMXYNUJKSYU> WYFACZVYWMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private SOAField<YMXYNUJKSYU, None> XOAXSLXRYZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private SOAField<YMXYNUJKSYU, QYNLRMWOSJV> PJFNPGYSTXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Id32<YMXYNUJKSYU>? RNTCVAJQFOE;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate AERUDVBNJQC
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xAC63F0", Offset = "0xAC51F0", VA = "0x180AC63F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x28CBFF0", Offset = "0x28CADF0", VA = "0x1828CBFF0")]
		public RPLYECVWMOB(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x28CB930", Offset = "0x28CA730", VA = "0x1828CB930", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x28CBBE0", Offset = "0x28CA9E0", VA = "0x1828CBBE0")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> XEVYPHCSBAK(IXXCQUDTOLA a, RegistryV2 b, Id32<UEWLFKNRYNB>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x28CBD60", Offset = "0x28CAB60", VA = "0x1828CBD60")]
		private void XQTVRTMDSIO(Id32<YMXYNUJKSYU> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x28CBB00", Offset = "0x28CA900", VA = "0x1828CBB00")]
		[CompilerGenerated]
		private Id32<UEWLFKNRYNB>? GSHVDDRVKFA([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class ZRAXPGSKTZO : CKLHBYYABAA.WROGKVZRMEZ
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<WWWGSMJWHIF> DeserializeCircuitsJunctionAsyncDelegate(QYNLRMWOSJV circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<WWWGSMJWHIF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public ZRAXPGSKTZO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public QYNLRMWOSJV circuitsManager;

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
			private TaskAwaiter<WWWGSMJWHIF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x28CCA50", Offset = "0x28CB850", VA = "0x1828CCA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x28CCC50", Offset = "0x28CBA50", VA = "0x1828CCC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate TNRHABCIPQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly LifecycleDidInitializeDelegate? CGILDLDWUBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly LifecycleWillDestroyDelegate? VCCTHPIZPVG;

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x28D16C0", Offset = "0x28D04C0", VA = "0x1828D16C0", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<WWWGSMJWHIF> HFYWAHHUZIY(QYNLRMWOSJV a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void WZLVMQNUYTW(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xDDA7A0", Offset = "0xDD95A0", VA = "0x180DDA7A0", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xE69CD0", Offset = "0xE68AD0", VA = "0x180E69CD0", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x28D1830", Offset = "0x28D0630", VA = "0x1828D1830")]
		public ZRAXPGSKTZO([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class DYNTRIDTTQG : KSDCTIOOBTE.WROGKVZRMEZ
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate MBCVFYIDIHC GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<NGYZLESJFBW> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<EAODHGTIJFS> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<KSDCTIOOBTE.WROGKVZRMEZ.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<KSDCTIOOBTE.WROGKVZRMEZ.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public DYNTRIDTTQG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter<KSDCTIOOBTE.WROGKVZRMEZ.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x28CCCC0", Offset = "0x28CBAC0", VA = "0x1828CCCC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x28CCEB0", Offset = "0x28CBCB0", VA = "0x1828CCEB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<EAODHGTIJFS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public DYNTRIDTTQG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			private TaskAwaiter<EAODHGTIJFS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x28CCF20", Offset = "0x28CBD20", VA = "0x1828CCF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x28CD110", Offset = "0x28CBF10", VA = "0x1828CD110", Slot = "5")]
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
			public AsyncTaskMethodBuilder<NGYZLESJFBW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public DYNTRIDTTQG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private TaskAwaiter<NGYZLESJFBW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x28CD180", Offset = "0x28CBF80", VA = "0x1828CD180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x28CD370", Offset = "0x28CC170", VA = "0x1828CD370", Slot = "5")]
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
			public DYNTRIDTTQG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x28CD3E0", Offset = "0x28CC1E0", VA = "0x1828CD3E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x28CD5D0", Offset = "0x28CC3D0", VA = "0x1828CD5D0", Slot = "5")]
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
			public DYNTRIDTTQG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x28CD640", Offset = "0x28CC440", VA = "0x1828CD640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x28CD830", Offset = "0x28CC630", VA = "0x1828CD830", Slot = "5")]
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
			public DYNTRIDTTQG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x28CD8A0", Offset = "0x28CC6A0", VA = "0x1828CD8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x28CDA90", Offset = "0x28CC890", VA = "0x1828CDA90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetCV2DependenciesDelegate VWOMCQPCFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomDataAsyncDelegate FKSAOYNUNUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetSuperRoomDataAsyncDelegate XIGAPTVDUBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetRoomAssetDataAsyncDelegate VKNIHZRMLWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetPlayerSaveDataAsyncDelegate WAPBCCAMCZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate SWZNQGNKGIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly GetStaticCircuitsConfigAsyncDelegate RUWNLSIMSNU;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public MBCVFYIDIHC MBCVFYIDIHC
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x10861E0", Offset = "0x1084FE0", VA = "0x1810861E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x28C9370", Offset = "0x28C8170", VA = "0x1828C9370", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> YZHCMPYDAZX(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x28C9260", Offset = "0x28C8060", VA = "0x1828C9260", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> XAEELPMGWYE(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x28C8E20", Offset = "0x28C7C20", VA = "0x1828C8E20", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<NGYZLESJFBW> AKTMMDJBNNF(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x28C9040", Offset = "0x28C7E40", VA = "0x1828C9040", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<EAODHGTIJFS> MYXGZHDBWPC(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x28C9150", Offset = "0x28C7F50", VA = "0x1828C9150", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<KSDCTIOOBTE.WROGKVZRMEZ.CircuitGraphToolMapping> NFAUGICLWJL(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x28C8F30", Offset = "0x28C7D30", VA = "0x1828C8F30", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> HGPLRANGJQM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x28C9480", Offset = "0x28C8280", VA = "0x1828C9480")]
		public DYNTRIDTTQG(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class FSJPLMSAFPQ : CV2Request.WROGKVZRMEZ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly CV2Request.WROGKVZRMEZ PKFRARWZTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly GetCanSendRequestsDelegate UCJAPLUTNPE;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public FSJPLMSAFPQ(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x10861E0", Offset = "0x1084FE0", VA = "0x1810861E0", Slot = "4")]
		public bool AOOJWZNHHEG()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class LAIFLUVYHIF : OBCNIXZMAQE
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, GVGCNFONGHQ> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly TryReportErrToUserDelegate XMPQGEIIXBQ;

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6B0", Offset = "0x28C94B0", VA = "0x1828CA6B0")]
		public bool TBEFTOZGYAU([In] Result<None, GVGCNFONGHQ> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6E0", Offset = "0x28C94E0", VA = "0x1828CA6E0")]
		public LAIFLUVYHIF([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6B0", Offset = "0x28C94B0", VA = "0x1828CA6B0", Slot = "4")]
		private bool ARGEDEJJGDV([In] Result<None, GVGCNFONGHQ> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class CKDVOSJBUSE : JRGKQLWFHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate SIFIYGRIVBJ CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly CKDVOSJBUSE PKFRARWZTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CurrentExecParamsDelegate? NPRWUESAVFE;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public SIFIYGRIVBJ LUSSYHOIGCG
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x10861E0", Offset = "0x1084FE0", VA = "0x1810861E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public CKDVOSJBUSE([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class RQWBKPXIMJU : GBOCFJGVLDP
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly GBOCFJGVLDP PKFRARWZTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly GetGameColorFromIdDelegate LKYNHACFTZE;

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6B0", Offset = "0x28C94B0", VA = "0x1828CA6B0", Slot = "4")]
		public CircuitsColor ETAEJCMYEVK(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x28CC540", Offset = "0x28CB340", VA = "0x1828CC540")]
		public RQWBKPXIMJU([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class EGVKVWBQXHU : MEPNXTLNVVD
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
			public EGVKVWBQXHU <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x28CDB00", Offset = "0x28CC900", VA = "0x1828CDB00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x28CDCF0", Offset = "0x28CCAF0", VA = "0x1828CDCF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly IsStringPureAsyncDelegate LZTDATEUKZT;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x28C9D90", Offset = "0x28C8B90", VA = "0x1828C9D90", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> SMDKHXZDOIJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x28C9ED0", Offset = "0x28C8CD0", VA = "0x1828C9ED0")]
		public EGVKVWBQXHU([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class LBMFCWXJCKI : LHZXDNJIZQT
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate LNMDEADXWOL? GetNodeVisualizationConfigDelegate([In] Id128<IFDXSBOVKOD> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly LHZXDNJIZQT PKFRARWZTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly GetNodeVisualizationConfigDelegate UZDOCDAOOME;

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6B0", Offset = "0x28C94B0", VA = "0x1828CA6B0")]
		public LNMDEADXWOL? XAAFQDUQMLU([In] Id128<IFDXSBOVKOD> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x28CA910", Offset = "0x28C9710", VA = "0x1828CA910")]
		public LBMFCWXJCKI([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6B0", Offset = "0x28C94B0", VA = "0x1828CA6B0", Slot = "4")]
		private LNMDEADXWOL MYBEJSMUGDY([In] Id128<IFDXSBOVKOD> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class TIIXSDDWBMP : GMHLPQQUHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x28CCA00", Offset = "0x28CB800", VA = "0x1828CCA00", Slot = "4")]
		public AFHJZSXUXUT HKJRISVOICD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public TIIXSDDWBMP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class ATUXXYONSGN : FSCEABXZIRI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, bool> SIDXGXDMRTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, float> POSYWLPIJMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, double> MRMNKTBFVPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, int> LVDXCPXPNTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, long> PVIBEDULZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, string> MXJJGQMNTCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly Dictionary<string, uint> EAWCQWHHDNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly Dictionary<string, ulong> PDMLQGBZORZ;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x28C8950", Offset = "0x28C7750", VA = "0x1828C8950", Slot = "4")]
		public bool? JULZVSGDXJC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x28C89F0", Offset = "0x28C77F0", VA = "0x1828C89F0")]
		public ATUXXYONSGN()
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
