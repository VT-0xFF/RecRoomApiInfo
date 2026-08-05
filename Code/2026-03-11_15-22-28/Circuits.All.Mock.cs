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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28A3090", Offset = "0x28A2090", VA = "0x1828A3090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		internal sealed class MTXIAAQWXUZ : NKOEIJVVLUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MTXIAAQWXUZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB95CC0", Offset = "0xB94CC0", VA = "0x180B95CC0", Slot = "4")]
			public NKOEIJVVLUE UTLDISVZSGG(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB95CC0", Offset = "0xB94CC0", VA = "0x180B95CC0", Slot = "5")]
			public NKOEIJVVLUE HYFENSQRYJH(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB95CC0", Offset = "0xB94CC0", VA = "0x180B95CC0", Slot = "6")]
			public NKOEIJVVLUE WVDHCSLDZOB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			public void IPCXLVWHJHS()
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
	public static class NMCAZIOFISE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MJLEUFQBZLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public WIQKHRMUIPP KBOYDQARTTM;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MJLEUFQBZLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x28A2740", Offset = "0x28A1740", VA = "0x1828A2740")]
			internal MLJAAVCGGXT VEKMIYAJYDX(GetNetworkObjectDelegate a)
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
			public DPGTGQXFVAL dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public KNSHTKDPPBO network;

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
			[Cpp2IlInjected.Address(RVA = "0x28AAE40", Offset = "0x28A9E40", VA = "0x1828AAE40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x28AB4E0", Offset = "0x28AA4E0", VA = "0x1828AB4E0", Slot = "5")]
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
			public KNSHTKDPPBO network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public DPGTGQXFVAL dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<UYHKNYSICNO>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private UOILJAPMYSC <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x28AB550", Offset = "0x28AA550", VA = "0x1828AB550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x28ABAE0", Offset = "0x28AAAE0", VA = "0x1828ABAE0", Slot = "5")]
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
			public WIQKHRMUIPP roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x28ABB50", Offset = "0x28AAB50", VA = "0x1828ABB50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x28AC060", Offset = "0x28AB060", VA = "0x1828AC060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28A2D50", Offset = "0x28A1D50", VA = "0x1828A2D50")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? GAUJAXLZTIX([Optional] WIQKHRMUIPP? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28A2BD0", Offset = "0x28A1BD0", VA = "0x1828A2BD0")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> BYQOMEAKQGU(KNSHTKDPPBO a, [Optional] DPGTGQXFVAL? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28A2A40", Offset = "0x28A1A40", VA = "0x1828A2A40")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> BYQOMEAKQGU(KNSHTKDPPBO a, DPGTGQXFVAL b, RegistryV2 c, Id32<UYHKNYSICNO>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28A2FC0", Offset = "0x28A1FC0", VA = "0x1828A2FC0")]
		public static (RuntimeFnRegistry, RuntimeFns) YOHQMVZPUHM()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28A2E40", Offset = "0x28A1E40", VA = "0x1828A2E40")]
		public static (ExternalFnRegistry, ExternalFns) SFALMFHMALJ()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28A2F40", Offset = "0x28A1F40", VA = "0x1828A2F40")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static KNSHTKDPPBO SWORRZOGCAU(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class WSUKMQLWDRK
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate MLJAAVCGGXT CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public WSUKMQLWDRK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x28AAA50", Offset = "0x28A9A50", VA = "0x1828AAA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x28AADD0", Offset = "0x28A9DD0", VA = "0x1828AADD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly KNSHTKDPPBO WVCOMEMSRAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? KPDTMRNBCFI;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		private WSUKMQLWDRK(KNSHTKDPPBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28AD430", Offset = "0x28AC430", VA = "0x1828AD430")]
		public static WSUKMQLWDRK UGFOPWHDXKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28AD410", Offset = "0x28AC410", VA = "0x1828AD410")]
		public WSUKMQLWDRK MVKGXUARZMV(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28AD320", Offset = "0x28AC320", VA = "0x1828AD320")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> IPCXLVWHJHS()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class ZVYDYMZIYPA : UOILJAPMYSC.OAIZGCDVQOY
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate EIQLKIGJKVE NewCircuitsLifecycleDelegate(UIREVXYUNXH.OAIZGCDVQOY deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(UOILJAPMYSC circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(UOILJAPMYSC circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate EKDGZQTNGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate EFTKDKNLODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate BCYCFDRHMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate BHIRADWQOSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate YEPLXGSKJJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate AOPKJVYVEST;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int QQLXBANJEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1059E90", Offset = "0x1058E90", VA = "0x181059E90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28ADD70", Offset = "0x28ACD70", VA = "0x1828ADD70", Slot = "6")]
		public void FCXSSATHXXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28ADDA0", Offset = "0x28ACDA0", VA = "0x1828ADDA0", Slot = "7")]
		public void JRIUYTIFPSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28ADDD0", Offset = "0x28ACDD0", VA = "0x1828ADDD0", Slot = "5")]
		public EIQLKIGJKVE NPVNRUQAFRD(UIREVXYUNXH.OAIZGCDVQOY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCA0700", Offset = "0xC9F700", VA = "0x180CA0700", Slot = "8")]
		public void HBXDSCFKEGS(UOILJAPMYSC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCA0670", Offset = "0xC9F670", VA = "0x180CA0670", Slot = "9")]
		public void BDVCVIUYBIX(UOILJAPMYSC a, PQYWNUACEKJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28ADE00", Offset = "0x28ACE00", VA = "0x1828ADE00")]
		public ZVYDYMZIYPA([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly JVSIOPAFIHP<KNSHTKDPPBO, KNSHTKDPPBO.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly BHSQOXYFTHX<KNSHTKDPPBO, KNSHTKDPPBO.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly UOILJAPMYSC CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<OFTCEQFRRMD> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly KNSHTKDPPBO Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x289F6D0", Offset = "0x289E6D0", VA = "0x18289F6D0")]
		public EVCreationResult(JVSIOPAFIHP<KNSHTKDPPBO, KNSHTKDPPBO.MockStaticNetSysDeps> staticNetSys, BHSQOXYFTHX<KNSHTKDPPBO, KNSHTKDPPBO.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, UOILJAPMYSC circuitsManager, Id32<OFTCEQFRRMD> clientId, KNSHTKDPPBO network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly UOILJAPMYSC _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 ZEFDAFFIXAE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x28A25F0", Offset = "0x28A15F0", VA = "0x1828A25F0")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request TUJNFMUNDGY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x28A2710", Offset = "0x28A1710", VA = "0x1828A2710")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public THPTAACPNZD? SYQBIGDTGQY
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x28A2620", Offset = "0x28A1620", VA = "0x1828A2620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ONSXKYCMZAP? FYLRPLOTYZY
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x28A2590", Offset = "0x28A1590", VA = "0x1828A2590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
		internal LimitedCircuits(UOILJAPMYSC circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class QFARXLAZPUQ : DPGTGQXFVAL
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LASOGALVDZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public MLJAAVCGGXT ASLKBRQIEMJ;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public LASOGALVDZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			internal MLJAAVCGGXT TQYTQWBUPDF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public UIREVXYUNXH.OAIZGCDVQOY QQRVOEQPRMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public UOILJAPMYSC.OAIZGCDVQOY SDBIWRFJWSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public YDXEBHQLRCV.OAIZGCDVQOY BDDWPDEHHVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC> DAAXGYBMJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.OAIZGCDVQOY WDCGBECLVNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public QDTLTHTSXNH CHLMVZKAAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public GHEKOECVSUE ORWRCEUNBON
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public YHJIQBACQBQ VOBKBRFJJRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GQQCNTKRUZA LGTNDZQQNBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xACDCE0", Offset = "0xACCCE0", VA = "0x180ACDCE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ZOCCJHRAKXK IAIREJBMFXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xACDCF0", Offset = "0xACCCF0", VA = "0x180ACDCF0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28A5E30", Offset = "0x28A4E30", VA = "0x1828A5E30")]
		private QFARXLAZPUQ(UIREVXYUNXH.OAIZGCDVQOY a, UOILJAPMYSC.OAIZGCDVQOY b, YDXEBHQLRCV.OAIZGCDVQOY c, FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC> d, CV2Request.OAIZGCDVQOY e, QDTLTHTSXNH f, GHEKOECVSUE g, YHJIQBACQBQ h, GQQCNTKRUZA i, ZOCCJHRAKXK j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28A5610", Offset = "0x28A4610", VA = "0x1828A5610")]
		public static QFARXLAZPUQ? AMTQPZOUZEX(YDXEBHQLRCV.OAIZGCDVQOY cv2RootSysDeps, [Optional] UIREVXYUNXH.OAIZGCDVQOY? a, [Optional] UOILJAPMYSC.OAIZGCDVQOY? b, [Optional] FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>? reducerDeps, [Optional] CV2Request.OAIZGCDVQOY? c, [Optional] QDTLTHTSXNH? d, [Optional] GHEKOECVSUE? e, [Optional] YHJIQBACQBQ? f, [Optional] GQQCNTKRUZA? g, [Optional] ZOCCJHRAKXK? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28A5CE0", Offset = "0x28A4CE0", VA = "0x1828A5CE0")]
		public static QFARXLAZPUQ MOCYUHWDPEZ(MLJAAVCGGXT a, [Optional] UIREVXYUNXH.OAIZGCDVQOY? circuitsLifecycleDeps, [Optional] UOILJAPMYSC.OAIZGCDVQOY? circuitsManagerDeps, [Optional] FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28A5960", Offset = "0x28A4960", VA = "0x1828A5960")]
		public static QFARXLAZPUQ MFCKPVGDMGZ(GetNetworkObjectDelegate a, [Optional] UIREVXYUNXH.OAIZGCDVQOY? circuitsLifecycleDeps, [Optional] UOILJAPMYSC.OAIZGCDVQOY? circuitsManagerDeps, [Optional] FMACKSTEVXH.GJLSAJUAVJH<ActionKind, PQYWNUACEKJ, UOILJAPMYSC>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class REVYWTCCBDT
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class HQENANIBZDY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public GetNetworkObjectDelegate ZIZCKTTTDMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int NAQOYCRPIOR;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public HQENANIBZDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x289FC30", Offset = "0x289EC30", VA = "0x18289FC30")]
			internal FBFCVJCOWNI JUFBQECKKSC(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x289FAD0", Offset = "0x289EAD0", VA = "0x18289FAD0")]
			internal FBFCVJCOWNI[] JTETDWGXPNJ(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0")]
			internal int UWVPYVLMFST()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HQJTXUBZIPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public DynamicEnvironmentNetworkId UPBMFFCSHCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public HQENANIBZDY PYDAXWOHYEE;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public HQJTXUBZIPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x289FCA0", Offset = "0x289ECA0", VA = "0x18289FCA0")]
			internal FBFCVJCOWNI BWHFNZEEQVA(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly TNNPXTPLORO XVPYRGUMNZX;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28A6650", Offset = "0x28A5650", VA = "0x1828A6650")]
		public static FBFCVJCOWNI? BRLRAOVPYRD(Id32<UYHKNYSICNO>? networkObject, [Optional] RBAXGOOVHDT.SerializesIntoSavesDelegate? a, [Optional] RBAXGOOVHDT.SerializesIntoInventionsDelegate? b, [Optional] RBAXGOOVHDT.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28A6670", Offset = "0x28A5670", VA = "0x1828A6670")]
		public static MLJAAVCGGXT? NQXZESUNVEY(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] VVHHZIOZHKI? b, [Optional] KAFBXKDIWCC? c, [Optional] YXFYOBHPRUA? d, [Optional] WIQKHRMUIPP? e, int f = 300000, bool g = false, bool h = false, [Optional] JGYIORBHLLE? i, [Optional] DWSSEPLQIYO? j, [Optional] EENXMCJVGEJ? k, [Optional] ZOJEZWTRZIU? l, [Optional] UIFHKYPVOQR? m, [Optional] QMCIYYANJEY? n, [Optional] CKKHMDLKIII.OAIZGCDVQOY? o, [Optional] EqualsNodeV2.OAIZGCDVQOY? p, [Optional] CKBFWSXPWXU? q, [Optional] MLJAAVCGGXT.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] MLJAAVCGGXT.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] MLJAAVCGGXT.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] MLJAAVCGGXT.GetLocalRoomIdDelegate? u, [Optional] MLJAAVCGGXT.GetLocalSubroomIdDelegate? v, [Optional] MLJAAVCGGXT.GetSubroomIdsForLocalRoomDelegate? w, [Optional] MLJAAVCGGXT.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] MLJAAVCGGXT.SaveRoomOnPlayerBehalfDelegate? z, [Optional] MLJAAVCGGXT.ReportCloudDataLedgerChangedDelegate? ba, [Optional] MLJAAVCGGXT.GetColorNameByIdDelegate? bb, [Optional] MLJAAVCGGXT.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] MLJAAVCGGXT.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] MLJAAVCGGXT.GetTaggableNameFromSignalDelegate? be, [Optional] MLJAAVCGGXT.GetAudioNameFromSignalDelegate? bf, [Optional] MLJAAVCGGXT.GetDestinationNameFromSignalDelegate? bg, [Optional] MLJAAVCGGXT.GetPlayerEventNameFromSignalDelegate? bh, [Optional] MLJAAVCGGXT.GetRoomKeyNameFromSignalDelegate? bi, [Optional] MLJAAVCGGXT.GetRewardNameFromSignalDelegate? bj, [Optional] MLJAAVCGGXT.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] MLJAAVCGGXT.ReportPreloadedAudioChangedDelegate? bl, [Optional] MLJAAVCGGXT.ReportRewardDataChangedDelegate? bm, [Optional] MLJAAVCGGXT.GetConsumableNameFromSignalDelegate? bn, [Optional] MLJAAVCGGXT.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] MLJAAVCGGXT.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] MLJAAVCGGXT.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] MLJAAVCGGXT.GetInventoryItemNameFromSignalDelegate? br, [Optional] MLJAAVCGGXT.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] MLJAAVCGGXT.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] MLJAAVCGGXT.GetRoomOfferNameFromSignalDelegate? bu, [Optional] MLJAAVCGGXT.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] MLJAAVCGGXT.GetObjectIdFromCreationObjectDelegate? bw, [Optional] MLJAAVCGGXT.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] MLJAAVCGGXT.GetCostInBytesDelegate? by, [Optional] MLJAAVCGGXT.GetAvatarItemNameFromSignalDelegate? bz, [Optional] MLJAAVCGGXT.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] MLJAAVCGGXT.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] MLJAAVCGGXT.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] MLJAAVCGGXT.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] MLJAAVCGGXT.GetStoreItemNameFromSignalDelegate? ce, [Optional] MLJAAVCGGXT.GetBodyPartNameFromSignalDelegate? cf, [Optional] MLJAAVCGGXT.GetDependenciesForGraphInstanceDelegate? cg, [Optional] MLJAAVCGGXT.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] MLJAAVCGGXT.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] MLJAAVCGGXT.GetRecNetImageNameFromSignalDelegate? cj, [Optional] MLJAAVCGGXT.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] MLJAAVCGGXT.IsFunctionValidForAIDelegate? cm, [Optional] MLJAAVCGGXT.GetAIFunctionNameFromSignalDelegate? cn, [Optional] MLJAAVCGGXT.FromSerializableObjectDelegate? co, [Optional] MLJAAVCGGXT.ToSerializableObjectDelegate? cp)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<UYHKNYSICNO>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class VJOLYDPWJJU : EENXMCJVGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly VJOLYDPWJJU QSHZKWMVMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly GetLocalPlayerDelegate? BFLAVKLJONH;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x28AD1E0", Offset = "0x28AC1E0", VA = "0x1828AD1E0", Slot = "4")]
		public (UCMMHLWSMSE, UCMMHLWSMSE, UCMMHLWSMSE, UCMMHLWSMSE, UCMMHLWSMSE) HIMHUKFKMEQ(object a)
		{
			return default((UCMMHLWSMSE, UCMMHLWSMSE, UCMMHLWSMSE, UCMMHLWSMSE, UCMMHLWSMSE));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x28AD1B0", Offset = "0x28AC1B0", VA = "0x1828AD1B0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "6")]
		public bool ZVTLCDIVAXZ(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xB310E0", Offset = "0xB300E0", VA = "0x180B310E0", Slot = "7")]
		public string XFSPYUTNRHJ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public VJOLYDPWJJU([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class RBAXGOOVHDT : FBFCVJCOWNI
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(RBAXGOOVHDT self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(RBAXGOOVHDT self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(RBAXGOOVHDT self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly SerializesIntoSavesDelegate IVHAKUZJFVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly SerializesIntoInventionsDelegate XAJGYIISNSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly CanPublishInInventionsDelegate AMOUHTUVGPI;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private TKIFYGJQRJI? PLMABQXNSRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F60", Offset = "0xAD1F60", VA = "0x180AD2F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId SMHXXMRCLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD77500", Offset = "0xD76500", VA = "0x180D77500", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool WOHPORDQNPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x28A6620", Offset = "0x28A5620", VA = "0x1828A6620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool UYYNLUDPSAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x28A65F0", Offset = "0x28A55F0", VA = "0x1828A65F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool GJAWFOPQTTY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x28A65C0", Offset = "0x28A55C0", VA = "0x1828A65C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DLUHAWAZDWR? UEQEVPSFUYE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<UYHKNYSICNO>? GTVHUQMWGLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x28A6470", Offset = "0x28A5470", VA = "0x1828A6470", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x28A5F20", Offset = "0x28A4F20", VA = "0x1828A5F20", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(TNNPXTPLORO e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAD2F60", Offset = "0xAD1F60", VA = "0x180AD2F60", Slot = "13")]
		public void Bind(TKIFYGJQRJI controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x28A6510", Offset = "0x28A5510", VA = "0x1828A6510")]
		private RBAXGOOVHDT(Id32<UYHKNYSICNO>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x28A5FC0", Offset = "0x28A4FC0", VA = "0x1828A5FC0")]
		public static RBAXGOOVHDT? New(Id32<UYHKNYSICNO>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class HWUQBJSETXD : JGYIORBHLLE
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
		public static readonly HWUQBJSETXD QSHZKWMVMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly RoundToDecimalPlaceDelegate? CQLDDFTUZDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly TruncateToDecimalPlaceDelegate? UEQNAVTGBIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsColorLerpDelegate? TLXVJZDSYAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsColorInverseLerpDelegate? KLJBAPIPYWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4GetPositionDelegate? LYOWQAHJZZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4GetRotationDelegate? MAXECPCGIRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsMtx4x4InverseDelegate? NBNXRKZIMVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsMtx4x4MultiplyDelegate? HUFGSLTTGTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? TBYSLXZJBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatDotDelegate? FVBMHXYVEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromAngleAxisDelegate? FLISKCXQWIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? AUXIWNERJOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatFromFromToRotationDelegate? WSQSVFSAFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatFromLookRotationDelegate? LGLZWIICZVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? CUEFQVQCXRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseDelegate? WICIXEVVOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatLerpDelegate? UEALJKNQUHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatLerpUnclampedDelegate? AVOKZDRAOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatInverseLerpDelegate? YNEGCJSGDQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatMultiplyDelegate? AHYPOYJOWZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatNormalizeDelegate? MDJWXBYEMWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatRotateTowardsDelegate? DAWDNNLXIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatRotateVectorDelegate? LHZNFVMKLRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatSlerpDelegate? JRGBVQLWPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsQuatToAngleAxisDelegate? UCJOROFJAUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsQuatToEulerAnglesDelegate? EAAIWCUOBQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3AddDelegate? TLVNPDOQGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? FYGNJANCACA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? ONEFTMQERMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3CrossDelegate? XPXQWGBKWZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3DotDelegate? FSQKMRFPQGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3AngleDelegate? JIHIWGTBZNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3GetMagnitudeDelegate? TBEZBWWXUFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3LerpDelegate? QVZBPYZCNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3LerpUnclampedDelegate? OCTIQUFSNQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3InverseLerpDelegate? MEYMZVMCLYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3MoveTowardsDelegate? GGEYSGOMKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3NegateDelegate? VOSAAUTOXOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3NormalizeDelegate? DYWIRRMQVUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ProjectDelegate? OXLDLQUJEIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? SYCWYCWJMAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3ScaleDelegate? RQHAOPVOOVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SmoothDampDelegate? AOYNHXBJTYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3SubtractDelegate? WCEHJZQHFLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3SlerpDelegate? INXFPZSMTNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly CircuitsVec3TransformDelegate? UPBYHCSBLXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CircuitsVec3InverseTransformDelegate? ILYGBFVPTYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly RealtimeSinceStartupDelegate? ZSOREHSGOGO;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28A1E90", Offset = "0x28A0E90", VA = "0x1828A1E90")]
		public HWUQBJSETXD([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28A02E0", Offset = "0x289F2E0", VA = "0x1828A02E0")]
		public float DHQJSUTSFQW([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28A0E90", Offset = "0x289FE90", VA = "0x1828A0E90")]
		public float LZOTGTVUQDU([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28A08D0", Offset = "0x289F8D0", VA = "0x1828A08D0")]
		public CircuitsColor HWBTVMGQERZ([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28A0120", Offset = "0x289F120", VA = "0x1828A0120")]
		public float CVJPAFTIZDB([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28A0AF0", Offset = "0x289FAF0", VA = "0x1828A0AF0")]
		public CircuitsVec3 JLICLJSINON([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28A1920", Offset = "0x28A0920", VA = "0x1828A1920")]
		public CircuitsQuat WLAEHXYENXW([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28A0930", Offset = "0x289F930", VA = "0x1828A0930")]
		public CircuitsMtx4x4 IBBZQFCDRNY([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28A1000", Offset = "0x28A0000", VA = "0x1828A1000")]
		public CircuitsMtx4x4 NHYVAYONTTM([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28A1970", Offset = "0x28A0970", VA = "0x1828A1970")]
		public CircuitsMtx4x4 WLZQMIRSIPY([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28A09A0", Offset = "0x289F9A0", VA = "0x1828A09A0")]
		public float QUVOFIBWFWH([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28A1870", Offset = "0x28A0870", VA = "0x1828A1870")]
		public CircuitsQuat VQQZARXOVBA(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28A0700", Offset = "0x289F700", VA = "0x1828A0700")]
		public CircuitsQuat FRNFCXPEQFL([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28A1620", Offset = "0x28A0620", VA = "0x1828A1620")]
		public CircuitsQuat VJXUAQKQVIH([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28A0150", Offset = "0x289F150", VA = "0x1828A0150")]
		public CircuitsQuat DACUYHVLORT([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28A0300", Offset = "0x289F300", VA = "0x1828A0300")]
		public CircuitsQuat ZICFQJFZUMM([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28A0D50", Offset = "0x289FD50", VA = "0x1828A0D50")]
		public CircuitsQuat RQEVVTCLARH([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28A12D0", Offset = "0x28A02D0", VA = "0x1828A12D0")]
		public CircuitsQuat RUOGUFUNRTC([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28A10E0", Offset = "0x28A00E0", VA = "0x1828A10E0")]
		public float NONQKDZTVGN([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28A0570", Offset = "0x289F570", VA = "0x1828A0570")]
		public CircuitsQuat JRQIHLOUBQM([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28A0BE0", Offset = "0x289FBE0", VA = "0x1828A0BE0")]
		public CircuitsQuat KDBYHJNESVR([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x289FE30", Offset = "0x289EE30", VA = "0x18289FE30")]
		public CircuitsQuat AMGFDYXDAIF([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28A0500", Offset = "0x289F500", VA = "0x1828A0500")]
		public CircuitsVec3 ELRVDHYMMPG([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28A03A0", Offset = "0x289F3A0", VA = "0x1828A03A0")]
		public CircuitsQuat DYQBESPIBKU([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x28A00E0", Offset = "0x289F0E0", VA = "0x1828A00E0")]
		public void ZUCHDICSCGB([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28A0810", Offset = "0x289F810", VA = "0x1828A0810")]
		public CircuitsVec3 HNBBSJUJZIW([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28A1C60", Offset = "0x28A0C60", VA = "0x1828A1C60")]
		public CircuitsVec3 YMGKVTJWPRV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28A0270", Offset = "0x289F270", VA = "0x1828A0270")]
		public CircuitsVec3 DFYRLTLZTUH([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28A0CE0", Offset = "0x289FCE0", VA = "0x1828A0CE0")]
		public CircuitsVec3 LDNSZPRRVAU([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x289FEF0", Offset = "0x289EEF0", VA = "0x18289FEF0")]
		public CircuitsVec3 BCVKOBCWSQI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28A0E10", Offset = "0x289FE10", VA = "0x1828A0E10")]
		public float YXOQDIANSYP([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28A0B50", Offset = "0x289FB50", VA = "0x1828A0B50")]
		public float JQXYLXPYYVJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28A11D0", Offset = "0x28A01D0", VA = "0x1828A11D0")]
		public float XTSBJHKBZSC([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28A0A80", Offset = "0x289FA80", VA = "0x1828A0A80")]
		public CircuitsVec3 JFBUKRAJBKR([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28A0200", Offset = "0x289F200", VA = "0x1828A0200")]
		public CircuitsVec3 DCFTPNCCSMU([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28A0460", Offset = "0x289F460", VA = "0x1828A0460")]
		public float MMWCWRKYAYN([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28A0490", Offset = "0x289F490", VA = "0x1828A0490")]
		public CircuitsVec3 EGILGJYTXGX([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28A0870", Offset = "0x289F870", VA = "0x1828A0870")]
		public CircuitsVec3 HUSXTXSQTCS([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28A0C80", Offset = "0x289FC80", VA = "0x1828A0C80")]
		public CircuitsVec3 KFRZKTQDHIP([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28A1BF0", Offset = "0x28A0BF0", VA = "0x1828A1BF0")]
		public CircuitsVec3 YLISTCLIKPP([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28A07A0", Offset = "0x289F7A0", VA = "0x1828A07A0")]
		public CircuitsVec3 GFUQQJOJQIS([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28A1B80", Offset = "0x28A0B80", VA = "0x1828A1B80")]
		public CircuitsVec3 YARQDCEKPKK([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x28A0030", Offset = "0x289F030", VA = "0x1828A0030")]
		public CircuitsVec3 BWUGJVFJXFS([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x289FD50", Offset = "0x289ED50", VA = "0x18289FD50")]
		public CircuitsVec3 AANAVIXNJUQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28A0690", Offset = "0x289F690", VA = "0x1828A0690")]
		public CircuitsVec3 FIXNHXJWSDO([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x28A1540", Offset = "0x28A0540", VA = "0x1828A1540")]
		public CircuitsVec3 SMMUBPSSLVG([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28A1AB0", Offset = "0x28A0AB0", VA = "0x1828A1AB0")]
		public CircuitsVec3 XIDPRTCWZZC([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28A1390", Offset = "0x28A0390", VA = "0x1828A1390", Slot = "50")]
		public Task QKUYGJLXOLW(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "51")]
		public void XLIJTOBQJDC([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28A09C0", Offset = "0x289F9C0", VA = "0x1828A09C0", Slot = "52")]
		public OUBSWFYBBQL<IBWRJZFPGUT> IPVRNAOTIHY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28A14F0", Offset = "0x28A04F0", VA = "0x1828A14F0", Slot = "53")]
		public OUBSWFYBBQL<IBWRJZFPGUT> REARQOBMXKT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28A0F80", Offset = "0x289FF80", VA = "0x1828A0F80", Slot = "54")]
		public float MWSMEWEILAB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28A02E0", Offset = "0x289F2E0", VA = "0x1828A02E0", Slot = "4")]
		private float ZHUYRQQUFLC([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28A0E90", Offset = "0x289FE90", VA = "0x1828A0E90", Slot = "5")]
		private float MNNZMHAAJSI([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x28A0EB0", Offset = "0x289FEB0", VA = "0x1828A0EB0", Slot = "6")]
		private CircuitsColor MDAHRNGRUIB([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28A0120", Offset = "0x289F120", VA = "0x1828A0120", Slot = "7")]
		private float CUAREVYFXEJ([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x289FFD0", Offset = "0x289EFD0", VA = "0x18289FFD0", Slot = "8")]
		private CircuitsVec3 BTBKCAPVMKP([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28A1110", Offset = "0x28A0110", VA = "0x1828A1110", Slot = "9")]
		private CircuitsQuat NPTBYHTJMIW([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28A0E30", Offset = "0x289FE30", VA = "0x1828A0E30", Slot = "10")]
		private CircuitsMtx4x4 LPYQZRLGUEI([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28A0FA0", Offset = "0x289FFA0", VA = "0x1828A0FA0", Slot = "11")]
		private CircuitsMtx4x4 MYERHPAHGAU([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28A16D0", Offset = "0x28A06D0", VA = "0x1828A16D0", Slot = "12")]
		private CircuitsMtx4x4 TLGASMNMVOY([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28A09A0", Offset = "0x289F9A0", VA = "0x1828A09A0", Slot = "13")]
		private float IFVQUHCQACJ([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28A1870", Offset = "0x28A0870", VA = "0x1828A1870", Slot = "14")]
		private CircuitsQuat VMVTVUYWJXW(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28A0700", Offset = "0x289F700", VA = "0x1828A0700", Slot = "15")]
		private CircuitsQuat LCXWDSMVWKP([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x28A1620", Offset = "0x28A0620", VA = "0x1828A1620", Slot = "16")]
		private CircuitsQuat TFTVVPBZBGN([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x28A0150", Offset = "0x289F150", VA = "0x1828A0150", Slot = "17")]
		private CircuitsQuat QQFCRYBMIIT([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x28A0300", Offset = "0x289F300", VA = "0x1828A0300", Slot = "18")]
		private CircuitsQuat DMBCIMTFUZU([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x28A0D50", Offset = "0x289FD50", VA = "0x1828A0D50", Slot = "19")]
		private CircuitsQuat LJUBDUXWCZZ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x28A12D0", Offset = "0x28A02D0", VA = "0x1828A12D0", Slot = "20")]
		private CircuitsQuat QBSEMHOWWVY([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28A10E0", Offset = "0x28A00E0", VA = "0x1828A10E0", Slot = "21")]
		private float ZZCVKKOZHHB([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28A0570", Offset = "0x289F570", VA = "0x1828A0570", Slot = "22")]
		private CircuitsQuat EMSWLQXHIAG([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x28A0BE0", Offset = "0x289FBE0", VA = "0x1828A0BE0", Slot = "23")]
		private CircuitsQuat TIYPMBNOQLP([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x289FE30", Offset = "0x289EE30", VA = "0x18289FE30", Slot = "24")]
		private CircuitsQuat BVGTCVCNSIH([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x289FDC0", Offset = "0x289EDC0", VA = "0x18289FDC0", Slot = "25")]
		private CircuitsVec3 ABBGNLQGIQS([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28A03A0", Offset = "0x289F3A0", VA = "0x1828A03A0", Slot = "26")]
		private CircuitsQuat FTPSJIYYRVQ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28A00E0", Offset = "0x289F0E0", VA = "0x1828A00E0", Slot = "27")]
		private void BXYTOUSSRJB([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28A1B20", Offset = "0x28A0B20", VA = "0x1828A1B20", Slot = "28")]
		private CircuitsVec3 XKNQNXGCJOQ([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28A11F0", Offset = "0x28A01F0", VA = "0x1828A11F0", Slot = "29")]
		private CircuitsVec3 OZRRUMINHDP([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28A1730", Offset = "0x28A0730", VA = "0x1828A1730", Slot = "30")]
		private CircuitsVec3 UCJFPSYGQQZ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x28A0A10", Offset = "0x289FA10", VA = "0x1828A0A10", Slot = "31")]
		private CircuitsVec3 IQPPPNSOMYK([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x28A13C0", Offset = "0x28A03C0", VA = "0x1828A13C0", Slot = "32")]
		private CircuitsVec3 QTXNWCBVTLY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x289FF60", Offset = "0x289EF60", VA = "0x18289FF60", Slot = "33")]
		private CircuitsVec3 BEDJGKWGUYS([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x28A1260", Offset = "0x28A0260", VA = "0x1828A1260", Slot = "34")]
		private CircuitsVec3 PXAGSYVBSZQ([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x28A0E10", Offset = "0x289FE10", VA = "0x1828A0E10", Slot = "35")]
		private float LNKZLOIYTQV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28A0B50", Offset = "0x289FB50", VA = "0x1828A0B50", Slot = "36")]
		private float XZUGGZTEPMV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28A11D0", Offset = "0x28A01D0", VA = "0x1828A11D0", Slot = "37")]
		private float OAZTVDPXIUA([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28A1160", Offset = "0x28A0160", VA = "0x1828A1160", Slot = "38")]
		private CircuitsVec3 NZAHLNCFXKX([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28A0620", Offset = "0x289F620", VA = "0x1828A0620", Slot = "39")]
		private CircuitsVec3 EVPFCTEUWXQ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28A0460", Offset = "0x289F460", VA = "0x1828A0460", Slot = "40")]
		private float EAUTSRCZFRR([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x28A0F10", Offset = "0x289FF10", VA = "0x1828A0F10", Slot = "41")]
		private CircuitsVec3 MKIHVVCIVYR([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28A19E0", Offset = "0x28A09E0", VA = "0x1828A19E0", Slot = "42")]
		private CircuitsVec3 WRYUYHURESA([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28A17A0", Offset = "0x28A07A0", VA = "0x1828A17A0", Slot = "43")]
		private CircuitsVec3 UNAQQLBJTCZ([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28A1A40", Offset = "0x28A0A40", VA = "0x1828A1A40", Slot = "44")]
		private CircuitsVec3 WWTVTRNNDWL([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28A1070", Offset = "0x28A0070", VA = "0x1828A1070", Slot = "45")]
		private CircuitsVec3 NIZXSBEDOWM([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x28A0B70", Offset = "0x289FB70", VA = "0x1828A0B70", Slot = "46")]
		private CircuitsVec3 KBXNRSBPSSM([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x28A1430", Offset = "0x28A0430", VA = "0x1828A1430", Slot = "47")]
		private CircuitsVec3 QZRGHJYJFLE([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x28A1800", Offset = "0x28A0800", VA = "0x1828A1800", Slot = "48")]
		private CircuitsVec3 VIOZGHHETSO([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28A15B0", Offset = "0x28A05B0", VA = "0x1828A15B0", Slot = "49")]
		private CircuitsVec3 SUVPQOXATYG([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class VWZMWRWPUUJ : KMNDSRXEHCW
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x10BD270", Offset = "0x10BC270", VA = "0x1810BD270", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xFB40D0", Offset = "0xFB30D0", VA = "0x180FB40D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x28AD2D0", Offset = "0x28AC2D0", VA = "0x1828AD2D0")]
		public VWZMWRWPUUJ(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class XSQZIPSBHSJ : DWSSEPLQIYO
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(PRQSSYDLWIV e, KSYUSLRGQHS invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly XSQZIPSBHSJ QSHZKWMVMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly GetCircuitsColorFromColorIndexDelegate? VTWROQNVOZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? UXFTMWVYNTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly InvisibleCollisionSetEnabledDelegate? LKOCDEPOSWD;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xB525B0", Offset = "0xB515B0", VA = "0x180B525B0")]
		public XSQZIPSBHSJ([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x28AD4E0", Offset = "0x28AC4E0", VA = "0x1828AD4E0", Slot = "4")]
		public CircuitsColor KTAVFPXNJEV(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x28AD530", Offset = "0x28AC530", VA = "0x1828AD530")]
		public int QZUMSBAMBAX([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x28AD530", Offset = "0x28AC530", VA = "0x1828AD530", Slot = "5")]
		private int ZWALWTLMGMI([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class PRDUDPQMVEU : HMSVIRSPFKB
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class OTXLEXNTHZL
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid EBPHGPFVXKR
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xC9D7C0", Offset = "0xC9C7C0", VA = "0x180C9D7C0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long HLNTLIBTYBQ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int YSGNJWGPFVW
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xAD05D0", Offset = "0xACF5D0", VA = "0x180AD05D0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool RWJMIKEIAUZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x1883E40", Offset = "0x1882E40", VA = "0x181883E40")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool HTQFVDNMNDJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x1883E50", Offset = "0x1882E50", VA = "0x181883E50")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool CQBSVMXCQWQ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x28A3110", Offset = "0x28A2110", VA = "0x1828A3110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x28A3130", Offset = "0x28A2130", VA = "0x1828A3130")]
			public OTXLEXNTHZL(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<Id128<QYHWLOYXTJM>, OTXLEXNTHZL> UTNYWVIVUIU;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x28A5200", Offset = "0x28A4200", VA = "0x1828A5200")]
		public bool GTJSLGLKUAZ([In] Id128<QYHWLOYXTJM> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x28A5130", Offset = "0x28A4130", VA = "0x1828A5130")]
		public void UYYAIIXEJCN([In] Id128<QYHWLOYXTJM> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x28A5400", Offset = "0x28A4400", VA = "0x1828A5400")]
		public void UYYAIIXEJCN([In] Id128<QYHWLOYXTJM> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x28A5010", Offset = "0x28A4010", VA = "0x1828A5010")]
		public void ASJZAYZQZWE([In] Id128<QYHWLOYXTJM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x28A5310", Offset = "0x28A4310", VA = "0x1828A5310")]
		public void QCDDTPPQRMX([In] Id128<QYHWLOYXTJM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x28A5370", Offset = "0x28A4370", VA = "0x1828A5370")]
		public bool RWJMIKEIAUZ([In] Id128<QYHWLOYXTJM> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x28A54E0", Offset = "0x28A44E0", VA = "0x1828A54E0")]
		public PRDUDPQMVEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x28A5200", Offset = "0x28A4200", VA = "0x1828A5200", Slot = "4")]
		private bool JRDLKRMPFYC([In] Id128<QYHWLOYXTJM> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x28A5130", Offset = "0x28A4130", VA = "0x1828A5130", Slot = "5")]
		private void BYUEXHJHLFU([In] Id128<QYHWLOYXTJM> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x28A5010", Offset = "0x28A4010", VA = "0x1828A5010", Slot = "6")]
		private void TJOYFOTALCT([In] Id128<QYHWLOYXTJM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x28A5310", Offset = "0x28A4310", VA = "0x1828A5310", Slot = "7")]
		private void NFKLFMGZAUM([In] Id128<QYHWLOYXTJM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x28A5370", Offset = "0x28A4370", VA = "0x1828A5370", Slot = "8")]
		private bool SZHKSYTKGOE([In] Id128<QYHWLOYXTJM> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class YSUHUYPOPPV
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x28AD5F0", Offset = "0x28AC5F0", VA = "0x1828AD5F0")]
		public static LogDeps HGDWZUJLFSU()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class CPEBVTBPCAO : MeshLibrary.OAIZGCDVQOY
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "4")]
		public byte[]? RHHPZTHGWED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
		public void DILBCCNYGJM(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public CPEBVTBPCAO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class OWUKDODDOAF : VVHHZIOZHKI
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
		public delegate void ConfigureAttachedObjectDelegate(BVGFUFXJEDA controlPanel, YYVRREXPLEY staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<RPECEFKJJZZ> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, WENLUTALDTF>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, WENLUTALDTF>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, WENLUTALDTF>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, WENLUTALDTF>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public Task<Result<MultiResult, WENLUTALDTF>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private TaskAwaiter<Result<MultiResult, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x28AC0D0", Offset = "0x28AB0D0", VA = "0x1828AC0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x28AC390", Offset = "0x28AB390", VA = "0x1828AC390", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x28AC400", Offset = "0x28AB400", VA = "0x1828AC400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x28AC6C0", Offset = "0x28AB6C0", VA = "0x1828AC6C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Task<Result<None, WENLUTALDTF>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private TaskAwaiter<Result<None, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x28AC730", Offset = "0x28AB730", VA = "0x1828AC730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x28AC9F0", Offset = "0x28AB9F0", VA = "0x1828AC9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Dictionary<string, EnumChoiceData> RBJCQYBHWOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Dictionary<int, string> WWRZUJMPQVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly List<object> KXZPDJKQWQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly List<Guid> XCLKPSNWEHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly CanLocalPlayerCreateCurrencyDelegate KRGOUVPZNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ShowRoomCurrencyCreationUIDelegate XPVOWSKKAHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipOptionsDelegate FNBPNUKCOVM;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<Guid, int> TIGLOYSSGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipGuidToIndexMapDelegate DNJBFUEAOLA;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<int, Guid> XEDMMXILCVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAudioClipIndexToGuidMapDelegate VYVAISWLQQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipOptionsDelegate FUGHZBVHPQJ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<Guid, int> YWACIDIOMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate GVEBKBVLAZB;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly IReadOnlyDictionary<int, Guid> AEBMQMVZRTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate VUMWUTBWGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly PlayAudioPreviewDelegate QISLSWUIWSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly StopAudioPreviewDelegate YJWEPZNWKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly SubscriptionIsActiveDelegate TYVTEDSJNYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate SUVGJNNGTZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Dictionary<string, EnumChoiceData> GUXLGMKXYFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly ShowQuickChatEditMenuDelegate WVIKVGWGSJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly ConfigureAttachedObjectDelegate PEIJPYNXRKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly DisplayInvalidNameErrorMessageDelegate YXLWTCVFUUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly IsStringPureDelegate VPJGGYUWXNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly TryGetSpecificChipConfigSummaryDelegate CEZHRQXQWQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReleaseIconIdDelegate INQEXTZGTRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate EVXXIKMDAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 WIFJZPOAPKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 WIADCIUDFZK;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment WHCUAFSWNMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool SZSCZSYUOSN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xB21140", Offset = "0xB20140", VA = "0x180B21140", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> PXGUGSZTWAG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> LEYODHZWLWB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> RDKBZFLAIZI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> GNGYJEYHJUG
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAD8420", Offset = "0xAD7420", VA = "0x180AD8420", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion ZPTZKKDYUMU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xD78C40", Offset = "0xD77C40", VA = "0x180D78C40", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool FBWBXWEFOFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xC685B0", Offset = "0xC675B0", VA = "0x180C685B0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool DJLGRAWOPBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x28A3320", Offset = "0x28A2320", VA = "0x1828A3320", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool YEVBCFFWOPA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x28A32E0", Offset = "0x28A22E0", VA = "0x1828A32E0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool CTVZDTQJIAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xADA5C0", Offset = "0xAD95C0", VA = "0x180ADA5C0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x28A3C60", Offset = "0x28A2C60", VA = "0x1828A3C60")]
		public OWUKDODDOAF([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x28A3220", Offset = "0x28A2220", VA = "0x1828A3220", Slot = "9")]
		public bool CVRVRSIQNBY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0")]
		public static bool ODLQLFSFDON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x28A39B0", Offset = "0x28A29B0", VA = "0x1828A39B0", Slot = "10")]
		public bool WVMQSTKSRPW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void AMDMBWUOHCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xC94CD0", Offset = "0xC93CD0", VA = "0x180C94CD0", Slot = "11")]
		public void SBPXRNZJTHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x28A3530", Offset = "0x28A2530", VA = "0x1828A3530")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> LBAMXLVTYGE(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x28A3360", Offset = "0x28A2360", VA = "0x1828A3360", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GPHEOLBTGIP(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x28A3A40", Offset = "0x28A2A40", VA = "0x1828A3A40")]
		private static IReadOnlyDictionary<Guid, int> YWFIOOFNMVE(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x28A36E0", Offset = "0x28A26E0", VA = "0x1828A36E0", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> UOGCLGTTMWB(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x28A3600", Offset = "0x28A2600", VA = "0x1828A3600")]
		private static IReadOnlyDictionary<int, Guid> RYDGWQYNNJU(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x28A3190", Offset = "0x28A2190", VA = "0x1828A3190", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> AHEFPXKUVJL(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x28A3A10", Offset = "0x28A2A10", VA = "0x1828A3A10")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> YMRTNXWUQQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2895B60", Offset = "0x2894B60", VA = "0x182895B60", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZEUCVFEKYZQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x28A3750", Offset = "0x28A2750", VA = "0x1828A3750")]
		private static IReadOnlyDictionary<Guid, int> VLJIEYCABEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x28A39E0", Offset = "0x28A29E0", VA = "0x1828A39E0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> YIBMEAJOYSW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x28A31C0", Offset = "0x28A21C0", VA = "0x1828A31C0", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> BHFNYPBQQWS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private static void NZOLKPSCDUA(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x28A3710", Offset = "0x28A2710", VA = "0x1828A3710", Slot = "18")]
		public void VIJBSYBIDDJ(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private static void AXYYCPHUQIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x28A32F0", Offset = "0x28A22F0", VA = "0x1828A32F0", Slot = "19")]
		public void EGHTPSMXLKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0")]
		private static bool TIBRPJPGHMR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x28A3560", Offset = "0x28A2560", VA = "0x1828A3560", Slot = "20")]
		public bool MOMGLBBYYOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0")]
		public static bool DMHJBHKPYZG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x28A33C0", Offset = "0x28A23C0", VA = "0x1828A33C0", Slot = "21")]
		public bool HLWCXCPZOBV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x28A3330", Offset = "0x28A2330", VA = "0x1828A3330", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GCZSJOVNMVG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> HXONYNJYJKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> SHZHKIFBGGQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x28A3980", Offset = "0x28A2980", VA = "0x1828A3980", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> WFKMDESEARH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> EPOJRJNIFJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> FSIDNDEVTCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void SYQLSHQZXTL(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x28A33F0", Offset = "0x28A23F0", VA = "0x1828A33F0", Slot = "29")]
		public void INCIEPRJSDS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private static void GNCBJKRTQKP(BVGFUFXJEDA a, YYVRREXPLEY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x28A31F0", Offset = "0x28A21F0", VA = "0x1828A31F0", Slot = "35")]
		public void BKRBXVSRJQK(BVGFUFXJEDA a, YYVRREXPLEY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "36")]
		public Dictionary<string, EnumChoiceData> ADCZPPUNKJW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "37")]
		public Dictionary<string, EnumChoiceData> AWTXYRXWARL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private static void ZQOIOCRGSAN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x28A3A90", Offset = "0x28A2A90", VA = "0x1828A3A90")]
		private static Task<bool> ZAEBETKVKGZ(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x28A3390", Offset = "0x28A2390", VA = "0x1828A3390", Slot = "38")]
		public Task<bool> GVHLZTXQGHK(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x28A3520", Offset = "0x28A2520", VA = "0x1828A3520")]
		private static bool KOAEEKJCWDP(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x28A35C0", Offset = "0x28A25C0", VA = "0x1828A35C0", Slot = "39")]
		public bool OBRDRGIVEZW(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private static void USQDVFRDXZX(Id32<RPECEFKJJZZ> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x28A3590", Offset = "0x28A2590", VA = "0x1828A3590", Slot = "40")]
		public void MQAWJIVLMWU(Id32<RPECEFKJJZZ> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x28A3430", Offset = "0x28A2430", VA = "0x1828A3430")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, WENLUTALDTF>> JRWVMRQIVCB(Task<Result<None, WENLUTALDTF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x28A3650", Offset = "0x28A2650", VA = "0x1828A3650", Slot = "41")]
		public Task<Result<None, WENLUTALDTF>> SRJQBYRIHUA(Task<Result<None, WENLUTALDTF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x28A3890", Offset = "0x28A2890", VA = "0x1828A3890")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, WENLUTALDTF>> VZUCLCQEQDT(Task<Result<MultiResult, WENLUTALDTF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x28A36B0", Offset = "0x28A26B0", VA = "0x1828A36B0", Slot = "42")]
		public Task<Result<MultiResult, WENLUTALDTF>> SRJQBYRIHUA(Task<Result<MultiResult, WENLUTALDTF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x28A37A0", Offset = "0x28A27A0", VA = "0x1828A37A0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> VZOVNVWHGSK(Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x28A3680", Offset = "0x28A2680", VA = "0x1828A3680", Slot = "43")]
		public Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> SRJQBYRIHUA(Task<Result<Id32<JPZDQKXUTWI>, WENLUTALDTF>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class YXFYOBHPRUA : OCBZRBWSEML
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(TNNPXTPLORO e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? XNSBKJIPYJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly InteropDelegate VQUMDKSZVZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly InteropDelegate QEZAYBZKZHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private InteropDelegate? HNZEDHHBJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private InvokeStudioFunctionDelegate? SKTEMYTJBOW;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "5")]
		public LegacyCV2Result<None> TDLSZNBMXLY(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0")]
		private static LegacyCV2Result<None> Default(TNNPXTPLORO _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "6")]
		public LegacyCV2Result<None> BAOVZURWRGD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "7")]
		public LegacyCV2Result<None> PUMKDOABGIA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "8")]
		public LegacyCV2Result<None> XHRKXYYLNOV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "9")]
		public LegacyCV2Result<None> OXCDFVSNMSV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "15")]
		public LegacyCV2Result<None> LBDSWLLQXVA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XPLJEWFGZTQ(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ODTCFPMTXDE(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NCLTPPUORGF(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IIKMLHBMEFC(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PLUIXKJTDDZ(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GDAMMCTVICL(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ANGMDYCWYKG(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "93")]
		public LegacyCV2Result<None> GOGCRBGFYSL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "94")]
		public LegacyCV2Result<None> HRBZZITFZFN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "95")]
		public LegacyCV2Result<None> IPYVQXDCJZC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ATYKFGRJDKU(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(TNNPXTPLORO e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KRUPCONDHDY(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KOSDIDWQKWC(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OMLPPAOWGYN(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PUNGGYLLTGM(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BANKOLZHDXH(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ASRTWDNJKGX(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TGOKHJEIWGD(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LRYTGZKNDNI(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x12A6E50", Offset = "0x12A5E50", VA = "0x1812A6E50", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZZDYBFQZUWF(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LTPYFIDSBMS(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "119")]
		public LegacyCV2Result<None> ZCQTEZRWQVM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NAADMJNVGRV(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "121")]
		public LegacyCV2Result<None> GOFOZNKSIUD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "122")]
		public LegacyCV2Result<None> AHBHZWAGSWD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "123")]
		public LegacyCV2Result<None> ZRIKBTQLIDN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "124")]
		public LegacyCV2Result<None> HYFGUYAQXRF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "125")]
		public LegacyCV2Result<None> MNDKFWLFAQD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "126")]
		public LegacyCV2Result<None> IWMKZQPYYAE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "818")]
		public LegacyCV2Result<None> JXTBRBCDYPM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "819")]
		public LegacyCV2Result<None> AKRLUBNKMAG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "147")]
		public LegacyCV2Result<None> UPWXUNZAZPI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "148")]
		public LegacyCV2Result<None> PZVGANUJXNQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "149")]
		public LegacyCV2Result<None> SYNPOTVTSOF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "150")]
		public LegacyCV2Result<None> AEMJNAUYJJH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "151")]
		public LegacyCV2Result<None> FXSHAYJIWGI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(TNNPXTPLORO e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(TNNPXTPLORO e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(TNNPXTPLORO e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, OCBZRBWSEML.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(TNNPXTPLORO e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, OCBZRBWSEML.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "174")]
		public LegacyCV2Result<None> VAERFPRYODL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "175")]
		public LegacyCV2Result<None> CTIBNUDFYCW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "176")]
		public LegacyCV2Result<None> ELVQNVWEXCW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "197")]
		public LegacyCV2Result<None> VVKSERJHFWQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "198")]
		public LegacyCV2Result<None> GRRTSJVOBDB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "199")]
		public LegacyCV2Result<None> XMXXBQZDCPQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "200")]
		public LegacyCV2Result<None> GMSASEIYLNE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "201")]
		public LegacyCV2Result<None> NTLEINBIVFM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "202")]
		public LegacyCV2Result<None> MUSOOLYBAYD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "203")]
		public LegacyCV2Result<None> CPDQUWFVPSF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "204")]
		public LegacyCV2Result<None> TSLDLQTPMLV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "205")]
		public LegacyCV2Result<None> ZEFXGCTOANJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "206")]
		public LegacyCV2Result<None> EINOVHDBGQX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "207")]
		public LegacyCV2Result<None> AHMIUGOEBKR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "208")]
		public LegacyCV2Result<None> PTWCQSZKWWF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "209")]
		public LegacyCV2Result<None> GNDUIXXOPED(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "210")]
		public LegacyCV2Result<None> AIHTXRLEKCK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "211")]
		public LegacyCV2Result<None> SJNQEPOLENF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "212")]
		public LegacyCV2Result<None> CMCJWWEEMRA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "213")]
		public LegacyCV2Result<None> LOLAOOLZFNH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "214")]
		public LegacyCV2Result<None> HUYSGQTHHEO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "215")]
		public LegacyCV2Result<None> LVADZFERZBF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "274")]
		public LegacyCV2Result<None> TUYOIRPYXKX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "277")]
		public LegacyCV2Result<None> PDSBJEPRGON(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "279")]
		public LegacyCV2Result<None> OHMQEQLBXKA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "280")]
		public LegacyCV2Result<None> FZPZIBAJABY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "281")]
		public LegacyCV2Result<None> RJZNSGVBRZZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "282")]
		public LegacyCV2Result<None> VZPNFTJMYQA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "283")]
		public LegacyCV2Result<None> JNGWJCMYIKZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "287")]
		public LegacyCV2Result<None> DYNMDHJUEKE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "288")]
		public LegacyCV2Result<None> RYRLTFEHBUZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "317")]
		public LegacyCV2Result<None> SSHNTMPLLNA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "406")]
		public LegacyCV2Result<None> SGXJRUXXMPT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZIWIDANOBXK(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JNINADESXAU(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OGHZOMKDAQK(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DBGWNURYIOR(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AEIGVIMAESK(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "416")]
		public LegacyCV2Result<TBPHGFDAOAO.CV2DiscoverySectionType> MUUOCNSVNRD(TNNPXTPLORO e, CircuitSignal a)
		{
			return default(LegacyCV2Result<TBPHGFDAOAO.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "417")]
		public LegacyCV2Result<None> RGQGZFKOQPD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(TNNPXTPLORO e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LQWCXHUZKSN(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YPHESRHEFRA(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YQFDUVESVKL(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "462")]
		public LegacyCV2Result<None> ZKBZMBDQHIS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "463")]
		public LegacyCV2Result<None> UFBDPIRFYGD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "464")]
		public LegacyCV2Result<None> BFEBQYYSPEY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "465")]
		public LegacyCV2Result<None> ORNQWUWRXHX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "466")]
		public LegacyCV2Result<None> FVLWSNVHWUN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "467")]
		public LegacyCV2Result<None> FJNRPAUBQYT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "468")]
		public LegacyCV2Result<None> PCOQOTSAPWM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "469")]
		public LegacyCV2Result<None> TXGMVNTDMYO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "474")]
		public LegacyCV2Result<None> RXIJULGEBVS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "475")]
		public LegacyCV2Result<None> KIJBRQQRVRK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "476")]
		public LegacyCV2Result<None> IVOWDJYXVIR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "477")]
		public LegacyCV2Result<None> YMVVKHNYXGU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "478")]
		public LegacyCV2Result<None> GNHMDSKNUEE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "479")]
		public LegacyCV2Result<None> QIUETDHLBHX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(TNNPXTPLORO executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(TNNPXTPLORO executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "472")]
		public LegacyCV2Result<None> UOXXXJVCIMH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "473")]
		public LegacyCV2Result<None> KCHLIPIAEDF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "480")]
		public LegacyCV2Result<None> JBWGZYDGMGL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "481")]
		public LegacyCV2Result<None> OLKYOVHXKKH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "482")]
		public LegacyCV2Result<None> PSUCNIPWGZK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "483")]
		public LegacyCV2Result<None> ZAOUPCXEBGW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "484")]
		public LegacyCV2Result<None> YTIXHKIKDZK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "485")]
		public LegacyCV2Result<None> QJRHVBNBLHS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "486")]
		public LegacyCV2Result<None> GNCXCYCZKEC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "487")]
		public LegacyCV2Result<None> ZGLOPINNMBS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "488")]
		public LegacyCV2Result<None> NNKCKCUETRM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "489")]
		public LegacyCV2Result<None> WFVMQKGNWJU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "490")]
		public LegacyCV2Result<None> JTWIIPIELRW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "491")]
		public LegacyCV2Result<None> KXFEVNRHRDS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "492")]
		public LegacyCV2Result<None> IJIGSLIVTKW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "493")]
		public LegacyCV2Result<None> GZXXHWLRAMS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "494")]
		public LegacyCV2Result<None> ZZKEQVFGWGO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "495")]
		public LegacyCV2Result<None> CXYHLELLXJS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "496")]
		public LegacyCV2Result<None> RHHZGIGAZGY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "497")]
		public LegacyCV2Result<None> BFRCZELCSKM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "498")]
		public LegacyCV2Result<None> RVBGBTOUREW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "499")]
		public LegacyCV2Result<None> QVOJVRRBFPO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x28ADB70", Offset = "0x28ACB70", VA = "0x1828ADB70", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "507")]
		public LegacyCV2Result<None> SHVQAYQTVEO(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "508")]
		public LegacyCV2Result<None> AYEDDYBSMXG(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "509")]
		public LegacyCV2Result<None> LKGSEDYTYMI(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "510")]
		public LegacyCV2Result<None> PKQJIMKBLVR(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(TNNPXTPLORO e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(TNNPXTPLORO e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(TNNPXTPLORO e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.GVPLRNGCQLE> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "522")]
		public LegacyCV2Result<None> CXJFSFPJJSR(TNNPXTPLORO e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "525")]
		public LegacyCV2Result<None> EBYPQOHOPUF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "527")]
		public LegacyCV2Result<None> KCPQVSJGKWC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "528")]
		public LegacyCV2Result<None> KLGEKUPTBXS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "530")]
		public LegacyCV2Result<None> SYCJWFLZRCI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "531")]
		public LegacyCV2Result<None> YJREAJXGUCD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x28ADA60", Offset = "0x28ACA60", VA = "0x1828ADA60", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "533")]
		public LegacyCV2Result<None> SJDKMLHUSGP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x28ADA20", Offset = "0x28ACA20", VA = "0x1828ADA20", Slot = "535")]
		public LegacyCV2Result<None> FMSSURMFJEJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "534")]
		public LegacyCV2Result<None> LVLRRTWRQDQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "536")]
		public LegacyCV2Result<None> JWEBNMYHOYO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "537")]
		public LegacyCV2Result<None> NUAXOMDZXTT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "538")]
		public LegacyCV2Result<None> VPQKXSEWQXR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "539")]
		public LegacyCV2Result<None> UQNYAQCHALR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "540")]
		public LegacyCV2Result<None> QQLOKAUKWHD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "583")]
		public LegacyCV2Result<None> Raycast(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "584")]
		public LegacyCV2Result<None> XVYVWYWDDTQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "587")]
		public LegacyCV2Result<None> CNRVASNARFP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "591")]
		public LegacyCV2Result<None> VRFVVQSBXIQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "592")]
		public LegacyCV2Result<None> OLTGGRALMNZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "641")]
		public LegacyCV2Result<None> YWVRJPFMIGM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "642")]
		public LegacyCV2Result<None> UFHPXLMCNFS(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "643")]
		public LegacyCV2Result<None> EMTOOYLOYKF(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "644")]
		public LegacyCV2Result<None> FIMQECZYRSC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "645")]
		public LegacyCV2Result<None> WBOWVLMKGQO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "646")]
		public LegacyCV2Result<None> ITRIVWIJUDV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "649")]
		public LegacyCV2Result<None> WGYLYSYHRQY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "650")]
		public LegacyCV2Result<None> XSFLLIEGVQY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "651")]
		public LegacyCV2Result<None> ZTXLJFFFTMN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "661")]
		public LegacyCV2Result<None> VJEMRHYCSGW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "660")]
		public LegacyCV2Result<None> QQBWMCNBLUR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "662")]
		public LegacyCV2Result<None> CSSOFVFVSYI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "663")]
		public LegacyCV2Result<None> LTLHQBRQZIT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "670")]
		public LegacyCV2Result<None> SLFEEJIHXCM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "671")]
		public LegacyCV2Result<None> BTPZDTJIQVV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "674")]
		public LegacyCV2Result<None> SQTVDGLRYYN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "675")]
		public LegacyCV2Result<None> FBNXLGUSYXC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(TNNPXTPLORO e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "696")]
		public LegacyCV2Result<None> AXZDAODYGDQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "697")]
		public LegacyCV2Result<None> LIMXQULNARG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "698")]
		public LegacyCV2Result<None> KFTPADEBQMU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "699")]
		public LegacyCV2Result<None> AIWGAWEGMOL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "700")]
		public LegacyCV2Result<None> DDZZZBRCIQX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "676")]
		public LegacyCV2Result<None> RMVTUSTNROU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "677")]
		public LegacyCV2Result<None> WRCXMFFRLWK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "678")]
		public LegacyCV2Result<None> SOIBZDLZDSH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "679")]
		public LegacyCV2Result<None> GSMWLOKOKOG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "680")]
		public LegacyCV2Result<None> IMFTGVVOVIZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "681")]
		public LegacyCV2Result<None> QNHPMUPFLMU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "682")]
		public LegacyCV2Result<None> XPEZTBVSPIK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "683")]
		public LegacyCV2Result<None> AXJCIBKKSOT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "684")]
		public LegacyCV2Result<None> OWLFXUNJBZN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "685")]
		public LegacyCV2Result<None> HYXSZTDYORE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "686")]
		public LegacyCV2Result<None> IHBPDXJCPYU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "687")]
		public LegacyCV2Result<None> DHUIIZXFCDP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "688")]
		public LegacyCV2Result<None> TGSEKCBFSDQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "689")]
		public LegacyCV2Result<None> EMVERTFYCYW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "690")]
		public LegacyCV2Result<None> PDJFWNOZCGL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "691")]
		public LegacyCV2Result<None> VCGJHFTASAV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "692")]
		public LegacyCV2Result<None> ARPXRCVQSVB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "693")]
		public LegacyCV2Result<None> PVNQMMOORCI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "765")]
		public LegacyCV2Result<None> SEVVCHNNCDK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "711")]
		public LegacyCV2Result<None> LPGPYNNIYSB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "712")]
		public LegacyCV2Result<None> LXBLPOQJNTF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "713")]
		public LegacyCV2Result<None> VOPCONKIGZH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "714")]
		public LegacyCV2Result<None> YGDFHZFUSOH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "717")]
		public LegacyCV2Result<None> BGNTOTKTYSP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "721")]
		public LegacyCV2Result<None> FKFZLNAJMCK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "722")]
		public LegacyCV2Result<None> VWJRVSRAAQM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "723")]
		public LegacyCV2Result<None> DCVEULTPZOD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "724")]
		public LegacyCV2Result<None> DUQJEOJMKZH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "725")]
		public LegacyCV2Result<None> QJXNQAFAROJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "726")]
		public LegacyCV2Result<None> FESOKUJMBXC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "727")]
		public LegacyCV2Result<None> EGSZESTTDDH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "728")]
		public LegacyCV2Result<None> SKKHWSNIVZW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "729")]
		public LegacyCV2Result<None> BVFCDIBYHHG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "730")]
		public LegacyCV2Result<None> FTFNEPHJVWA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "731")]
		public LegacyCV2Result<None> ZMZRLVVHBOQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "732")]
		public LegacyCV2Result<None> CJQKIMBVAVS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "733")]
		public LegacyCV2Result<None> CLXQDMPMPUS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "734")]
		public LegacyCV2Result<None> RSOYQYFCOAF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "735")]
		public LegacyCV2Result<None> FPKQMJLDEPS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "736")]
		public LegacyCV2Result<None> KWPVGRXOVYW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "737")]
		public LegacyCV2Result<None> QQRCLFQSFIB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "738")]
		public LegacyCV2Result<None> QVGURAFPOTE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "740")]
		public LegacyCV2Result<None> AGBVBQXEQJW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "739")]
		public LegacyCV2Result<None> WIPONHJHTOS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "741")]
		public LegacyCV2Result<None> IMVLOUDVNJB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "742")]
		public LegacyCV2Result<None> CRDYAMIOKWO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "743")]
		public LegacyCV2Result<None> WRXEQGSPUWV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "744")]
		public LegacyCV2Result<None> HQYKWKFWRGV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "745")]
		public LegacyCV2Result<None> IFEIWEMPLEQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "746")]
		public LegacyCV2Result<None> HINUOZHPPUF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "747")]
		public LegacyCV2Result<None> HWVICGWJRBL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "748")]
		public LegacyCV2Result<None> YYWKTARHDMW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "749")]
		public LegacyCV2Result<None> KDYJAQHMCKE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "750")]
		public LegacyCV2Result<None> SHKZEJNILQO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "751")]
		public LegacyCV2Result<None> ONNUCUSBEKK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "752")]
		public LegacyCV2Result<None> OKOPQRBXQJK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "753")]
		public LegacyCV2Result<None> OHQXHMKWGQE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "754")]
		public LegacyCV2Result<None> WYYWIIETEOQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "755")]
		public LegacyCV2Result<None> WTQAQPABIQN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "756")]
		public LegacyCV2Result<None> IQIBJBDPNRL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "757")]
		public LegacyCV2Result<None> POQXFXGTNTB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "758")]
		public LegacyCV2Result<None> XAALDDDLUQR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "759")]
		public LegacyCV2Result<None> FFGRXWGEHBQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "760")]
		public LegacyCV2Result<None> VKOUKQWTFCS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "761")]
		public LegacyCV2Result<None> LTCRLXYYDBA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "762")]
		public LegacyCV2Result<None> ODFOHQOUBPV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "763")]
		public LegacyCV2Result<None> ZRZBCVTVDJP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "764")]
		public LegacyCV2Result<None> LERVTFFAZXE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "771")]
		public LegacyCV2Result<None> SCCOGZNWFXQ(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "772")]
		public LegacyCV2Result<None> UDLEPXWRMMM(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "773")]
		public LegacyCV2Result<None> CQLINBOBHIN(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(TNNPXTPLORO ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "775")]
		public LegacyCV2Result<None> MCVNCIIUFDF(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "776")]
		public LegacyCV2Result<None> TUINBPQPUWN(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "777")]
		public LegacyCV2Result<None> KYNKZRYCAQY(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "778")]
		public LegacyCV2Result<None> FVIEWZUSUBK(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "779")]
		public LegacyCV2Result<None> GZKECRFDRWO(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "707")]
		public LegacyCV2Result<None> VHBDUGSQLIK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "801")]
		public LegacyCV2Result<None> QCLIKUYRZDY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "802")]
		public LegacyCV2Result<None> GVWRHDKUKJU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "803")]
		public LegacyCV2Result<None> TECUDDWCYXM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "804")]
		public LegacyCV2Result<None> VQMHGQDPCXW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "805")]
		public LegacyCV2Result<None> ANEKZARSGEK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "806")]
		public LegacyCV2Result<None> ENPMKZHENUC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "807")]
		public LegacyCV2Result<None> OSJMXBMKCZI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "808")]
		public LegacyCV2Result<None> XDAZCCEEZLC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "809")]
		public LegacyCV2Result<None> KJRRXJUGISW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "810")]
		public LegacyCV2Result<None> ZJRARYZIXAW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "811")]
		public LegacyCV2Result<None> RPPOGNVIVLS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "812")]
		public LegacyCV2Result<None> SALDLZQDQWD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "817")]
		public LegacyCV2Result<None> EJESGNAIRPK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "821")]
		public LegacyCV2Result<None> IHADCYXQZGH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "822")]
		public LegacyCV2Result<None> VBTEUYGGVVD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "823")]
		public LegacyCV2Result<None> QTDDPEZALZX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "824")]
		public LegacyCV2Result<None> CWHNGVXXPNJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "826")]
		public LegacyCV2Result<None> EMDPTGSIOUL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "827")]
		public LegacyCV2Result<None> LOEGVFALZMA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "828")]
		public LegacyCV2Result<None> IMPKTXDMJSO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "831")]
		public LegacyCV2Result<None> OCWLXECKGJA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "832")]
		public LegacyCV2Result<None> JLDCSCXJFNV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "833")]
		public LegacyCV2Result<None> MYMZZNOOEJE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(TNNPXTPLORO e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(TNNPXTPLORO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "836")]
		public LegacyCV2Result<None> WUPFQZGWVOF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HZVYRIFYNHJ(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PWVTTDFYDPJ(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MGKLVRWLWJM(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IFUDZVMSFVF(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZOHAJIJNCAI(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(TNNPXTPLORO e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(TNNPXTPLORO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(TNNPXTPLORO e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(TNNPXTPLORO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(TNNPXTPLORO e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(TNNPXTPLORO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(TNNPXTPLORO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "856")]
		public LegacyCV2Result<None> FDAJCXNWCMB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "859")]
		public LegacyCV2Result<None> VISNTWAFNBX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "860")]
		public LegacyCV2Result<None> EAFCPQATZWP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "861")]
		public LegacyCV2Result<None> BDHQDYJXZNT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "862")]
		public LegacyCV2Result<None> VMHKBCCBNXW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "864")]
		public LegacyCV2Result<None> MWPBLKIGQJL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "865")]
		public LegacyCV2Result<None> HEVVQAXMBQJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(TNNPXTPLORO e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "869")]
		public LegacyCV2Result<None> CEWCKILNSUD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "879")]
		public LegacyCV2Result<None> POXMGLLODUF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "880")]
		public LegacyCV2Result<None> LKBRJKUUYAF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "881")]
		public LegacyCV2Result<None> FVQRVVGOZBO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "882")]
		public LegacyCV2Result<None> BGUMRAEZUIV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(TNNPXTPLORO e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(TNNPXTPLORO e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(TNNPXTPLORO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(TNNPXTPLORO e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(TNNPXTPLORO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "889")]
		public LegacyCV2Result<None> RKXZZBJLGQD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "890")]
		public LegacyCV2Result<None> LEYJYEFOKGU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "891")]
		public LegacyCV2Result<None> VBZJFXAGZSD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "892")]
		public LegacyCV2Result<None> XKXHNPMIKNZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "893")]
		public LegacyCV2Result<None> RWHFVPRUWTP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "897")]
		public LegacyCV2Result<None> KFYPRLJVVTQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "898")]
		public LegacyCV2Result<None> TNHHOFTZMSK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "899")]
		public LegacyCV2Result<None> CIRDGTBCOFT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "901")]
		public LegacyCV2Result<None> BKCSLMLSJFT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "900")]
		public LegacyCV2Result<None> ILHBZMVFGWP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "902")]
		public LegacyCV2Result<None> SNTAALSNVMW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "904")]
		public LegacyCV2Result<None> ZDEUQGENXAS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "903")]
		public LegacyCV2Result<None> DQILFLAOFRU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "905")]
		public LegacyCV2Result<None> BBHXVOLTDJR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "906")]
		public LegacyCV2Result<None> KGHBMMRJIZJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "907")]
		public LegacyCV2Result<None> UPTZMGVHVNO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "908")]
		public LegacyCV2Result<None> AVPXXKHMXRE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "909")]
		public LegacyCV2Result<None> KEOPPHUYNMU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "910")]
		public LegacyCV2Result<None> ZUMWCXNWAXK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "911")]
		public LegacyCV2Result<None> PNXQYHFUFAA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "918")]
		public LegacyCV2Result<None> JVAREFOPIPI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "919")]
		public LegacyCV2Result<None> VZZOTEQBHBG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(TNNPXTPLORO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(TNNPXTPLORO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(TNNPXTPLORO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(TNNPXTPLORO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(TNNPXTPLORO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(TNNPXTPLORO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(TNNPXTPLORO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(TNNPXTPLORO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(TNNPXTPLORO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "941")]
		public LegacyCV2Result<None> GVNFJTZPVFE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "942")]
		public LegacyCV2Result<None> MYYFAIKZDEI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "943")]
		public LegacyCV2Result<None> TGTGYGVDBTF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "944")]
		public LegacyCV2Result<None> LZDJAOXNDKX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "945")]
		public LegacyCV2Result<None> UBWCJCUMMOG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "946")]
		public LegacyCV2Result<None> UAMLIFTJWMO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "947")]
		public LegacyCV2Result<None> NRRWNTNXXCZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "948")]
		public LegacyCV2Result<None> JUHOXOELCWP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "949")]
		public LegacyCV2Result<None> DMJRQQJLMXX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "950")]
		public LegacyCV2Result<None> VCISVWDZGHK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "968")]
		public LegacyCV2Result<None> IGTBROGHXCE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "967")]
		public LegacyCV2Result<None> ZJWPSGQBKNB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "969")]
		public LegacyCV2Result<None> SOEFQEEWOFZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "970")]
		public LegacyCV2Result<None> YZHVECWAIOO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "971")]
		public LegacyCV2Result<None> OFJNQMFRITF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "972")]
		public LegacyCV2Result<None> OCFCLBLPSYJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "973")]
		public LegacyCV2Result<None> KBZTTSRBYAW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "975")]
		public LegacyCV2Result<None> IXYNSVMOUQB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "982")]
		public LegacyCV2Result<None> PCEJPNDIRMU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "983")]
		public LegacyCV2Result<None> NSCNARDFOGQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "991")]
		public LegacyCV2Result<None> VPCMPNUKYPV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "993")]
		public LegacyCV2Result<None> HXSIJYNYRRF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "994")]
		public LegacyCV2Result<None> BIAFNAMGAVH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "995")]
		public LegacyCV2Result<None> GDXJWZJDLEV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "996")]
		public LegacyCV2Result<None> OWGNTACLAZZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "997")]
		public LegacyCV2Result<None> IIXXHKFVXHL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "998")]
		public LegacyCV2Result<None> UFQMBRFPAGN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "999")]
		public LegacyCV2Result<None> VMACAYXPXSD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1000")]
		public LegacyCV2Result<None> AJGVUHCUDRB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1001")]
		public LegacyCV2Result<None> VAGMGXQLOIT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1002")]
		public LegacyCV2Result<None> CZXPDSQBVIL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1009")]
		public LegacyCV2Result<None> CWLCHXDBVPZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1017")]
		public LegacyCV2Result<None> FREOGDGWRAO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1018")]
		public LegacyCV2Result<None> ORXDIGCHVAN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1019")]
		public LegacyCV2Result<None> GAEGBDTFDMS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1020")]
		public LegacyCV2Result<None> WNFQLOMFHFH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1021")]
		public LegacyCV2Result<None> PBUWCSQVLYQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1022")]
		public LegacyCV2Result<None> DMJEJYRSIUJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1023")]
		public LegacyCV2Result<None> UTNRPCZKFMM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1024")]
		public LegacyCV2Result<None> YHJXMJXLRAI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1025")]
		public LegacyCV2Result<None> HIDMMZLZQIT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1026")]
		public LegacyCV2Result<None> BMKTOGRHIUW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1027")]
		public LegacyCV2Result<None> PRENMNFSVSI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1028")]
		public LegacyCV2Result<None> KOWUDLDCDON(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1029")]
		public LegacyCV2Result<None> YYDBHVOCRTB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1030")]
		public LegacyCV2Result<None> TNRZADYDKYE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1031")]
		public LegacyCV2Result<None> QQKRTWLQRQL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1032")]
		public LegacyCV2Result<None> RDZKBWZXDFS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1033")]
		public LegacyCV2Result<None> CGMUMIEMIZW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1047")]
		public LegacyCV2Result<None> RJPGLFGQCMQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1048")]
		public LegacyCV2Result<None> QEOILBAEKXG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1049")]
		public LegacyCV2Result<None> HDFDXEVBZHY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1050")]
		public LegacyCV2Result<None> BAZIIMZTFNQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1051")]
		public LegacyCV2Result<None> RESUEMYTQEX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1052")]
		public LegacyCV2Result<None> IXYJXKYEHSL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1053")]
		public LegacyCV2Result<None> ZFQGYNTVYLI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1054")]
		public LegacyCV2Result<None> QJDPIIQOYVR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1055")]
		public LegacyCV2Result<None> GDMOTLLJMBI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1056")]
		public LegacyCV2Result<None> AFCTKEKQIWZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1057")]
		public LegacyCV2Result<None> RTGJMCMODZF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1058")]
		public LegacyCV2Result<None> COZEBIUYMJU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1059")]
		public LegacyCV2Result<None> BGRSVRMFCTT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1060")]
		public LegacyCV2Result<None> FGXHFCARRPB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1061")]
		public LegacyCV2Result<None> RRYRFILPBJB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1062")]
		public LegacyCV2Result<None> SBYUGYBLIHF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1063")]
		public LegacyCV2Result<None> GOEUKDXGMVN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1064")]
		public LegacyCV2Result<None> WULXVDVAUIK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1065")]
		public LegacyCV2Result<None> YKQJHRQNRGO(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1066")]
		public LegacyCV2Result<None> DDZWVMXDFSF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1067")]
		public LegacyCV2Result<None> KZUACQEURZD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1068")]
		public LegacyCV2Result<None> FGEDYUWOXYL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1069")]
		public LegacyCV2Result<None> KFAWIZPPZHR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1070")]
		public LegacyCV2Result<None> MQUPQAYLKUG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1071")]
		public LegacyCV2Result<None> FOWLCMPKLHA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x28ADAA0", Offset = "0x28ACAA0", VA = "0x1828ADAA0", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(TNNPXTPLORO e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(TNNPXTPLORO e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1092")]
		public LegacyCV2Result<None> CHYFPBZYEVV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1093")]
		public LegacyCV2Result<None> RCVPQTBWAXY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1094")]
		public LegacyCV2Result<None> JGMRHVJVBXQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1095")]
		public LegacyCV2Result<None> OFUQTTNVDIS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1096")]
		public LegacyCV2Result<None> MHWTUITSVHA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1097")]
		public LegacyCV2Result<None> UGCNRUODSCG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1098")]
		public LegacyCV2Result<None> UTVZEHNNUSS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1099")]
		public LegacyCV2Result<None> KAECUYHZFNW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1100")]
		public LegacyCV2Result<None> XDRQCWEYGOU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1101")]
		public LegacyCV2Result<None> TGQWTEXNEIU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1102")]
		public LegacyCV2Result<None> BZUDXLCHDMU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1103")]
		public LegacyCV2Result<None> UFMSXDADYIP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1104")]
		public LegacyCV2Result<None> ANPYHAJGFMH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1105")]
		public LegacyCV2Result<None> STQLCRMBOFF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1106")]
		public LegacyCV2Result<None> SIMUSXHWLWL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1107")]
		public LegacyCV2Result<None> TWKZNCHYEGW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1108")]
		public LegacyCV2Result<None> NKLWDLSISVU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1109")]
		public LegacyCV2Result<None> VTVPNKALSEF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1110")]
		public LegacyCV2Result<None> ASCZPCXULBD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1111")]
		public LegacyCV2Result<None> JHWCBLHVNXN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1112")]
		public LegacyCV2Result<None> SINDLSGYOTF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1113")]
		public LegacyCV2Result<None> HDYJQQDMLZI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1114")]
		public LegacyCV2Result<None> QMDGNBZEWZA(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1115")]
		public LegacyCV2Result<None> DJKLVTWYSXR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1116")]
		public LegacyCV2Result<None> JOIWJEMGOYT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1117")]
		public LegacyCV2Result<None> WZWZJITWEKT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1118")]
		public LegacyCV2Result<None> GSQVMUACGIT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1119")]
		public LegacyCV2Result<None> UGYZRQAVUWK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1120")]
		public LegacyCV2Result<None> AVMJXVTXXKX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1121")]
		public LegacyCV2Result<None> OXEPCDIDTKN(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1122")]
		public LegacyCV2Result<None> PWAEAIZLFMF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1123")]
		public LegacyCV2Result<None> BQITISWIBSI(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1124")]
		public LegacyCV2Result<None> DOONMBJGKUU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1125")]
		public LegacyCV2Result<None> NJIIJJCPPTU(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1126")]
		public LegacyCV2Result<None> NYUQPOTZIJI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1127")]
		public LegacyCV2Result<None> BGWAZBANLZC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1128")]
		public LegacyCV2Result<None> CQRLTEWNCIE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1129")]
		public LegacyCV2Result<None> BZGWPFLQYNW(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1130")]
		public LegacyCV2Result<None> HWLSEIETLFL(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1131")]
		public LegacyCV2Result<None> DPOQPWRMQZQ(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1132")]
		public LegacyCV2Result<None> IZTGDLWDNWV(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1133")]
		public LegacyCV2Result<None> CQVXYYQUPDE(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1134")]
		public LegacyCV2Result<None> WZBZDCELVEG(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1135")]
		public LegacyCV2Result<None> GFORGZXXTZL(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1136")]
		public LegacyCV2Result<None> YMDDNWKJCZX(PRQSSYDLWIV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1140")]
		public LegacyCV2Result<None> XVQFBELWQRR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1166")]
		public LegacyCV2Result<None> ELDMFYIIGKZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1168")]
		public LegacyCV2Result<None> RMOQRAVRKCV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1169")]
		public LegacyCV2Result<None> LLOJHDQHHRC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1170")]
		public LegacyCV2Result<None> EXJCTBUYQZN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1171")]
		public LegacyCV2Result<None> YEJRZXTUTUW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1182")]
		public LegacyCV2Result<None> OEXNODCUQOG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1183")]
		public LegacyCV2Result<None> BLQKTVDLZZU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1184")]
		public LegacyCV2Result<None> KBCIRYLAUGY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1185")]
		public LegacyCV2Result<None> XLKCGYAGTPC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1186")]
		public LegacyCV2Result<None> ZVWHAOPWQVV(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1187")]
		public LegacyCV2Result<None> ORHMQJSTBTH(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1188")]
		public LegacyCV2Result<None> MVCYWYSHCGZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1189")]
		public LegacyCV2Result<None> DFSNIQRDHRR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1190")]
		public LegacyCV2Result<None> ODJHMJTVEVI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1191")]
		public LegacyCV2Result<None> YGZMHWIMDNI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1192")]
		public LegacyCV2Result<None> PIVIHIHOKGR(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1193")]
		public LegacyCV2Result<None> ULJPYURTQXQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "184")]
		public LegacyCV2Result<None> VRXHYRZKJXG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x28ADBB0", Offset = "0x28ACBB0", VA = "0x1828ADBB0", Slot = "191")]
		public bool UIWRZRUOEVE(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1194")]
		public LegacyCV2Result<None> ERVUXHMCROW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1195")]
		public LegacyCV2Result<None> RNTCYDMDMYB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1196")]
		public LegacyCV2Result<None> UMLMQBTOLLE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(TNNPXTPLORO e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1205")]
		public LegacyCV2Result<None> TCLSRRRSJUT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1206")]
		public LegacyCV2Result<None> NQZCCYGVYJZ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(TNNPXTPLORO e, InOut io, JTAZPAWUZRZ objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "250")]
		public LegacyCV2Result<None> FFHUXESYKPI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "251")]
		public LegacyCV2Result<None> VPFZOSIABTE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "252")]
		public LegacyCV2Result<None> GNECKQGZPFM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "254")]
		public LegacyCV2Result<None> LCMAXOKCZYD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "255")]
		public LegacyCV2Result<None> GYFAXZUBIUJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "256")]
		public LegacyCV2Result<None> UDDYNBTVSYF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "257")]
		public LegacyCV2Result<None> EJTLFGVSAAS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "258")]
		public LegacyCV2Result<None> GICOOSYDRYK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "259")]
		public LegacyCV2Result<None> JKBJJQRWEPN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "260")]
		public LegacyCV2Result<None> EYXHVHMIHAD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "261")]
		public LegacyCV2Result<None> UPHOOTNTLOJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "262")]
		public LegacyCV2Result<None> WDHAEOZBSGB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "263")]
		public LegacyCV2Result<None> VCDYJSKJBHQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "264")]
		public LegacyCV2Result<None> ETANOJCPTRY(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "265")]
		public LegacyCV2Result<None> KRZSCQWXAFU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "266")]
		public LegacyCV2Result<None> JMLXVXVWYSI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "267")]
		public LegacyCV2Result<None> HGRDVBZMQHS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "268")]
		public LegacyCV2Result<None> KUOQQFSUJUC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "269")]
		public LegacyCV2Result<None> QYPSVVMCBOS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0")]
		private static LegacyCV2Result<None> Default(TNNPXTPLORO e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x28ADAE0", Offset = "0x28ACAE0", VA = "0x1828ADAE0", Slot = "1209")]
		public LegacyCV2Result<None> PFKTTELRGIB(TNNPXTPLORO a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1212")]
		public LegacyCV2Result<None> EAJJBNXKNCE(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1213")]
		public LegacyCV2Result<None> TNUOYHHPPMS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1214")]
		public LegacyCV2Result<None> YBLANWBZZWI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1215")]
		public LegacyCV2Result<None> MFAFWJRKOHL(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(TNNPXTPLORO e, InOut io, LIMIDQITZIR quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1036")]
		public LegacyCV2Result<None> AQCHKFZCJBQ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1037")]
		public LegacyCV2Result<None> YPZAYHAFIGG(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1038")]
		public LegacyCV2Result<None> RJHWEDPNOPI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1039")]
		public LegacyCV2Result<None> MYWAMFFZWPM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1040")]
		public LegacyCV2Result<None> DXQIEHKEFYM(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1041")]
		public LegacyCV2Result<None> UBKNHKAZVPS(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1042")]
		public LegacyCV2Result<None> TWIENEWIIMW(TNNPXTPLORO a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1043")]
		public LegacyCV2Result<None> XYNXYMGFMJK(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1044")]
		public LegacyCV2Result<None> IRSNQZCMIFW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1045")]
		public LegacyCV2Result<None> XXZRCUZXGVN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1046")]
		public LegacyCV2Result<None> INDTKADBUBJ(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HRSPLXWXTIV(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1234")]
		public LegacyCV2Result<None> WVOGIYKQBPW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1236")]
		public LegacyCV2Result<None> XAYAJZACXGT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1229")]
		public LegacyCV2Result<None> UBOOAEWZXST(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1241")]
		public LegacyCV2Result<None> ONAYRDBDKHP(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1242")]
		public LegacyCV2Result<None> CXQKOEAXTXC(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1243")]
		public LegacyCV2Result<None> BLDGTMIJKKI(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1244")]
		public LegacyCV2Result<None> WKDSJSMHFDW(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1245")]
		public LegacyCV2Result<None> OVGOAWDQOTD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CVIAROZIEBT(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AAILLNMJBHH(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YTYBNHHBBIR(TNNPXTPLORO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1259")]
		public LegacyCV2Result<None> QYUKKQZYFPF(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1260")]
		public LegacyCV2Result<None> VBOUKZEXLFT(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1261")]
		public LegacyCV2Result<None> BDMCZXVAIFD(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1262")]
		public LegacyCV2Result<None> HTMDKZSOARB(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x28ADBC0", Offset = "0x28ACBC0", VA = "0x1828ADBC0")]
		public YXFYOBHPRUA([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(TNNPXTPLORO e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1280")]
		public LegacyCV2Result<None> QMFPMXXDAIU(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1281")]
		public LegacyCV2Result<None> PTOMDEMOYNX(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "599")]
		public LegacyCV2Result<None> NWPCOKQDUYN(TNNPXTPLORO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1293")]
		public LegacyCV2Result<None> ZGKQEBDNFLE(PRQSSYDLWIV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1294")]
		public LegacyCV2Result<None> SRNMNVVKVKF(PRQSSYDLWIV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1295")]
		public LegacyCV2Result<None> JSNRMIHAHCS(PRQSSYDLWIV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1296")]
		public LegacyCV2Result<None> XZHOPHJSHLA(PRQSSYDLWIV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1297")]
		public LegacyCV2Result<None> CYRYRCOYCKZ(PRQSSYDLWIV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0")]
		public LegacyCV2Result<None> ConstantStorefrontItem(TNNPXTPLORO e, InOut io, [In] WAVHLXLYFEQ storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(TNNPXTPLORO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> RRVOZGGQZJT(TNNPXTPLORO a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, OCBZRBWSEML.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> TRKCULZSAHF(TNNPXTPLORO a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, OCBZRBWSEML.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1207")]
		private LegacyCV2Result<None> FMROTNCNJJC(TNNPXTPLORO a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1216")]
		private LegacyCV2Result<None> DCCYACEGIYL(TNNPXTPLORO a, InOut b, [In] WAVHLXLYFEQ storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xE99EA0", Offset = "0xE98EA0", VA = "0x180E99EA0", Slot = "1257")]
		private LegacyCV2Result<None> HTTAPUNGMJP(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class MNXZICJFWQZ : KAFBXKDIWCC
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(LZMAONPIYRD node);

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly MNXZICJFWQZ KBHUGEVMPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate HBEYNUVNQXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate IMKTBDYSDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private bool QXCTJEGYHWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private bool PDKJHUHDUKU;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x28AF030", Offset = "0x28AE030", VA = "0x1828AF030", Slot = "4")]
		public Task<bool> OUYAXZBHXLN(LZMAONPIYRD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x28AFC50", Offset = "0x28AEC50", VA = "0x1828AFC50", Slot = "5")]
		public Task<bool> SCTFUXTNFEG(LZMAONPIYRD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x28AFD00", Offset = "0x28AED00", VA = "0x1828AFD00")]
		public MNXZICJFWQZ([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x28AFC30", Offset = "0x28AEC30", VA = "0x1828AFC30", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? GDQDVAWUSPX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xAD2F00", Offset = "0xAD1F00", VA = "0x180AD2F00", Slot = "7")]
		public bool FCXNUBINYIY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x1366560", Offset = "0x1365560", VA = "0x181366560", Slot = "8")]
		public bool YYAOZOBYGIU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class NSFNWJGTJXF : HKOMGWVIADY
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid WSFLKLJQNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xC9D7C0", Offset = "0xC9C7C0", VA = "0x180C9D7C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
		public void Bind(HIYQNPLRBCM pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xEB88D0", Offset = "0xEB78D0", VA = "0x180EB88D0")]
		public NSFNWJGTJXF(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x28B2890", Offset = "0x28B1890", VA = "0x1828B2890")]
		public static NSFNWJGTJXF New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class NGDBFIOAYBT : WIQKHRMUIPP
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<XWYEQLTFQES> nodeDefId, Id128<YHQFEYRJQPY>? legacyInnerGraphId, IReadOnlyDictionary<Id128<YHQFEYRJQPY>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IsNodeRestrictedDelegate? CCRBGLUJYNI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool FBWBXWEFOFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xB21140", Offset = "0xB20140", VA = "0x180B21140", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HYAMUDLJTXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x28B0AD0", Offset = "0x28AFAD0", VA = "0x1828B0AD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BJCOOYUPZLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xFB40D0", Offset = "0xFB30D0", VA = "0x180FB40D0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "6")]
		public bool GUVCSAKLPCO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "7")]
		public CanSaveObjectIntoInventionResultType NSJMOEEUYCL(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x28B0A80", Offset = "0x28AFA80", VA = "0x1828B0A80", Slot = "8")]
		public bool PMYUSLQFJQO(Id128<XWYEQLTFQES> nodeDefId, Id128<YHQFEYRJQPY>? legacyInnerGraphId, IReadOnlyDictionary<Id128<YHQFEYRJQPY>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "9")]
		public bool PWQKYUTFCJH(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "10")]
		public bool ZWPJYENXMMV(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x28B0AE0", Offset = "0x28AFAE0", VA = "0x1828B0AE0")]
		public NGDBFIOAYBT(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class PUEGZPDJXJL : CKBFWSXPWXU
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly PUEGZPDJXJL KBHUGEVMPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly ShouldLogEventSenderToMakerPenDelegate EDLMJDIDLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate DANGARAIABT;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KXPKZDKTVNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x1059E90", Offset = "0x1058E90", VA = "0x181059E90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool PQYIZSESXEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x28B28F0", Offset = "0x28B18F0", VA = "0x1828B28F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x28B2990", Offset = "0x28B1990", VA = "0x1828B2990")]
		public PUEGZPDJXJL([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ZDRGGGROUDP : OUBSWFYBBQL<IBWRJZFPGUT>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class BFEKZBQQKFU : IBWRJZFPGUT, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly BFEKZBQQKFU QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool GJOEZEWWJNO
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x28AE6E0", Offset = "0x28AD6E0", VA = "0x1828AE6E0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			public void NINPZEGLIVW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public BFEKZBQQKFU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly ZDRGGGROUDP QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private ZDRGGGROUDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x28B7610", Offset = "0x28B6610", VA = "0x1828B7610", Slot = "4")]
		public IBWRJZFPGUT MEQQCLQBOMC()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class BHSQOXYFTHX<a, b> : IDisposable, SPVIFMMAWWI where a : notnull where b : notnull, CFQQKHGMRUH.GJBEFWGGCMP<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly b USEUOEMXTCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly a URWYPHZQTOI;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<OFTCEQFRRMD> SGKZBGDKDLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<OFTCEQFRRMD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x3D4D110", Offset = "0x3D4C110", VA = "0x183D4D110")]
		public BHSQOXYFTHX(b a, a b, Id32<OFTCEQFRRMD> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B610", Offset = "0x3D4A610", VA = "0x183D4B610", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C0A0", Offset = "0x3D4B0A0", VA = "0x183D4C0A0")]
		public Id32<UYHKNYSICNO> UAVWIQDJTWV([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<UYHKNYSICNO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x3D4BB80", Offset = "0x3D4AB80", VA = "0x183D4BB80", Slot = "6")]
		public void IGXFTZCMFSC(Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C060", Offset = "0x3D4B060", VA = "0x183D4C060", Slot = "7")]
		public void OEGJEUJVREI(Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C8D0", Offset = "0x3D4B8D0", VA = "0x183D4C8D0", Slot = "8")]
		public void WRBOLMTFFJP(Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AEE0", Offset = "0x3D49EE0", VA = "0x183D4AEE0", Slot = "10")]
		public void AODQQDRRCUW(Id32<UYHKNYSICNO> objectId, Id32<OFTCEQFRRMD> clientId, LUDZPBIZHHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C5C0", Offset = "0x3D4B5C0", VA = "0x183D4C5C0", Slot = "9")]
		public void VSKCWQORRBS(Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x3D4BE10", Offset = "0x3D4AE10", VA = "0x183D4BE10", Slot = "11")]
		public void KOQAEJKWWVQ(Id32<UYHKNYSICNO> objectId, DCRGBHKLLZL? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x3D4D040", Offset = "0x3D4C040", VA = "0x183D4D040", Slot = "12")]
		public Id32<OFTCEQFRRMD> XXOIPUYBCYF(Id32<UYHKNYSICNO> objectId)
		{
			return default(Id32<OFTCEQFRRMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B650", Offset = "0x3D4A650", VA = "0x183D4B650", Slot = "13")]
		public Id32<TETUOZPDWQY> GPUMNMEIKJF(Id32<UYHKNYSICNO> objectId, string a, object b, bool c, VWDJTLBCZIU d, RVXIGOQBMTO e)
		{
			return default(Id32<TETUOZPDWQY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B3B0", Offset = "0x3D4A3B0", VA = "0x183D4B3B0", Slot = "14")]
		public void CVIHMMNIXVD(Id32<TETUOZPDWQY> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C880", Offset = "0x3D4B880", VA = "0x183D4C880", Slot = "15")]
		public void VUTICDYFKCJ(Id32<TETUOZPDWQY> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class CFQQKHGMRUH
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface GJBEFWGGCMP<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SGTYFMRBSFJ(a a, Id32<OFTCEQFRRMD> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<OFTCEQFRRMD>? WWDSJYGYEZO(a a);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<UYHKNYSICNO> UAVWIQDJTWV(a a, Id32<OFTCEQFRRMD> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void IGXFTZCMFSC(a a, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void OEGJEUJVREI(a a, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void AODQQDRRCUW(a a, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ b);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void VSKCWQORRBS(a a, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ b);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void KOQAEJKWWVQ(a a, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, DCRGBHKLLZL? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<OFTCEQFRRMD>? XXOIPUYBCYF(a a, Id32<UYHKNYSICNO> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<TETUOZPDWQY> GPUMNMEIKJF(a a, Id32<OFTCEQFRRMD> clientId, string b, object c, VWDJTLBCZIU d, RVXIGOQBMTO e);

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void CVIHMMNIXVD(a a, Id32<OFTCEQFRRMD> clientId, Id32<TETUOZPDWQY> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void VUTICDYFKCJ(a a, Id32<OFTCEQFRRMD> clientId, Id32<TETUOZPDWQY> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class NLPADRRXGET
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly HashSet<Id32<UYHKNYSICNO>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAId32Field<TETUOZPDWQY, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public readonly Dictionary<Id32<TETUOZPDWQY>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<TETUOZPDWQY>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public SOAField<UYHKNYSICNO, DCRGBHKLLZL?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x28B0720", Offset = "0x28AF720", VA = "0x1828B0720")]
			private MockCV2DynamicNetSys(HashSet<Id32<UYHKNYSICNO>> authorityOf, [In] SOAId32Field<TETUOZPDWQY, MockCV2SyncField> syncFields, Dictionary<Id32<TETUOZPDWQY>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<TETUOZPDWQY>> mockSyncFieldToSyncField, [In] SOAField<UYHKNYSICNO, DCRGBHKLLZL?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x28B0560", Offset = "0x28AF560", VA = "0x1828B0560")]
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
			public Id32<OFTCEQFRRMD>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x28B07C0", Offset = "0x28AF7C0", VA = "0x1828B07C0")]
			public MockCV2ObjectShared(Id32<OFTCEQFRRMD> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public RVXIGOQBMTO SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public VWDJTLBCZIU SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
			internal MockCV2SyncField(RVXIGOQBMTO syncField, VWDJTLBCZIU syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x28B08E0", Offset = "0x28AF8E0", VA = "0x1828B08E0")]
			public static MockCV2SyncField New(RVXIGOQBMTO syncField, VWDJTLBCZIU syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x28B0890", Offset = "0x28AF890", VA = "0x1828B0890")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x28B0840", Offset = "0x28AF840", VA = "0x1828B0840")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<UYHKNYSICNO, MockCV2ObjectShared> XXCJIHNHJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<UYHKNYSICNO>> BKGYIKUBMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> CIZRRRQPJEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> NMVPIZTLNBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private SOAField<OFTCEQFRRMD, MockCV2DynamicNetSys> IXEBEJGIAMU;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<UYHKNYSICNO>? OOINDHZLXXW
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xB6B480", Offset = "0xB6A480", VA = "0x180B6B480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x100F910", Offset = "0x100E910", VA = "0x18100F910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x28B0DF0", Offset = "0x28AFDF0", VA = "0x1828B0DF0")]
		public void Destroy([In] SOAId32<OFTCEQFRRMD> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x28B13E0", Offset = "0x28B03E0", VA = "0x1828B13E0")]
		public void NYQQCTHCSKZ(Id32<OFTCEQFRRMD> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x28B1980", Offset = "0x28B0980", VA = "0x1828B1980")]
		public void SGTYFMRBSFJ(Id32<OFTCEQFRRMD> clientId, Id32<OFTCEQFRRMD>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x28B1DA0", Offset = "0x28B0DA0", VA = "0x1828B1DA0")]
		public Id32<UYHKNYSICNO> UAVWIQDJTWV(Id32<OFTCEQFRRMD> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<OFTCEQFRRMD> clientIds)
		{
			return default(Id32<UYHKNYSICNO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x28B1030", Offset = "0x28B0030", VA = "0x1828B1030")]
		public Id32<TETUOZPDWQY> GPUMNMEIKJF(Id32<OFTCEQFRRMD> clientId, string a, object b, VWDJTLBCZIU c, RVXIGOQBMTO d)
		{
			return default(Id32<TETUOZPDWQY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x28B0C60", Offset = "0x28AFC60", VA = "0x1828B0C60")]
		public void CVIHMMNIXVD(Id32<OFTCEQFRRMD> clientId, Id32<TETUOZPDWQY> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x28B1CD0", Offset = "0x28B0CD0", VA = "0x1828B1CD0")]
		public Id32<UYHKNYSICNO>? TQVOIGQQYFW([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x28B1290", Offset = "0x28B0290", VA = "0x1828B1290")]
		public void IGXFTZCMFSC([In] SOAId32<OFTCEQFRRMD> clientIds, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x28B1840", Offset = "0x28B0840", VA = "0x1828B1840")]
		public void OEGJEUJVREI(Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x28B0B60", Offset = "0x28AFB60", VA = "0x1828B0B60")]
		public void AODQQDRRCUW(Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x28B21B0", Offset = "0x28B11B0", VA = "0x1828B21B0")]
		public void VSKCWQORRBS([In] SOAId32<OFTCEQFRRMD> clientIds, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x28B1310", Offset = "0x28B0310", VA = "0x1828B1310")]
		public void KOQAEJKWWVQ(Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, DCRGBHKLLZL? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x28B26A0", Offset = "0x28B16A0", VA = "0x1828B26A0")]
		public Id32<OFTCEQFRRMD>? XXOIPUYBCYF(Id32<UYHKNYSICNO> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x28B2330", Offset = "0x28B1330", VA = "0x1828B2330")]
		public void VUTICDYFKCJ([In] SOAId32<OFTCEQFRRMD> clientIds, Id32<OFTCEQFRRMD> clientId, Id32<TETUOZPDWQY> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x28B26F0", Offset = "0x28B16F0", VA = "0x1828B26F0")]
		public NLPADRRXGET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class HMMXETXXYSW
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x28AEA90", Offset = "0x28ADA90", VA = "0x1828AEA90")]
		public static void Destroy(this NLPADRRXGET.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class UETJPYRBGRG : CKKHMDLKIII.OAIZGCDVQOY
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static UETJPYRBGRG SHEJGKHPSUV;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate OSEFMXYKGSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate UJOGYTPPSRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xACA870", Offset = "0xAC9870", VA = "0x180ACA870")]
		public UETJPYRBGRG(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class KNSHTKDPPBO : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : NKGUVMYRRNL.LSMBPXCSTGO<PQYWNUACEKJ, KNSHTKDPPBO>
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
				public AsyncTaskMethodBuilder<Result<object, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public KNSHTKDPPBO root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public Id32<OFTCEQFRRMD> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public PQYWNUACEKJ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				private TaskAwaiter<Result<object, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0x28B5FD0", Offset = "0x28B4FD0", VA = "0x1828B5FD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0x28B6210", Offset = "0x28B5210", VA = "0x1828B6210", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "4")]
			public int MYCMEDJGDUA(KNSHTKDPPBO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x28B3110", Offset = "0x28B2110", VA = "0x1828B3110", Slot = "5")]
			public int QEWGVXSYCDO(KNSHTKDPPBO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x28B30D0", Offset = "0x28B20D0", VA = "0x1828B30D0", Slot = "6")]
			public int EUPNHNMHDRN(KNSHTKDPPBO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x28B30F0", Offset = "0x28B20F0", VA = "0x1828B30F0", Slot = "7")]
			public int PGFUGAVLHJZ(KNSHTKDPPBO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x28B3080", Offset = "0x28B2080", VA = "0x1828B3080", Slot = "8")]
			public void BCIFMGYBRGO(KNSHTKDPPBO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "9")]
			public bool ROKYPSMZANN(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> actorId, PQYWNUACEKJ[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "10")]
			public bool FTSBWEDBMPP(KNSHTKDPPBO a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x28B3130", Offset = "0x28B2130", VA = "0x1828B3130", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, WENLUTALDTF>> TDXULBVXUUN(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> senderId, PQYWNUACEKJ b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : NKGUVMYRRNL.GJLSAJUAVJH<ActionDeps, UOILJAPMYSC.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps YTBGAMRZLNR
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public UOILJAPMYSC.StaticNetSysReceiverDeps CGGLGLGIODW
			{
				[Cpp2IlInjected.Token(Token = "0x60007AD")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "5")]
				get
				{
					return default(UOILJAPMYSC.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps RUTUCFMPLRT
			{
				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : SQHYJUCIACL.GJBEFWGGCMP<KNSHTKDPPBO>
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
				public AsyncTaskMethodBuilder<Result<object?, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public KNSHTKDPPBO root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public Id32<OFTCEQFRRMD> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public PQYWNUACEKJ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				private TaskAwaiter<Result<object?, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007B0")]
				[Cpp2IlInjected.Address(RVA = "0x28B5CB0", Offset = "0x28B4CB0", VA = "0x1828B5CB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007B1")]
				[Cpp2IlInjected.Address(RVA = "0x28B5F60", Offset = "0x28B4F60", VA = "0x1828B5F60", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x28B0920", Offset = "0x28AF920", VA = "0x1828B0920", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, WENLUTALDTF>> TDXULBVXUUN(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> clientId, PQYWNUACEKJ b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : CFQQKHGMRUH.GJBEFWGGCMP<KNSHTKDPPBO>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x28B0470", Offset = "0x28AF470", VA = "0x1828B0470", Slot = "4")]
			public void SGTYFMRBSFJ(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xCF61B0", Offset = "0xCF51B0", VA = "0x180CF61B0", Slot = "5")]
			public Id32<OFTCEQFRRMD>? WWDSJYGYEZO(KNSHTKDPPBO a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x28B02B0", Offset = "0x28AF2B0", VA = "0x1828B02B0")]
			public Id32<UYHKNYSICNO> UAVWIQDJTWV(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<UYHKNYSICNO>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x28B0140", Offset = "0x28AF140", VA = "0x1828B0140", Slot = "7")]
			public void IGXFTZCMFSC(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x28B0310", Offset = "0x28AF310", VA = "0x1828B0310", Slot = "8")]
			public void OEGJEUJVREI(KNSHTKDPPBO a, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x28AFF00", Offset = "0x28AEF00", VA = "0x1828AFF00", Slot = "9")]
			public void AODQQDRRCUW(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x28B04A0", Offset = "0x28AF4A0", VA = "0x1828B04A0", Slot = "10")]
			public void VSKCWQORRBS(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, LUDZPBIZHHZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x28B01D0", Offset = "0x28AF1D0", VA = "0x1828B01D0", Slot = "11")]
			public void KOQAEJKWWVQ(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> clientId, Id32<UYHKNYSICNO> objectId, DCRGBHKLLZL? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x28B0500", Offset = "0x28AF500", VA = "0x1828B0500", Slot = "12")]
			public Id32<OFTCEQFRRMD>? XXOIPUYBCYF(KNSHTKDPPBO a, Id32<UYHKNYSICNO> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x28B00E0", Offset = "0x28AF0E0", VA = "0x1828B00E0", Slot = "13")]
			public Id32<TETUOZPDWQY> GPUMNMEIKJF(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> clientId, string b, object c, VWDJTLBCZIU d, RVXIGOQBMTO e)
			{
				return default(Id32<TETUOZPDWQY>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x28AFF40", Offset = "0x28AEF40", VA = "0x1828AFF40", Slot = "14")]
			public void CVIHMMNIXVD(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> clientId, Id32<TETUOZPDWQY> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x28B04D0", Offset = "0x28AF4D0", VA = "0x1828B04D0", Slot = "15")]
			public void VUTICDYFKCJ(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> clientId, Id32<TETUOZPDWQY> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x28B02B0", Offset = "0x28AF2B0", VA = "0x1828B02B0", Slot = "6")]
			private Id32<UYHKNYSICNO> MEJQSVLBCKP(KNSHTKDPPBO a, Id32<OFTCEQFRRMD> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<UYHKNYSICNO>);
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
			public KNSHTKDPPBO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public Id32<UYHKNYSICNO>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public DPGTGQXFVAL deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private Id32<OFTCEQFRRMD> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private JVSIOPAFIHP<KNSHTKDPPBO, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private BHSQOXYFTHX<KNSHTKDPPBO, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private UOILJAPMYSC <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x28B55F0", Offset = "0x28B45F0", VA = "0x1828B55F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x28B5C40", Offset = "0x28B4C40", VA = "0x1828B5C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly DKWRUSDPYHR<PQYWNUACEKJ, None, UOILJAPMYSC, ActionDeps, UOILJAPMYSC.StaticNetSysReceiverDeps, RootDeps, KNSHTKDPPBO, Deps> EUEIQJYPJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly NLPADRRXGET DXGWXMFFOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAId32<OFTCEQFRRMD> RMMXRFOBHTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private SOAField<OFTCEQFRRMD, None> IXEBEJGIAMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private SOAField<OFTCEQFRRMD, UOILJAPMYSC> SYUGAVFAQZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Id32<OFTCEQFRRMD>? DNMNDJVRNYR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate RQUCLZHDJPH
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xACDCA0", Offset = "0xACCCA0", VA = "0x180ACDCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x28AF8D0", Offset = "0x28AE8D0", VA = "0x1828AF8D0")]
		public KNSHTKDPPBO(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x28AF210", Offset = "0x28AE210", VA = "0x1828AF210", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x28AF4C0", Offset = "0x28AE4C0", VA = "0x1828AF4C0")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> NYQQCTHCSKZ(DPGTGQXFVAL a, RegistryV2 b, Id32<UYHKNYSICNO>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x28AF640", Offset = "0x28AE640", VA = "0x1828AF640")]
		private void SGTYFMRBSFJ(Id32<OFTCEQFRRMD> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x28AF3E0", Offset = "0x28AE3E0", VA = "0x1828AF3E0")]
		[CompilerGenerated]
		private Id32<UYHKNYSICNO>? EXGVYWHDHJJ([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class XWDAHBWPTGR : UIREVXYUNXH.OAIZGCDVQOY
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<NZDCYEHGQGM> DeserializeCircuitsJunctionAsyncDelegate(UOILJAPMYSC circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<NZDCYEHGQGM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public XWDAHBWPTGR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public UOILJAPMYSC circuitsManager;

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
			private TaskAwaiter<NZDCYEHGQGM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x28B42E0", Offset = "0x28B32E0", VA = "0x1828B42E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x28B44E0", Offset = "0x28B34E0", VA = "0x1828B44E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate TSDJMYDJPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly LifecycleDidInitializeDelegate? WNYEZNCNVYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly LifecycleWillDestroyDelegate? IAJVQNAFKUN;

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x28B72C0", Offset = "0x28B62C0", VA = "0x1828B72C0", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<NZDCYEHGQGM> DOQTRTGCMPP(UOILJAPMYSC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
		public void VWDSSIPUNTV(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xD84AB0", Offset = "0xD83AB0", VA = "0x180D84AB0", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xE2A830", Offset = "0xE29830", VA = "0x180E2A830", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x28B7430", Offset = "0x28B6430", VA = "0x1828B7430")]
		public XWDAHBWPTGR([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class TDGMEXCJRLT : YDXEBHQLRCV.OAIZGCDVQOY
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate MLJAAVCGGXT GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<ZWCOPVGGMMD> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<DLNBIGPDDFF> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<YDXEBHQLRCV.OAIZGCDVQOY.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<YDXEBHQLRCV.OAIZGCDVQOY.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public TDGMEXCJRLT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter<YDXEBHQLRCV.OAIZGCDVQOY.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x28B4550", Offset = "0x28B3550", VA = "0x1828B4550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x28B4740", Offset = "0x28B3740", VA = "0x1828B4740", Slot = "5")]
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
			public AsyncTaskMethodBuilder<DLNBIGPDDFF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public TDGMEXCJRLT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			private TaskAwaiter<DLNBIGPDDFF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x28B47B0", Offset = "0x28B37B0", VA = "0x1828B47B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x28B49A0", Offset = "0x28B39A0", VA = "0x1828B49A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<ZWCOPVGGMMD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public TDGMEXCJRLT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private TaskAwaiter<ZWCOPVGGMMD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x28B4A10", Offset = "0x28B3A10", VA = "0x1828B4A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x28B4C00", Offset = "0x28B3C00", VA = "0x1828B4C00", Slot = "5")]
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
			public TDGMEXCJRLT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x28B4C70", Offset = "0x28B3C70", VA = "0x1828B4C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x28B4E60", Offset = "0x28B3E60", VA = "0x1828B4E60", Slot = "5")]
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
			public TDGMEXCJRLT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x28B4ED0", Offset = "0x28B3ED0", VA = "0x1828B4ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x28B50C0", Offset = "0x28B40C0", VA = "0x1828B50C0", Slot = "5")]
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
			public TDGMEXCJRLT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x28B5130", Offset = "0x28B4130", VA = "0x1828B5130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x28B5320", Offset = "0x28B4320", VA = "0x1828B5320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetCV2DependenciesDelegate LSIFLWAQMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomDataAsyncDelegate KISCJUHRCXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetSuperRoomDataAsyncDelegate PAZJMOVFAQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetRoomAssetDataAsyncDelegate TAMPSVNJUXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetPlayerSaveDataAsyncDelegate PTJVUFYKXNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate MIUZOMNNKSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly GetStaticCircuitsConfigAsyncDelegate UFZEYRSXPHN;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public MLJAAVCGGXT MLJAAVCGGXT
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x1059E90", Offset = "0x1058E90", VA = "0x181059E90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x28B34A0", Offset = "0x28B24A0", VA = "0x1828B34A0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> BQBDJCANAKW(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x28B38E0", Offset = "0x28B28E0", VA = "0x1828B38E0", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> SRVDFHVZAKJ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x28B36C0", Offset = "0x28B26C0", VA = "0x1828B36C0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<ZWCOPVGGMMD> IOCUVRXFQSC(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x28B35B0", Offset = "0x28B25B0", VA = "0x1828B35B0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<DLNBIGPDDFF> CIBEUZABCPN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x28B39F0", Offset = "0x28B29F0", VA = "0x1828B39F0", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<YDXEBHQLRCV.OAIZGCDVQOY.CircuitGraphToolMapping> UVHCKDTOPEI(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x28B37D0", Offset = "0x28B27D0", VA = "0x1828B37D0", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> LIMCKFWVZUT(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x28B3B00", Offset = "0x28B2B00", VA = "0x1828B3B00")]
		public TDGMEXCJRLT(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class CLGMAYMLHWR : CV2Request.OAIZGCDVQOY
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly CV2Request.OAIZGCDVQOY QSHZKWMVMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly GetCanSendRequestsDelegate LMFWAMHPZKJ;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public CLGMAYMLHWR(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x1059E90", Offset = "0x1058E90", VA = "0x181059E90", Slot = "4")]
		public bool ONMANRUSGSB()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class KNGINVHYWZM : QDTLTHTSXNH
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, IMZVXBWNFZH> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly TryReportErrToUserDelegate OTVEHJFVLPZ;

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x28AF030", Offset = "0x28AE030", VA = "0x1828AF030")]
		public bool LCWVCBXQFQD([In] Result<None, IMZVXBWNFZH> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x28AF060", Offset = "0x28AE060", VA = "0x1828AF060")]
		public KNGINVHYWZM([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x28AF030", Offset = "0x28AE030", VA = "0x1828AF030", Slot = "4")]
		private bool CIRIZJGICWE([In] Result<None, IMZVXBWNFZH> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class QRFDZYUVRAP : GHEKOECVSUE
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate TNNPXTPLORO CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly QRFDZYUVRAP QSHZKWMVMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CurrentExecParamsDelegate? XHNOJMAUAVT;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TNNPXTPLORO XMLXBJXETJB
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x1059E90", Offset = "0x1058E90", VA = "0x181059E90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public QRFDZYUVRAP([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class QETFUAOHPRZ : YHJIQBACQBQ
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly YHJIQBACQBQ QSHZKWMVMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly GetGameColorFromIdDelegate HIHUXLFYXHZ;

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x28AF030", Offset = "0x28AE030", VA = "0x1828AF030", Slot = "4")]
		public CircuitsColor EMGOVBGHJTJ(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x28B2E60", Offset = "0x28B1E60", VA = "0x1828B2E60")]
		public QETFUAOHPRZ([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class VCPSHTHRNGT : GQQCNTKRUZA
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
			public VCPSHTHRNGT <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x28B5390", Offset = "0x28B4390", VA = "0x1828B5390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x28B5580", Offset = "0x28B4580", VA = "0x1828B5580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly IsStringPureAsyncDelegate SKGQRHBXIJE;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x28B6F80", Offset = "0x28B5F80", VA = "0x1828B6F80", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> WBLDKQQFFJW(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x28B70C0", Offset = "0x28B60C0", VA = "0x1828B70C0")]
		public VCPSHTHRNGT([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class SWVWQGPQIJH : ZOCCJHRAKXK
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate VPBEDTVFQOY? GetNodeVisualizationConfigDelegate([In] Id128<XWYEQLTFQES> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly ZOCCJHRAKXK QSHZKWMVMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly GetNodeVisualizationConfigDelegate CKJDHWVAIZL;

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x28AF030", Offset = "0x28AE030", VA = "0x1828AF030")]
		public VPBEDTVFQOY? SKNPNFFFYUZ([In] Id128<XWYEQLTFQES> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x28B32F0", Offset = "0x28B22F0", VA = "0x1828B32F0")]
		public SWVWQGPQIJH([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x28AF030", Offset = "0x28AE030", VA = "0x1828AF030", Slot = "4")]
		private VPBEDTVFQOY JSORXWFBMST([In] Id128<XWYEQLTFQES> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class WNLQSZNMXNG : IBJTCLVNPXN
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x28B7270", Offset = "0x28B6270", VA = "0x1828B7270", Slot = "4")]
		public NKOEIJVVLUE ODAGFCGAWHC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public WNLQSZNMXNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class IQYZZEHETLO : ONVTNJKXENL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, bool> TMBNXKCDLNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, float> KFXSADIWAWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, double> THNKIUAIYSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, int> RSNUIFTXZZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, long> TFZSSGHZJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, string> ROAXWCKVBHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly Dictionary<string, uint> XDISODKPBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly Dictionary<string, ulong> EODDENCYNFM;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x28AEAF0", Offset = "0x28ADAF0", VA = "0x1828AEAF0", Slot = "4")]
		public bool? SMELJETFMJT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x28AEB90", Offset = "0x28ADB90", VA = "0x1828AEB90")]
		public IQYZZEHETLO()
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
