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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x2847EB0", Offset = "0x28472B0", VA = "0x182847EB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
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
		internal sealed class ZTJNVMYXQGW : NUIOMADGJVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ZTJNVMYXQGW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840", Slot = "4")]
			public NUIOMADGJVH APPUOFQQFYR(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840", Slot = "5")]
			public NUIOMADGJVH IRGFKRBKRTC(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840", Slot = "6")]
			public NUIOMADGJVH IGJGUCUNHXK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
			public void SMCVKRDMXBZ()
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
	public static class OSFTXHACVVV
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class VKMWSMJNIRA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public YHXGCLRLMUY HTKUJEJOPYB;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VKMWSMJNIRA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x284C0A0", Offset = "0x284B4A0", VA = "0x18284C0A0")]
			internal VTCCODAZOLE BXEMYBMBPIQ(GetNetworkObjectDelegate a)
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
			public KVKSDIRUDBG dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public ZNWMZVRLJBJ network;

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
			[Cpp2IlInjected.Address(RVA = "0x2849CE0", Offset = "0x28490E0", VA = "0x182849CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x284A380", Offset = "0x2849780", VA = "0x18284A380", Slot = "5")]
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
			public ZNWMZVRLJBJ network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public KVKSDIRUDBG dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<JDQQUBYOTBT>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private PRNNMMJSLKB <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x284A3F0", Offset = "0x28497F0", VA = "0x18284A3F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x284A980", Offset = "0x2849D80", VA = "0x18284A980", Slot = "5")]
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
			public YHXGCLRLMUY roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x284A9F0", Offset = "0x2849DF0", VA = "0x18284A9F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x284AF00", Offset = "0x284A300", VA = "0x18284AF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2848660", Offset = "0x2847A60", VA = "0x182848660")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? HAZCZYBXERU([Optional] YHXGCLRLMUY? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2848960", Offset = "0x2847D60", VA = "0x182848960")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> IFTVZHXQUIH(ZNWMZVRLJBJ a, [Optional] KVKSDIRUDBG? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28487D0", Offset = "0x2847BD0", VA = "0x1828487D0")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> IFTVZHXQUIH(ZNWMZVRLJBJ a, KVKSDIRUDBG b, RegistryV2 c, Id32<JDQQUBYOTBT>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2848BE0", Offset = "0x2847FE0", VA = "0x182848BE0")]
		public static (RuntimeFnRegistry, RuntimeFns) SZLXTSHOSZB()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2848AE0", Offset = "0x2847EE0", VA = "0x182848AE0")]
		public static (ExternalFnRegistry, ExternalFns) JMEVWEREJAI()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2848750", Offset = "0x2847B50", VA = "0x182848750")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static ZNWMZVRLJBJ HBEFLRMTQTL(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class CZCHCZKCNDB
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate VTCCODAZOLE CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public CZCHCZKCNDB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x28498F0", Offset = "0x2848CF0", VA = "0x1828498F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2849C70", Offset = "0x2849070", VA = "0x182849C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ZNWMZVRLJBJ NFQNTAEPLWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? FSMGDUHZFNH;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		private CZCHCZKCNDB(ZNWMZVRLJBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x283D310", Offset = "0x283C710", VA = "0x18283D310")]
		public static CZCHCZKCNDB LUYAJHASGOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x283D2F0", Offset = "0x283C6F0", VA = "0x18283D2F0")]
		public CZCHCZKCNDB KDNDMYQLWBE(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x283D3C0", Offset = "0x283C7C0", VA = "0x18283D3C0")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> SMCVKRDMXBZ()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class XNHMYXIDHUN : PRNNMMJSLKB.VUJTJJOWWBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate XIJKTMWBCMT NewCircuitsLifecycleDelegate(RWYGVNVPHCG.VUJTJJOWWBJ deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(PRNNMMJSLKB circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(PRNNMMJSLKB circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate IQNESBJCFQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate FSLOORAGNMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate IKYOYVKBQEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate SESALDCMRZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate KAFSMKIRQRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate QAHWPCNEDQA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int JDNZSTPTAOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xFF2980", Offset = "0xFF1D80", VA = "0x180FF2980", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x284C3F0", Offset = "0x284B7F0", VA = "0x18284C3F0", Slot = "6")]
		public void RXAKJAEQJTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x284C3C0", Offset = "0x284B7C0", VA = "0x18284C3C0", Slot = "7")]
		public void GPDIJLEPXST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x284C390", Offset = "0x284B790", VA = "0x18284C390", Slot = "5")]
		public XIJKTMWBCMT FWWTKMEWUAY(RWYGVNVPHCG.VUJTJJOWWBJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC2A660", Offset = "0xC29A60", VA = "0x180C2A660", Slot = "8")]
		public void QPBTPYHSXXL(PRNNMMJSLKB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC2A5D0", Offset = "0xC299D0", VA = "0x180C2A5D0", Slot = "9")]
		public void SPOVZIGKTQG(PRNNMMJSLKB a, HJODGUBVAZG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x284C420", Offset = "0x284B820", VA = "0x18284C420")]
		public XNHMYXIDHUN([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly VZKFCAVCIQQ<ZNWMZVRLJBJ, ZNWMZVRLJBJ.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly GRMJQVWYAHK<ZNWMZVRLJBJ, ZNWMZVRLJBJ.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly PRNNMMJSLKB CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<GPNZGVDAJTA> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly ZNWMZVRLJBJ Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28423C0", Offset = "0x28417C0", VA = "0x1828423C0")]
		public EVCreationResult(VZKFCAVCIQQ<ZNWMZVRLJBJ, ZNWMZVRLJBJ.MockStaticNetSysDeps> staticNetSys, GRMJQVWYAHK<ZNWMZVRLJBJ, ZNWMZVRLJBJ.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, PRNNMMJSLKB circuitsManager, Id32<GPNZGVDAJTA> clientId, ZNWMZVRLJBJ network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly PRNNMMJSLKB _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 QOZKRCHDOLL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2847D60", Offset = "0x2847160", VA = "0x182847D60")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request TEYHKDCMZMD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2847E80", Offset = "0x2847280", VA = "0x182847E80")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NOBNTZOERHO? ZPNFGQLVWPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2847D90", Offset = "0x2847190", VA = "0x182847D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ZIFYNAHDVNO? NCWHIAXLMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2847D00", Offset = "0x2847100", VA = "0x182847D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		internal LimitedCircuits(PRNNMMJSLKB circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class HPBXUUSYRFT : KVKSDIRUDBG
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HHTJOUQDZBZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public VTCCODAZOLE KAEMOZPBLZU;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public HHTJOUQDZBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			internal VTCCODAZOLE PSXHUPKEXHC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RWYGVNVPHCG.VUJTJJOWWBJ HRMPBGJJHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PRNNMMJSLKB.VUJTJJOWWBJ FCUMHKWXNVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HCCGTESCYEY.VUJTJJOWWBJ FJRKQLYYQTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB> CONYTBARIYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.VUJTJJOWWBJ HRGRZLXHLSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DEPMCWKOSXQ QBMVFWJVZGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HWWVWTNKRNF BDSKFJNURTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JZZMFKCCSQP SKITHEBMTAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DSKKGSMHSDN RFGQBINISEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA6650", Offset = "0xAA5A50", VA = "0x180AA6650", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OJKJTUFQHTH TCIMFANLPRC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAA6680", Offset = "0xAA5A80", VA = "0x180AA6680", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28453D0", Offset = "0x28447D0", VA = "0x1828453D0")]
		private HPBXUUSYRFT(RWYGVNVPHCG.VUJTJJOWWBJ a, PRNNMMJSLKB.VUJTJJOWWBJ b, HCCGTESCYEY.VUJTJJOWWBJ c, BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB> d, CV2Request.VUJTJJOWWBJ e, DEPMCWKOSXQ f, HWWVWTNKRNF g, JZZMFKCCSQP h, DSKKGSMHSDN i, OJKJTUFQHTH j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2844F30", Offset = "0x2844330", VA = "0x182844F30")]
		public static HPBXUUSYRFT? FWEDFWSIKDU(HCCGTESCYEY.VUJTJJOWWBJ cv2RootSysDeps, [Optional] RWYGVNVPHCG.VUJTJJOWWBJ? a, [Optional] PRNNMMJSLKB.VUJTJJOWWBJ? b, [Optional] BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>? reducerDeps, [Optional] CV2Request.VUJTJJOWWBJ? c, [Optional] DEPMCWKOSXQ? d, [Optional] HWWVWTNKRNF? e, [Optional] JZZMFKCCSQP? f, [Optional] DSKKGSMHSDN? g, [Optional] OJKJTUFQHTH? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2845280", Offset = "0x2844680", VA = "0x182845280")]
		public static HPBXUUSYRFT MYLIPUOCEDY(VTCCODAZOLE a, [Optional] RWYGVNVPHCG.VUJTJJOWWBJ? circuitsLifecycleDeps, [Optional] PRNNMMJSLKB.VUJTJJOWWBJ? circuitsManagerDeps, [Optional] BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2844BC0", Offset = "0x2843FC0", VA = "0x182844BC0")]
		public static HPBXUUSYRFT BJPTTJGQDQE(GetNetworkObjectDelegate a, [Optional] RWYGVNVPHCG.VUJTJJOWWBJ? circuitsLifecycleDeps, [Optional] PRNNMMJSLKB.VUJTJJOWWBJ? circuitsManagerDeps, [Optional] BJTQVTWCTYS.UCTXXJIHGPQ<ActionKind, HJODGUBVAZG, PRNNMMJSLKB>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class DQUQREUJBWI
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class ADTOMERNIYL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public GetNetworkObjectDelegate TVXSHFAVVMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int MBBJVTXHICO;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ADTOMERNIYL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x283D120", Offset = "0x283C520", VA = "0x18283D120")]
			internal TWEXDEECSVL PFKUDMJZOAT(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x283D190", Offset = "0x283C590", VA = "0x18283D190")]
			internal TWEXDEECSVL[] PIBFTWIRGSG(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAA8420", Offset = "0xAA7820", VA = "0x180AA8420")]
			internal int CIGBUKKLVQO()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ADOHOXXPZNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public DynamicEnvironmentNetworkId NRMYAVGJXJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public ADTOMERNIYL VHOTALYTHEL;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ADOHOXXPZNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x283D070", Offset = "0x283C470", VA = "0x18283D070")]
			internal TWEXDEECSVL XCYCLDUKPBD(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly VUYLGSMGCXP BXYVIPVKPKO;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x283E310", Offset = "0x283D710", VA = "0x18283E310")]
		public static TWEXDEECSVL? EDKVRHJFOXM(Id32<JDQQUBYOTBT>? networkObject, [Optional] OFFIILFKXKM.SerializesIntoSavesDelegate? a, [Optional] OFFIILFKXKM.SerializesIntoInventionsDelegate? b, [Optional] OFFIILFKXKM.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x283E330", Offset = "0x283D730", VA = "0x18283E330")]
		public static VTCCODAZOLE? XAGIJHKJJIL(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] OKJTZHVBSRL? b, [Optional] MJEQGDROKLD? c, [Optional] GTTUDZWRUWR? d, [Optional] YHXGCLRLMUY? e, int f = 300000, bool g = false, bool h = false, [Optional] OOGWBDBBEEV? i, [Optional] XNNZVAKEGIZ? j, [Optional] EYCMMGHDMXU? k, [Optional] STTQVDDNEIJ? l, [Optional] JRDFSFUEYIS? m, [Optional] DNSSRIZNGOJ? n, [Optional] VZPXXBIZHZJ.VUJTJJOWWBJ? o, [Optional] EqualsNodeV2.VUJTJJOWWBJ? p, [Optional] AIHNJNRGCJX? q, [Optional] VTCCODAZOLE.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] VTCCODAZOLE.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] VTCCODAZOLE.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] VTCCODAZOLE.GetLocalRoomIdDelegate? u, [Optional] VTCCODAZOLE.GetLocalSubroomIdDelegate? v, [Optional] VTCCODAZOLE.GetSubroomIdsForLocalRoomDelegate? w, [Optional] VTCCODAZOLE.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] VTCCODAZOLE.SaveRoomOnPlayerBehalfDelegate? z, [Optional] VTCCODAZOLE.ReportCloudDataLedgerChangedDelegate? ba, [Optional] VTCCODAZOLE.GetColorNameByIdDelegate? bb, [Optional] VTCCODAZOLE.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] VTCCODAZOLE.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] VTCCODAZOLE.GetTaggableNameFromSignalDelegate? be, [Optional] VTCCODAZOLE.GetAudioNameFromSignalDelegate? bf, [Optional] VTCCODAZOLE.GetDestinationNameFromSignalDelegate? bg, [Optional] VTCCODAZOLE.GetPlayerEventNameFromSignalDelegate? bh, [Optional] VTCCODAZOLE.GetRoomKeyNameFromSignalDelegate? bi, [Optional] VTCCODAZOLE.GetRewardNameFromSignalDelegate? bj, [Optional] VTCCODAZOLE.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] VTCCODAZOLE.ReportPreloadedAudioChangedDelegate? bl, [Optional] VTCCODAZOLE.ReportRewardDataChangedDelegate? bm, [Optional] VTCCODAZOLE.GetConsumableNameFromSignalDelegate? bn, [Optional] VTCCODAZOLE.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] VTCCODAZOLE.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] VTCCODAZOLE.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] VTCCODAZOLE.GetInventoryItemNameFromSignalDelegate? br, [Optional] VTCCODAZOLE.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] VTCCODAZOLE.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] VTCCODAZOLE.GetRoomOfferNameFromSignalDelegate? bu, [Optional] VTCCODAZOLE.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] VTCCODAZOLE.GetObjectIdFromCreationObjectDelegate? bw, [Optional] VTCCODAZOLE.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] VTCCODAZOLE.GetCostInBytesDelegate? by, [Optional] VTCCODAZOLE.GetAvatarItemNameFromSignalDelegate? bz, [Optional] VTCCODAZOLE.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] VTCCODAZOLE.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] VTCCODAZOLE.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] VTCCODAZOLE.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] VTCCODAZOLE.GetStoreItemNameFromSignalDelegate? ce, [Optional] VTCCODAZOLE.GetBodyPartNameFromSignalDelegate? cf, [Optional] VTCCODAZOLE.GetDependenciesForGraphInstanceDelegate? cg, [Optional] VTCCODAZOLE.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] VTCCODAZOLE.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] VTCCODAZOLE.GetRecNetImageNameFromSignalDelegate? cj, [Optional] VTCCODAZOLE.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] VTCCODAZOLE.IsFunctionValidForAIDelegate? cm, [Optional] VTCCODAZOLE.GetAIFunctionNameFromSignalDelegate? cn)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<JDQQUBYOTBT>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class EXKYDTUYCOX : EYCMMGHDMXU
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly EXKYDTUYCOX ZOZTORXSSBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly GetLocalPlayerDelegate? JUNTGBZLNKW;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x28442E0", Offset = "0x28436E0", VA = "0x1828442E0", Slot = "4")]
		public (FYVWJBXROPB, FYVWJBXROPB, FYVWJBXROPB, FYVWJBXROPB, FYVWJBXROPB) UWVQCPQLKAR(object a)
		{
			return default((FYVWJBXROPB, FYVWJBXROPB, FYVWJBXROPB, FYVWJBXROPB, FYVWJBXROPB));
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x28442B0", Offset = "0x28436B0", VA = "0x1828442B0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "6")]
		public bool SNUBYQZVLOI(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xB05350", Offset = "0xB04750", VA = "0x180B05350", Slot = "7")]
		public string MEHLBYWTUHU(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public EXKYDTUYCOX([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class OFFIILFKXKM : TWEXDEECSVL
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(OFFIILFKXKM self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(OFFIILFKXKM self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(OFFIILFKXKM self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoSavesDelegate HPBDGOJMUFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly SerializesIntoInventionsDelegate OOYNIQQNZCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly CanPublishInInventionsDelegate TCGJXSTSPYJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private QXQYLDKMTDR? XFLVLXFYHOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId QIEUDNWPEDU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF9480", Offset = "0xCF8880", VA = "0x180CF9480", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PNQVMEUWNQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2848630", Offset = "0x2847A30", VA = "0x182848630", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool SQMNNXORFXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2848600", Offset = "0x2847A00", VA = "0x182848600", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool TEJOHNBPXJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x28485D0", Offset = "0x28479D0", VA = "0x1828485D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public SSGMLNNAZUW? RWNZGAIAHSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<JDQQUBYOTBT>? JYZDFMYIVNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2848480", Offset = "0x2847880", VA = "0x182848480", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2847F30", Offset = "0x2847330", VA = "0x182847F30", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(VUYLGSMGCXP e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0", Slot = "13")]
		public void Bind(QXQYLDKMTDR controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2848520", Offset = "0x2847920", VA = "0x182848520")]
		private OFFIILFKXKM(Id32<JDQQUBYOTBT>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2847FD0", Offset = "0x28473D0", VA = "0x182847FD0")]
		public static OFFIILFKXKM? New(Id32<JDQQUBYOTBT>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class ICQVROHJLWY : OOGWBDBBEEV
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
		public static readonly ICQVROHJLWY ZOZTORXSSBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly RoundToDecimalPlaceDelegate? XEXCFLYCVDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly TruncateToDecimalPlaceDelegate? USZAKBHCFWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorLerpDelegate? DPAMCFZURJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsColorInverseLerpDelegate? UILSKBXPXBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetPositionDelegate? QLAYNQNTGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4GetRotationDelegate? EOQYFEWTXCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4InverseDelegate? EKBXHBHDGAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4MultiplyDelegate? OAFYKRDPNMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? XXXCRSHXDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatDotDelegate? SFKUOBGCKPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromAngleAxisDelegate? UOWHYWGPGPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? QUPTWXWHYLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromFromToRotationDelegate? BUGWNXLCIZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromLookRotationDelegate? HGZCZPOVKUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? GIZXYFZAXUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatInverseDelegate? JPGAKVCWBQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpDelegate? UHUHZDAANSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatLerpUnclampedDelegate? WWUMBPJTOJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatInverseLerpDelegate? GFGCYQNJFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatMultiplyDelegate? QCCCZOWXPJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatNormalizeDelegate? CEPIQPXYOQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateTowardsDelegate? ICTNFVVORUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatRotateVectorDelegate? LYSEDRHGEMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatSlerpDelegate? KTCUEGZWJSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToAngleAxisDelegate? YIUXVVVBJUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatToEulerAnglesDelegate? PBJTRNXXJQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3AddDelegate? YIJUUBGWACH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? BKTTSLWUKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? YJADPMAATWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3CrossDelegate? LNOYNSTAQAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3DotDelegate? GBJPOXSZRQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3AngleDelegate? UBRMLPGCWFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3GetMagnitudeDelegate? MYFFBQDHMXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpDelegate? TKLTKIBVWYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3LerpUnclampedDelegate? HAUQQWTQLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3InverseLerpDelegate? CPYAURDQPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3MoveTowardsDelegate? EMIKZDISVJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NegateDelegate? UKASQRGJDYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3NormalizeDelegate? HCZFXKJGFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectDelegate? PXJCBLXVELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? HGUORCCKHTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ScaleDelegate? SUBKMICUIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SmoothDampDelegate? EUURKIPRALS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SubtractDelegate? RCLSETZCKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SlerpDelegate? UXQAEIEDMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3TransformDelegate? YKUNROSKKCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3InverseTransformDelegate? CAXSUOBJTME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly RealtimeSinceStartupDelegate? NRWWZKAVYCR;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2847600", Offset = "0x2846A00", VA = "0x182847600")]
		public ICQVROHJLWY([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x28470B0", Offset = "0x28464B0", VA = "0x1828470B0")]
		public float VZCCATRENIV([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2845AD0", Offset = "0x2844ED0", VA = "0x182845AD0")]
		public float EAXCRWUALUH([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2845940", Offset = "0x2844D40", VA = "0x182845940")]
		public CircuitsColor CUEEGUYCGVG([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28459A0", Offset = "0x2844DA0", VA = "0x1828459A0")]
		public float CWAJXVSNMRA([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2847050", Offset = "0x2846450", VA = "0x182847050")]
		public CircuitsVec3 TIFQYIJJNNU([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28459D0", Offset = "0x2844DD0", VA = "0x1828459D0")]
		public CircuitsQuat CYRGKAXHUMH([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2846D40", Offset = "0x2846140", VA = "0x182846D40")]
		public CircuitsMtx4x4 RNSTRZIZPJH([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2845B60", Offset = "0x2844F60", VA = "0x182845B60")]
		public CircuitsMtx4x4 EFBTDDNKVCT([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2845EC0", Offset = "0x28452C0", VA = "0x182845EC0")]
		public CircuitsMtx4x4 HKTELZKMSPV([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2845920", Offset = "0x2844D20", VA = "0x182845920")]
		public float CTNBWPOWBBG([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28462E0", Offset = "0x28456E0", VA = "0x1828462E0")]
		public CircuitsQuat IVUCHCGODLD(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2845700", Offset = "0x2844B00", VA = "0x182845700")]
		public CircuitsQuat CACLKDPEZQW([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2845870", Offset = "0x2844C70", VA = "0x182845870")]
		public CircuitsQuat LSTKPDUGEMW([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2845A20", Offset = "0x2844E20", VA = "0x182845A20")]
		public CircuitsQuat DAPYPIZZEVO([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2845CB0", Offset = "0x28450B0", VA = "0x182845CB0")]
		public CircuitsQuat FIKZGRNVDCX([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28454C0", Offset = "0x28448C0", VA = "0x1828454C0")]
		public CircuitsQuat OZYGQHEFLAY([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28460F0", Offset = "0x28454F0", VA = "0x1828460F0")]
		public CircuitsQuat LXUTKDVBLWX([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2845DB0", Offset = "0x28451B0", VA = "0x182845DB0")]
		public float GXDBBGDHSOK([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2845610", Offset = "0x2844A10", VA = "0x182845610")]
		public CircuitsQuat BBGDQQHSXRL([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2845FF0", Offset = "0x28453F0", VA = "0x182845FF0")]
		public CircuitsQuat HPKDGKVDXLO([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2846E60", Offset = "0x2846260", VA = "0x182846E60")]
		public CircuitsQuat UGTQUEVCVKO([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2846BF0", Offset = "0x2845FF0", VA = "0x182846BF0")]
		public CircuitsVec3 REFLGXOOTKV([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2845F30", Offset = "0x2845330", VA = "0x182845F30")]
		public CircuitsQuat HTANLFWYGXF([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28456C0", Offset = "0x2844AC0", VA = "0x1828456C0")]
		public void GGYAEXBCPZA([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2845D50", Offset = "0x2845150", VA = "0x182845D50")]
		public CircuitsVec3 GBUXUHFNUMF([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2845580", Offset = "0x2844980", VA = "0x182845580")]
		public CircuitsVec3 AMFUNEMDIUQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28471B0", Offset = "0x28465B0", VA = "0x1828471B0")]
		public CircuitsVec3 VNQOGBSRFMS([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2846AB0", Offset = "0x2845EB0", VA = "0x182846AB0")]
		public CircuitsVec3 QCHESTUXCGD([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28463B0", Offset = "0x28457B0", VA = "0x1828463B0")]
		public CircuitsVec3 JQOSVHVSDOX([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2846960", Offset = "0x2845D60", VA = "0x182846960")]
		public float OQVBTGZYKUU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2846600", Offset = "0x2845A00", VA = "0x182846600")]
		public float LCYRUIVBTJW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2846390", Offset = "0x2845790", VA = "0x182846390")]
		public float JLOVMXRKYXR([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2845DE0", Offset = "0x28451E0", VA = "0x182845DE0")]
		public CircuitsVec3 HBYHKHVWJKE([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2845C40", Offset = "0x2845040", VA = "0x182845C40")]
		public CircuitsVec3 FGDWKFBNOVF([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2846930", Offset = "0x2845D30", VA = "0x182846930")]
		public float NZBAKCCISMG([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2846A40", Offset = "0x2845E40", VA = "0x182846A40")]
		public CircuitsVec3 PRUBKKKRURC([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2845810", Offset = "0x2844C10", VA = "0x182845810")]
		public CircuitsVec3 CKXXDDBIEHB([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2846B20", Offset = "0x2845F20", VA = "0x182846B20")]
		public CircuitsVec3 QCWAEXLVGUY([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2846C60", Offset = "0x2846060", VA = "0x182846C60")]
		public CircuitsVec3 RNCDUBWJMVI([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2846420", Offset = "0x2845820", VA = "0x182846420")]
		public CircuitsVec3 JVLCMODDPZV([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28469D0", Offset = "0x2845DD0", VA = "0x1828469D0")]
		public CircuitsVec3 PFCOZOLQNER([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2846490", Offset = "0x2845890", VA = "0x182846490")]
		public CircuitsVec3 KPHXAUAWGOF([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28457A0", Offset = "0x2844BA0", VA = "0x1828457A0")]
		public CircuitsVec3 CBZKEBTRYXP([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2847290", Offset = "0x2846690", VA = "0x182847290")]
		public CircuitsVec3 WCJQYLDRKYD([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2845BD0", Offset = "0x2844FD0", VA = "0x182845BD0")]
		public CircuitsVec3 EKZSBOPFALZ([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28467F0", Offset = "0x2845BF0", VA = "0x1828467F0")]
		public CircuitsVec3 MTRFCPRWUHL([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2846620", Offset = "0x2845A20", VA = "0x182846620", Slot = "50")]
		public Task LSWHYUTQVGH(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "51")]
		public void ERWEOSEMQFB([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2846E10", Offset = "0x2846210", VA = "0x182846E10", Slot = "52")]
		public XRPUYCJXMWS<KZGUMKWBJGS> RYNOXFSJDST()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2846980", Offset = "0x2845D80", VA = "0x182846980", Slot = "53")]
		public XRPUYCJXMWS<KZGUMKWBJGS> OVPHAWUUNMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28455F0", Offset = "0x28449F0", VA = "0x1828455F0", Slot = "54")]
		public float APODZORYWJS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28470B0", Offset = "0x28464B0", VA = "0x1828470B0", Slot = "4")]
		private float TOQCWUJZPTF([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2845AD0", Offset = "0x2844ED0", VA = "0x182845AD0", Slot = "5")]
		private float NSSLOKTVYZD([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2846F80", Offset = "0x2846380", VA = "0x182846F80", Slot = "6")]
		private CircuitsColor SKLGHDLJRGC([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28459A0", Offset = "0x2844DA0", VA = "0x1828459A0", Slot = "7")]
		private float QZTBKGLHHTW([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2846210", Offset = "0x2845610", VA = "0x182846210", Slot = "8")]
		private CircuitsVec3 IPYCJAGNVMQ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28465B0", Offset = "0x28459B0", VA = "0x1828465B0", Slot = "9")]
		private CircuitsQuat LCQLXODWUEB([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2847300", Offset = "0x2846700", VA = "0x182847300", Slot = "10")]
		private CircuitsMtx4x4 WEXYGSHDFVF([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2846090", Offset = "0x2845490", VA = "0x182846090", Slot = "11")]
		private CircuitsMtx4x4 HUNESPUDLRH([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2846DB0", Offset = "0x28461B0", VA = "0x182846DB0", Slot = "12")]
		private CircuitsMtx4x4 RTQIXAJTYKF([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2845920", Offset = "0x2844D20", VA = "0x182845920", Slot = "13")]
		private float DHJZMBHGUTA([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28462E0", Offset = "0x28456E0", VA = "0x1828462E0", Slot = "14")]
		private CircuitsQuat WVCFDSNIFRN(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2845700", Offset = "0x2844B00", VA = "0x182845700", Slot = "15")]
		private CircuitsQuat OPSYRTCULYQ([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2845870", Offset = "0x2844C70", VA = "0x182845870", Slot = "16")]
		private CircuitsQuat CLKOKVEVDGU([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2845A20", Offset = "0x2844E20", VA = "0x182845A20", Slot = "17")]
		private CircuitsQuat WUVCYANWVVM([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2845CB0", Offset = "0x28450B0", VA = "0x182845CB0", Slot = "18")]
		private CircuitsQuat MEAUOTEPRNX([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x28454C0", Offset = "0x28448C0", VA = "0x1828454C0", Slot = "19")]
		private CircuitsQuat AANZKABTXAW([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x28460F0", Offset = "0x28454F0", VA = "0x1828460F0", Slot = "20")]
		private CircuitsQuat IIHNBZAULMF([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2845DB0", Offset = "0x28451B0", VA = "0x182845DB0", Slot = "21")]
		private float JXMNHLQGOSM([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2845610", Offset = "0x2844A10", VA = "0x182845610", Slot = "22")]
		private CircuitsQuat XQUTCANEFAH([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2845FF0", Offset = "0x28453F0", VA = "0x182845FF0", Slot = "23")]
		private CircuitsQuat ZZIKBLJGOYG([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2846E60", Offset = "0x2846260", VA = "0x182846E60", Slot = "24")]
		private CircuitsQuat SHSFRFJBVFO([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2846CD0", Offset = "0x28460D0", VA = "0x182846CD0", Slot = "25")]
		private CircuitsVec3 RNOEFHILPAL([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2845F30", Offset = "0x2845330", VA = "0x182845F30", Slot = "26")]
		private CircuitsQuat HMSJIPJDHTX([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x28456C0", Offset = "0x2844AC0", VA = "0x1828456C0", Slot = "27")]
		private void BLWIDAWYUUM([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28461B0", Offset = "0x28455B0", VA = "0x1828461B0", Slot = "28")]
		private CircuitsVec3 ILQGLCAGNEL([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2846FE0", Offset = "0x28463E0", VA = "0x182846FE0", Slot = "29")]
		private CircuitsVec3 TGLPOSZHMNA([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2846270", Offset = "0x2845670", VA = "0x182846270", Slot = "30")]
		private CircuitsVec3 IQGPSREMGZO([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2846B80", Offset = "0x2845F80", VA = "0x182846B80", Slot = "31")]
		private CircuitsVec3 QHUEGXHGYCZ([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2846650", Offset = "0x2845A50", VA = "0x182846650", Slot = "32")]
		private CircuitsVec3 MBSCNYARMYF([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2847140", Offset = "0x2846540", VA = "0x182847140", Slot = "33")]
		private CircuitsVec3 VJUQTODZRDH([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2846780", Offset = "0x2845B80", VA = "0x182846780", Slot = "34")]
		private CircuitsVec3 MQETTYJIHOH([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2846960", Offset = "0x2845D60", VA = "0x182846960", Slot = "35")]
		private float PKFJBDLZVHI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2846600", Offset = "0x2845A00", VA = "0x182846600", Slot = "36")]
		private float WPIDRKNTVSW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2846390", Offset = "0x2845790", VA = "0x182846390", Slot = "37")]
		private float OGWRNDPXLOJ([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2846860", Offset = "0x2845C60", VA = "0x182846860", Slot = "38")]
		private CircuitsVec3 NFIMAEYAFKO([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2845E50", Offset = "0x2845250", VA = "0x182845E50", Slot = "39")]
		private CircuitsVec3 HCVYVIACMKJ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2846930", Offset = "0x2845D30", VA = "0x182846930", Slot = "40")]
		private float PEFAGDYFEQE([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2847220", Offset = "0x2846620", VA = "0x182847220", Slot = "41")]
		private CircuitsVec3 VZYEKCPLLPU([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2846F20", Offset = "0x2846320", VA = "0x182846F20", Slot = "42")]
		private CircuitsVec3 SJRVMGZLUBL([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x28468D0", Offset = "0x2845CD0", VA = "0x1828468D0", Slot = "43")]
		private CircuitsVec3 NJPEIYDCNFE([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2847360", Offset = "0x2846760", VA = "0x182847360", Slot = "44")]
		private CircuitsVec3 WNFYMDKUEOQ([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2846540", Offset = "0x2845940", VA = "0x182846540", Slot = "45")]
		private CircuitsVec3 LASNSBNTOFD([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28473D0", Offset = "0x28467D0", VA = "0x1828473D0", Slot = "46")]
		private CircuitsVec3 WWFINSXHGVN([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28466C0", Offset = "0x2845AC0", VA = "0x1828466C0", Slot = "47")]
		private CircuitsVec3 MJACCCSOYSH([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2845AF0", Offset = "0x2844EF0", VA = "0x182845AF0", Slot = "48")]
		private CircuitsVec3 EEQZDSSXRXZ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x28470D0", Offset = "0x28464D0", VA = "0x1828470D0", Slot = "49")]
		private CircuitsVec3 VHMMFJCYARD([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class UANQBUHNGNO : CERLBTBJFVL
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x1061380", Offset = "0x1060780", VA = "0x181061380", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xF992B0", Offset = "0xF986B0", VA = "0x180F992B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x284C050", Offset = "0x284B450", VA = "0x18284C050")]
		public UANQBUHNGNO(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class HNRTJXNPPPO : XNNZVAKEGIZ
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(ZSXZLQTRHHU e, EMPFHIORGPD invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly HNRTJXNPPPO ZOZTORXSSBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetCircuitsColorFromColorIndexDelegate? QAOVUMJKJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? ZLCYMXUFUZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly InvisibleCollisionSetEnabledDelegate? IKXNIOICCUU;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB2DA60", Offset = "0xB2CE60", VA = "0x180B2DA60")]
		public HNRTJXNPPPO([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2844AD0", Offset = "0x2843ED0", VA = "0x182844AD0", Slot = "4")]
		public CircuitsColor ZKNWVSPINKY(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2844AB0", Offset = "0x2843EB0", VA = "0x182844AB0")]
		public int BHNSJWQZDYE([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2844AB0", Offset = "0x2843EB0", VA = "0x182844AB0", Slot = "5")]
		private int SQOAIBXKYIZ([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class TGKSMWCQLDN : AMDHPBOPJWY
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class PCTWUZZDIJC
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid BHBYMRCMFSQ
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xC28720", Offset = "0xC27B20", VA = "0x180C28720")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long CYUYTKNCFOV
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int SSHVHVXCIXV
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xAA5980", Offset = "0xAA4D80", VA = "0x180AA5980")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool WNSOGLMOOMS
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x1821DC0", Offset = "0x18211C0", VA = "0x181821DC0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool PASQMRTAZTQ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x1821A10", Offset = "0x1820E10", VA = "0x181821A10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool AXWPKYHMWJB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x2848CB0", Offset = "0x28480B0", VA = "0x182848CB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2848CD0", Offset = "0x28480D0", VA = "0x182848CD0")]
			public PCTWUZZDIJC(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly Dictionary<Id128<YAEGQIMTQZT>, PCTWUZZDIJC> RUIRQLETWZP;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x28492C0", Offset = "0x28486C0", VA = "0x1828492C0")]
		public bool BDARRZAIYJS([In] Id128<YAEGQIMTQZT> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x28494F0", Offset = "0x28488F0", VA = "0x1828494F0")]
		public void MJDJZKHTNEM([In] Id128<YAEGQIMTQZT> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2849620", Offset = "0x2848A20", VA = "0x182849620")]
		public void MJDJZKHTNEM([In] Id128<YAEGQIMTQZT> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x28493D0", Offset = "0x28487D0", VA = "0x1828493D0")]
		public void PYLDCXKHBDX([In] Id128<YAEGQIMTQZT> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x28495C0", Offset = "0x28489C0", VA = "0x1828495C0")]
		public void LFAZASJLEQC([In] Id128<YAEGQIMTQZT> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2849700", Offset = "0x2848B00", VA = "0x182849700")]
		public bool WNSOGLMOOMS([In] Id128<YAEGQIMTQZT> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2849790", Offset = "0x2848B90", VA = "0x182849790")]
		public TGKSMWCQLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x28492C0", Offset = "0x28486C0", VA = "0x1828492C0", Slot = "4")]
		private bool AUMIDRAJBSN([In] Id128<YAEGQIMTQZT> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x28494F0", Offset = "0x28488F0", VA = "0x1828494F0", Slot = "5")]
		private void IYRVGKUCTYV([In] Id128<YAEGQIMTQZT> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x28493D0", Offset = "0x28487D0", VA = "0x1828493D0", Slot = "6")]
		private void CFSTGGKLZDW([In] Id128<YAEGQIMTQZT> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x28495C0", Offset = "0x28489C0", VA = "0x1828495C0", Slot = "7")]
		private void KFOVAKXKUQP([In] Id128<YAEGQIMTQZT> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2849700", Offset = "0x2848B00", VA = "0x182849700", Slot = "8")]
		private bool QPSGGDGVTAZ([In] Id128<YAEGQIMTQZT> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class SUJYTNPHYCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2848E90", Offset = "0x2848290", VA = "0x182848E90")]
		public static LogDeps TXSTMNYBBBB()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class EPGSDMWZJZT : MeshLibrary.VUJTJJOWWBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
		public byte[]? TBGIRZYHTZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
		public void TSQUGGEIGFX(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public EPGSDMWZJZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class EVDOZXNZZYO : OKJTZHVBSRL
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
		public delegate void ConfigureAttachedObjectDelegate(PYUVBLAJANF controlPanel, HDGORUDUZAT staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<QEMJZGJSIYE> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, ZEEUKBHYSTE>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, ZEEUKBHYSTE>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, ZEEUKBHYSTE>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, ZEEUKBHYSTE>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Task<Result<MultiResult, ZEEUKBHYSTE>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private TaskAwaiter<Result<MultiResult, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x284AF70", Offset = "0x284A370", VA = "0x18284AF70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x284B230", Offset = "0x284A630", VA = "0x18284B230", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private TaskAwaiter<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x284B2A0", Offset = "0x284A6A0", VA = "0x18284B2A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x284B560", Offset = "0x284A960", VA = "0x18284B560", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public Task<Result<None, ZEEUKBHYSTE>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private TaskAwaiter<Result<None, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x284B5D0", Offset = "0x284A9D0", VA = "0x18284B5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x284B890", Offset = "0x284AC90", VA = "0x18284B890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<string, EnumChoiceData> UQUQQBOCCIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<int, string> LNXXFHKVEGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<object> VXDNVLSYZWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly List<Guid> CAVYYQLOVZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly CanLocalPlayerCreateCurrencyDelegate NLOFKLPEDKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ShowRoomCurrencyCreationUIDelegate JDQBXUJSBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly GetAudioClipOptionsDelegate VMOLPDJIGVV;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly IReadOnlyDictionary<Guid, int> POBXIYCGEXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipGuidToIndexMapDelegate VGBRQHEMQTH;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<int, Guid> KIHDUDAUMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipIndexToGuidMapDelegate NMTFFITSJIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly GetAllAudioClipOptionsDelegate DUDJRSFTWEC;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly IReadOnlyDictionary<Guid, int> TBBUACIGPTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate YYUJMNHIMSW;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<int, Guid> TOEVZVSFAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate RPQMHFJMFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly PlayAudioPreviewDelegate DAJOKTEGEAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly StopAudioPreviewDelegate FEVWVTMPTCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SubscriptionIsActiveDelegate TPBPAKECJFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate ZRWWFQKNULJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly Dictionary<string, EnumChoiceData> RBBHCWVICJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly ShowQuickChatEditMenuDelegate YSYZZYBOYOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly ConfigureAttachedObjectDelegate BUDBXUQKJBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly DisplayInvalidNameErrorMessageDelegate LGKPPTDBTVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly IsStringPureDelegate DEHUFYSJBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly TryGetSpecificChipConfigSummaryDelegate CZKODWARMEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReleaseIconIdDelegate TUMFHBDSYGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate ZPGQHQSOXLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 RJDQNPDGCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 RJIXKVXDLPL;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment BRLHTMOSVKP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool NADXWOHEGLE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xAF68E0", Offset = "0xAF5CE0", VA = "0x180AF68E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> EKUKRGGQBTT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> SFWALSSEJXG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> ZSALSILETQD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> MQYUEIZSXWF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xAAFB60", Offset = "0xAAEF60", VA = "0x180AAFB60", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion XWCHMIDUVNV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD2DA40", Offset = "0xD2CE40", VA = "0x180D2DA40", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool UDIPVEEQCCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xBF4880", Offset = "0xBF3C80", VA = "0x180BF4880", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool COKTRMENKQS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x28429D0", Offset = "0x2841DD0", VA = "0x1828429D0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool GUUSPPVDLJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2842CE0", Offset = "0x28420E0", VA = "0x182842CE0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool RAZPOLKKBHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xAB0FD0", Offset = "0xAB03D0", VA = "0x180AB0FD0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2842F00", Offset = "0x2842300", VA = "0x182842F00")]
		public EVDOZXNZZYO([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2842890", Offset = "0x2841C90", VA = "0x182842890", Slot = "9")]
		public bool MPTYDUUHNSP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50")]
		public static bool CSKVXPBKSGC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x28427D0", Offset = "0x2841BD0", VA = "0x1828427D0", Slot = "10")]
		public bool ITWINPLQKTH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		public static void LQCPVVQJIWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xC2AA70", Offset = "0xC29E70", VA = "0x180C2AA70", Slot = "11")]
		public void IZDREKKPFMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2842CF0", Offset = "0x28420F0", VA = "0x182842CF0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XAAOPJHFQIV(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2842430", Offset = "0x2841830", VA = "0x182842430", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> AKENOCHSVKI(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x28429E0", Offset = "0x2841DE0", VA = "0x1828429E0")]
		private static IReadOnlyDictionary<Guid, int> OKJRWDXVZRX(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2842CB0", Offset = "0x28420B0", VA = "0x182842CB0", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> VZNLCBQWOPC(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2842C10", Offset = "0x2842010", VA = "0x182842C10")]
		private static IReadOnlyDictionary<int, Guid> SZZTZQZAUCN(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2842860", Offset = "0x2841C60", VA = "0x182842860", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> MGZFLZBCAWQ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2842670", Offset = "0x2841A70", VA = "0x182842670")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BSLHQYOCYWQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2833FE0", Offset = "0x28333E0", VA = "0x182833FE0", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> UEYMPDTFFBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2842C60", Offset = "0x2842060", VA = "0x182842C60")]
		private static IReadOnlyDictionary<Guid, int> URYQDAJECJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x28426A0", Offset = "0x2841AA0", VA = "0x1828426A0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> CDFHQGKZMUR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2842770", Offset = "0x2841B70", VA = "0x182842770", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> GTBHOXKDNMR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		private static void FQYBICBRYUH(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2842950", Offset = "0x2841D50", VA = "0x182842950", Slot = "18")]
		public void MRMEOJJLGZQ(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		private static void OITMWMZCCUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2842640", Offset = "0x2841A40", VA = "0x182842640", Slot = "19")]
		public void BJOILYIXMTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50")]
		private static bool FLWGFAOLUCS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x28425B0", Offset = "0x28419B0", VA = "0x1828425B0", Slot = "20")]
		public bool BDOQHHKXHWF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50")]
		public static bool IIPUIEKRUOZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2842460", Offset = "0x2841860", VA = "0x182842460", Slot = "21")]
		public bool AYNDKNDXIZO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2842D20", Offset = "0x2842120", VA = "0x182842D20", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> YONLHDJWBMR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> FNPFZKUGGVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> UMYBKCARLZZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2842830", Offset = "0x2841C30", VA = "0x182842830", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> MBKVNJVOOOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> JATVCGCLSIS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> KIVFKPPWXZQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		public static void TLLMSBAMKHS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2842D50", Offset = "0x2842150", VA = "0x182842D50", Slot = "29")]
		public void ZREZIULRUCL(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		private static void VFWDYGQHOMC(PYUVBLAJANF a, HDGORUDUZAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2842800", Offset = "0x2841C00", VA = "0x182842800", Slot = "35")]
		public void IUSILIVSAHD(PYUVBLAJANF a, HDGORUDUZAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "36")]
		public Dictionary<string, EnumChoiceData> EULHVPJXYJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "37")]
		public Dictionary<string, EnumChoiceData> MUGLQVCWCIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		private static void YQDHCGUKMJM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x28425E0", Offset = "0x28419E0", VA = "0x1828425E0")]
		private static Task<bool> BESFUXYNSXU(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2842490", Offset = "0x2841890", VA = "0x182842490", Slot = "38")]
		public Task<bool> AYUNNIRZFNL(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x28426D0", Offset = "0x2841AD0", VA = "0x1828426D0")]
		private static bool ENTMLIZHCMQ(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2842990", Offset = "0x2841D90", VA = "0x182842990", Slot = "39")]
		public bool NITZDUDGBZB(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		private static void VPPOSHCTNTO(Id32<QEMJZGJSIYE> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x28427A0", Offset = "0x2841BA0", VA = "0x1828427A0", Slot = "40")]
		public void IRGPDNJIOFV(Id32<QEMJZGJSIYE> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x28424C0", Offset = "0x28418C0", VA = "0x1828424C0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, ZEEUKBHYSTE>> BBTSSNGJPQW(Task<Result<None, ZEEUKBHYSTE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2842740", Offset = "0x2841B40", VA = "0x182842740", Slot = "41")]
		public Task<Result<None, ZEEUKBHYSTE>> FNCKUCBOYAJ(Task<Result<None, ZEEUKBHYSTE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2842A30", Offset = "0x2841E30", VA = "0x182842A30")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, ZEEUKBHYSTE>> QPVJZTVMJTW(Task<Result<MultiResult, ZEEUKBHYSTE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2842710", Offset = "0x2841B10", VA = "0x182842710", Slot = "42")]
		public Task<Result<MultiResult, ZEEUKBHYSTE>> FNCKUCBOYAJ(Task<Result<MultiResult, ZEEUKBHYSTE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2842B20", Offset = "0x2841F20", VA = "0x182842B20")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> QQAQXAPJTFF(Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x28426E0", Offset = "0x2841AE0", VA = "0x1828426E0", Slot = "43")]
		public Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> FNCKUCBOYAJ(Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class GTTUDZWRUWR : LJSCZFYMNAA
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(VUYLGSMGCXP e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private InteropDelegate? DLECHNHBBBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate FKMPVWRUGVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly InteropDelegate SEODEVDOBPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InteropDelegate? QUIPQIHZJNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private InvokeStudioFunctionDelegate? OKIXVYDOOEP;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "5")]
		public LegacyCV2Result<None> QIZSATWQYCP(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350")]
		private static LegacyCV2Result<None> Default(VUYLGSMGCXP _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "6")]
		public LegacyCV2Result<None> OMTFWLPCJTA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "7")]
		public LegacyCV2Result<None> HXWUPRCEYZJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "8")]
		public LegacyCV2Result<None> AAOILVXSZDM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "9")]
		public LegacyCV2Result<None> DKFXGKGWMYS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "15")]
		public LegacyCV2Result<None> RJRTVYWOXWL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YNNKVVEOCMF(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CFUJODFRPOD(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YIQMBRDTUJW(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NHXKXJMRBXL(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UGRAWSFOVQG(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HTXFNVGRJTW(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KHWLMNQMZVV(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "93")]
		public LegacyCV2Result<None> SJBQWRYONGS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "94")]
		public LegacyCV2Result<None> HIXHMCQUMDS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "95")]
		public LegacyCV2Result<None> JGGQQRAERYR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VSANMNUUDJX(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(VUYLGSMGCXP e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XGABVIKVCAP(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MRCHFCTUKYL(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HDBIFELMHFK(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XIESTQVLLEN(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QPGEQIQTGEE(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CLBGWSZEGPA(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZRENIXMGNCG(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XERTVSHCYAD(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1247410", Offset = "0x1246810", VA = "0x181247410", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QPXTNIOIUTI(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IYFJIFESTYZ(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "119")]
		public LegacyCV2Result<None> HCDSESHCSLX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DVJGSDVDTFU(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "121")]
		public LegacyCV2Result<None> JYISDGNKPAG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "122")]
		public LegacyCV2Result<None> WIQKJVNZGPI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "123")]
		public LegacyCV2Result<None> PUBLGOFMSJM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "124")]
		public LegacyCV2Result<None> HBOOFQVJLCK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "125")]
		public LegacyCV2Result<None> OWAZLNALCJO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "126")]
		public LegacyCV2Result<None> DNGJVAXTQRX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "818")]
		public LegacyCV2Result<None> ZKTXAWLTZDR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "819")]
		public LegacyCV2Result<None> RHGLMIJVVOL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "147")]
		public LegacyCV2Result<None> WLCCDPDUSAN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "148")]
		public LegacyCV2Result<None> DOGJNIGDBMV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "149")]
		public LegacyCV2Result<None> YGBRVNBGERS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "150")]
		public LegacyCV2Result<None> GOZATEIVZUM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "151")]
		public LegacyCV2Result<None> TZMQVBTAQGR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(VUYLGSMGCXP e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(VUYLGSMGCXP e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(VUYLGSMGCXP e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, LJSCZFYMNAA.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(VUYLGSMGCXP e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, LJSCZFYMNAA.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "174")]
		public LegacyCV2Result<None> UFNLRZCBAOM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "175")]
		public LegacyCV2Result<None> KGTDYRDYUQF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "176")]
		public LegacyCV2Result<None> RELOEDOEDCR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "197")]
		public LegacyCV2Result<None> ZAIQCUQPGIH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "198")]
		public LegacyCV2Result<None> SUBHJKWQCIC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "199")]
		public LegacyCV2Result<None> CDMVLNCQCPH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "200")]
		public LegacyCV2Result<None> JDYOQWNROFD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "201")]
		public LegacyCV2Result<None> YCJCWVCNCLF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "202")]
		public LegacyCV2Result<None> YDGYIRPYEIK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "203")]
		public LegacyCV2Result<None> JGQUKKLJZGA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "204")]
		public LegacyCV2Result<None> BUGBVRVZBJK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "205")]
		public LegacyCV2Result<None> DVKEJZURUYE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "206")]
		public LegacyCV2Result<None> LUKWWNRYHKQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "207")]
		public LegacyCV2Result<None> FMKHLRPIUXG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "208")]
		public LegacyCV2Result<None> KPKMNZHMZCU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "209")]
		public LegacyCV2Result<None> ROBRLXHJVHC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "210")]
		public LegacyCV2Result<None> DCJGYHSXFYD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "211")]
		public LegacyCV2Result<None> SHECPWBNWYW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "212")]
		public LegacyCV2Result<None> OGPGDABFXML(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "213")]
		public LegacyCV2Result<None> RHGEYUOMUNC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "214")]
		public LegacyCV2Result<None> LUSDVUPSDRX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "215")]
		public LegacyCV2Result<None> ODJIVSRDCLK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "274")]
		public LegacyCV2Result<None> DZCQNWOPGXG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "277")]
		public LegacyCV2Result<None> UXOMSPZAGJE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "279")]
		public LegacyCV2Result<None> UBVBYLQGCXJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "280")]
		public LegacyCV2Result<None> WYGGUWNEGVT(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "281")]
		public LegacyCV2Result<None> FMTXNBOJBYO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "282")]
		public LegacyCV2Result<None> HIGIYFDTBLZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "283")]
		public LegacyCV2Result<None> GLKRUQIWKNU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "287")]
		public LegacyCV2Result<None> QHCVRDSSNNV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "288")]
		public LegacyCV2Result<None> YMZSBLHCBOW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "317")]
		public LegacyCV2Result<None> RULUDNRJJEX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "406")]
		public LegacyCV2Result<None> DXGPGYTCINU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AWBIIOXKVRH(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MHPBVOQZYHD(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SBJUWNICQOL(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TNPJMFIQSNO(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XLRXHYFGKLJ(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "416")]
		public LegacyCV2Result<ROJVVKMMSCP.CV2DiscoverySectionType> LRBXSXHPKUU(VUYLGSMGCXP e, CircuitSignal a)
		{
			return default(LegacyCV2Result<ROJVVKMMSCP.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "417")]
		public LegacyCV2Result<None> IAPRUEORFOQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(VUYLGSMGCXP e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OJGEMYFROIA(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OZJSHHVLMFJ(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ACLRQKNBZHS(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "462")]
		public LegacyCV2Result<None> CSPBKIDBNCD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "463")]
		public LegacyCV2Result<None> ETBXHXXIKKS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "464")]
		public LegacyCV2Result<None> LXOETMTWMDD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "465")]
		public LegacyCV2Result<None> ZIIKUGRVAII(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "466")]
		public LegacyCV2Result<None> ZADQFDIRXSO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "467")]
		public LegacyCV2Result<None> BPTKTATUYJQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "468")]
		public LegacyCV2Result<None> SVNMTVJMWMB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "469")]
		public LegacyCV2Result<None> PTOKTCNDOCH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "474")]
		public LegacyCV2Result<None> AZDTHNPIIVV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "475")]
		public LegacyCV2Result<None> IXDNNNPXXEB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "476")]
		public LegacyCV2Result<None> TZSUSOXKUAO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "477")]
		public LegacyCV2Result<None> GDPDXLVGOPV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "478")]
		public LegacyCV2Result<None> QEPHVCGONYF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "479")]
		public LegacyCV2Result<None> MAEZIQXRCNQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(VUYLGSMGCXP executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(VUYLGSMGCXP executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "472")]
		public LegacyCV2Result<None> IVCMCJKOOPI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "473")]
		public LegacyCV2Result<None> QBOADFZDZCC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "480")]
		public LegacyCV2Result<None> JONJITZCOLS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "481")]
		public LegacyCV2Result<None> MQVSEFNAERI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "482")]
		public LegacyCV2Result<None> HKUAQDNSWKP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "483")]
		public LegacyCV2Result<None> MYHNXOEMKPD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "484")]
		public LegacyCV2Result<None> AOAZCPJLJVP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "485")]
		public LegacyCV2Result<None> CVYAFILSMPF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "486")]
		public LegacyCV2Result<None> LIRXLZEQTEB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "487")]
		public LegacyCV2Result<None> NCVFFOSBUDZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "488")]
		public LegacyCV2Result<None> RHUHVTARWKN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "489")]
		public LegacyCV2Result<None> NHUIRJWLTDD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "490")]
		public LegacyCV2Result<None> CQPQOIZJLWP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "491")]
		public LegacyCV2Result<None> NBSYRRRERCZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "492")]
		public LegacyCV2Result<None> OIONAVMPFJF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "493")]
		public LegacyCV2Result<None> KYGOCOFIHND(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "494")]
		public LegacyCV2Result<None> TTXICXVZGUN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "495")]
		public LegacyCV2Result<None> XVEYLWSKQEL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "496")]
		public LegacyCV2Result<None> UTDXLMBSNCX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "497")]
		public LegacyCV2Result<None> BFJIDNRXDLN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "498")]
		public LegacyCV2Result<None> FWNONJUPOHR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "499")]
		public LegacyCV2Result<None> ZXJPYNFPPYJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x28444F0", Offset = "0x28438F0", VA = "0x1828444F0", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "507")]
		public LegacyCV2Result<None> CAQSNGDRUXL(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "508")]
		public LegacyCV2Result<None> QBAATPEOWVB(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "509")]
		public LegacyCV2Result<None> BHNAHZIDIID(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "510")]
		public LegacyCV2Result<None> IPBIZARCGGW(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(VUYLGSMGCXP e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(VUYLGSMGCXP e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(VUYLGSMGCXP e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.YIJTUISFCSX> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "522")]
		public LegacyCV2Result<None> AESLDMRTOVU(VUYLGSMGCXP e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "525")]
		public LegacyCV2Result<None> AWPVFNZGNUS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "527")]
		public LegacyCV2Result<None> VVWKNOYQKNJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "528")]
		public LegacyCV2Result<None> MMXCEZOJSZH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "530")]
		public LegacyCV2Result<None> OBRVTOWXPXT(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "531")]
		public LegacyCV2Result<None> WELTLYQKJPG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2844460", Offset = "0x2843860", VA = "0x182844460", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "533")]
		public LegacyCV2Result<None> VFYKSWZAKVI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2844530", Offset = "0x2843930", VA = "0x182844530", Slot = "535")]
		public LegacyCV2Result<None> WUITSEFPLYU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "534")]
		public LegacyCV2Result<None> DSVUACASLCN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "536")]
		public LegacyCV2Result<None> CBBRKVTBFHB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "537")]
		public LegacyCV2Result<None> VTSKTDJBCOU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "538")]
		public LegacyCV2Result<None> PVSOPPIIZEC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "539")]
		public LegacyCV2Result<None> OMLKZGUVXTM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "540")]
		public LegacyCV2Result<None> RKPTMGCCFAI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "583")]
		public LegacyCV2Result<None> Raycast(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "584")]
		public LegacyCV2Result<None> OSYOVWWVGBH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "587")]
		public LegacyCV2Result<None> BTXVKARSEJW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "591")]
		public LegacyCV2Result<None> UBFBMSWCHPR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "592")]
		public LegacyCV2Result<None> BLVBFTFFISU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "641")]
		public LegacyCV2Result<None> FZOVDTBFLLX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "642")]
		public LegacyCV2Result<None> GPQYDXXWWEF(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "643")]
		public LegacyCV2Result<None> SNRTJEHDSAU(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "644")]
		public LegacyCV2Result<None> RFXUWELLMSD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "645")]
		public LegacyCV2Result<None> AEGGHOPATKX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "646")]
		public LegacyCV2Result<None> ESZJQOFVRUM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "649")]
		public LegacyCV2Result<None> ZOTEWSRIINF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "650")]
		public LegacyCV2Result<None> VNSNZXCANXB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "651")]
		public LegacyCV2Result<None> IMZSPALYNGI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "661")]
		public LegacyCV2Result<None> QARINSRGFXF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "660")]
		public LegacyCV2Result<None> VJUIRGCPZFI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "662")]
		public LegacyCV2Result<None> LFBIQALTKTH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "663")]
		public LegacyCV2Result<None> NJSNXHFAZDK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "670")]
		public LegacyCV2Result<None> FOVABVRVVYP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "671")]
		public LegacyCV2Result<None> DVDOHSOWQXY(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "674")]
		public LegacyCV2Result<None> RGWZZRPRWQM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "675")]
		public LegacyCV2Result<None> QHBIYXHPWJB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(VUYLGSMGCXP e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "696")]
		public LegacyCV2Result<None> EWTUVAEFIGJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "697")]
		public LegacyCV2Result<None> SYXNSWKKWLZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "698")]
		public LegacyCV2Result<None> ZZGNIDPPDUJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "699")]
		public LegacyCV2Result<None> KYOHYJLVUKS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "700")]
		public LegacyCV2Result<None> IHGRTOBUYYI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "676")]
		public LegacyCV2Result<None> SHYOLRHTYHJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "677")]
		public LegacyCV2Result<None> NOEJJZRRFIV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "678")]
		public LegacyCV2Result<None> FHOHNPBROPO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "679")]
		public LegacyCV2Result<None> YSFCETDQITL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "680")]
		public LegacyCV2Result<None> ULXCBGAQKLA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "681")]
		public LegacyCV2Result<None> GIFWEFDQHNB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "682")]
		public LegacyCV2Result<None> UFMYIBAYCSF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "683")]
		public LegacyCV2Result<None> VTETXNXTFRG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "684")]
		public LegacyCV2Result<None> XNQHTFPGTUG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "685")]
		public LegacyCV2Result<None> RXZAFWGJIAN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "686")]
		public LegacyCV2Result<None> JDCSTRWZEGN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "687")]
		public LegacyCV2Result<None> YPZVUEFBDTO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "688")]
		public LegacyCV2Result<None> OQZRWLCQNDV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "689")]
		public LegacyCV2Result<None> CYFFWGZBVVJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "690")]
		public LegacyCV2Result<None> GFEDOWQPADS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "691")]
		public LegacyCV2Result<None> GFRYBIMQAJE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "692")]
		public LegacyCV2Result<None> RETWQQSFWZK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "693")]
		public LegacyCV2Result<None> UMZSRUZBWDF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "765")]
		public LegacyCV2Result<None> DZYYLJOKAXH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "711")]
		public LegacyCV2Result<None> MEUFDOEPLEW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "712")]
		public LegacyCV2Result<None> IOOPOFTWGSW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "713")]
		public LegacyCV2Result<None> BZROIZGRMUQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "714")]
		public LegacyCV2Result<None> LZYZHBFFZDA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "717")]
		public LegacyCV2Result<None> NGYKTVWATYE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "721")]
		public LegacyCV2Result<None> EYQEIRETYIV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "722")]
		public LegacyCV2Result<None> SVGLRJSCLKL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "723")]
		public LegacyCV2Result<None> YHAGYBRPDHQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "724")]
		public LegacyCV2Result<None> RLKFRAKFCBQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "725")]
		public LegacyCV2Result<None> TCJBHMNZOSS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "726")]
		public LegacyCV2Result<None> VUHIFLUHXDT(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "727")]
		public LegacyCV2Result<None> WAWYKTJXGQQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "728")]
		public LegacyCV2Result<None> MIXTLZMYRXJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "729")]
		public LegacyCV2Result<None> AMKYFGXVIGZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "730")]
		public LegacyCV2Result<None> LNLHUHQBSDZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "731")]
		public LegacyCV2Result<None> IPSJXLRZNET(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "732")]
		public LegacyCV2Result<None> IMOYISIVGRT(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "733")]
		public LegacyCV2Result<None> DIWXYHGKCEB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "734")]
		public LegacyCV2Result<None> FXHCXAMQVXW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "735")]
		public LegacyCV2Result<None> XRHAILZCMLH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "736")]
		public LegacyCV2Result<None> WXEXCKAEFYP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "737")]
		public LegacyCV2Result<None> PJWGKTDRNPQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "738")]
		public LegacyCV2Result<None> ZYJXNUJTERL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "740")]
		public LegacyCV2Result<None> EDVVWUMVEEL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "739")]
		public LegacyCV2Result<None> NIWAQJCRTNN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "741")]
		public LegacyCV2Result<None> ZLVBDSAUDDI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "742")]
		public LegacyCV2Result<None> SZBMULGYANH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "743")]
		public LegacyCV2Result<None> KYIJERPUNQW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "744")]
		public LegacyCV2Result<None> SGEVYSBZBWU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "745")]
		public LegacyCV2Result<None> FTJPENXRADV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "746")]
		public LegacyCV2Result<None> LMVMRLHKDQW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "747")]
		public LegacyCV2Result<None> VALXBCJOXSK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "748")]
		public LegacyCV2Result<None> ZFIIRZNCJXH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "749")]
		public LegacyCV2Result<None> YUWPTDSWNQL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "750")]
		public LegacyCV2Result<None> ZILEYTKTZBF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "751")]
		public LegacyCV2Result<None> UQLAJHJHRAZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "752")]
		public LegacyCV2Result<None> AJHBDEONUOZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "753")]
		public LegacyCV2Result<None> FEEGXPBOKVX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "754")]
		public LegacyCV2Result<None> YCZIAJERQSZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "755")]
		public LegacyCV2Result<None> ACZPOMFRHTK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "756")]
		public LegacyCV2Result<None> OLBGELKVGKK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "757")]
		public LegacyCV2Result<None> ZOZSWFOMGQK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "758")]
		public LegacyCV2Result<None> GOVKHXOWGFY(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "759")]
		public LegacyCV2Result<None> GMPDWWUIWLX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "760")]
		public LegacyCV2Result<None> HXBWDYUJPSD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "761")]
		public LegacyCV2Result<None> OMCUQKAAOLX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "762")]
		public LegacyCV2Result<None> TGNBMGJTXMK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "763")]
		public LegacyCV2Result<None> JGKTWFLBMGY(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "764")]
		public LegacyCV2Result<None> ZZXZQHIOLQB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "771")]
		public LegacyCV2Result<None> SVWYNIMPBRZ(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "772")]
		public LegacyCV2Result<None> TOBDHOLOFKR(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "773")]
		public LegacyCV2Result<None> FNYQIPYKYXE(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(VUYLGSMGCXP ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "775")]
		public LegacyCV2Result<None> VRJCNRONQXG(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "776")]
		public LegacyCV2Result<None> NOFOBVFUBWY(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "777")]
		public LegacyCV2Result<None> YQNUYMTQCTB(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "778")]
		public LegacyCV2Result<None> WMWZQBFSPXT(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "779")]
		public LegacyCV2Result<None> KPZFFXPCCJT(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "707")]
		public LegacyCV2Result<None> FVEIUBMTUOL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "801")]
		public LegacyCV2Result<None> RFLEOUJIKXX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "802")]
		public LegacyCV2Result<None> JSRJCPZIJQJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "803")]
		public LegacyCV2Result<None> BREZKCDEWKP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "804")]
		public LegacyCV2Result<None> IAFWSLDCWOH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "805")]
		public LegacyCV2Result<None> OOJMQALIINP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "806")]
		public LegacyCV2Result<None> MBDTJVJHQIJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "807")]
		public LegacyCV2Result<None> KMBNKDHZFZJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "808")]
		public LegacyCV2Result<None> LXXQPBNEEST(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "809")]
		public LegacyCV2Result<None> BJLLNXOLEXP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "810")]
		public LegacyCV2Result<None> VMSGVMYOAPF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "811")]
		public LegacyCV2Result<None> RBPWVQFVNLZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "812")]
		public LegacyCV2Result<None> OHJUMZTOCXS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "817")]
		public LegacyCV2Result<None> WETPKHZWVUT(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "821")]
		public LegacyCV2Result<None> NLLXPXSETUM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "822")]
		public LegacyCV2Result<None> QTJKAYBNKIM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "823")]
		public LegacyCV2Result<None> ECCDDHVDGOG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "824")]
		public LegacyCV2Result<None> ITKEKKCETVY(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "826")]
		public LegacyCV2Result<None> RSNJFBSNNMO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "827")]
		public LegacyCV2Result<None> NFXIXSNKTPX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "828")]
		public LegacyCV2Result<None> AJCMNDILOLB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "831")]
		public LegacyCV2Result<None> QYJUFILZDVL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "832")]
		public LegacyCV2Result<None> SXLMTTDUVPM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "833")]
		public LegacyCV2Result<None> DHTNUXDLURX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(VUYLGSMGCXP e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(VUYLGSMGCXP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "836")]
		public LegacyCV2Result<None> TYAALZSUSHC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MHKBHWTQJEO(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HTOCGJJUMAQ(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CSMYSSUENUD(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VJPOZQEWEFK(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BOPHPYJVKHX(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(VUYLGSMGCXP e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(VUYLGSMGCXP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(VUYLGSMGCXP e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(VUYLGSMGCXP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(VUYLGSMGCXP e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(VUYLGSMGCXP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(VUYLGSMGCXP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "856")]
		public LegacyCV2Result<None> FYKXAYCBPUM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "859")]
		public LegacyCV2Result<None> MDZFIVQHTQA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "860")]
		public LegacyCV2Result<None> DTWQCKAUEVA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "861")]
		public LegacyCV2Result<None> PNAFWPAFTRI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "862")]
		public LegacyCV2Result<None> AZOCWHAGALJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "864")]
		public LegacyCV2Result<None> NRSXGSNFBRG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "865")]
		public LegacyCV2Result<None> QXQVDOYJWWG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(VUYLGSMGCXP e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "869")]
		public LegacyCV2Result<None> GTIRTXBTLEC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "879")]
		public LegacyCV2Result<None> LWLYDEUVXTW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "880")]
		public LegacyCV2Result<None> SZZGHSXEGBQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "881")]
		public LegacyCV2Result<None> XCQDHLBGQNR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "882")]
		public LegacyCV2Result<None> VATEYWTOTSO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(VUYLGSMGCXP e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(VUYLGSMGCXP e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(VUYLGSMGCXP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(VUYLGSMGCXP e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(VUYLGSMGCXP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "889")]
		public LegacyCV2Result<None> GSNYWPTPNBY(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "890")]
		public LegacyCV2Result<None> WWXSBSLQWYB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "891")]
		public LegacyCV2Result<None> SCFVGTQIZNC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "892")]
		public LegacyCV2Result<None> GVVGMLHMNTS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "893")]
		public LegacyCV2Result<None> ZYHWZORWBWC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "897")]
		public LegacyCV2Result<None> BEYVRGOJHML(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "898")]
		public LegacyCV2Result<None> CCBFWAIQHNV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "899")]
		public LegacyCV2Result<None> TBPSIUJWHHA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "901")]
		public LegacyCV2Result<None> AOXDTXITJLE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "900")]
		public LegacyCV2Result<None> DVXVAUNTUFA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "902")]
		public LegacyCV2Result<None> EPYVRCGKSMD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "904")]
		public LegacyCV2Result<None> GDCPHJARSMX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "903")]
		public LegacyCV2Result<None> SUHPNUOUUZP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "905")]
		public LegacyCV2Result<None> KEMKKIRPMHI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "906")]
		public LegacyCV2Result<None> FDTVMXZVKKO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "907")]
		public LegacyCV2Result<None> VDCMTAQWBZV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "908")]
		public LegacyCV2Result<None> NOLMESFPJKF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "909")]
		public LegacyCV2Result<None> FDTWEBKJKOZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "910")]
		public LegacyCV2Result<None> QAJZQSWTTLP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "911")]
		public LegacyCV2Result<None> FTCHGDLIWDX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "918")]
		public LegacyCV2Result<None> BSZZVWHQCDJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "919")]
		public LegacyCV2Result<None> ZKBKYFQQXBZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(VUYLGSMGCXP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(VUYLGSMGCXP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(VUYLGSMGCXP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(VUYLGSMGCXP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(VUYLGSMGCXP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(VUYLGSMGCXP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(VUYLGSMGCXP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(VUYLGSMGCXP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(VUYLGSMGCXP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "941")]
		public LegacyCV2Result<None> GZRAVTTNNZL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "942")]
		public LegacyCV2Result<None> VMFGBOENMBH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "943")]
		public LegacyCV2Result<None> EEXEGUVASHU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "944")]
		public LegacyCV2Result<None> CFOAJQTLAFS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "945")]
		public LegacyCV2Result<None> YKPDSDBSDPF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "946")]
		public LegacyCV2Result<None> XYUEJAZGQYZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "947")]
		public LegacyCV2Result<None> PELEQJHCKUU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "948")]
		public LegacyCV2Result<None> BLIJTLCKXMA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "949")]
		public LegacyCV2Result<None> COUSDPZYNNS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "950")]
		public LegacyCV2Result<None> JMMBRRGQMGP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "968")]
		public LegacyCV2Result<None> JKDCZRMFRGP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "967")]
		public LegacyCV2Result<None> SGAMSCTEYKA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "969")]
		public LegacyCV2Result<None> BWTCUCSVKIS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "970")]
		public LegacyCV2Result<None> ESVRRDWWOIX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "971")]
		public LegacyCV2Result<None> KJHFTINPBXS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "972")]
		public LegacyCV2Result<None> NRMOFGTAMNU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "973")]
		public LegacyCV2Result<None> SMWZBQZMSDJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "975")]
		public LegacyCV2Result<None> CSSJNVYXVTS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "982")]
		public LegacyCV2Result<None> ICTOSEWKJJN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "983")]
		public LegacyCV2Result<None> QHLCXROSDCF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "991")]
		public LegacyCV2Result<None> PGNHMJMOSUM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "993")]
		public LegacyCV2Result<None> IFCPXOFSMMU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "994")]
		public LegacyCV2Result<None> PPUAWFVILOU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "995")]
		public LegacyCV2Result<None> CTDBMGNMRWS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "996")]
		public LegacyCV2Result<None> HJKXIQHBJNU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "997")]
		public LegacyCV2Result<None> ZMGTECPOGOI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "998")]
		public LegacyCV2Result<None> HRKNBWGLQZO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "999")]
		public LegacyCV2Result<None> PMIMTWNXOSO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1000")]
		public LegacyCV2Result<None> HTWBKYFHZHE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1001")]
		public LegacyCV2Result<None> FATVXLYGBPQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1002")]
		public LegacyCV2Result<None> LTPTPWVUCEW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1009")]
		public LegacyCV2Result<None> NNIIABPIMGM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1017")]
		public LegacyCV2Result<None> ZQQAFOUKHVB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1018")]
		public LegacyCV2Result<None> DEGKUAXLOZU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1019")]
		public LegacyCV2Result<None> JVOACZZQMVZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1020")]
		public LegacyCV2Result<None> FFKKDAHDAIK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1021")]
		public LegacyCV2Result<None> PLOUHHHXOXB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1022")]
		public LegacyCV2Result<None> JQGYNLTPKRG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1023")]
		public LegacyCV2Result<None> EQSCQXLHCIF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1024")]
		public LegacyCV2Result<None> PMGVFTDNKZX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1025")]
		public LegacyCV2Result<None> YADTCIPJEJG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1026")]
		public LegacyCV2Result<None> OEGWPTEINCP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1027")]
		public LegacyCV2Result<None> ZOJHUVUHSXN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1028")]
		public LegacyCV2Result<None> RSANVTDEWJK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1029")]
		public LegacyCV2Result<None> ZDAWNRJBVBS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1030")]
		public LegacyCV2Result<None> THRULXYLSYX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1031")]
		public LegacyCV2Result<None> YAFAYJSOVDC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1032")]
		public LegacyCV2Result<None> DHPURCFCSFR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1033")]
		public LegacyCV2Result<None> KAFSPCDMVMX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1047")]
		public LegacyCV2Result<None> ZBACZZXHRPH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1048")]
		public LegacyCV2Result<None> DNGOTMGXHHL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1049")]
		public LegacyCV2Result<None> TJTEPKJZXKB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1050")]
		public LegacyCV2Result<None> RIHQVULPESZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1051")]
		public LegacyCV2Result<None> LVCLCGYVIXE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1052")]
		public LegacyCV2Result<None> TGMCGUEYRXE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1053")]
		public LegacyCV2Result<None> VNXEWMFXALD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1054")]
		public LegacyCV2Result<None> VSRSAFPEJAI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1055")]
		public LegacyCV2Result<None> EFKPUCUVWVF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1056")]
		public LegacyCV2Result<None> PZNNJRJKFSU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1057")]
		public LegacyCV2Result<None> EKFBSFCDTZG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1058")]
		public LegacyCV2Result<None> CFLMBRYBVRX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1059")]
		public LegacyCV2Result<None> JVUSTNONGZG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1060")]
		public LegacyCV2Result<None> BUOIETRXTHI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1061")]
		public LegacyCV2Result<None> CXDBFNPFNQK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1062")]
		public LegacyCV2Result<None> XKADYKDBCPE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1063")]
		public LegacyCV2Result<None> CIKYEOXNKPA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1064")]
		public LegacyCV2Result<None> SBAMULSNDNN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1065")]
		public LegacyCV2Result<None> CRLZMFYWNNZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1066")]
		public LegacyCV2Result<None> CDGCHBVLPAY(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1067")]
		public LegacyCV2Result<None> LBERCWGXKFW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1068")]
		public LegacyCV2Result<None> XRWHTSUCBGG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1069")]
		public LegacyCV2Result<None> NSOTKITMJIG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1070")]
		public LegacyCV2Result<None> FUBFAAFMKZZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1071")]
		public LegacyCV2Result<None> MGWLLOQMNVB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x28444A0", Offset = "0x28438A0", VA = "0x1828444A0", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(VUYLGSMGCXP e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(VUYLGSMGCXP e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1092")]
		public LegacyCV2Result<None> PXVIOJNMIRM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1093")]
		public LegacyCV2Result<None> DOYDINIVYYR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1094")]
		public LegacyCV2Result<None> UWMFDVLRWHH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1095")]
		public LegacyCV2Result<None> ATHUYIMMUMZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1096")]
		public LegacyCV2Result<None> QPBDTOVCSEF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1097")]
		public LegacyCV2Result<None> GDOQPQCIIYP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1098")]
		public LegacyCV2Result<None> QRUZZBPDVPB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1099")]
		public LegacyCV2Result<None> CWATYZSANSP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1100")]
		public LegacyCV2Result<None> SBOBVZMIHOT(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1101")]
		public LegacyCV2Result<None> PEZYOYKHTMD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1102")]
		public LegacyCV2Result<None> BFGFXRMKCLN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1103")]
		public LegacyCV2Result<None> SKNIRLXZTDW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1104")]
		public LegacyCV2Result<None> GQIOBRISIIU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1105")]
		public LegacyCV2Result<None> OUBVDIXTCKM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1106")]
		public LegacyCV2Result<None> GOQRWPGEUSY(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1107")]
		public LegacyCV2Result<None> HYEBBXDJPNR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1108")]
		public LegacyCV2Result<None> YBLXQASHJEP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1109")]
		public LegacyCV2Result<None> ZIMVTCWPOQO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1110")]
		public LegacyCV2Result<None> KPASGYPVVRE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1111")]
		public LegacyCV2Result<None> SAPFMRDCWEO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1112")]
		public LegacyCV2Result<None> IFPBZGKTEOW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1113")]
		public LegacyCV2Result<None> EYKZNTJNUVR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1114")]
		public LegacyCV2Result<None> PYKRNVYIIBF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1115")]
		public LegacyCV2Result<None> YFMYYQSTJOG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1116")]
		public LegacyCV2Result<None> VMBLXHJCMUS(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1117")]
		public LegacyCV2Result<None> ACXJFIUDJZI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1118")]
		public LegacyCV2Result<None> VEZURJBWWCW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1119")]
		public LegacyCV2Result<None> EJWALGVVLFB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1120")]
		public LegacyCV2Result<None> TBZOWWDHUEQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1121")]
		public LegacyCV2Result<None> ZEJNZSEZNJK(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1122")]
		public LegacyCV2Result<None> HZUGAIHYMXW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1123")]
		public LegacyCV2Result<None> UFOOZULVILN(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1124")]
		public LegacyCV2Result<None> XIRVOSCIEYP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1125")]
		public LegacyCV2Result<None> LYKUVBYOHWP(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1126")]
		public LegacyCV2Result<None> KGAGEXECCLN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1127")]
		public LegacyCV2Result<None> GXNZSLELHBR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1128")]
		public LegacyCV2Result<None> WLODGUBYAVJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1129")]
		public LegacyCV2Result<None> WQSSSTOXPFX(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1130")]
		public LegacyCV2Result<None> PFFETAYNGPY(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1131")]
		public LegacyCV2Result<None> PUQLSGIBKSP(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1132")]
		public LegacyCV2Result<None> IVOULEYDIFE(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1133")]
		public LegacyCV2Result<None> SKYSDWXLOTZ(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1134")]
		public LegacyCV2Result<None> NDLTEQLGAIT(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1135")]
		public LegacyCV2Result<None> NNOCPQCYPZG(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1136")]
		public LegacyCV2Result<None> QFRBSXPPYOI(ZSXZLQTRHHU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1140")]
		public LegacyCV2Result<None> YBOBCDILBKE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1166")]
		public LegacyCV2Result<None> ASDIOSAYMPA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1168")]
		public LegacyCV2Result<None> LYMWEONJOBW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1169")]
		public LegacyCV2Result<None> YMVHMCLAAPZ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1170")]
		public LegacyCV2Result<None> EKBCLOQHBRA(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1171")]
		public LegacyCV2Result<None> XYVLBBIDLQP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1182")]
		public LegacyCV2Result<None> LTDNCIYDLRF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1183")]
		public LegacyCV2Result<None> PLUCACTCDWV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1184")]
		public LegacyCV2Result<None> JOADYULVXTX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1185")]
		public LegacyCV2Result<None> GOHSBZHKLFF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1186")]
		public LegacyCV2Result<None> BWIVTBTRIMU(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1187")]
		public LegacyCV2Result<None> LUSXNXSVPKM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1188")]
		public LegacyCV2Result<None> QAXEZFHFWPE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1189")]
		public LegacyCV2Result<None> LXXHYTIXLEW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1190")]
		public LegacyCV2Result<None> HCSZKRAIKDX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1191")]
		public LegacyCV2Result<None> XUJGTVNIJFT(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1192")]
		public LegacyCV2Result<None> VQQRRIVKHBE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1193")]
		public LegacyCV2Result<None> BFJMKWFIEKD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "184")]
		public LegacyCV2Result<None> MSFEUFWVAOX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x28444E0", Offset = "0x28438E0", VA = "0x1828444E0", Slot = "191")]
		public bool RIFUUUFWIAB(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1194")]
		public LegacyCV2Result<None> URWTABDLXLV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1195")]
		public LegacyCV2Result<None> YSIGYJMWPXQ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1196")]
		public LegacyCV2Result<None> NZJPGGGIOZT(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(VUYLGSMGCXP e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1205")]
		public LegacyCV2Result<None> WUZIMPURHDM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1206")]
		public LegacyCV2Result<None> ADEZEWBRVIW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(VUYLGSMGCXP e, InOut io, MFPJFYGRUCC objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "250")]
		public LegacyCV2Result<None> JWFGQNXTDIL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "251")]
		public LegacyCV2Result<None> TRPSYBNUFDD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "252")]
		public LegacyCV2Result<None> BHERMAYJDSB(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "254")]
		public LegacyCV2Result<None> RSCHIWHJTSO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "255")]
		public LegacyCV2Result<None> KJQHPOQPFGO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "256")]
		public LegacyCV2Result<None> GCLIUQJCMES(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "257")]
		public LegacyCV2Result<None> XSTFPUXBHGN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "258")]
		public LegacyCV2Result<None> WBGRGIJWTPX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "259")]
		public LegacyCV2Result<None> QVZTPGCCKQW(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "260")]
		public LegacyCV2Result<None> QBICNCMKDMO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "261")]
		public LegacyCV2Result<None> UWNRQODJPMI(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "262")]
		public LegacyCV2Result<None> ZUMVNRHYULC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "263")]
		public LegacyCV2Result<None> KDZYOTLDMKD(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "264")]
		public LegacyCV2Result<None> LRGZKCYDKGP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "265")]
		public LegacyCV2Result<None> PEMLKXXFRNX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "266")]
		public LegacyCV2Result<None> PRDUZNJGJYR(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "267")]
		public LegacyCV2Result<None> HRHVVJVPEVP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "268")]
		public LegacyCV2Result<None> RXFXPEMRNKH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "269")]
		public LegacyCV2Result<None> ZBMCULVRNYH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350")]
		private static LegacyCV2Result<None> Default(VUYLGSMGCXP e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x28443D0", Offset = "0x28437D0", VA = "0x1828443D0", Slot = "1209")]
		public LegacyCV2Result<None> DWZXALHDWWM(VUYLGSMGCXP a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1212")]
		public LegacyCV2Result<None> RKCOLIKLSNF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1213")]
		public LegacyCV2Result<None> ZGZHHRKOYMN(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1214")]
		public LegacyCV2Result<None> TIHIQWAXGKJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1215")]
		public LegacyCV2Result<None> BNEQLUALMSG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(VUYLGSMGCXP e, InOut io, GAUFGCSPFYW quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1036")]
		public LegacyCV2Result<None> ZRSQSNFVTEH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1037")]
		public LegacyCV2Result<None> CVLGCLCMQMH(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1038")]
		public LegacyCV2Result<None> WKGTFKKGUEV(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1039")]
		public LegacyCV2Result<None> MDRPEQYLYYJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1040")]
		public LegacyCV2Result<None> STXYAXPVMHJ(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1041")]
		public LegacyCV2Result<None> LNIKRYAQACX(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1042")]
		public LegacyCV2Result<None> QLNBSTAQDTF(VUYLGSMGCXP a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1043")]
		public LegacyCV2Result<None> TYUXLTYULNT(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1044")]
		public LegacyCV2Result<None> XFPPTTBIZBP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1045")]
		public LegacyCV2Result<None> WTYYJXLEAPC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1046")]
		public LegacyCV2Result<None> RTQVDZDTMEE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HKIDLAZZXFG(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1234")]
		public LegacyCV2Result<None> LJOOZFEXOET(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1236")]
		public LegacyCV2Result<None> DBRJJPWFIMO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1229")]
		public LegacyCV2Result<None> BXMJMRNZHCM(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1241")]
		public LegacyCV2Result<None> YGGEKEAIDDK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1242")]
		public LegacyCV2Result<None> MADRIOJFPAP(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1243")]
		public LegacyCV2Result<None> VWEUAMOHUEL(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1244")]
		public LegacyCV2Result<None> FEUXNZXJKMF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1245")]
		public LegacyCV2Result<None> YLYLZJSBGKC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KYPGWUXRNME(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OWTYNDOYHKM(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NSODWYJJZAS(VUYLGSMGCXP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1259")]
		public LegacyCV2Result<None> CZHPASYGFPE(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1260")]
		public LegacyCV2Result<None> CDVDRAZOTJG(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1261")]
		public LegacyCV2Result<None> EYMCMLONBBK(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1262")]
		public LegacyCV2Result<None> IGURBTDISPO(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2844570", Offset = "0x2843970", VA = "0x182844570")]
		public GTTUDZWRUWR([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(VUYLGSMGCXP e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1280")]
		public LegacyCV2Result<None> LAIXXMZOFFF(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1281")]
		public LegacyCV2Result<None> UMHEUFFPNMC(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "599")]
		public LegacyCV2Result<None> DLCHQIEJCSY(VUYLGSMGCXP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1293")]
		public LegacyCV2Result<None> DDPTBUKXPUP(ZSXZLQTRHHU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1294")]
		public LegacyCV2Result<None> RFGFZCHPGVQ(ZSXZLQTRHHU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1295")]
		public LegacyCV2Result<None> SNHQNPJFECL(ZSXZLQTRHHU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1296")]
		public LegacyCV2Result<None> PMHUQYQNFCR(ZSXZLQTRHHU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1297")]
		public LegacyCV2Result<None> UREEILJSLNS(ZSXZLQTRHHU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350")]
		public LegacyCV2Result<None> ConstantStorefrontItem(VUYLGSMGCXP e, InOut io, [In] DTJZZWPDOSD storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(VUYLGSMGCXP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> LVPIXMSWNHC(VUYLGSMGCXP a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, LJSCZFYMNAA.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> RNGLYAJJXRY(VUYLGSMGCXP a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, LJSCZFYMNAA.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1207")]
		private LegacyCV2Result<None> AUIIEZJNZDT(VUYLGSMGCXP a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1216")]
		private LegacyCV2Result<None> JXPIGHIARJY(VUYLGSMGCXP a, InOut b, [In] DTJZZWPDOSD storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350", Slot = "1257")]
		private LegacyCV2Result<None> LQDESKYJMSO(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class HXFZZOFLRYQ : MJEQGDROKLD
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(ZXTZCPACNVY node);

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly HXFZZOFLRYQ RMUSGMNMVYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate GZSUGVXEBUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate SUMMYVCFGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool JEUSFFSPQKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private bool QLDGKGJYFQX;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x284E610", Offset = "0x284DA10", VA = "0x18284E610", Slot = "4")]
		public Task<bool> KTABQFGYSRQ(ZXTZCPACNVY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x284E990", Offset = "0x284DD90", VA = "0x18284E990", Slot = "5")]
		public Task<bool> TFGBTHGQKKJ(ZXTZCPACNVY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x284EA40", Offset = "0x284DE40", VA = "0x18284EA40")]
		public HXFZZOFLRYQ([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x284E970", Offset = "0x284DD70", VA = "0x18284E970", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? GIPMPIYSGCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xAAE730", Offset = "0xAADB30", VA = "0x180AAE730", Slot = "7")]
		public bool QVONRCVJIXZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x1305840", Offset = "0x1304C40", VA = "0x181305840", Slot = "8")]
		public bool CEDMYSOANSP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class GILLIMSAIWY : KCHIPMOWORV
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid FZXFWGJTVNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xC28720", Offset = "0xC27B20", VA = "0x180C28720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
		public void Bind(ZXNGQWPTXIP pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xE3DDD0", Offset = "0xE3D1D0", VA = "0x180E3DDD0")]
		public GILLIMSAIWY(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x284E860", Offset = "0x284DC60", VA = "0x18284E860")]
		public static GILLIMSAIWY New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class CAOSZSJLZHY : YHXGCLRLMUY
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<XNNOENVVCYV> nodeDefId, Id128<LVEMYDMRMXB>? legacyInnerGraphId, IReadOnlyDictionary<Id128<LVEMYDMRMXB>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private IsNodeRestrictedDelegate? UEJOZAEZSAN;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool UDIPVEEQCCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAF68E0", Offset = "0xAF5CE0", VA = "0x180AF68E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool SJBZNONGCKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x284CE00", Offset = "0x284C200", VA = "0x18284CE00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AILJGFVCIRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xF992B0", Offset = "0xF986B0", VA = "0x180F992B0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "6")]
		public bool CSFVBIFXQDJ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "7")]
		public CanSaveObjectIntoInventionResultType UYLXAQQGAHW(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x284CE10", Offset = "0x284C210", VA = "0x18284CE10", Slot = "8")]
		public bool WSNIJTSLWTN(Id128<XNNOENVVCYV> nodeDefId, Id128<LVEMYDMRMXB>? legacyInnerGraphId, IReadOnlyDictionary<Id128<LVEMYDMRMXB>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "9")]
		public bool AZGWEIALTQM(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "10")]
		public bool KYPZBNYJZFQ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x284CE60", Offset = "0x284C260", VA = "0x18284CE60")]
		public CAOSZSJLZHY(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class XUJVGAQQXWE : AIHNJNRGCJX
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly XUJVGAQQXWE RMUSGMNMVYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventSenderToMakerPenDelegate HJXPFPWNXTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate ICYPFGFOCQW;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool SIDAHPWUDYA
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0xFF2980", Offset = "0xFF1D80", VA = "0x180FF2980", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FBZYXAKFEYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x2854E70", Offset = "0x2854270", VA = "0x182854E70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x2854F10", Offset = "0x2854310", VA = "0x182854F10")]
		public XUJVGAQQXWE([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class VOBCQOCWMCW : XRPUYCJXMWS<KZGUMKWBJGS>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class XWGRQFEHTMV : KZGUMKWBJGS, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly XWGRQFEHTMV ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool MTEWKTUNLIH
			{
				[Cpp2IlInjected.Token(Token = "0x600075E")]
				[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2855200", Offset = "0x2854600", VA = "0x182855200", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			public void SUNQWODQXCX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public XWGRQFEHTMV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly VOBCQOCWMCW ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private VOBCQOCWMCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2854D50", Offset = "0x2854150", VA = "0x182854D50", Slot = "4")]
		public KZGUMKWBJGS TURVVFPIEGT()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class GRMJQVWYAHK<a, b> : IDisposable, FZUHJKMKOUD where a : notnull where b : notnull, WUKDAXIYOHY.UCJKCVUMNSY<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly b GOSNOUTRNRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly a KGOLZETXOPV;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<GPNZGVDAJTA> XKVMHZWGJUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GPNZGVDAJTA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4B50", Offset = "0x4EA3F50", VA = "0x184EA4B50")]
		public GRMJQVWYAHK(b a, a b, Id32<GPNZGVDAJTA> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2B20", Offset = "0x4EA1F20", VA = "0x184EA2B20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4710", Offset = "0x4EA3B10", VA = "0x184EA4710")]
		public Id32<JDQQUBYOTBT> XCDLBYNARJO([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<JDQQUBYOTBT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3FD0", Offset = "0x4EA33D0", VA = "0x184EA3FD0", Slot = "6")]
		public void RXPLDSCOUID(Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3D90", Offset = "0x4EA3190", VA = "0x184EA3D90", Slot = "7")]
		public void PSFINALWZYB(Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4240", Offset = "0x4EA3640", VA = "0x184EA4240", Slot = "8")]
		public void UFZJAQPVYAO(Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2B50", Offset = "0x4EA1F50", VA = "0x184EA2B50", Slot = "10")]
		public void EEGAXYDOVXL(Id32<JDQQUBYOTBT> objectId, Id32<GPNZGVDAJTA> clientId, KMDWRSUVLAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2FF0", Offset = "0x4EA23F0", VA = "0x184EA2FF0", Slot = "9")]
		public void EJBKDSXBOHN(Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3540", Offset = "0x4EA2940", VA = "0x184EA3540", Slot = "11")]
		public void IKNTUCQKSHB(Id32<JDQQUBYOTBT> objectId, JJTCGSUBOXA? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3CC0", Offset = "0x4EA30C0", VA = "0x184EA3CC0", Slot = "12")]
		public Id32<GPNZGVDAJTA> NMVWPDZXJRK(Id32<JDQQUBYOTBT> objectId)
		{
			return default(Id32<GPNZGVDAJTA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3030", Offset = "0x4EA2430", VA = "0x184EA3030", Slot = "13")]
		public Id32<DSZQEJPSUJJ> GAIXMUYDOQU(Id32<JDQQUBYOTBT> objectId, string a, object b, bool c, UAIHKBQAJZH d, BPZOLTUSHZR e)
		{
			return default(Id32<DSZQEJPSUJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x4EA32E0", Offset = "0x4EA26E0", VA = "0x184EA32E0", Slot = "14")]
		public void GDHDAFMZOOM(Id32<DSZQEJPSUJJ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x4EA37E0", Offset = "0x4EA2BE0", VA = "0x184EA37E0", Slot = "15")]
		public void JXBUNLROPGW(Id32<DSZQEJPSUJJ> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class WUKDAXIYOHY
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface UCJKCVUMNSY<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void OOAXKTTEEGI(a a, Id32<GPNZGVDAJTA> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<GPNZGVDAJTA>? YCAAJNRXAKX(a a);

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<JDQQUBYOTBT> XCDLBYNARJO(a a, Id32<GPNZGVDAJTA> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void RXPLDSCOUID(a a, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA b);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void PSFINALWZYB(a a, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void EEGAXYDOVXL(a a, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void EJBKDSXBOHN(a a, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void IKNTUCQKSHB(a a, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, JJTCGSUBOXA? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<GPNZGVDAJTA>? NMVWPDZXJRK(a a, Id32<JDQQUBYOTBT> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<DSZQEJPSUJJ> GAIXMUYDOQU(a a, Id32<GPNZGVDAJTA> clientId, string b, object c, UAIHKBQAJZH d, BPZOLTUSHZR e);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void GDHDAFMZOOM(a a, Id32<GPNZGVDAJTA> clientId, Id32<DSZQEJPSUJJ> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void JXBUNLROPGW(a a, Id32<GPNZGVDAJTA> clientId, Id32<DSZQEJPSUJJ> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class UXNMQUWNISU
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public readonly HashSet<Id32<JDQQUBYOTBT>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public SOAId32Field<DSZQEJPSUJJ, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly Dictionary<Id32<DSZQEJPSUJJ>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<DSZQEJPSUJJ>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public SOAField<JDQQUBYOTBT, JJTCGSUBOXA?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x284FED0", Offset = "0x284F2D0", VA = "0x18284FED0")]
			private MockCV2DynamicNetSys(HashSet<Id32<JDQQUBYOTBT>> authorityOf, [In] SOAId32Field<DSZQEJPSUJJ, MockCV2SyncField> syncFields, Dictionary<Id32<DSZQEJPSUJJ>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<DSZQEJPSUJJ>> mockSyncFieldToSyncField, [In] SOAField<JDQQUBYOTBT, JJTCGSUBOXA?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x284FD10", Offset = "0x284F110", VA = "0x18284FD10")]
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
			public Id32<GPNZGVDAJTA>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x284FF70", Offset = "0x284F370", VA = "0x18284FF70")]
			public MockCV2ObjectShared(Id32<GPNZGVDAJTA> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public BPZOLTUSHZR SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public UAIHKBQAJZH SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
			internal MockCV2SyncField(BPZOLTUSHZR syncField, UAIHKBQAJZH syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2850090", Offset = "0x284F490", VA = "0x182850090")]
			public static MockCV2SyncField New(BPZOLTUSHZR syncField, UAIHKBQAJZH syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x2850040", Offset = "0x284F440", VA = "0x182850040")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x284FFF0", Offset = "0x284F3F0", VA = "0x18284FFF0")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private SOAId32Field<JDQQUBYOTBT, MockCV2ObjectShared> ERDBIRCBNVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<JDQQUBYOTBT>> HMHBNINEZAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> NEAFHAVTUCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> JXWUJDNKKQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAField<GPNZGVDAJTA, MockCV2DynamicNetSys> TNWMZMOQIEJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<JDQQUBYOTBT>? RMQFPWQLTIR
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0xBB52C0", Offset = "0xBB46C0", VA = "0x180BB52C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0xFB4020", Offset = "0xFB3420", VA = "0x180FB4020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x2853030", Offset = "0x2852430", VA = "0x182853030")]
		public void Destroy([In] SOAId32<GPNZGVDAJTA> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2853E40", Offset = "0x2853240", VA = "0x182853E40")]
		public void NUENOOXQJKI(Id32<GPNZGVDAJTA> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x28542A0", Offset = "0x28536A0", VA = "0x1828542A0")]
		public void OOAXKTTEEGI(Id32<GPNZGVDAJTA> clientId, Id32<GPNZGVDAJTA>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x28547A0", Offset = "0x2853BA0", VA = "0x1828547A0")]
		public Id32<JDQQUBYOTBT> XCDLBYNARJO(Id32<GPNZGVDAJTA> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<GPNZGVDAJTA> clientIds)
		{
			return default(Id32<JDQQUBYOTBT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x28534F0", Offset = "0x28528F0", VA = "0x1828534F0")]
		public Id32<DSZQEJPSUJJ> GAIXMUYDOQU(Id32<GPNZGVDAJTA> clientId, string a, object b, UAIHKBQAJZH c, BPZOLTUSHZR d)
		{
			return default(Id32<DSZQEJPSUJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2853750", Offset = "0x2852B50", VA = "0x182853750")]
		public void GDHDAFMZOOM(Id32<GPNZGVDAJTA> clientId, Id32<DSZQEJPSUJJ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2853D20", Offset = "0x2853120", VA = "0x182853D20")]
		public Id32<JDQQUBYOTBT>? MVUZDIIAZAN([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x2854720", Offset = "0x2853B20", VA = "0x182854720")]
		public void RXPLDSCOUID([In] SOAId32<GPNZGVDAJTA> clientIds, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x28545E0", Offset = "0x28539E0", VA = "0x1828545E0")]
		public void PSFINALWZYB(Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2853270", Offset = "0x2852670", VA = "0x182853270")]
		public void EEGAXYDOVXL(Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2853370", Offset = "0x2852770", VA = "0x182853370")]
		public void EJBKDSXBOHN([In] SOAId32<GPNZGVDAJTA> clientIds, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x28538E0", Offset = "0x2852CE0", VA = "0x1828538E0")]
		public void IKNTUCQKSHB(Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, JJTCGSUBOXA? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2853DF0", Offset = "0x28531F0", VA = "0x182853DF0")]
		public Id32<GPNZGVDAJTA>? NMVWPDZXJRK(Id32<JDQQUBYOTBT> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x28539B0", Offset = "0x2852DB0", VA = "0x1828539B0")]
		public void JXBUNLROPGW([In] SOAId32<GPNZGVDAJTA> clientIds, Id32<GPNZGVDAJTA> clientId, Id32<DSZQEJPSUJJ> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2854BB0", Offset = "0x2853FB0", VA = "0x182854BB0")]
		public UXNMQUWNISU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class XJVHRNHEAHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x2854E10", Offset = "0x2854210", VA = "0x182854E10")]
		public static void Destroy(this UXNMQUWNISU.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class BXRLQUXUUEH : VZPXXBIZHZJ.VUJTJJOWWBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static BXRLQUXUUEH BIJDYAWAIVO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate GTZXNYOXOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate TDYVLXGYTMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xAAC040", Offset = "0xAAB440", VA = "0x180AAC040")]
		public BXRLQUXUUEH(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class ZNWMZVRLJBJ : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : NTEFXKGQILC.OAYYLTXYXIF<HJODGUBVAZG, ZNWMZVRLJBJ>
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
				public AsyncTaskMethodBuilder<Result<object, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public ZNWMZVRLJBJ root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public Id32<GPNZGVDAJTA> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public HJODGUBVAZG action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				private TaskAwaiter<Result<object, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007A8")]
				[Cpp2IlInjected.Address(RVA = "0x2852180", Offset = "0x2851580", VA = "0x182852180", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A9")]
				[Cpp2IlInjected.Address(RVA = "0x28523C0", Offset = "0x28517C0", VA = "0x1828523C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
			public int VLIUWXXGURX(ZNWMZVRLJBJ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x28502B0", Offset = "0x284F6B0", VA = "0x1828502B0", Slot = "5")]
			public int JDANBMRGQFJ(ZNWMZVRLJBJ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x2850470", Offset = "0x284F870", VA = "0x182850470", Slot = "6")]
			public int ZUMNGMYOUGM(ZNWMZVRLJBJ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xCA35D0", Offset = "0xCA29D0", VA = "0x180CA35D0", Slot = "7")]
			public int UDIXAIGHGZW(ZNWMZVRLJBJ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x28502D0", Offset = "0x284F6D0", VA = "0x1828502D0", Slot = "8")]
			public void XLKHBMVVKRZ(ZNWMZVRLJBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "9")]
			public bool YFEHDFHPGAU(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> actorId, HJODGUBVAZG[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "10")]
			public bool VEJHIFQZBRU(ZNWMZVRLJBJ a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2850320", Offset = "0x284F720", VA = "0x182850320", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, ZEEUKBHYSTE>> YYSLKNAWHOS(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> senderId, HJODGUBVAZG b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : NTEFXKGQILC.UCTXXJIHGPQ<ActionDeps, PRNNMMJSLKB.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps ULQFZKOZFIK
			{
				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public PRNNMMJSLKB.StaticNetSysReceiverDeps BQTRRBSIUGJ
			{
				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "5")]
				get
				{
					return default(PRNNMMJSLKB.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps GSGOEREMWPK
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : OKKGSXARKYW.UCJKCVUMNSY<ZNWMZVRLJBJ>
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
				public AsyncTaskMethodBuilder<Result<object?, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public ZNWMZVRLJBJ root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public Id32<GPNZGVDAJTA> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public HJODGUBVAZG action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				private TaskAwaiter<Result<object?, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0x2851E60", Offset = "0x2851260", VA = "0x182851E60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AF")]
				[Cpp2IlInjected.Address(RVA = "0x2852110", Offset = "0x2851510", VA = "0x182852110", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x28500D0", Offset = "0x284F4D0", VA = "0x1828500D0", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, ZEEUKBHYSTE>> YYSLKNAWHOS(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> clientId, HJODGUBVAZG b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : WUKDAXIYOHY.UCJKCVUMNSY<ZNWMZVRLJBJ>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x284FAF0", Offset = "0x284EEF0", VA = "0x18284FAF0", Slot = "4")]
			public void OOAXKTTEEGI(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xCA3220", Offset = "0xCA2620", VA = "0x180CA3220", Slot = "5")]
			public Id32<GPNZGVDAJTA>? YCAAJNRXAKX(ZNWMZVRLJBJ a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x284F6F0", Offset = "0x284EAF0", VA = "0x18284F6F0")]
			public Id32<JDQQUBYOTBT> XCDLBYNARJO(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<JDQQUBYOTBT>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x284FC80", Offset = "0x284F080", VA = "0x18284FC80", Slot = "7")]
			public void RXPLDSCOUID(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x284FB20", Offset = "0x284EF20", VA = "0x18284FB20", Slot = "8")]
			public void PSFINALWZYB(ZNWMZVRLJBJ a, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x284F6B0", Offset = "0x284EAB0", VA = "0x18284F6B0", Slot = "9")]
			public void EEGAXYDOVXL(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x284F750", Offset = "0x284EB50", VA = "0x18284F750", Slot = "10")]
			public void EJBKDSXBOHN(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, KMDWRSUVLAA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x284F980", Offset = "0x284ED80", VA = "0x18284F980", Slot = "11")]
			public void IKNTUCQKSHB(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> clientId, Id32<JDQQUBYOTBT> objectId, JJTCGSUBOXA? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x284FA90", Offset = "0x284EE90", VA = "0x18284FA90", Slot = "12")]
			public Id32<GPNZGVDAJTA>? NMVWPDZXJRK(ZNWMZVRLJBJ a, Id32<JDQQUBYOTBT> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x284F780", Offset = "0x284EB80", VA = "0x18284F780", Slot = "13")]
			public Id32<DSZQEJPSUJJ> GAIXMUYDOQU(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> clientId, string b, object c, UAIHKBQAJZH d, BPZOLTUSHZR e)
			{
				return default(Id32<DSZQEJPSUJJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x284F7E0", Offset = "0x284EBE0", VA = "0x18284F7E0", Slot = "14")]
			public void GDHDAFMZOOM(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> clientId, Id32<DSZQEJPSUJJ> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x284FA60", Offset = "0x284EE60", VA = "0x18284FA60", Slot = "15")]
			public void JXBUNLROPGW(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> clientId, Id32<DSZQEJPSUJJ> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x284F6F0", Offset = "0x284EAF0", VA = "0x18284F6F0", Slot = "6")]
			private Id32<JDQQUBYOTBT> EGUJAANEGBK(ZNWMZVRLJBJ a, Id32<GPNZGVDAJTA> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<JDQQUBYOTBT>);
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
			public ZNWMZVRLJBJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public Id32<JDQQUBYOTBT>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public KVKSDIRUDBG deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private Id32<GPNZGVDAJTA> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private VZKFCAVCIQQ<ZNWMZVRLJBJ, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private GRMJQVWYAHK<ZNWMZVRLJBJ, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private PRNNMMJSLKB <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x28517A0", Offset = "0x2850BA0", VA = "0x1828517A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2851DF0", Offset = "0x28511F0", VA = "0x182851DF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly SYRPNDMNFLO<HJODGUBVAZG, None, PRNNMMJSLKB, ActionDeps, PRNNMMJSLKB.StaticNetSysReceiverDeps, RootDeps, ZNWMZVRLJBJ, Deps> NNSOOIKRDNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly UXNMQUWNISU JHIHQVLMIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAId32<GPNZGVDAJTA> DJDKBGRWZWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<GPNZGVDAJTA, None> TNWMZMOQIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAField<GPNZGVDAJTA, PRNNMMJSLKB> FHWBCJTRGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Id32<GPNZGVDAJTA>? ZJRBIAWDYTQ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate PTUPSLFLTBO
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7C60", Offset = "0xAA7060", VA = "0x180AA7C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x2855960", Offset = "0x2854D60", VA = "0x182855960")]
		public ZNWMZVRLJBJ(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x2855380", Offset = "0x2854780", VA = "0x182855380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x2855550", Offset = "0x2854950", VA = "0x182855550")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> NUENOOXQJKI(KVKSDIRUDBG a, RegistryV2 b, Id32<JDQQUBYOTBT>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x28556D0", Offset = "0x2854AD0", VA = "0x1828556D0")]
		private void OOAXKTTEEGI(Id32<GPNZGVDAJTA> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x28552A0", Offset = "0x28546A0", VA = "0x1828552A0")]
		[CompilerGenerated]
		private Id32<JDQQUBYOTBT>? ACCYWZNGJNO([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class EVWAFQLEFAK : RWYGVNVPHCG.VUJTJJOWWBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<HVVQBWJJBSH> DeserializeCircuitsJunctionAsyncDelegate(PRNNMMJSLKB circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<HVVQBWJJBSH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public EVWAFQLEFAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public PRNNMMJSLKB circuitsManager;

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
			private TaskAwaiter<HVVQBWJJBSH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x2850490", Offset = "0x284F890", VA = "0x182850490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x2850690", Offset = "0x284FA90", VA = "0x182850690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate JOVFOUAFXIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleDidInitializeDelegate? ORMOZAXVKAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly LifecycleWillDestroyDelegate? RPMQELAOERE;

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x284E140", Offset = "0x284D540", VA = "0x18284E140", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<HVVQBWJJBSH> EXTAVPMTNTE(PRNNMMJSLKB a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
		public void POCBSLXSWTE(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xD1EC20", Offset = "0xD1E020", VA = "0x180D1EC20", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xDC6400", Offset = "0xDC5800", VA = "0x180DC6400", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x284E2B0", Offset = "0x284D6B0", VA = "0x18284E2B0")]
		public EVWAFQLEFAK([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class DESONWIDLVW : HCCGTESCYEY.VUJTJJOWWBJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate VTCCODAZOLE GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<ROZSWMJLVUC> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<ZBEHYKVOKWC> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<HCCGTESCYEY.VUJTJJOWWBJ.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<HCCGTESCYEY.VUJTJJOWWBJ.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public DESONWIDLVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			private TaskAwaiter<HCCGTESCYEY.VUJTJJOWWBJ.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x2850700", Offset = "0x284FB00", VA = "0x182850700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x28508F0", Offset = "0x284FCF0", VA = "0x1828508F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<ZBEHYKVOKWC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public DESONWIDLVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private TaskAwaiter<ZBEHYKVOKWC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x2850960", Offset = "0x284FD60", VA = "0x182850960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x2850B50", Offset = "0x284FF50", VA = "0x182850B50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<ROZSWMJLVUC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public DESONWIDLVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			private TaskAwaiter<ROZSWMJLVUC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2850BC0", Offset = "0x284FFC0", VA = "0x182850BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2850DB0", Offset = "0x28501B0", VA = "0x182850DB0", Slot = "5")]
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
			public DESONWIDLVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x2850E20", Offset = "0x2850220", VA = "0x182850E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2851010", Offset = "0x2850410", VA = "0x182851010", Slot = "5")]
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
			public DESONWIDLVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2851080", Offset = "0x2850480", VA = "0x182851080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x2851270", Offset = "0x2850670", VA = "0x182851270", Slot = "5")]
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
			public DESONWIDLVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x28512E0", Offset = "0x28506E0", VA = "0x1828512E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x28514D0", Offset = "0x28508D0", VA = "0x1828514D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetCV2DependenciesDelegate FVIAKBKJUZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetRoomDataAsyncDelegate OUUSUYGRQMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetSuperRoomDataAsyncDelegate NMTHMCDFVBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomAssetDataAsyncDelegate TUTSPVHNYJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetPlayerSaveDataAsyncDelegate XWTAEUZJETO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate WZYQHXGCAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetStaticCircuitsConfigAsyncDelegate WHUXYWCNTTO;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public VTCCODAZOLE VTCCODAZOLE
		{
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0xFF2980", Offset = "0xFF1D80", VA = "0x180FF2980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x284D100", Offset = "0x284C500", VA = "0x18284D100", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> PQBWLQREKRN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x284CEE0", Offset = "0x284C2E0", VA = "0x18284CEE0", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> GRGVXBGLPQK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x284D320", Offset = "0x284C720", VA = "0x18284D320", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<ROZSWMJLVUC> VOTWRZQIDLL(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x284CFF0", Offset = "0x284C3F0", VA = "0x18284CFF0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<ZBEHYKVOKWC> JPGKJGBFQBE(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x284D210", Offset = "0x284C610", VA = "0x18284D210", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<HCCGTESCYEY.VUJTJJOWWBJ.CircuitGraphToolMapping> TCECNGPKPPV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x284D430", Offset = "0x284C830", VA = "0x18284D430", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> ZMSAOGIURGO(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x284D540", Offset = "0x284C940", VA = "0x18284D540")]
		public DESONWIDLVW(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class FFZRORYXUFG : CV2Request.VUJTJJOWWBJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly CV2Request.VUJTJJOWWBJ ZOZTORXSSBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly GetCanSendRequestsDelegate OARHIRERZIQ;

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public FFZRORYXUFG(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xFF2980", Offset = "0xFF1D80", VA = "0x180FF2980", Slot = "4")]
		public bool PTAKBKCULDC()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class MFBOLCYXGJB : DEPMCWKOSXQ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, AFOSPUXIYKE> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly TryReportErrToUserDelegate LIUWMVVJBZK;

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x284E610", Offset = "0x284DA10", VA = "0x18284E610")]
		public bool CCZUGUEGOGO([In] Result<None, AFOSPUXIYKE> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x284F500", Offset = "0x284E900", VA = "0x18284F500")]
		public MFBOLCYXGJB([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x284E610", Offset = "0x284DA10", VA = "0x18284E610", Slot = "4")]
		private bool RZVTBFZJXHD([In] Result<None, AFOSPUXIYKE> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class PTRIXKDMLOK : HWWVWTNKRNF
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate VUYLGSMGCXP CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static readonly PTRIXKDMLOK ZOZTORXSSBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly CurrentExecParamsDelegate? ESSQJTPYOBO;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public VUYLGSMGCXP IMGPIXLWBLK
		{
			[Cpp2IlInjected.Token(Token = "0x600080B")]
			[Cpp2IlInjected.Address(RVA = "0xFF2980", Offset = "0xFF1D80", VA = "0x180FF2980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public PTRIXKDMLOK([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class KQPKQEUOMLG : JZZMFKCCSQP
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly JZZMFKCCSQP ZOZTORXSSBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly GetGameColorFromIdDelegate OQYWRVEYENS;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x284E610", Offset = "0x284DA10", VA = "0x18284E610", Slot = "4")]
		public CircuitsColor QSLJDBWJOYK(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x284F050", Offset = "0x284E450", VA = "0x18284F050")]
		public KQPKQEUOMLG([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class ETBZOOZKPWQ : DSKKGSMHSDN
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
			public ETBZOOZKPWQ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x2851540", Offset = "0x2850940", VA = "0x182851540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x2851730", Offset = "0x2850B30", VA = "0x182851730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly IsStringPureAsyncDelegate STPCSCOLHCD;

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x284DE50", Offset = "0x284D250", VA = "0x18284DE50", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> FKZRLPDXQPF(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x284DF90", Offset = "0x284D390", VA = "0x18284DF90")]
		public ETBZOOZKPWQ([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class FIFDEMFXVUS : OJKJTUFQHTH
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate PDQNYXYUBDH? GetNodeVisualizationConfigDelegate([In] Id128<XNNOENVVCYV> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public static readonly OJKJTUFQHTH ZOZTORXSSBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly GetNodeVisualizationConfigDelegate AQKCXOGTKYW;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x284E610", Offset = "0x284DA10", VA = "0x18284E610")]
		public PDQNYXYUBDH? DWKMYFJVGMA([In] Id128<XNNOENVVCYV> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x284E6B0", Offset = "0x284DAB0", VA = "0x18284E6B0")]
		public FIFDEMFXVUS([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x284E610", Offset = "0x284DA10", VA = "0x18284E610", Slot = "4")]
		private PDQNYXYUBDH OLAJOLOQPUE([In] Id128<XNNOENVVCYV> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class EDXCQMGHMZD : OSFRBXMQTKU
	{
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x284DE00", Offset = "0x284D200", VA = "0x18284DE00", Slot = "4")]
		public NUIOMADGJVH HNXCAISODCF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public EDXCQMGHMZD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class LIOWRWNQZOP : RILPKECODQM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, bool> FCEDQUAMTLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, float> JXZLIHEAGKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, double> LLLJSHSBPLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, int> CLJJAESYHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, long> LMZBIVKLFCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, string> VNWUSFXVZST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, uint> GABQVKCXNQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, ulong> EOFVPLSBCCJ;

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x284F1F0", Offset = "0x284E5F0", VA = "0x18284F1F0", Slot = "4")]
		public bool? ZRNRLJQOQNA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x284F290", Offset = "0x284E690", VA = "0x18284F290")]
		public LIOWRWNQZOP()
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
