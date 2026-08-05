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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AFFDD0", Offset = "0x2AFE9D0", VA = "0x182AFFDD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
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
		internal sealed class UZAWHRBZUZS : NNUVDKBLROH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UZAWHRBZUZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0", Slot = "4")]
			public NNUVDKBLROH OBQIHAJMBSL(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0", Slot = "5")]
			public NNUVDKBLROH GRFKSHXEHZI(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0", Slot = "6")]
			public NNUVDKBLROH VDZNUPNJXHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
			public void CLJSAMBXECZ()
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
	public static class SLIXCCYOLMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public EMQYARIYMUS URALBLDKLAX;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B03BC0", Offset = "0x2B027C0", VA = "0x182B03BC0")]
			internal LEWVSLHMGCM IBAGSSPQAXM(GetNetworkObjectDelegate a)
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
			public HAHYOVHKCDQ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public HPHIQELCELX network;

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
			[Cpp2IlInjected.Address(RVA = "0x2B01850", Offset = "0x2B00450", VA = "0x182B01850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B01EF0", Offset = "0x2B00AF0", VA = "0x182B01EF0", Slot = "5")]
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
			public HPHIQELCELX network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public HAHYOVHKCDQ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<STFYXSIYFLB>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private XXEAPKVABFJ <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B01F60", Offset = "0x2B00B60", VA = "0x182B01F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B024F0", Offset = "0x2B010F0", VA = "0x182B024F0", Slot = "5")]
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
			public EMQYARIYMUS roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B02560", Offset = "0x2B01160", VA = "0x182B02560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B02A70", Offset = "0x2B01670", VA = "0x182B02A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B01290", Offset = "0x2AFFE90", VA = "0x182B01290")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? YVRMEHARUXW([Optional] EMQYARIYMUS? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F80", Offset = "0x2AFFB80", VA = "0x182B00F80")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> TTYBIFJLLZX(HPHIQELCELX a, [Optional] HAHYOVHKCDQ? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B01100", Offset = "0x2AFFD00", VA = "0x182B01100")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> TTYBIFJLLZX(HPHIQELCELX a, HAHYOVHKCDQ b, RegistryV2 c, Id32<STFYXSIYFLB>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B00E30", Offset = "0x2AFFA30", VA = "0x182B00E30")]
		public static (RuntimeFnRegistry, RuntimeFns) MHDYGPPUBXX()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B00D30", Offset = "0x2AFF930", VA = "0x182B00D30")]
		public static (ExternalFnRegistry, ExternalFns) COXBQTQIAHA()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F00", Offset = "0x2AFFB00", VA = "0x182B00F00")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static HPHIQELCELX NZZPHQKPHOL(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class HPWTOSRCDTT
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate LEWVSLHMGCM CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public HPWTOSRCDTT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B01460", Offset = "0x2B00060", VA = "0x182B01460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B017E0", Offset = "0x2B003E0", VA = "0x182B017E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly HPHIQELCELX QBSUONKZPQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? PWZSPUJQCIX;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		private HPWTOSRCDTT(HPHIQELCELX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF7C0", Offset = "0x2AFE3C0", VA = "0x182AFF7C0")]
		public static HPWTOSRCDTT SIUHUEYRRON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF7A0", Offset = "0x2AFE3A0", VA = "0x182AFF7A0")]
		public HPWTOSRCDTT DHVJNTFHXXG(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF6B0", Offset = "0x2AFE2B0", VA = "0x182AFF6B0")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> CLJSAMBXECZ()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class DPDJUZTNXNJ : XXEAPKVABFJ.ODRSNXNZSZX
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate XVENBBMCSIN NewCircuitsLifecycleDelegate(HLQSLBGKSFS.ODRSNXNZSZX deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(XXEAPKVABFJ circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(XXEAPKVABFJ circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate SEFJKEBDHUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate QFZPRHUEXVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate UUFALDCSOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate HJIKQPOCLQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate CESABWSSTKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate MEEBEVFNMTY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int WPKYTONSOYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x12B9250", Offset = "0x12B7E50", VA = "0x1812B9250", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE600", Offset = "0x2AFD200", VA = "0x182AFE600", Slot = "6")]
		public void SMFAAABNEQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE630", Offset = "0x2AFD230", VA = "0x182AFE630", Slot = "7")]
		public void ZBOTPKSSUGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE5D0", Offset = "0x2AFD1D0", VA = "0x182AFE5D0", Slot = "5")]
		public XVENBBMCSIN BGUZMDCHWUC(HLQSLBGKSFS.ODRSNXNZSZX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF03850", Offset = "0xF02450", VA = "0x180F03850", Slot = "8")]
		public void BUOAZLJHQOX(XXEAPKVABFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF038B0", Offset = "0xF024B0", VA = "0x180F038B0", Slot = "9")]
		public void IKEFLBMLIHC(XXEAPKVABFJ a, FXFJUDAMIWO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE660", Offset = "0x2AFD260", VA = "0x182AFE660")]
		public DPDJUZTNXNJ([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly HUACHFUJUGG<HPHIQELCELX, HPHIQELCELX.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly BFJWOIONIEO<HPHIQELCELX, HPHIQELCELX.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly XXEAPKVABFJ CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<GEJEFIAWMNS> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly HPHIQELCELX Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEF10", Offset = "0x2AFDB10", VA = "0x182AFEF10")]
		public EVCreationResult(HUACHFUJUGG<HPHIQELCELX, HPHIQELCELX.MockStaticNetSysDeps> staticNetSys, BFJWOIONIEO<HPHIQELCELX, HPHIQELCELX.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, XXEAPKVABFJ circuitsManager, Id32<GEJEFIAWMNS> clientId, HPHIQELCELX network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly XXEAPKVABFJ _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 USXXQEQUCYP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFD20", Offset = "0x2AFE920", VA = "0x182AFFD20")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request NRYLSGMUOIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFC90", Offset = "0x2AFE890", VA = "0x182AFFC90")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public UVZHGVMFUGK? TVKKHUAZLCN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFBA0", Offset = "0x2AFE7A0", VA = "0x182AFFBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public EOMRJYDEACK? KEHJKNTJZOR
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFCC0", Offset = "0x2AFE8C0", VA = "0x182AFFCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		internal LimitedCircuits(XXEAPKVABFJ circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class QHUUJFWVLXB : HAHYOVHKCDQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KLYTXZLOCGR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public LEWVSLHMGCM TZSPZWSIBKA;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public KLYTXZLOCGR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			internal LEWVSLHMGCM YCPVIQVLWBU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public HLQSLBGKSFS.ODRSNXNZSZX SWMSEXOCKHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public XXEAPKVABFJ.ODRSNXNZSZX KUDMWPWEUFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GFREUFWJHCW.ODRSNXNZSZX CNTZRWREGMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ> ZKACJCVERLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.ODRSNXNZSZX HZQEDPZHDBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SZNXFZCEGDW WDOKEZLXTRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CNGANKRQXIV WFSWMWLMNXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public WNSVIDJHVWR IPYCYPEMXYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LGZSDACFKQJ XFDGRKSQAAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CBQIBVXTUYH ALSEHUSRKSO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECD50", VA = "0x180CEE150", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B00B90", Offset = "0x2AFF790", VA = "0x182B00B90")]
		private QHUUJFWVLXB(HLQSLBGKSFS.ODRSNXNZSZX a, XXEAPKVABFJ.ODRSNXNZSZX b, GFREUFWJHCW.ODRSNXNZSZX c, JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ> d, CV2Request.ODRSNXNZSZX e, SZNXFZCEGDW f, CNGANKRQXIV g, WNSVIDJHVWR h, LGZSDACFKQJ i, CBQIBVXTUYH j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B006E0", Offset = "0x2AFF2E0", VA = "0x182B006E0")]
		public static QHUUJFWVLXB? JMHRYANMZUE(GFREUFWJHCW.ODRSNXNZSZX cv2RootSysDeps, [Optional] HLQSLBGKSFS.ODRSNXNZSZX? a, [Optional] XXEAPKVABFJ.ODRSNXNZSZX? b, [Optional] JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>? reducerDeps, [Optional] CV2Request.ODRSNXNZSZX? c, [Optional] SZNXFZCEGDW? d, [Optional] CNGANKRQXIV? e, [Optional] WNSVIDJHVWR? f, [Optional] LGZSDACFKQJ? g, [Optional] CBQIBVXTUYH? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B00A40", Offset = "0x2AFF640", VA = "0x182B00A40")]
		public static QHUUJFWVLXB RGMASPZKRAU(LEWVSLHMGCM a, [Optional] HLQSLBGKSFS.ODRSNXNZSZX? circuitsLifecycleDeps, [Optional] XXEAPKVABFJ.ODRSNXNZSZX? circuitsManagerDeps, [Optional] JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B00360", Offset = "0x2AFEF60", VA = "0x182B00360")]
		public static QHUUJFWVLXB CZWWIFDOEQW(GetNetworkObjectDelegate a, [Optional] HLQSLBGKSFS.ODRSNXNZSZX? circuitsLifecycleDeps, [Optional] XXEAPKVABFJ.ODRSNXNZSZX? circuitsManagerDeps, [Optional] JRCKZXYCDCE.VCVAKIZRWMY<ActionKind, FXFJUDAMIWO, XXEAPKVABFJ>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class XDYEVZPRDXE
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class HGOHUZHWDLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public GetNetworkObjectDelegate PGHBCCQYKLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int HOSZJGPNBYA;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public HGOHUZHWDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF4E0", Offset = "0x2AFE0E0", VA = "0x182AFF4E0")]
			internal SEVVSWFCYQX IYWLBRYTUYN(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF550", Offset = "0x2AFE150", VA = "0x182AFF550")]
			internal SEVVSWFCYQX[] IZBRYYSREJW(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0")]
			internal int XUPTOYMNCLC()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HGJAXSNYTZU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public DynamicEnvironmentNetworkId YTHMHWCVTWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public HGOHUZHWDLD FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public HGJAXSNYTZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF430", Offset = "0x2AFE030", VA = "0x182AFF430")]
			internal SEVVSWFCYQX QZFLXABTYBT(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly SDSGZEUUWRN UNSRQEFRHPG;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AC10", Offset = "0x2B09810", VA = "0x182B0AC10")]
		public static SEVVSWFCYQX? YKLVDKHHKMA(Id32<STFYXSIYFLB>? networkObject, [Optional] XKVXCPVPROO.SerializesIntoSavesDelegate? a, [Optional] XKVXCPVPROO.SerializesIntoInventionsDelegate? b, [Optional] XKVXCPVPROO.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B06640", Offset = "0x2B05240", VA = "0x182B06640")]
		public static LEWVSLHMGCM? HAWXHVVTHXL(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] ZEQAUYTRFYT? b, [Optional] ZCUTXEYWEKT? c, [Optional] WHHRJMKNBCX? d, [Optional] EMQYARIYMUS? e, int f = 300000, bool g = false, bool h = false, [Optional] TNPFMTBMEDB? i, [Optional] BCUKXTEZGAT? j, [Optional] JQMVJQRQZJG? k, [Optional] UAJWEHKAWJR? l, [Optional] ZAWQUGKQBEM? m, [Optional] BJSDJSUFFST? n, [Optional] UUHXPVSFXIV.ODRSNXNZSZX? o, [Optional] EqualsNodeV2.ODRSNXNZSZX? p, [Optional] AOKLQWLZMFZ? q, [Optional] LEWVSLHMGCM.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] LEWVSLHMGCM.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] LEWVSLHMGCM.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] LEWVSLHMGCM.GetLocalRoomIdDelegate? u, [Optional] LEWVSLHMGCM.GetLocalSubroomIdDelegate? v, [Optional] LEWVSLHMGCM.GetSubroomIdsForLocalRoomDelegate? w, [Optional] LEWVSLHMGCM.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] LEWVSLHMGCM.SaveRoomOnPlayerBehalfDelegate? z, [Optional] LEWVSLHMGCM.ReportCloudDataLedgerChangedDelegate? ba, [Optional] LEWVSLHMGCM.GetColorNameByIdDelegate? bb, [Optional] LEWVSLHMGCM.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] LEWVSLHMGCM.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] LEWVSLHMGCM.GetTaggableNameFromSignalDelegate? be, [Optional] LEWVSLHMGCM.GetAudioNameFromSignalDelegate? bf, [Optional] LEWVSLHMGCM.GetDestinationNameFromSignalDelegate? bg, [Optional] LEWVSLHMGCM.GetPlayerEventNameFromSignalDelegate? bh, [Optional] LEWVSLHMGCM.GetRoomKeyNameFromSignalDelegate? bi, [Optional] LEWVSLHMGCM.GetRewardNameFromSignalDelegate? bj, [Optional] LEWVSLHMGCM.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] LEWVSLHMGCM.ReportPreloadedAudioChangedDelegate? bl, [Optional] LEWVSLHMGCM.ReportRewardDataChangedDelegate? bm, [Optional] LEWVSLHMGCM.GetConsumableNameFromSignalDelegate? bn, [Optional] LEWVSLHMGCM.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] LEWVSLHMGCM.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] LEWVSLHMGCM.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] LEWVSLHMGCM.GetInventoryItemNameFromSignalDelegate? br, [Optional] LEWVSLHMGCM.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] LEWVSLHMGCM.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] LEWVSLHMGCM.GetRoomOfferNameFromSignalDelegate? bu, [Optional] LEWVSLHMGCM.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] LEWVSLHMGCM.GetObjectIdFromCreationObjectDelegate? bw, [Optional] LEWVSLHMGCM.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] LEWVSLHMGCM.GetCostInBytesDelegate? by, [Optional] LEWVSLHMGCM.GetAvatarItemNameFromSignalDelegate? bz, [Optional] LEWVSLHMGCM.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] LEWVSLHMGCM.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] LEWVSLHMGCM.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] LEWVSLHMGCM.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] LEWVSLHMGCM.GetStoreItemNameFromSignalDelegate? ce, [Optional] LEWVSLHMGCM.GetBodyPartNameFromSignalDelegate? cf, [Optional] LEWVSLHMGCM.GetDependenciesForGraphInstanceDelegate? cg, [Optional] LEWVSLHMGCM.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] LEWVSLHMGCM.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] LEWVSLHMGCM.GetRecNetImageNameFromSignalDelegate? cj, [Optional] LEWVSLHMGCM.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] LEWVSLHMGCM.IsFunctionValidForAIDelegate? cm, [Optional] LEWVSLHMGCM.GetAIFunctionNameFromSignalDelegate? cn, [Optional] LEWVSLHMGCM.FromSerializableObjectDelegate? co, [Optional] LEWVSLHMGCM.ToSerializableObjectDelegate? cp)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<STFYXSIYFLB>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class GYBMUWRSDON : JQMVJQRQZJG
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly GYBMUWRSDON UXEDIFVFAQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly GetLocalPlayerDelegate? KKMNVHOOZQM;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEFB0", Offset = "0x2AFDBB0", VA = "0x182AFEFB0", Slot = "4")]
		public (MPNBQAEPLEN, MPNBQAEPLEN, MPNBQAEPLEN, MPNBQAEPLEN, MPNBQAEPLEN) YWPYWCPVTPF(object a)
		{
			return default((MPNBQAEPLEN, MPNBQAEPLEN, MPNBQAEPLEN, MPNBQAEPLEN, MPNBQAEPLEN));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEF80", Offset = "0x2AFDB80", VA = "0x182AFEF80", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "6")]
		public bool BXDMPUECVXA(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD54960", Offset = "0xD53560", VA = "0x180D54960", Slot = "7")]
		public string FXPDZKSVARC(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public GYBMUWRSDON([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class XKVXCPVPROO : SEVVSWFCYQX
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(XKVXCPVPROO self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(XKVXCPVPROO self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(XKVXCPVPROO self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly SerializesIntoSavesDelegate EZZUNBRGEEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly SerializesIntoInventionsDelegate JPDUYNJNMRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly CanPublishInInventionsDelegate MJLHMAVNGYL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FDOGRQSMFQZ? XPENPGTBYGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId KIKDNRPOSTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xFC7000", Offset = "0xFC5C00", VA = "0x180FC7000", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CSMQEDWQEDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B3D0", Offset = "0x2B09FD0", VA = "0x182B0B3D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PSILJEUONNU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B3A0", Offset = "0x2B09FA0", VA = "0x182B0B3A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool UFUWKQBVDDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B370", Offset = "0x2B09F70", VA = "0x182B0B370", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public WNRALCNEBYE? IKRMJGUGGML
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<STFYXSIYFLB>? BREJQWMKXXD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B220", Offset = "0x2B09E20", VA = "0x182B0B220", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ACB0", Offset = "0x2B098B0", VA = "0x182B0ACB0", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(SDSGZEUUWRN e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10", Slot = "13")]
		public void Bind(FDOGRQSMFQZ controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B2C0", Offset = "0x2B09EC0", VA = "0x182B0B2C0")]
		private XKVXCPVPROO(Id32<STFYXSIYFLB>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AD50", Offset = "0x2B09950", VA = "0x182B0AD50")]
		public static XKVXCPVPROO? New(Id32<STFYXSIYFLB>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class ASIDPVPLASW : TNPFMTBMEDB
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
		public static readonly ASIDPVPLASW UXEDIFVFAQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly RoundToDecimalPlaceDelegate? LCTYKCRRLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly TruncateToDecimalPlaceDelegate? SFBWKJDSSCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsColorLerpDelegate? ASOYMSEAHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsColorInverseLerpDelegate? VQRJCTOLWYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4GetPositionDelegate? GMIFWOULFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4GetRotationDelegate? JSYIZBWCNWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsMtx4x4InverseDelegate? YCAQLXYOAZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsMtx4x4MultiplyDelegate? EQGJURBRARB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? GCQDVGPNPVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatDotDelegate? VZHAOXLIHYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromAngleAxisDelegate? IRIFOVKQUGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? NJLAWGESKNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatFromFromToRotationDelegate? VHACKTMXOTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatFromLookRotationDelegate? TMELFDENZIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? RXRIBXVFEYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseDelegate? GWEJSVLEBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatLerpDelegate? YRHCONLQZHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatLerpUnclampedDelegate? RVKXUAGSAJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatInverseLerpDelegate? TUBFNBHLLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatMultiplyDelegate? UJSBVLPBQWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatNormalizeDelegate? YZXEYOJBPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatRotateTowardsDelegate? SKIRFTTQOBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatRotateVectorDelegate? TOPJQBEXHWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatSlerpDelegate? NTBLDBNGPCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsQuatToAngleAxisDelegate? LXLVDNAKEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsQuatToEulerAnglesDelegate? NOPFHKIXOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3AddDelegate? HKPEZQVDYPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? DYJLHEBEVWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? GGUICEGXOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3CrossDelegate? KNRNFNMKMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3DotDelegate? EFQIQGZSRMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3AngleDelegate? UWBFYAJWJSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3GetMagnitudeDelegate? BTCDQXNXZWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3LerpDelegate? MFQKBHFYXDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3LerpUnclampedDelegate? ZLNFYOTZUXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3InverseLerpDelegate? JJWWHFDREMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3MoveTowardsDelegate? PYZHYYZJQQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3NegateDelegate? VTXJLPYXXMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3NormalizeDelegate? CHNBWYMGCVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ProjectDelegate? RGKDNYQQXGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? QJSOAEEGHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3ScaleDelegate? DRPYDICGGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SmoothDampDelegate? CDYXPLMUCNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3SubtractDelegate? EZYYCTLNBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3SlerpDelegate? XVDOLUPAHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly CircuitsVec3TransformDelegate? VQMONRXQZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CircuitsVec3InverseTransformDelegate? BJBJWEQFRJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly RealtimeSinceStartupDelegate? VUJNKQPDEGH;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD290", Offset = "0x2AFBE90", VA = "0x182AFD290")]
		public ASIDPVPLASW([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBB80", Offset = "0x2AFA780", VA = "0x182AFBB80")]
		public float KLOJWOMZICX([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB5D0", Offset = "0x2AFA1D0", VA = "0x182AFB5D0")]
		public float CZEIJWBPGZH([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCBD0", Offset = "0x2AFB7D0", VA = "0x182AFCBD0")]
		public CircuitsColor YDPRYNNTNYS([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB1A0", Offset = "0x2AF9DA0", VA = "0x182AFB1A0")]
		public float XJLXKGXHXNO([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBEC0", Offset = "0x2AFAAC0", VA = "0x182AFBEC0")]
		public CircuitsVec3 KNZPKNBBVTO([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC8D0", Offset = "0x2AFB4D0", VA = "0x182AFC8D0")]
		public CircuitsQuat TRMDUJQCKSZ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBA30", Offset = "0x2AFA630", VA = "0x182AFBA30")]
		public CircuitsMtx4x4 GASMRAZDKPZ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC7F0", Offset = "0x2AFB3F0", VA = "0x182AFC7F0")]
		public CircuitsMtx4x4 TEIRXIVMFEV([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCD60", Offset = "0x2AFB960", VA = "0x182AFCD60")]
		public CircuitsMtx4x4 YNJYYPLJSGB([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC240", Offset = "0x2AFAE40", VA = "0x182AFC240")]
		public float MTNKVOCEDSS([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC6F0", Offset = "0x2AFB2F0", VA = "0x182AFC6F0")]
		public CircuitsQuat RFSPRWEAFSX(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB4C0", Offset = "0x2AFA0C0", VA = "0x182AFB4C0")]
		public CircuitsQuat LVURUGMEFNK([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBF20", Offset = "0x2AFAB20", VA = "0x182AFBF20")]
		public CircuitsQuat OVLOCOYXTME([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB7E0", Offset = "0x2AFA3E0", VA = "0x182AFB7E0")]
		public CircuitsQuat EQMGYRMRIZM([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB1D0", Offset = "0x2AF9DD0", VA = "0x182AFB1D0")]
		public CircuitsQuat KHMQEQRVCJH([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB320", Offset = "0x2AF9F20", VA = "0x182AFB320")]
		public CircuitsQuat PUKXWCPAKYW([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB660", Offset = "0x2AFA260", VA = "0x182AFB660")]
		public CircuitsQuat DHFVQTFFIPH([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC520", Offset = "0x2AFB120", VA = "0x182AFC520")]
		public float ZJFQAZKGUKA([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB270", Offset = "0x2AF9E70", VA = "0x182AFB270")]
		public CircuitsQuat VEMNYAXMNML([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBC90", Offset = "0x2AFA890", VA = "0x182AFBC90")]
		public CircuitsQuat JXQPKOPNIIK([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC110", Offset = "0x2AFAD10", VA = "0x182AFC110")]
		public CircuitsQuat MCAVQOHYSYA([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD050", Offset = "0x2AFBC50", VA = "0x182AFD050")]
		public CircuitsVec3 ZTTBYWHKDKD([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB720", Offset = "0x2AFA320", VA = "0x182AFB720")]
		public CircuitsQuat JVBLTAINJMB([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC330", Offset = "0x2AFAF30", VA = "0x182AFC330")]
		public void VDMUQXFVUMQ([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCEA0", Offset = "0x2AFBAA0", VA = "0x182AFCEA0")]
		public CircuitsVec3 YWNKNOUQPQH([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCF70", Offset = "0x2AFBB70", VA = "0x182AFCF70")]
		public CircuitsVec3 ZDTWWGHATRA([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCB60", Offset = "0x2AFB760", VA = "0x182AFCB60")]
		public CircuitsVec3 XODVKIKVRRG([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC9B0", Offset = "0x2AFB5B0", VA = "0x182AFC9B0")]
		public CircuitsVec3 VHLKXUYCMSV([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB950", Offset = "0x2AFA550", VA = "0x182AFB950")]
		public CircuitsVec3 FWDYENITHAN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC040", Offset = "0x2AFAC40", VA = "0x182AFC040")]
		public float RBWMBLNIAZU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBC10", Offset = "0x2AFA810", VA = "0x182AFBC10")]
		public float RVXZVORSCCW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC3D0", Offset = "0x2AFAFD0", VA = "0x182AFC3D0")]
		public float PDDTIMFUVIZ([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC920", Offset = "0x2AFB520", VA = "0x182AFC920")]
		public CircuitsVec3 TSFROZVLIQC([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCAF0", Offset = "0x2AFB6F0", VA = "0x182AFCAF0")]
		public CircuitsVec3 XHZJBLUXBKZ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB920", Offset = "0x2AFA520", VA = "0x182AFB920")]
		public float FQPCJGLGECU([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBBA0", Offset = "0x2AFA7A0", VA = "0x182AFBBA0")]
		public CircuitsVec3 ILNXRRLKUPU([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB890", Offset = "0x2AFA490", VA = "0x182AFB890")]
		public CircuitsVec3 EZBDUWSNKRP([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC260", Offset = "0x2AFAE60", VA = "0x182AFC260")]
		public CircuitsVec3 MYGDUBZAXWW([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCA20", Offset = "0x2AFB620", VA = "0x182AFCA20")]
		public CircuitsVec3 VTZKFWMGBEU([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC30", Offset = "0x2AFB830", VA = "0x182AFCC30")]
		public CircuitsVec3 YGXOUIIEOCN([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC550", Offset = "0x2AFB150", VA = "0x182AFC550")]
		public CircuitsVec3 QQAGJSJWMDN([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC060", Offset = "0x2AFAC60", VA = "0x182AFC060")]
		public CircuitsVec3 LXTQHSUMVYL([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB9C0", Offset = "0x2AFA5C0", VA = "0x182AFB9C0")]
		public CircuitsVec3 FXIBPKPWQST([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC680", Offset = "0x2AFB280", VA = "0x182AFC680")]
		public CircuitsVec3 RAQMQQEHLZL([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCDD0", Offset = "0x2AFB9D0", VA = "0x182AFCDD0")]
		public CircuitsVec3 YVIPWEPDIRD([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBE00", Offset = "0x2AFAA00", VA = "0x182AFBE00")]
		public CircuitsVec3 KLMDTWALRJF([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB8F0", Offset = "0x2AFA4F0", VA = "0x182AFB8F0", Slot = "50")]
		public Task FDIKZSMAYVH(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "51")]
		public void ZCPPZGSRGMV([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC7A0", Offset = "0x2AFB3A0", VA = "0x182AFC7A0", Slot = "52")]
		public UBEBOZCAVGU<KONMMJWHXTO> ROYFGZQKBAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBE70", Offset = "0x2AFAA70", VA = "0x182AFBE70", Slot = "53")]
		public UBEBOZCAVGU<KONMMJWHXTO> KNUUDIXVUWE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC990", Offset = "0x2AFB590", VA = "0x182AFC990", Slot = "54")]
		public float UXUAXSCMTPY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBB80", Offset = "0x2AFA780", VA = "0x182AFBB80", Slot = "4")]
		private float IJJTNUAIBSR([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB5D0", Offset = "0x2AFA1D0", VA = "0x182AFB5D0", Slot = "5")]
		private float MSSPKZLDVIP([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBC30", Offset = "0x2AFA830", VA = "0x182AFBC30", Slot = "6")]
		private CircuitsColor IWXOAAWOMRW([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB1A0", Offset = "0x2AF9DA0", VA = "0x182AFB1A0", Slot = "7")]
		private float ANXJCAUPYCG([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC370", Offset = "0x2AFAF70", VA = "0x182AFC370", Slot = "8")]
		private CircuitsVec3 ONFCINRIEYC([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC630", Offset = "0x2AFB230", VA = "0x182AFC630", Slot = "9")]
		private CircuitsQuat QVZCGYJTXPN([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCA90", Offset = "0x2AFB690", VA = "0x182AFCA90", Slot = "10")]
		private CircuitsMtx4x4 WPTYREYPGBL([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCE40", Offset = "0x2AFBA40", VA = "0x182AFCE40", Slot = "11")]
		private CircuitsMtx4x4 YWMPDTNPORB([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC3F0", Offset = "0x2AFAFF0", VA = "0x182AFC3F0", Slot = "12")]
		private CircuitsMtx4x4 PEBKNKNEUYT([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC240", Offset = "0x2AFAE40", VA = "0x182AFC240", Slot = "13")]
		private float ONTFUCDVYPW([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC6F0", Offset = "0x2AFB2F0", VA = "0x182AFC6F0", Slot = "14")]
		private CircuitsQuat RQUALCUQGWJ(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB4C0", Offset = "0x2AFA0C0", VA = "0x182AFB4C0", Slot = "15")]
		private CircuitsQuat CTAINZUPRZE([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBF20", Offset = "0x2AFAB20", VA = "0x182AFBF20", Slot = "16")]
		private CircuitsQuat KSAQYKVKSWK([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB7E0", Offset = "0x2AFA3E0", VA = "0x182AFB7E0", Slot = "17")]
		private CircuitsQuat TRLXPTQVYYA([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB1D0", Offset = "0x2AF9DD0", VA = "0x182AFB1D0", Slot = "18")]
		private CircuitsQuat APVZZLZOPQT([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB320", Offset = "0x2AF9F20", VA = "0x182AFB320", Slot = "19")]
		private CircuitsQuat BIFTJGAEWAU([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB660", Offset = "0x2AFA260", VA = "0x182AFB660", Slot = "20")]
		private CircuitsQuat HRRJQLUOHVJ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC520", Offset = "0x2AFB120", VA = "0x182AFC520", Slot = "21")]
		private float QCOXMKMLKNU([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB270", Offset = "0x2AF9E70", VA = "0x182AFB270", Slot = "22")]
		private CircuitsQuat BGSEGTOVVAF([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBC90", Offset = "0x2AFA890", VA = "0x182AFBC90", Slot = "23")]
		private CircuitsQuat UEPFMAINAVG([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC110", Offset = "0x2AFAD10", VA = "0x182AFC110", Slot = "24")]
		private CircuitsQuat UAOGUMCHNNI([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBD30", Offset = "0x2AFA930", VA = "0x182AFBD30", Slot = "25")]
		private CircuitsVec3 KCUCDCUMMLH([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB720", Offset = "0x2AFA320", VA = "0x182AFB720", Slot = "26")]
		private CircuitsQuat DHJFCMDOGCH([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC330", Offset = "0x2AFAF30", VA = "0x182AFC330", Slot = "27")]
		private void OCIWSFPEEDY([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC4C0", Offset = "0x2AFB0C0", VA = "0x182AFC4C0", Slot = "28")]
		private CircuitsVec3 PVKSWHFXDRX([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCFE0", Offset = "0x2AFBBE0", VA = "0x182AFCFE0", Slot = "29")]
		private CircuitsVec3 ZHOIZRVCKFG([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBB10", Offset = "0x2AFA710", VA = "0x182AFBB10", Slot = "30")]
		private CircuitsVec3 IBBMTEFFXKO([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC860", Offset = "0x2AFB460", VA = "0x182AFC860", Slot = "31")]
		private CircuitsVec3 TKOXXMKDEEP([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC5C0", Offset = "0x2AFB1C0", VA = "0x182AFC5C0", Slot = "32")]
		private CircuitsVec3 QTMAJNXBAEP([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB3E0", Offset = "0x2AF9FE0", VA = "0x182AFB3E0", Slot = "33")]
		private CircuitsVec3 BQMSBHLYWKD([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB450", Offset = "0x2AFA050", VA = "0x182AFB450", Slot = "34")]
		private CircuitsVec3 CSCDMAIINZT([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC040", Offset = "0x2AFAC40", VA = "0x182AFC040", Slot = "35")]
		private float LMHTFEKWOMU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBC10", Offset = "0x2AFA810", VA = "0x182AFBC10", Slot = "36")]
		private float INPINWRYQNC([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC3D0", Offset = "0x2AFAFD0", VA = "0x182AFC3D0", Slot = "37")]
		private float XLQWQEHXWIX([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC1D0", Offset = "0x2AFADD0", VA = "0x182AFC1D0", Slot = "38")]
		private CircuitsVec3 MGCJZQZHRIQ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC2C0", Offset = "0x2AFAEC0", VA = "0x182AFC2C0", Slot = "39")]
		private CircuitsVec3 OAUKAQXPLHN([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB920", Offset = "0x2AFA520", VA = "0x182AFB920", Slot = "40")]
		private float ZGKMKVXZWKS([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB5F0", Offset = "0x2AFA1F0", VA = "0x182AFB5F0", Slot = "41")]
		private CircuitsVec3 DFUGGRDWYLW([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB140", Offset = "0x2AF9D40", VA = "0x182AFB140", Slot = "42")]
		private CircuitsVec3 AMCMQDEIXDN([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBDA0", Offset = "0x2AFA9A0", VA = "0x182AFBDA0", Slot = "43")]
		private CircuitsVec3 KFNVCWDFPHG([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCF00", Offset = "0x2AFBB00", VA = "0x182AFCF00", Slot = "44")]
		private CircuitsVec3 YYVXWFCRDGS([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC450", Offset = "0x2AFB050", VA = "0x182AFC450", Slot = "45")]
		private CircuitsVec3 PSJKITQCSBR([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBFD0", Offset = "0x2AFABD0", VA = "0x182AFBFD0", Slot = "46")]
		private CircuitsVec3 LCFACPBOYMF([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCCA0", Offset = "0x2AFB8A0", VA = "0x182AFCCA0", Slot = "47")]
		private CircuitsVec3 YIRXRRHYXLP([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBAA0", Offset = "0x2AFA6A0", VA = "0x182AFBAA0", Slot = "48")]
		private CircuitsVec3 GXXJTKANZYB([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB560", Offset = "0x2AFA160", VA = "0x182AFB560", Slot = "49")]
		private CircuitsVec3 CUNUFWUBUBB([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class VTUTGMDTEUC : SSDPRXPVIVB
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x1329660", Offset = "0x1328260", VA = "0x181329660", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1127A70", Offset = "0x1126670", VA = "0x181127A70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2B04410", Offset = "0x2B03010", VA = "0x182B04410")]
		public VTUTGMDTEUC(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class JPOXARHIIDM : BCUKXTEZGAT
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(JTWCQRGBJCE e, TDFWXDQOWBN invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly JPOXARHIIDM UXEDIFVFAQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly GetCircuitsColorFromColorIndexDelegate? DJKLVUMKTMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? PDHOCPSWROF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly InvisibleCollisionSetEnabledDelegate? MOFEXDYMLQS;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xDD8300", Offset = "0xDD6F00", VA = "0x180DD8300")]
		public JPOXARHIIDM([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFAB0", Offset = "0x2AFE6B0", VA = "0x182AFFAB0", Slot = "4")]
		public CircuitsColor VIOCXGPOXTY(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFA90", Offset = "0x2AFE690", VA = "0x182AFFA90")]
		public int CRASZQKUUNY([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFA90", Offset = "0x2AFE690", VA = "0x182AFFA90", Slot = "5")]
		private int JVVNLSVFBCP([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class UTVPTKUXZMZ : FLHDACVAKSS
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class NZLMQWIWDIK
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid IBMXQCAIFFA
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xF00A10", Offset = "0xEFF610", VA = "0x180F00A10")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long VGFOKZYUDMP
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int ZLNBWHWGZYZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0600", VA = "0x180CF1A00")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool FEKFEDBSSPW
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x1B12480", Offset = "0x1B11080", VA = "0x181B12480")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool OXLDXCBAJKA
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x1B12560", Offset = "0x1B11160", VA = "0x181B12560")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool DHXLCAGDNJD
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x2AFFD50", Offset = "0x2AFE950", VA = "0x182AFFD50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFD70", Offset = "0x2AFE970", VA = "0x182AFFD70")]
			public NZLMQWIWDIK(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<Id128<NYBQVHGBIMX>, NZLMQWIWDIK> LIBFOQLUADF;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2B04140", Offset = "0x2B02D40", VA = "0x182B04140")]
		public bool XJNKTBKEHPA([In] Id128<NYBQVHGBIMX> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B03F50", Offset = "0x2B02B50", VA = "0x182B03F50")]
		public void KGCDIKQTZSG([In] Id128<NYBQVHGBIMX> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2B04250", Offset = "0x2B02E50", VA = "0x182B04250")]
		public void KGCDIKQTZSG([In] Id128<NYBQVHGBIMX> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B04020", Offset = "0x2B02C20", VA = "0x182B04020")]
		public void IAZFEMNAEUX([In] Id128<NYBQVHGBIMX> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2B04330", Offset = "0x2B02F30", VA = "0x182B04330")]
		public void UVRQPGSMTEU([In] Id128<NYBQVHGBIMX> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2B03EC0", Offset = "0x2B02AC0", VA = "0x182B03EC0")]
		public bool FEKFEDBSSPW([In] Id128<NYBQVHGBIMX> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2B04390", Offset = "0x2B02F90", VA = "0x182B04390")]
		public UTVPTKUXZMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2B04140", Offset = "0x2B02D40", VA = "0x182B04140", Slot = "4")]
		private bool IHAPIXDHMPN([In] Id128<NYBQVHGBIMX> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2B03F50", Offset = "0x2B02B50", VA = "0x182B03F50", Slot = "5")]
		private void FTRDHMEXAPB([In] Id128<NYBQVHGBIMX> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2B04020", Offset = "0x2B02C20", VA = "0x182B04020", Slot = "6")]
		private void GCULIELVXNQ([In] Id128<NYBQVHGBIMX> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2B04330", Offset = "0x2B02F30", VA = "0x182B04330", Slot = "7")]
		private void ORWARDRJXVH([In] Id128<NYBQVHGBIMX> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2B03EC0", Offset = "0x2B02AC0", VA = "0x182B03EC0", Slot = "8")]
		private bool HHVCDLATMOD([In] Id128<NYBQVHGBIMX> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class PPJBYNQTAZI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFE50", Offset = "0x2AFEA50", VA = "0x182AFFE50")]
		public static LogDeps YRJRZDCDEOV()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class LQGTBWWAKPJ : MeshLibrary.ODRSNXNZSZX
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
		public byte[]? WXCLGTLKDUE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
		public void URFKIJIEJPN(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public LQGTBWWAKPJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class XDJGJQNFIWA : ZEQAUYTRFYT
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
		public delegate void ConfigureAttachedObjectDelegate(LSTCJXZSMZL controlPanel, NPOSFCMHTQF staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<SIQZVIOBMBM> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, LYQWSZGLQZW>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, LYQWSZGLQZW>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, LYQWSZGLQZW>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, LYQWSZGLQZW>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public Task<Result<MultiResult, LYQWSZGLQZW>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private TaskAwaiter<Result<MultiResult, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2B02AE0", Offset = "0x2B016E0", VA = "0x182B02AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2B02DA0", Offset = "0x2B019A0", VA = "0x182B02DA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2B02E10", Offset = "0x2B01A10", VA = "0x182B02E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2B030D0", Offset = "0x2B01CD0", VA = "0x182B030D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Task<Result<None, LYQWSZGLQZW>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private TaskAwaiter<Result<None, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2B03140", Offset = "0x2B01D40", VA = "0x182B03140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2B03400", Offset = "0x2B02000", VA = "0x182B03400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Dictionary<string, EnumChoiceData> LORJLIZFNMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Dictionary<int, string> PIJECHBQEMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly List<object> RVJYTTITYEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly List<Guid> DCUDDCOLSXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly CanLocalPlayerCreateCurrencyDelegate TYKEJBVAJKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ShowRoomCurrencyCreationUIDelegate OESHYLQNPVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipOptionsDelegate IIHWKNUGGZL;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<Guid, int> JCAKEVRHLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipGuidToIndexMapDelegate XTEMHIFQBLR;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<int, Guid> BJUGUCNPPJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAudioClipIndexToGuidMapDelegate YIHNNRQCIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipOptionsDelegate NOFKARKZIKQ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<Guid, int> XOLMTSQEZTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate HYIXABPNCPG;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly IReadOnlyDictionary<int, Guid> DHRNBTZDKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate YXFOYYPVCCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly PlayAudioPreviewDelegate QXHJWKJCKVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly StopAudioPreviewDelegate JQKGCBFAKVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly SubscriptionIsActiveDelegate XFUNOURAISS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate ZOTGGUHDNSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Dictionary<string, EnumChoiceData> YWQGUXPXEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly ShowQuickChatEditMenuDelegate XWPLZGRWUPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly ConfigureAttachedObjectDelegate NDSSHNKLKUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly DisplayInvalidNameErrorMessageDelegate TORLKLEUZMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly IsStringPureDelegate TZSDISPSNVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly TryGetSpecificChipConfigSummaryDelegate TUMOBFFNLVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReleaseIconIdDelegate IQHYWDIHNWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate EBTCLTZIAOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 EKYQLPWEDHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 ELDXIWQBMTB;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment NSAVZSOZFFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GNYHRLMWGTC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xD44270", Offset = "0xD42E70", VA = "0x180D44270", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> AKEZHUYUIQH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> UUPZUTNYJNY
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> LCJVOKFWKZD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> OFYXLTITWJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E00", Offset = "0xCF6A00", VA = "0x180CF7E00", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion NHPORMBOPTT
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xFF9430", Offset = "0xFF8030", VA = "0x180FF9430", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ACNDEOLNLNR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xEED340", Offset = "0xEEBF40", VA = "0x180EED340", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool TZFVTUUYJWA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B04DE0", Offset = "0x2B039E0", VA = "0x182B04DE0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool LNADHRVFIRT
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B04F70", Offset = "0x2B03B70", VA = "0x182B04F70", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool RELUEDJUNDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xCF3460", Offset = "0xCF2060", VA = "0x180CF3460", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B05290", Offset = "0x2B03E90", VA = "0x182B05290")]
		public XDJGJQNFIWA([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B05050", Offset = "0x2B03C50", VA = "0x182B05050", Slot = "9")]
		public bool ZUQSJLNFCHX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		public static bool IZFCXFPAZXS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B04FF0", Offset = "0x2B03BF0", VA = "0x182B04FF0", Slot = "10")]
		public bool YHHPASGYSVB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void IKIQYJPRUAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xF0A270", Offset = "0xF08E70", VA = "0x180F0A270", Slot = "11")]
		public void BNSYVHZXEJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B04DB0", Offset = "0x2B039B0", VA = "0x182B04DB0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> SMNDWNYVTJV(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B048E0", Offset = "0x2B034E0", VA = "0x182B048E0", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GRZADKSRIKC(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B04890", Offset = "0x2B03490", VA = "0x182B04890")]
		private static IReadOnlyDictionary<Guid, int> GNIDIHWSTRN(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B047B0", Offset = "0x2B033B0", VA = "0x182B047B0", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> ADJABJNHNBI(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B04BC0", Offset = "0x2B037C0", VA = "0x182B04BC0")]
		private static IReadOnlyDictionary<int, Guid> OCCBVRUBOSL(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B04B90", Offset = "0x2B03790", VA = "0x182B04B90", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> NFZMQXWYEHM(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B04F40", Offset = "0x2B03B40", VA = "0x182B04F40")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> VYPDYGJWFIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3720", Offset = "0x2AF2320", VA = "0x182AF3720", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> KSUZRSTTETP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C10", Offset = "0x2B03810", VA = "0x182B04C10")]
		private static IReadOnlyDictionary<Guid, int> OIQFTQFUFPS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B04CC0", Offset = "0x2B038C0", VA = "0x182B04CC0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> SERYGMMMLBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B04980", Offset = "0x2B03580", VA = "0x182B04980", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> JLPJGOAFCBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void VNSXNPNYPUR(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B047E0", Offset = "0x2B033E0", VA = "0x182B047E0", Slot = "18")]
		public void BYPQLVXWVEM(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void XPKVFQXCONZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B04820", Offset = "0x2B03420", VA = "0x182B04820", Slot = "19")]
		public void EJXINKOPUIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		private static bool UFJRJQRIGCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B05020", Offset = "0x2B03C20", VA = "0x182B05020", Slot = "20")]
		public bool ZNVMBUOUJQH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		public static bool SVFDDLVWOVJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B04950", Offset = "0x2B03550", VA = "0x182B04950", Slot = "21")]
		public bool JLCLALEGMYO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C90", Offset = "0x2B03890", VA = "0x182B04C90", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> RGZMBSVPOWT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> TXXYDOXHDLT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> MRILOJORYFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B04850", Offset = "0x2B03450", VA = "0x182B04850", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> FDCEVQJTSAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> DCHQBILFRSI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> NAWWINTCDKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void TBKKFYDWVOW(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B04910", Offset = "0x2B03510", VA = "0x182B04910", Slot = "29")]
		public void GZTDUFYYGKB(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void CJINQJJUGCE(LSTCJXZSMZL a, NPOSFCMHTQF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C60", Offset = "0x2B03860", VA = "0x182B04C60", Slot = "35")]
		public void PTRFPCMUSWT(LSTCJXZSMZL a, NPOSFCMHTQF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "36")]
		public Dictionary<string, EnumChoiceData> QIVCGNXRXXL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "37")]
		public Dictionary<string, EnumChoiceData> DQCQDBZXIFU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void HEXBAVJGJKA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B04EE0", Offset = "0x2B03AE0", VA = "0x182B04EE0")]
		private static Task<bool> VGFICYOKTPG(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B04FC0", Offset = "0x2B03BC0", VA = "0x182B04FC0", Slot = "38")]
		public Task<bool> YALYLEAJPBB(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B04880", Offset = "0x2B03480", VA = "0x182B04880")]
		private static bool FGWMOMCQAVA(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B04F80", Offset = "0x2B03B80", VA = "0x182B04F80", Slot = "39")]
		public bool XNCLYGXBWTT(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void IDGSIUXWSDI(Id32<SIQZVIOBMBM> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B04D80", Offset = "0x2B03980", VA = "0x182B04D80", Slot = "40")]
		public void SKRHZXZCNTD(Id32<SIQZVIOBMBM> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B04DF0", Offset = "0x2B039F0", VA = "0x182B04DF0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, LYQWSZGLQZW>> VDSTHRGURYY(Task<Result<None, LYQWSZGLQZW>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B04D50", Offset = "0x2B03950", VA = "0x182B04D50", Slot = "41")]
		public Task<Result<None, LYQWSZGLQZW>> SJJOBOBUQZB(Task<Result<None, LYQWSZGLQZW>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B049B0", Offset = "0x2B035B0", VA = "0x182B049B0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, LYQWSZGLQZW>> LLBYWSMFFPY(Task<Result<MultiResult, LYQWSZGLQZW>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B04D20", Offset = "0x2B03920", VA = "0x182B04D20", Slot = "42")]
		public Task<Result<MultiResult, LYQWSZGLQZW>> SJJOBOBUQZB(Task<Result<MultiResult, LYQWSZGLQZW>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B04AA0", Offset = "0x2B036A0", VA = "0x182B04AA0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> LLHFTZGCPBH(Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B04CF0", Offset = "0x2B038F0", VA = "0x182B04CF0", Slot = "43")]
		public Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> SJJOBOBUQZB(Task<Result<Id32<BNOAYSCHUMT>, LYQWSZGLQZW>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class WHHRJMKNBCX : ZQJJEWSIQXA
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(SDSGZEUUWRN e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? RFKBRIYAYCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly InteropDelegate PGWDNGIGJPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly InteropDelegate DXVAJVSHQGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private InteropDelegate? SGAHVRZPEZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private InvokeStudioFunctionDelegate? CARLBVTZVFP;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "5")]
		public LegacyCV2Result<None> NSEFPFFWHWB(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0")]
		private static LegacyCV2Result<None> Default(SDSGZEUUWRN _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "6")]
		public LegacyCV2Result<None> BQHMDGFIXKA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "7")]
		public LegacyCV2Result<None> XWCGQPTWDLP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "8")]
		public LegacyCV2Result<None> YFYFQRYCPWQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "9")]
		public LegacyCV2Result<None> CJKWYOKIERS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "15")]
		public LegacyCV2Result<None> PITUMTXYAVL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OIHLEMZSPJN(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YABWGTOBWWZ(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MHTECBSXTJU(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JEFUFKWPFRZ(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YCRNBLMLUAM(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZOQBDURSRPQ(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WMRRAEMVIMF(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "93")]
		public LegacyCV2Result<None> PZUOYRWJMQU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "94")]
		public LegacyCV2Result<None> SESUMBPBLSG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "95")]
		public LegacyCV2Result<None> OVQAECOZQXF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JDVWVVOWKUL(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(SDSGZEUUWRN e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TQFGTKZADUF(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PDVHCXRJGZL(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SFUSTJPBJHM(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RDXQLDJVMCX(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OEDQPCLZSBA(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RUJDYUQUGLO(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TBDIBLIIRVK(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SWBXXLXYWBP(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1515FD0", Offset = "0x1514BD0", VA = "0x181515FD0", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GMAHEBZGMTC(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UXGRPXTJHBV(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "119")]
		public LegacyCV2Result<None> APLCLVIUAXZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YCFRZHNOVRK(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "121")]
		public LegacyCV2Result<None> ZLCROKRMZSU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "122")]
		public LegacyCV2Result<None> AOOMLILIYJW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "123")]
		public LegacyCV2Result<None> ULGROBEXPEQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "124")]
		public LegacyCV2Result<None> ZQDMTABKEXG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "125")]
		public LegacyCV2Result<None> MLYZOHJUMQC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "126")]
		public LegacyCV2Result<None> SLIUEUHIAHF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "818")]
		public LegacyCV2Result<None> CGBBEXZXCMZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "819")]
		public LegacyCV2Result<None> LSGTYZSUJOR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "147")]
		public LegacyCV2Result<None> THWPUZGLTHJ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "148")]
		public LegacyCV2Result<None> PJYHNPYNAUP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "149")]
		public LegacyCV2Result<None> LIAOKDHWNBY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "150")]
		public LegacyCV2Result<None> IQKYBQROIFQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "151")]
		public LegacyCV2Result<None> UABUNWWDMCD(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(SDSGZEUUWRN e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(SDSGZEUUWRN e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(SDSGZEUUWRN e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, ZQJJEWSIQXA.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(SDSGZEUUWRN e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, ZQJJEWSIQXA.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "174")]
		public LegacyCV2Result<None> BSUQWQJEWYG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "175")]
		public LegacyCV2Result<None> AZEAHBGDVRB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "176")]
		public LegacyCV2Result<None> OVJVJTGJCUD(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "197")]
		public LegacyCV2Result<None> WNHCDRDCBUB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "198")]
		public LegacyCV2Result<None> YYUGTXCPDBC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "199")]
		public LegacyCV2Result<None> XTMFMNABHCX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "200")]
		public LegacyCV2Result<None> USIPBBLQQTZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "201")]
		public LegacyCV2Result<None> CUMZOATUNXP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "202")]
		public LegacyCV2Result<None> KIMNFFANEWQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "203")]
		public LegacyCV2Result<None> UQBNQJESGPA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "204")]
		public LegacyCV2Result<None> QBABKMJZJDA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "205")]
		public LegacyCV2Result<None> CXKHYBGVGWS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "206")]
		public LegacyCV2Result<None> JJCSRRJMNGS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "207")]
		public LegacyCV2Result<None> ESHOXNECJVA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "208")]
		public LegacyCV2Result<None> DDULCHWTNKC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "209")]
		public LegacyCV2Result<None> CQQYQOLRUDI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "210")]
		public LegacyCV2Result<None> KCIWDXVAQTX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "211")]
		public LegacyCV2Result<None> XHVSMRCDZFC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "212")]
		public LegacyCV2Result<None> UDSCQZAZUZH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "213")]
		public LegacyCV2Result<None> XHLAJTTVVAG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "214")]
		public LegacyCV2Result<None> FZNMAIJUBTR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "215")]
		public LegacyCV2Result<None> WNUKRMPABXQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "274")]
		public LegacyCV2Result<None> PRRQHCYUEJY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "277")]
		public LegacyCV2Result<None> UAHFKTNNCJW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "279")]
		public LegacyCV2Result<None> OAAKTQICVKR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "280")]
		public LegacyCV2Result<None> FOUMXOPHBDZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "281")]
		public LegacyCV2Result<None> RXRYVYFFGIA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "282")]
		public LegacyCV2Result<None> OLBUALZMARL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "283")]
		public LegacyCV2Result<None> KBBUFFXZBFK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "287")]
		public LegacyCV2Result<None> LWINZEBZXIN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "288")]
		public LegacyCV2Result<None> WDQTJCCYSWE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "317")]
		public LegacyCV2Result<None> DSTLQRDKNXT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "406")]
		public LegacyCV2Result<None> DKJXNWXKLWU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MZFJOLBNYOL(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FNETNDITGBF(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DUHCZHDRHMN(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WBHFSQTKSLA(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZRJGXAXDUFT(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "416")]
		public LegacyCV2Result<MUQFPCALGKV.CV2DiscoverySectionType> YNKKUBTXKUC(SDSGZEUUWRN e, CircuitSignal a)
		{
			return default(LegacyCV2Result<MUQFPCALGKV.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "417")]
		public LegacyCV2Result<None> ZXKVKIPDZWS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(SDSGZEUUWRN e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KPEXDRMMQNM(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WWUTWWFLAJL(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UTIHLSQJCVY(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "462")]
		public LegacyCV2Result<None> YMWZAZHSNTT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "463")]
		public LegacyCV2Result<None> OABGUHKQZCI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "464")]
		public LegacyCV2Result<None> UBZFTIXTMHJ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "465")]
		public LegacyCV2Result<None> MXMININWYPI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "466")]
		public LegacyCV2Result<None> YXPUYLLZCFW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "467")]
		public LegacyCV2Result<None> VBMXAOVDGRS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "468")]
		public LegacyCV2Result<None> RJEXJCVKVDV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "469")]
		public LegacyCV2Result<None> FWECKLMPXMB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "474")]
		public LegacyCV2Result<None> HCIZKGWEWPX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "475")]
		public LegacyCV2Result<None> SRBPDSMMQVJ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "476")]
		public LegacyCV2Result<None> CYGXVOJLYXK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "477")]
		public LegacyCV2Result<None> CSMYTZJONSR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "478")]
		public LegacyCV2Result<None> GNXWOTVZIAX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "479")]
		public LegacyCV2Result<None> IGNHCGRYKSY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(SDSGZEUUWRN executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(SDSGZEUUWRN executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "472")]
		public LegacyCV2Result<None> RWMDQQZDRCI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "473")]
		public LegacyCV2Result<None> ZMSENWRAXSE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "480")]
		public LegacyCV2Result<None> YYEWZNRKXSW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "481")]
		public LegacyCV2Result<None> ASNIDALNOPS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "482")]
		public LegacyCV2Result<None> UAFHCDXUHXL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "483")]
		public LegacyCV2Result<None> XDBRKNRPSOH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "484")]
		public LegacyCV2Result<None> EWWSLJLHJMP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "485")]
		public LegacyCV2Result<None> BOBUJYFCZMF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "486")]
		public LegacyCV2Result<None> FNKSFZGWKSX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "487")]
		public LegacyCV2Result<None> EEJBGKUJQOZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "488")]
		public LegacyCV2Result<None> NRHWGKOARPN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "489")]
		public LegacyCV2Result<None> FGZEMJMOLXV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "490")]
		public LegacyCV2Result<None> SFGSFFPHPQF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "491")]
		public LegacyCV2Result<None> QWCPDWCRIXZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "492")]
		public LegacyCV2Result<None> GTSGETSEFXL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "493")]
		public LegacyCV2Result<None> QSPLGWDZASX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "494")]
		public LegacyCV2Result<None> WSGYADCUMLZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "495")]
		public LegacyCV2Result<None> EBOZCRSRRQF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "496")]
		public LegacyCV2Result<None> MJTWULYSUTX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "497")]
		public LegacyCV2Result<None> QKBAYOJLWPL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "498")]
		public LegacyCV2Result<None> JMGMINHRJEN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "499")]
		public LegacyCV2Result<None> HVHKSYNRYCH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B04530", Offset = "0x2B03130", VA = "0x182B04530", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "507")]
		public LegacyCV2Result<None> VLLJLDKQIRV(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "508")]
		public LegacyCV2Result<None> ZDHKHHTWILL(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "509")]
		public LegacyCV2Result<None> LECKIWUUMUN(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "510")]
		public LegacyCV2Result<None> IUNNCIYDRGE(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(SDSGZEUUWRN e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(SDSGZEUUWRN e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(SDSGZEUUWRN e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.QYOPFSVHNHD> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "522")]
		public LegacyCV2Result<None> VDSFNESUWWU(SDSGZEUUWRN e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "525")]
		public LegacyCV2Result<None> IXHTWCQLMXG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "527")]
		public LegacyCV2Result<None> NGHFCORKRKB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "528")]
		public LegacyCV2Result<None> OHZDIDAYYUT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "530")]
		public LegacyCV2Result<None> JAJNJIVTYOL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "531")]
		public LegacyCV2Result<None> NURZXIFLJGW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2B04460", Offset = "0x2B03060", VA = "0x182B04460", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "533")]
		public LegacyCV2Result<None> WZWWBFNQURS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2B044F0", Offset = "0x2B030F0", VA = "0x182B044F0", Slot = "535")]
		public LegacyCV2Result<None> NWRENMHTQDU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "534")]
		public LegacyCV2Result<None> AMEANUWUEBN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "536")]
		public LegacyCV2Result<None> UBYTNQOLSDT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "537")]
		public LegacyCV2Result<None> NXJICVFTBCG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "538")]
		public LegacyCV2Result<None> EKHEWVTJJKU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "539")]
		public LegacyCV2Result<None> DPAJWASVWSM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "540")]
		public LegacyCV2Result<None> UUWWAKTUOFE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "583")]
		public LegacyCV2Result<None> Raycast(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "584")]
		public LegacyCV2Result<None> LEOTRAPGDBZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "587")]
		public LegacyCV2Result<None> FRVOPVVNDPE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "591")]
		public LegacyCV2Result<None> ITMYKKYYZMF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "592")]
		public LegacyCV2Result<None> EIBCDNIDZRA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "641")]
		public LegacyCV2Result<None> XEWYWPINAWT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "642")]
		public LegacyCV2Result<None> COQOKWNJDDR(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "643")]
		public LegacyCV2Result<None> OGZRKGUZHMG(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "644")]
		public LegacyCV2Result<None> BTWPYNFAAIF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "645")]
		public LegacyCV2Result<None> SJNUARVTFMF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "646")]
		public LegacyCV2Result<None> OZJARBXHGNE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "649")]
		public LegacyCV2Result<None> PMMFYJRIOZX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "650")]
		public LegacyCV2Result<None> KVPYPALTIDX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "651")]
		public LegacyCV2Result<None> WTCMUHUBYJI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "661")]
		public LegacyCV2Result<None> GKLYIGOWSJP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "660")]
		public LegacyCV2Result<None> XUZCLFTRGSU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "662")]
		public LegacyCV2Result<None> PGPCJUTIREH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "663")]
		public LegacyCV2Result<None> EZCGNNIUUQS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "670")]
		public LegacyCV2Result<None> YJQBQXQRKKV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "671")]
		public LegacyCV2Result<None> VXXKFCTPGUY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "674")]
		public LegacyCV2Result<None> ZVCKTCXNLNI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "675")]
		public LegacyCV2Result<None> XINCGPNHCHX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(SDSGZEUUWRN e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "696")]
		public LegacyCV2Result<None> UKCSCTASUNN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "697")]
		public LegacyCV2Result<None> SAFSAQDEAYB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "698")]
		public LegacyCV2Result<None> NKFURETFOHB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "699")]
		public LegacyCV2Result<None> LCTREQIOKNO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "700")]
		public LegacyCV2Result<None> FXAINOPNWXI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "676")]
		public LegacyCV2Result<None> GSJISQMDJBT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "677")]
		public LegacyCV2Result<None> NTVEYGAWBIH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "678")]
		public LegacyCV2Result<None> FUHNRTNEBFU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "679")]
		public LegacyCV2Result<None> DJNQCNKVNCL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "680")]
		public LegacyCV2Result<None> SHWUPZYACZK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "681")]
		public LegacyCV2Result<None> ZXJKCJLXJVX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "682")]
		public LegacyCV2Result<None> QWCCFHDQABB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "683")]
		public LegacyCV2Result<None> TRESAGSIYIO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "684")]
		public LegacyCV2Result<None> KZPEMTBOQWI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "685")]
		public LegacyCV2Result<None> PVICJNLNGED(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "686")]
		public LegacyCV2Result<None> FLREJOZVULV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "687")]
		public LegacyCV2Result<None> CVFDKJAXWLQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "688")]
		public LegacyCV2Result<None> TDWCSYIOXDP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "689")]
		public LegacyCV2Result<None> PATZHFSARCB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "690")]
		public LegacyCV2Result<None> RDWYBDJXTDI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "691")]
		public LegacyCV2Result<None> OBASFEVGXJC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "692")]
		public LegacyCV2Result<None> RDSCZWBWUSK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "693")]
		public LegacyCV2Result<None> LAEHXQXNYHL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "765")]
		public LegacyCV2Result<None> ULSNLDJPUIL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "711")]
		public LegacyCV2Result<None> JMVINKPGVTG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "712")]
		public LegacyCV2Result<None> QLAAWAXFTMA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "713")]
		public LegacyCV2Result<None> CCRLCORPTPI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "714")]
		public LegacyCV2Result<None> RSXYWBKVVXS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "717")]
		public LegacyCV2Result<None> WJGCELHXUAK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "721")]
		public LegacyCV2Result<None> MLYFXYEUPBJ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "722")]
		public LegacyCV2Result<None> FSUIEXGTPAR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "723")]
		public LegacyCV2Result<None> SPOUAYXALAM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "724")]
		public LegacyCV2Result<None> QWGCUEBGEBC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "725")]
		public LegacyCV2Result<None> RLCJFCIPVEM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "726")]
		public LegacyCV2Result<None> GZAWKACQFDR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "727")]
		public LegacyCV2Result<None> IBAOMMRSMHQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "728")]
		public LegacyCV2Result<None> AVEERZKSSMN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "729")]
		public LegacyCV2Result<None> HDJNANJHRTZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "730")]
		public LegacyCV2Result<None> POUAWIAXGAB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "731")]
		public LegacyCV2Result<None> COWLTYFJHBL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "732")]
		public LegacyCV2Result<None> WYQOLPMVWPN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "733")]
		public LegacyCV2Result<None> CCNBKELJKIH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "734")]
		public LegacyCV2Result<None> AOQSPIYCHUG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "735")]
		public LegacyCV2Result<None> KRSWVPPIKNR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "736")]
		public LegacyCV2Result<None> ICIESHKWSLX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "737")]
		public LegacyCV2Result<None> ABMLCLPPJDK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "738")]
		public LegacyCV2Result<None> TBCVBVKISLJ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "740")]
		public LegacyCV2Result<None> HRJNWMBBSYB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "739")]
		public LegacyCV2Result<None> HZBGBPMLTWV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "741")]
		public LegacyCV2Result<None> ECKHBGDAZAY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "742")]
		public LegacyCV2Result<None> QLCAQANWCED(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "743")]
		public LegacyCV2Result<None> LVLTIETOEGA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "744")]
		public LegacyCV2Result<None> DSDITANMJOO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "745")]
		public LegacyCV2Result<None> RMJZXRMMDTP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "746")]
		public LegacyCV2Result<None> OSPFHFKJYUU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "747")]
		public LegacyCV2Result<None> HOQIVESEIAM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "748")]
		public LegacyCV2Result<None> QGYYQHBWNHF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "749")]
		public LegacyCV2Result<None> OTCOEFRGWDP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "750")]
		public LegacyCV2Result<None> DLKCASROXAN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "751")]
		public LegacyCV2Result<None> RVEBJVACPMX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "752")]
		public LegacyCV2Result<None> KIRMKWDILOH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "753")]
		public LegacyCV2Result<None> GYNJHNEXDRR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "754")]
		public LegacyCV2Result<None> AKJNFWBINEH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "755")]
		public LegacyCV2Result<None> PIJNOPMAHZY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "756")]
		public LegacyCV2Result<None> ZKUIERIJDPW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "757")]
		public LegacyCV2Result<None> FBFOYFSBJGI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "758")]
		public LegacyCV2Result<None> PQHQVHJPDQA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "759")]
		public LegacyCV2Result<None> RYFIIDTZFWT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "760")]
		public LegacyCV2Result<None> ZSNKLQELWFL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "761")]
		public LegacyCV2Result<None> OMIGZFVLFOX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "762")]
		public LegacyCV2Result<None> LSMQNGVXAXW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "763")]
		public LegacyCV2Result<None> GTFYISIDYIS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "764")]
		public LegacyCV2Result<None> KIXZTMWQPMT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "771")]
		public LegacyCV2Result<None> UWFZERFVADH(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "772")]
		public LegacyCV2Result<None> VBCBEKRMVNV(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "773")]
		public LegacyCV2Result<None> FTTPJOFUYGQ(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(SDSGZEUUWRN ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "775")]
		public LegacyCV2Result<None> DGIRUKHIMJU(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "776")]
		public LegacyCV2Result<None> FWBUNHKOLXA(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "777")]
		public LegacyCV2Result<None> OVAGOYOIDYR(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "778")]
		public LegacyCV2Result<None> FYFLTAPYVUX(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "779")]
		public LegacyCV2Result<None> YKKCKAOYXWH(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "707")]
		public LegacyCV2Result<None> MMPFYRVZXSB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "801")]
		public LegacyCV2Result<None> YQNYDNCHZLR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "802")]
		public LegacyCV2Result<None> UYZHYPULPCH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "803")]
		public LegacyCV2Result<None> LXYWCBEBYMB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "804")]
		public LegacyCV2Result<None> VVBVKGTDNTH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "805")]
		public LegacyCV2Result<None> PYRWJJHKETF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "806")]
		public LegacyCV2Result<None> SPKORLQNQVN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "807")]
		public LegacyCV2Result<None> SFXONBAHQDT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "808")]
		public LegacyCV2Result<None> ENLHHGIFGKV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "809")]
		public LegacyCV2Result<None> THUXPRLTIIL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "810")]
		public LegacyCV2Result<None> GZFTQCNQJUJ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "811")]
		public LegacyCV2Result<None> RPXEDFQSKWF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "812")]
		public LegacyCV2Result<None> LVHMSLEDAGC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "817")]
		public LegacyCV2Result<None> QNUUQRWAPUN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "821")]
		public LegacyCV2Result<None> HKJITBKSQHY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "822")]
		public LegacyCV2Result<None> RCTFKLOXGUC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "823")]
		public LegacyCV2Result<None> PELORHSYUOU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "824")]
		public LegacyCV2Result<None> OPQCEPPWOCA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "826")]
		public LegacyCV2Result<None> TFBNVDDTMCQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "827")]
		public LegacyCV2Result<None> YDFANIIBTIL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "828")]
		public LegacyCV2Result<None> JRFHHHKKEUN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "831")]
		public LegacyCV2Result<None> WJTGSKZJCED(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "832")]
		public LegacyCV2Result<None> EJWIPAUOZTW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "833")]
		public LegacyCV2Result<None> KQHYEQXHYNZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(SDSGZEUUWRN e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(SDSGZEUUWRN e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "836")]
		public LegacyCV2Result<None> ERXCEQHUFAG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YQHUVEFMYQU(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NGCVGMVHHIO(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WLZDOETPDQJ(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VJMFYUSDWJQ(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JRBJVJRRIYT(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(SDSGZEUUWRN e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(SDSGZEUUWRN e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(SDSGZEUUWRN e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(SDSGZEUUWRN e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(SDSGZEUUWRN e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(SDSGZEUUWRN e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(SDSGZEUUWRN e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "856")]
		public LegacyCV2Result<None> UQFNVGEGSGK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "859")]
		public LegacyCV2Result<None> MREZJOMNPSS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "860")]
		public LegacyCV2Result<None> ULFBRVCEFME(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "861")]
		public LegacyCV2Result<None> FYZVGLYYAPG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "862")]
		public LegacyCV2Result<None> ZWHGSFTSXBX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "864")]
		public LegacyCV2Result<None> YBFMIACVHWC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "865")]
		public LegacyCV2Result<None> DTTBKMZRYYU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(SDSGZEUUWRN e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "869")]
		public LegacyCV2Result<None> XWTOGTTVBHK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "879")]
		public LegacyCV2Result<None> FKUFNTLZMTI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "880")]
		public LegacyCV2Result<None> WHUSRFWWTNK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "881")]
		public LegacyCV2Result<None> TUVHYLCFLQF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "882")]
		public LegacyCV2Result<None> HZQFYYEOEYU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(SDSGZEUUWRN e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(SDSGZEUUWRN e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(SDSGZEUUWRN e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(SDSGZEUUWRN e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(SDSGZEUUWRN e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "889")]
		public LegacyCV2Result<None> GNIYWLHMXSM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "890")]
		public LegacyCV2Result<None> GJQZMDEWNEL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "891")]
		public LegacyCV2Result<None> IAKCRSLAZPQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "892")]
		public LegacyCV2Result<None> RPMOTNLIECK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "893")]
		public LegacyCV2Result<None> YAABRVZUILK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "897")]
		public LegacyCV2Result<None> GMXRSKKRUBP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "898")]
		public LegacyCV2Result<None> UMHNBGDYMTX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "899")]
		public LegacyCV2Result<None> BAWIEFIFVQA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "901")]
		public LegacyCV2Result<None> HBVVBDKGSIY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "900")]
		public LegacyCV2Result<None> SVTNYQTBUVC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "902")]
		public LegacyCV2Result<None> AUQMHUSFSNH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "904")]
		public LegacyCV2Result<None> CMYIUIJFWAN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "903")]
		public LegacyCV2Result<None> KXUOASZHHBR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "905")]
		public LegacyCV2Result<None> HHBEOOSVPAM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "906")]
		public LegacyCV2Result<None> VCAQUEHOGXG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "907")]
		public LegacyCV2Result<None> VSKAKNJVPER(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "908")]
		public LegacyCV2Result<None> EOOMXDCQRJZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "909")]
		public LegacyCV2Result<None> FBJETRYFODZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "910")]
		public LegacyCV2Result<None> SGXQSAEYCQL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "911")]
		public LegacyCV2Result<None> DGRXYVOSYZV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "918")]
		public LegacyCV2Result<None> GTRIZWYLEER(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "919")]
		public LegacyCV2Result<None> QVTEIFEUMUZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(SDSGZEUUWRN e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(SDSGZEUUWRN e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(SDSGZEUUWRN e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(SDSGZEUUWRN e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(SDSGZEUUWRN e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(SDSGZEUUWRN e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(SDSGZEUUWRN e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(SDSGZEUUWRN e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(SDSGZEUUWRN e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "941")]
		public LegacyCV2Result<None> PKXMUYCVGYT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "942")]
		public LegacyCV2Result<None> CIBKRIYZNEP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "943")]
		public LegacyCV2Result<None> FMUZLMOFBFK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "944")]
		public LegacyCV2Result<None> CIVCHMYSEYS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "945")]
		public LegacyCV2Result<None> JRQZIXRCXSF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "946")]
		public LegacyCV2Result<None> GIYZBIWHJCH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "947")]
		public LegacyCV2Result<None> GSAKFUIUMEO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "948")]
		public LegacyCV2Result<None> CSOHLNQUHIO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "949")]
		public LegacyCV2Result<None> IRSSSJBHOQO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "950")]
		public LegacyCV2Result<None> BBGZUUFYTPD(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "968")]
		public LegacyCV2Result<None> HFDXZJZSTNH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "967")]
		public LegacyCV2Result<None> ODNEUDWGHGC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "969")]
		public LegacyCV2Result<None> RAOYNRLFEIQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "970")]
		public LegacyCV2Result<None> KTWDRNJNYKF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "971")]
		public LegacyCV2Result<None> EHDWNOVQZHM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "972")]
		public LegacyCV2Result<None> JZXCHCYIAZO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "973")]
		public LegacyCV2Result<None> PUHQUJMHBYF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "975")]
		public LegacyCV2Result<None> BYWITFNNJXE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "982")]
		public LegacyCV2Result<None> XRDUCYDIREB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "983")]
		public LegacyCV2Result<None> CTBSQZSZWBF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "991")]
		public LegacyCV2Result<None> HYYPTOSERUC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "993")]
		public LegacyCV2Result<None> NHHDMIKBOFU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "994")]
		public LegacyCV2Result<None> GJIIWOFBOWS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "995")]
		public LegacyCV2Result<None> VLICYDVSTCQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "996")]
		public LegacyCV2Result<None> OZWVILODNHW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "997")]
		public LegacyCV2Result<None> GKBSDVKQPKG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "998")]
		public LegacyCV2Result<None> GRMZUKELBTA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "999")]
		public LegacyCV2Result<None> RNFBTIWLSLO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1000")]
		public LegacyCV2Result<None> BGVEANHUNJC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1001")]
		public LegacyCV2Result<None> EMCULGYMTRC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1002")]
		public LegacyCV2Result<None> IIHLHJCVYXW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1009")]
		public LegacyCV2Result<None> YGWSIHJANEK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1017")]
		public LegacyCV2Result<None> WXHGOAELXWN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1018")]
		public LegacyCV2Result<None> EYSFKOCRHCI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1019")]
		public LegacyCV2Result<None> UJXPPHTAVFL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1020")]
		public LegacyCV2Result<None> UULPAGXUJDK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1021")]
		public LegacyCV2Result<None> BAOBAGLAPNH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1022")]
		public LegacyCV2Result<None> KEITHWWRZKO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1023")]
		public LegacyCV2Result<None> YOXEKIJOYAH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1024")]
		public LegacyCV2Result<None> TOVXNUXCFJN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1025")]
		public LegacyCV2Result<None> YCKWWBHZEJE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1026")]
		public LegacyCV2Result<None> SOUUPJAAAWF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1027")]
		public LegacyCV2Result<None> VJDOIWSFSKV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1028")]
		public LegacyCV2Result<None> QQRSHEOGHVQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1029")]
		public LegacyCV2Result<None> IGXBCUYIIAG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1030")]
		public LegacyCV2Result<None> UQYROHBZISJ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1031")]
		public LegacyCV2Result<None> PFWPKCATDPA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1032")]
		public LegacyCV2Result<None> DQITASAVBAV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1033")]
		public LegacyCV2Result<None> MRYELKSLIRX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1047")]
		public LegacyCV2Result<None> LYSPFDKPJYP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1048")]
		public LegacyCV2Result<None> CDHAPRYXKLB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1049")]
		public LegacyCV2Result<None> DQRGSFUBVNN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1050")]
		public LegacyCV2Result<None> FABMLCRKYSL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1051")]
		public LegacyCV2Result<None> TPAXNSZNXGE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1052")]
		public LegacyCV2Result<None> HMQUQUZCYKE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1053")]
		public LegacyCV2Result<None> KACNIBAVMLZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1054")]
		public LegacyCV2Result<None> UKDMPKNEWJM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1055")]
		public LegacyCV2Result<None> ALLUUJTIJWZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1056")]
		public LegacyCV2Result<None> NHQAZTUXSQG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1057")]
		public LegacyCV2Result<None> KTUDUETZWSO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1058")]
		public LegacyCV2Result<None> CANPJQIOPLB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1059")]
		public LegacyCV2Result<None> VAEBRYOKDRM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1060")]
		public LegacyCV2Result<None> VGMRRXBIVLK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1061")]
		public LegacyCV2Result<None> MMLXYGIACDS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1062")]
		public LegacyCV2Result<None> XBZTHVDINUE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1063")]
		public LegacyCV2Result<None> QMIDUUVAQKQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1064")]
		public LegacyCV2Result<None> TSLGXACERAB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1065")]
		public LegacyCV2Result<None> YHOQBQDMAPT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1066")]
		public LegacyCV2Result<None> XLXTZWZKUTI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1067")]
		public LegacyCV2Result<None> GXJAWZEPXDI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1068")]
		public LegacyCV2Result<None> AISYWICTIIE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1069")]
		public LegacyCV2Result<None> LVPZIDXZTTG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1070")]
		public LegacyCV2Result<None> LOPIIXKSZKV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1071")]
		public LegacyCV2Result<None> GFVBXCRBGHL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B044A0", Offset = "0x2B030A0", VA = "0x182B044A0", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(SDSGZEUUWRN e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(SDSGZEUUWRN e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1092")]
		public LegacyCV2Result<None> ZQOUVPSMNSQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1093")]
		public LegacyCV2Result<None> ILVYPISUNJB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1094")]
		public LegacyCV2Result<None> QIOLWZZYERZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1095")]
		public LegacyCV2Result<None> DXZFODQQLHB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1096")]
		public LegacyCV2Result<None> WIDMOLNZLBR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1097")]
		public LegacyCV2Result<None> MUNNEJKXXUJ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1098")]
		public LegacyCV2Result<None> XIQGYDITUYZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1099")]
		public LegacyCV2Result<None> CRIRMSLLIZP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1100")]
		public LegacyCV2Result<None> DEDUIQQNRCN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1101")]
		public LegacyCV2Result<None> SUQCIVUSDPH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1102")]
		public LegacyCV2Result<None> IOFJEQFYQMN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1103")]
		public LegacyCV2Result<None> WNYWLKPMVHI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1104")]
		public LegacyCV2Result<None> OCCIHFXRTFY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1105")]
		public LegacyCV2Result<None> FLEFGVZEVNU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1106")]
		public LegacyCV2Result<None> IIMPKEJFXVY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1107")]
		public LegacyCV2Result<None> FEOJPCLSFVX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1108")]
		public LegacyCV2Result<None> WENFRKCZEXD(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1109")]
		public LegacyCV2Result<None> NAZZYVXZUDG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1110")]
		public LegacyCV2Result<None> LOCDZJYLUHC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1111")]
		public LegacyCV2Result<None> CPCBPQAGMFW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1112")]
		public LegacyCV2Result<None> ZGYORYBDJXK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1113")]
		public LegacyCV2Result<None> HXCIJLUEBRH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1114")]
		public LegacyCV2Result<None> NIKJMNVKXJL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1115")]
		public LegacyCV2Result<None> ORKTRAWUIAQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1116")]
		public LegacyCV2Result<None> PZUIPWAKJMI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1117")]
		public LegacyCV2Result<None> PXHXQZJUDKQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1118")]
		public LegacyCV2Result<None> PQYYRDWGBMY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1119")]
		public LegacyCV2Result<None> UOMDILIFVGN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1120")]
		public LegacyCV2Result<None> JRCEZZNTORY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1121")]
		public LegacyCV2Result<None> CGJDSPFGBVQ(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1122")]
		public LegacyCV2Result<None> WBSIAUCHUEK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1123")]
		public LegacyCV2Result<None> RTKCSLJGERD(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1124")]
		public LegacyCV2Result<None> AXDNBGWQHPP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1125")]
		public LegacyCV2Result<None> GHMITIPHZZL(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1126")]
		public LegacyCV2Result<None> TBGGWUVZHIR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1127")]
		public LegacyCV2Result<None> FQVJVNERDLX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1128")]
		public LegacyCV2Result<None> GSRIBLNQHPL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1129")]
		public LegacyCV2Result<None> JAXUNCMPOHJ(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1130")]
		public LegacyCV2Result<None> QXXMEJRMOQA(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1131")]
		public LegacyCV2Result<None> LASOOTHEINT(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1132")]
		public LegacyCV2Result<None> LMSADNPTLII(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1133")]
		public LegacyCV2Result<None> CQCNOZRZOYB(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1134")]
		public LegacyCV2Result<None> NBZUKXMFAHP(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1135")]
		public LegacyCV2Result<None> EVIHWUNLTCO(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1136")]
		public LegacyCV2Result<None> DNUPNAQJAMG(JTWCQRGBJCE e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1140")]
		public LegacyCV2Result<None> HXHVFKDUZCK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1166")]
		public LegacyCV2Result<None> FVLXDIXFJOY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1168")]
		public LegacyCV2Result<None> IFWYRZKNXCW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1169")]
		public LegacyCV2Result<None> GHJSXKVBVUV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1170")]
		public LegacyCV2Result<None> DCKISQURKHK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1171")]
		public LegacyCV2Result<None> ZJADFFLROMZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1182")]
		public LegacyCV2Result<None> PUSXFFOKWDD(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1183")]
		public LegacyCV2Result<None> OYROLQTEWCX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1184")]
		public LegacyCV2Result<None> VCHKAROMTZV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1185")]
		public LegacyCV2Result<None> FKBJYHMZQMV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1186")]
		public LegacyCV2Result<None> ENNJTMWVDVU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1187")]
		public LegacyCV2Result<None> TFSVXYYPXNM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1188")]
		public LegacyCV2Result<None> YBMOBKZQKWI(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1189")]
		public LegacyCV2Result<None> DRBHIJQOGFS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1190")]
		public LegacyCV2Result<None> ETEEGSCNYSL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1191")]
		public LegacyCV2Result<None> BDCAZESHBQX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1192")]
		public LegacyCV2Result<None> NCLFJDOMYKA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1193")]
		public LegacyCV2Result<None> TFWYVQPPSNL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "184")]
		public LegacyCV2Result<None> GNZWVOFCJDL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B044E0", Offset = "0x2B030E0", VA = "0x182B044E0", Slot = "191")]
		public bool JPXLXXSVTML(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1194")]
		public LegacyCV2Result<None> UESKGLCIADL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1195")]
		public LegacyCV2Result<None> FTSPVANCRJK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1196")]
		public LegacyCV2Result<None> VAYUPNPWQLR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(SDSGZEUUWRN e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1205")]
		public LegacyCV2Result<None> ODQLYEKRCTO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1206")]
		public LegacyCV2Result<None> SJRICZLOABW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(SDSGZEUUWRN e, InOut io, ODGEZIQXQME objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "250")]
		public LegacyCV2Result<None> NGEKFJXSCDD(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "251")]
		public LegacyCV2Result<None> UJSBHYIZJSP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "252")]
		public LegacyCV2Result<None> YETTIRIZCRB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "254")]
		public LegacyCV2Result<None> LNVKZLUZVJK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "255")]
		public LegacyCV2Result<None> UBDNPOMFULW(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "256")]
		public LegacyCV2Result<None> FOAOBKHMFWY(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "257")]
		public LegacyCV2Result<None> VEMEUSCBFUX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "258")]
		public LegacyCV2Result<None> JWEFCQSAFMD(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "259")]
		public LegacyCV2Result<None> UDZVNMAUNCM(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "260")]
		public LegacyCV2Result<None> OQYDUZSVSHK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "261")]
		public LegacyCV2Result<None> KHYBMWKWMZQ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "262")]
		public LegacyCV2Result<None> FBDNJIVZZFA(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "263")]
		public LegacyCV2Result<None> JZLTWOSOVOR(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "264")]
		public LegacyCV2Result<None> EQTBIKRQCJT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "265")]
		public LegacyCV2Result<None> KAQWPKWWZZZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "266")]
		public LegacyCV2Result<None> AMRKGEVDRKD(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "267")]
		public LegacyCV2Result<None> YRTIBLYDXET(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "268")]
		public LegacyCV2Result<None> JLLDPDOFVGZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "269")]
		public LegacyCV2Result<None> GWOWCFYTSYV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0")]
		private static LegacyCV2Result<None> Default(SDSGZEUUWRN e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B04570", Offset = "0x2B03170", VA = "0x182B04570", Slot = "1209")]
		public LegacyCV2Result<None> XRYGVLPWFXQ(SDSGZEUUWRN a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1212")]
		public LegacyCV2Result<None> DVOAJXJBEDL(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1213")]
		public LegacyCV2Result<None> AYOZRCDXORN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1214")]
		public LegacyCV2Result<None> SEIZYBKXINV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1215")]
		public LegacyCV2Result<None> TSYBZXWPZXS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(SDSGZEUUWRN e, InOut io, HOFPBSYFQRK quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1036")]
		public LegacyCV2Result<None> LHKZZYSSYXX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1037")]
		public LegacyCV2Result<None> ILAXLXYUQZP(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1038")]
		public LegacyCV2Result<None> JNSYIENJBXN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1039")]
		public LegacyCV2Result<None> NHPEJBOZNBN(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1040")]
		public LegacyCV2Result<None> CKIWQJHBOVT(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1041")]
		public LegacyCV2Result<None> GHBSDZWHRSZ(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1042")]
		public LegacyCV2Result<None> PWDMYFKDZTH(SDSGZEUUWRN a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1043")]
		public LegacyCV2Result<None> CPEWFHXWJFF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1044")]
		public LegacyCV2Result<None> RFWWNSERMJF(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1045")]
		public LegacyCV2Result<None> YSUPSFIXJPU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1046")]
		public LegacyCV2Result<None> NIIIXDEBRCC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ECEIMEXCLXA(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1234")]
		public LegacyCV2Result<None> MHBBIQWLKWB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1236")]
		public LegacyCV2Result<None> KNAEBQOJDKU(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1229")]
		public LegacyCV2Result<None> PBXVFFPSYGG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1241")]
		public LegacyCV2Result<None> ZABYDVQNMOC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1242")]
		public LegacyCV2Result<None> WIANQPKEDSV(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1243")]
		public LegacyCV2Result<None> ANHLVOFAKWB(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1244")]
		public LegacyCV2Result<None> PZKEUWKLJYH(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1245")]
		public LegacyCV2Result<None> RORLCQSYXTO(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FMDGZIKDEWS(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CEGHHMOECMK(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GRLFXKYROJG(SDSGZEUUWRN a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1259")]
		public LegacyCV2Result<None> EDDNRRPNEBK(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1260")]
		public LegacyCV2Result<None> MRBUOJOVGUC(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1261")]
		public LegacyCV2Result<None> NKJGZGDNYYG(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1262")]
		public LegacyCV2Result<None> WGFXVVMNCYS(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B04600", Offset = "0x2B03200", VA = "0x182B04600")]
		public WHHRJMKNBCX([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(SDSGZEUUWRN e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1280")]
		public LegacyCV2Result<None> VJCEICCFCDX(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1281")]
		public LegacyCV2Result<None> PSKZVJQAOII(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "599")]
		public LegacyCV2Result<None> WHPMSBNXKBE(SDSGZEUUWRN e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1293")]
		public LegacyCV2Result<None> DEPLKSEEUZT(JTWCQRGBJCE e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1294")]
		public LegacyCV2Result<None> TPNWAYVGMMM(JTWCQRGBJCE e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1295")]
		public LegacyCV2Result<None> DWPXXQQMCAZ(JTWCQRGBJCE e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1296")]
		public LegacyCV2Result<None> PVVRBEOMAOH(JTWCQRGBJCE e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1297")]
		public LegacyCV2Result<None> RXNLOEHBCHY(JTWCQRGBJCE e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0")]
		public LegacyCV2Result<None> ConstantStorefrontItem(SDSGZEUUWRN e, InOut io, [In] XWBOZKXJVPT storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(SDSGZEUUWRN e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> GOKXKAIEEXE(SDSGZEUUWRN a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, ZQJJEWSIQXA.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> RMEEEQICTOU(SDSGZEUUWRN a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, ZQJJEWSIQXA.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1207")]
		private LegacyCV2Result<None> PBTXSESKIJJ(SDSGZEUUWRN a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1216")]
		private LegacyCV2Result<None> ECEULUOHDRS(SDSGZEUUWRN a, InOut b, [In] XWBOZKXJVPT storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0", Slot = "1257")]
		private LegacyCV2Result<None> UFVJLYTRDYQ(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class VTLGPYNJUCW : ZCUTXEYWEKT
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(VUXIBZNXCYQ node);

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly VTLGPYNJUCW IYCZABTNUWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate RYSHCSLRPPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate OVCXIZXRCWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private bool DGFPGBEEIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private bool YWEGSTDNSCB;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C450", Offset = "0x2B0B050", VA = "0x182B0C450", Slot = "4")]
		public Task<bool> DVKQZRKDIPK(VUXIBZNXCYQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2B13AD0", Offset = "0x2B126D0", VA = "0x182B13AD0", Slot = "5")]
		public Task<bool> JFWGIGPYCBB(VUXIBZNXCYQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2B13B80", Offset = "0x2B12780", VA = "0x182B13B80")]
		public VTLGPYNJUCW([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2B13AB0", Offset = "0x2B126B0", VA = "0x182B13AB0", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? IRCUGNFJYQY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF3830", VA = "0x180CF4C30", Slot = "7")]
		public bool QPVJFFVNMQZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x15F5E10", Offset = "0x15F4A10", VA = "0x1815F5E10", Slot = "8")]
		public bool OFUAADCTMQV()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class BIEECUAHUVQ : ZWCWMJAIFMB
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid HTBXPXDQNZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xF00A10", Offset = "0xEFF610", VA = "0x180F00A10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
		public void Bind(ETODIYAQDFP pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x10FB2E0", Offset = "0x10F9EE0", VA = "0x1810FB2E0")]
		public BIEECUAHUVQ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B540", Offset = "0x2B0A140", VA = "0x182B0B540")]
		public static BIEECUAHUVQ New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class PJRJUEMKJSA : EMQYARIYMUS
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<VJPEKKVEEYH> nodeDefId, Id128<GNQADATMYDH>? legacyInnerGraphId, IReadOnlyDictionary<Id128<GNQADATMYDH>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IsNodeRestrictedDelegate? PIJDQZAMRMP;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool ACNDEOLNLNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xD44270", Offset = "0xD42E70", VA = "0x180D44270", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool QFDLFEJDSHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F860", Offset = "0x2B0E460", VA = "0x182B0F860", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool GFIXRMIUNTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x1127A70", Offset = "0x1126670", VA = "0x181127A70", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "6")]
		public bool BTOHKYBAKRD(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "7")]
		public CanSaveObjectIntoInventionResultType ICSVYOTOWQC(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F810", Offset = "0x2B0E410", VA = "0x182B0F810", Slot = "8")]
		public bool JKSGKJUTWXP(Id128<VJPEKKVEEYH> nodeDefId, Id128<GNQADATMYDH>? legacyInnerGraphId, IReadOnlyDictionary<Id128<GNQADATMYDH>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "9")]
		public bool HRFEXVAVKIG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "10")]
		public bool BUDDMCXMYTC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F870", Offset = "0x2B0E470", VA = "0x182B0F870")]
		public PJRJUEMKJSA(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class VUJEDGXGOJU : AOKLQWLZMFZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly VUJEDGXGOJU IYCZABTNUWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly ShouldLogEventSenderToMakerPenDelegate JYXABFBODQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate GOKZUFACMNO;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool WNXPHRIEPCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x12B9250", Offset = "0x12B7E50", VA = "0x1812B9250", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FBMXIIFZTXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2B13D90", Offset = "0x2B12990", VA = "0x182B13D90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2B13E30", Offset = "0x2B12A30", VA = "0x182B13E30")]
		public VUJEDGXGOJU([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class AEQJBQSJZPC : UBEBOZCAVGU<KONMMJWHXTO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class FEJQMRMECID : KONMMJWHXTO, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly FEJQMRMECID UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool SQVJFZTNKTD
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B6E0", Offset = "0x2B0A2E0", VA = "0x182B0B6E0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			public void MVUJCEMZVBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public FEJQMRMECID()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly AEQJBQSJZPC UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private AEQJBQSJZPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B480", Offset = "0x2B0A080", VA = "0x182B0B480", Slot = "4")]
		public KONMMJWHXTO ZIWBNELVIQR()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class BFJWOIONIEO<a, b> : IDisposable, UNRLRPNONNX where a : notnull where b : notnull, OYYEQHXCMCE.VDFOEWNMPJQ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly b XBSGLFJHVQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly a YPZTFWZJQOJ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<GEJEFIAWMNS> EJOGSUGHHAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF270", VA = "0x180D00670", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GEJEFIAWMNS>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x4F59E20", Offset = "0x4F58A20", VA = "0x184F59E20")]
		public BFJWOIONIEO(b a, a b, Id32<GEJEFIAWMNS> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x4F57C10", Offset = "0x4F56810", VA = "0x184F57C10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x4F58310", Offset = "0x4F56F10", VA = "0x184F58310")]
		public Id32<STFYXSIYFLB> GEQNJWISKJQ([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<STFYXSIYFLB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x4F59A10", Offset = "0x4F58610", VA = "0x184F59A10", Slot = "6")]
		public void ZEQRFDNRLPX(Id32<STFYXSIYFLB> objectId, MTKDKHURMYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x4F59C50", Offset = "0x4F58850", VA = "0x184F59C50", Slot = "7")]
		public void ZFZWLDOPQGP(Id32<STFYXSIYFLB> objectId, MTKDKHURMYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x4F58C10", Offset = "0x4F57810", VA = "0x184F58C10", Slot = "8")]
		public void KEPPLIHRJMU(Id32<STFYXSIYFLB> objectId, MTKDKHURMYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x4F58FC0", Offset = "0x4F57BC0", VA = "0x184F58FC0", Slot = "10")]
		public void NTOWZLRZUKH(Id32<STFYXSIYFLB> objectId, Id32<GEJEFIAWMNS> clientId, MTKDKHURMYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x4F59460", Offset = "0x4F58060", VA = "0x184F59460", Slot = "9")]
		public void PBJQSLJLTQN(Id32<STFYXSIYFLB> objectId, MTKDKHURMYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x4F57E50", Offset = "0x4F56A50", VA = "0x184F57E50", Slot = "11")]
		public void FSSFSABZRBT(Id32<STFYXSIYFLB> objectId, HGPEHRMTQUY? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x4F59710", Offset = "0x4F58310", VA = "0x184F59710", Slot = "12")]
		public Id32<GEJEFIAWMNS> PHCPYTQYJHA(Id32<STFYXSIYFLB> objectId)
		{
			return default(Id32<GEJEFIAWMNS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x4F58F60", Offset = "0x4F57B60", VA = "0x184F58F60", Slot = "13")]
		public Id32<CAFZYIVHGER> MLQFQYZZDIC(Id32<STFYXSIYFLB> objectId, string a, object b, bool c, CQDACIRUNTR d, THSXRYGYBAZ e)
		{
			return default(Id32<CAFZYIVHGER>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x4F58800", Offset = "0x4F57400", VA = "0x184F58800", Slot = "14")]
		public void IPCQDHRUQVE(Id32<CAFZYIVHGER> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x4F58370", Offset = "0x4F56F70", VA = "0x184F58370", Slot = "15")]
		public void GQBBXFBEJXW(Id32<CAFZYIVHGER> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class OYYEQHXCMCE
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface VDFOEWNMPJQ<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void IPQXQYGUIMO(a a, Id32<GEJEFIAWMNS> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<GEJEFIAWMNS>? JIKJGGBHWUR(a a);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<STFYXSIYFLB> GEQNJWISKJQ(a a, Id32<GEJEFIAWMNS> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void ZEQRFDNRLPX(a a, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ZFZWLDOPQGP(a a, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void NTOWZLRZUKH(a a, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS b);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void PBJQSLJLTQN(a a, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS b);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void FSSFSABZRBT(a a, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, HGPEHRMTQUY? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<GEJEFIAWMNS>? PHCPYTQYJHA(a a, Id32<STFYXSIYFLB> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<CAFZYIVHGER> MLQFQYZZDIC(a a, Id32<GEJEFIAWMNS> clientId, string b, object c, CQDACIRUNTR d, THSXRYGYBAZ e);

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void IPCQDHRUQVE(a a, Id32<GEJEFIAWMNS> clientId, Id32<CAFZYIVHGER> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void GQBBXFBEJXW(a a, Id32<GEJEFIAWMNS> clientId, Id32<CAFZYIVHGER> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class KYFWJXJNBWG
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly HashSet<Id32<STFYXSIYFLB>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAId32Field<CAFZYIVHGER, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public readonly Dictionary<Id32<CAFZYIVHGER>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<CAFZYIVHGER>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public SOAField<STFYXSIYFLB, HGPEHRMTQUY?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EE00", Offset = "0x2B0DA00", VA = "0x182B0EE00")]
			private MockCV2DynamicNetSys(HashSet<Id32<STFYXSIYFLB>> authorityOf, [In] SOAId32Field<CAFZYIVHGER, MockCV2SyncField> syncFields, Dictionary<Id32<CAFZYIVHGER>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<CAFZYIVHGER>> mockSyncFieldToSyncField, [In] SOAField<STFYXSIYFLB, HGPEHRMTQUY?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EC40", Offset = "0x2B0D840", VA = "0x182B0EC40")]
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
			public Id32<GEJEFIAWMNS>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EEA0", Offset = "0x2B0DAA0", VA = "0x182B0EEA0")]
			public MockCV2ObjectShared(Id32<GEJEFIAWMNS> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public THSXRYGYBAZ SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public CQDACIRUNTR SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			internal MockCV2SyncField(THSXRYGYBAZ syncField, CQDACIRUNTR syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EFC0", Offset = "0x2B0DBC0", VA = "0x182B0EFC0")]
			public static MockCV2SyncField New(THSXRYGYBAZ syncField, CQDACIRUNTR syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x2B0EF70", Offset = "0x2B0DB70", VA = "0x182B0EF70")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EF20", Offset = "0x2B0DB20", VA = "0x182B0EF20")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<STFYXSIYFLB, MockCV2ObjectShared> YYDJZGSMSYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<STFYXSIYFLB>> PSWCZMREHVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> SVQOEHSGNMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> LBPHPVYTJTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private SOAField<GEJEFIAWMNS, MockCV2DynamicNetSys> GLWXVXMZOWD;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<STFYXSIYFLB>? ACKLGCQAEEX
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xDD4470", Offset = "0xDD3070", VA = "0x180DD4470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x127C8C0", Offset = "0x127B4C0", VA = "0x18127C8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C8C0", Offset = "0x2B0B4C0", VA = "0x182B0C8C0")]
		public void Destroy([In] SOAId32<GEJEFIAWMNS> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DE20", Offset = "0x2B0CA20", VA = "0x182B0DE20")]
		public void QSVONCQXWVU(Id32<GEJEFIAWMNS> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D5B0", Offset = "0x2B0C1B0", VA = "0x182B0D5B0")]
		public void IPQXQYGUIMO(Id32<GEJEFIAWMNS> clientId, Id32<GEJEFIAWMNS>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CCA0", Offset = "0x2B0B8A0", VA = "0x182B0CCA0")]
		public Id32<STFYXSIYFLB> GEQNJWISKJQ(Id32<GEJEFIAWMNS> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<GEJEFIAWMNS> clientIds)
		{
			return default(Id32<STFYXSIYFLB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D8F0", Offset = "0x2B0C4F0", VA = "0x182B0D8F0")]
		public Id32<CAFZYIVHGER> MLQFQYZZDIC(Id32<GEJEFIAWMNS> clientId, string a, object b, CQDACIRUNTR c, THSXRYGYBAZ d)
		{
			return default(Id32<CAFZYIVHGER>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D420", Offset = "0x2B0C020", VA = "0x182B0D420")]
		public void IPCQDHRUQVE(Id32<GEJEFIAWMNS> clientId, Id32<CAFZYIVHGER> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CB00", Offset = "0x2B0B700", VA = "0x182B0CB00")]
		public Id32<STFYXSIYFLB>? FLTFJJYKLET([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E280", Offset = "0x2B0CE80", VA = "0x182B0E280")]
		public void ZEQRFDNRLPX([In] SOAId32<GEJEFIAWMNS> clientIds, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E300", Offset = "0x2B0CF00", VA = "0x182B0E300")]
		public void ZFZWLDOPQGP(Id32<STFYXSIYFLB> objectId, MTKDKHURMYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DB50", Offset = "0x2B0C750", VA = "0x182B0DB50")]
		public void NTOWZLRZUKH(Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DC50", Offset = "0x2B0C850", VA = "0x182B0DC50")]
		public void PBJQSLJLTQN([In] SOAId32<GEJEFIAWMNS> clientIds, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CBD0", Offset = "0x2B0B7D0", VA = "0x182B0CBD0")]
		public void FSSFSABZRBT(Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, HGPEHRMTQUY? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DDD0", Offset = "0x2B0C9D0", VA = "0x182B0DDD0")]
		public Id32<GEJEFIAWMNS>? PHCPYTQYJHA(Id32<STFYXSIYFLB> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D0B0", Offset = "0x2B0BCB0", VA = "0x182B0D0B0")]
		public void GQBBXFBEJXW([In] SOAId32<GEJEFIAWMNS> clientIds, Id32<GEJEFIAWMNS> clientId, Id32<CAFZYIVHGER> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E440", Offset = "0x2B0D040", VA = "0x182B0E440")]
		public KYFWJXJNBWG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class BNJCYMBHWSN
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B5A0", Offset = "0x2B0A1A0", VA = "0x182B0B5A0")]
		public static void Destroy(this KYFWJXJNBWG.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class YPTEDMYRUJH : UUHXPVSFXIV.ODRSNXNZSZX
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static YPTEDMYRUJH YSFTPQRIWVA;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate WANXMCZFHRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate SYMMAHVPOCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1560", VA = "0x180CF2960")]
		public YPTEDMYRUJH(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class HPHIQELCELX : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : BROQOKBSSNY.UPRLNBORNML<FXFJUDAMIWO, HPHIQELCELX>
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
				public AsyncTaskMethodBuilder<Result<object, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public HPHIQELCELX root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public Id32<GEJEFIAWMNS> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public FXFJUDAMIWO action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				private TaskAwaiter<Result<object, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B12C00", Offset = "0x2B11800", VA = "0x182B12C00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B12E40", Offset = "0x2B11A40", VA = "0x182B12E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			public int ISUHCPXXNJR(HPHIQELCELX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F8F0", Offset = "0x2B0E4F0", VA = "0x182B0F8F0", Slot = "5")]
			public int LJLTCJSCRUV(HPHIQELCELX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F930", Offset = "0x2B0E530", VA = "0x182B0F930", Slot = "6")]
			public int OPMHHXPBDXY(HPHIQELCELX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F910", Offset = "0x2B0E510", VA = "0x182B0F910", Slot = "7")]
			public int MKIJDGTQQXU(HPHIQELCELX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FAA0", Offset = "0x2B0E6A0", VA = "0x182B0FAA0", Slot = "8")]
			public void XXFVRELNXMN(HPHIQELCELX a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "9")]
			public bool PXYHTECPKJE(HPHIQELCELX a, Id32<GEJEFIAWMNS> actorId, FXFJUDAMIWO[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "10")]
			public bool KZQFYOPIDAU(HPHIQELCELX a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F950", Offset = "0x2B0E550", VA = "0x182B0F950", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, LYQWSZGLQZW>> VLZIGITBNZG(HPHIQELCELX a, Id32<GEJEFIAWMNS> senderId, FXFJUDAMIWO b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : BROQOKBSSNY.VCVAKIZRWMY<ActionDeps, XXEAPKVABFJ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps BXKHZXHDMFC
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public XXEAPKVABFJ.StaticNetSysReceiverDeps EBLJZQQZUXJ
			{
				[Cpp2IlInjected.Token(Token = "0x60007AD")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "5")]
				get
				{
					return default(XXEAPKVABFJ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps KHZDEXQAAHY
			{
				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : YKANUKGRNBO.VDFOEWNMPJQ<HPHIQELCELX>
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
				public AsyncTaskMethodBuilder<Result<object?, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public HPHIQELCELX root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public Id32<GEJEFIAWMNS> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public FXFJUDAMIWO action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				private TaskAwaiter<Result<object?, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B128E0", Offset = "0x2B114E0", VA = "0x182B128E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B12B90", Offset = "0x2B11790", VA = "0x182B12B90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F000", Offset = "0x2B0DC00", VA = "0x182B0F000", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, LYQWSZGLQZW>> VLZIGITBNZG(HPHIQELCELX a, Id32<GEJEFIAWMNS> clientId, FXFJUDAMIWO b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : OYYEQHXCMCE.VDFOEWNMPJQ<HPHIQELCELX>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E8F0", Offset = "0x2B0D4F0", VA = "0x182B0E8F0", Slot = "4")]
			public void IPQXQYGUIMO(HPHIQELCELX a, Id32<GEJEFIAWMNS> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xF5C440", Offset = "0xF5B040", VA = "0x180F5C440", Slot = "5")]
			public Id32<GEJEFIAWMNS>? JIKJGGBHWUR(HPHIQELCELX a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E5E0", Offset = "0x2B0D1E0", VA = "0x182B0E5E0")]
			public Id32<STFYXSIYFLB> GEQNJWISKJQ(HPHIQELCELX a, Id32<GEJEFIAWMNS> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<STFYXSIYFLB>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EA50", Offset = "0x2B0D650", VA = "0x182B0EA50", Slot = "7")]
			public void ZEQRFDNRLPX(HPHIQELCELX a, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EAE0", Offset = "0x2B0D6E0", VA = "0x182B0EAE0", Slot = "8")]
			public void ZFZWLDOPQGP(HPHIQELCELX a, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E980", Offset = "0x2B0D580", VA = "0x182B0E980", Slot = "9")]
			public void NTOWZLRZUKH(HPHIQELCELX a, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E9C0", Offset = "0x2B0D5C0", VA = "0x182B0E9C0", Slot = "10")]
			public void PBJQSLJLTQN(HPHIQELCELX a, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, MTKDKHURMYS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E640", Offset = "0x2B0D240", VA = "0x182B0E640", Slot = "11")]
			public void FSSFSABZRBT(HPHIQELCELX a, Id32<GEJEFIAWMNS> clientId, Id32<STFYXSIYFLB> objectId, HGPEHRMTQUY? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E9F0", Offset = "0x2B0D5F0", VA = "0x182B0E9F0", Slot = "12")]
			public Id32<GEJEFIAWMNS>? PHCPYTQYJHA(HPHIQELCELX a, Id32<STFYXSIYFLB> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E920", Offset = "0x2B0D520", VA = "0x182B0E920", Slot = "13")]
			public Id32<CAFZYIVHGER> MLQFQYZZDIC(HPHIQELCELX a, Id32<GEJEFIAWMNS> clientId, string b, object c, CQDACIRUNTR d, THSXRYGYBAZ e)
			{
				return default(Id32<CAFZYIVHGER>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E750", Offset = "0x2B0D350", VA = "0x182B0E750", Slot = "14")]
			public void IPCQDHRUQVE(HPHIQELCELX a, Id32<GEJEFIAWMNS> clientId, Id32<CAFZYIVHGER> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E720", Offset = "0x2B0D320", VA = "0x182B0E720", Slot = "15")]
			public void GQBBXFBEJXW(HPHIQELCELX a, Id32<GEJEFIAWMNS> clientId, Id32<CAFZYIVHGER> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E5E0", Offset = "0x2B0D1E0", VA = "0x182B0E5E0", Slot = "6")]
			private Id32<STFYXSIYFLB> FKHUSHYITIG(HPHIQELCELX a, Id32<GEJEFIAWMNS> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<STFYXSIYFLB>);
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
			public HPHIQELCELX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public Id32<STFYXSIYFLB>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public HAHYOVHKCDQ deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private Id32<GEJEFIAWMNS> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private HUACHFUJUGG<HPHIQELCELX, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private BFJWOIONIEO<HPHIQELCELX, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private XXEAPKVABFJ <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B12220", Offset = "0x2B10E20", VA = "0x182B12220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B12870", Offset = "0x2B11470", VA = "0x182B12870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly FURETQEYXQO<FXFJUDAMIWO, None, XXEAPKVABFJ, ActionDeps, XXEAPKVABFJ.StaticNetSysReceiverDeps, RootDeps, HPHIQELCELX, Deps> VPIGNUJPOZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly KYFWJXJNBWG WMUAQPWBKPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAId32<GEJEFIAWMNS> UIGWHNMVRYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private SOAField<GEJEFIAWMNS, None> GLWXVXMZOWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private SOAField<GEJEFIAWMNS, XXEAPKVABFJ> NEHFWYWKUSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Id32<GEJEFIAWMNS>? HKQAYWEXOYM;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate AKWZQFBQCCK
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED320", VA = "0x180CEE720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BF70", Offset = "0x2B0AB70", VA = "0x182B0BF70")]
		public HPHIQELCELX(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B990", Offset = "0x2B0A590", VA = "0x182B0B990", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BDF0", Offset = "0x2B0A9F0", VA = "0x182B0BDF0")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> QSVONCQXWVU(HAHYOVHKCDQ a, RegistryV2 b, Id32<STFYXSIYFLB>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BB60", Offset = "0x2B0A760", VA = "0x182B0BB60")]
		private void IPQXQYGUIMO(Id32<GEJEFIAWMNS> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B8B0", Offset = "0x2B0A4B0", VA = "0x182B0B8B0")]
		[CompilerGenerated]
		private Id32<STFYXSIYFLB>? APMNXVTNREG([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class SAGIQGWKVGM : HLQSLBGKSFS.ODRSNXNZSZX
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<QNOYLKOFSQJ> DeserializeCircuitsJunctionAsyncDelegate(XXEAPKVABFJ circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<QNOYLKOFSQJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public SAGIQGWKVGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public XXEAPKVABFJ circuitsManager;

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
			private TaskAwaiter<QNOYLKOFSQJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B10F10", Offset = "0x2B0FB10", VA = "0x182B10F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B11110", Offset = "0x2B0FD10", VA = "0x182B11110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate IBMSKLNMRNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly LifecycleDidInitializeDelegate? HTLWECUDLNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly LifecycleWillDestroyDelegate? ELRZCIRUPNG;

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FAF0", Offset = "0x2B0E6F0", VA = "0x182B0FAF0", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<QNOYLKOFSQJ> BPDYRAPHVHC(XXEAPKVABFJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
		public void QEZKTPHXOFK(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x1002290", Offset = "0x1000E90", VA = "0x181002290", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x109E150", Offset = "0x109CD50", VA = "0x18109E150", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FC60", Offset = "0x2B0E860", VA = "0x182B0FC60")]
		public SAGIQGWKVGM([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class SEJTXDJBQSG : GFREUFWJHCW.ODRSNXNZSZX
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate LEWVSLHMGCM GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<PQNICHBJXRG> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<WTDQFLYTVGY> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<GFREUFWJHCW.ODRSNXNZSZX.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<GFREUFWJHCW.ODRSNXNZSZX.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public SEJTXDJBQSG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter<GFREUFWJHCW.ODRSNXNZSZX.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B11180", Offset = "0x2B0FD80", VA = "0x182B11180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B11370", Offset = "0x2B0FF70", VA = "0x182B11370", Slot = "5")]
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
			public AsyncTaskMethodBuilder<WTDQFLYTVGY> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public SEJTXDJBQSG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			private TaskAwaiter<WTDQFLYTVGY> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B113E0", Offset = "0x2B0FFE0", VA = "0x182B113E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B115D0", Offset = "0x2B101D0", VA = "0x182B115D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<PQNICHBJXRG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public SEJTXDJBQSG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private TaskAwaiter<PQNICHBJXRG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B11640", Offset = "0x2B10240", VA = "0x182B11640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B11830", Offset = "0x2B10430", VA = "0x182B11830", Slot = "5")]
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
			public SEJTXDJBQSG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B118A0", Offset = "0x2B104A0", VA = "0x182B118A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B11A90", Offset = "0x2B10690", VA = "0x182B11A90", Slot = "5")]
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
			public SEJTXDJBQSG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B11B00", Offset = "0x2B10700", VA = "0x182B11B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B11CF0", Offset = "0x2B108F0", VA = "0x182B11CF0", Slot = "5")]
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
			public SEJTXDJBQSG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B11D60", Offset = "0x2B10960", VA = "0x182B11D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B11F50", Offset = "0x2B10B50", VA = "0x182B11F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetCV2DependenciesDelegate XTNTSZVVELQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomDataAsyncDelegate CYZSZPYZVSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetSuperRoomDataAsyncDelegate DOTVODCYWHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetRoomAssetDataAsyncDelegate XRQFVAODRTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetPlayerSaveDataAsyncDelegate ZLYKISFCEHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate QIURNVKIARL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly GetStaticCircuitsConfigAsyncDelegate PDKMXEXOUGK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public LEWVSLHMGCM LEWVSLHMGCM
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x12B9250", Offset = "0x12B7E50", VA = "0x1812B9250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FE50", Offset = "0x2B0EA50", VA = "0x182B0FE50", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> AWSZELEBEWN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B10180", Offset = "0x2B0ED80", VA = "0x182B10180", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> RVVDASCJTUY(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FF60", Offset = "0x2B0EB60", VA = "0x182B0FF60", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<PQNICHBJXRG> JKBYATXEJPB(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B103A0", Offset = "0x2B0EFA0", VA = "0x182B103A0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<WTDQFLYTVGY> ZMTBCCUJIAI(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B10070", Offset = "0x2B0EC70", VA = "0x182B10070", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<GFREUFWJHCW.ODRSNXNZSZX.CircuitGraphToolMapping> OQRSRFVBEYF(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B10290", Offset = "0x2B0EE90", VA = "0x182B10290", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> XINEUXSLEMI(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B104B0", Offset = "0x2B0F0B0", VA = "0x182B104B0")]
		public SEJTXDJBQSG(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class IADCZNVCVRE : CV2Request.ODRSNXNZSZX
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly CV2Request.ODRSNXNZSZX UXEDIFVFAQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly GetCanSendRequestsDelegate XYOFLTZRVFA;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public IADCZNVCVRE(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x12B9250", Offset = "0x12B7E50", VA = "0x1812B9250", Slot = "4")]
		public bool KDVBHSTBDAG()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class ICFAXKPWWQB : SZNXFZCEGDW
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, SCULPNIXVDU> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly TryReportErrToUserDelegate SXZBXMHHJKO;

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C450", Offset = "0x2B0B050", VA = "0x182B0C450")]
		public bool QFZTOAODTXC([In] Result<None, SCULPNIXVDU> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C480", Offset = "0x2B0B080", VA = "0x182B0C480")]
		public ICFAXKPWWQB([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C450", Offset = "0x2B0B050", VA = "0x182B0C450", Slot = "4")]
		private bool JVECGASRKNJ([In] Result<None, SCULPNIXVDU> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class GMQOMEQGLMU : CNGANKRQXIV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate SDSGZEUUWRN CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly GMQOMEQGLMU UXEDIFVFAQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CurrentExecParamsDelegate? KBSBUCBSBOS;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public SDSGZEUUWRN YQTEFQFJPLY
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x12B9250", Offset = "0x12B7E50", VA = "0x1812B9250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public GMQOMEQGLMU([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class NEZONPPVMXI : WNSVIDJHVWR
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly WNSVIDJHVWR UXEDIFVFAQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly GetGameColorFromIdDelegate UGWZTHNXTVE;

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C450", Offset = "0x2B0B050", VA = "0x182B0C450", Slot = "4")]
		public CircuitsColor VIMIFHQSXTK(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F350", Offset = "0x2B0DF50", VA = "0x182B0F350")]
		public NEZONPPVMXI([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class XTNOTVTFLFI : LGZSDACFKQJ
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
			public XTNOTVTFLFI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x2B11FC0", Offset = "0x2B10BC0", VA = "0x182B11FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x2B121B0", Offset = "0x2B10DB0", VA = "0x182B121B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly IsStringPureAsyncDelegate QNPBMRZKFHD;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x2B14130", Offset = "0x2B12D30", VA = "0x182B14130", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> JJTJBIWFBKB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2B14270", Offset = "0x2B12E70", VA = "0x182B14270")]
		public XTNOTVTFLFI([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class SFIZDLDBKDW : CBQIBVXTUYH
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate UKIHQPXWSHB? GetNodeVisualizationConfigDelegate([In] Id128<VJPEKKVEEYH> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly CBQIBVXTUYH UXEDIFVFAQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly GetNodeVisualizationConfigDelegate SOZEAXOXCLO;

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C450", Offset = "0x2B0B050", VA = "0x182B0C450")]
		public UKIHQPXWSHB? ZCYLECTEUFY([In] Id128<VJPEKKVEEYH> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2B10D50", Offset = "0x2B0F950", VA = "0x182B10D50")]
		public SFIZDLDBKDW([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C450", Offset = "0x2B0B050", VA = "0x182B0C450", Slot = "4")]
		private UKIHQPXWSHB QMLEAHTMPUS([In] Id128<VJPEKKVEEYH> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class JQKLRSBRBYX : CCEZIAZAKCW
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C870", Offset = "0x2B0B470", VA = "0x182B0C870", Slot = "4")]
		public NNUVDKBLROH QPHYVBXREPR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public JQKLRSBRBYX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class OWUMLBHWJAN : GYLDOFPAMRI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, bool> ESMWZPEQBHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, float> GKOJGXGOEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, double> AJUYCPEMMUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, int> YSIFESEOBNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, long> CSMJGGBKNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, string> TZRALXWMFFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly Dictionary<string, uint> THNHTBCEWZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly Dictionary<string, ulong> CJXCAFDEPFN;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F500", Offset = "0x2B0E100", VA = "0x182B0F500", Slot = "4")]
		public bool? XKUIOVSBEAA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F5A0", Offset = "0x2B0E1A0", VA = "0x182B0F5A0")]
		public OWUMLBHWJAN()
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
