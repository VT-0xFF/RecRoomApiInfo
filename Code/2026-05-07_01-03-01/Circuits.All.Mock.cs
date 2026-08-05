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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AFE3A0", Offset = "0x2AFCDA0", VA = "0x182AFE3A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
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
		internal sealed class UTGNNOXFFXW : EKVEUNWMJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public UTGNNOXFFXW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0", Slot = "4")]
			public EKVEUNWMJGL CPBWJFUOQJF(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0", Slot = "5")]
			public EKVEUNWMJGL QOKRLBXDKSO(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0", Slot = "6")]
			public EKVEUNWMJGL RFXJBZRWCXM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
			public void QUSLSCNGWNP()
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
	public static class AINPXAZIOWR
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JOXUKJQLBDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public YWXACDIEBZA LPCVALREYBF;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD1E0", Offset = "0x2AFBBE0", VA = "0x182AFD1E0")]
			internal KHYMSWFULYQ MYJWQQLKLKG(GetNetworkObjectDelegate a)
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
			public KGAFOUMCVHY dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public ETNCQEUIWVP network;

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
			[Cpp2IlInjected.Address(RVA = "0x2B06460", Offset = "0x2B04E60", VA = "0x182B06460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B06B00", Offset = "0x2B05500", VA = "0x182B06B00", Slot = "5")]
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
			public ETNCQEUIWVP network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public KGAFOUMCVHY dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<SLTVKIGDHLN>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private BOPULBRGFUP <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B06B70", Offset = "0x2B05570", VA = "0x182B06B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B07100", Offset = "0x2B05B00", VA = "0x182B07100", Slot = "5")]
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
			public YWXACDIEBZA roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B07170", Offset = "0x2B05B70", VA = "0x182B07170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B07680", Offset = "0x2B06080", VA = "0x182B07680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF92C0", Offset = "0x2AF7CC0", VA = "0x182AF92C0")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? TKSFZMITMPK([Optional] YWXACDIEBZA? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8FB0", Offset = "0x2AF79B0", VA = "0x182AF8FB0")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> NMHCCNGQCMJ(ETNCQEUIWVP a, [Optional] KGAFOUMCVHY? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9130", Offset = "0x2AF7B30", VA = "0x182AF9130")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> NMHCCNGQCMJ(ETNCQEUIWVP a, KGAFOUMCVHY b, RegistryV2 c, Id32<SLTVKIGDHLN>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF93B0", Offset = "0x2AF7DB0", VA = "0x182AF93B0")]
		public static (RuntimeFnRegistry, RuntimeFns) TRJJGAZEYZT()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8EB0", Offset = "0x2AF78B0", VA = "0x182AF8EB0")]
		public static (ExternalFnRegistry, ExternalFns) LXXFBCNPBVM()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8E30", Offset = "0x2AF7830", VA = "0x182AF8E30")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static ETNCQEUIWVP GDQWYPHUWYH(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class RAPGRDZWQRX
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate KHYMSWFULYQ CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public RAPGRDZWQRX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B06070", Offset = "0x2B04A70", VA = "0x182B06070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B063F0", Offset = "0x2B04DF0", VA = "0x182B063F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ETNCQEUIWVP UWLLAYIRKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? GIIUSTZRYFR;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		private RAPGRDZWQRX(ETNCQEUIWVP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B058E0", Offset = "0x2B042E0", VA = "0x182B058E0")]
		public static RAPGRDZWQRX ONZPJVMVHLX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B058C0", Offset = "0x2B042C0", VA = "0x182B058C0")]
		public RAPGRDZWQRX KYVZFQFWAEM(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B05990", Offset = "0x2B04390", VA = "0x182B05990")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> QUSLSCNGWNP()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class NNEETPDKOGX : BOPULBRGFUP.VQSBDUUAFGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate RFQSRXWWNBT NewCircuitsLifecycleDelegate(XXIODFUTTPG.VQSBDUUAFGN deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(BOPULBRGFUP circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(BOPULBRGFUP circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate FLPWFYJURBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate OEOJQLIGPZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate BULODAFHLTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate VBBYWPLMBOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate JUBYJSFWNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate NLWZYONTKUC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int VCUQGYZYELU
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x129FCC0", Offset = "0x129E6C0", VA = "0x18129FCC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDA60", Offset = "0x2AFC460", VA = "0x182AFDA60", Slot = "6")]
		public void GLPWSVXHFXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDAC0", Offset = "0x2AFC4C0", VA = "0x182AFDAC0", Slot = "7")]
		public void YXDOJFNEXIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDA90", Offset = "0x2AFC490", VA = "0x182AFDA90", Slot = "5")]
		public RFQSRXWWNBT VGIQBYUJRRI(XXIODFUTTPG.VQSBDUUAFGN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xEF9FF0", Offset = "0xEF89F0", VA = "0x180EF9FF0", Slot = "8")]
		public void PQGCRULWQGD(BOPULBRGFUP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xEF9F90", Offset = "0xEF8990", VA = "0x180EF9F90", Slot = "9")]
		public void RXCLBFFZBQI(BOPULBRGFUP a, SYXPYTMUMKS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDAF0", Offset = "0x2AFC4F0", VA = "0x182AFDAF0")]
		public NNEETPDKOGX([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly FZBXDZLWBIS<ETNCQEUIWVP, ETNCQEUIWVP.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly ZGUBSLDPVXI<ETNCQEUIWVP, ETNCQEUIWVP.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly BOPULBRGFUP CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<QEBRWUBFUFW> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly ETNCQEUIWVP Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA2E0", Offset = "0x2AF8CE0", VA = "0x182AFA2E0")]
		public EVCreationResult(FZBXDZLWBIS<ETNCQEUIWVP, ETNCQEUIWVP.MockStaticNetSysDeps> staticNetSys, ZGUBSLDPVXI<ETNCQEUIWVP, ETNCQEUIWVP.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, BOPULBRGFUP circuitsManager, Id32<QEBRWUBFUFW> clientId, ETNCQEUIWVP network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly BOPULBRGFUP _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 QKVSNOGYDST
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD630", Offset = "0x2AFC030", VA = "0x182AFD630")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request OREKOGOPGLP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD660", Offset = "0x2AFC060", VA = "0x182AFD660")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public VLIGRPBVLTA? BFIYFRVCQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD540", Offset = "0x2AFBF40", VA = "0x182AFD540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public UESRNTRQLCK? SIZCWBKKBIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD4E0", Offset = "0x2AFBEE0", VA = "0x182AFD4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEBA9B0", Offset = "0xEB93B0", VA = "0x180EBA9B0")]
		internal LimitedCircuits(BOPULBRGFUP circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class UGNLOHOCVZB : KGAFOUMCVHY
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class QFCXJTSNKSN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public KHYMSWFULYQ BMBJVZVBWWQ;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public QFCXJTSNKSN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			internal KHYMSWFULYQ VOZXTQRFDDY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public XXIODFUTTPG.VQSBDUUAFGN SELYMIVZQLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public BOPULBRGFUP.VQSBDUUAFGN WASLEOWZSGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PROZKNCVPRU.VQSBDUUAFGN GOWLOTDDBFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ZZQZJVDKZSI.ZFCLKDKZCRS<ActionKind, SYXPYTMUMKS, BOPULBRGFUP> TZPIAMMGSNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.VQSBDUUAFGN TSVUUXPOJNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AMOMUAWSSEI XKFPXLTRPDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public QVZSNJGYCUV KLFIWBSRRBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public AASPWJWOJHD FLIVOLTWNKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RPWMSZPCVKF OYUNAENCPTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public SVFGTXNXCXN AWBCUFIYQRU
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B09000", Offset = "0x2B07A00", VA = "0x182B09000")]
		private UGNLOHOCVZB(XXIODFUTTPG.VQSBDUUAFGN a, BOPULBRGFUP.VQSBDUUAFGN b, PROZKNCVPRU.VQSBDUUAFGN c, ZZQZJVDKZSI.ZFCLKDKZCRS<ActionKind, SYXPYTMUMKS, BOPULBRGFUP> d, CV2Request.VQSBDUUAFGN e, AMOMUAWSSEI f, QVZSNJGYCUV g, AASPWJWOJHD h, RPWMSZPCVKF i, SVFGTXNXCXN j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B087D0", Offset = "0x2B071D0", VA = "0x182B087D0")]
		public static UGNLOHOCVZB? ARQFWMJPBOU(PROZKNCVPRU.VQSBDUUAFGN cv2RootSysDeps, [Optional] XXIODFUTTPG.VQSBDUUAFGN? a, [Optional] BOPULBRGFUP.VQSBDUUAFGN? b, [Optional] ZZQZJVDKZSI.ZFCLKDKZCRS<ActionKind, SYXPYTMUMKS, BOPULBRGFUP>? reducerDeps, [Optional] CV2Request.VQSBDUUAFGN? c, [Optional] AMOMUAWSSEI? d, [Optional] QVZSNJGYCUV? e, [Optional] AASPWJWOJHD? f, [Optional] RPWMSZPCVKF? g, [Optional] SVFGTXNXCXN? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B08EB0", Offset = "0x2B078B0", VA = "0x182B08EB0")]
		public static UGNLOHOCVZB JFKIQOCGVYQ(KHYMSWFULYQ a, [Optional] XXIODFUTTPG.VQSBDUUAFGN? circuitsLifecycleDeps, [Optional] BOPULBRGFUP.VQSBDUUAFGN? circuitsManagerDeps, [Optional] ZZQZJVDKZSI.ZFCLKDKZCRS<ActionKind, SYXPYTMUMKS, BOPULBRGFUP>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B08B30", Offset = "0x2B07530", VA = "0x182B08B30")]
		public static UGNLOHOCVZB EBRZLJMDNYW(GetNetworkObjectDelegate a, [Optional] XXIODFUTTPG.VQSBDUUAFGN? circuitsLifecycleDeps, [Optional] BOPULBRGFUP.VQSBDUUAFGN? circuitsManagerDeps, [Optional] ZZQZJVDKZSI.ZFCLKDKZCRS<ActionKind, SYXPYTMUMKS, BOPULBRGFUP>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class QNDJFIHAKCW
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class EYKCAZOIXTX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public GetNetworkObjectDelegate RKBULJEVRBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int GAGNOVYPSJO;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public EYKCAZOIXTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA400", Offset = "0x2AF8E00", VA = "0x182AFA400")]
			internal RJSMIWZGCTN JTEHBTHVTQV(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA470", Offset = "0x2AF8E70", VA = "0x182AFA470")]
			internal RJSMIWZGCTN[] JUZRDCEYAOY(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0")]
			internal int VYDCXKKMUTW()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EYEVDSULOIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public DynamicEnvironmentNetworkId JMYBWNPGBPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public EYKCAZOIXTX YQELRQOBVLD;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public EYEVDSULOIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA350", Offset = "0x2AF8D50", VA = "0x182AFA350")]
			internal RJSMIWZGCTN OWGIPDNAALL(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly MNPVGDUGIJR LVRCHONLYGY;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B01250", Offset = "0x2AFFC50", VA = "0x182B01250")]
		public static RJSMIWZGCTN? DDVNLMCTQGI(Id32<SLTVKIGDHLN>? networkObject, [Optional] PVIVIPLNHXQ.SerializesIntoSavesDelegate? a, [Optional] PVIVIPLNHXQ.SerializesIntoInventionsDelegate? b, [Optional] PVIVIPLNHXQ.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B01270", Offset = "0x2AFFC70", VA = "0x182B01270")]
		public static KHYMSWFULYQ? KDCAMCDDWSV(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] MDLFRJOYVEP? b, [Optional] HYUDKEUUZXJ? c, [Optional] MGAYZVKUJDJ? d, [Optional] YWXACDIEBZA? e, int f = 300000, bool g = false, bool h = false, [Optional] XGQYWFNBRKT? i, [Optional] UGSTGSNEDCH? j, [Optional] SBBVIVDVOCM? k, [Optional] GNUHQACMLVZ? l, [Optional] MNHQMCOHKJS? m, [Optional] SZYUUPLSJBZ? n, [Optional] BZVXRTNDJQB.VQSBDUUAFGN? o, [Optional] EqualsNodeV2.VQSBDUUAFGN? p, [Optional] PDFENVGSLXV? q, [Optional] KHYMSWFULYQ.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] KHYMSWFULYQ.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] KHYMSWFULYQ.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] KHYMSWFULYQ.GetLocalRoomIdDelegate? u, [Optional] KHYMSWFULYQ.GetLocalSubroomIdDelegate? v, [Optional] KHYMSWFULYQ.GetSubroomIdsForLocalRoomDelegate? w, [Optional] KHYMSWFULYQ.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] KHYMSWFULYQ.SaveRoomOnPlayerBehalfDelegate? z, [Optional] KHYMSWFULYQ.ReportCloudDataLedgerChangedDelegate? ba, [Optional] KHYMSWFULYQ.GetColorNameByIdDelegate? bb, [Optional] KHYMSWFULYQ.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] KHYMSWFULYQ.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] KHYMSWFULYQ.GetTaggableNameFromSignalDelegate? be, [Optional] KHYMSWFULYQ.GetAudioNameFromSignalDelegate? bf, [Optional] KHYMSWFULYQ.GetDestinationNameFromSignalDelegate? bg, [Optional] KHYMSWFULYQ.GetPlayerEventNameFromSignalDelegate? bh, [Optional] KHYMSWFULYQ.GetRoomKeyNameFromSignalDelegate? bi, [Optional] KHYMSWFULYQ.GetRewardNameFromSignalDelegate? bj, [Optional] KHYMSWFULYQ.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] KHYMSWFULYQ.ReportPreloadedAudioChangedDelegate? bl, [Optional] KHYMSWFULYQ.ReportRewardDataChangedDelegate? bm, [Optional] KHYMSWFULYQ.GetConsumableNameFromSignalDelegate? bn, [Optional] KHYMSWFULYQ.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] KHYMSWFULYQ.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] KHYMSWFULYQ.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] KHYMSWFULYQ.GetInventoryItemNameFromSignalDelegate? br, [Optional] KHYMSWFULYQ.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] KHYMSWFULYQ.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] KHYMSWFULYQ.GetRoomOfferNameFromSignalDelegate? bu, [Optional] KHYMSWFULYQ.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] KHYMSWFULYQ.GetObjectIdFromCreationObjectDelegate? bw, [Optional] KHYMSWFULYQ.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] KHYMSWFULYQ.GetCostInBytesDelegate? by, [Optional] KHYMSWFULYQ.GetAvatarItemNameFromSignalDelegate? bz, [Optional] KHYMSWFULYQ.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] KHYMSWFULYQ.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] KHYMSWFULYQ.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] KHYMSWFULYQ.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] KHYMSWFULYQ.GetStoreItemNameFromSignalDelegate? ce, [Optional] KHYMSWFULYQ.GetBodyPartNameFromSignalDelegate? cf, [Optional] KHYMSWFULYQ.GetDependenciesForGraphInstanceDelegate? cg, [Optional] KHYMSWFULYQ.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] KHYMSWFULYQ.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] KHYMSWFULYQ.GetRecNetImageNameFromSignalDelegate? cj, [Optional] KHYMSWFULYQ.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] KHYMSWFULYQ.IsFunctionValidForAIDelegate? cm, [Optional] KHYMSWFULYQ.GetAIFunctionNameFromSignalDelegate? cn, [Optional] KHYMSWFULYQ.FromSerializableObjectDelegate? co, [Optional] KHYMSWFULYQ.ToSerializableObjectDelegate? cp)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<SLTVKIGDHLN>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class IZLEKPOIVYF : SBBVIVDVOCM
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly IZLEKPOIVYF IWMDTGRRYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly GetLocalPlayerDelegate? QARDDLZYOHO;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCED0", Offset = "0x2AFB8D0", VA = "0x182AFCED0", Slot = "4")]
		public (VZOBZAPZKAN, VZOBZAPZKAN, VZOBZAPZKAN, VZOBZAPZKAN, VZOBZAPZKAN) LDXQXNDDHUH(object a)
		{
			return default((VZOBZAPZKAN, VZOBZAPZKAN, VZOBZAPZKAN, VZOBZAPZKAN, VZOBZAPZKAN));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCEA0", Offset = "0x2AFB8A0", VA = "0x182AFCEA0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "6")]
		public bool SFWGMFEBQCS(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD368A0", Offset = "0xD352A0", VA = "0x180D368A0", Slot = "7")]
		public string ORYCYTPKZGA(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public IZLEKPOIVYF([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class PVIVIPLNHXQ : RJSMIWZGCTN
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(PVIVIPLNHXQ self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(PVIVIPLNHXQ self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(PVIVIPLNHXQ self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly SerializesIntoSavesDelegate YAELYIPMOYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly SerializesIntoInventionsDelegate NLYTRTPLMUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly CanPublishInInventionsDelegate QZUUFGBWMJF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private YGMHDOTMPHP? ECEADQOMAJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId HTHJEXPZOBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xFA4B20", Offset = "0xFA3520", VA = "0x180FA4B20", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MVIANHUTISZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B01170", Offset = "0x2AFFB70", VA = "0x182B01170", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool VWKBMZUIVBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B01140", Offset = "0x2AFFB40", VA = "0x182B01140", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool IECXZZJISAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B01110", Offset = "0x2AFFB10", VA = "0x182B01110", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IKXETXVCHAQ? AFSVBXMBGXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<SLTVKIGDHLN>? FNRWKEEDRQV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B00FC0", Offset = "0x2AFF9C0", VA = "0x182B00FC0", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B00A50", Offset = "0x2AFF450", VA = "0x182B00A50", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(MNPVGDUGIJR e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10", Slot = "13")]
		public void Bind(YGMHDOTMPHP controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B01060", Offset = "0x2AFFA60", VA = "0x182B01060")]
		private PVIVIPLNHXQ(Id32<SLTVKIGDHLN>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B00AF0", Offset = "0x2AFF4F0", VA = "0x182B00AF0")]
		public static PVIVIPLNHXQ? New(Id32<SLTVKIGDHLN>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class OSZMELJTDES : XGQYWFNBRKT
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
		public static readonly OSZMELJTDES IWMDTGRRYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly RoundToDecimalPlaceDelegate? TGHBERBNIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly TruncateToDecimalPlaceDelegate? DGQLMMBOHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsColorLerpDelegate? KOQVRGPATDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsColorInverseLerpDelegate? SYIWHKYPGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4GetPositionDelegate? OGXFMYSQISU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4GetRotationDelegate? BBFISXFCTAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsMtx4x4InverseDelegate? JMGQVLDVEJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsMtx4x4MultiplyDelegate? DMPBOTCRZCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? GPONGLQXWTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatDotDelegate? LRFWDAWXTPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromAngleAxisDelegate? BFGNNDDLEXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? PZIANHXVFET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatFromFromToRotationDelegate? ECURZXOHOBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatFromLookRotationDelegate? RAWDKNMNHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? CDMNVETKGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseDelegate? PNBSXRCJZIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatLerpDelegate? ORTCUHQASAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatLerpUnclampedDelegate? BLWFLKAPTSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatInverseLerpDelegate? OAHOPKEXHYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatMultiplyDelegate? SWXBGCLCQES;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatNormalizeDelegate? LICSRAMBJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatRotateTowardsDelegate? FBKVEZFMYHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatRotateVectorDelegate? HIIKCXVANYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatSlerpDelegate? UMUBGLLULVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsQuatToAngleAxisDelegate? HMUFLWCPWOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsQuatToEulerAnglesDelegate? BUKIVLRLXHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3AddDelegate? ISHEVZDPUOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? CZBRCUKQJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? PUQBDQLCUEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3CrossDelegate? ERLHVSMUZFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3DotDelegate? SUAMRJVJKYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3AngleDelegate? PLWIAFHRLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3GetMagnitudeDelegate? FBAIFRWHTUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3LerpDelegate? JQUNVMVDRAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3LerpUnclampedDelegate? XVOJXYUSRMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3InverseLerpDelegate? IKIXVIRJVLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3MoveTowardsDelegate? WKQSDUDGNBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3NegateDelegate? GZJLIQSCAKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3NormalizeDelegate? SOJFHTFDNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ProjectDelegate? PQOGNMKRGPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? DNSWAAIBBJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3ScaleDelegate? WFGKSZAAZMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SmoothDampDelegate? SDATTXGBRTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3SubtractDelegate? CAYYOHHBLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3SlerpDelegate? BGNMFLDHYMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly CircuitsVec3TransformDelegate? JOHJOTKZQTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CircuitsVec3InverseTransformDelegate? GCVPCKMFLLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly RealtimeSinceStartupDelegate? VNKIQULSNCH;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B00570", Offset = "0x2AFEF70", VA = "0x182B00570")]
		public OSZMELJTDES([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF610", Offset = "0x2AFE010", VA = "0x182AFF610")]
		public float WUUTMQVKVQL([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE530", Offset = "0x2AFCF30", VA = "0x182AFE530")]
		public float AKBAAMSTYIV([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE860", Offset = "0x2AFD260", VA = "0x182AFE860")]
		public CircuitsColor BOZBHLKOEQC([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEFA0", Offset = "0x2AFD9A0", VA = "0x182AFEFA0")]
		public float FNNLRETBNIE([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B00030", Offset = "0x2AFEA30", VA = "0x182B00030")]
		public CircuitsVec3 URLEJQBNFJW([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFED70", Offset = "0x2AFD770", VA = "0x182AFED70")]
		public CircuitsQuat DIVKAQJMYXL([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF090", Offset = "0x2AFDA90", VA = "0x182AFF090")]
		public CircuitsMtx4x4 GEIGKAYQESX([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE620", Offset = "0x2AFD020", VA = "0x182AFE620")]
		public CircuitsMtx4x4 AVCTZCWTEPP([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFC80", Offset = "0x2AFE680", VA = "0x182AFFC80")]
		public CircuitsMtx4x4 SFOOKOTDOJP([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF180", Offset = "0x2AFDB80", VA = "0x182AFF180")]
		public float IKSGOIOHVRQ([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEB00", Offset = "0x2AFD500", VA = "0x182AFEB00")]
		public CircuitsQuat CAWSFPWYDVF(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE700", Offset = "0x2AFD100", VA = "0x182AFE700")]
		public CircuitsQuat BLZXKXKYREY([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEA50", Offset = "0x2AFD450", VA = "0x182AFEA50")]
		public CircuitsQuat ZAFTQYPVQLW([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF7C0", Offset = "0x2AFE1C0", VA = "0x182AFF7C0")]
		public CircuitsQuat RPCHNWJEMYK([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF3F0", Offset = "0x2AFDDF0", VA = "0x182AFF3F0")]
		public CircuitsQuat VEXXFJGKOMN([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE7A0", Offset = "0x2AFD1A0", VA = "0x182AFE7A0")]
		public CircuitsQuat NZUMPZFZMDM([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFDA0", Offset = "0x2AFE7A0", VA = "0x182AFFDA0")]
		public CircuitsQuat SLNCWQFTFDH([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFED0", Offset = "0x2AFE8D0", VA = "0x182AFFED0")]
		public float TZGIRSVREHC([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFCF0", Offset = "0x2AFE6F0", VA = "0x182AFFCF0")]
		public CircuitsQuat SIAFSUTJIPV([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE8C0", Offset = "0x2AFD2C0", VA = "0x182AFE8C0")]
		public CircuitsQuat WHDZPHIUXNI([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE470", Offset = "0x2AFCE70", VA = "0x182AFE470")]
		public CircuitsQuat LPWGGDSIRRG([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEBB0", Offset = "0x2AFD5B0", VA = "0x182AFEBB0")]
		public CircuitsVec3 CKJQHMLAJHN([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFF00", Offset = "0x2AFE900", VA = "0x182AFFF00")]
		public CircuitsQuat UGBGPKHAWQZ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF5D0", Offset = "0x2AFDFD0", VA = "0x182AFF5D0")]
		public void OJDKCCSVCXW([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF030", Offset = "0x2AFDA30", VA = "0x182AFF030")]
		public CircuitsVec3 FYNLTFEWTOX([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFA10", Offset = "0x2AFE410", VA = "0x182AFFA10")]
		public CircuitsVec3 QIWACBMURVM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B001E0", Offset = "0x2AFEBE0", VA = "0x182B001E0")]
		public CircuitsVec3 YPKJWHHLERG([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFC10", Offset = "0x2AFE610", VA = "0x182AFFC10")]
		public CircuitsVec3 RRRODSWGCGR([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B00250", Offset = "0x2AFEC50", VA = "0x182B00250")]
		public CircuitsVec3 YUZWCJANABD([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF2D0", Offset = "0x2AFDCD0", VA = "0x182AFF2D0")]
		public float IVDYHKIGAQS([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF100", Offset = "0x2AFDB00", VA = "0x182AFF100")]
		public float HVZWKLRVCKK([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE450", Offset = "0x2AFCE50", VA = "0x182AFE450")]
		public float QSYUAIBBGOV([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF500", Offset = "0x2AFDF00", VA = "0x182AFF500")]
		public CircuitsVec3 JVSZVIFAYJU([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFED00", Offset = "0x2AFD700", VA = "0x182AFED00")]
		public CircuitsVec3 CYYHBGSPLWV([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF2F0", Offset = "0x2AFDCF0", VA = "0x182AFF2F0")]
		public float IYQAVNYDQEU([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF380", Offset = "0x2AFDD80", VA = "0x182AFF380")]
		public CircuitsVec3 JBQSJAZEPMC([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF120", Offset = "0x2AFDB20", VA = "0x182AFF120")]
		public CircuitsVec3 HZGLSDJVVHD([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF9B0", Offset = "0x2AFE3B0", VA = "0x182AFF9B0")]
		public CircuitsVec3 QGUBFUPJFAW([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B00330", Offset = "0x2AFED30", VA = "0x182B00330")]
		public CircuitsVec3 ZMWOJUQJVPS([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B00090", Offset = "0x2AFEA90", VA = "0x182B00090")]
		public CircuitsVec3 VOIWOJVLPPT([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE690", Offset = "0x2AFD090", VA = "0x182AFE690")]
		public CircuitsVec3 BKZGELQWVJZ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF710", Offset = "0x2AFE110", VA = "0x182AFF710")]
		public CircuitsVec3 MWCVCCNLFXB([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFE60", Offset = "0x2AFE860", VA = "0x182AFFE60")]
		public CircuitsVec3 SOKFLBLLCLV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFFC0", Offset = "0x2AFE9C0", VA = "0x182AFFFC0")]
		public CircuitsVec3 UIXSMEVEZZX([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEC20", Offset = "0x2AFD620", VA = "0x182AFEC20")]
		public CircuitsVec3 CQSJBXTSZBL([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEF30", Offset = "0x2AFD930", VA = "0x182AFEF30")]
		public CircuitsVec3 EFLBUVYIPUD([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE420", Offset = "0x2AFCE20", VA = "0x182AFE420", Slot = "50")]
		public Task ABPVVWELKUF(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "51")]
		public void OGFYWDUWVIF([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEEE0", Offset = "0x2AFD8E0", VA = "0x182AFEEE0", Slot = "52")]
		public JEMWUSSDJUE<SHCDMTYIUNK> DWJNKYTJJLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1A0", Offset = "0x2AFDBA0", VA = "0x182AFF1A0", Slot = "53")]
		public JEMWUSSDJUE<SHCDMTYIUNK> ILBBGAGMKGQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE9C0", Offset = "0x2AFD3C0", VA = "0x182AFE9C0", Slot = "54")]
		public float BXWPAEHGKLI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF610", Offset = "0x2AFE010", VA = "0x182AFF610", Slot = "4")]
		private float LWJTGUDOHOV([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE530", Offset = "0x2AFCF30", VA = "0x182AFE530", Slot = "5")]
		private float FBPPCGNUYBF([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFA80", Offset = "0x2AFE480", VA = "0x182AFFA80", Slot = "6")]
		private CircuitsColor QUCXHBKPGJS([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEFA0", Offset = "0x2AFD9A0", VA = "0x182AFEFA0", Slot = "7")]
		private float ORANYVIODSW([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEFD0", Offset = "0x2AFD9D0", VA = "0x182AFEFD0", Slot = "8")]
		private CircuitsVec3 FQMUWEAERNI([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEDC0", Offset = "0x2AFD7C0", VA = "0x182AFEDC0", Slot = "9")]
		private CircuitsQuat DKFWHTUKAIL([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE550", Offset = "0x2AFCF50", VA = "0x182AFE550", Slot = "10")]
		private CircuitsMtx4x4 AKDRKMQIGEZ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEE80", Offset = "0x2AFD880", VA = "0x182AFEE80", Slot = "11")]
		private CircuitsMtx4x4 DVAQBUMPXBB([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF320", Offset = "0x2AFDD20", VA = "0x182AFF320", Slot = "12")]
		private CircuitsMtx4x4 JAUSBVYLAOD([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF180", Offset = "0x2AFDB80", VA = "0x182AFF180", Slot = "13")]
		private float LPMCMYJSBZS([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEB00", Offset = "0x2AFD500", VA = "0x182AFEB00", Slot = "14")]
		private CircuitsQuat DSELTJBYRIF(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE700", Offset = "0x2AFD100", VA = "0x182AFE700", Slot = "15")]
		private CircuitsQuat CBYPNARNNMC([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEA50", Offset = "0x2AFD450", VA = "0x182AFEA50", Slot = "16")]
		private CircuitsQuat CAUXJNKLCYS([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF7C0", Offset = "0x2AFE1C0", VA = "0x182AFF7C0", Slot = "17")]
		private CircuitsQuat NCWQNPYLISA([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF3F0", Offset = "0x2AFDDF0", VA = "0x182AFF3F0", Slot = "18")]
		private CircuitsQuat JEWOGJOMKCH([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE7A0", Offset = "0x2AFD1A0", VA = "0x182AFE7A0", Slot = "19")]
		private CircuitsQuat BMZFNLNKTTO([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFDA0", Offset = "0x2AFE7A0", VA = "0x182AFFDA0", Slot = "20")]
		private CircuitsQuat ZUNWRCXKWGH([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFED0", Offset = "0x2AFE8D0", VA = "0x182AFFED0", Slot = "21")]
		private float YWCYQUYNMVA([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFCF0", Offset = "0x2AFE6F0", VA = "0x182AFFCF0", Slot = "22")]
		private CircuitsQuat WAPGXBWWRRX([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE8C0", Offset = "0x2AFD2C0", VA = "0x182AFE8C0", Slot = "23")]
		private CircuitsQuat BTYZLDJRUBK([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE470", Offset = "0x2AFCE70", VA = "0x182AFE470", Slot = "24")]
		private CircuitsQuat AEOZMSNLXYG([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B00170", Offset = "0x2AFEB70", VA = "0x182B00170", Slot = "25")]
		private CircuitsVec3 XYLSOJIQPYV([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFF00", Offset = "0x2AFE900", VA = "0x182AFFF00", Slot = "26")]
		private CircuitsQuat UOXNAITYUOL([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF5D0", Offset = "0x2AFDFD0", VA = "0x182AFF5D0", Slot = "27")]
		private void LUBRMPDSCIS([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF570", Offset = "0x2AFDF70", VA = "0x182AFF570", Slot = "28")]
		private CircuitsVec3 KIKODBKZMQB([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFAE0", Offset = "0x2AFE4E0", VA = "0x182AFFAE0", Slot = "29")]
		private CircuitsVec3 RCMPAKMKBEI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B00100", Offset = "0x2AFEB00", VA = "0x182B00100", Slot = "30")]
		private CircuitsVec3 XJSZAZSBHHQ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1F0", Offset = "0x2AFDBF0", VA = "0x182AFF1F0", Slot = "31")]
		private CircuitsVec3 INFDLSQDHEX([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF630", Offset = "0x2AFE030", VA = "0x182AFF630", Slot = "32")]
		private CircuitsVec3 MBBODJLMDMX([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF870", Offset = "0x2AFE270", VA = "0x182AFF870", Slot = "33")]
		private CircuitsVec3 NSVQETKFQGH([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEC90", Offset = "0x2AFD690", VA = "0x182AFEC90", Slot = "34")]
		private CircuitsVec3 CVSKRIEBEGR([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF2D0", Offset = "0x2AFDCD0", VA = "0x182AFF2D0", Slot = "35")]
		private float WJHLJTCKMAQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF100", Offset = "0x2AFDB00", VA = "0x182AFF100", Slot = "36")]
		private float LNNRZCYBHVC([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE450", Offset = "0x2AFCE50", VA = "0x182AFE450", Slot = "37")]
		private float ACALAOJIIFR([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B002C0", Offset = "0x2AFECC0", VA = "0x182B002C0", Slot = "38")]
		private CircuitsVec3 ZMDAKJABRJC([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF490", Offset = "0x2AFDE90", VA = "0x182AFF490", Slot = "39")]
		private CircuitsVec3 JFRHCLTWVZN([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF2F0", Offset = "0x2AFDCF0", VA = "0x182AFF2F0", Slot = "40")]
		private float XSVCDHGXBWS([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF8E0", Offset = "0x2AFE2E0", VA = "0x182AFF8E0", Slot = "41")]
		private CircuitsVec3 OBISIICMOUY([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF950", Offset = "0x2AFE350", VA = "0x182AFF950", Slot = "42")]
		private CircuitsVec3 PASRVRNHYHN([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE960", Offset = "0x2AFD360", VA = "0x182AFE960", Slot = "43")]
		private CircuitsVec3 BVBWSOOVEGI([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF260", Offset = "0x2AFDC60", VA = "0x182AFF260", Slot = "44")]
		private CircuitsVec3 IOQAMCFFEAG([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE9E0", Offset = "0x2AFD3E0", VA = "0x182AFE9E0", Slot = "45")]
		private CircuitsVec3 BYCQEGZLKOD([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF6A0", Offset = "0x2AFE0A0", VA = "0x182AFF6A0", Slot = "46")]
		private CircuitsVec3 MDJBSNGOCAJ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFB50", Offset = "0x2AFE550", VA = "0x182AFFB50", Slot = "47")]
		private CircuitsVec3 RNQXQMOTTYR([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEE10", Offset = "0x2AFD810", VA = "0x182AFEE10", Slot = "48")]
		private CircuitsVec3 DMWPYVXZYER([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE5B0", Offset = "0x2AFCFB0", VA = "0x182AFE5B0", Slot = "49")]
		private CircuitsVec3 APVYUTTTKOL([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class FQICAOEVOTQ : GMQNCOZGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x13442D0", Offset = "0x1342CD0", VA = "0x1813442D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x11007D0", Offset = "0x10FF1D0", VA = "0x1811007D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA6E0", Offset = "0x2AF90E0", VA = "0x182AFA6E0")]
		public FQICAOEVOTQ(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class FAEYISIYYSS : UGSTGSNEDCH
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(AQJBJOMITDO e, VKWYZFFQXXB invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly FAEYISIYYSS IWMDTGRRYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly GetCircuitsColorFromColorIndexDelegate? UOAFHOJLUOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? UNVYMXWPRYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly InvisibleCollisionSetEnabledDelegate? QNMUNYIYPSK;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xDB6790", Offset = "0xDB5190", VA = "0x180DB6790")]
		public FAEYISIYYSS([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA5F0", Offset = "0x2AF8FF0", VA = "0x182AFA5F0", Slot = "4")]
		public CircuitsColor XWWUZZINTQK(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA5D0", Offset = "0x2AF8FD0", VA = "0x182AFA5D0")]
		public int QISYABKRPLM([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA5D0", Offset = "0x2AF8FD0", VA = "0x182AFA5D0", Slot = "5")]
		private int DXLODMZZXUX([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class HRUCITWFMXL : ERYJZAAZIHE
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class NLRWWCPPFEO
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid FCPGNLZYEOG
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xEF88F0", Offset = "0xEF72F0", VA = "0x180EF88F0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long VCXIFGXZPHF
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int KQFKUAHSEFX
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool YHQJUVECYZG
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x1B05E00", Offset = "0x1B04800", VA = "0x181B05E00")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool KEJWWCMGZYI
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x1B06270", Offset = "0x1B04C70", VA = "0x181B06270")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool HDNMFBGNEZD
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x2AFD9E0", Offset = "0x2AFC3E0", VA = "0x182AFD9E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2AFDA00", Offset = "0x2AFC400", VA = "0x182AFDA00")]
			public NLRWWCPPFEO(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<Id128<TOXCFTIABCD>, NLRWWCPPFEO> SQVVRXRGLFB;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCAB0", Offset = "0x2AFB4B0", VA = "0x182AFCAB0")]
		public bool OEJWALHUISC([In] Id128<TOXCFTIABCD> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC9E0", Offset = "0x2AFB3E0", VA = "0x182AFC9E0")]
		public void PFECLQXWPFU([In] Id128<TOXCFTIABCD> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCD40", Offset = "0x2AFB740", VA = "0x182AFCD40")]
		public void PFECLQXWPFU([In] Id128<TOXCFTIABCD> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC20", Offset = "0x2AFB620", VA = "0x182AFCC20")]
		public void TYJOPFAKNAH([In] Id128<TOXCFTIABCD> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCBC0", Offset = "0x2AFB5C0", VA = "0x182AFCBC0")]
		public void OLJIMABVAJS([In] Id128<TOXCFTIABCD> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC950", Offset = "0x2AFB350", VA = "0x182AFC950")]
		public bool YHQJUVECYZG([In] Id128<TOXCFTIABCD> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCE20", Offset = "0x2AFB820", VA = "0x182AFCE20")]
		public HRUCITWFMXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCAB0", Offset = "0x2AFB4B0", VA = "0x182AFCAB0", Slot = "4")]
		private bool XQOGNHICUFF([In] Id128<TOXCFTIABCD> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC9E0", Offset = "0x2AFB3E0", VA = "0x182AFC9E0", Slot = "5")]
		private void KEEBEAMBQHV([In] Id128<TOXCFTIABCD> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC20", Offset = "0x2AFB620", VA = "0x182AFCC20", Slot = "6")]
		private void ONXXWOLTWRQ([In] Id128<TOXCFTIABCD> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCBC0", Offset = "0x2AFB5C0", VA = "0x182AFCBC0", Slot = "7")]
		private void ZVXEVBBLFJL([In] Id128<TOXCFTIABCD> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC950", Offset = "0x2AFB350", VA = "0x182AFC950", Slot = "8")]
		private bool BTQTALLDDDJ([In] Id128<TOXCFTIABCD> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class RKMKXJBQNSG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B05A80", Offset = "0x2B04480", VA = "0x182B05A80")]
		public static LogDeps GBBENONEXQR()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class DKPHEGIOOZJ : MeshLibrary.VQSBDUUAFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "4")]
		public byte[]? OWOSPCIYORC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
		public void EGNAMKBUMCP(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public DKPHEGIOOZJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class FXGUTMNCHHG : MDLFRJOYVEP
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
		public delegate void ConfigureAttachedObjectDelegate(XVECRNMXAXL controlPanel, IWROMQEIXSV staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<WOTREZTVRTI> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, RYUTMMKYXMA>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, RYUTMMKYXMA>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, RYUTMMKYXMA>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, RYUTMMKYXMA>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<CVONZJXKLFZ>, RYUTMMKYXMA>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<CVONZJXKLFZ>, RYUTMMKYXMA>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, RYUTMMKYXMA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public Task<Result<MultiResult, RYUTMMKYXMA>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private TaskAwaiter<Result<MultiResult, RYUTMMKYXMA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2B076F0", Offset = "0x2B060F0", VA = "0x182B076F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2B079B0", Offset = "0x2B063B0", VA = "0x182B079B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<CVONZJXKLFZ>, RYUTMMKYXMA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Task<Result<Id32<CVONZJXKLFZ>, RYUTMMKYXMA>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<Result<Id32<CVONZJXKLFZ>, RYUTMMKYXMA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2B07A20", Offset = "0x2B06420", VA = "0x182B07A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2B07CE0", Offset = "0x2B066E0", VA = "0x182B07CE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RYUTMMKYXMA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Task<Result<None, RYUTMMKYXMA>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private TaskAwaiter<Result<None, RYUTMMKYXMA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2B07D50", Offset = "0x2B06750", VA = "0x182B07D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2B08010", Offset = "0x2B06A10", VA = "0x182B08010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Dictionary<string, EnumChoiceData> AIMNZTANXUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Dictionary<int, string> QKEQILXPBHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly List<object> DDYCCEHWDZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly List<Guid> HFFUVAKNEPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly CanLocalPlayerCreateCurrencyDelegate UKNXDDFVFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ShowRoomCurrencyCreationUIDelegate TCYOGWMYUCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipOptionsDelegate WVJLUZXZEFX;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<Guid, int> MEGMOFCGUXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipGuidToIndexMapDelegate WSETNUDURCP;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<int, Guid> BBFWFDMBZUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAudioClipIndexToGuidMapDelegate UCEZDMIHKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipOptionsDelegate JPZDIJJCXVK;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<Guid, int> AMOMOGILXKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate VBBWHVVRZBS;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly IReadOnlyDictionary<int, Guid> LOQRVQYMCMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate JVBPTZVLUBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly PlayAudioPreviewDelegate KLFIQMQZNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly StopAudioPreviewDelegate KXSOETCMZRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly SubscriptionIsActiveDelegate ABOFKNGUNDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate DMBGLZKGRFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Dictionary<string, EnumChoiceData> OSTTGFSMBVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly ShowQuickChatEditMenuDelegate UUUYBDBPICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly ConfigureAttachedObjectDelegate WLBPVDNCOWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly DisplayInvalidNameErrorMessageDelegate SSZWOHENKXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly IsStringPureDelegate AQQGWUFAUGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly TryGetSpecificChipConfigSummaryDelegate UZYXDOKKUOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReleaseIconIdDelegate VYGBRFYOAAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate FHERCSOSCSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 PJUAZFXLXXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 PJZHWMRJHJF;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment LSLZLNCRGKV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool TZFGBSLLXQY
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xD28710", Offset = "0xD27110", VA = "0x180D28710", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> DFDASZHVUQD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> FDYRMBGEEOW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> QHYVTKNBMFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> FCDDRNTYUNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xCD76F0", Offset = "0xCD60F0", VA = "0x180CD76F0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion DRKANUTRJYV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xFF2CA0", Offset = "0xFF16A0", VA = "0x180FF2CA0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool SASMRMIMERR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xEC1540", Offset = "0xEBFF40", VA = "0x180EC1540", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool ENJJCVCLRBW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA950", Offset = "0x2AF9350", VA = "0x182AFA950", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UNMNSMBHVGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAE50", Offset = "0x2AF9850", VA = "0x182AFAE50", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool PMADZVMMMNX
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xCD2A70", Offset = "0xCD1470", VA = "0x180CD2A70", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB210", Offset = "0x2AF9C10", VA = "0x182AFB210")]
		public FXGUTMNCHHG([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFACA0", Offset = "0x2AF96A0", VA = "0x182AFACA0", Slot = "9")]
		public bool PBIGIPCIKBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850")]
		public static bool EUFMZTXKMYY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAEA0", Offset = "0x2AF98A0", VA = "0x182AFAEA0", Slot = "10")]
		public bool SZLKKBLIFXV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void QXXVHDJQYKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xEF2460", Offset = "0xEF0E60", VA = "0x180EF2460", Slot = "11")]
		public void ISNIDDWAHSC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA730", Offset = "0x2AF9130", VA = "0x182AFA730")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ADJHZLTJUYH(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAF00", Offset = "0x2AF9900", VA = "0x182AFAF00", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> VSVRZZQHYUS(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA880", Offset = "0x2AF9280", VA = "0x182AFA880")]
		private static IReadOnlyDictionary<Guid, int> CFFQSSFHDYL(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA9F0", Offset = "0x2AF93F0", VA = "0x182AFA9F0", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> JYWSZACLLMG(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA900", Offset = "0x2AF9300", VA = "0x182AFA900")]
		private static IReadOnlyDictionary<int, Guid> GIJANSZXDNV(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB020", Offset = "0x2AF9A20", VA = "0x182AFB020", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> ZKHSTZGWCTQ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAD60", Offset = "0x2AF9760", VA = "0x182AFAD60")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> POXWXVWBRGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1410", Offset = "0x2AEFE10", VA = "0x182AF1410", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> YZYQLJHYSEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAE00", Offset = "0x2AF9800", VA = "0x182AFAE00")]
		private static IReadOnlyDictionary<Guid, int> RHTXZLPTKDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA850", Offset = "0x2AF9250", VA = "0x182AFA850", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> BFBNOWGBRGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAF60", Offset = "0x2AF9960", VA = "0x182AFAF60", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> WIJEIGRUGTV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private static void HEBYZIIHVWJ(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB050", Offset = "0x2AF9A50", VA = "0x182AFB050", Slot = "18")]
		public void ZVUVQICFRUI(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private static void DOSPZADCDZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA9C0", Offset = "0x2AF93C0", VA = "0x182AFA9C0", Slot = "19")]
		public void JNQXXHVUKKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850")]
		private static bool AVLQZJVXLME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAD90", Offset = "0x2AF9790", VA = "0x182AFAD90", Slot = "20")]
		public bool RCQYDZWOIOL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850")]
		public static bool WLACZHCFGKT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAF30", Offset = "0x2AF9930", VA = "0x182AFAF30", Slot = "21")]
		public bool VUABGLSXIFQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA960", Offset = "0x2AF9360", VA = "0x182AFA960", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ITYSLTPJBAX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> UDTQUVZSIWN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> ZJXZQDIHFCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA8D0", Offset = "0x2AF92D0", VA = "0x182AFA8D0", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> EOJKWYWSIAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> GVGGYIDPMSI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> JIDGLRPXAXC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void DIDCHWYUDLI(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAE60", Offset = "0x2AF9860", VA = "0x182AFAE60", Slot = "29")]
		public void SSFEDGIJZDH(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private static void XGVKAWGRMBK(XVECRNMXAXL a, IWROMQEIXSV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFADC0", Offset = "0x2AF97C0", VA = "0x182AFADC0", Slot = "35")]
		public void RFHAJFGNCPV(XVECRNMXAXL a, IWROMQEIXSV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "36")]
		public Dictionary<string, EnumChoiceData> FPYSBPTWYAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "37")]
		public Dictionary<string, EnumChoiceData> KODWVXPIUPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private static void XIUTCLWLKXW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAA20", Offset = "0x2AF9420", VA = "0x182AFAA20")]
		private static Task<bool> MNXHZAJGGMM(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAED0", Offset = "0x2AF98D0", VA = "0x182AFAED0", Slot = "38")]
		public Task<bool> UNHZUQBIOQD(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFADF0", Offset = "0x2AF97F0", VA = "0x182AFADF0")]
		private static bool RFHGQRDKEZE(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAC60", Offset = "0x2AF9660", VA = "0x182AFAC60", Slot = "39")]
		public bool OIIFPIXHOMN(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private static void WXOKCZCIBVE(Id32<WOTREZTVRTI> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA990", Offset = "0x2AF9390", VA = "0x182AFA990", Slot = "40")]
		public void JACNXHQZTGJ(Id32<WOTREZTVRTI> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA760", Offset = "0x2AF9160", VA = "0x182AFA760")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, RYUTMMKYXMA>> AWJPGBAPLWY(Task<Result<None, RYUTMMKYXMA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAF90", Offset = "0x2AF9990", VA = "0x182AFAF90", Slot = "41")]
		public Task<Result<None, RYUTMMKYXMA>> YAECLQUKFXV(Task<Result<None, RYUTMMKYXMA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAA80", Offset = "0x2AF9480", VA = "0x182AFAA80")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, RYUTMMKYXMA>> NGKDLYDTWZU(Task<Result<MultiResult, RYUTMMKYXMA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAFC0", Offset = "0x2AF99C0", VA = "0x182AFAFC0", Slot = "42")]
		public Task<Result<MultiResult, RYUTMMKYXMA>> YAECLQUKFXV(Task<Result<MultiResult, RYUTMMKYXMA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAB70", Offset = "0x2AF9570", VA = "0x182AFAB70")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<CVONZJXKLFZ>, RYUTMMKYXMA>> NGPKJEXRGLD(Task<Result<Id32<CVONZJXKLFZ>, RYUTMMKYXMA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAFF0", Offset = "0x2AF99F0", VA = "0x182AFAFF0", Slot = "43")]
		public Task<Result<Id32<CVONZJXKLFZ>, RYUTMMKYXMA>> YAECLQUKFXV(Task<Result<Id32<CVONZJXKLFZ>, RYUTMMKYXMA>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class MGAYZVKUJDJ : ZTTTBJKYPDI
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(MNPVGDUGIJR e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? ZYILEYBECVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly InteropDelegate FRYEIPDMICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly InteropDelegate QVQMHLFJSVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private InteropDelegate? WBPZNFLJQXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private InvokeStudioFunctionDelegate? LPINRLIYVMN;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "5")]
		public LegacyCV2Result<None> BLYLFJCZSOZ(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0")]
		private static LegacyCV2Result<None> Default(MNPVGDUGIJR _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "6")]
		public LegacyCV2Result<None> VRBKXJGRQME(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "7")]
		public LegacyCV2Result<None> ZUNTJFZKDGV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "8")]
		public LegacyCV2Result<None> HTJJTCGUMDW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "9")]
		public LegacyCV2Result<None> REEBMNSLSIA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "15")]
		public LegacyCV2Result<None> YZGVXBSVVOZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JLMLCSDNCUX(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OMCURKPEHZT(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KNDAYMWIPXE(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FZZVGYLDXIH(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RPDGZTZHQIY(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FRTLKBFPWRE(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PKETVXIFGUZ(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "93")]
		public LegacyCV2Result<None> LIJIMJYBCTS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "94")]
		public LegacyCV2Result<None> WWVLCXIKOKG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "95")]
		public LegacyCV2Result<None> XIXPFGMACNN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PHQZQUJXFZR(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(MNPVGDUGIJR e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZAHJETTBQGJ(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YMJYGCZRDBD(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UBXTXSJPXPY(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EFGXJHDMBRZ(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RNCZLBRFNHE(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LMMRPBSELZS(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RSQNOABALXK(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ECGICEMWNMB(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x151E560", Offset = "0x151CF60", VA = "0x18151E560", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KLIAETJZSTO(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EQVCEMHPUNF(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "119")]
		public LegacyCV2Result<None> SRQQGRTYSVB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FABEXFJATDC(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "121")]
		public LegacyCV2Result<None> TUUCPBPZZFC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "122")]
		public LegacyCV2Result<None> GMMIVPAQXUI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "123")]
		public LegacyCV2Result<None> IDSQJEDGJWQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "124")]
		public LegacyCV2Result<None> BZIVAVFQJPG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "125")]
		public LegacyCV2Result<None> VZFMSVXOWHI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "126")]
		public LegacyCV2Result<None> GHHWDMXHEDR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "818")]
		public LegacyCV2Result<None> FSPKYOAXRUB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "819")]
		public LegacyCV2Result<None> IRBEAHRZKLH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "147")]
		public LegacyCV2Result<None> QCBRVGFLTVJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "148")]
		public LegacyCV2Result<None> SWUKQUGYMEL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "149")]
		public LegacyCV2Result<None> CGMOJUNIXMO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "150")]
		public LegacyCV2Result<None> UPLYISVLGRM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "151")]
		public LegacyCV2Result<None> FYWFJHEVKNB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(MNPVGDUGIJR e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(MNPVGDUGIJR e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(MNPVGDUGIJR e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, ZTTTBJKYPDI.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(MNPVGDUGIJR e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, ZTTTBJKYPDI.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "174")]
		public LegacyCV2Result<None> VGIYAQAAHMW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "175")]
		public LegacyCV2Result<None> WMTTHEDIVEP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "176")]
		public LegacyCV2Result<None> RLTTIHFOOEH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "197")]
		public LegacyCV2Result<None> BJHAZJFOKPD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "198")]
		public LegacyCV2Result<None> GLLROAETDNO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "199")]
		public LegacyCV2Result<None> CAPVNAXVFHR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "200")]
		public LegacyCV2Result<None> OBPKEPIPLQH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "201")]
		public LegacyCV2Result<None> XRXXLCONDLT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "202")]
		public LegacyCV2Result<None> RTNQASQWMKM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "203")]
		public LegacyCV2Result<None> WCCYRZLYHSC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "204")]
		public LegacyCV2Result<None> QVMFHJFAAGC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "205")]
		public LegacyCV2Result<None> WRNWZPQALNE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "206")]
		public LegacyCV2Result<None> ACCVYEYEPMS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "207")]
		public LegacyCV2Result<None> TQXNZFMOOPM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "208")]
		public LegacyCV2Result<None> BUQQDSFCIOS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "209")]
		public LegacyCV2Result<None> GZAZBBIMYBA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "210")]
		public LegacyCV2Result<None> XGERXMXCTKJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "211")]
		public LegacyCV2Result<None> KUVPXHZJDUI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "212")]
		public LegacyCV2Result<None> FJPRKNAGGSR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "213")]
		public LegacyCV2Result<None> RCZTHKGTWAO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "214")]
		public LegacyCV2Result<None> RIYRXXOQUOL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "215")]
		public LegacyCV2Result<None> DTDPOOHTVNQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "274")]
		public LegacyCV2Result<None> NEYIUKGRVOW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "277")]
		public LegacyCV2Result<None> EIQCCQFYREA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "279")]
		public LegacyCV2Result<None> UHFBMRJRANL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "280")]
		public LegacyCV2Result<None> UCWYONDGISD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "281")]
		public LegacyCV2Result<None> XCDBPHSJEKI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "282")]
		public LegacyCV2Result<None> NVJSXSVOBEV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "283")]
		public LegacyCV2Result<None> QCKZLCJGOLW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "287")]
		public LegacyCV2Result<None> HDRCKQMCTGV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "288")]
		public LegacyCV2Result<None> UTTFNVHAMTO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "317")]
		public LegacyCV2Result<None> BEEUQPVMUFP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "406")]
		public LegacyCV2Result<None> WVPTCZTPONO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UNSKABEEQUL(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AALMEGTEISH(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OFRRMKFEYGJ(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HHZPKHQYFHY(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QWPTXQFDAJX(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "416")]
		public LegacyCV2Result<KCIKIJZIIKJ.CV2DiscoverySectionType> ZLCNCYALPQC(MNPVGDUGIJR e, CircuitSignal a)
		{
			return default(LegacyCV2Result<KCIKIJZIIKJ.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "417")]
		public LegacyCV2Result<None> IBAPELDOSDI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(MNPVGDUGIJR e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WMTEOLJKOSO(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HFACMQNPWPT(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WCWGQRHKCEG(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "462")]
		public LegacyCV2Result<None> QXDZKEMDHZL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "463")]
		public LegacyCV2Result<None> VAHNFOTDQSQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "464")]
		public LegacyCV2Result<None> FKHTGZLADST(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "465")]
		public LegacyCV2Result<None> SDDEEXDDOGW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "466")]
		public LegacyCV2Result<None> QRKJFUFDOMM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "467")]
		public LegacyCV2Result<None> RCUUSJAINFC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "468")]
		public LegacyCV2Result<None> XWYVRWMJTQP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "469")]
		public LegacyCV2Result<None> VWDCPVRUHJL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "474")]
		public LegacyCV2Result<None> KWRCVAYZPFD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "475")]
		public LegacyCV2Result<None> NHQXFDVJQWL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "476")]
		public LegacyCV2Result<None> LRUGOBQUJWU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "477")]
		public LegacyCV2Result<None> PVDFNJMDXQR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "478")]
		public LegacyCV2Result<None> FFQOACNUPQP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "479")]
		public LegacyCV2Result<None> BZRRBOALEMY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(MNPVGDUGIJR executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(MNPVGDUGIJR executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "472")]
		public LegacyCV2Result<None> YDTCCAHYEVC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "473")]
		public LegacyCV2Result<None> CGDUEGGNLCA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "480")]
		public LegacyCV2Result<None> EVCTAYYNSTE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "481")]
		public LegacyCV2Result<None> RFNNHKVJXHK(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "482")]
		public LegacyCV2Result<None> QBCRBVBXDCR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "483")]
		public LegacyCV2Result<None> IQLGAHXMRUD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "484")]
		public LegacyCV2Result<None> WQAVCHSGWOL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "485")]
		public LegacyCV2Result<None> BREACZACUTP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "486")]
		public LegacyCV2Result<None> UETFJQLSJIT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "487")]
		public LegacyCV2Result<None> JSSTMSYUYMR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "488")]
		public LegacyCV2Result<None> BUCDQYJIKNR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "489")]
		public LegacyCV2Result<None> GKINHUWKMWP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "490")]
		public LegacyCV2Result<None> ILKJSGQAFQR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "491")]
		public LegacyCV2Result<None> CVMOBZHKYBR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "492")]
		public LegacyCV2Result<None> WCLRGPACZYV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "493")]
		public LegacyCV2Result<None> IGFQQIGUGFV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "494")]
		public LegacyCV2Result<None> WFIBGMHGYYL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "495")]
		public LegacyCV2Result<None> CPOMCZWMPAJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "496")]
		public LegacyCV2Result<None> PQBDFZWIDWR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "497")]
		public LegacyCV2Result<None> ENGZYCRBJNH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "498")]
		public LegacyCV2Result<None> BBTGQZOWKBL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "499")]
		public LegacyCV2Result<None> NMBOJBCYWXB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD760", Offset = "0x2AFC160", VA = "0x182AFD760", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "507")]
		public LegacyCV2Result<None> QLEAIQRMYJZ(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "508")]
		public LegacyCV2Result<None> QDJDKTARDIZ(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "509")]
		public LegacyCV2Result<None> CVDERMQHCGF(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "510")]
		public LegacyCV2Result<None> JDPRATPZWMY(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(MNPVGDUGIJR e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(MNPVGDUGIJR e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(MNPVGDUGIJR e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.XDWTLKDRXRD> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "522")]
		public LegacyCV2Result<None> IMOSNPYLHSU(MNPVGDUGIJR e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "525")]
		public LegacyCV2Result<None> WRWZYPBUNHW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "527")]
		public LegacyCV2Result<None> UHMGAMHMXSN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "528")]
		public LegacyCV2Result<None> RCZGMCJYAQP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "530")]
		public LegacyCV2Result<None> LCIVBOMKZGL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "531")]
		public LegacyCV2Result<None> JINMPTYCQKO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD6D0", Offset = "0x2AFC0D0", VA = "0x182AFD6D0", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "533")]
		public LegacyCV2Result<None> JPXZOUHAPRS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD690", Offset = "0x2AFC090", VA = "0x182AFD690", Slot = "535")]
		public LegacyCV2Result<None> CLXCCEOGRWO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "534")]
		public LegacyCV2Result<None> TPZZEFZSBEX(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "536")]
		public LegacyCV2Result<None> CDXTJJMMCQF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "537")]
		public LegacyCV2Result<None> GNDLYKUVBAW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "538")]
		public LegacyCV2Result<None> GDDGFMRTDSQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "539")]
		public LegacyCV2Result<None> IMEIOXDOANC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "540")]
		public LegacyCV2Result<None> UEWZBLEBEUK(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "583")]
		public LegacyCV2Result<None> Raycast(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "584")]
		public LegacyCV2Result<None> PRALJOCSGIT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "587")]
		public LegacyCV2Result<None> YJTDSMHSKXE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "591")]
		public LegacyCV2Result<None> DBRFPELAHIZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "592")]
		public LegacyCV2Result<None> GJELAOQMYGG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "641")]
		public LegacyCV2Result<None> BAMNBNSQTGD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "642")]
		public LegacyCV2Result<None> CWGSNIGGKVF(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "643")]
		public LegacyCV2Result<None> KVIVNUNAIJE(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "644")]
		public LegacyCV2Result<None> ECPGHKTZIRX(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "645")]
		public LegacyCV2Result<None> EAIUMBOAYNL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "646")]
		public LegacyCV2Result<None> BNJOGRVRHMW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "649")]
		public LegacyCV2Result<None> ZBBWXJOCVXL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "650")]
		public LegacyCV2Result<None> PHZRXUIVIRP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "651")]
		public LegacyCV2Result<None> RSSYVLQBKBM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "661")]
		public LegacyCV2Result<None> OFLSCFTPGFD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "660")]
		public LegacyCV2Result<None> KHPIFYGUITW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "662")]
		public LegacyCV2Result<None> HBKDBJYQRUD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "663")]
		public LegacyCV2Result<None> IFFBOBTWOHI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "670")]
		public LegacyCV2Result<None> MDRVNMDGQDH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "671")]
		public LegacyCV2Result<None> RQUJPECBYEU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "674")]
		public LegacyCV2Result<None> NFDEDZOVNHA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "675")]
		public LegacyCV2Result<None> UANMQDRZDQF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(MNPVGDUGIJR e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "696")]
		public LegacyCV2Result<None> UQACDRHLVCT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "697")]
		public LegacyCV2Result<None> OKTBZBIAZLT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "698")]
		public LegacyCV2Result<None> VZTAPUWINPZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "699")]
		public LegacyCV2Result<None> FRBTVIFEKJC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "700")]
		public LegacyCV2Result<None> LRTJTXFAYTU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "676")]
		public LegacyCV2Result<None> ECNFKBFHNRX(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "677")]
		public LegacyCV2Result<None> DDKDNWBIQWD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "678")]
		public LegacyCV2Result<None> DSPTJNLXLNQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "679")]
		public LegacyCV2Result<None> JPYIYNDUVML(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "680")]
		public LegacyCV2Result<None> FSFMJOVFJWA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "681")]
		public LegacyCV2Result<None> XSZHDCKQBEN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "682")]
		public LegacyCV2Result<None> HRRNJQYVSXZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "683")]
		public LegacyCV2Result<None> YZYVKFHGVSS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "684")]
		public LegacyCV2Result<None> DZSSVQPOGOM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "685")]
		public LegacyCV2Result<None> DYNGRQAJJRB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "686")]
		public LegacyCV2Result<None> AWHEKNQYQBV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "687")]
		public LegacyCV2Result<None> DXQOVWSIBVM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "688")]
		public LegacyCV2Result<None> LISWTQETSVL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "689")]
		public LegacyCV2Result<None> ZBTQLYSIGFD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "690")]
		public LegacyCV2Result<None> DWMALXVNLRI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "691")]
		public LegacyCV2Result<None> DTAMZGKBTTC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "692")]
		public LegacyCV2Result<None> MTOOEHGWDPA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "693")]
		public LegacyCV2Result<None> JQTDIVIAIWB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "765")]
		public LegacyCV2Result<None> ZHLSEPHJWUX(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "711")]
		public LegacyCV2Result<None> BWDPKKTOSJC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "712")]
		public LegacyCV2Result<None> XTAZZZXONRS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "713")]
		public LegacyCV2Result<None> BRENDHJRNVA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "714")]
		public LegacyCV2Result<None> MEJDHSRPJRC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "717")]
		public LegacyCV2Result<None> IUIPZKQLIBM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "721")]
		public LegacyCV2Result<None> EMBHBRJYVQH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "722")]
		public LegacyCV2Result<None> PJWJRQAAOUR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "723")]
		public LegacyCV2Result<None> UWCZZHJYWQE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "724")]
		public LegacyCV2Result<None> ARPFWUOTZJC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "725")]
		public LegacyCV2Result<None> RJCEIEKFBZG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "726")]
		public LegacyCV2Result<None> UHCUPMSRDRR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "727")]
		public LegacyCV2Result<None> FNYAZTFYZJM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "728")]
		public LegacyCV2Result<None> QRCRDCIIQXL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "729")]
		public LegacyCV2Result<None> IOOILQAXZYD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "730")]
		public LegacyCV2Result<None> FRZFLELUJKV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "731")]
		public LegacyCV2Result<None> WFRSXDOVIND(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "732")]
		public LegacyCV2Result<None> AIBVMAJOKNV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "733")]
		public LegacyCV2Result<None> RFXCPMPPIRR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "734")]
		public LegacyCV2Result<None> OUDXRYBGWJU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "735")]
		public LegacyCV2Result<None> ICSHFCHQOKL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "736")]
		public LegacyCV2Result<None> YJLYHCUSTIN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "737")]
		public LegacyCV2Result<None> BXJUEDPFWOE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "738")]
		public LegacyCV2Result<None> RNISFIISHPZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "740")]
		public LegacyCV2Result<None> UCOPBWPVESR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "739")]
		public LegacyCV2Result<None> OBLLURXXRYV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "741")]
		public LegacyCV2Result<None> WERNVVAGANG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "742")]
		public LegacyCV2Result<None> EMYSPSMREHZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "743")]
		public LegacyCV2Result<None> MUJEXYHATLG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "744")]
		public LegacyCV2Result<None> ZVOJUHLARUW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "745")]
		public LegacyCV2Result<None> LSFJIDAZEUF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "746")]
		public LegacyCV2Result<None> PRGAZTMAXKA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "747")]
		public LegacyCV2Result<None> BSFTKTJRMMY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "748")]
		public LegacyCV2Result<None> IGSMLDQEGED(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "749")]
		public LegacyCV2Result<None> PORMPXNRZLX(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "750")]
		public LegacyCV2Result<None> QHXAKUDMXHD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "751")]
		public LegacyCV2Result<None> VIIGFMVOUBN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "752")]
		public LegacyCV2Result<None> XGVTTHGELDB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "753")]
		public LegacyCV2Result<None> ZWTKGJGPPFF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "754")]
		public LegacyCV2Result<None> AZRSDAZXIOD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "755")]
		public LegacyCV2Result<None> MXGJEJLZGKG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "756")]
		public LegacyCV2Result<None> TTQIADQQZIA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "757")]
		public LegacyCV2Result<None> NTCURDCVGEE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "758")]
		public LegacyCV2Result<None> MNICBYVJPDG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "759")]
		public LegacyCV2Result<None> TUXJECLBXVZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "760")]
		public LegacyCV2Result<None> RNIMHFLHLCB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "761")]
		public LegacyCV2Result<None> VZSWOGJYFDJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "762")]
		public LegacyCV2Result<None> GSRGCSNNYTS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "763")]
		public LegacyCV2Result<None> PMPZDIZHWWK(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "764")]
		public LegacyCV2Result<None> SOJIYVFMMAT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "771")]
		public LegacyCV2Result<None> FXIGMWZZAJH(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "772")]
		public LegacyCV2Result<None> GTZOZVNAJHV(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "773")]
		public LegacyCV2Result<None> PMFZFIUQTSA(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(MNPVGDUGIJR ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "775")]
		public LegacyCV2Result<None> TKKJPJCZMWW(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "776")]
		public LegacyCV2Result<None> LTUENFTOUPY(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "777")]
		public LegacyCV2Result<None> JUMXCUCLQXD(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "778")]
		public LegacyCV2Result<None> TZOCPHZYMBF(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "779")]
		public LegacyCV2Result<None> JDVFHXSDBAP(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "707")]
		public LegacyCV2Result<None> ZVKMEBQMGAV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "801")]
		public LegacyCV2Result<None> CIPJLCZUSWT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "802")]
		public LegacyCV2Result<None> PGZZJTYCFXZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "803")]
		public LegacyCV2Result<None> DAYMKVTCAND(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "804")]
		public LegacyCV2Result<None> GQDZYWBUFZP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "805")]
		public LegacyCV2Result<None> CDZVSHBPKKT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "806")]
		public LegacyCV2Result<None> XQLVGRJYLSD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "807")]
		public LegacyCV2Result<None> KYUZDBUOYFD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "808")]
		public LegacyCV2Result<None> JXXNERQTOOB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "809")]
		public LegacyCV2Result<None> ELCTIKZNTBR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "810")]
		public LegacyCV2Result<None> ZUHOHBTUUYZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "811")]
		public LegacyCV2Result<None> JAHUTZTZQJT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "812")]
		public LegacyCV2Result<None> GKGSNKHQBPA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "817")]
		public LegacyCV2Result<None> OWOIQSEGMAF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "821")]
		public LegacyCV2Result<None> PPLOHIBYKPM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "822")]
		public LegacyCV2Result<None> NMLDEFEVSQO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "823")]
		public LegacyCV2Result<None> SLDYFTOSHOM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "824")]
		public LegacyCV2Result<None> PVDKTLQNHQU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "826")]
		public LegacyCV2Result<None> LEAIDUREIKE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "827")]
		public LegacyCV2Result<None> SDYZJAVAEZR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "828")]
		public LegacyCV2Result<None> KUWCGEIDGGV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "831")]
		public LegacyCV2Result<None> XGGVBIWHCBF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "832")]
		public LegacyCV2Result<None> YPGNLAVQKLO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "833")]
		public LegacyCV2Result<None> FVLUIOUZQRF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(MNPVGDUGIJR e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(MNPVGDUGIJR e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "836")]
		public LegacyCV2Result<None> VXCFKODBJYK(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> USQVOBIPYMQ(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EFPLEJUINLM(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SGPRHCTRKNH(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SAIWKTXJSMW(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XBYKWTMWBQT(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(MNPVGDUGIJR e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(MNPVGDUGIJR e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(MNPVGDUGIJR e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(MNPVGDUGIJR e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(MNPVGDUGIJR e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(MNPVGDUGIJR e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(MNPVGDUGIJR e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "856")]
		public LegacyCV2Result<None> IVYSLLRTVTA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "859")]
		public LegacyCV2Result<None> ARAYBTDIKYO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "860")]
		public LegacyCV2Result<None> DVXVFIJAPVG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "861")]
		public LegacyCV2Result<None> APARNNFYSBO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "862")]
		public LegacyCV2Result<None> FPKMDBJWHKB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "864")]
		public LegacyCV2Result<None> NLJDGUQXQHY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "865")]
		public LegacyCV2Result<None> NZVALZNTFLW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(MNPVGDUGIJR e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "869")]
		public LegacyCV2Result<None> GMJGKQNFQNG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "879")]
		public LegacyCV2Result<None> NLDSEKLEJNE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "880")]
		public LegacyCV2Result<None> BCZYOGHKTLC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "881")]
		public LegacyCV2Result<None> IQYTFFCISGJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "882")]
		public LegacyCV2Result<None> LDZVFXNNDNS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(MNPVGDUGIJR e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(MNPVGDUGIJR e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(MNPVGDUGIJR e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(MNPVGDUGIJR e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(MNPVGDUGIJR e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "889")]
		public LegacyCV2Result<None> RLUFDZQFECE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "890")]
		public LegacyCV2Result<None> ABWKEOPUAXF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "891")]
		public LegacyCV2Result<None> AXIWUIZMPKG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "892")]
		public LegacyCV2Result<None> UZUBGBQBPDA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "893")]
		public LegacyCV2Result<None> KRPUEJYLKUU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "897")]
		public LegacyCV2Result<None> GMBKFVJYBGV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "898")]
		public LegacyCV2Result<None> WCQGXRCNUUB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "899")]
		public LegacyCV2Result<None> ZDRSQKVYRAM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "901")]
		public LegacyCV2Result<None> ZOMIRUPMMSI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "900")]
		public LegacyCV2Result<None> HDTMQRITOEQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "902")]
		public LegacyCV2Result<None> SXEYXUNSXOV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "904")]
		public LegacyCV2Result<None> NQXUAMMWSJH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "903")]
		public LegacyCV2Result<None> YKEINKAJZTR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "905")]
		public LegacyCV2Result<None> AFJNSKPURMI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "906")]
		public LegacyCV2Result<None> UETKFQNYALC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "907")]
		public LegacyCV2Result<None> KPVMYMFMDEV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "908")]
		public LegacyCV2Result<None> OCDLGCZZOET(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "909")]
		public LegacyCV2Result<None> DVSVTZTMJHR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "910")]
		public LegacyCV2Result<None> PMYDGLQDSXR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "911")]
		public LegacyCV2Result<None> KAPRVZTSIGP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "918")]
		public LegacyCV2Result<None> NHMQMQWVHXD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "919")]
		public LegacyCV2Result<None> OFOXHJRTNVX(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(MNPVGDUGIJR e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(MNPVGDUGIJR e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(MNPVGDUGIJR e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(MNPVGDUGIJR e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(MNPVGDUGIJR e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(MNPVGDUGIJR e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(MNPVGDUGIJR e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(MNPVGDUGIJR e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(MNPVGDUGIJR e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "941")]
		public LegacyCV2Result<None> QLLHTFFLOIH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "942")]
		public LegacyCV2Result<None> LTDRZDWHKPB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "943")]
		public LegacyCV2Result<None> NKGXBNDIAOQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "944")]
		public LegacyCV2Result<None> ESBJLTEOVVA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "945")]
		public LegacyCV2Result<None> AXLJJYFIGTT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "946")]
		public LegacyCV2Result<None> PPZGVCOEWET(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "947")]
		public LegacyCV2Result<None> DHEMPTPBJWK(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "948")]
		public LegacyCV2Result<None> XEMRAJCPMNE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "949")]
		public LegacyCV2Result<None> NLPXVOJCPMG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "950")]
		public LegacyCV2Result<None> NZIHORZQLPH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "968")]
		public LegacyCV2Result<None> HZEYQXTOTZT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "967")]
		public LegacyCV2Result<None> SXXKCRUEEIO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "969")]
		public LegacyCV2Result<None> JNSKKZSXSMU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "970")]
		public LegacyCV2Result<None> ALTIZGFTRKF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "971")]
		public LegacyCV2Result<None> CRLBPFLIIJY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "972")]
		public LegacyCV2Result<None> AIUGMBDTGIM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "973")]
		public LegacyCV2Result<None> QMTEDZQEKPP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "975")]
		public LegacyCV2Result<None> ZWVQILWOZBM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "982")]
		public LegacyCV2Result<None> RKDPCWUXYCN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "983")]
		public LegacyCV2Result<None> JCFTNQYLLCL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "991")]
		public LegacyCV2Result<None> SQKUENMBKBY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "993")]
		public LegacyCV2Result<None> RUOPWQUTEVY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "994")]
		public LegacyCV2Result<None> ISOOGAIUCVQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "995")]
		public LegacyCV2Result<None> KHUVNQUITIY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "996")]
		public LegacyCV2Result<None> ROLOTIPUROM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "997")]
		public LegacyCV2Result<None> KWEQXNYBCDM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "998")]
		public LegacyCV2Result<None> YSVCSYBEJFQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "999")]
		public LegacyCV2Result<None> ESNQCXWNPBS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1000")]
		public LegacyCV2Result<None> TBYBLRBLBDS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1001")]
		public LegacyCV2Result<None> SKYVOFCNHVO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1002")]
		public LegacyCV2Result<None> COUPPAUXSFG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1009")]
		public LegacyCV2Result<None> JDWNYPRGNUG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1017")]
		public LegacyCV2Result<None> YVJFZCZHPJT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1018")]
		public LegacyCV2Result<None> IAHOMFGLFOE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1019")]
		public LegacyCV2Result<None> VAPOZNJWRWN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1020")]
		public LegacyCV2Result<None> VINNOUOPIQY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1021")]
		public LegacyCV2Result<None> DCMNDVYCXLP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1022")]
		public LegacyCV2Result<None> TDDGZYZZJKS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1023")]
		public LegacyCV2Result<None> OVKIBISPNDB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1024")]
		public LegacyCV2Result<None> WBQICDGAJBZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1025")]
		public LegacyCV2Result<None> QMOYROHQELM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1026")]
		public LegacyCV2Result<None> ILEPIFDTFIR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1027")]
		public LegacyCV2Result<None> OSFMBIFMRPD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1028")]
		public LegacyCV2Result<None> PAXNUVFERQW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1029")]
		public LegacyCV2Result<None> FNESKEXYNPQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1030")]
		public LegacyCV2Result<None> GXXKXKUHXOR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1031")]
		public LegacyCV2Result<None> DPMXONEFBGO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1032")]
		public LegacyCV2Result<None> BWJDENXRAMV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1033")]
		public LegacyCV2Result<None> KNFQFHVHXAR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1047")]
		public LegacyCV2Result<None> IOXWOLHDYXB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1048")]
		public LegacyCV2Result<None> SKJLDWSVYKP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1049")]
		public LegacyCV2Result<None> FVOEUIYLZVB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1050")]
		public LegacyCV2Result<None> EMDZBMBCWQD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1051")]
		public LegacyCV2Result<None> SGNYGMROLEU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1052")]
		public LegacyCV2Result<None> EIYBDKRZKAU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1053")]
		public LegacyCV2Result<None> WLUVSHLHFSL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1054")]
		public LegacyCV2Result<None> OUOKIVJBECW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1055")]
		public LegacyCV2Result<None> NRLZYWZTHQZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1056")]
		public LegacyCV2Result<None> WGQDDUNFRVE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1057")]
		public LegacyCV2Result<None> QYCPGOSZJJQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1058")]
		public LegacyCV2Result<None> KKOFGWYIZCP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1059")]
		public LegacyCV2Result<None> OOCCLPTTGTY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1060")]
		public LegacyCV2Result<None> VRGPKNYRFSQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1061")]
		public LegacyCV2Result<None> AZHOZKWNEAM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1062")]
		public LegacyCV2Result<None> JADTHMLEYCY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1063")]
		public LegacyCV2Result<None> VOFOCVXJFXG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1064")]
		public LegacyCV2Result<None> WGEGFXEUCAJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1065")]
		public LegacyCV2Result<None> DQYKZHVZWBD(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1066")]
		public LegacyCV2Result<None> ZQUWJPKWDSS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1067")]
		public LegacyCV2Result<None> TFPRWKBSAYO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1068")]
		public LegacyCV2Result<None> OHFNPFHKJWY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1069")]
		public LegacyCV2Result<None> FAKVWWDMIME(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1070")]
		public LegacyCV2Result<None> POUAMMICNAN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1071")]
		public LegacyCV2Result<None> BPCPIXABJYR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD710", Offset = "0x2AFC110", VA = "0x182AFD710", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(MNPVGDUGIJR e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(MNPVGDUGIJR e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1092")]
		public LegacyCV2Result<None> JXKSRGTKBXC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1093")]
		public LegacyCV2Result<None> FNINUCLGTUP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1094")]
		public LegacyCV2Result<None> YJZEIAUGKZN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1095")]
		public LegacyCV2Result<None> IJZFBTTERGP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1096")]
		public LegacyCV2Result<None> UMMLZTWPSNB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1097")]
		public LegacyCV2Result<None> AIUINZJBXKJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1098")]
		public LegacyCV2Result<None> QRHFPRBYJWF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1099")]
		public LegacyCV2Result<None> GGTFNGTYMWB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1100")]
		public LegacyCV2Result<None> PSCDRLPFBTH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1101")]
		public LegacyCV2Result<None> VHNPCIGDOIF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1102")]
		public LegacyCV2Result<None> BUGEXWZDMSN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1103")]
		public LegacyCV2Result<None> GMIHPVYINES(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1104")]
		public LegacyCV2Result<None> MNDCPROIUCO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1105")]
		public LegacyCV2Result<None> AXOQDSDQUTQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1106")]
		public LegacyCV2Result<None> MVTADCFMJCS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1107")]
		public LegacyCV2Result<None> HYTSEVCYAQB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1108")]
		public LegacyCV2Result<None> YUJNSQEAKUN(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1109")]
		public LegacyCV2Result<None> BPDAGGWCTLW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1110")]
		public LegacyCV2Result<None> YXFLOIXCPWU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1111")]
		public LegacyCV2Result<None> LBDTBYOYRKU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1112")]
		public LegacyCV2Result<None> DDNMASVOBSQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1113")]
		public LegacyCV2Result<None> VRVZPQOUNSZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1114")]
		public LegacyCV2Result<None> QAILKGKJEOR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1115")]
		public LegacyCV2Result<None> MYVIYWXKVFO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1116")]
		public LegacyCV2Result<None> EQSTRHEPQUA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1117")]
		public LegacyCV2Result<None> WDURDYBNWQE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1118")]
		public LegacyCV2Result<None> WLBSADRUMQA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1119")]
		public LegacyCV2Result<None> WTKMMRKSCDT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1120")]
		public LegacyCV2Result<None> XVCFACZREHI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1121")]
		public LegacyCV2Result<None> AWVOGKTSYCW(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1122")]
		public LegacyCV2Result<None> FMFIALFZWZM(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1123")]
		public LegacyCV2Result<None> FIOPSQTJNEN(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1124")]
		public LegacyCV2Result<None> BZMFRXAWWND(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1125")]
		public LegacyCV2Result<None> WIZOPCJEKPH(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1126")]
		public LegacyCV2Result<None> MZMMOAMPEXT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1127")]
		public LegacyCV2Result<None> FOGDNIMKNMR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1128")]
		public LegacyCV2Result<None> GUNIRPRDDIV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1129")]
		public LegacyCV2Result<None> TCGSWXYXASP(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1130")]
		public LegacyCV2Result<None> DHWHYNHTSEU(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1131")]
		public LegacyCV2Result<None> TZVANKCCXVD(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1132")]
		public LegacyCV2Result<None> FMIUJXASZRS(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1133")]
		public LegacyCV2Result<None> YESARPLSKGB(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1134")]
		public LegacyCV2Result<None> EUADWTPKDYN(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1135")]
		public LegacyCV2Result<None> KLQQZUEDPXY(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1136")]
		public LegacyCV2Result<None> NSZCHIXTPZM(AQJBJOMITDO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1140")]
		public LegacyCV2Result<None> APXZIWSFAGC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1166")]
		public LegacyCV2Result<None> VPWFQYDPQPO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1168")]
		public LegacyCV2Result<None> IXEMZAKKKOG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1169")]
		public LegacyCV2Result<None> BHJBQXTKKDP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1170")]
		public LegacyCV2Result<None> IODIWBLWSYE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1171")]
		public LegacyCV2Result<None> RZDMNEAUXLL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1182")]
		public LegacyCV2Result<None> XTFCMCTUZUJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1183")]
		public LegacyCV2Result<None> STGPTKBAYBV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1184")]
		public LegacyCV2Result<None> EHJHTMPTVWH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1185")]
		public LegacyCV2Result<None> XQCSISKVYDT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1186")]
		public LegacyCV2Result<None> WPZGCJJEMFU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1187")]
		public LegacyCV2Result<None> FCKYYVCDWDQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1188")]
		public LegacyCV2Result<None> BTCXZADLNTW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1189")]
		public LegacyCV2Result<None> EHYVHBMLPSI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1190")]
		public LegacyCV2Result<None> UMWXZVKXQED(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1191")]
		public LegacyCV2Result<None> BAMRABCJWLZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1192")]
		public LegacyCV2Result<None> TTOKIAENOZO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1193")]
		public LegacyCV2Result<None> CIHPPGQSXWB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "184")]
		public LegacyCV2Result<None> EDOWGOZWPMV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD750", Offset = "0x2AFC150", VA = "0x182AFD750", Slot = "191")]
		public bool JOSKPGDEJOL(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1194")]
		public LegacyCV2Result<None> JGJJJAWXOKB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1195")]
		public LegacyCV2Result<None> TLAWPDRKWBS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1196")]
		public LegacyCV2Result<None> WMVWKOIOJXJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(MNPVGDUGIJR e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1205")]
		public LegacyCV2Result<None> GQIVVHICAAA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1206")]
		public LegacyCV2Result<None> OSJVBQBEWWI(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(MNPVGDUGIJR e, InOut io, JLBKWYMCWPS objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "250")]
		public LegacyCV2Result<None> VGHFYOQMXAR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "251")]
		public LegacyCV2Result<None> EGMOAATVFHZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "252")]
		public LegacyCV2Result<None> MOBSVSODKSL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "254")]
		public LegacyCV2Result<None> BUWNEMRRJEQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "255")]
		public LegacyCV2Result<None> ZAYUWROJVSY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "256")]
		public LegacyCV2Result<None> UXKOBMWFBFO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "257")]
		public LegacyCV2Result<None> WGBJNERQSFF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "258")]
		public LegacyCV2Result<None> WUUXFWZOXWT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "259")]
		public LegacyCV2Result<None> DVWAPVJUSPC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "260")]
		public LegacyCV2Result<None> YFREEDQROBK(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "261")]
		public LegacyCV2Result<None> CYZTZABGUOS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "262")]
		public LegacyCV2Result<None> BARMSHEIZIW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "263")]
		public LegacyCV2Result<None> KBWDVJRDNSV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "264")]
		public LegacyCV2Result<None> NSSTJETOCCV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "265")]
		public LegacyCV2Result<None> QKMJEHIHMCX(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "266")]
		public LegacyCV2Result<None> ULFXBMNBOLR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "267")]
		public LegacyCV2Result<None> UOLAOKPYWBB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "268")]
		public LegacyCV2Result<None> MPKGVAZYNAR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "269")]
		public LegacyCV2Result<None> LNJENXYVGDT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0")]
		private static LegacyCV2Result<None> Default(MNPVGDUGIJR e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD7A0", Offset = "0x2AFC1A0", VA = "0x182AFD7A0", Slot = "1209")]
		public LegacyCV2Result<None> TARPAJIGUNM(MNPVGDUGIJR a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1212")]
		public LegacyCV2Result<None> IFCQUSJCIGJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1213")]
		public LegacyCV2Result<None> PFJRVHYNFOL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1214")]
		public LegacyCV2Result<None> JLFTANZNVVF(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1215")]
		public LegacyCV2Result<None> XSSAZFOCJTW(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(MNPVGDUGIJR e, InOut io, ZXKGRYTRQIY quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1036")]
		public LegacyCV2Result<None> HTZBECWGCMB(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1037")]
		public LegacyCV2Result<None> ZFCNQJBQABL(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1038")]
		public LegacyCV2Result<None> BCJCTPZZUGH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1039")]
		public LegacyCV2Result<None> NAVBGQTWGXZ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1040")]
		public LegacyCV2Result<None> MEPFSJYGNCJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1041")]
		public LegacyCV2Result<None> DUPCVASKMTP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1042")]
		public LegacyCV2Result<None> RPXNUDXZCZT(MNPVGDUGIJR a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1043")]
		public LegacyCV2Result<None> MHHMRQQYZCH(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1044")]
		public LegacyCV2Result<None> XPTGRATKHIX(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1045")]
		public LegacyCV2Result<None> VEBEJBJSSCO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1046")]
		public LegacyCV2Result<None> CWQOTZPNAFE(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GPFEFISAIIO(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1234")]
		public LegacyCV2Result<None> NKFPAIUTBRT(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1236")]
		public LegacyCV2Result<None> WLBJEISAQQQ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1229")]
		public LegacyCV2Result<None> AYLGFMJZFSO(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1241")]
		public LegacyCV2Result<None> VWMGOHNQSYK(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1242")]
		public LegacyCV2Result<None> UXMVTXBOIOV(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1243")]
		public LegacyCV2Result<None> DRCVSWRYBSR(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1244")]
		public LegacyCV2Result<None> PKLVJLPJOTJ(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1245")]
		public LegacyCV2Result<None> LTUNUXHVGUU(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> INGPPMIDWNI(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YEHJLTFDZNI(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PCCFIDRFHGU(MNPVGDUGIJR a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1259")]
		public LegacyCV2Result<None> QJYXTSTUTCA(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1260")]
		public LegacyCV2Result<None> ESEKDVLZULY(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1261")]
		public LegacyCV2Result<None> KKVSCBZIQKG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1262")]
		public LegacyCV2Result<None> FQBTRUPJIOC(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD830", Offset = "0x2AFC230", VA = "0x182AFD830")]
		public MGAYZVKUJDJ([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(MNPVGDUGIJR e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1280")]
		public LegacyCV2Result<None> OHABRLXYDPP(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1281")]
		public LegacyCV2Result<None> MERBOTSICNS(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "599")]
		public LegacyCV2Result<None> LDEVOROHZEG(MNPVGDUGIJR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1293")]
		public LegacyCV2Result<None> TMBDIQIWWQB(AQJBJOMITDO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1294")]
		public LegacyCV2Result<None> BKXONDMLVMU(AQJBJOMITDO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1295")]
		public LegacyCV2Result<None> GMWKLQHMROV(AQJBJOMITDO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1296")]
		public LegacyCV2Result<None> PAUPKLESPHV(AQJBJOMITDO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1297")]
		public LegacyCV2Result<None> LUGXCUAFPFE(AQJBJOMITDO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0")]
		public LegacyCV2Result<None> ConstantStorefrontItem(MNPVGDUGIJR e, InOut io, [In] FKQHJCRSURP storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(MNPVGDUGIJR e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> DSMMSDOAYMW(MNPVGDUGIJR a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, ZTTTBJKYPDI.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> GBPABETXQII(MNPVGDUGIJR a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, ZTTTBJKYPDI.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1207")]
		private LegacyCV2Result<None> SAIAWSWHHQT(MNPVGDUGIJR a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1216")]
		private LegacyCV2Result<None> QAKHXBLCUBS(MNPVGDUGIJR a, InOut b, [In] FKQHJCRSURP storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "1257")]
		private LegacyCV2Result<None> WNECJBFGAPK(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class WJYTEEBYAPA : HYUDKEUUZXJ
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(NUEOXSANYOQ node);

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly WJYTEEBYAPA KDIOXRMUMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate YNUZVOCNYRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate IAGVSGJODKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private bool HMALHTOUBIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private bool VZTBFNVSEOF;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE10", Offset = "0x2B0A810", VA = "0x182B0BE10", Slot = "4")]
		public Task<bool> VSTOSKJKEQU(NUEOXSANYOQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2B11BD0", Offset = "0x2B105D0", VA = "0x182B11BD0", Slot = "5")]
		public Task<bool> JFKFUOJFHKH(NUEOXSANYOQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2B11CA0", Offset = "0x2B106A0", VA = "0x182B11CA0")]
		public WJYTEEBYAPA([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C00", Offset = "0x2B10600", VA = "0x182B11C00", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? NOWHKDJPINS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xCDB270", Offset = "0xCD9C70", VA = "0x180CDB270", Slot = "7")]
		public bool VREHOZWHNYR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x15E74B0", Offset = "0x15E5EB0", VA = "0x1815E74B0", Slot = "8")]
		public bool QEXYSONMZDH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class EOIXCUBATHM : MEACUSORBRT
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid WBXPJZPWWBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xEF88F0", Offset = "0xEF72F0", VA = "0x180EF88F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
		public void Bind(SBDIEKQLAFH pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x10E2010", Offset = "0x10E0A10", VA = "0x1810E2010")]
		public EOIXCUBATHM(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A970", Offset = "0x2B09370", VA = "0x182B0A970")]
		public static EOIXCUBATHM New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class KAEJZRWAUJS : YWXACDIEBZA
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<DAVIPBXXNLR> nodeDefId, Id128<MHARATWVONH>? legacyInnerGraphId, IReadOnlyDictionary<Id128<MHARATWVONH>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IsNodeRestrictedDelegate? EPXRRVTIIXZ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool SASMRMIMERR
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xD28710", Offset = "0xD27110", VA = "0x180D28710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JBHENIARIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2B0BD30", Offset = "0x2B0A730", VA = "0x182B0BD30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AXMGGDQABVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x11007D0", Offset = "0x10FF1D0", VA = "0x1811007D0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "6")]
		public bool MRQLJFJBAGF(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "7")]
		public CanSaveObjectIntoInventionResultType TIECBVKTRTE(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BD40", Offset = "0x2B0A740", VA = "0x182B0BD40", Slot = "8")]
		public bool CQPCWEKSOVX(Id128<DAVIPBXXNLR> nodeDefId, Id128<MHARATWVONH>? legacyInnerGraphId, IReadOnlyDictionary<Id128<MHARATWVONH>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "9")]
		public bool HSQTGHRJIUK(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "10")]
		public bool CFZGMGWPCKY(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BD90", Offset = "0x2B0A790", VA = "0x182B0BD90")]
		public KAEJZRWAUJS(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class EBVVRIMFWYS : PDFENVGSLXV
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly EBVVRIMFWYS KDIOXRMUMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly ShouldLogEventSenderToMakerPenDelegate PBCNDZLPKBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate BGWFJZKPPIY;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ZALFCDCURVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x129FCC0", Offset = "0x129E6C0", VA = "0x18129FCC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ZBOUPHHKORU
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A270", Offset = "0x2B08C70", VA = "0x182B0A270", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A310", Offset = "0x2B08D10", VA = "0x182B0A310")]
		public EBVVRIMFWYS([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class XFKHDQGGAIY : JEMWUSSDJUE<SHCDMTYIUNK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class ZFGDKFFZHAT : SHCDMTYIUNK, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly ZFGDKFFZHAT IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool OEDHLMOSWBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2B12130", Offset = "0x2B10B30", VA = "0x182B12130", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			public void SSCYETFXNUV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZFGDKFFZHAT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly XFKHDQGGAIY IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private XFKHDQGGAIY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B11EB0", Offset = "0x2B108B0", VA = "0x182B11EB0", Slot = "4")]
		public SHCDMTYIUNK WCWBJUPIQVL()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class ZGUBSLDPVXI<a, b> : IDisposable, RMMDEDBMVOB where a : notnull where b : notnull, WZVSWFCXEUU.ZFMZEQYTVOK<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly b ANTAOVGZRYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly a EYQJGPXKOQR;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<QEBRWUBFUFW> HGMEIUADVSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xCE2550", Offset = "0xCE0F50", VA = "0x180CE2550", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QEBRWUBFUFW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x517E470", Offset = "0x517CE70", VA = "0x18517E470")]
		public ZGUBSLDPVXI(b a, a b, Id32<QEBRWUBFUFW> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x517CB00", Offset = "0x517B500", VA = "0x18517CB00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x517DCD0", Offset = "0x517C6D0", VA = "0x18517DCD0")]
		public Id32<SLTVKIGDHLN> WXSFFCSMOWS([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<SLTVKIGDHLN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x517D270", Offset = "0x517BC70", VA = "0x18517D270", Slot = "6")]
		public void PZANMLEIQCJ(Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x517C6B0", Offset = "0x517B0B0", VA = "0x18517C6B0", Slot = "7")]
		public void BQZHTXSZRZZ(Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x517C1D0", Offset = "0x517ABD0", VA = "0x18517C1D0", Slot = "8")]
		public void AUYBRXCOAZK(Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x517CFF0", Offset = "0x517B9F0", VA = "0x18517CFF0", Slot = "10")]
		public void PEXCDCVVNRR(Id32<SLTVKIGDHLN> objectId, Id32<QEBRWUBFUFW> clientId, YOWRGPCINZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x517D570", Offset = "0x517BF70", VA = "0x18517D570", Slot = "9")]
		public void RNQFJWSXYDH(Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x517D7F0", Offset = "0x517C1F0", VA = "0x18517D7F0", Slot = "11")]
		public void RTGHZGHWXLL(Id32<SLTVKIGDHLN> objectId, XRFLWTQTKUE? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x517DF90", Offset = "0x517C990", VA = "0x18517DF90", Slot = "12")]
		public Id32<QEBRWUBFUFW> ZXBMCXLDMPQ(Id32<SLTVKIGDHLN> objectId)
		{
			return default(Id32<QEBRWUBFUFW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x517D2B0", Offset = "0x517BCB0", VA = "0x18517D2B0", Slot = "13")]
		public Id32<YFBJPXYJORD> QMZLKHZKJJU(Id32<SLTVKIGDHLN> objectId, string a, object b, bool c, QHMMCWYGQBV d, HZOEHZSWUUR e)
		{
			return default(Id32<YFBJPXYJORD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x517DF50", Offset = "0x517C950", VA = "0x18517DF50", Slot = "14")]
		public void XALELJNVKPM(Id32<YFBJPXYJORD> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x517CB30", Offset = "0x517B530", VA = "0x18517CB30", Slot = "15")]
		public void KZIKNIQBEGQ(Id32<YFBJPXYJORD> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class WZVSWFCXEUU
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface ZFMZEQYTVOK<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void UGJDDZFOSBQ(a a, Id32<QEBRWUBFUFW> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<QEBRWUBFUFW>? ONXACOSDQPX(a a);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<SLTVKIGDHLN> WXSFFCSMOWS(a a, Id32<QEBRWUBFUFW> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void PZANMLEIQCJ(a a, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void BQZHTXSZRZZ(a a, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void PEXCDCVVNRR(a a, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI b);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void RNQFJWSXYDH(a a, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI b);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void RTGHZGHWXLL(a a, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, XRFLWTQTKUE? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<QEBRWUBFUFW>? ZXBMCXLDMPQ(a a, Id32<SLTVKIGDHLN> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<YFBJPXYJORD> QMZLKHZKJJU(a a, Id32<QEBRWUBFUFW> clientId, string b, object c, QHMMCWYGQBV d, HZOEHZSWUUR e);

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void XALELJNVKPM(a a, Id32<QEBRWUBFUFW> clientId, Id32<YFBJPXYJORD> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void KZIKNIQBEGQ(a a, Id32<QEBRWUBFUFW> clientId, Id32<YFBJPXYJORD> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class MMQDJHNVCQS
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly HashSet<Id32<SLTVKIGDHLN>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAId32Field<YFBJPXYJORD, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public readonly Dictionary<Id32<YFBJPXYJORD>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<YFBJPXYJORD>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public SOAField<SLTVKIGDHLN, XRFLWTQTKUE?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E720", Offset = "0x2B0D120", VA = "0x182B0E720")]
			private MockCV2DynamicNetSys(HashSet<Id32<SLTVKIGDHLN>> authorityOf, [In] SOAId32Field<YFBJPXYJORD, MockCV2SyncField> syncFields, Dictionary<Id32<YFBJPXYJORD>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<YFBJPXYJORD>> mockSyncFieldToSyncField, [In] SOAField<SLTVKIGDHLN, XRFLWTQTKUE?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E560", Offset = "0x2B0CF60", VA = "0x182B0E560")]
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
			public Id32<QEBRWUBFUFW>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E7C0", Offset = "0x2B0D1C0", VA = "0x182B0E7C0")]
			public MockCV2ObjectShared(Id32<QEBRWUBFUFW> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public HZOEHZSWUUR SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public QHMMCWYGQBV SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x10DE880", Offset = "0x10DD280", VA = "0x1810DE880")]
			internal MockCV2SyncField(HZOEHZSWUUR syncField, QHMMCWYGQBV syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E8E0", Offset = "0x2B0D2E0", VA = "0x182B0E8E0")]
			public static MockCV2SyncField New(HZOEHZSWUUR syncField, QHMMCWYGQBV syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x2B0E890", Offset = "0x2B0D290", VA = "0x182B0E890")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E840", Offset = "0x2B0D240", VA = "0x182B0E840")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<SLTVKIGDHLN, MockCV2ObjectShared> LDDKNFVEKUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<SLTVKIGDHLN>> GIBDLSUBOWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> BEBJGGNUJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> WPIBMLGXRRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private SOAField<QEBRWUBFUFW, MockCV2DynamicNetSys> RXQTNWPVFFN;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<SLTVKIGDHLN>? XYKXTZVMLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xDA8860", Offset = "0xDA7260", VA = "0x180DA8860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x1279990", Offset = "0x1278390", VA = "0x181279990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C3F0", Offset = "0x2B0ADF0", VA = "0x182B0C3F0")]
		public void Destroy([In] SOAId32<QEBRWUBFUFW> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C9A0", Offset = "0x2B0B3A0", VA = "0x182B0C9A0")]
		public void OMUFVTCAFLQ(Id32<QEBRWUBFUFW> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D430", Offset = "0x2B0BE30", VA = "0x182B0D430")]
		public void UGJDDZFOSBQ(Id32<QEBRWUBFUFW> clientId, Id32<QEBRWUBFUFW>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D770", Offset = "0x2B0C170", VA = "0x182B0D770")]
		public Id32<SLTVKIGDHLN> WXSFFCSMOWS(Id32<QEBRWUBFUFW> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<QEBRWUBFUFW> clientIds)
		{
			return default(Id32<SLTVKIGDHLN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CF80", Offset = "0x2B0B980", VA = "0x182B0CF80")]
		public Id32<YFBJPXYJORD> QMZLKHZKJJU(Id32<QEBRWUBFUFW> clientId, string a, object b, QHMMCWYGQBV c, HZOEHZSWUUR d)
		{
			return default(Id32<YFBJPXYJORD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DB80", Offset = "0x2B0C580", VA = "0x182B0DB80")]
		public void XALELJNVKPM(Id32<QEBRWUBFUFW> clientId, Id32<YFBJPXYJORD> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C320", Offset = "0x2B0AD20", VA = "0x182B0C320")]
		public Id32<SLTVKIGDHLN>? CMHAGNHCVFF([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CF00", Offset = "0x2B0B900", VA = "0x182B0CF00")]
		public void PZANMLEIQCJ([In] SOAId32<QEBRWUBFUFW> clientIds, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C1E0", Offset = "0x2B0ABE0", VA = "0x182B0C1E0")]
		public void BQZHTXSZRZZ(Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CE00", Offset = "0x2B0B800", VA = "0x182B0CE00")]
		public void PEXCDCVVNRR(Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D1E0", Offset = "0x2B0BBE0", VA = "0x182B0D1E0")]
		public void RNQFJWSXYDH([In] SOAId32<QEBRWUBFUFW> clientIds, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D360", Offset = "0x2B0BD60", VA = "0x182B0D360")]
		public void RTGHZGHWXLL(Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, XRFLWTQTKUE? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DD10", Offset = "0x2B0C710", VA = "0x182B0DD10")]
		public Id32<QEBRWUBFUFW>? ZXBMCXLDMPQ(Id32<SLTVKIGDHLN> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C630", Offset = "0x2B0B030", VA = "0x182B0C630")]
		public void KZIKNIQBEGQ([In] SOAId32<QEBRWUBFUFW> clientIds, Id32<QEBRWUBFUFW> clientId, Id32<YFBJPXYJORD> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DD60", Offset = "0x2B0C760", VA = "0x182B0DD60")]
		public MMQDJHNVCQS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class ZVCJAGYAVZH
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x2B121D0", Offset = "0x2B10BD0", VA = "0x182B121D0")]
		public static void Destroy(this MMQDJHNVCQS.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class DOZYNPMRPFH : BZVXRTNDJQB.VQSBDUUAFGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static DOZYNPMRPFH IEUXREDGTGW;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate QPTPWYUHNAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate FISEYCBCUFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xCD4A70", Offset = "0xCD3470", VA = "0x180CD4A70")]
		public DOZYNPMRPFH(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class ETNCQEUIWVP : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : DFCGLAFPUYG.YKCEPJNVAWP<SYXPYTMUMKS, ETNCQEUIWVP>
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
				public AsyncTaskMethodBuilder<Result<object, RYUTMMKYXMA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public ETNCQEUIWVP root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public Id32<QEBRWUBFUFW> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public SYXPYTMUMKS action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				private TaskAwaiter<Result<object, RYUTMMKYXMA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B10BA0", Offset = "0x2B0F5A0", VA = "0x182B10BA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B10DE0", Offset = "0x2B0F7E0", VA = "0x182B10DE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "4")]
			public int CQNPPJSTBXJ(ETNCQEUIWVP a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EE70", Offset = "0x2B0D870", VA = "0x182B0EE70", Slot = "5")]
			public int PQYBQQBRHUJ(ETNCQEUIWVP a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EE90", Offset = "0x2B0D890", VA = "0x182B0EE90", Slot = "6")]
			public int SAJYTHLOYKK(ETNCQEUIWVP a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EE50", Offset = "0x2B0D850", VA = "0x182B0EE50", Slot = "7")]
			public int NPCGWFXLLNI(ETNCQEUIWVP a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0ECB0", Offset = "0x2B0D6B0", VA = "0x182B0ECB0", Slot = "8")]
			public void LLLWOQZUJWF(ETNCQEUIWVP a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "9")]
			public bool YRBFDIRBOEC(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> actorId, SYXPYTMUMKS[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "10")]
			public bool XCADZIAIFAI(ETNCQEUIWVP a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0ED00", Offset = "0x2B0D700", VA = "0x182B0ED00", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, RYUTMMKYXMA>> LWYLDUSLRGQ(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> senderId, SYXPYTMUMKS b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : DFCGLAFPUYG.ZFCLKDKZCRS<ActionDeps, BOPULBRGFUP.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps NUVFWHTIZFS
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public BOPULBRGFUP.StaticNetSysReceiverDeps MKTGHAQBKUD
			{
				[Cpp2IlInjected.Token(Token = "0x60007AD")]
				[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "5")]
				get
				{
					return default(BOPULBRGFUP.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps ZRRPLJGSDRE
			{
				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : GXWCFSPOAEI.ZFMZEQYTVOK<ETNCQEUIWVP>
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
				public AsyncTaskMethodBuilder<Result<object?, RYUTMMKYXMA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public ETNCQEUIWVP root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public Id32<QEBRWUBFUFW> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public SYXPYTMUMKS action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				private TaskAwaiter<Result<object?, RYUTMMKYXMA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B10880", Offset = "0x2B0F280", VA = "0x182B10880", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B10B30", Offset = "0x2B0F530", VA = "0x182B10B30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E920", Offset = "0x2B0D320", VA = "0x182B0E920", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, RYUTMMKYXMA>> LWYLDUSLRGQ(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> clientId, SYXPYTMUMKS b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : WZVSWFCXEUU.ZFMZEQYTVOK<ETNCQEUIWVP>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E330", Offset = "0x2B0CD30", VA = "0x182B0E330", Slot = "4")]
			public void UGJDDZFOSBQ(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xF58060", Offset = "0xF56A60", VA = "0x180F58060", Slot = "5")]
			public Id32<QEBRWUBFUFW>? ONXACOSDQPX(ETNCQEUIWVP a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E090", Offset = "0x2B0CA90", VA = "0x182B0E090")]
			public Id32<SLTVKIGDHLN> WXSFFCSMOWS(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<SLTVKIGDHLN>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E130", Offset = "0x2B0CB30", VA = "0x182B0E130", Slot = "7")]
			public void PZANMLEIQCJ(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DF00", Offset = "0x2B0C900", VA = "0x182B0DF00", Slot = "8")]
			public void BQZHTXSZRZZ(ETNCQEUIWVP a, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E0F0", Offset = "0x2B0CAF0", VA = "0x182B0E0F0", Slot = "9")]
			public void PEXCDCVVNRR(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E220", Offset = "0x2B0CC20", VA = "0x182B0E220", Slot = "10")]
			public void RNQFJWSXYDH(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, YOWRGPCINZI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E250", Offset = "0x2B0CC50", VA = "0x182B0E250", Slot = "11")]
			public void RTGHZGHWXLL(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> clientId, Id32<SLTVKIGDHLN> objectId, XRFLWTQTKUE? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E500", Offset = "0x2B0CF00", VA = "0x182B0E500", Slot = "12")]
			public Id32<QEBRWUBFUFW>? ZXBMCXLDMPQ(ETNCQEUIWVP a, Id32<SLTVKIGDHLN> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E1C0", Offset = "0x2B0CBC0", VA = "0x182B0E1C0", Slot = "13")]
			public Id32<YFBJPXYJORD> QMZLKHZKJJU(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> clientId, string b, object c, QHMMCWYGQBV d, HZOEHZSWUUR e)
			{
				return default(Id32<YFBJPXYJORD>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E360", Offset = "0x2B0CD60", VA = "0x182B0E360", Slot = "14")]
			public void XALELJNVKPM(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> clientId, Id32<YFBJPXYJORD> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E060", Offset = "0x2B0CA60", VA = "0x182B0E060", Slot = "15")]
			public void KZIKNIQBEGQ(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> clientId, Id32<YFBJPXYJORD> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E090", Offset = "0x2B0CA90", VA = "0x182B0E090", Slot = "6")]
			private Id32<SLTVKIGDHLN> NQVVJSKEAPY(ETNCQEUIWVP a, Id32<QEBRWUBFUFW> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<SLTVKIGDHLN>);
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
			public ETNCQEUIWVP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public Id32<SLTVKIGDHLN>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public KGAFOUMCVHY deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private Id32<QEBRWUBFUFW> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private FZBXDZLWBIS<ETNCQEUIWVP, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private ZGUBSLDPVXI<ETNCQEUIWVP, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private BOPULBRGFUP <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B101C0", Offset = "0x2B0EBC0", VA = "0x182B101C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B10810", Offset = "0x2B0F210", VA = "0x182B10810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly KLPRZZNRKZU<SYXPYTMUMKS, None, BOPULBRGFUP, ActionDeps, BOPULBRGFUP.StaticNetSysReceiverDeps, RootDeps, ETNCQEUIWVP, Deps> CKBAUMDBSRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly MMQDJHNVCQS VAXYUAPUKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAId32<QEBRWUBFUFW> CDPANKDWCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private SOAField<QEBRWUBFUFW, None> RXQTNWPVFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private SOAField<QEBRWUBFUFW, BOPULBRGFUP> XMPONSCXKSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Id32<QEBRWUBFUFW>? FANQIXMZKCE;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate CCZVAZLPUDE
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xCDB1B0", Offset = "0xCD9BB0", VA = "0x180CDB1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B090", Offset = "0x2B09A90", VA = "0x182B0B090")]
		public ETNCQEUIWVP(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A9D0", Offset = "0x2B093D0", VA = "0x182B0A9D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ABA0", Offset = "0x2B095A0", VA = "0x182B0ABA0")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> OMUFVTCAFLQ(KGAFOUMCVHY a, RegistryV2 b, Id32<SLTVKIGDHLN>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AE00", Offset = "0x2B09800", VA = "0x182B0AE00")]
		private void UGJDDZFOSBQ(Id32<QEBRWUBFUFW> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AD20", Offset = "0x2B09720", VA = "0x182B0AD20")]
		[CompilerGenerated]
		private Id32<SLTVKIGDHLN>? PZHGVKJQSCK([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class EGRNHXFSHTG : XXIODFUTTPG.VQSBDUUAFGN
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<FGSPNCNIVOV> DeserializeCircuitsJunctionAsyncDelegate(BOPULBRGFUP circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<FGSPNCNIVOV> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public EGRNHXFSHTG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public BOPULBRGFUP circuitsManager;

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
			private TaskAwaiter<FGSPNCNIVOV> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EEB0", Offset = "0x2B0D8B0", VA = "0x182B0EEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F0B0", Offset = "0x2B0DAB0", VA = "0x182B0F0B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate YGHFGVCGPVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly LifecycleDidInitializeDelegate? GBDKMJYCVEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly LifecycleWillDestroyDelegate? HLKLFZMQZRS;

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A610", Offset = "0x2B09010", VA = "0x182B0A610", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<FGSPNCNIVOV> VMEEJZOXPCQ(BOPULBRGFUP a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
		public void YWHEULEGJIM(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xFE66D0", Offset = "0xFE50D0", VA = "0x180FE66D0", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x1084950", Offset = "0x1083350", VA = "0x181084950", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A780", Offset = "0x2B09180", VA = "0x182B0A780")]
		public EGRNHXFSHTG([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class CPXYJXBCTEC : PROZKNCVPRU.VQSBDUUAFGN
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate KHYMSWFULYQ GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<VULSXCZUWAI> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<TQZWVQRKFBG> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<PROZKNCVPRU.VQSBDUUAFGN.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<PROZKNCVPRU.VQSBDUUAFGN.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public CPXYJXBCTEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter<PROZKNCVPRU.VQSBDUUAFGN.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F120", Offset = "0x2B0DB20", VA = "0x182B0F120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F310", Offset = "0x2B0DD10", VA = "0x182B0F310", Slot = "5")]
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
			public AsyncTaskMethodBuilder<TQZWVQRKFBG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CPXYJXBCTEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			private TaskAwaiter<TQZWVQRKFBG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F380", Offset = "0x2B0DD80", VA = "0x182B0F380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F570", Offset = "0x2B0DF70", VA = "0x182B0F570", Slot = "5")]
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
			public AsyncTaskMethodBuilder<VULSXCZUWAI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public CPXYJXBCTEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private TaskAwaiter<VULSXCZUWAI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F5E0", Offset = "0x2B0DFE0", VA = "0x182B0F5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F7D0", Offset = "0x2B0E1D0", VA = "0x182B0F7D0", Slot = "5")]
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
			public CPXYJXBCTEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F840", Offset = "0x2B0E240", VA = "0x182B0F840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FA30", Offset = "0x2B0E430", VA = "0x182B0FA30", Slot = "5")]
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
			public CPXYJXBCTEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FAA0", Offset = "0x2B0E4A0", VA = "0x182B0FAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FC90", Offset = "0x2B0E690", VA = "0x182B0FC90", Slot = "5")]
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
			public CPXYJXBCTEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FD00", Offset = "0x2B0E700", VA = "0x182B0FD00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FEF0", Offset = "0x2B0E8F0", VA = "0x182B0FEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetCV2DependenciesDelegate LBPMYBMSVGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomDataAsyncDelegate ORTTMBAKRDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetSuperRoomDataAsyncDelegate GCYEBGMLTLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetRoomAssetDataAsyncDelegate DURLAQFLWLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetPlayerSaveDataAsyncDelegate NLZOYNGXECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate OQTODFIKNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly GetStaticCircuitsConfigAsyncDelegate XSQETVTNDCK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public KHYMSWFULYQ KHYMSWFULYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x129FCC0", Offset = "0x129E6C0", VA = "0x18129FCC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B091F0", Offset = "0x2B07BF0", VA = "0x182B091F0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> DFFQZFSLJUZ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B09740", Offset = "0x2B08140", VA = "0x182B09740", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> WEHLGTZWMPC(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B09300", Offset = "0x2B07D00", VA = "0x182B09300", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<VULSXCZUWAI> HTVHSFGJYDJ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B09630", Offset = "0x2B08030", VA = "0x182B09630", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<TQZWVQRKFBG> UJMGNKVTNRO(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B09410", Offset = "0x2B07E10", VA = "0x182B09410", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<PROZKNCVPRU.VQSBDUUAFGN.CircuitGraphToolMapping> MAFNRDYEVVT(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B09520", Offset = "0x2B07F20", VA = "0x182B09520", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> QNBZKIBSEBC(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B09850", Offset = "0x2B08250", VA = "0x182B09850")]
		public CPXYJXBCTEC(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class VLLAYJUJKKK : CV2Request.VQSBDUUAFGN
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly CV2Request.VQSBDUUAFGN IWMDTGRRYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly GetCanSendRequestsDelegate MIKCQHYOBXI;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public VLLAYJUJKKK(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x129FCC0", Offset = "0x129E6C0", VA = "0x18129FCC0", Slot = "4")]
		public bool ABPUONJZBJQ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class YFVJPHAVEUN : AMOMUAWSSEI
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, LLLHSATKLGS> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly TryReportErrToUserDelegate WSTMAFHVMFI;

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE10", Offset = "0x2B0A810", VA = "0x182B0BE10")]
		public bool ISWGAOBHCKU([In] Result<None, LLLHSATKLGS> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2B11F70", Offset = "0x2B10970", VA = "0x182B11F70")]
		public YFVJPHAVEUN([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE10", Offset = "0x2B0A810", VA = "0x182B0BE10", Slot = "4")]
		private bool IYLANFXPVLF([In] Result<None, LLLHSATKLGS> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class BELRSZBPNGM : QVZSNJGYCUV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate MNPVGDUGIJR CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly BELRSZBPNGM IWMDTGRRYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CurrentExecParamsDelegate? URJITYFMMJE;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public MNPVGDUGIJR AIQHKLKPKIO
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x129FCC0", Offset = "0x129E6C0", VA = "0x18129FCC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public BELRSZBPNGM([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class KHQZTKKVNYW : AASPWJWOJHD
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly AASPWJWOJHD IWMDTGRRYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly GetGameColorFromIdDelegate DIKFTLQYMWS;

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE10", Offset = "0x2B0A810", VA = "0x182B0BE10", Slot = "4")]
		public CircuitsColor DJGEYBPXOAA(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C030", Offset = "0x2B0AA30", VA = "0x182B0C030")]
		public KHQZTKKVNYW([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class IALXCTJZIZY : RPWMSZPCVKF
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
			public IALXCTJZIZY <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x2B0FF60", Offset = "0x2B0E960", VA = "0x182B0FF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x2B10150", Offset = "0x2B0EB50", VA = "0x182B10150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly IsStringPureAsyncDelegate ZOOEQPYVBFT;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B800", Offset = "0x2B0A200", VA = "0x182B0B800", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> AWKPDXQRZJH(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B940", Offset = "0x2B0A340", VA = "0x182B0B940")]
		public IALXCTJZIZY([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class PWNHKJMHVFC : SVFGTXNXCXN
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate ECHTNHAYNGD? GetNodeVisualizationConfigDelegate([In] Id128<DAVIPBXXNLR> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly SVFGTXNXCXN IWMDTGRRYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly GetNodeVisualizationConfigDelegate VMOGNFVRZLG;

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE10", Offset = "0x2B0A810", VA = "0x182B0BE10")]
		public ECHTNHAYNGD? PWXNKSFVCCS([In] Id128<DAVIPBXXNLR> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EAF0", Offset = "0x2B0D4F0", VA = "0x182B0EAF0")]
		public PWNHKJMHVFC([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE10", Offset = "0x2B0A810", VA = "0x182B0BE10", Slot = "4")]
		private ECHTNHAYNGD SZYBJRQVNQW([In] Id128<DAVIPBXXNLR> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class FWZQISMHIAX : LOSCWUQEIKS
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B3F0", Offset = "0x2B09DF0", VA = "0x182B0B3F0", Slot = "4")]
		public EKVEUNWMJGL XZPVMMUOCZR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public FWZQISMHIAX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class GYNFOALRFKN : MPAVXKEAITY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, bool> OSHJPNCXVPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, float> JIQGXVEYWQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, double> LMJBAAJJMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, int> RWZGFMOLDJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, long> AZJAMQPKVPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, string> SODYQIGHYKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly Dictionary<string, uint> FUVFPATYDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly Dictionary<string, ulong> JUZJQOQUOYP;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B440", Offset = "0x2B09E40", VA = "0x182B0B440", Slot = "4")]
		public bool? PRPQRLSNCWA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B4E0", Offset = "0x2B09EE0", VA = "0x182B0B4E0")]
		public GYNFOALRFKN()
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
