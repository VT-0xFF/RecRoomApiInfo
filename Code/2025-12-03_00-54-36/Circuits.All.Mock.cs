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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x282E400", Offset = "0x282D000", VA = "0x18282E400")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
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
		internal sealed class PHXXXCCBESR : QZPMTXTKYSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public PHXXXCCBESR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960", Slot = "4")]
			public QZPMTXTKYSM NKEFSTNPVVU(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960", Slot = "5")]
			public QZPMTXTKYSM CHEOCWYYVIF(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960", Slot = "6")]
			public QZPMTXTKYSM JKHZJXVGNUN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
			public void ZXGWLXXUFYA()
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
	public static class MFTWONGQHSA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FWKMQDTJZYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public JEXXETQFPCN GYKWCGXDIHA;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FWKMQDTJZYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2828120", Offset = "0x2826D20", VA = "0x182828120")]
			internal ZFOPNMGJHIN NGRTBRSORWN(GetNetworkObjectDelegate a)
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
			public JDXRPHKCJUL dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public VDJIRLLJMFS network;

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
			[Cpp2IlInjected.Address(RVA = "0x2830C20", Offset = "0x282F820", VA = "0x182830C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x28312C0", Offset = "0x282FEC0", VA = "0x1828312C0", Slot = "5")]
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
			public VDJIRLLJMFS network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public JDXRPHKCJUL dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<KJUTVDVUHQM>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private TGMYLJQNIMW <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2831330", Offset = "0x282FF30", VA = "0x182831330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x28318C0", Offset = "0x28304C0", VA = "0x1828318C0", Slot = "5")]
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
			public JEXXETQFPCN roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2831930", Offset = "0x2830530", VA = "0x182831930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2831E40", Offset = "0x2830A40", VA = "0x182831E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x282D8E0", Offset = "0x282C4E0", VA = "0x18282D8E0")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? AZECTZQDWGP([Optional] JEXXETQFPCN? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x282DCB0", Offset = "0x282C8B0", VA = "0x18282DCB0")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> ROPTVNGUEEY(VDJIRLLJMFS a, [Optional] JDXRPHKCJUL? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x282DB20", Offset = "0x282C720", VA = "0x18282DB20")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> ROPTVNGUEEY(VDJIRLLJMFS a, JDXRPHKCJUL b, RegistryV2 c, Id32<KJUTVDVUHQM>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x282D9D0", Offset = "0x282C5D0", VA = "0x18282D9D0")]
		public static (RuntimeFnRegistry, RuntimeFns) BVOVVBYBPGK()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x282D7E0", Offset = "0x282C3E0", VA = "0x18282D7E0")]
		public static (ExternalFnRegistry, ExternalFns) AWSCZWHYPZR()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x282DAA0", Offset = "0x282C6A0", VA = "0x18282DAA0")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static VDJIRLLJMFS HWWIBFQTHGM(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class TSERWBHNOGU
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate ZFOPNMGJHIN CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public TSERWBHNOGU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2830830", Offset = "0x282F430", VA = "0x182830830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2830BB0", Offset = "0x282F7B0", VA = "0x182830BB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly VDJIRLLJMFS ODPFFCMJJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? KYXFKRIFZTA;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		private TSERWBHNOGU(VDJIRLLJMFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2830590", Offset = "0x282F190", VA = "0x182830590")]
		public static TSERWBHNOGU QMWBYPAHZIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2830640", Offset = "0x282F240", VA = "0x182830640")]
		public TSERWBHNOGU UVLALXWKECV(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2830660", Offset = "0x282F260", VA = "0x182830660")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> ZXGWLXXUFYA()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class XEMBNRVOUXA : TGMYLJQNIMW.HGULJDEHQOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate ATLYGSIJOIW NewCircuitsLifecycleDelegate(QISMRYAGOIJ.HGULJDEHQOI deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(TGMYLJQNIMW circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(TGMYLJQNIMW circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate IMLISTWGPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate ETRUMWFUZMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate AQNLYKEYPSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate RILWXXKZJKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate GQVRDJOPMYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate HBHYOZOVDET;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int RYQKKMGWBQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xFB7AB0", Offset = "0xFB66B0", VA = "0x180FB7AB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2833DF0", Offset = "0x28329F0", VA = "0x182833DF0", Slot = "6")]
		public void JWAMUXPYWPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2833E50", Offset = "0x2832A50", VA = "0x182833E50", Slot = "7")]
		public void VRJRNMCIHYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2833E20", Offset = "0x2832A20", VA = "0x182833E20", Slot = "5")]
		public ATLYGSIJOIW TVUXHCRSURX(QISMRYAGOIJ.HGULJDEHQOI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xBF8920", Offset = "0xBF7520", VA = "0x180BF8920", Slot = "8")]
		public void XRCPGLZQYOS(TGMYLJQNIMW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBF89E0", Offset = "0xBF75E0", VA = "0x180BF89E0", Slot = "9")]
		public void ALQOVZLZFFN(TGMYLJQNIMW a, NOYQGYRQTEZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2833E80", Offset = "0x2832A80", VA = "0x182833E80")]
		public XEMBNRVOUXA([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly NSRRADRIHLT<VDJIRLLJMFS, VDJIRLLJMFS.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly TDIMPNVDIIZ<VDJIRLLJMFS, VDJIRLLJMFS.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly TGMYLJQNIMW CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<VXOAABITZCX> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly VDJIRLLJMFS Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2827FA0", Offset = "0x2826BA0", VA = "0x182827FA0")]
		public EVCreationResult(NSRRADRIHLT<VDJIRLLJMFS, VDJIRLLJMFS.MockStaticNetSysDeps> staticNetSys, TDIMPNVDIIZ<VDJIRLLJMFS, VDJIRLLJMFS.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, TGMYLJQNIMW circuitsManager, Id32<VXOAABITZCX> clientId, VDJIRLLJMFS network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly TGMYLJQNIMW _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 CLUQVAIBLXW
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x282D650", Offset = "0x282C250", VA = "0x18282D650")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request LQNDUKZYDYM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x282D620", Offset = "0x282C220", VA = "0x18282D620")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public DRQILQQWMSV? OKBGWWRWXZC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x282D6E0", Offset = "0x282C2E0", VA = "0x18282D6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public NSJEOKCMOGP? MARCKXLTDJM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x282D680", Offset = "0x282C280", VA = "0x18282D680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		internal LimitedCircuits(TGMYLJQNIMW circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class VPQNUAYWDQQ : JDXRPHKCJUL
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KRFKZYGPKGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ZFOPNMGJHIN RXTEVKDIEZX;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KRFKZYGPKGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			internal ZFOPNMGJHIN TFFXFTIEYTB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public QISMRYAGOIJ.HGULJDEHQOI FINJNFHICEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public TGMYLJQNIMW.HGULJDEHQOI WMLHCEGCVEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MIRQTXIQXPT.HGULJDEHQOI TJJRKGTRHCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HZPHESKVUJP.LGUBDHHAHFH<ActionKind, NOYQGYRQTEZ, TGMYLJQNIMW> PWWCDLGIRDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.HGULJDEHQOI IILCEEDAFAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RAIVYTHKDKV GCNQATBARQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA98620", Offset = "0xA97220", VA = "0x180A98620", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public VUZSBPVGYXW BXKIIDKZGCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9F800", VA = "0x180AA0C00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public XPEEEJIOVCS AQHJEILAIJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DZRACNYRZDY GHDIPFDMTUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5C0", Offset = "0xA991C0", VA = "0x180A9A5C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public YQDHHMUYBMM UIDWWFFIPLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5A0", Offset = "0xA991A0", VA = "0x180A9A5A0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28337B0", Offset = "0x28323B0", VA = "0x1828337B0")]
		private VPQNUAYWDQQ(QISMRYAGOIJ.HGULJDEHQOI a, TGMYLJQNIMW.HGULJDEHQOI b, MIRQTXIQXPT.HGULJDEHQOI c, HZPHESKVUJP.LGUBDHHAHFH<ActionKind, NOYQGYRQTEZ, TGMYLJQNIMW> d, CV2Request.HGULJDEHQOI e, RAIVYTHKDKV f, VUZSBPVGYXW g, XPEEEJIOVCS h, DZRACNYRZDY i, YQDHHMUYBMM j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2832F90", Offset = "0x2831B90", VA = "0x182832F90")]
		public static VPQNUAYWDQQ? DVMTFXSNWAT(MIRQTXIQXPT.HGULJDEHQOI cv2RootSysDeps, [Optional] QISMRYAGOIJ.HGULJDEHQOI? a, [Optional] TGMYLJQNIMW.HGULJDEHQOI? b, [Optional] HZPHESKVUJP.LGUBDHHAHFH<ActionKind, NOYQGYRQTEZ, TGMYLJQNIMW>? reducerDeps, [Optional] CV2Request.HGULJDEHQOI? c, [Optional] RAIVYTHKDKV? d, [Optional] VUZSBPVGYXW? e, [Optional] XPEEEJIOVCS? f, [Optional] DZRACNYRZDY? g, [Optional] YQDHHMUYBMM? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28332F0", Offset = "0x2831EF0", VA = "0x1828332F0")]
		public static VPQNUAYWDQQ PEABZUUSNMJ(ZFOPNMGJHIN a, [Optional] QISMRYAGOIJ.HGULJDEHQOI? circuitsLifecycleDeps, [Optional] TGMYLJQNIMW.HGULJDEHQOI? circuitsManagerDeps, [Optional] HZPHESKVUJP.LGUBDHHAHFH<ActionKind, NOYQGYRQTEZ, TGMYLJQNIMW>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2833440", Offset = "0x2832040", VA = "0x182833440")]
		public static VPQNUAYWDQQ TCTGUCZTSWB(GetNetworkObjectDelegate a, [Optional] QISMRYAGOIJ.HGULJDEHQOI? circuitsLifecycleDeps, [Optional] TGMYLJQNIMW.HGULJDEHQOI? circuitsManagerDeps, [Optional] HZPHESKVUJP.LGUBDHHAHFH<ActionKind, NOYQGYRQTEZ, TGMYLJQNIMW>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class LUTQJOIKNRH
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MIPFINYMDPQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public GetNetworkObjectDelegate XAICKNSAJCR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int KQXITGFIKGB;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MIPFINYMDPQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x282DF90", Offset = "0x282CB90", VA = "0x18282DF90")]
			internal WUJNHINGHTI JSMFQQBDDQK(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x282DE30", Offset = "0x282CA30", VA = "0x18282DE30")]
			internal WUJNHINGHTI[] JRLXEIFQILR(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1C0", Offset = "0xA9BDC0", VA = "0x180A9D1C0")]
			internal int UVCTZHKEYRB()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class MIUMFUSJNAZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public DynamicEnvironmentNetworkId TWXJBEQMTMZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public MIPFINYMDPQ CFCUCJZVXTS;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MIUMFUSJNAZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x282E000", Offset = "0x282CC00", VA = "0x18282E000")]
			internal WUJNHINGHTI BUYXIYQSCQA(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly GDANQZHWFSQ TBGBTRSZNYZ;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x282D580", Offset = "0x282C180", VA = "0x18282D580")]
		public static WUJNHINGHTI? DYAXXBJFXCN(Id32<KJUTVDVUHQM>? networkObject, [Optional] KXKGRFKBZUB.SerializesIntoSavesDelegate? a, [Optional] KXKGRFKBZUB.SerializesIntoInventionsDelegate? b, [Optional] KXKGRFKBZUB.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2829190", Offset = "0x2827D90", VA = "0x182829190")]
		public static ZFOPNMGJHIN? AFJHMXNELGU(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] CHMJTXYXPBS? b, [Optional] PSLOADIYRZA? c, [Optional] MXOSJDQETHC? d, [Optional] JEXXETQFPCN? e, int f = 300000, bool g = false, bool h = false, [Optional] SBWKEPTWVOG? i, [Optional] HEVRIMIUSVU? j, [Optional] XXASXCCNHAN? k, [Optional] RWIONSQNIGM? l, [Optional] MWZJDBINZVD? m, [Optional] WYUKZMUKNHC? n, [Optional] CQCWMALDTKQ.HGULJDEHQOI? o, [Optional] EqualsNodeV2.HGULJDEHQOI? p, [Optional] ZHXCQEBWJJM? q, [Optional] ZFOPNMGJHIN.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] ZFOPNMGJHIN.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] ZFOPNMGJHIN.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] ZFOPNMGJHIN.GetLocalRoomIdDelegate? u, [Optional] ZFOPNMGJHIN.GetLocalSubroomIdDelegate? v, [Optional] ZFOPNMGJHIN.GetSubroomIdsForLocalRoomDelegate? w, [Optional] ZFOPNMGJHIN.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] ZFOPNMGJHIN.SaveRoomOnPlayerBehalfDelegate? z, [Optional] ZFOPNMGJHIN.ReportCloudDataLedgerChangedDelegate? ba, [Optional] ZFOPNMGJHIN.GetColorNameByIdDelegate? bb, [Optional] ZFOPNMGJHIN.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] ZFOPNMGJHIN.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] ZFOPNMGJHIN.GetTaggableNameFromSignalDelegate? be, [Optional] ZFOPNMGJHIN.GetAudioNameFromSignalDelegate? bf, [Optional] ZFOPNMGJHIN.GetDestinationNameFromSignalDelegate? bg, [Optional] ZFOPNMGJHIN.GetPlayerEventNameFromSignalDelegate? bh, [Optional] ZFOPNMGJHIN.GetRoomKeyNameFromSignalDelegate? bi, [Optional] ZFOPNMGJHIN.GetRewardNameFromSignalDelegate? bj, [Optional] ZFOPNMGJHIN.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] ZFOPNMGJHIN.ReportPreloadedAudioChangedDelegate? bl, [Optional] ZFOPNMGJHIN.ReportRewardDataChangedDelegate? bm, [Optional] ZFOPNMGJHIN.GetConsumableNameFromSignalDelegate? bn, [Optional] ZFOPNMGJHIN.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] ZFOPNMGJHIN.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] ZFOPNMGJHIN.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] ZFOPNMGJHIN.GetInventoryItemNameFromSignalDelegate? br, [Optional] ZFOPNMGJHIN.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] ZFOPNMGJHIN.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] ZFOPNMGJHIN.GetRoomOfferNameFromSignalDelegate? bu, [Optional] ZFOPNMGJHIN.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] ZFOPNMGJHIN.GetObjectIdFromCreationObjectDelegate? bw, [Optional] ZFOPNMGJHIN.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] ZFOPNMGJHIN.GetCostInBytesDelegate? by, [Optional] ZFOPNMGJHIN.GetAvatarItemNameFromSignalDelegate? bz, [Optional] ZFOPNMGJHIN.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] ZFOPNMGJHIN.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] ZFOPNMGJHIN.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] ZFOPNMGJHIN.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] ZFOPNMGJHIN.GetStoreItemNameFromSignalDelegate? ce, [Optional] ZFOPNMGJHIN.GetBodyPartNameFromSignalDelegate? cf, [Optional] ZFOPNMGJHIN.GetDependenciesForGraphInstanceDelegate? cg, [Optional] ZFOPNMGJHIN.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] ZFOPNMGJHIN.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] ZFOPNMGJHIN.GetRecNetImageNameFromSignalDelegate? cj, [Optional] ZFOPNMGJHIN.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] ZFOPNMGJHIN.IsFunctionValidForAIDelegate? cm, [Optional] ZFOPNMGJHIN.GetAIFunctionNameFromSignalDelegate? cn)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<KJUTVDVUHQM>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class RGJYHYJYWRQ : XXASXCCNHAN
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly RGJYHYJYWRQ PGFSJHGESKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly GetLocalPlayerDelegate? ZCJMUPQJTXP;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x28303F0", Offset = "0x282EFF0", VA = "0x1828303F0", Slot = "4")]
		public (MQKFVQOBDTG, MQKFVQOBDTG, MQKFVQOBDTG, MQKFVQOBDTG, MQKFVQOBDTG) POGVJTBSTMU(object a)
		{
			return default((MQKFVQOBDTG, MQKFVQOBDTG, MQKFVQOBDTG, MQKFVQOBDTG, MQKFVQOBDTG));
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x28303C0", Offset = "0x282EFC0", VA = "0x1828303C0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "6")]
		public bool HYLNHOWUFPN(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAF79F0", Offset = "0xAF65F0", VA = "0x180AF79F0", Slot = "7")]
		public string HVAHHEZFAAT(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public RGJYHYJYWRQ([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class KXKGRFKBZUB : WUJNHINGHTI
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(KXKGRFKBZUB self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(KXKGRFKBZUB self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(KXKGRFKBZUB self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoSavesDelegate VDPYLSTCKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly SerializesIntoInventionsDelegate SXVSJAZBBUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly CanPublishInInventionsDelegate CWUDDIIRITI;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? XPPEXRAPNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private JKKBXRZXNTM? YZCWZZSDYDM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA98600", Offset = "0xA97200", VA = "0x180A98600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId ESCQHAYLMFR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCC50F0", Offset = "0xCC3CF0", VA = "0x180CC50F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ZBYGLRZKSQE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2829160", Offset = "0x2827D60", VA = "0x182829160", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool MIRPBLCGCEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2829130", Offset = "0x2827D30", VA = "0x182829130", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NICUQCBZXRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2829100", Offset = "0x2827D00", VA = "0x182829100", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public EXAQJZVZHUV? GLAQQTCJGYM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<KJUTVDVUHQM>? JEOJCRMBMLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2828FB0", Offset = "0x2827BB0", VA = "0x182828FB0", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2828A40", Offset = "0x2827640", VA = "0x182828A40", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(GDANQZHWFSQ e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA98600", Offset = "0xA97200", VA = "0x180A98600", Slot = "13")]
		public void Bind(JKKBXRZXNTM controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2829050", Offset = "0x2827C50", VA = "0x182829050")]
		private KXKGRFKBZUB(Id32<KJUTVDVUHQM>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2828AE0", Offset = "0x28276E0", VA = "0x182828AE0")]
		public static KXKGRFKBZUB? New(Id32<KJUTVDVUHQM>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class BPFDGIGAQZL : SBWKEPTWVOG
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
		public static readonly BPFDGIGAQZL PGFSJHGESKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly RoundToDecimalPlaceDelegate? RODCPGVMZKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly TruncateToDecimalPlaceDelegate? GWBCGRVYQEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorLerpDelegate? UDSIHVQYTPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsColorInverseLerpDelegate? NOAXBYWOJZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetPositionDelegate? KVGPYMNUIWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4GetRotationDelegate? BHPCHXOGITE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4InverseDelegate? OZNONNMYNRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4MultiplyDelegate? CVUPMKABEWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? MRTZQYUEVGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatDotDelegate? SYSLUNWDOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromAngleAxisDelegate? PJCUJRBBKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? QNQLPYVFJRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromFromToRotationDelegate? JDKJWBYOICU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromLookRotationDelegate? ATRRVUFUSQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? GQXALIGUJFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatInverseDelegate? RJRMWHTKTWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpDelegate? WUQPOURFIPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatLerpUnclampedDelegate? BWEXSDAPSRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatInverseLerpDelegate? WFGPOGIDMTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatMultiplyDelegate? VJGXKCPAQJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatNormalizeDelegate? LLRVOOQGEHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateTowardsDelegate? MWYKTUKMMYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatRotateVectorDelegate? YGUMKXNRIOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatSlerpDelegate? BKSMDQSKSWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToAngleAxisDelegate? USEUAGCJBMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatToEulerAnglesDelegate? MKIVGAWYQMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3AddDelegate? OPSOFHUKMQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? RERGXCDFCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? VNJCWSQCZUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3CrossDelegate? CVLOYKCFDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3DotDelegate? AQAYMMYQGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3AngleDelegate? YTOWQMXHTCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3GetMagnitudeDelegate? CIHFBUXOGRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpDelegate? JOKIZCRQNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3LerpUnclampedDelegate? MSDFVMGTQER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3InverseLerpDelegate? EWXPPWUSJXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3MoveTowardsDelegate? SDMYSVAEZEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NegateDelegate? QPBJNHIENWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3NormalizeDelegate? ORGPAGNFXWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectDelegate? KOTYCMWSBKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? CERVJPDHAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ScaleDelegate? EQGUQNSJSZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SmoothDampDelegate? XIUEXIMRBXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SubtractDelegate? BNNXTDUIPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SlerpDelegate? XMMGBKANCMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3TransformDelegate? CTMWDQQRAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3InverseTransformDelegate? OLYSNBQHRRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly RealtimeSinceStartupDelegate? PCIPSWHDOIS;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2826C60", Offset = "0x2825860", VA = "0x182826C60")]
		public BPFDGIGAQZL([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2824E80", Offset = "0x2823A80", VA = "0x182824E80")]
		public float CMDTRHMVXHA([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28250C0", Offset = "0x2823CC0", VA = "0x1828250C0")]
		public float QUJKCOZDWBI([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2826380", Offset = "0x2824F80", VA = "0x182826380")]
		public CircuitsColor THYJWGPSBQP([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2825C30", Offset = "0x2824830", VA = "0x182825C30")]
		public float LYHNGXJNTWT([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2826130", Offset = "0x2824D30", VA = "0x182826130")]
		public CircuitsVec3 QRJQVALPIGZ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2825DF0", Offset = "0x28249F0", VA = "0x182825DF0")]
		public CircuitsQuat OBESBBGYGOM([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2825930", Offset = "0x2824530", VA = "0x182825930")]
		public CircuitsMtx4x4 ILVDNWEPOXQ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2825280", Offset = "0x2823E80", VA = "0x182825280")]
		public CircuitsMtx4x4 EUTDIGINLVI([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2826800", Offset = "0x2825400", VA = "0x182826800")]
		public CircuitsMtx4x4 XGACGRQBQSS([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2824F50", Offset = "0x2823B50", VA = "0x182824F50")]
		public float LGKJFWGLRED([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2825460", Offset = "0x2824060", VA = "0x182825460")]
		public CircuitsQuat WDTIUILLIYG(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2826450", Offset = "0x2825050", VA = "0x182826450")]
		public CircuitsQuat TTQYPWHZIZL([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28252F0", Offset = "0x2823EF0", VA = "0x1828252F0")]
		public CircuitsQuat FDMFCRTZSDN([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2825C60", Offset = "0x2824860", VA = "0x182825C60")]
		public CircuitsQuat QBBRIKHRPBP([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2824C90", Offset = "0x2823890", VA = "0x182824C90")]
		public CircuitsQuat BRGMJZPAQCY([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28251C0", Offset = "0x2823DC0", VA = "0x1828251C0")]
		public CircuitsQuat ETSXCMQFCKV([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2825B00", Offset = "0x2824700", VA = "0x182825B00")]
		public CircuitsQuat TWOSZLQHYVS([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2825430", Offset = "0x2824030", VA = "0x182825430")]
		public float JLPBMMXAFIB([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2825620", Offset = "0x2824220", VA = "0x182825620")]
		public CircuitsQuat GUFTEDTHAJO([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2825510", Offset = "0x2824110", VA = "0x182825510")]
		public CircuitsQuat GGWBEOINKSX([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2825870", Offset = "0x2824470", VA = "0x182825870")]
		public CircuitsQuat IBCOKRCMOZL([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2824DC0", Offset = "0x28239C0", VA = "0x182824DC0")]
		public CircuitsVec3 CGLQCURUWLG([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2824B10", Offset = "0x2823710", VA = "0x182824B10")]
		public CircuitsQuat ZDYYKOYSFSE([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2824D50", Offset = "0x2823950", VA = "0x182824D50")]
		public void BUZXDCGXWJL([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28256D0", Offset = "0x28242D0", VA = "0x1828256D0")]
		public CircuitsVec3 GYXQPUEHBFE([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2826250", Offset = "0x2824E50", VA = "0x182826250")]
		public CircuitsVec3 RKIVTPJBQBJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2825D10", Offset = "0x2824910", VA = "0x182825D10")]
		public CircuitsVec3 MWITQTJYLXR([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28265D0", Offset = "0x28251D0", VA = "0x1828265D0")]
		public CircuitsVec3 VEGZZHTQCTK([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2825BC0", Offset = "0x28247C0", VA = "0x182825BC0")]
		public CircuitsVec3 LSLRTRCEKSU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2824D30", Offset = "0x2823930", VA = "0x182824D30")]
		public float BTWRAKJREZN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2825A00", Offset = "0x2824600", VA = "0x182825A00")]
		public float UOKTGVVKVSD([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2825410", Offset = "0x2824010", VA = "0x182825410")]
		public float PFYJXTLHXRU([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2825F90", Offset = "0x2824B90", VA = "0x182825F90")]
		public CircuitsVec3 QDDNUEKUQIB([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2826720", Offset = "0x2825320", VA = "0x182826720")]
		public CircuitsVec3 VJRPOXOQJFO([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2824D90", Offset = "0x2823990", VA = "0x182824D90")]
		public float VZCJZPHAZYJ([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28262C0", Offset = "0x2824EC0", VA = "0x1828262C0")]
		public CircuitsVec3 RLYCOWPPGHB([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2826870", Offset = "0x2825470", VA = "0x182826870")]
		public CircuitsVec3 XPXUFKNRIUC([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2825A80", Offset = "0x2824680", VA = "0x182825A80")]
		public CircuitsVec3 KWYCGRGZSLV([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28253A0", Offset = "0x2823FA0", VA = "0x1828253A0")]
		public CircuitsVec3 FFDZJDVULUZ([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2825050", Offset = "0x2823C50", VA = "0x182825050")]
		public CircuitsVec3 EASZZIXGJQW([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28257A0", Offset = "0x28243A0", VA = "0x1828257A0")]
		public CircuitsVec3 HTTTJQHWWDE([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2824EA0", Offset = "0x2823AA0", VA = "0x182824EA0")]
		public CircuitsVec3 CQWNMHGWYAI([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2826790", Offset = "0x2825390", VA = "0x182826790")]
		public CircuitsVec3 XBQZJJIFQZS([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2826A20", Offset = "0x2825620", VA = "0x182826A20")]
		public CircuitsVec3 ZWTSRDHYCEU([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2825730", Offset = "0x2824330", VA = "0x182825730")]
		public CircuitsVec3 HPQSDGJIXXS([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2824F70", Offset = "0x2823B70", VA = "0x182824F70")]
		public CircuitsVec3 DTAHIHBREWM([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2825E40", Offset = "0x2824A40", VA = "0x182825E40", Slot = "50")]
		public Task OLXNCPHYPKU(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "51")]
		public void NESJDLJVHXK([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2826070", Offset = "0x2824C70", VA = "0x182826070", Slot = "52")]
		public GOBWESELGYH<NWNCJNHUMKH> QKMPAGFPQGS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2826330", Offset = "0x2824F30", VA = "0x182826330", Slot = "53")]
		public GOBWESELGYH<NWNCJNHUMKH> RYLQIXJPODF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2825AE0", Offset = "0x28246E0", VA = "0x182825AE0", Slot = "54")]
		public float LDUJUFFXEIV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2824E80", Offset = "0x2823A80", VA = "0x182824E80", Slot = "4")]
		private float ZMKOFRSWPJO([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28250C0", Offset = "0x2823CC0", VA = "0x1828250C0", Slot = "5")]
		private float EGMCOGQXLCY([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2825F30", Offset = "0x2824B30", VA = "0x182825F30", Slot = "6")]
		private CircuitsColor PPLRUKQWMPT([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2825C30", Offset = "0x2824830", VA = "0x182825C30", Slot = "7")]
		private float LUIQDWMWKBT([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2825E70", Offset = "0x2824A70", VA = "0x182825E70", Slot = "8")]
		private CircuitsVec3 ONLWTIJTYAD([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2824E30", Offset = "0x2823A30", VA = "0x182824E30", Slot = "9")]
		private CircuitsQuat CGWVSJEFPJQ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2825ED0", Offset = "0x2824AD0", VA = "0x182825ED0", Slot = "10")]
		private CircuitsMtx4x4 PBQGBQAXFKA([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28261F0", Offset = "0x2824DF0", VA = "0x1828261F0", Slot = "11")]
		private CircuitsMtx4x4 RAUALWGAFSM([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2826190", Offset = "0x2824D90", VA = "0x182826190", Slot = "12")]
		private CircuitsMtx4x4 QZYJUWRVKAY([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2824F50", Offset = "0x2823B50", VA = "0x182824F50", Slot = "13")]
		private float DBOSSWPBKWR([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2825460", Offset = "0x2824060", VA = "0x182825460", Slot = "14")]
		private CircuitsQuat GGORNLEPWZW(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2826450", Offset = "0x2825050", VA = "0x182826450", Slot = "15")]
		private CircuitsQuat ZXGHYCQISDN([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28252F0", Offset = "0x2823EF0", VA = "0x1828252F0", Slot = "16")]
		private CircuitsQuat HTNGCNCHQDP([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2825C60", Offset = "0x2824860", VA = "0x182825C60", Slot = "17")]
		private CircuitsQuat MLKXNMVKZIP([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2824C90", Offset = "0x2823890", VA = "0x182824C90", Slot = "18")]
		private CircuitsQuat HQFMQKSTTTE([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x28251C0", Offset = "0x2823DC0", VA = "0x1828251C0", Slot = "19")]
		private CircuitsQuat IATFUZUYMZB([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2825B00", Offset = "0x2824700", VA = "0x182825B00", Slot = "20")]
		private CircuitsQuat LPBITKAVLPY([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2825430", Offset = "0x2824030", VA = "0x182825430", Slot = "21")]
		private float GDRGUKVWCYT([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2825620", Offset = "0x2824220", VA = "0x182825620", Slot = "22")]
		private CircuitsQuat YTDLOGRTPFY([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2825510", Offset = "0x2824110", VA = "0x182825510", Slot = "23")]
		private CircuitsQuat YMFYTBQXULX([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2825870", Offset = "0x2824470", VA = "0x182825870", Slot = "24")]
		private CircuitsQuat NLQXOWRGMRN([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x28263E0", Offset = "0x2824FE0", VA = "0x1828263E0", Slot = "25")]
		private CircuitsVec3 TJVEWMUAYNA([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2824B10", Offset = "0x2823710", VA = "0x182824B10", Slot = "26")]
		private CircuitsQuat ALHMHPXKBDU([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2824D50", Offset = "0x2823950", VA = "0x182824D50", Slot = "27")]
		private void VLDPGTQNIRN([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28259A0", Offset = "0x28245A0", VA = "0x1828259A0", Slot = "28")]
		private CircuitsVec3 JWNXIJPFRTW([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28269B0", Offset = "0x28255B0", VA = "0x1828269B0", Slot = "29")]
		private CircuitsVec3 ZJZIFFAOUDD([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28250E0", Offset = "0x2823CE0", VA = "0x1828250E0", Slot = "30")]
		private CircuitsVec3 EQVNYCWQJKR([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28266B0", Offset = "0x28252B0", VA = "0x1828266B0", Slot = "31")]
		private CircuitsVec3 VIAYFSHFIKO([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2825D80", Offset = "0x2824980", VA = "0x182825D80", Slot = "32")]
		private CircuitsVec3 NLYVKRSINNE([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x28264F0", Offset = "0x28250F0", VA = "0x1828264F0", Slot = "33")]
		private CircuitsVec3 UZAKSRSYEQC([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2826560", Offset = "0x2825160", VA = "0x182826560", Slot = "34")]
		private CircuitsVec3 VCVNHNVEHBE([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2824D30", Offset = "0x2823930", VA = "0x182824D30", Slot = "35")]
		private float DMSBJDAQBHX([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2825A00", Offset = "0x2824600", VA = "0x182825A00", Slot = "36")]
		private float KDSMHOIDWNH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2825410", Offset = "0x2824010", VA = "0x182825410", Slot = "37")]
		private float GASRRJFQJOA([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2826940", Offset = "0x2825540", VA = "0x182826940", Slot = "38")]
		private CircuitsVec3 ZHZKHIDPEQX([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2824FE0", Offset = "0x2823BE0", VA = "0x182824FE0", Slot = "39")]
		private CircuitsVec3 DYETJSZYRKW([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2824D90", Offset = "0x2823990", VA = "0x182824D90", Slot = "40")]
		private float BYFFIOJTNRB([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2826640", Offset = "0x2825240", VA = "0x182826640", Slot = "41")]
		private CircuitsVec3 VGINNIFVYSZ([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2825A20", Offset = "0x2824620", VA = "0x182825A20", Slot = "42")]
		private CircuitsVec3 KMSUKJUUKFS([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2825810", Offset = "0x2824410", VA = "0x182825810", Slot = "43")]
		private CircuitsVec3 HVRAIHHTZAV([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2826000", Offset = "0x2824C00", VA = "0x182826000", Slot = "44")]
		private CircuitsVec3 QGVMYEAOGDF([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28260C0", Offset = "0x2824CC0", VA = "0x1828260C0", Slot = "45")]
		private CircuitsVec3 QKYKHGWIIPC([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28268D0", Offset = "0x28254D0", VA = "0x1828268D0", Slot = "46")]
		private CircuitsVec3 YLBATNJNDSI([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2824BD0", Offset = "0x28237D0", VA = "0x182824BD0", Slot = "47")]
		private CircuitsVec3 BNXBATBFJOG([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x28255B0", Offset = "0x28241B0", VA = "0x1828255B0", Slot = "48")]
		private CircuitsVec3 GTAPZUTDXJA([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2825150", Offset = "0x2823D50", VA = "0x182825150", Slot = "49")]
		private CircuitsVec3 ETQUACYADUO([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class XKDTJDMKUCV : YBSMRZIILVY
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x102CA00", Offset = "0x102B600", VA = "0x18102CA00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xF97D10", Offset = "0xF96910", VA = "0x180F97D10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2834730", Offset = "0x2833330", VA = "0x182834730")]
		public XKDTJDMKUCV(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class FDEONBXOLAF : HEVRIMIUSVU
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(UZNSAHKLUZD e, JWZXIBMMSAQ invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly FDEONBXOLAF PGFSJHGESKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetCircuitsColorFromColorIndexDelegate? HNJOKVHDQNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? SLKOFCUPZJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly InvisibleCollisionSetEnabledDelegate? TZHFTFZXAOD;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xDA16A0", Offset = "0xDA02A0", VA = "0x180DA16A0")]
		public FDEONBXOLAF([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2828030", Offset = "0x2826C30", VA = "0x182828030", Slot = "4")]
		public CircuitsColor UGKROWSVJXH(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2828010", Offset = "0x2826C10", VA = "0x182828010")]
		public int MFGFTSSOBQX([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2828010", Offset = "0x2826C10", VA = "0x182828010", Slot = "5")]
		private int ORZLAPQSIHS([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class WPIYROFCZEU : LTCMOHTVJOZ
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class JRLALEZWFYF
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid CHRGTRTBTGZ
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xBB0FE0", Offset = "0xBAFBE0", VA = "0x180BB0FE0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long ZTFCHXJICRQ
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int BGWQSVGDUBS
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xA9F8F0", Offset = "0xA9E4F0", VA = "0x180A9F8F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool ZZAXKMCLGRH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x17EF370", Offset = "0x17EDF70", VA = "0x1817EF370")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool FCNDTKITTTZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x17EFAB0", Offset = "0x17EE6B0", VA = "0x1817EFAB0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool BQSPPIXRULW
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x28289C0", Offset = "0x28275C0", VA = "0x1828289C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x28289E0", Offset = "0x28275E0", VA = "0x1828289E0")]
			public JRLALEZWFYF(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly Dictionary<Id128<YNBOVCHXCPU>, JRLALEZWFYF> RVCCPOJQMBS;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2833B80", Offset = "0x2832780", VA = "0x182833B80")]
		public bool YBEYCKPFHKB([In] Id128<YNBOVCHXCPU> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2833990", Offset = "0x2832590", VA = "0x182833990")]
		public void WMIUXYGGJBX([In] Id128<YNBOVCHXCPU> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2833C90", Offset = "0x2832890", VA = "0x182833C90")]
		public void WMIUXYGGJBX([In] Id128<YNBOVCHXCPU> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2833A60", Offset = "0x2832660", VA = "0x182833A60")]
		public void TWCUHYWRTAQ([In] Id128<YNBOVCHXCPU> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2833930", Offset = "0x2832530", VA = "0x182833930")]
		public void KICCTAYBTDR([In] Id128<YNBOVCHXCPU> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x28338A0", Offset = "0x28324A0", VA = "0x1828338A0")]
		public bool ZZAXKMCLGRH([In] Id128<YNBOVCHXCPU> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2833D70", Offset = "0x2832970", VA = "0x182833D70")]
		public WPIYROFCZEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2833B80", Offset = "0x2832780", VA = "0x182833B80", Slot = "4")]
		private bool VMKRKEVWBVI([In] Id128<YNBOVCHXCPU> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2833990", Offset = "0x2832590", VA = "0x182833990", Slot = "5")]
		private void SEXAUKBURDY([In] Id128<YNBOVCHXCPU> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2833A60", Offset = "0x2832660", VA = "0x182833A60", Slot = "6")]
		private void TORKDHMZSAD([In] Id128<YNBOVCHXCPU> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2833930", Offset = "0x2832530", VA = "0x182833930", Slot = "7")]
		private void FGBAROGDJUI([In] Id128<YNBOVCHXCPU> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x28338A0", Offset = "0x28324A0", VA = "0x1828338A0", Slot = "8")]
		private bool AKRQNMTOBLW([In] Id128<YNBOVCHXCPU> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class YOICDODOOLR
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2834780", Offset = "0x2833380", VA = "0x182834780")]
		public static LogDeps RYTQQRMJXLS()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class CWUQYAZKZLM : MeshLibrary.HGULJDEHQOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "4")]
		public byte[]? VWRZBZJWUTV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
		public void LEAXGGOGWBM(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public CWUQYAZKZLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class PDJPRDQZLDT : CHMJTXYXPBS
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
		public delegate void ConfigureAttachedObjectDelegate(GRPSCMNREYO controlPanel, ERQHRRBKVVO staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<LMMSIGKDEXB> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, GGHDNJMZMXZ>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, GGHDNJMZMXZ>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, GGHDNJMZMXZ>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, GGHDNJMZMXZ>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<RWYPXOVFHEU>, GGHDNJMZMXZ>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<RWYPXOVFHEU>, GGHDNJMZMXZ>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Task<Result<MultiResult, GGHDNJMZMXZ>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private TaskAwaiter<Result<MultiResult, GGHDNJMZMXZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2831EB0", Offset = "0x2830AB0", VA = "0x182831EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2832170", Offset = "0x2830D70", VA = "0x182832170", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<RWYPXOVFHEU>, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public Task<Result<Id32<RWYPXOVFHEU>, GGHDNJMZMXZ>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private TaskAwaiter<Result<Id32<RWYPXOVFHEU>, GGHDNJMZMXZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x28321E0", Offset = "0x2830DE0", VA = "0x1828321E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x28324A0", Offset = "0x28310A0", VA = "0x1828324A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public Task<Result<None, GGHDNJMZMXZ>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private TaskAwaiter<Result<None, GGHDNJMZMXZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2832510", Offset = "0x2831110", VA = "0x182832510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x28327D0", Offset = "0x28313D0", VA = "0x1828327D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<string, EnumChoiceData> ACMDTTIHVTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<int, string> BRWGUJOOHIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<object> QOAPEZTAGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly List<Guid> KSZHGCKHTGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly CanLocalPlayerCreateCurrencyDelegate NOXNYCUVHGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ShowRoomCurrencyCreationUIDelegate DHSDFZYVQVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly GetAudioClipOptionsDelegate OPKEDYVJCYW;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly IReadOnlyDictionary<Guid, int> VYXNHHADLUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipGuidToIndexMapDelegate ZDLUIULMOOS;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<int, Guid> TANJRSSPJWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipIndexToGuidMapDelegate HQGGEFHSVNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly GetAllAudioClipOptionsDelegate HGQXXYVTCZD;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly IReadOnlyDictionary<Guid, int> HIRCRAVXPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate DTHJOPTQUNR;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<int, Guid> FILPHHMATFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate NYQQYXGVSZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly PlayAudioPreviewDelegate BMYQEJBXLRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly StopAudioPreviewDelegate DVOLHUVJHYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SubscriptionIsActiveDelegate OGOTEXFJPJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate ZAEAOWDVIIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly Dictionary<string, EnumChoiceData> OTYYJOUKBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly ShowQuickChatEditMenuDelegate JGANRDSODVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly ConfigureAttachedObjectDelegate PBUVMOMPQXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly DisplayInvalidNameErrorMessageDelegate JKNIOFWUCMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly IsStringPureDelegate SLNVTNUHMZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly TryGetSpecificChipConfigSummaryDelegate LCVMYHFFCYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReleaseIconIdDelegate FQJIMRVSTSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate SUVYYZIJDGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 TAFQOXPQWTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 TAAJRQVTNIE;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment EMWCIQLJJVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool BIVMXLECWEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xAE9750", Offset = "0xAE8350", VA = "0x180AE9750", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> GKPCMGMICKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> GACXPBPITGB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> XMDHZUOKMNA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> ANPMZOYEXOS
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA9D810", Offset = "0xA9C410", VA = "0x180A9D810", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion MGXTWOYAZYI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xCF8AF0", Offset = "0xCF76F0", VA = "0x180CF8AF0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool PGTNZBDJFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xBBEC60", Offset = "0xBBD860", VA = "0x180BBEC60", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool RQAJDNAZNBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x282EB60", Offset = "0x282D760", VA = "0x18282EB60", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool OPVCDOJHNPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x282ED40", Offset = "0x282D940", VA = "0x18282ED40", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool TLSMKWQLJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99790", VA = "0x180A9AB90", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x282EF60", Offset = "0x282DB60", VA = "0x18282EF60")]
		public PDJPRDQZLDT([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x282EA70", Offset = "0x282D670", VA = "0x18282EA70", Slot = "9")]
		public bool NXMBULZWEKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		public static bool XPWQBXGQNEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x282E830", Offset = "0x282D430", VA = "0x18282E830", Slot = "10")]
		public bool EZSXKIDZWWU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		public static void OBSVUMUHPXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xBF2170", Offset = "0xBF0D70", VA = "0x180BF2170", Slot = "11")]
		public void KXUNAZAAZGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x282E920", Offset = "0x282D520", VA = "0x18282E920")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> IHPJAQZBQTS(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x282E980", Offset = "0x282D580", VA = "0x18282E980", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> JZHCBMMPOMH(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x282E890", Offset = "0x282D490", VA = "0x18282E890")]
		private static IReadOnlyDictionary<Guid, int> GXQGPKJBVIC(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x282EC10", Offset = "0x282D810", VA = "0x18282EC10", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> TWSDAOSIUAV(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x282E600", Offset = "0x282D200", VA = "0x18282E600")]
		private static IReadOnlyDictionary<int, Guid> CEKZVGPZROC(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x282E4B0", Offset = "0x282D0B0", VA = "0x18282E4B0", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> ATFATMYSSDT(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x282EB30", Offset = "0x282D730", VA = "0x18282EB30")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ODDOWPQAFJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x281B9D0", Offset = "0x281A5D0", VA = "0x18281B9D0", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> WRECIEUMIJQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x282EC70", Offset = "0x282D870", VA = "0x18282EC70")]
		private static IReadOnlyDictionary<Guid, int> VLKNOLGFQNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x282EBB0", Offset = "0x282D7B0", VA = "0x18282EBB0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> RUUOIZJRCES()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x282EC40", Offset = "0x282D840", VA = "0x18282EC40", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> UZWYMQLXORU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void TJYRUWZSAYE(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x282ED00", Offset = "0x282D900", VA = "0x18282ED00", Slot = "18")]
		public void XJLFHQQXCXN(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void QCPSQASUDZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x282EBE0", Offset = "0x282D7E0", VA = "0x18282EBE0", Slot = "19")]
		public void TDMKBYQPMTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		private static bool TKJWVMSTPBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x282ED50", Offset = "0x282D950", VA = "0x18282ED50", Slot = "20")]
		public bool ZKZIIACCEOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		public static bool LXREUTVONMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x282E480", Offset = "0x282D080", VA = "0x18282E480", Slot = "21")]
		public bool AAEZOIYTXSH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x282E950", Offset = "0x282D550", VA = "0x18282E950", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> IRJJKTIMQUY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> XXHIKADLZAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> ULKIHFOHXDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x282E4E0", Offset = "0x282D0E0", VA = "0x18282E4E0", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BAYMRWBWHUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> SKRXRWFZTTV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> SJWCIGKOEOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		public static void GMWZBSHEUFL(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x282ECC0", Offset = "0x282D8C0", VA = "0x18282ECC0", Slot = "29")]
		public void VTHLZYEGVQM(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void WLICLKKIESH(GRPSCMNREYO a, ERQHRRBKVVO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x282E860", Offset = "0x282D460", VA = "0x18282E860", Slot = "35")]
		public void FSTESOIWEDY(GRPSCMNREYO a, ERQHRRBKVVO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "36")]
		public Dictionary<string, EnumChoiceData> MEUJZQRAJZC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "37")]
		public Dictionary<string, EnumChoiceData> HSWIIQLJHEZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void ACPUHUZZTYR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x282ED80", Offset = "0x282D980", VA = "0x18282ED80")]
		private static Task<bool> ZRNAAVDZTMZ(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x282EB80", Offset = "0x282D780", VA = "0x18282EB80", Slot = "38")]
		public Task<bool> REXQPVEEPEU(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x282EB70", Offset = "0x282D770", VA = "0x18282EB70")]
		private static bool PGYNGYRHXUZ(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x282E8E0", Offset = "0x282D4E0", VA = "0x18282E8E0", Slot = "39")]
		public bool GZGTGZWTHUM(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void YSSTNWHPQKJ(Id32<LMMSIGKDEXB> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x282EA40", Offset = "0x282D640", VA = "0x18282EA40", Slot = "40")]
		public void LQFKKUBYWPK(Id32<LMMSIGKDEXB> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x282E510", Offset = "0x282D110", VA = "0x18282E510")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, GGHDNJMZMXZ>> BNRPLCPRRBD(Task<Result<None, GGHDNJMZMXZ>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x282E9E0", Offset = "0x282D5E0", VA = "0x18282E9E0", Slot = "41")]
		public Task<Result<None, GGHDNJMZMXZ>> KHDAKJDVQEE(Task<Result<None, GGHDNJMZMXZ>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x282E740", Offset = "0x282D340", VA = "0x18282E740")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, GGHDNJMZMXZ>> EXHNTCSGTSB(Task<Result<MultiResult, GGHDNJMZMXZ>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x282E9B0", Offset = "0x282D5B0", VA = "0x18282E9B0", Slot = "42")]
		public Task<Result<MultiResult, GGHDNJMZMXZ>> KHDAKJDVQEE(Task<Result<MultiResult, GGHDNJMZMXZ>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x282E650", Offset = "0x282D250", VA = "0x18282E650")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<RWYPXOVFHEU>, GGHDNJMZMXZ>> EXCGVVYJKGS(Task<Result<Id32<RWYPXOVFHEU>, GGHDNJMZMXZ>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x282EA10", Offset = "0x282D610", VA = "0x18282EA10", Slot = "43")]
		public Task<Result<Id32<RWYPXOVFHEU>, GGHDNJMZMXZ>> KHDAKJDVQEE(Task<Result<Id32<RWYPXOVFHEU>, GGHDNJMZMXZ>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class MXOSJDQETHC : UPVZZKQNRST
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(GDANQZHWFSQ e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private InteropDelegate? OMCZUIZYVWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate XAWRATSWLMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly InteropDelegate PLTBHWQDYAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InteropDelegate? ACKZLXPMBEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private InvokeStudioFunctionDelegate? KWXDOWXKQLQ;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "5")]
		public LegacyCV2Result<None> UTMZBHUAFOS(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20")]
		private static LegacyCV2Result<None> Default(GDANQZHWFSQ _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "6")]
		public LegacyCV2Result<None> CZXQYBUYPFV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "7")]
		public LegacyCV2Result<None> BIAJKSUUWRO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "8")]
		public LegacyCV2Result<None> DBWBRHIKDHL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "9")]
		public LegacyCV2Result<None> ORZRDLGPHEV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "15")]
		public LegacyCV2Result<None> XZKTCJLWKAW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WFXEGLDIMYC(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GTBGPLDFIBE(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JAFKHKQYRLD(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YAJQFUGCUYE(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QZSSUDBMIVZ(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XULWFGYMLMD(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QSHIVTEZTOK(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "93")]
		public LegacyCV2Result<None> JFGSCJEYMGL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "94")]
		public LegacyCV2Result<None> VDKGDMLOERR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "95")]
		public LegacyCV2Result<None> BNZEHBGNLAM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GUUYPDIBITW(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(GDANQZHWFSQ e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IQDLEIDJXRM(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RQJHYGDUEXA(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LOSRAKEVUTP(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZRLJCVHITBW(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FUCNBPWALND(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VDLDAWBONDB(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VBWAYOKXZNZ(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FMDKKFYRMHQ(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x11FF780", Offset = "0x11FE380", VA = "0x1811FF780", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RUYDJKRTPFD(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QXFWNYRCLJI(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "119")]
		public LegacyCV2Result<None> JNASNRUCOKS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RATSPDPJJTF(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "121")]
		public LegacyCV2Result<None> LPSEWIFPEAT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "122")]
		public LegacyCV2Result<None> WPNBEICIEYH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "123")]
		public LegacyCV2Result<None> MPHHLTXSOBR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "124")]
		public LegacyCV2Result<None> HSEKPGKOUWP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "125")]
		public LegacyCV2Result<None> ZCCFPHDENCT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "126")]
		public LegacyCV2Result<None> OACDIZNSJAA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "818")]
		public LegacyCV2Result<None> NYNUQPULGNY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "819")]
		public LegacyCV2Result<None> BYRGRCIJEGS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "147")]
		public LegacyCV2Result<None> IHURIOIPKRY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "148")]
		public LegacyCV2Result<None> QLBRJXTEXQK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "149")]
		public LegacyCV2Result<None> VGZSBUELJGZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "150")]
		public LegacyCV2Result<None> MZVNUZBVLSN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "151")]
		public LegacyCV2Result<None> NHDRLITQFMA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(GDANQZHWFSQ e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(GDANQZHWFSQ e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(GDANQZHWFSQ e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, UPVZZKQNRST.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(GDANQZHWFSQ e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, UPVZZKQNRST.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "174")]
		public LegacyCV2Result<None> APYOWFELFGJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "175")]
		public LegacyCV2Result<None> ESBTAVWHWWG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "176")]
		public LegacyCV2Result<None> HPEDJEJTPTE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "197")]
		public LegacyCV2Result<None> RLXERDOQEKE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "198")]
		public LegacyCV2Result<None> GYGFRUGQRXJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "199")]
		public LegacyCV2Result<None> ZIUZQLFPEOS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "200")]
		public LegacyCV2Result<None> XYTKOPGYFCK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "201")]
		public LegacyCV2Result<None> WCLGLNYLFOK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "202")]
		public LegacyCV2Result<None> GZCVOCNBGBB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "203")]
		public LegacyCV2Result<None> NMYOQCOMHNP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "204")]
		public LegacyCV2Result<None> URMYIGPBFTB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "205")]
		public LegacyCV2Result<None> CAVWPAYQMVZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "206")]
		public LegacyCV2Result<None> UVOZZOBKMAH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "207")]
		public LegacyCV2Result<None> HIBBHVRUHSJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "208")]
		public LegacyCV2Result<None> XHVOWYEPURH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "209")]
		public LegacyCV2Result<None> PNFWPSYTYLB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "210")]
		public LegacyCV2Result<None> KYHZMDJWZDU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "211")]
		public LegacyCV2Result<None> HVJLUVLLTVZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "212")]
		public LegacyCV2Result<None> SWMFRKKISQS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "213")]
		public LegacyCV2Result<None> RSWNPBYMHXD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "214")]
		public LegacyCV2Result<None> YXWBSYBDRJU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "215")]
		public LegacyCV2Result<None> PXEXVAJOFRN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "274")]
		public LegacyCV2Result<None> ZYBNPIAJLDV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "277")]
		public LegacyCV2Result<None> MHPTJDZQIRP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "279")]
		public LegacyCV2Result<None> PPRMJOYAODC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "280")]
		public LegacyCV2Result<None> EVSASGHHRDQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "281")]
		public LegacyCV2Result<None> YKLXJTZYNZB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "282")]
		public LegacyCV2Result<None> LMIBRGKCZJC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "283")]
		public LegacyCV2Result<None> YQZLINEITEZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "287")]
		public LegacyCV2Result<None> LLIIMDDHOQY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "288")]
		public LegacyCV2Result<None> XQPWMCUAASZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "317")]
		public LegacyCV2Result<None> MBKNCYEHUQO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "406")]
		public LegacyCV2Result<None> OYKJLZJBCJX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FLFPLSVPUUU(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BWSGKFPVOQA(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PETGITKRLHI(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NNXNKYQJXON(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FUUOJPQWZSW(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "416")]
		public LegacyCV2Result<YXNCKOARMHY.CV2DiscoverySectionType> NPUMCVNAIFX(GDANQZHWFSQ e, CircuitSignal a)
		{
			return default(LegacyCV2Result<YXNCKOARMHY.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "417")]
		public LegacyCV2Result<None> AERMJKSWSQR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(GDANQZHWFSQ e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GPTUYSVYZXX(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QTNJNPZMEMW(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IXPWUOXAALV(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "462")]
		public LegacyCV2Result<None> AYVEIDJIBPE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "463")]
		public LegacyCV2Result<None> KJPDJPFCQYX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "464")]
		public LegacyCV2Result<None> WPZNFHTHSVK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "465")]
		public LegacyCV2Result<None> WUOLUJQPCWF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "466")]
		public LegacyCV2Result<None> YQZEQFRRRAJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "467")]
		public LegacyCV2Result<None> TSPJTQUFUML(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "468")]
		public LegacyCV2Result<None> HNASXGMMXYI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "469")]
		public LegacyCV2Result<None> UQFFZNSAWDA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "474")]
		public LegacyCV2Result<None> XICPPBZOUAY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "475")]
		public LegacyCV2Result<None> KXPHDZRSWYI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "476")]
		public LegacyCV2Result<None> YLJTTGQSVUR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "477")]
		public LegacyCV2Result<None> LWERTDMDHOM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "478")]
		public LegacyCV2Result<None> GOGWHEDHNUQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "479")]
		public LegacyCV2Result<None> KYTWHWHOWBX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(GDANQZHWFSQ executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(GDANQZHWFSQ executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "472")]
		public LegacyCV2Result<None> DSFBEUKRYCT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "473")]
		public LegacyCV2Result<None> RDXVFLPZPSL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "480")]
		public LegacyCV2Result<None> CHILNCTQNQD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "481")]
		public LegacyCV2Result<None> EIUDRKKPNZV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "482")]
		public LegacyCV2Result<None> XCNWSJILTAY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "483")]
		public LegacyCV2Result<None> QRUDOAARYUG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "484")]
		public LegacyCV2Result<None> XDWUFOMAOAI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "485")]
		public LegacyCV2Result<None> IEZALTCEKKQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "486")]
		public LegacyCV2Result<None> GYVMXLUICSO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "487")]
		public LegacyCV2Result<None> BLFVBWOMUOI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "488")]
		public LegacyCV2Result<None> VAJHCSWCVWC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "489")]
		public LegacyCV2Result<None> YTCMPTKVBSO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "490")]
		public LegacyCV2Result<None> RAVWKNFOYQM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "491")]
		public LegacyCV2Result<None> BQDZJSXTFIQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "492")]
		public LegacyCV2Result<None> WSAPDWDYCNU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "493")]
		public LegacyCV2Result<None> HXCVQYEIRGS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "494")]
		public LegacyCV2Result<None> LMPQTZFAQTU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "495")]
		public LegacyCV2Result<None> HSXDDSULQNG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "496")]
		public LegacyCV2Result<None> CHAUFXHXYXK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "497")]
		public LegacyCV2Result<None> EDCQPVBWAXS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "498")]
		public LegacyCV2Result<None> IQZAQPCCRUW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "499")]
		public LegacyCV2Result<None> MROAEPVUJZS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x282E210", Offset = "0x282CE10", VA = "0x18282E210", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "507")]
		public LegacyCV2Result<None> DVKHJHBWTKC(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "508")]
		public LegacyCV2Result<None> SBODQURAMYM(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "509")]
		public LegacyCV2Result<None> MMTIZFPVGPS(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "510")]
		public LegacyCV2Result<None> THFNJXLOFML(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(GDANQZHWFSQ e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(GDANQZHWFSQ e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(GDANQZHWFSQ e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.ADUFMASSHJM> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "522")]
		public LegacyCV2Result<None> XTQKOLSGZGB(GDANQZHWFSQ e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "525")]
		public LegacyCV2Result<None> AWGMUHLUHRT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "527")]
		public LegacyCV2Result<None> TEHWKPUODES(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "528")]
		public LegacyCV2Result<None> YENJJWAHRSU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "530")]
		public LegacyCV2Result<None> JARHSSYJCHC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "531")]
		public LegacyCV2Result<None> HWMFVFSRRHV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x282E0B0", Offset = "0x282CCB0", VA = "0x18282E0B0", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "533")]
		public LegacyCV2Result<None> NOUVRVBHUJR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x282E0F0", Offset = "0x282CCF0", VA = "0x18282E0F0", Slot = "535")]
		public LegacyCV2Result<None> IJFTXKOPOSJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "534")]
		public LegacyCV2Result<None> NINVBJUPGMO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "536")]
		public LegacyCV2Result<None> YWPUFHKSPWW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "537")]
		public LegacyCV2Result<None> KEDJCZWGNSN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "538")]
		public LegacyCV2Result<None> EGDDTTYICNN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "539")]
		public LegacyCV2Result<None> SPYUFUUOUUP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "540")]
		public LegacyCV2Result<None> MLXHUVZVYDL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "583")]
		public LegacyCV2Result<None> Raycast(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "584")]
		public LegacyCV2Result<None> EUIRSMMMQWW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "587")]
		public LegacyCV2Result<None> FRLCKYZZCLX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "591")]
		public LegacyCV2Result<None> BOADCTHLVNG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "592")]
		public LegacyCV2Result<None> XRSJSYSPTZV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "641")]
		public LegacyCV2Result<None> RAOHZYEMEQY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "642")]
		public LegacyCV2Result<None> KOOZJHWVGIY(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "643")]
		public LegacyCV2Result<None> MNEXGRGBNZT(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "644")]
		public LegacyCV2Result<None> WFJHKZPMRYW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "645")]
		public LegacyCV2Result<None> IBQJIYANKNE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "646")]
		public LegacyCV2Result<None> WDBBTEWMAED(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "649")]
		public LegacyCV2Result<None> EGHQFKNLNRO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "650")]
		public LegacyCV2Result<None> YMKGQVQHVRG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "651")]
		public LegacyCV2Result<None> OBMTTOSHNOB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "661")]
		public LegacyCV2Result<None> QCIAMQYFKKG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "660")]
		public LegacyCV2Result<None> BBLIMZTRKRT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "662")]
		public LegacyCV2Result<None> IKOXTLFTORO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "663")]
		public LegacyCV2Result<None> BTXXIELEYFV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "670")]
		public LegacyCV2Result<None> BJKEFRYQNFO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "671")]
		public LegacyCV2Result<None> AZYFKVOFNIL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "674")]
		public LegacyCV2Result<None> BXOCOQULPOF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "675")]
		public LegacyCV2Result<None> ZLZRPVKDPBK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(GDANQZHWFSQ e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "696")]
		public LegacyCV2Result<None> IKIRSASEKRU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "697")]
		public LegacyCV2Result<None> CNILJBHVMNO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "698")]
		public LegacyCV2Result<None> NMRWBEHKKEU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "699")]
		public LegacyCV2Result<None> IVWDWWYSUPB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "700")]
		public LegacyCV2Result<None> MENFMSCOFHN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "676")]
		public LegacyCV2Result<None> DNNTGCGEPVO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "677")]
		public LegacyCV2Result<None> RUUZDRVHUMK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "678")]
		public LegacyCV2Result<None> BKQBKRTSYMX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "679")]
		public LegacyCV2Result<None> QLSBWTDQQKG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "680")]
		public LegacyCV2Result<None> MJMRZNTTXYZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "681")]
		public LegacyCV2Result<None> QSYOHBAXXOA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "682")]
		public LegacyCV2Result<None> GADOYSBMOCK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "683")]
		public LegacyCV2Result<None> USUHCRSIESD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "684")]
		public LegacyCV2Result<None> YJZUJFDTRJN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "685")]
		public LegacyCV2Result<None> EOTLMLDIHCW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "686")]
		public LegacyCV2Result<None> DPKATTVKXQU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "687")]
		public LegacyCV2Result<None> CKBJPYUQNKV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "688")]
		public LegacyCV2Result<None> BNRKXONEXSO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "689")]
		public LegacyCV2Result<None> PHAIVYIQBLM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "690")]
		public LegacyCV2Result<None> WBLGZDPTVPF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "691")]
		public LegacyCV2Result<None> QUORLETFLER(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "692")]
		public LegacyCV2Result<None> CBQENIQAWTF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "693")]
		public LegacyCV2Result<None> KBEIDWJYMZW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "765")]
		public LegacyCV2Result<None> KGADNXCLCNW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "711")]
		public LegacyCV2Result<None> BOUTXUWAVTT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "712")]
		public LegacyCV2Result<None> HTSWEIQFVNR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "713")]
		public LegacyCV2Result<None> BQPRPFWPEZH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "714")]
		public LegacyCV2Result<None> WGQTOZWFDTZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "717")]
		public LegacyCV2Result<None> LCVKWMTCGBZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "721")]
		public LegacyCV2Result<None> NDDRRWVNIFM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "722")]
		public LegacyCV2Result<None> MRGVCHMYXKM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "723")]
		public LegacyCV2Result<None> STBOWPEILGD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "724")]
		public LegacyCV2Result<None> KXLVBKFLCCV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "725")]
		public LegacyCV2Result<None> AAGXFFPISRH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "726")]
		public LegacyCV2Result<None> PSWWGESGAJC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "727")]
		public LegacyCV2Result<None> VAFZAUKEWXL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "728")]
		public LegacyCV2Result<None> IICHHMOKEKQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "729")]
		public LegacyCV2Result<None> XYWEFENKGXK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "730")]
		public LegacyCV2Result<None> KPUFCYWNFRC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "731")]
		public LegacyCV2Result<None> BOLGVHULYGE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "732")]
		public LegacyCV2Result<None> JSSTIBIZGBC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "733")]
		public LegacyCV2Result<None> NBMEREZPGLY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "734")]
		public LegacyCV2Result<None> HIXKLBBTDQZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "735")]
		public LegacyCV2Result<None> DVSASNUDKOU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "736")]
		public LegacyCV2Result<None> ZLGEGEINEQS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "737")]
		public LegacyCV2Result<None> LQRBSBQXZYZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "738")]
		public LegacyCV2Result<None> ZZBIFZQQUKO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "740")]
		public LegacyCV2Result<None> RPSRMBYMTSA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "739")]
		public LegacyCV2Result<None> OITGFVAQTHA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "741")]
		public LegacyCV2Result<None> SWTRAOQXVSH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "742")]
		public LegacyCV2Result<None> SSGCISLTSDU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "743")]
		public LegacyCV2Result<None> TESXITEZHBL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "744")]
		public LegacyCV2Result<None> OUHLVTMGSJD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "745")]
		public LegacyCV2Result<None> YWGDBVMKZFW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "746")]
		public LegacyCV2Result<None> MPXHVIRTBVT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "747")]
		public LegacyCV2Result<None> IFLTLFTMBOB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "748")]
		public LegacyCV2Result<None> KFUODSDLCLE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "749")]
		public LegacyCV2Result<None> LXDWPPDBKMY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "750")]
		public LegacyCV2Result<None> SDXNUNRGZEO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "751")]
		public LegacyCV2Result<None> OYCSEGISOJE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "752")]
		public LegacyCV2Result<None> SRHNXLJPKTO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "753")]
		public LegacyCV2Result<None> ZRJTDMONWNK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "754")]
		public LegacyCV2Result<None> ZCLEYITIECA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "755")]
		public LegacyCV2Result<None> ZKRYJNAZKLX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "756")]
		public LegacyCV2Result<None> SMNNYDRAVAN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "757")]
		public LegacyCV2Result<None> DETDPQBBRRV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "758")]
		public LegacyCV2Result<None> YGYARLBFTFT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "759")]
		public LegacyCV2Result<None> XCQKUERSYUO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "760")]
		public LegacyCV2Result<None> UEMOLEEXWWW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "761")]
		public LegacyCV2Result<None> SRAKDEADQCK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "762")]
		public LegacyCV2Result<None> XHLXAXIFCLB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "763")]
		public LegacyCV2Result<None> XXZUDIHZWJT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "764")]
		public LegacyCV2Result<None> QDIEUNFCCTI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "771")]
		public LegacyCV2Result<None> PZPCRQKXMWG(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "772")]
		public LegacyCV2Result<None> YTIDHVUBLII(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "773")]
		public LegacyCV2Result<None> XMSOTFOEBEF(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(GDANQZHWFSQ ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "775")]
		public LegacyCV2Result<None> ZQFNTOSWJFB(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "776")]
		public LegacyCV2Result<None> KLDRZOQKSQJ(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "777")]
		public LegacyCV2Result<None> PXUHDIPSAUQ(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "778")]
		public LegacyCV2Result<None> SSHBSUCOOGQ(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "779")]
		public LegacyCV2Result<None> TTTTQOHETAK(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "707")]
		public LegacyCV2Result<None> FCRHKYAAXCG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "801")]
		public LegacyCV2Result<None> DPFEQKLHHCK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "802")]
		public LegacyCV2Result<None> PGULRHREPFI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "803")]
		public LegacyCV2Result<None> VTWEELTHFNU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "804")]
		public LegacyCV2Result<None> SLOPKVXZYJK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "805")]
		public LegacyCV2Result<None> UQKCYKGSDGC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "806")]
		public LegacyCV2Result<None> JTOAUCWSNBA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "807")]
		public LegacyCV2Result<None> VQTVAQQBNUW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "808")]
		public LegacyCV2Result<None> OURYVPOYTCU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "809")]
		public LegacyCV2Result<None> CCENBROIECG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "810")]
		public LegacyCV2Result<None> VKNSEQFUALE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "811")]
		public LegacyCV2Result<None> HUULKTTQEKA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "812")]
		public LegacyCV2Result<None> OKUWGCCAZML(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "817")]
		public LegacyCV2Result<None> YVGLYNJZUXG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "821")]
		public LegacyCV2Result<None> MLZDFSALSQH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "822")]
		public LegacyCV2Result<None> XKFKTXAWBQF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "823")]
		public LegacyCV2Result<None> UPWWYMSMFHD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "824")]
		public LegacyCV2Result<None> WQMVDCZBKZF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "826")]
		public LegacyCV2Result<None> EJHUNEJXOYL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "827")]
		public LegacyCV2Result<None> IGTEXRERKDG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "828")]
		public LegacyCV2Result<None> AOHMFVYRGKC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "831")]
		public LegacyCV2Result<None> DBBBSQIHPBU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "832")]
		public LegacyCV2Result<None> NBTZVOSASIL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "833")]
		public LegacyCV2Result<None> IBGWQYPAWAW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(GDANQZHWFSQ e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(GDANQZHWFSQ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "836")]
		public LegacyCV2Result<None> ERXLWBZBBSV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BTJVUDJWADF(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VXTFDMFLDCT(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WERYEDORYBU(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ATPXKJEYGOX(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NGYRGMFDUOU(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(GDANQZHWFSQ e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(GDANQZHWFSQ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(GDANQZHWFSQ e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(GDANQZHWFSQ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(GDANQZHWFSQ e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(GDANQZHWFSQ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(GDANQZHWFSQ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "856")]
		public LegacyCV2Result<None> IMJEMSKJWGV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "859")]
		public LegacyCV2Result<None> QOYAVFWLPVH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "860")]
		public LegacyCV2Result<None> LMXMSJTLFCH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "861")]
		public LegacyCV2Result<None> MSQRMNJDKOF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "862")]
		public LegacyCV2Result<None> INHTAYTROWM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "864")]
		public LegacyCV2Result<None> NIBUDABNWRL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "865")]
		public LegacyCV2Result<None> ZDFJIUZMRAZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(GDANQZHWFSQ e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "869")]
		public LegacyCV2Result<None> XZQGKLALZHJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "879")]
		public LegacyCV2Result<None> FIZEWYXKZMN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "880")]
		public LegacyCV2Result<None> KAUKYJEKWCZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "881")]
		public LegacyCV2Result<None> VSOUODRDQVC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "882")]
		public LegacyCV2Result<None> QINKXUZXGWR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(GDANQZHWFSQ e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(GDANQZHWFSQ e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(GDANQZHWFSQ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(GDANQZHWFSQ e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(GDANQZHWFSQ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "889")]
		public LegacyCV2Result<None> KNSCKFREYML(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "890")]
		public LegacyCV2Result<None> AZMCLEUJFWQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "891")]
		public LegacyCV2Result<None> FFGHKHKHUYD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "892")]
		public LegacyCV2Result<None> TYBTEAXRXWT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "893")]
		public LegacyCV2Result<None> XPRIZDACFAR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "897")]
		public LegacyCV2Result<None> RUUJYXYXJWC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "898")]
		public LegacyCV2Result<None> OWYOEYJENJI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "899")]
		public LegacyCV2Result<None> VMWLFGFFQGJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "901")]
		public LegacyCV2Result<None> BFIPJFQKNDX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "900")]
		public LegacyCV2Result<None> OZWUWMLDKDN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "902")]
		public LegacyCV2Result<None> QTCEMWAPHMO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "904")]
		public LegacyCV2Result<None> RCWWNVQEAFE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "903")]
		public LegacyCV2Result<None> QHBPZCIUMIC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "905")]
		public LegacyCV2Result<None> LHEMOJTUTSP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "906")]
		public LegacyCV2Result<None> WLOMEVOVKPF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "907")]
		public LegacyCV2Result<None> PZKUDESNMKQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "908")]
		public LegacyCV2Result<None> RRHLKQVVRXI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "909")]
		public LegacyCV2Result<None> LRAOAKXPMYI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "910")]
		public LegacyCV2Result<None> HZQDZQXMROQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "911")]
		public LegacyCV2Result<None> UEMFKRGUOYM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "918")]
		public LegacyCV2Result<None> ZJZCZRWCWAO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "919")]
		public LegacyCV2Result<None> VOJUTPSSHHS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(GDANQZHWFSQ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(GDANQZHWFSQ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(GDANQZHWFSQ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(GDANQZHWFSQ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(GDANQZHWFSQ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(GDANQZHWFSQ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(GDANQZHWFSQ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(GDANQZHWFSQ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(GDANQZHWFSQ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "941")]
		public LegacyCV2Result<None> GERVXOITEFI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "942")]
		public LegacyCV2Result<None> HPKGGSHHTRG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "943")]
		public LegacyCV2Result<None> ONDPXDVVAJN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "944")]
		public LegacyCV2Result<None> JBZGHGNBSLR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "945")]
		public LegacyCV2Result<None> DVTYFZZKABY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "946")]
		public LegacyCV2Result<None> PSTZXRWODPE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "947")]
		public LegacyCV2Result<None> IQNJQCIINRT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "948")]
		public LegacyCV2Result<None> VJZAGWYZSJB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "949")]
		public LegacyCV2Result<None> CDRHKHPFVGN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "950")]
		public LegacyCV2Result<None> EUSOTGDCLTG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "968")]
		public LegacyCV2Result<None> GEAQEUAOVFW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "967")]
		public LegacyCV2Result<None> IIJBNJXEOUD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "969")]
		public LegacyCV2Result<None> JZLZWFGBEKX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "970")]
		public LegacyCV2Result<None> IVQWPKASLHY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "971")]
		public LegacyCV2Result<None> MFCMXVXEWQT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "972")]
		public LegacyCV2Result<None> SHWIABJNLCB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "973")]
		public LegacyCV2Result<None> BXUAACZYUBE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "975")]
		public LegacyCV2Result<None> MLTLFZWHVXP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "982")]
		public LegacyCV2Result<None> BLLJDZSNMCE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "983")]
		public LegacyCV2Result<None> QRBXMNXTAFC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "991")]
		public LegacyCV2Result<None> ICYAFGUOFYH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "993")]
		public LegacyCV2Result<None> AZVZAEFOANR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "994")]
		public LegacyCV2Result<None> ZKRLZEWMGVP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "995")]
		public LegacyCV2Result<None> NBKOAWZYSKF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "996")]
		public LegacyCV2Result<None> SJYVJXGLRRV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "997")]
		public LegacyCV2Result<None> VGOKRTCDOND(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "998")]
		public LegacyCV2Result<None> ULWHPNIZPKZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "999")]
		public LegacyCV2Result<None> PJBFFPKZPAH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1000")]
		public LegacyCV2Result<None> ZTKTWRJCOXJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1001")]
		public LegacyCV2Result<None> UADBFGMMSYL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1002")]
		public LegacyCV2Result<None> HKZATBSKDKH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1009")]
		public LegacyCV2Result<None> SNLHFRSFKMT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1017")]
		public LegacyCV2Result<None> ZBTBVUAZXGS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1018")]
		public LegacyCV2Result<None> XMRLJYJBPDH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1019")]
		public LegacyCV2Result<None> SDYUNYDQEXI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1020")]
		public LegacyCV2Result<None> DFPWFQXTTHT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1021")]
		public LegacyCV2Result<None> ANGTALPPXCM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1022")]
		public LegacyCV2Result<None> KZXDKRCCNJT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1023")]
		public LegacyCV2Result<None> IIUMMDRBNUU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1024")]
		public LegacyCV2Result<None> IXKRKWWFWAE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1025")]
		public LegacyCV2Result<None> NCGMSMSOYIL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1026")]
		public LegacyCV2Result<None> YQEEAGHMRVA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1027")]
		public LegacyCV2Result<None> WTMIOODHCKM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1028")]
		public LegacyCV2Result<None> STBUPOZZZSF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1029")]
		public LegacyCV2Result<None> MMAURHYTVHR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1030")]
		public LegacyCV2Result<None> QHQOUFSULNG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1031")]
		public LegacyCV2Result<None> WSTZGZISMEH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1032")]
		public LegacyCV2Result<None> DHJLGMDTMYQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1033")]
		public LegacyCV2Result<None> JXDTQNZKVZS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1047")]
		public LegacyCV2Result<None> TZWPTPFXQTK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1048")]
		public LegacyCV2Result<None> EOPFETCPYSI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1049")]
		public LegacyCV2Result<None> EDWFLDGDBSK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1050")]
		public LegacyCV2Result<None> PWYELQUYSQG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1051")]
		public LegacyCV2Result<None> CSDILUSFAOT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1052")]
		public LegacyCV2Result<None> EMGBJHAJBBF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1053")]
		public LegacyCV2Result<None> QUNCDZZPTUS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1054")]
		public LegacyCV2Result<None> CXZWXCTJRZN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1055")]
		public LegacyCV2Result<None> YVGFONMVEWG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1056")]
		public LegacyCV2Result<None> WRGFXBTAFNP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1057")]
		public LegacyCV2Result<None> MHADEGOHZYP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1058")]
		public LegacyCV2Result<None> UQBNTWUFEKC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1059")]
		public LegacyCV2Result<None> SOJSQBEZAPT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1060")]
		public LegacyCV2Result<None> GCNOZEJINZV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1061")]
		public LegacyCV2Result<None> AISFEKJEYUP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1062")]
		public LegacyCV2Result<None> QLRESLQEBUH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1063")]
		public LegacyCV2Result<None> RQTVKNMQRAL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1064")]
		public LegacyCV2Result<None> XIASLZGUVTI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1065")]
		public LegacyCV2Result<None> HZWIQQCWOOS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1066")]
		public LegacyCV2Result<None> TKOFSOIPIQN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1067")]
		public LegacyCV2Result<None> WRMWFJWNLPH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1068")]
		public LegacyCV2Result<None> UTRLAUXRGDZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1069")]
		public LegacyCV2Result<None> YBGFFOWPRFF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1070")]
		public LegacyCV2Result<None> DUUMHNJJWGS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1071")]
		public LegacyCV2Result<None> PJDJWBWEZQO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x282E130", Offset = "0x282CD30", VA = "0x18282E130", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(GDANQZHWFSQ e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(GDANQZHWFSQ e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1092")]
		public LegacyCV2Result<None> TLPRHIXQQLZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1093")]
		public LegacyCV2Result<None> RAIGBGEGYVM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1094")]
		public LegacyCV2Result<None> HDDSLCXDMYK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1095")]
		public LegacyCV2Result<None> OIVYGAERBLM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1096")]
		public LegacyCV2Result<None> ILURANVTCHU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1097")]
		public LegacyCV2Result<None> BVZMOBJOJSS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1098")]
		public LegacyCV2Result<None> RQHNRYEWSCS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1099")]
		public LegacyCV2Result<None> WBSHVMNFPVO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1100")]
		public LegacyCV2Result<None> OCAYSRBJHSA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1101")]
		public LegacyCV2Result<None> NXAOMOQXZGE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1102")]
		public LegacyCV2Result<None> TXNNYNQFICE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1103")]
		public LegacyCV2Result<None> VDGGQAKRCFV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1104")]
		public LegacyCV2Result<None> YSKRAPPXHOT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1105")]
		public LegacyCV2Result<None> KAQXBFDWNXN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1106")]
		public LegacyCV2Result<None> MAKUYKJGYAD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1107")]
		public LegacyCV2Result<None> XFQAHUSTXZE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1108")]
		public LegacyCV2Result<None> SXAKSJWVBBI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1109")]
		public LegacyCV2Result<None> XPZWFLTCVPD(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1110")]
		public LegacyCV2Result<None> BNAVMPRHQEZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1111")]
		public LegacyCV2Result<None> PKANGYKTPFJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1112")]
		public LegacyCV2Result<None> YXENOIJAWJJ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1113")]
		public LegacyCV2Result<None> EAVDWAKIXLE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1114")]
		public LegacyCV2Result<None> HBSSVHMMFQO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1115")]
		public LegacyCV2Result<None> ZLIUZSDAOQX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1116")]
		public LegacyCV2Result<None> OMHYSJUGABR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1117")]
		public LegacyCV2Result<None> UMZMIFXPBMT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1118")]
		public LegacyCV2Result<None> SBKRLVRRWHV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1119")]
		public LegacyCV2Result<None> AAJYXSRETLU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1120")]
		public LegacyCV2Result<None> UKPESHICXXN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1121")]
		public LegacyCV2Result<None> WYCUSUORXSN(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1122")]
		public LegacyCV2Result<None> UNCNGNQIDXH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1123")]
		public LegacyCV2Result<None> XGKKGITQFZC(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1124")]
		public LegacyCV2Result<None> QLMWATHYXKE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1125")]
		public LegacyCV2Result<None> WDUXNGGXBHU(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1126")]
		public LegacyCV2Result<None> ARMZGWPIPEG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1127")]
		public LegacyCV2Result<None> VMUWKDHIOYY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1128")]
		public LegacyCV2Result<None> ZGBVSSLJUHW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1129")]
		public LegacyCV2Result<None> PRGFFSVYKUI(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1130")]
		public LegacyCV2Result<None> EOIDELXFFDH(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1131")]
		public LegacyCV2Result<None> KKKQSTMVEBI(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1132")]
		public LegacyCV2Result<None> TJTUPYSWJIJ(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1133")]
		public LegacyCV2Result<None> VTZIGRJOZFY(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1134")]
		public LegacyCV2Result<None> NKSGUSXKWEK(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1135")]
		public LegacyCV2Result<None> AYCILURGDRT(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1136")]
		public LegacyCV2Result<None> NURCQSXJAGN(UZNSAHKLUZD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1140")]
		public LegacyCV2Result<None> SHETNQTXDGL(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1166")]
		public LegacyCV2Result<None> QPTODUWMZWF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1168")]
		public LegacyCV2Result<None> WMHKBRCIJUN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1169")]
		public LegacyCV2Result<None> EYFLZRAUPYU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1170")]
		public LegacyCV2Result<None> URNJNRTWBZZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1171")]
		public LegacyCV2Result<None> AVXROBBCEUS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1182")]
		public LegacyCV2Result<None> USSDDDROIJY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1183")]
		public LegacyCV2Result<None> MGWBRHGROIK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1184")]
		public LegacyCV2Result<None> AOWEBCRJUSI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1185")]
		public LegacyCV2Result<None> EICIRKPMZSM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1186")]
		public LegacyCV2Result<None> LJPUZPCYAST(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1187")]
		public LegacyCV2Result<None> ATRZUOQPENH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1188")]
		public LegacyCV2Result<None> UNAEYDTGETH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1189")]
		public LegacyCV2Result<None> FCXIIHMYGHR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1190")]
		public LegacyCV2Result<None> QCYGTVDFGUK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1191")]
		public LegacyCV2Result<None> UNHMGXCXQBE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1192")]
		public LegacyCV2Result<None> CTIJQUXUUTX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1193")]
		public LegacyCV2Result<None> ISNFWNGETNA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "184")]
		public LegacyCV2Result<None> YTBBMIZTINW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x282E200", Offset = "0x282CE00", VA = "0x18282E200", Slot = "191")]
		public bool QOUNKZSJVTM(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1194")]
		public LegacyCV2Result<None> JHVXBILGYIW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1195")]
		public LegacyCV2Result<None> ESXDMAGRWYZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1196")]
		public LegacyCV2Result<None> VHAMWEFYRAK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(GDANQZHWFSQ e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1205")]
		public LegacyCV2Result<None> HTAGPAGCOMP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1206")]
		public LegacyCV2Result<None> HJWFFRENCKH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(GDANQZHWFSQ e, InOut io, DGVKWTHBMEX objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "250")]
		public LegacyCV2Result<None> SSMATJDBHKO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "251")]
		public LegacyCV2Result<None> CNVASDYUWVM(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "252")]
		public LegacyCV2Result<None> GVADUVWCRKK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "254")]
		public LegacyCV2Result<None> RMTSUDYKTXF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "255")]
		public LegacyCV2Result<None> PXKXUNUIJYV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "256")]
		public LegacyCV2Result<None> UKYPHJLSWOB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "257")]
		public LegacyCV2Result<None> BYIABSKIKVY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "258")]
		public LegacyCV2Result<None> LLLNFPWMGMW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "259")]
		public LegacyCV2Result<None> HLLMAUOYWHF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "260")]
		public LegacyCV2Result<None> TJEDIOXBINF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "261")]
		public LegacyCV2Result<None> XZHWOWKUTWR(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "262")]
		public LegacyCV2Result<None> RWFDCWVALYB(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "263")]
		public LegacyCV2Result<None> TPOUJTUSZHY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "264")]
		public LegacyCV2Result<None> SWQKLMLFUTQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "265")]
		public LegacyCV2Result<None> NNCSRTOYXVA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "266")]
		public LegacyCV2Result<None> NUTFFPOOHEY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "267")]
		public LegacyCV2Result<None> OFOBQRYYMQY(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "268")]
		public LegacyCV2Result<None> RYKRMDXRKZU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "269")]
		public LegacyCV2Result<None> WECGWZERUGO(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20")]
		private static LegacyCV2Result<None> Default(GDANQZHWFSQ e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x282E170", Offset = "0x282CD70", VA = "0x18282E170", Slot = "1209")]
		public LegacyCV2Result<None> LOWHVHKHVMN(GDANQZHWFSQ a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1212")]
		public LegacyCV2Result<None> UXGDNORQAVK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1213")]
		public LegacyCV2Result<None> FECKIELSMMW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1214")]
		public LegacyCV2Result<None> CTMWWBEOQAA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1215")]
		public LegacyCV2Result<None> YAOTYPHDNAN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(GDANQZHWFSQ e, InOut io, FCPCSVOXWBD quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1036")]
		public LegacyCV2Result<None> VAGSZUYLHJA(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1037")]
		public LegacyCV2Result<None> PHVVBBOSXBU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1038")]
		public LegacyCV2Result<None> RMCEXJRFWBE(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1039")]
		public LegacyCV2Result<None> TQLSDHHJLGS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1040")]
		public LegacyCV2Result<None> KVKKUSPIEHK(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1041")]
		public LegacyCV2Result<None> QMNVAYYTCWI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1042")]
		public LegacyCV2Result<None> TFXRWJHEFES(GDANQZHWFSQ a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1043")]
		public LegacyCV2Result<None> SCCANFTUBHS(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1044")]
		public LegacyCV2Result<None> ABRLYJRZOEQ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1045")]
		public LegacyCV2Result<None> TQABVTOBAYH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1046")]
		public LegacyCV2Result<None> CJDCOISRTVF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BPNZGJURPLX(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1234")]
		public LegacyCV2Result<None> CQDHSCZIKHC(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1236")]
		public LegacyCV2Result<None> HOILQMDFOCH(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1229")]
		public LegacyCV2Result<None> JNRLXUUFOKX(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1241")]
		public LegacyCV2Result<None> BOGSRXOTBGN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1242")]
		public LegacyCV2Result<None> XNZUEOKXNRG(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1243")]
		public LegacyCV2Result<None> FXFJFEQEKTW(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1244")]
		public LegacyCV2Result<None> PNIJKRVTCUI(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1245")]
		public LegacyCV2Result<None> WZNUGAPWTIN(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BFNIEDWXQVD(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TYJRWBINDMN(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PUFUIKWKEJD(GDANQZHWFSQ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1259")]
		public LegacyCV2Result<None> BYDCJDQADRZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1260")]
		public LegacyCV2Result<None> TMBGIUXIHUV(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1261")]
		public LegacyCV2Result<None> MNLWLPAIORT(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1262")]
		public LegacyCV2Result<None> YPBLRVGTOPF(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x282E250", Offset = "0x282CE50", VA = "0x18282E250")]
		public MXOSJDQETHC([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(GDANQZHWFSQ e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1280")]
		public LegacyCV2Result<None> ANUMHVAOEUU(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1281")]
		public LegacyCV2Result<None> GKKUEGSRJDP(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "599")]
		public LegacyCV2Result<None> FJUUQZZWVUZ(GDANQZHWFSQ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1293")]
		public LegacyCV2Result<None> ACAJAYOSOVU(UZNSAHKLUZD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1294")]
		public LegacyCV2Result<None> XYFSLRVJHSF(UZNSAHKLUZD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1295")]
		public LegacyCV2Result<None> BYASYICSSAK(UZNSAHKLUZD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1296")]
		public LegacyCV2Result<None> KLASKEIXEOW(UZNSAHKLUZD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1297")]
		public LegacyCV2Result<None> WWAGZABKUIV(UZNSAHKLUZD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20")]
		public LegacyCV2Result<None> ConstantStorefrontItem(GDANQZHWFSQ e, InOut io, [In] ODCCAUUXMTW storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(GDANQZHWFSQ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> AYYFFMXYFBT(GDANQZHWFSQ a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, UPVZZKQNRST.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> UKNBEKMYHEH(GDANQZHWFSQ a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, UPVZZKQNRST.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1207")]
		private LegacyCV2Result<None> JTMIFISASHK(GDANQZHWFSQ a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1216")]
		private LegacyCV2Result<None> PZTYQZRMWID(GDANQZHWFSQ a, InOut b, [In] ODCCAUUXMTW storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20", Slot = "1257")]
		private LegacyCV2Result<None> JHKGFYOCUTL(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class JDUHIORFKNH : PSLOADIYRZA
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(DFJINRJWSWZ node);

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly JDUHIORFKNH IKMGYQWAVIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate MCYFKPYCJHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate ZFVRUUHQOOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool DYADUKRCDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private bool GIEWELHNBRK;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2837170", Offset = "0x2835D70", VA = "0x182837170", Slot = "4")]
		public Task<bool> LXQUWDUVFCP(DFJINRJWSWZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x2838940", Offset = "0x2837540", VA = "0x182838940", Slot = "5")]
		public Task<bool> TADHSAETBXY(DFJINRJWSWZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2838A10", Offset = "0x2837610", VA = "0x182838A10")]
		public JDUHIORFKNH([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2838970", Offset = "0x2837570", VA = "0x182838970", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? ZMKVNDKXLEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xA988B0", Offset = "0xA974B0", VA = "0x180A988B0", Slot = "7")]
		public bool LAFIHKCSQFO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x12DA6F0", Offset = "0x12D92F0", VA = "0x1812DA6F0", Slot = "8")]
		public bool YFDCZKDGGIU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class LKQOANESNGH : DILBABXUXES
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid FDVLLCPKZUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xBB0FE0", Offset = "0xBAFBE0", VA = "0x180BB0FE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
		public void Bind(NPCWSWFFONK pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xE0C7B0", Offset = "0xE0B3B0", VA = "0x180E0C7B0")]
		public LKQOANESNGH(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2838F80", Offset = "0x2837B80", VA = "0x182838F80")]
		public static LKQOANESNGH New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class SFKBRFXOMAN : JEXXETQFPCN
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<KMTSZWWZJTI> nodeDefId, Id128<LJKQDQDPBOO>? legacyInnerGraphId, IReadOnlyDictionary<Id128<LJKQDQDPBOO>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private IsNodeRestrictedDelegate? JJSNAKAYTKC;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool PGTNZBDJFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAE9750", Offset = "0xAE8350", VA = "0x180AE9750", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UGCZGVYOQLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x283A0B0", Offset = "0x2838CB0", VA = "0x18283A0B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool MYIGAOTYUMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xF97D10", Offset = "0xF96910", VA = "0x180F97D10", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "6")]
		public bool CYEQIQLTWDY(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "7")]
		public CanSaveObjectIntoInventionResultType UFPVZGPHKWD(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x283A060", Offset = "0x2838C60", VA = "0x18283A060", Slot = "8")]
		public bool LUOEQBHFMVA(Id128<KMTSZWWZJTI> nodeDefId, Id128<LJKQDQDPBOO>? legacyInnerGraphId, IReadOnlyDictionary<Id128<LJKQDQDPBOO>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "9")]
		public bool IKTVPVDSFOB(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "10")]
		public bool BVRTQSSQKEF(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x283A0C0", Offset = "0x2838CC0", VA = "0x18283A0C0")]
		public SFKBRFXOMAN(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class DIEYCNVNPBL : ZHXCQEBWJJM
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly DIEYCNVNPBL IKMGYQWAVIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventSenderToMakerPenDelegate GIXXARAJMJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate NYQGCDDQOGZ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FVUBWGVMTZT
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0xFB7AB0", Offset = "0xFB66B0", VA = "0x180FB7AB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool RCCWLSCARHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x2834FD0", Offset = "0x2833BD0", VA = "0x182834FD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x2835070", Offset = "0x2833C70", VA = "0x182835070")]
		public DIEYCNVNPBL([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class RGUQIIGVWKZ : GOBWESELGYH<NWNCJNHUMKH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class MGNXZWAPKQO : NWNCJNHUMKH, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly MGNXZWAPKQO PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool NKEZNUYAGGQ
			{
				[Cpp2IlInjected.Token(Token = "0x600075E")]
				[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2838FE0", Offset = "0x2837BE0", VA = "0x182838FE0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			public void AGOXQMNLUBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MGNXZWAPKQO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly RGUQIIGVWKZ PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private RGUQIIGVWKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2839DC0", Offset = "0x28389C0", VA = "0x182839DC0", Slot = "4")]
		public NWNCJNHUMKH UCKUBDUZFPI()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class TDIMPNVDIIZ<a, b> : IDisposable, LYKTLMTPRMI where a : notnull where b : notnull, CLSPQGSQHLJ.LGJNITTFOIP<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly b GSCBNDREEJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly a JALSKXMEXLG;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<VXOAABITZCX> PNPKCJIEICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<VXOAABITZCX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x579F800", Offset = "0x579E400", VA = "0x18579F800")]
		public TDIMPNVDIIZ(b a, a b, Id32<VXOAABITZCX> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x5E16ED0", Offset = "0x5E15AD0", VA = "0x185E16ED0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x5E16C00", Offset = "0x5E15800", VA = "0x185E16C00")]
		public Id32<KJUTVDVUHQM> BROFAMAUDON([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<KJUTVDVUHQM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x5E17B20", Offset = "0x5E16720", VA = "0x185E17B20", Slot = "6")]
		public void QODAQMFCCLU(Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x5E18460", Offset = "0x5E17060", VA = "0x185E18460", Slot = "7")]
		public void SLWIPBHXRGU(Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x5E18160", Offset = "0x5E16D60", VA = "0x185E18160", Slot = "8")]
		public void RGWAHLQYUDX(Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x5E17350", Offset = "0x5E15F50", VA = "0x185E17350", Slot = "10")]
		public void JOWKKNPQVLM(Id32<KJUTVDVUHQM> objectId, Id32<VXOAABITZCX> clientId, TWKJOSGKHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x5E16C60", Offset = "0x5E15860", VA = "0x185E16C60", Slot = "9")]
		public void DXRPSLBIQDK(Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x5E17880", Offset = "0x5E16480", VA = "0x185E17880", Slot = "11")]
		public void OBJELSJPHLI(Id32<KJUTVDVUHQM> objectId, SBXFSVIVCAZ? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x5E184A0", Offset = "0x5E170A0", VA = "0x185E184A0", Slot = "12")]
		public Id32<VXOAABITZCX> TZALTPGNUHH(Id32<KJUTVDVUHQM> objectId)
		{
			return default(Id32<VXOAABITZCX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x5E17390", Offset = "0x5E15F90", VA = "0x185E17390", Slot = "13")]
		public Id32<DUXMLVOEJNS> MPQDZMDDJZR(Id32<KJUTVDVUHQM> objectId, string a, object b, bool c, SIQXSFHKWGE d, BKIBIFOYVUI e)
		{
			return default(Id32<DUXMLVOEJNS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x5E178C0", Offset = "0x5E164C0", VA = "0x185E178C0", Slot = "14")]
		public void OMWFCVXXKLT(Id32<DUXMLVOEJNS> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x5E187E0", Offset = "0x5E173E0", VA = "0x185E187E0", Slot = "15")]
		public void XUAYHYMZCRT(Id32<DUXMLVOEJNS> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class CLSPQGSQHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface LGJNITTFOIP<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void OYXSXEKJXSD(a a, Id32<VXOAABITZCX> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<VXOAABITZCX>? HVTCCPHAJYU(a a);

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<KJUTVDVUHQM> BROFAMAUDON(a a, Id32<VXOAABITZCX> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void QODAQMFCCLU(a a, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ b);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void SLWIPBHXRGU(a a, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void JOWKKNPQVLM(a a, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void DXRPSLBIQDK(a a, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void OBJELSJPHLI(a a, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, SBXFSVIVCAZ? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<VXOAABITZCX>? TZALTPGNUHH(a a, Id32<KJUTVDVUHQM> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<DUXMLVOEJNS> MPQDZMDDJZR(a a, Id32<VXOAABITZCX> clientId, string b, object c, SIQXSFHKWGE d, BKIBIFOYVUI e);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void OMWFCVXXKLT(a a, Id32<VXOAABITZCX> clientId, Id32<DUXMLVOEJNS> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void XUAYHYMZCRT(a a, Id32<VXOAABITZCX> clientId, Id32<DUXMLVOEJNS> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class DZOBRVOVLCD
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public readonly HashSet<Id32<KJUTVDVUHQM>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public SOAId32Field<DUXMLVOEJNS, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly Dictionary<Id32<DUXMLVOEJNS>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<DUXMLVOEJNS>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public SOAField<KJUTVDVUHQM, SBXFSVIVCAZ?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x28398A0", Offset = "0x28384A0", VA = "0x1828398A0")]
			private MockCV2DynamicNetSys(HashSet<Id32<KJUTVDVUHQM>> authorityOf, [In] SOAId32Field<DUXMLVOEJNS, MockCV2SyncField> syncFields, Dictionary<Id32<DUXMLVOEJNS>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<DUXMLVOEJNS>> mockSyncFieldToSyncField, [In] SOAField<KJUTVDVUHQM, SBXFSVIVCAZ?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x28396E0", Offset = "0x28382E0", VA = "0x1828396E0")]
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
			public Id32<VXOAABITZCX>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2839940", Offset = "0x2838540", VA = "0x182839940")]
			public MockCV2ObjectShared(Id32<VXOAABITZCX> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public BKIBIFOYVUI SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public SIQXSFHKWGE SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
			internal MockCV2SyncField(BKIBIFOYVUI syncField, SIQXSFHKWGE syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2839A60", Offset = "0x2838660", VA = "0x182839A60")]
			public static MockCV2SyncField New(BKIBIFOYVUI syncField, SIQXSFHKWGE syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x2839A10", Offset = "0x2838610", VA = "0x182839A10")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x28399C0", Offset = "0x28385C0", VA = "0x1828399C0")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private SOAId32Field<KJUTVDVUHQM, MockCV2ObjectShared> TLWHOWMVXTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<KJUTVDVUHQM>> SXEBYILDZOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> AUEFNXVHPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> HACUOTBJQOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAField<VXOAABITZCX, MockCV2DynamicNetSys> LAAAFPQJALW;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<KJUTVDVUHQM>? RUKIOEEMSSE
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0xB82670", Offset = "0xB81270", VA = "0x180B82670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0xF6C6A0", Offset = "0xF6B2A0", VA = "0x180F6C6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x2835900", Offset = "0x2834500", VA = "0x182835900")]
		public void Destroy([In] SOAId32<VXOAABITZCX> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2835B40", Offset = "0x2834740", VA = "0x182835B40")]
		public void JFJCCTMXIBD(Id32<VXOAABITZCX> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2836560", Offset = "0x2835160", VA = "0x182836560")]
		public void OYXSXEKJXSD(Id32<VXOAABITZCX> clientId, Id32<VXOAABITZCX>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2835370", Offset = "0x2833F70", VA = "0x182835370")]
		public Id32<KJUTVDVUHQM> BROFAMAUDON(Id32<VXOAABITZCX> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<VXOAABITZCX> clientIds)
		{
			return default(Id32<KJUTVDVUHQM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x28360A0", Offset = "0x2834CA0", VA = "0x1828360A0")]
		public Id32<DUXMLVOEJNS> MPQDZMDDJZR(Id32<VXOAABITZCX> clientId, string a, object b, SIQXSFHKWGE c, BKIBIFOYVUI d)
		{
			return default(Id32<DUXMLVOEJNS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x28363D0", Offset = "0x2834FD0", VA = "0x1828363D0")]
		public void OMWFCVXXKLT(Id32<VXOAABITZCX> clientId, Id32<DUXMLVOEJNS> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2836AB0", Offset = "0x28356B0", VA = "0x182836AB0")]
		public Id32<KJUTVDVUHQM>? VIDPXEVKQWM([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x28368A0", Offset = "0x28354A0", VA = "0x1828368A0")]
		public void QODAQMFCCLU([In] SOAId32<VXOAABITZCX> clientIds, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2836920", Offset = "0x2835520", VA = "0x182836920")]
		public void SLWIPBHXRGU(Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2835FA0", Offset = "0x2834BA0", VA = "0x182835FA0")]
		public void JOWKKNPQVLM(Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2835780", Offset = "0x2834380", VA = "0x182835780")]
		public void DXRPSLBIQDK([In] SOAId32<VXOAABITZCX> clientIds, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2836300", Offset = "0x2834F00", VA = "0x182836300")]
		public void OBJELSJPHLI(Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, SBXFSVIVCAZ? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2836A60", Offset = "0x2835660", VA = "0x182836A60")]
		public Id32<VXOAABITZCX>? TZALTPGNUHH(Id32<KJUTVDVUHQM> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2836B80", Offset = "0x2835780", VA = "0x182836B80")]
		public void XUAYHYMZCRT([In] SOAId32<VXOAABITZCX> clientIds, Id32<VXOAABITZCX> clientId, Id32<DUXMLVOEJNS> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2836EF0", Offset = "0x2835AF0", VA = "0x182836EF0")]
		public DZOBRVOVLCD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class CBTWWESHOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x2834F70", Offset = "0x2833B70", VA = "0x182834F70")]
		public static void Destroy(this DZOBRVOVLCD.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class HZXUXMRXZJK : CQCWMALDTKQ.HGULJDEHQOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static HZXUXMRXZJK QFXOBKJRLJP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate YAGFKRCLGYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate GWIIIQYULWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xA99D10", Offset = "0xA98910", VA = "0x180A99D10")]
		public HZXUXMRXZJK(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class VDJIRLLJMFS : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : BFACBNGTTJL.ZGIMNPCIEIW<NOYQGYRQTEZ, VDJIRLLJMFS>
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
				public AsyncTaskMethodBuilder<Result<object, GGHDNJMZMXZ>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public VDJIRLLJMFS root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public Id32<VXOAABITZCX> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public NOYQGYRQTEZ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				private TaskAwaiter<Result<object, GGHDNJMZMXZ>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007A8")]
				[Cpp2IlInjected.Address(RVA = "0x283C130", Offset = "0x283AD30", VA = "0x18283C130", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A9")]
				[Cpp2IlInjected.Address(RVA = "0x283C370", Offset = "0x283AF70", VA = "0x18283C370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "4")]
			public int ATYYUNSMBGE(VDJIRLLJMFS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x283A040", Offset = "0x2838C40", VA = "0x18283A040", Slot = "5")]
			public int WDKMPPXLGGY(VDJIRLLJMFS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x2839E80", Offset = "0x2838A80", VA = "0x182839E80", Slot = "6")]
			public int IIDQNLBXFRF(VDJIRLLJMFS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xC721C0", Offset = "0xC70DC0", VA = "0x180C721C0", Slot = "7")]
			public int GUZGQOYBNXF(VDJIRLLJMFS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2839FF0", Offset = "0x2838BF0", VA = "0x182839FF0", Slot = "8")]
			public void QAIXRDFEKBU(VDJIRLLJMFS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "9")]
			public bool XYXZOUVUBGH(VDJIRLLJMFS a, Id32<VXOAABITZCX> actorId, NOYQGYRQTEZ[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "10")]
			public bool GHBKDHYPXSF(VDJIRLLJMFS a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2839EA0", Offset = "0x2838AA0", VA = "0x182839EA0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(VDJIRLLJMFS a, Id32<VXOAABITZCX> senderId, NOYQGYRQTEZ b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : BFACBNGTTJL.LGUBDHHAHFH<ActionDeps, TGMYLJQNIMW.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps UXRPJJYGSOT
			{
				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public TGMYLJQNIMW.StaticNetSysReceiverDeps SQUTMCRJUCQ
			{
				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "5")]
				get
				{
					return default(TGMYLJQNIMW.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps HGEEJBTONKJ
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : GHZGZDSJPWP.LGJNITTFOIP<VDJIRLLJMFS>
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
				public AsyncTaskMethodBuilder<Result<object?, GGHDNJMZMXZ>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public VDJIRLLJMFS root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public Id32<VXOAABITZCX> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public NOYQGYRQTEZ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				private TaskAwaiter<Result<object?, GGHDNJMZMXZ>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0x283BE10", Offset = "0x283AA10", VA = "0x18283BE10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AF")]
				[Cpp2IlInjected.Address(RVA = "0x283C0C0", Offset = "0x283ACC0", VA = "0x18283C0C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x2839AA0", Offset = "0x28386A0", VA = "0x182839AA0", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(VDJIRLLJMFS a, Id32<VXOAABITZCX> clientId, NOYQGYRQTEZ b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : CLSPQGSQHLJ.LGJNITTFOIP<VDJIRLLJMFS>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x2839430", Offset = "0x2838030", VA = "0x182839430", Slot = "4")]
			public void OYXSXEKJXSD(VDJIRLLJMFS a, Id32<VXOAABITZCX> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xC72300", Offset = "0xC70F00", VA = "0x180C72300", Slot = "5")]
			public Id32<VXOAABITZCX>? HVTCCPHAJYU(VDJIRLLJMFS a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2839080", Offset = "0x2837C80", VA = "0x182839080")]
			public Id32<KJUTVDVUHQM> BROFAMAUDON(VDJIRLLJMFS a, Id32<VXOAABITZCX> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<KJUTVDVUHQM>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x2839460", Offset = "0x2838060", VA = "0x182839460", Slot = "7")]
			public void QODAQMFCCLU(VDJIRLLJMFS a, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x28394F0", Offset = "0x28380F0", VA = "0x1828394F0", Slot = "8")]
			public void SLWIPBHXRGU(VDJIRLLJMFS a, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2839110", Offset = "0x2837D10", VA = "0x182839110", Slot = "9")]
			public void JOWKKNPQVLM(VDJIRLLJMFS a, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x28390E0", Offset = "0x2837CE0", VA = "0x1828390E0", Slot = "10")]
			public void DXRPSLBIQDK(VDJIRLLJMFS a, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, TWKJOSGKHLZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x28391B0", Offset = "0x2837DB0", VA = "0x1828391B0", Slot = "11")]
			public void OBJELSJPHLI(VDJIRLLJMFS a, Id32<VXOAABITZCX> clientId, Id32<KJUTVDVUHQM> objectId, SBXFSVIVCAZ? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2839650", Offset = "0x2838250", VA = "0x182839650", Slot = "12")]
			public Id32<VXOAABITZCX>? TZALTPGNUHH(VDJIRLLJMFS a, Id32<KJUTVDVUHQM> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x2839150", Offset = "0x2837D50", VA = "0x182839150", Slot = "13")]
			public Id32<DUXMLVOEJNS> MPQDZMDDJZR(VDJIRLLJMFS a, Id32<VXOAABITZCX> clientId, string b, object c, SIQXSFHKWGE d, BKIBIFOYVUI e)
			{
				return default(Id32<DUXMLVOEJNS>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x2839290", Offset = "0x2837E90", VA = "0x182839290", Slot = "14")]
			public void OMWFCVXXKLT(VDJIRLLJMFS a, Id32<VXOAABITZCX> clientId, Id32<DUXMLVOEJNS> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x28396B0", Offset = "0x28382B0", VA = "0x1828396B0", Slot = "15")]
			public void XUAYHYMZCRT(VDJIRLLJMFS a, Id32<VXOAABITZCX> clientId, Id32<DUXMLVOEJNS> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2839080", Offset = "0x2837C80", VA = "0x182839080", Slot = "6")]
			private Id32<KJUTVDVUHQM> VSGOJFRNBIX(VDJIRLLJMFS a, Id32<VXOAABITZCX> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<KJUTVDVUHQM>);
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
			public VDJIRLLJMFS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public Id32<KJUTVDVUHQM>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public JDXRPHKCJUL deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private Id32<VXOAABITZCX> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private NSRRADRIHLT<VDJIRLLJMFS, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private TDIMPNVDIIZ<VDJIRLLJMFS, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private TGMYLJQNIMW <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x283B750", Offset = "0x283A350", VA = "0x18283B750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x283BDA0", Offset = "0x283A9A0", VA = "0x18283BDA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly OMMXYTJGNHV<NOYQGYRQTEZ, None, TGMYLJQNIMW, ActionDeps, TGMYLJQNIMW.StaticNetSysReceiverDeps, RootDeps, VDJIRLLJMFS, Deps> NDVAUNYVGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly DZOBRVOVLCD WBYGEUPBKKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAId32<VXOAABITZCX> TBFKTJOIXGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<VXOAABITZCX, None> LAAAFPQJALW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAField<VXOAABITZCX, TGMYLJQNIMW> NHHILXGFGRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Id32<VXOAABITZCX>? IVCITQZMDLD;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate YYZUUYHWIEB
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xA9EA20", Offset = "0xA9D620", VA = "0x180A9EA20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x283D8D0", Offset = "0x283C4D0", VA = "0x18283D8D0")]
		public VDJIRLLJMFS(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x283D210", Offset = "0x283BE10", VA = "0x18283D210", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x283D4C0", Offset = "0x283C0C0", VA = "0x18283D4C0")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> JFJCCTMXIBD(JDXRPHKCJUL a, RegistryV2 b, Id32<KJUTVDVUHQM>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x283D640", Offset = "0x283C240", VA = "0x18283D640")]
		private void OYXSXEKJXSD(Id32<VXOAABITZCX> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x283D3E0", Offset = "0x283BFE0", VA = "0x18283D3E0")]
		[CompilerGenerated]
		private Id32<KJUTVDVUHQM>? IPVQOSMKFQD([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class JPRHYOZDUXT : QISMRYAGOIJ.HGULJDEHQOI
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<KXFAEZWOJNS> DeserializeCircuitsJunctionAsyncDelegate(TGMYLJQNIMW circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<KXFAEZWOJNS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public JPRHYOZDUXT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public TGMYLJQNIMW circuitsManager;

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
			private TaskAwaiter<KXFAEZWOJNS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x283A440", Offset = "0x2839040", VA = "0x18283A440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x283A640", Offset = "0x2839240", VA = "0x18283A640", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate PPMFPEYQSES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleDidInitializeDelegate? EODREIRXOLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly LifecycleWillDestroyDelegate? ROICINKZUKZ;

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x2838C20", Offset = "0x2837820", VA = "0x182838C20", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<KXFAEZWOJNS> UOEZSXHFMZT(TGMYLJQNIMW a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
		public void JIQQOUSOOEH(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xCEC8D0", Offset = "0xCEB4D0", VA = "0x180CEC8D0", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xDAD930", Offset = "0xDAC530", VA = "0x180DAD930", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x2838D90", Offset = "0x2837990", VA = "0x182838D90")]
		public JPRHYOZDUXT([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class HXDSMWLWVSF : MIRQTXIQXPT.HGULJDEHQOI
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate ZFOPNMGJHIN GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<SMVRVTIYCJZ> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<OHPGYSJVQRZ> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<MIRQTXIQXPT.HGULJDEHQOI.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<MIRQTXIQXPT.HGULJDEHQOI.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public HXDSMWLWVSF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			private TaskAwaiter<MIRQTXIQXPT.HGULJDEHQOI.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x283A6B0", Offset = "0x28392B0", VA = "0x18283A6B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x283A8A0", Offset = "0x28394A0", VA = "0x18283A8A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<OHPGYSJVQRZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public HXDSMWLWVSF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private TaskAwaiter<OHPGYSJVQRZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x283A910", Offset = "0x2839510", VA = "0x18283A910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x283AB00", Offset = "0x2839700", VA = "0x18283AB00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<SMVRVTIYCJZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public HXDSMWLWVSF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			private TaskAwaiter<SMVRVTIYCJZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x283AB70", Offset = "0x2839770", VA = "0x18283AB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x283AD60", Offset = "0x2839960", VA = "0x18283AD60", Slot = "5")]
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
			public HXDSMWLWVSF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x283ADD0", Offset = "0x28399D0", VA = "0x18283ADD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x283AFC0", Offset = "0x2839BC0", VA = "0x18283AFC0", Slot = "5")]
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
			public HXDSMWLWVSF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x283B030", Offset = "0x2839C30", VA = "0x18283B030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x283B220", Offset = "0x2839E20", VA = "0x18283B220", Slot = "5")]
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
			public HXDSMWLWVSF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x283B290", Offset = "0x2839E90", VA = "0x18283B290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x283B480", Offset = "0x283A080", VA = "0x18283B480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetCV2DependenciesDelegate WBOLDOZIDSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetRoomDataAsyncDelegate PQJUXABIQOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetSuperRoomDataAsyncDelegate GXSFQXYSUSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomAssetDataAsyncDelegate YKEXYQBZQLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetPlayerSaveDataAsyncDelegate YHXTBQVSBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate CGPLGGTMFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetStaticCircuitsConfigAsyncDelegate GTXKIABYBGX;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public ZFOPNMGJHIN ZFOPNMGJHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0xFB7AB0", Offset = "0xFB66B0", VA = "0x180FB7AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x28375F0", Offset = "0x28361F0", VA = "0x1828375F0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> FAALIAJREZA(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2837810", Offset = "0x2836410", VA = "0x182837810", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> NLJRMBWTXMJ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2837B40", Offset = "0x2836740", VA = "0x182837B40", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<SMVRVTIYCJZ> WQTDHIPMVFY(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2837700", Offset = "0x2836300", VA = "0x182837700", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<OHPGYSJVQRZ> KFHXCHDSRZF(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2837A30", Offset = "0x2836630", VA = "0x182837A30", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<MIRQTXIQXPT.HGULJDEHQOI.CircuitGraphToolMapping> SZZIRRKBGZS(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2837920", Offset = "0x2836520", VA = "0x182837920", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> PHDJXXKGTFZ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2837C50", Offset = "0x2836850", VA = "0x182837C50")]
		public HXDSMWLWVSF(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class IGIMYIHRLWR : CV2Request.HGULJDEHQOI
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly CV2Request.HGULJDEHQOI PGFSJHGESKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly GetCanSendRequestsDelegate KZQTEADQPJT;

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public IGIMYIHRLWR(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xFB7AB0", Offset = "0xFB66B0", VA = "0x180FB7AB0", Slot = "4")]
		public bool RDHVPYBFYTH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class NVRFSAZPTHE : RAIVYTHKDKV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, JGLGQAAJYUN> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly TryReportErrToUserDelegate JRSRKDVBVXR;

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x2837170", Offset = "0x2835D70", VA = "0x182837170")]
		public bool VPTYLUDEELZ([In] Result<None, JGLGQAAJYUN> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x2839C00", Offset = "0x2838800", VA = "0x182839C00")]
		public NVRFSAZPTHE([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2837170", Offset = "0x2835D70", VA = "0x182837170", Slot = "4")]
		private bool OAMCXGMHYOU([In] Result<None, JGLGQAAJYUN> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class YHYDODNVHPR : VUZSBPVGYXW
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate GDANQZHWFSQ CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static readonly YHYDODNVHPR PGFSJHGESKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly CurrentExecParamsDelegate? RUFYLOTEPER;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public GDANQZHWFSQ IMGDPWRLYKL
		{
			[Cpp2IlInjected.Token(Token = "0x600080B")]
			[Cpp2IlInjected.Address(RVA = "0xFB7AB0", Offset = "0xFB66B0", VA = "0x180FB7AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public YHYDODNVHPR([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class GNKHRUSLFSX : XPEEEJIOVCS
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly XPEEEJIOVCS PGFSJHGESKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly GetGameColorFromIdDelegate ZBBPUFNPMAT;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2837170", Offset = "0x2835D70", VA = "0x182837170", Slot = "4")]
		public CircuitsColor RSBRCHNDHLB(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2837390", Offset = "0x2835F90", VA = "0x182837390")]
		public GNKHRUSLFSX([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class TBKPDDLTLOL : DZRACNYRZDY
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
			public TBKPDDLTLOL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x283B4F0", Offset = "0x283A0F0", VA = "0x18283B4F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x283B6E0", Offset = "0x283A2E0", VA = "0x18283B6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly IsStringPureAsyncDelegate EIYJAIXKPLM;

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x283A140", Offset = "0x2838D40", VA = "0x18283A140", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> SZZWDYMNFMY(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x283A280", Offset = "0x2838E80", VA = "0x18283A280")]
		public TBKPDDLTLOL([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class UBQTEYYJWKN : YQDHHMUYBMM
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate OZUUPXARKOQ? GetNodeVisualizationConfigDelegate([In] Id128<KMTSZWWZJTI> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public static readonly YQDHHMUYBMM PGFSJHGESKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly GetNodeVisualizationConfigDelegate ERRKAXHVZFX;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x2837170", Offset = "0x2835D70", VA = "0x182837170")]
		public OZUUPXARKOQ? SPYUYXALMYR([In] Id128<KMTSZWWZJTI> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x283D050", Offset = "0x283BC50", VA = "0x18283D050")]
		public UBQTEYYJWKN([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2837170", Offset = "0x2835D70", VA = "0x182837170", Slot = "4")]
		private OZUUPXARKOQ BJBDZWJTDJB([In] Id128<KMTSZWWZJTI> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class VHULJNIOHNW : JOEOUGMSPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x283DC30", Offset = "0x283C830", VA = "0x18283DC30", Slot = "4")]
		public QZPMTXTKYSM DMLJQLKIPSQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public VHULJNIOHNW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class ADDXFLOQNSQ : CRXVWHPYIHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, bool> VATXHJYLVRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, float> FCMEHQLHSTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, double> EUXRJYANXSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, int> TQFUBAYSOYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, long> LUNNESKNFCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, string> SEUVSSAYSYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, uint> SJDMJGSZJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, ulong> JDCCFZNPOBY;

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2834C60", Offset = "0x2833860", VA = "0x182834C60", Slot = "4")]
		public bool? WCJVNSPRYRD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2834D00", Offset = "0x2833900", VA = "0x182834D00")]
		public ADDXFLOQNSQ()
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
