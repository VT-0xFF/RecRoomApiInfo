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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3AE30", Offset = "0x2B39830", VA = "0x182B3AE30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		internal sealed class KVFZSKIDEWS : CWAEHDAESDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KVFZSKIDEWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0", Slot = "4")]
			public CWAEHDAESDL HAZAGVLPQIR(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0", Slot = "5")]
			public CWAEHDAESDL TBENKKNWCNG(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0", Slot = "6")]
			public CWAEHDAESDL BYKIRXDBSQY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			public void FHFBFMADOYL()
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
	public static class WPHCDUDKCFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public WKJPEKOLCLW UNIFBAHHFNT;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B407F0", Offset = "0x2B3F1F0", VA = "0x182B407F0")]
			internal VQEUHQUVGGC QCLAJEWNBEM(GetNetworkObjectDelegate a)
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
			public KGZAGFPSONW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LWWLBIHZXST network;

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
			[Cpp2IlInjected.Address(RVA = "0x2B3E480", Offset = "0x2B3CE80", VA = "0x182B3E480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EB20", Offset = "0x2B3D520", VA = "0x182B3EB20", Slot = "5")]
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
			public LWWLBIHZXST network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public KGZAGFPSONW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<TBNPHTPCKFD>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private WVKEVWTACCJ <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EB90", Offset = "0x2B3D590", VA = "0x182B3EB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F120", Offset = "0x2B3DB20", VA = "0x182B3F120", Slot = "5")]
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
			public WKJPEKOLCLW roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F190", Offset = "0x2B3DB90", VA = "0x182B3F190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F6A0", Offset = "0x2B3E0A0", VA = "0x182B3F6A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B41050", Offset = "0x2B3FA50", VA = "0x182B41050")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? YEVMBKOPZQG([Optional] WKJPEKOLCLW? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B40BF0", Offset = "0x2B3F5F0", VA = "0x182B40BF0")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> AKXPHOBSYDV(LWWLBIHZXST a, [Optional] KGZAGFPSONW? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B40D70", Offset = "0x2B3F770", VA = "0x182B40D70")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> AKXPHOBSYDV(LWWLBIHZXST a, KGZAGFPSONW b, RegistryV2 c, Id32<TBNPHTPCKFD>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B40F00", Offset = "0x2B3F900", VA = "0x182B40F00")]
		public static (RuntimeFnRegistry, RuntimeFns) FKAHSQQHKLZ()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B40AF0", Offset = "0x2B3F4F0", VA = "0x182B40AF0")]
		public static (ExternalFnRegistry, ExternalFns) ACPZHEPGORG()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B40FD0", Offset = "0x2B3F9D0", VA = "0x182B40FD0")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static LWWLBIHZXST IRYPXEYQWSB(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class SEHOFKGZDRR
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate VQEUHQUVGGC CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public SEHOFKGZDRR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E090", Offset = "0x2B3CA90", VA = "0x182B3E090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E410", Offset = "0x2B3CE10", VA = "0x182B3E410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly LWWLBIHZXST UTJPRZYZHVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? QHGSETARVBT;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		private SEHOFKGZDRR(LWWLBIHZXST a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D940", Offset = "0x2B3C340", VA = "0x182B3D940")]
		public static SEHOFKGZDRR JPMHDBJTTOT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D9F0", Offset = "0x2B3C3F0", VA = "0x182B3D9F0")]
		public SEHOFKGZDRR SVHUZYHSBZM(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D850", Offset = "0x2B3C250", VA = "0x182B3D850")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> FHFBFMADOYL()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class QFJKYRUMWXP : WVKEVWTACCJ.EDIRCJTODTF
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate ZXAQAILBSDB NewCircuitsLifecycleDelegate(XMAUPUIQGZI.EDIRCJTODTF deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(WVKEVWTACCJ circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(WVKEVWTACCJ circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate DHMBVXEWLRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate UZPEXFQINDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate SZVXXMAUOOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate CQAZIHKYYNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate RLVVFPPXYDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate XUVNVAHSZWQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int PHNYNSBVTEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x12DAB80", Offset = "0x12D9580", VA = "0x1812DAB80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B010", Offset = "0x2B39A10", VA = "0x182B3B010", Slot = "6")]
		public void WBXDMQCSMTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AFE0", Offset = "0x2B399E0", VA = "0x182B3AFE0", Slot = "7")]
		public void FUUXJSJVIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B040", Offset = "0x2B39A40", VA = "0x182B3B040", Slot = "5")]
		public ZXAQAILBSDB YVCCCRSVEYM(XMAUPUIQGZI.EDIRCJTODTF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF36730", Offset = "0xF35130", VA = "0x180F36730", Slot = "8")]
		public void PUQWPIKFXQV(WVKEVWTACCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF36790", Offset = "0xF35190", VA = "0x180F36790", Slot = "9")]
		public void TWRSIEQBTJQ(WVKEVWTACCJ a, PZJVNVFLVDC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B070", Offset = "0x2B39A70", VA = "0x182B3B070")]
		public QFJKYRUMWXP([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly NSSIEQQRQOQ<LWWLBIHZXST, LWWLBIHZXST.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly CBYJFRFNFDK<LWWLBIHZXST, LWWLBIHZXST.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly WVKEVWTACCJ CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<HGRDVVOSLAK> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly LWWLBIHZXST Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B34B10", Offset = "0x2B33510", VA = "0x182B34B10")]
		public EVCreationResult(NSSIEQQRQOQ<LWWLBIHZXST, LWWLBIHZXST.MockStaticNetSysDeps> staticNetSys, CBYJFRFNFDK<LWWLBIHZXST, LWWLBIHZXST.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, WVKEVWTACCJ circuitsManager, Id32<HGRDVVOSLAK> clientId, LWWLBIHZXST network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly WVKEVWTACCJ _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 ZAYFCRCMTTT
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B36730", Offset = "0x2B35130", VA = "0x182B36730")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request LUTHBMROVWT
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B36700", Offset = "0x2B35100", VA = "0x182B36700")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public HVIEREJNYRS? VYRACMXOXPR
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2B36600", Offset = "0x2B35000", VA = "0x182B36600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public BSRXIMSMGHS? AMJPMKEJKQH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2B36760", Offset = "0x2B35160", VA = "0x182B36760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		internal LimitedCircuits(WVKEVWTACCJ circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class FYRNCYSLTYB : KGZAGFPSONW
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KTORQALGSRR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public VQEUHQUVGGC OKDWZMPSSEO;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KTORQALGSRR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			internal VQEUHQUVGGC LTEICPUCESU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public XMAUPUIQGZI.EDIRCJTODTF QQSGIYSOZPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public WVKEVWTACCJ.EDIRCJTODTF CKHCKHISSXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public SSKFXZAJUJK.EDIRCJTODTF WPPKKHSNBIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ> QGRMNVKMAQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.EDIRCJTODTF MQTYZCVAYDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FAUMPQIMSBQ KMJQRCLCRZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ZIVHGNLPODZ CEPSAYZQRJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DNRVFIQUYRJ WGWXVQLTCSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GPWQFBHBUSL ZZIBOIJSCGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public KXKYWNBNZAB KGXWIDEYNYA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xD14480", Offset = "0xD12E80", VA = "0x180D14480", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B353B0", Offset = "0x2B33DB0", VA = "0x182B353B0")]
		private FYRNCYSLTYB(XMAUPUIQGZI.EDIRCJTODTF a, WVKEVWTACCJ.EDIRCJTODTF b, SSKFXZAJUJK.EDIRCJTODTF c, TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ> d, CV2Request.EDIRCJTODTF e, FAUMPQIMSBQ f, ZIVHGNLPODZ g, DNRVFIQUYRJ h, GPWQFBHBUSL i, KXKYWNBNZAB j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B35050", Offset = "0x2B33A50", VA = "0x182B35050")]
		public static FYRNCYSLTYB? YQWWFOHGAJE(SSKFXZAJUJK.EDIRCJTODTF cv2RootSysDeps, [Optional] XMAUPUIQGZI.EDIRCJTODTF? a, [Optional] WVKEVWTACCJ.EDIRCJTODTF? b, [Optional] TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>? reducerDeps, [Optional] CV2Request.EDIRCJTODTF? c, [Optional] FAUMPQIMSBQ? d, [Optional] ZIVHGNLPODZ? e, [Optional] DNRVFIQUYRJ? f, [Optional] GPWQFBHBUSL? g, [Optional] KXKYWNBNZAB? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B34B80", Offset = "0x2B33580", VA = "0x182B34B80")]
		public static FYRNCYSLTYB BMENFSVELCK(VQEUHQUVGGC a, [Optional] XMAUPUIQGZI.EDIRCJTODTF? circuitsLifecycleDeps, [Optional] WVKEVWTACCJ.EDIRCJTODTF? circuitsManagerDeps, [Optional] TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B34CD0", Offset = "0x2B336D0", VA = "0x182B34CD0")]
		public static FYRNCYSLTYB TVAMLKBHYPG(GetNetworkObjectDelegate a, [Optional] XMAUPUIQGZI.EDIRCJTODTF? circuitsLifecycleDeps, [Optional] WVKEVWTACCJ.EDIRCJTODTF? circuitsManagerDeps, [Optional] TFOUCAQYAHM.SWYTVHETLJM<ActionKind, PZJVNVFLVDC, WVKEVWTACCJ>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class NCSKGATVRBW
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class BGYUSPZXLWP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public GetNetworkObjectDelegate URDVLZYTRCY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int OJSYWTWHXRA;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BGYUSPZXLWP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B33680", Offset = "0x2B32080", VA = "0x182B33680")]
			internal YEDZHZZAPGR TZGTYVTOLAD(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2B336F0", Offset = "0x2B320F0", VA = "0x182B336F0")]
			internal YEDZHZZAPGR[] UAHCLDPBGEW(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
			internal int FBMUMZOVNEC()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BGTNVJGACLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public DynamicEnvironmentNetworkId VPPSBASYEDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public BGYUSPZXLWP UZNLTVLUBPB;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BGTNVJGACLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B335D0", Offset = "0x2B31FD0", VA = "0x182B335D0")]
			internal YEDZHZZAPGR ZBNTXEXDGBJ(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly MHFTIKCGLDX TCAHIIUIHZM;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AD90", Offset = "0x2B39790", VA = "0x182B3AD90")]
		public static YEDZHZZAPGR? UCAJOKDDKLQ(Id32<TBNPHTPCKFD>? networkObject, [Optional] GYQGZRGDWXS.SerializesIntoSavesDelegate? a, [Optional] GYQGZRGDWXS.SerializesIntoInventionsDelegate? b, [Optional] GYQGZRGDWXS.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B367C0", Offset = "0x2B351C0", VA = "0x182B367C0")]
		public static VQEUHQUVGGC? PMAHTJXUXIH(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] LGEKONOLGQZ? b, [Optional] CTROCSSJSFL? c, [Optional] KQNVXECCNWB? d, [Optional] WKJPEKOLCLW? e, int f = 300000, bool g = false, bool h = false, [Optional] VTQXGJFVGXL? i, [Optional] FLLSEBDXVIB? j, [Optional] ACDFLBHNDNA? k, [Optional] XXPTNFBFHHT? l, [Optional] NLOEUEBUSHA? m, [Optional] JVBBBSIYWPD? n, [Optional] OUQHWESAABZ.EDIRCJTODTF? o, [Optional] EqualsNodeV2.EDIRCJTODTF? p, [Optional] OSKOVGZFRAZ? q, [Optional] VQEUHQUVGGC.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] VQEUHQUVGGC.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] VQEUHQUVGGC.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] VQEUHQUVGGC.GetLocalRoomIdDelegate? u, [Optional] VQEUHQUVGGC.GetLocalSubroomIdDelegate? v, [Optional] VQEUHQUVGGC.GetSubroomIdsForLocalRoomDelegate? w, [Optional] VQEUHQUVGGC.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] VQEUHQUVGGC.SaveRoomOnPlayerBehalfDelegate? z, [Optional] VQEUHQUVGGC.ReportCloudDataLedgerChangedDelegate? ba, [Optional] VQEUHQUVGGC.GetColorNameByIdDelegate? bb, [Optional] VQEUHQUVGGC.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] VQEUHQUVGGC.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] VQEUHQUVGGC.GetTaggableNameFromSignalDelegate? be, [Optional] VQEUHQUVGGC.GetAudioNameFromSignalDelegate? bf, [Optional] VQEUHQUVGGC.GetDestinationNameFromSignalDelegate? bg, [Optional] VQEUHQUVGGC.GetPlayerEventNameFromSignalDelegate? bh, [Optional] VQEUHQUVGGC.GetRoomKeyNameFromSignalDelegate? bi, [Optional] VQEUHQUVGGC.GetRewardNameFromSignalDelegate? bj, [Optional] VQEUHQUVGGC.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] VQEUHQUVGGC.ReportPreloadedAudioChangedDelegate? bl, [Optional] VQEUHQUVGGC.ReportRewardDataChangedDelegate? bm, [Optional] VQEUHQUVGGC.GetConsumableNameFromSignalDelegate? bn, [Optional] VQEUHQUVGGC.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] VQEUHQUVGGC.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] VQEUHQUVGGC.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] VQEUHQUVGGC.GetInventoryItemNameFromSignalDelegate? br, [Optional] VQEUHQUVGGC.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] VQEUHQUVGGC.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] VQEUHQUVGGC.GetRoomOfferNameFromSignalDelegate? bu, [Optional] VQEUHQUVGGC.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] VQEUHQUVGGC.GetObjectIdFromCreationObjectDelegate? bw, [Optional] VQEUHQUVGGC.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] VQEUHQUVGGC.GetCostInBytesDelegate? by, [Optional] VQEUHQUVGGC.GetAvatarItemNameFromSignalDelegate? bz, [Optional] VQEUHQUVGGC.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] VQEUHQUVGGC.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] VQEUHQUVGGC.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] VQEUHQUVGGC.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] VQEUHQUVGGC.GetStoreItemNameFromSignalDelegate? ce, [Optional] VQEUHQUVGGC.GetBodyPartNameFromSignalDelegate? cf, [Optional] VQEUHQUVGGC.GetDependenciesForGraphInstanceDelegate? cg, [Optional] VQEUHQUVGGC.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] VQEUHQUVGGC.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] VQEUHQUVGGC.GetRecNetImageNameFromSignalDelegate? cj, [Optional] VQEUHQUVGGC.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] VQEUHQUVGGC.IsFunctionValidForAIDelegate? cm, [Optional] VQEUHQUVGGC.GetAIFunctionNameFromSignalDelegate? cn, [Optional] VQEUHQUVGGC.FromSerializableObjectDelegate? co, [Optional] VQEUHQUVGGC.ToSerializableObjectDelegate? cp)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<TBNPHTPCKFD>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class GKQFGUQPMRV : ACDFLBHNDNA
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly GKQFGUQPMRV UIOXUQVVXGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly GetLocalPlayerDelegate? NFETGDRUNSS;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2B354D0", Offset = "0x2B33ED0", VA = "0x182B354D0", Slot = "4")]
		public (MRNHRDHQHVF, MRNHRDHQHVF, MRNHRDHQHVF, MRNHRDHQHVF, MRNHRDHQHVF) HQBIXDFIFER(object a)
		{
			return default((MRNHRDHQHVF, MRNHRDHQHVF, MRNHRDHQHVF, MRNHRDHQHVF, MRNHRDHQHVF));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B354A0", Offset = "0x2B33EA0", VA = "0x182B354A0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "6")]
		public bool FGCJYTKVFEA(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD76D10", Offset = "0xD75710", VA = "0x180D76D10", Slot = "7")]
		public string SFXAXROLCZM(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public GKQFGUQPMRV([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class GYQGZRGDWXS : YEDZHZZAPGR
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(GYQGZRGDWXS self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(GYQGZRGDWXS self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(GYQGZRGDWXS self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly SerializesIntoSavesDelegate QBUKUQTVAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly SerializesIntoInventionsDelegate VXYCNDAHVLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly CanPublishInInventionsDelegate CBVFOFJWQEJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private SKWYISTCPPF? QGBPCLEFCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId UKFUQRERBXM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xFFD2C0", Offset = "0xFFBCC0", VA = "0x180FFD2C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool XHYLAURBOJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B35CE0", Offset = "0x2B346E0", VA = "0x182B35CE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool FRGIZBIPDKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B35CB0", Offset = "0x2B346B0", VA = "0x182B35CB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool YQTTOZVEJTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B35C80", Offset = "0x2B34680", VA = "0x182B35C80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BPTJIQFGDYC? VPQSYZJCMGR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<TBNPHTPCKFD>? HLTFCAZXKJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B35B30", Offset = "0x2B34530", VA = "0x182B35B30", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B355C0", Offset = "0x2B33FC0", VA = "0x182B355C0", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(MHFTIKCGLDX e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0", Slot = "13")]
		public void Bind(SKWYISTCPPF controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B35BD0", Offset = "0x2B345D0", VA = "0x182B35BD0")]
		private GYQGZRGDWXS(Id32<TBNPHTPCKFD>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B35660", Offset = "0x2B34060", VA = "0x182B35660")]
		public static GYQGZRGDWXS? New(Id32<TBNPHTPCKFD>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class BGKKGWSQLQA : VTQXGJFVGXL
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
		public static readonly BGKKGWSQLQA UIOXUQVVXGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly RoundToDecimalPlaceDelegate? LNVDUEYCAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly TruncateToDecimalPlaceDelegate? MHINCIHMQOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsColorLerpDelegate? NZDLCSRAQWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsColorInverseLerpDelegate? UVGHZAVVLBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4GetPositionDelegate? DWXBYRTJHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4GetRotationDelegate? XSXJPFOSIQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsMtx4x4InverseDelegate? UZTKEGMPTCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsMtx4x4MultiplyDelegate? CWRAXOVTHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? UFLFXBMFBQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatDotDelegate? HJMAJOURYJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromAngleAxisDelegate? GXSFXTSEHMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? KCSINKXHXAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatFromFromToRotationDelegate? TPZHZCDHCGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatFromLookRotationDelegate? XJGGSCLIOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? NJNPLSZPUCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseDelegate? ORNSBIWAWLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatLerpDelegate? WXQMHMTENKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatLerpUnclampedDelegate? SEXSSOURKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatInverseLerpDelegate? WKCVCTEOWZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatMultiplyDelegate? HBBNDOIZBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatNormalizeDelegate? IWQGMOQHRDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatRotateTowardsDelegate? VGDXVSVUUEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatRotateVectorDelegate? GWCHWTZLGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatSlerpDelegate? IGVWWMFCQWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsQuatToAngleAxisDelegate? VVYYFPMTKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsQuatToEulerAnglesDelegate? PGWDRUOXWPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3AddDelegate? ECVQRSZQQEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? XITQCZAHATR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? EQJYZZIQFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3CrossDelegate? PJVZDNYIGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3DotDelegate? DENNGEATGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3AngleDelegate? GXQWABDUSMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3GetMagnitudeDelegate? PLMEJQYGXOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3LerpDelegate? AONHMUIJIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3LerpUnclampedDelegate? UXEZJHIYWYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3InverseLerpDelegate? JSGTPYEZEMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3MoveTowardsDelegate? QYFYDFRJXLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3NegateDelegate? IPBIQNGAMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3NormalizeDelegate? AGWMMUZXTHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ProjectDelegate? RIWGVNULQTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? OKIGVFSJBCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3ScaleDelegate? IPZUGLFAGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SmoothDampDelegate? MCQCCMQAQJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3SubtractDelegate? HJXSUVWZTGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3SlerpDelegate? JQQECBFWNMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly CircuitsVec3TransformDelegate? WJXPALGPMHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CircuitsVec3InverseTransformDelegate? MDLOHLNCIIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly RealtimeSinceStartupDelegate? FHDGGAOQULL;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B330F0", Offset = "0x2B31AF0", VA = "0x182B330F0")]
		public BGKKGWSQLQA([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B31850", Offset = "0x2B30250", VA = "0x182B31850")]
		public float FOUJMPDKENL([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B31060", Offset = "0x2B2FA60", VA = "0x182B31060")]
		public float APDLJEQLJHN([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B32D70", Offset = "0x2B31770", VA = "0x182B32D70")]
		public CircuitsColor YEXGOCJOBII([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B31700", Offset = "0x2B30100", VA = "0x182B31700")]
		public float ENZZMUECAQG([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B329E0", Offset = "0x2B313E0", VA = "0x182B329E0")]
		public CircuitsVec3 UYWOUXMIJCW([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B311B0", Offset = "0x2B2FBB0", VA = "0x182B311B0")]
		public CircuitsQuat ATNVUHHOXXJ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B32830", Offset = "0x2B31230", VA = "0x182B32830")]
		public CircuitsMtx4x4 TEPFVMHSXHX([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B32C30", Offset = "0x2B31630", VA = "0x182B32C30")]
		public CircuitsMtx4x4 WRUVIPSBWPZ([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B32D00", Offset = "0x2B31700", VA = "0x182B32D00")]
		public CircuitsMtx4x4 YEPRMKZLAKL([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B30FA0", Offset = "0x2B2F9A0", VA = "0x182B30FA0")]
		public float NRREXAGAPKQ([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B31570", Offset = "0x2B2FF70", VA = "0x182B31570")]
		public CircuitsQuat QYLHCGSGHAN(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B31AC0", Offset = "0x2B304C0", VA = "0x182B31AC0")]
		public CircuitsQuat SOEJCLPJMAO([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B32780", Offset = "0x2B31180", VA = "0x182B32780")]
		public CircuitsQuat SNYSWISIHUO([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B31200", Offset = "0x2B2FC00", VA = "0x182B31200")]
		public CircuitsQuat AZGFCKSVUCQ([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B31DA0", Offset = "0x2B307A0", VA = "0x182B31DA0")]
		public CircuitsQuat KTLKPFUJQSX([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B31390", Offset = "0x2B2FD90", VA = "0x182B31390")]
		public CircuitsQuat BSPETJGQIJO([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B32340", Offset = "0x2B30D40", VA = "0x182B32340")]
		public CircuitsQuat OFCNCTWLMBJ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B31030", Offset = "0x2B2FA30", VA = "0x182B31030")]
		public float WYONCWUVFMW([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B31730", Offset = "0x2B30130", VA = "0x182B31730")]
		public CircuitsQuat FJYEUOPCMSR([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B31110", Offset = "0x2B2FB10", VA = "0x182B31110")]
		public CircuitsQuat LZWAQVIVKAM([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B321F0", Offset = "0x2B30BF0", VA = "0x182B321F0")]
		public CircuitsQuat PNEQXCKJHBM([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B31EB0", Offset = "0x2B308B0", VA = "0x182B31EB0")]
		public CircuitsVec3 LOVAQVKTSYB([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B31870", Offset = "0x2B30270", VA = "0x182B31870")]
		public CircuitsQuat FXRRBOIZJJR([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B31C20", Offset = "0x2B30620", VA = "0x182B31C20")]
		public void QVBMAEDBEIC([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B32910", Offset = "0x2B31310", VA = "0x182B32910")]
		public CircuitsVec3 UGHBHOQIINX([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B328A0", Offset = "0x2B312A0", VA = "0x182B328A0")]
		public CircuitsVec3 TLJQDXRVJSE([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B31620", Offset = "0x2B30020", VA = "0x182B31620")]
		public CircuitsVec3 EJDUNOYHQCO([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B31690", Offset = "0x2B30090", VA = "0x182B31690")]
		public CircuitsVec3 EMJJYITPOZZ([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B31F20", Offset = "0x2B30920", VA = "0x182B31F20")]
		public CircuitsVec3 LZSIDCHVWJB([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B32690", Offset = "0x2B31090", VA = "0x182B32690")]
		public float RDFBAKIFZWY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B31F90", Offset = "0x2B30990", VA = "0x182B31F90")]
		public float MJPFTUMZLFC([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B310F0", Offset = "0x2B2FAF0", VA = "0x182B310F0")]
		public float APXLWDZZWJZ([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B32180", Offset = "0x2B30B80", VA = "0x182B32180")]
		public CircuitsVec3 NEMZZPOYCDS([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B31BB0", Offset = "0x2B305B0", VA = "0x182B31BB0")]
		public CircuitsVec3 IHQURLODGQL([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B32150", Offset = "0x2B30B50", VA = "0x182B32150")]
		public float YWYZOIXRULU([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B32460", Offset = "0x2B30E60", VA = "0x182B32460")]
		public CircuitsVec3 OYHWRIPQSEI([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B32A40", Offset = "0x2B31440", VA = "0x182B32A40")]
		public CircuitsVec3 VHNDFKIUAMD([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B31FB0", Offset = "0x2B309B0", VA = "0x182B31FB0")]
		public CircuitsVec3 MJSPDJYFNKM([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B32DD0", Offset = "0x2B317D0", VA = "0x182B32DD0")]
		public CircuitsVec3 ZFCEBKJMSCS([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B32080", Offset = "0x2B30A80", VA = "0x182B32080")]
		public CircuitsVec3 MPKBTATHQVF([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B30FC0", Offset = "0x2B2F9C0", VA = "0x182B30FC0")]
		public CircuitsVec3 ADVAXKRIAOV([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B312B0", Offset = "0x2B2FCB0", VA = "0x182B312B0")]
		public CircuitsVec3 BJBTJOOMJYB([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B32B00", Offset = "0x2B31500", VA = "0x182B32B00")]
		public CircuitsVec3 VSCLRTGVIFX([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B32710", Offset = "0x2B31110", VA = "0x182B32710")]
		public CircuitsVec3 SKTWAGODFVJ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B32970", Offset = "0x2B31370", VA = "0x182B32970")]
		public CircuitsVec3 UUUJHHXUZQH([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B317E0", Offset = "0x2B301E0", VA = "0x182B317E0")]
		public CircuitsVec3 FNXVAPMTCVT([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B31360", Offset = "0x2B2FD60", VA = "0x182B31360", Slot = "50")]
		public Task BKDIUJCLXDB(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "51")]
		public void JJBPLJUNYHZ([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B31B60", Offset = "0x2B30560", VA = "0x182B31B60", Slot = "52")]
		public HUOSGZFVSJI<HRDYSUFEMPY> GYZTYKJDFDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B31450", Offset = "0x2B2FE50", VA = "0x182B31450", Slot = "53")]
		public HUOSGZFVSJI<HRDYSUFEMPY> CAKGEWCRZOW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B32320", Offset = "0x2B30D20", VA = "0x182B32320", Slot = "54")]
		public float OEPRPTJTPAM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B31850", Offset = "0x2B30250", VA = "0x182B31850", Slot = "4")]
		private float RVJLNIMMRMH([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B31060", Offset = "0x2B2FA60", VA = "0x182B31060", Slot = "5")]
		private float UXURTDJJBNT([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B319A0", Offset = "0x2B303A0", VA = "0x182B319A0", Slot = "6")]
		private CircuitsColor GMKIVVWYNHE([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B31700", Offset = "0x2B30100", VA = "0x182B31700", Slot = "7")]
		private float ZAHUNWFVNUA([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B32CA0", Offset = "0x2B316A0", VA = "0x182B32CA0", Slot = "8")]
		private CircuitsVec3 XMXZKGFLNHG([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B32B70", Offset = "0x2B31570", VA = "0x182B32B70", Slot = "9")]
		private CircuitsQuat WHEXFGPPTGF([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B32AA0", Offset = "0x2B314A0", VA = "0x182B32AA0", Slot = "10")]
		private CircuitsMtx4x4 VJNVVIFXSZF([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B31510", Offset = "0x2B2FF10", VA = "0x182B31510", Slot = "11")]
		private CircuitsMtx4x4 DCRJTXORHSZ([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B326B0", Offset = "0x2B310B0", VA = "0x182B326B0", Slot = "12")]
		private CircuitsMtx4x4 RWRMFYLTSOR([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B30FA0", Offset = "0x2B2F9A0", VA = "0x182B30FA0", Slot = "13")]
		private float ABVCLWHDNTY([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B31570", Offset = "0x2B2FF70", VA = "0x182B31570", Slot = "14")]
		private CircuitsQuat DFTXGCRTKNN(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B31AC0", Offset = "0x2B304C0", VA = "0x182B31AC0", Slot = "15")]
		private CircuitsQuat GYYXLVALMCE([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2B32780", Offset = "0x2B31180", VA = "0x182B32780", Slot = "16")]
		private CircuitsQuat SVELHSCWVXW([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2B31200", Offset = "0x2B2FC00", VA = "0x182B31200", Slot = "17")]
		private CircuitsQuat ZQBELEPBJKO([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B31DA0", Offset = "0x2B307A0", VA = "0x182B31DA0", Slot = "18")]
		private CircuitsQuat UQYXOHYEDAV([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B31390", Offset = "0x2B2FD90", VA = "0x182B31390", Slot = "19")]
		private CircuitsQuat HCPFJVEZOPI([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B32340", Offset = "0x2B30D40", VA = "0x182B32340", Slot = "20")]
		private CircuitsQuat REOWVSAGQOZ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B31030", Offset = "0x2B2FA30", VA = "0x182B31030", Slot = "21")]
		private float ANPDQZJEVLS([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B31730", Offset = "0x2B30130", VA = "0x182B31730", Slot = "22")]
		private CircuitsQuat RDERYVCXYZV([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B31110", Offset = "0x2B2FB10", VA = "0x182B31110", Slot = "23")]
		private CircuitsQuat ARHILZRDSZI([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B321F0", Offset = "0x2B30BF0", VA = "0x182B321F0", Slot = "24")]
		private CircuitsQuat NPTHIQHDGFW([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B32BC0", Offset = "0x2B315C0", VA = "0x182B32BC0", Slot = "25")]
		private CircuitsVec3 WRDGFFMUPKD([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B31870", Offset = "0x2B30270", VA = "0x182B31870", Slot = "26")]
		private CircuitsQuat WQOTHNNYYSR([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B31C20", Offset = "0x2B30620", VA = "0x182B31C20", Slot = "27")]
		private void JKWTLUTVUVW([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B32400", Offset = "0x2B30E00", VA = "0x182B32400", Slot = "28")]
		private CircuitsVec3 OOGFFVKAUCP([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B31080", Offset = "0x2B2FA80", VA = "0x182B31080", Slot = "29")]
		private CircuitsVec3 APQOCZRQBOG([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B314A0", Offset = "0x2B2FEA0", VA = "0x182B314A0", Slot = "30")]
		private CircuitsVec3 CKBOZJDUKQE([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2B32620", Offset = "0x2B31020", VA = "0x182B32620", Slot = "31")]
		private CircuitsVec3 QLHHSCWCTJT([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2B31930", Offset = "0x2B30330", VA = "0x182B31930", Slot = "32")]
		private CircuitsVec3 GFKEZRTITOJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2B322B0", Offset = "0x2B30CB0", VA = "0x182B322B0", Slot = "33")]
		private CircuitsVec3 ODSSFHSOSJT([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B32010", Offset = "0x2B30A10", VA = "0x182B32010", Slot = "34")]
		private CircuitsVec3 MOJPUKICMET([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2B32690", Offset = "0x2B31090", VA = "0x182B32690", Slot = "35")]
		private float QUJSXXMQBDM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B31F90", Offset = "0x2B30990", VA = "0x182B31F90", Slot = "36")]
		private float MPPDTIBUCLM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B310F0", Offset = "0x2B2FAF0", VA = "0x182B310F0", Slot = "37")]
		private float WKMSCMQKFHD([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B32E40", Offset = "0x2B31840", VA = "0x182B32E40", Slot = "38")]
		private CircuitsVec3 ZJCKDYXGOIS([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B32540", Offset = "0x2B30F40", VA = "0x182B32540", Slot = "39")]
		private CircuitsVec3 QHFNGLSEPEF([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B32150", Offset = "0x2B30B50", VA = "0x182B32150", Slot = "40")]
		private float NAZOYFTKBMM([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B31D30", Offset = "0x2B30730", VA = "0x182B31D30", Slot = "41")]
		private CircuitsVec3 KGPLRXPJFOC([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B31CD0", Offset = "0x2B306D0", VA = "0x182B31CD0", Slot = "42")]
		private CircuitsVec3 JSNZTTUXIJH([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B320F0", Offset = "0x2B30AF0", VA = "0x182B320F0", Slot = "43")]
		private CircuitsVec3 NANFOIPGSRM([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B325B0", Offset = "0x2B30FB0", VA = "0x182B325B0", Slot = "44")]
		private CircuitsVec3 QLCZUMXPRQU([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B32EB0", Offset = "0x2B318B0", VA = "0x182B32EB0", Slot = "45")]
		private CircuitsVec3 ZPSRYRFABKR([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2B31E40", Offset = "0x2B30840", VA = "0x182B31E40", Slot = "46")]
		private CircuitsVec3 LNZERDPCIKX([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2B31A00", Offset = "0x2B30400", VA = "0x182B31A00", Slot = "47")]
		private CircuitsVec3 GWZUNYASGZN([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B31C60", Offset = "0x2B30660", VA = "0x182B31C60", Slot = "48")]
		private CircuitsVec3 JQFBXROGAPB([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B324D0", Offset = "0x2B30ED0", VA = "0x182B324D0", Slot = "49")]
		private CircuitsVec3 PMQLTZMTQGV([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class TZLTCRQTCKQ : GNRLTENARYB
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x137EFD0", Offset = "0x137D9D0", VA = "0x18137EFD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1138E90", Offset = "0x1137890", VA = "0x181138E90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DF60", Offset = "0x2B3C960", VA = "0x182B3DF60")]
		public TZLTCRQTCKQ(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class YRLJTLXUGPO : FLLSEBDXVIB
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(YRRNONXIVNU e, WTEDEOUTIOR invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly YRLJTLXUGPO UIOXUQVVXGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly GetCircuitsColorFromColorIndexDelegate? NYEIPGZWYVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? JIILXOEGNXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly InvisibleCollisionSetEnabledDelegate? SOTLTFSGMHC;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xE09060", Offset = "0xE07A60", VA = "0x180E09060")]
		public YRLJTLXUGPO([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2B41160", Offset = "0x2B3FB60", VA = "0x182B41160", Slot = "4")]
		public CircuitsColor PWPUUPFOQMM(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B41140", Offset = "0x2B3FB40", VA = "0x182B41140")]
		public int DCCWKKJQXHS([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2B41140", Offset = "0x2B3FB40", VA = "0x182B41140", Slot = "5")]
		private int CGMBQVQGKXH([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class TVMNYBPNLPB : VESEUBEIAKI
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class OLLZUHYLXYU
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid SPZMXPGJIFS
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xF35A80", Offset = "0xF34480", VA = "0x180F35A80")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long ZZKYOLWSDJT
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int MDXIABDKPBJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool MCFAFYRRNBA
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x1B26A20", Offset = "0x1B25420", VA = "0x181B26A20")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool PUOFXCHZYEO
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x1B26E90", Offset = "0x1B25890", VA = "0x181B26E90")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool NJWLBFUHKDZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B3AEB0", Offset = "0x2B398B0", VA = "0x182B3AEB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3AED0", Offset = "0x2B398D0", VA = "0x182B3AED0")]
			public OLLZUHYLXYU(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<Id128<CEDSPQRYDBL>, OLLZUHYLXYU> VXSVVKTGEPX;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DB30", Offset = "0x2B3C530", VA = "0x182B3DB30")]
		public bool CYGWDAOUGVO([In] Id128<CEDSPQRYDBL> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DE10", Offset = "0x2B3C810", VA = "0x182B3DE10")]
		public void VJZSMXPJCIE([In] Id128<CEDSPQRYDBL> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DD30", Offset = "0x2B3C730", VA = "0x182B3DD30")]
		public void VJZSMXPJCIE([In] Id128<CEDSPQRYDBL> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DA10", Offset = "0x2B3C410", VA = "0x182B3DA10")]
		public void BTYCWRERCRL([In] Id128<CEDSPQRYDBL> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DC40", Offset = "0x2B3C640", VA = "0x182B3DC40")]
		public void JZFQWKIIBES([In] Id128<CEDSPQRYDBL> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DCA0", Offset = "0x2B3C6A0", VA = "0x182B3DCA0")]
		public bool MCFAFYRRNBA([In] Id128<CEDSPQRYDBL> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DEE0", Offset = "0x2B3C8E0", VA = "0x182B3DEE0")]
		public TVMNYBPNLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DB30", Offset = "0x2B3C530", VA = "0x182B3DB30", Slot = "4")]
		private bool NVKZJVOCHLH([In] Id128<CEDSPQRYDBL> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DE10", Offset = "0x2B3C810", VA = "0x182B3DE10", Slot = "5")]
		private void XHAHPHOOIPH([In] Id128<CEDSPQRYDBL> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DA10", Offset = "0x2B3C410", VA = "0x182B3DA10", Slot = "6")]
		private void QKQHBDVGZHC([In] Id128<CEDSPQRYDBL> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DC40", Offset = "0x2B3C640", VA = "0x182B3DC40", Slot = "7")]
		private void FUDWANEQOOX([In] Id128<CEDSPQRYDBL> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DCA0", Offset = "0x2B3C6A0", VA = "0x182B3DCA0", Slot = "8")]
		private bool GBHZVLWPGKF([In] Id128<CEDSPQRYDBL> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class DYSHPBAVEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B346B0", Offset = "0x2B330B0", VA = "0x182B346B0")]
		public static LogDeps PYVNRVZLDXZ()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class TRKZJJYJJXT : MeshLibrary.EDIRCJTODTF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
		public byte[]? VKGBNHBKBKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
		public void IDHSGSVLWDH(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public TRKZJJYJJXT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class QIQRUSJGNQS : LGEKONOLGQZ
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
		public delegate void ConfigureAttachedObjectDelegate(SRIHQTGPZUH controlPanel, JBOFPJQGWHN staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<JNMNERPAZHW> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, LSNRXVKTUTI>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, LSNRXVKTUTI>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, LSNRXVKTUTI>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, LSNRXVKTUTI>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public Task<Result<MultiResult, LSNRXVKTUTI>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private TaskAwaiter<Result<MultiResult, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F710", Offset = "0x2B3E110", VA = "0x182B3F710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2B3F9D0", Offset = "0x2B3E3D0", VA = "0x182B3F9D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2B3FA40", Offset = "0x2B3E440", VA = "0x182B3FA40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2B3FD00", Offset = "0x2B3E700", VA = "0x182B3FD00", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Task<Result<None, LSNRXVKTUTI>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private TaskAwaiter<Result<None, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3FD70", Offset = "0x2B3E770", VA = "0x182B3FD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2B40030", Offset = "0x2B3EA30", VA = "0x182B40030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Dictionary<string, EnumChoiceData> PJYUDDAMHSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Dictionary<int, string> RQGMLROVVVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly List<object> RQXBKIMLTXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly List<Guid> WQLVCYGBFRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly CanLocalPlayerCreateCurrencyDelegate VHXWYMBUTUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ShowRoomCurrencyCreationUIDelegate PXOWLIZYMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipOptionsDelegate RHFFSHIELXJ;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<Guid, int> DXOFKMQDBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipGuidToIndexMapDelegate VTYCJXKKAHL;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<int, Guid> KLZWDGMNFNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAudioClipIndexToGuidMapDelegate DGUPKVKTOIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipOptionsDelegate WRVYBGTBCXY;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<Guid, int> GSKDUATLTID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate TEOCOGQVSPI;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly IReadOnlyDictionary<int, Guid> DUNVIDWUQTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate HJUQZVSPHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly PlayAudioPreviewDelegate JXECDSDGFBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly StopAudioPreviewDelegate NRXQRWEKUOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly SubscriptionIsActiveDelegate UZTYWLKFZWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate PXKHHZLBWQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Dictionary<string, EnumChoiceData> JZDYYYPQKRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly ShowQuickChatEditMenuDelegate NWEVTIVMTJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly ConfigureAttachedObjectDelegate QMZBFHDPSSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly DisplayInvalidNameErrorMessageDelegate RGHAEPVFEOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly IsStringPureDelegate WVOHBXHANII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly TryGetSpecificChipConfigSummaryDelegate VGFVMHMUKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReleaseIconIdDelegate PPAUUDVHPOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate FAXBSHYEAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 LDNVNNFLYDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 LDTCKTZJHOZ;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment QAXGKARWBKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DTJGQITWFTU
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> YISPOJBBZUN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> PZVRADJNNCM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> BRIEBAPDMHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> WDKZTBISRAF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD1DCA0", Offset = "0xD1C6A0", VA = "0x180D1DCA0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion FHUTUFKNVMD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1018F90", Offset = "0x1017990", VA = "0x181018F90", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool GXMCPXEGNEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xEFE100", Offset = "0xEFCB00", VA = "0x180EFE100", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool JMLILYQXOIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BED0", Offset = "0x2B3A8D0", VA = "0x182B3BED0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool CFGJTFILECX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BAB0", Offset = "0x2B3A4B0", VA = "0x182B3BAB0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ESEDYDHPJDR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xD15390", Offset = "0xD13D90", VA = "0x180D15390", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C3F0", Offset = "0x2B3ADF0", VA = "0x182B3C3F0")]
		public QIQRUSJGNQS([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BF10", Offset = "0x2B3A910", VA = "0x182B3BF10", Slot = "9")]
		public bool VOMYAMESCXN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		public static bool RABMJACPDXQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C000", Offset = "0x2B3AA00", VA = "0x182B3C000", Slot = "10")]
		public bool XKWWFBCWXJD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void CATQPPEVHKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xF25E10", Offset = "0xF24810", VA = "0x180F25E10", Slot = "11")]
		public void WSEJQHTZQFW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C240", Offset = "0x2B3AC40", VA = "0x182B3C240")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZXZNTZAFUNH(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BFD0", Offset = "0x2B3A9D0", VA = "0x182B3BFD0", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XHLPQWGCIUE(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B9D0", Offset = "0x2B3A3D0", VA = "0x182B3B9D0")]
		private static IReadOnlyDictionary<Guid, int> BSRCMRMIUDD(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BA50", Offset = "0x2B3A450", VA = "0x182B3BA50", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> DYXAQYAUKBK(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C1F0", Offset = "0x2B3ABF0", VA = "0x182B3C1F0")]
		private static IReadOnlyDictionary<int, Guid> ZAGJWFMPXZX(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BA20", Offset = "0x2B3A420", VA = "0x182B3BA20", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> BUWWCXVTWHC(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C030", Offset = "0x2B3AA30", VA = "0x182B3C030")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XTTTRLBHTDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B29580", Offset = "0x2B27F80", VA = "0x182B29580", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> HJIFAUOYWTZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BB20", Offset = "0x2B3A520", VA = "0x182B3BB20")]
		private static IReadOnlyDictionary<Guid, int> JFQWFATHEEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B9A0", Offset = "0x2B3A3A0", VA = "0x182B3B9A0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> BBGNBQALCGZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BAF0", Offset = "0x2B3A4F0", VA = "0x182B3BAF0", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> IQNGZEAXFKZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void JQGXCJPCPWD(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BC10", Offset = "0x2B3A610", VA = "0x182B3BC10", Slot = "18")]
		public void LFGDLROMSPI(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void BDOASGIQMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BA80", Offset = "0x2B3A480", VA = "0x182B3BA80", Slot = "19")]
		public void EEFYPPEITQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		private static bool XAVFBNLQYZA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BEE0", Offset = "0x2B3A8E0", VA = "0x182B3BEE0", Slot = "20")]
		public bool UAWBHZKBZOR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		public static bool PSSYJPUJAHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C0D0", Offset = "0x2B3AAD0", VA = "0x182B3C0D0", Slot = "21")]
		public bool YOLUCSNFJJO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BEA0", Offset = "0x2B3A8A0", VA = "0x182B3BEA0", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> QKZLXAHNKVX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> ZJGRUQKDXMT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> BFBAZEGRIKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C0A0", Offset = "0x2B3AAA0", VA = "0x182B3C0A0", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> YMMUKRXAGZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> HUCQCEPIOHY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> ZRHJLCMRIQC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void WRAJCNLYYFS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C060", Offset = "0x2B3AA60", VA = "0x182B3C060", Slot = "29")]
		public void YJLMTUBSQJJ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void QUFXPJNDZLE(SRIHQTGPZUH a, JBOFPJQGWHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BC80", Offset = "0x2B3A680", VA = "0x182B3BC80", Slot = "35")]
		public void NMSAQMQTZHD(SRIHQTGPZUH a, JBOFPJQGWHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "36")]
		public Dictionary<string, EnumChoiceData> EVDZLDSTWJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "37")]
		public Dictionary<string, EnumChoiceData> KFVCOEDUSXW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void GQWEUEYSCZQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BB70", Offset = "0x2B3A570", VA = "0x182B3BB70")]
		private static Task<bool> KPEFCPEOTUC(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BAC0", Offset = "0x2B3A4C0", VA = "0x182B3BAC0", Slot = "38")]
		public Task<bool> GXDVHOEHIKR(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BCB0", Offset = "0x2B3A6B0", VA = "0x182B3BCB0")]
		private static bool OXMVXQVZMLG(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BBD0", Offset = "0x2B3A5D0", VA = "0x182B3BBD0", Slot = "39")]
		public bool KPSGAQQATRV(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void RFALLDNSZXC(Id32<JNMNERPAZHW> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BC50", Offset = "0x2B3A650", VA = "0x182B3BC50", Slot = "40")]
		public void MSYSVUCUSQD(Id32<JNMNERPAZHW> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C100", Offset = "0x2B3AB00", VA = "0x182B3C100")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, LSNRXVKTUTI>> YUIBJLCBTYK(Task<Result<None, LSNRXVKTUTI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B910", Offset = "0x2B3A310", VA = "0x182B3B910", Slot = "41")]
		public Task<Result<None, LSNRXVKTUTI>> AYZUKIKGFQR(Task<Result<None, LSNRXVKTUTI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BCC0", Offset = "0x2B3A6C0", VA = "0x182B3BCC0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, LSNRXVKTUTI>> QFPDQNRMNAQ(Task<Result<MultiResult, LSNRXVKTUTI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B940", Offset = "0x2B3A340", VA = "0x182B3B940", Slot = "42")]
		public Task<Result<MultiResult, LSNRXVKTUTI>> AYZUKIKGFQR(Task<Result<MultiResult, LSNRXVKTUTI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BDB0", Offset = "0x2B3A7B0", VA = "0x182B3BDB0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> QFUKNULJWLZ(Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B970", Offset = "0x2B3A370", VA = "0x182B3B970", Slot = "43")]
		public Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> AYZUKIKGFQR(Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class KQNVXECCNWB : FFFNKWYJXLW
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(MHFTIKCGLDX e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? AQGWHUWJDBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly InteropDelegate NVTAPAROJWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly InteropDelegate LAXEFZEXOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private InteropDelegate? KGYXULJQGYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private InvokeStudioFunctionDelegate? FYZMYECXUCX;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "5")]
		public LegacyCV2Result<None> RDFFRLGLNMD(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0")]
		private static LegacyCV2Result<None> Default(MHFTIKCGLDX _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "6")]
		public LegacyCV2Result<None> PMTZEEXZYWK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "7")]
		public LegacyCV2Result<None> YZGKLFGFMQX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "8")]
		public LegacyCV2Result<None> QULKCOMZAHE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "9")]
		public LegacyCV2Result<None> EHQDKVVPCRU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "15")]
		public LegacyCV2Result<None> UJRALUYMRWP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CVSMDBOTMFP(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FAEMYUDUCIX(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HYBGUUXTCTW(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DZXSWBPVHWB(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BWARKNPDLAK(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WCVODFLREJK(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YJMTEAPCXQD(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "93")]
		public LegacyCV2Result<None> MILKJLNIRFY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "94")]
		public LegacyCV2Result<None> RHPQZLJWGQE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "95")]
		public LegacyCV2Result<None> ZZOGSTUETMN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TTSQBEBPKAR(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(MHFTIKCGLDX e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TJZNANEXJLB(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BZRTSVCYOMH(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZITYAKYSJXK(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RMWSDMFVLSN(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LCAUOUIGUMI(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WJLRUPGYEMC(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KAKIMHOEZGS(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LUUNQXTQFJZ(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x15587A0", Offset = "0x15571A0", VA = "0x1815587A0", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JMFNENHGKFA(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NARCYLCIBCB(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "119")]
		public LegacyCV2Result<None> DHAWDSYGSIZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YKHFEIDROCC(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "121")]
		public LegacyCV2Result<None> DXRWHJDFOPI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "122")]
		public LegacyCV2Result<None> WVFWNMACNOS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "123")]
		public LegacyCV2Result<None> AZQFKXXIHFM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "124")]
		public LegacyCV2Result<None> MMXKQIJLOMG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "125")]
		public LegacyCV2Result<None> JGEXEDZLAYM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "126")]
		public LegacyCV2Result<None> GCADJTBFYAF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "818")]
		public LegacyCV2Result<None> JVSTRXADDLV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "819")]
		public LegacyCV2Result<None> MQDJIMLFXNZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "147")]
		public LegacyCV2Result<None> SHSSDYDSJMN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "148")]
		public LegacyCV2Result<None> CFOLSDVSOHX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "149")]
		public LegacyCV2Result<None> NWICJXPVBXO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "150")]
		public LegacyCV2Result<None> GNSXNGBKTQQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "151")]
		public LegacyCV2Result<None> OMUVOSSSQVH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(MHFTIKCGLDX e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(MHFTIKCGLDX e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(MHFTIKCGLDX e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, FFFNKWYJXLW.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(MHFTIKCGLDX e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, FFFNKWYJXLW.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "174")]
		public LegacyCV2Result<None> IKVIPGWCMWI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "175")]
		public LegacyCV2Result<None> WIRORHXUHRL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "176")]
		public LegacyCV2Result<None> CDUEDTSNGWJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "197")]
		public LegacyCV2Result<None> VZUZQSAAMJJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "198")]
		public LegacyCV2Result<None> EZQZWVSWLCG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "199")]
		public LegacyCV2Result<None> UTDSCJFEPDX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "200")]
		public LegacyCV2Result<None> WSMROXDDEPD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "201")]
		public LegacyCV2Result<None> YFJPISWMJID(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "202")]
		public LegacyCV2Result<None> OMHZMIQXVGW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "203")]
		public LegacyCV2Result<None> YTOORMKCMLG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "204")]
		public LegacyCV2Result<None> OABLXBMALKM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "205")]
		public LegacyCV2Result<None> RDHPZYMKOCM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "206")]
		public LegacyCV2Result<None> FSCJJLQMQRS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "207")]
		public LegacyCV2Result<None> XGJXMBDHIKM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "208")]
		public LegacyCV2Result<None> SDDHEEWUSQY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "209")]
		public LegacyCV2Result<None> VBATITQGAFW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "210")]
		public LegacyCV2Result<None> CULWEOYVNOD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "211")]
		public LegacyCV2Result<None> TMIJWSNHDMW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "212")]
		public LegacyCV2Result<None> RIOPTDSJIXF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "213")]
		public LegacyCV2Result<None> QOZBUJKOGWE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "214")]
		public LegacyCV2Result<None> PTDBCMZOBTH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "215")]
		public LegacyCV2Result<None> HIOFXHJUHRO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "274")]
		public LegacyCV2Result<None> IYUUDKOYKKU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "277")]
		public LegacyCV2Result<None> PSSUQTSWLKK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "279")]
		public LegacyCV2Result<None> RRXQGDIUDFN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "280")]
		public LegacyCV2Result<None> DVFQGSLPOVX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "281")]
		public LegacyCV2Result<None> CMPKHVRTXWG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "282")]
		public LegacyCV2Result<None> HWEMZMHBSAX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "283")]
		public LegacyCV2Result<None> RGUAFMBRZPY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "287")]
		public LegacyCV2Result<None> SVWAWEISTNR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "288")]
		public LegacyCV2Result<None> VXTFJKUDQHE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "317")]
		public LegacyCV2Result<None> PVDWKFDYCMH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "406")]
		public LegacyCV2Result<None> BRSVCCQFPPI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BKHKHMFPZFT(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GHEPSBPAEIF(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ARJYRRWRCBR(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XCKLCHQCXUY(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PGACFIUMJKL(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "416")]
		public LegacyCV2Result<VLNNLEMRSFV.CV2DiscoverySectionType> MAVMEHNJVCQ(MHFTIKCGLDX e, CircuitSignal a)
		{
			return default(LegacyCV2Result<VLNNLEMRSFV.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "417")]
		public LegacyCV2Result<None> FGZEWHXWQSQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(MHFTIKCGLDX e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JZODORUFRPC(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QZBTBHOMRML(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KXNIUZFMHKY(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "462")]
		public LegacyCV2Result<None> SYLMMFKGFUT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "463")]
		public LegacyCV2Result<None> KZJGRIIQUQC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "464")]
		public LegacyCV2Result<None> LCPWFTXDEJT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "465")]
		public LegacyCV2Result<None> QOTQEZNOBXC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "466")]
		public LegacyCV2Result<None> DOHGZOVJIVQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "467")]
		public LegacyCV2Result<None> UTWWBOLRAIG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "468")]
		public LegacyCV2Result<None> OPLKOSLTRUB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "469")]
		public LegacyCV2Result<None> AXALAGCUTKH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "474")]
		public LegacyCV2Result<None> FIBRILMFAED(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "475")]
		public LegacyCV2Result<None> EVEEPCUGIGN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "476")]
		public LegacyCV2Result<None> WZPDCTIUGFI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "477")]
		public LegacyCV2Result<None> TIOYONMGHOP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "478")]
		public LegacyCV2Result<None> KZBNCLSXXIJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "479")]
		public LegacyCV2Result<None> QKSMXJYCJCW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(MHFTIKCGLDX executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(MHFTIKCGLDX executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "472")]
		public LegacyCV2Result<None> DTOSWWPXUZI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "473")]
		public LegacyCV2Result<None> RUPZSPGBODQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "480")]
		public LegacyCV2Result<None> RKKCQOJSJAI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "481")]
		public LegacyCV2Result<None> LTESBFMKGOS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "482")]
		public LegacyCV2Result<None> LHRBMQBQVBR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "483")]
		public LegacyCV2Result<None> RMPJINHRKKR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "484")]
		public LegacyCV2Result<None> RSCIFOQVMXT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "485")]
		public LegacyCV2Result<None> XWYRMIFBSLR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "486")]
		public LegacyCV2Result<None> RRQQDIJUPUN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "487")]
		public LegacyCV2Result<None> VGHADTSKYYT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "488")]
		public LegacyCV2Result<None> FUHGHMKQCGZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "489")]
		public LegacyCV2Result<None> WAGVEFUNTGB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "490")]
		public LegacyCV2Result<None> FJXMFIFUVLR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "491")]
		public LegacyCV2Result<None> NPEIGBAAKFD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "492")]
		public LegacyCV2Result<None> TUJWDMJDWRN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "493")]
		public LegacyCV2Result<None> PIFWXAEZLBX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "494")]
		public LegacyCV2Result<None> PFFOTMZTSMZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "495")]
		public LegacyCV2Result<None> GGMGDKUPHXF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "496")]
		public LegacyCV2Result<None> QZDJQBNAYCH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "497")]
		public LegacyCV2Result<None> TIAJXUZZEUL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "498")]
		public LegacyCV2Result<None> KNSSLDKRBBF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "499")]
		public LegacyCV2Result<None> JNJINTJZIIJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B36410", Offset = "0x2B34E10", VA = "0x182B36410", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "507")]
		public LegacyCV2Result<None> SSMJLYWOOAN(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "508")]
		public LegacyCV2Result<None> FQCGLVSADQL(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "509")]
		public LegacyCV2Result<None> CLFMPXNRKKL(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "510")]
		public LegacyCV2Result<None> CBLRNEEBPQS(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(MHFTIKCGLDX e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(MHFTIKCGLDX e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(MHFTIKCGLDX e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.CMPZHBZLLFJ> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "522")]
		public LegacyCV2Result<None> GNGCPESYEIC(MHFTIKCGLDX e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "525")]
		public LegacyCV2Result<None> YFIAEYXRPCK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "527")]
		public LegacyCV2Result<None> PKWEXYZXORV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "528")]
		public LegacyCV2Result<None> CCSQNLFLKBD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "530")]
		public LegacyCV2Result<None> TFJAHANSXGZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "531")]
		public LegacyCV2Result<None> SBMNYHHZTOM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2B36300", Offset = "0x2B34D00", VA = "0x182B36300", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "533")]
		public LegacyCV2Result<None> BVKZKIXDXAS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2B362B0", Offset = "0x2B34CB0", VA = "0x182B362B0", Slot = "535")]
		public LegacyCV2Result<None> FIUWZLCOGEU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "534")]
		public LegacyCV2Result<None> YBMMPISVWOF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "536")]
		public LegacyCV2Result<None> NKDJRRUDOGL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "537")]
		public LegacyCV2Result<None> YYRTPOTABFO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "538")]
		public LegacyCV2Result<None> SAUYMWPVCBA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "539")]
		public LegacyCV2Result<None> GCPSDJDDRRE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "540")]
		public LegacyCV2Result<None> MAFPBHHCHIU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "583")]
		public LegacyCV2Result<None> Raycast(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "584")]
		public LegacyCV2Result<None> JVYNGYANRIZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "587")]
		public LegacyCV2Result<None> YHQBAXLLHXC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "591")]
		public LegacyCV2Result<None> YTIYBJOTPSH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "592")]
		public LegacyCV2Result<None> WQSQJKGFKBK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "641")]
		public LegacyCV2Result<None> ONLKYWQGDEB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "642")]
		public LegacyCV2Result<None> UKHQXQRLBXH(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "643")]
		public LegacyCV2Result<None> FZUSMEJRAWE(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "644")]
		public LegacyCV2Result<None> HNZAQMYMOVR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "645")]
		public LegacyCV2Result<None> JWLMOVHRYKH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "646")]
		public LegacyCV2Result<None> CHFWKAJLXRG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "649")]
		public LegacyCV2Result<None> EGSUAWOIZCD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "650")]
		public LegacyCV2Result<None> MGIIOIUOZCP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "651")]
		public LegacyCV2Result<None> GTRRDTTIPIA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "661")]
		public LegacyCV2Result<None> RGMDECRNVMH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "660")]
		public LegacyCV2Result<None> IBCCMACYPHY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "662")]
		public LegacyCV2Result<None> TFMMUTYQJDX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "663")]
		public LegacyCV2Result<None> IEJZJPPHOYI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "670")]
		public LegacyCV2Result<None> KSCCCJAEBRB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "671")]
		public LegacyCV2Result<None> TZMWGGCKQCW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "674")]
		public LegacyCV2Result<None> TIFXZBSGFWI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "675")]
		public LegacyCV2Result<None> ZHQTIIKSTVB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(MHFTIKCGLDX e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "696")]
		public LegacyCV2Result<None> DKXSRJEOVNT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "697")]
		public LegacyCV2Result<None> GKOXCKMJKED(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "698")]
		public LegacyCV2Result<None> DAAEWUGFJHH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "699")]
		public LegacyCV2Result<None> CVHEFTRGHKS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "700")]
		public LegacyCV2Result<None> BGRMVPAQSBC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "676")]
		public LegacyCV2Result<None> IERPBUTHTEX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "677")]
		public LegacyCV2Result<None> UTKHRJXZPHD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "678")]
		public LegacyCV2Result<None> VHKRBZYNPDG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "679")]
		public LegacyCV2Result<None> MFKDWCRBQTH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "680")]
		public LegacyCV2Result<None> FQBXMYWGATM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "681")]
		public LegacyCV2Result<None> MNZOLVZLVXJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "682")]
		public LegacyCV2Result<None> EWPWZNEITIR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "683")]
		public LegacyCV2Result<None> OVRXIEDAUIA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "684")]
		public LegacyCV2Result<None> OGEMOYGTDYK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "685")]
		public LegacyCV2Result<None> OJTCBPZTYBH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "686")]
		public LegacyCV2Result<None> OCUTXDMKRNH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "687")]
		public LegacyCV2Result<None> YNKGOCXTELG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "688")]
		public LegacyCV2Result<None> IKHWNZIIRTR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "689")]
		public LegacyCV2Result<None> WRGMSIFBABB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "690")]
		public LegacyCV2Result<None> EZCIYTQBCWQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "691")]
		public LegacyCV2Result<None> CSADNJQIPUO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "692")]
		public LegacyCV2Result<None> GJSBWEZKLVC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "693")]
		public LegacyCV2Result<None> MNLVTUKLCGD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "765")]
		public LegacyCV2Result<None> EROICWLCJMV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "711")]
		public LegacyCV2Result<None> RDSGILXDRNY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "712")]
		public LegacyCV2Result<None> BXZLFLFQBAK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "713")]
		public LegacyCV2Result<None> EORQGVFILNW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "714")]
		public LegacyCV2Result<None> RMXHNPEDJGO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "717")]
		public LegacyCV2Result<None> XDFEFALQWWQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "721")]
		public LegacyCV2Result<None> XIWVDTBFMON(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "722")]
		public LegacyCV2Result<None> AGHDUYDSHJZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "723")]
		public LegacyCV2Result<None> AFDQAIZNRUC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "724")]
		public LegacyCV2Result<None> TZJORTXLCIO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "725")]
		public LegacyCV2Result<None> AZUHFLJZNNM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "726")]
		public LegacyCV2Result<None> PBPGUGJGPAN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "727")]
		public LegacyCV2Result<None> LAWULGXSFQY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "728")]
		public LegacyCV2Result<None> GSSGCMLNUOL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "729")]
		public LegacyCV2Result<None> FDYZJDRKQJX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "730")]
		public LegacyCV2Result<None> DQRPDMHMTPZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "731")]
		public LegacyCV2Result<None> MBOUOKTIDKT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "732")]
		public LegacyCV2Result<None> UWNKCUTWXMN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "733")]
		public LegacyCV2Result<None> RQFZIQYZUWR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "734")]
		public LegacyCV2Result<None> FFZLKEETVUQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "735")]
		public LegacyCV2Result<None> JNAKVPIOSNP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "736")]
		public LegacyCV2Result<None> PAQFWPOEOOT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "737")]
		public LegacyCV2Result<None> IDHGNXKSXZA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "738")]
		public LegacyCV2Result<None> JVAVVBIBYMR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "740")]
		public LegacyCV2Result<None> VXWPRVVRYVF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "739")]
		public LegacyCV2Result<None> CPYIZNZPKXB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "741")]
		public LegacyCV2Result<None> AFWFWQUAZVQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "742")]
		public LegacyCV2Result<None> RZPDUDUFBAJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "743")]
		public LegacyCV2Result<None> ROVYLYUABQS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "744")]
		public LegacyCV2Result<None> ZGTWDYZIWKM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "745")]
		public LegacyCV2Result<None> KQWRWCULBYD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "746")]
		public LegacyCV2Result<None> DOWNGZZMXPE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "747")]
		public LegacyCV2Result<None> ERSUVMWJTPE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "748")]
		public LegacyCV2Result<None> OSOFUGIDGRT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "749")]
		public LegacyCV2Result<None> LLOEMXMWISP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "750")]
		public LegacyCV2Result<None> DDJHROTCUZF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "751")]
		public LegacyCV2Result<None> JFKKOFQKNZL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "752")]
		public LegacyCV2Result<None> KPXJRRIALOJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "753")]
		public LegacyCV2Result<None> WQOAUEEFXOF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "754")]
		public LegacyCV2Result<None> BGEEGMARLKZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "755")]
		public LegacyCV2Result<None> ZBDMUTUPFPO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "756")]
		public LegacyCV2Result<None> ZNFLWPOHXTI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "757")]
		public LegacyCV2Result<None> BHEXRFQBRPU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "758")]
		public LegacyCV2Result<None> NAODIKSWPTU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "759")]
		public LegacyCV2Result<None> AOSLTJMOQXD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "760")]
		public LegacyCV2Result<None> HWWTAKISTAT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "761")]
		public LegacyCV2Result<None> YVQLLQECBYN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "762")]
		public LegacyCV2Result<None> BDKPQSJRGWW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "763")]
		public LegacyCV2Result<None> EEHFYSCMGDK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "764")]
		public LegacyCV2Result<None> GVVWDHIMVWB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "771")]
		public LegacyCV2Result<None> PAVOVBRJTCL(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "772")]
		public LegacyCV2Result<None> QRAITZNVAJD(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "773")]
		public LegacyCV2Result<None> BHOLSUUOWYO(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(MHFTIKCGLDX ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "775")]
		public LegacyCV2Result<None> OKFQNJUXRJC(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "776")]
		public LegacyCV2Result<None> FEJBHWWMYEU(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "777")]
		public LegacyCV2Result<None> KRIVJOHAWJB(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "778")]
		public LegacyCV2Result<None> XXSXLICOIZP(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "779")]
		public LegacyCV2Result<None> HZOXXJPFRAN(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "707")]
		public LegacyCV2Result<None> RYCXMDWFPVF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "801")]
		public LegacyCV2Result<None> VPCMZYPDGSF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "802")]
		public LegacyCV2Result<None> GCWIOWNKWIR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "803")]
		public LegacyCV2Result<None> KTPTNALEWYP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "804")]
		public LegacyCV2Result<None> ANRQNUDUABV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "805")]
		public LegacyCV2Result<None> JIGOGJPHTKV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "806")]
		public LegacyCV2Result<None> WCPHJCPUHRP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "807")]
		public LegacyCV2Result<None> NAHIKWZXHIP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "808")]
		public LegacyCV2Result<None> XFJZCFXOASP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "809")]
		public LegacyCV2Result<None> UOFPXYPTVEN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "810")]
		public LegacyCV2Result<None> WFHQHCXTXYT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "811")]
		public LegacyCV2Result<None> GHWFGBXTVNZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "812")]
		public LegacyCV2Result<None> DKZVBSGPBJG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "817")]
		public LegacyCV2Result<None> HABBUAARVAP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "821")]
		public LegacyCV2Result<None> NPWJLBPGBWE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "822")]
		public LegacyCV2Result<None> CFDHJXWXHVC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "823")]
		public LegacyCV2Result<None> BTIVKEAFGUG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "824")]
		public LegacyCV2Result<None> RWXOCNUWMQK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "826")]
		public LegacyCV2Result<None> OEUFZZVEIFU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "827")]
		public LegacyCV2Result<None> XEUSXAJEHQR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "828")]
		public LegacyCV2Result<None> MYKKKRJXSEL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "831")]
		public LegacyCV2Result<None> YRREQELCLJX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "832")]
		public LegacyCV2Result<None> PNBBUOBFUHM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "833")]
		public LegacyCV2Result<None> WTVOIKRRREB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(MHFTIKCGLDX e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(MHFTIKCGLDX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "836")]
		public LegacyCV2Result<None> VTPFIWSOWVK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KEYBXGFZDHE(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NMZMXOCCVAQ(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JYVBJEBQXYH(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DJWZAORLUBW(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DDLHDLYONNL(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(MHFTIKCGLDX e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(MHFTIKCGLDX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(MHFTIKCGLDX e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(MHFTIKCGLDX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(MHFTIKCGLDX e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(MHFTIKCGLDX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(MHFTIKCGLDX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "856")]
		public LegacyCV2Result<None> XSNJOQUVZGE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "859")]
		public LegacyCV2Result<None> LRJLCDTAWJW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "860")]
		public LegacyCV2Result<None> XERGNJSQXHM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "861")]
		public LegacyCV2Result<None> QTGZLOMUXUO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "862")]
		public LegacyCV2Result<None> FNRVDCFCBDR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "864")]
		public LegacyCV2Result<None> LUVNYHMUSBG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "865")]
		public LegacyCV2Result<None> YYGNPJMLACC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(MHFTIKCGLDX e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "869")]
		public LegacyCV2Result<None> DAJBHHYWLBE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "879")]
		public LegacyCV2Result<None> XDVRQDCUPMY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "880")]
		public LegacyCV2Result<None> XXLNPRXAUTA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "881")]
		public LegacyCV2Result<None> GTETVUPFMKD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "882")]
		public LegacyCV2Result<None> AOCQBBHYYIK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(MHFTIKCGLDX e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(MHFTIKCGLDX e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(MHFTIKCGLDX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(MHFTIKCGLDX e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(MHFTIKCGLDX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "889")]
		public LegacyCV2Result<None> OBGODCSWMXU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "890")]
		public LegacyCV2Result<None> TKAICUUYHBP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "891")]
		public LegacyCV2Result<None> YQSMWIERZKM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "892")]
		public LegacyCV2Result<None> EWCSOLUAWUA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "893")]
		public LegacyCV2Result<None> DBAQNGQKCSS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "897")]
		public LegacyCV2Result<None> VHRMUEAAABZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "898")]
		public LegacyCV2Result<None> ZNWBFNZLJUD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "899")]
		public LegacyCV2Result<None> MAEOWCXMHNQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "901")]
		public LegacyCV2Result<None> BYTPHNHNOQS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "900")]
		public LegacyCV2Result<None> ZCEPXCFNGQO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "902")]
		public LegacyCV2Result<None> KKMVPMDGUEX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "904")]
		public LegacyCV2Result<None> UYNEAEABOOX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "903")]
		public LegacyCV2Result<None> BLPDGGKOHUZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "905")]
		public LegacyCV2Result<None> DPVOOWDBYQK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "906")]
		public LegacyCV2Result<None> CRHSGQADQLQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "907")]
		public LegacyCV2Result<None> GLYZZMFRZLN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "908")]
		public LegacyCV2Result<None> CZUJWEAAGPT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "909")]
		public LegacyCV2Result<None> BUJWBRSSIFP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "910")]
		public LegacyCV2Result<None> GMGZJMXWOXP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "911")]
		public LegacyCV2Result<None> MNKPVPMUOKF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "918")]
		public LegacyCV2Result<None> MVRFZVMGBHJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "919")]
		public LegacyCV2Result<None> MPVNPXJFGMT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(MHFTIKCGLDX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(MHFTIKCGLDX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(MHFTIKCGLDX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(MHFTIKCGLDX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(MHFTIKCGLDX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(MHFTIKCGLDX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(MHFTIKCGLDX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(MHFTIKCGLDX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(MHFTIKCGLDX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "941")]
		public LegacyCV2Result<None> JIYIOAVSNAJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "942")]
		public LegacyCV2Result<None> HFWHBROIYHP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "943")]
		public LegacyCV2Result<None> LFJCFHXBTFY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "944")]
		public LegacyCV2Result<None> HTUFMQDRYXK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "945")]
		public LegacyCV2Result<None> MNYLAZGEMGX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "946")]
		public LegacyCV2Result<None> NDXGIHADZIB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "947")]
		public LegacyCV2Result<None> QJBXAZAVGQY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "948")]
		public LegacyCV2Result<None> PRMNXAIUOVW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "949")]
		public LegacyCV2Result<None> IVYAPFDHKOQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "950")]
		public LegacyCV2Result<None> QKDEIEXTIHJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "968")]
		public LegacyCV2Result<None> ANVRPVWFMFJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "967")]
		public LegacyCV2Result<None> KGFFONMPBLG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "969")]
		public LegacyCV2Result<None> NMGMFTTYGVE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "970")]
		public LegacyCV2Result<None> OAYTHOYEOVR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "971")]
		public LegacyCV2Result<None> PYJKMDCABOY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "972")]
		public LegacyCV2Result<None> FRITHXUFILM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "973")]
		public LegacyCV2Result<None> OARATUNRSTF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "975")]
		public LegacyCV2Result<None> JZJYSNBKNKA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "982")]
		public LegacyCV2Result<None> VEJVYRFBQNV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "983")]
		public LegacyCV2Result<None> ERMNGDLPBRL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "991")]
		public LegacyCV2Result<None> TIZAZVRZZUE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "993")]
		public LegacyCV2Result<None> FOPLRYUAMNO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "994")]
		public LegacyCV2Result<None> IMINTZHKAZW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "995")]
		public LegacyCV2Result<None> HDSZUTUVFKO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "996")]
		public LegacyCV2Result<None> MWXYRWJIIGS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "997")]
		public LegacyCV2Result<None> IGYYCDLVSAI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "998")]
		public LegacyCV2Result<None> XJFDKKZJUHG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "999")]
		public LegacyCV2Result<None> TPWGWXPVORU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1000")]
		public LegacyCV2Result<None> CVEXUOADNRU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1001")]
		public LegacyCV2Result<None> YPXASGHOMZU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1002")]
		public LegacyCV2Result<None> ITGIDLNDTJE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1009")]
		public LegacyCV2Result<None> SHOUUPNJFKM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1017")]
		public LegacyCV2Result<None> ENFPASPMBXB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1018")]
		public LegacyCV2Result<None> VHFHINCWJMG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1019")]
		public LegacyCV2Result<None> ALDRFUYFCGT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1020")]
		public LegacyCV2Result<None> CXKELJNUSJM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1021")]
		public LegacyCV2Result<None> MZDRNBECKRR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1022")]
		public LegacyCV2Result<None> ODUYBWENSGA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1023")]
		public LegacyCV2Result<None> XMOUEADOWXD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1024")]
		public LegacyCV2Result<None> FHQRDBCVPOF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1025")]
		public LegacyCV2Result<None> IQJHHFNZOQU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1026")]
		public LegacyCV2Result<None> JWMVAJPIHDB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1027")]
		public LegacyCV2Result<None> HPGKNUTUWKT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1028")]
		public LegacyCV2Result<None> HEJIVKPRROY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1029")]
		public LegacyCV2Result<None> PNBIJMTZVDK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1030")]
		public LegacyCV2Result<None> ZIELQQPCUCH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1031")]
		public LegacyCV2Result<None> BGDBTDSGRJK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1032")]
		public LegacyCV2Result<None> OMKYRJMRMZV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1033")]
		public LegacyCV2Result<None> CHMQAAARWST(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1047")]
		public LegacyCV2Result<None> VSYBVRCAQGZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1048")]
		public LegacyCV2Result<None> RGRQCESLAOV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1049")]
		public LegacyCV2Result<None> MXJWJLKEJLD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1050")]
		public LegacyCV2Result<None> MBUXAUHJOSV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1051")]
		public LegacyCV2Result<None> UBMXEBARSTA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1052")]
		public LegacyCV2Result<None> MQDFZNUOJTA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1053")]
		public LegacyCV2Result<None> ALPDNQUKCMN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1054")]
		public LegacyCV2Result<None> GSACADWKRWI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1055")]
		public LegacyCV2Result<None> QFUZNCCUNBV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1056")]
		public LegacyCV2Result<None> SEDXGNMAZMU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1057")]
		public LegacyCV2Result<None> XQWJGSUWEAQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1058")]
		public LegacyCV2Result<None> QEPWBSMZICV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1059")]
		public LegacyCV2Result<None> BEXEYYIDLPS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1060")]
		public LegacyCV2Result<None> RBIFKTUQEDA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1061")]
		public LegacyCV2Result<None> ZIXCLQFJPHQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1062")]
		public LegacyCV2Result<None> IFYSYDJZZYC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1063")]
		public LegacyCV2Result<None> HFQAOGFQQAC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1064")]
		public LegacyCV2Result<None> MJVPXLWCEKD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1065")]
		public LegacyCV2Result<None> IEFDNETKBWL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1066")]
		public LegacyCV2Result<None> BDIFHAYBMVG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1067")]
		public LegacyCV2Result<None> BSLHARTQJTC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1068")]
		public LegacyCV2Result<None> SEGCQCHYCSO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1069")]
		public LegacyCV2Result<None> CSRFNMSFXCO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1070")]
		public LegacyCV2Result<None> DBIBPKQRBPV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1071")]
		public LegacyCV2Result<None> ICSJNFACRDJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B36340", Offset = "0x2B34D40", VA = "0x182B36340", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(MHFTIKCGLDX e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(MHFTIKCGLDX e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1092")]
		public LegacyCV2Result<None> VBTCSQNKYVQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1093")]
		public LegacyCV2Result<None> QHLBZFAPVFX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1094")]
		public LegacyCV2Result<None> PTAKQTITYXT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1095")]
		public LegacyCV2Result<None> NIAPURIPORL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1096")]
		public LegacyCV2Result<None> QTZRLQZBKTT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1097")]
		public LegacyCV2Result<None> MXYZBFQVUJB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1098")]
		public LegacyCV2Result<None> FVUVGAGUANN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1099")]
		public LegacyCV2Result<None> YVFTEBTZSHF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1100")]
		public LegacyCV2Result<None> DEKHSEIMVHN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1101")]
		public LegacyCV2Result<None> JWVCCECBGDV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1102")]
		public LegacyCV2Result<None> BMVKPETZWAP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1103")]
		public LegacyCV2Result<None> AGUYZERCIKY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1104")]
		public LegacyCV2Result<None> QWUCCBKVVWY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1105")]
		public LegacyCV2Result<None> CABORAAXEDG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1106")]
		public LegacyCV2Result<None> BSRCUACEQUY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1107")]
		public LegacyCV2Result<None> YFCDZMUFSCP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1108")]
		public LegacyCV2Result<None> MGQRWWVKZGX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1109")]
		public LegacyCV2Result<None> UOWAQQUZTQW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1110")]
		public LegacyCV2Result<None> ILDIFNZBDES(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1111")]
		public LegacyCV2Result<None> IKERQVRONFU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1112")]
		public LegacyCV2Result<None> CZFXRMQXCQO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1113")]
		public LegacyCV2Result<None> QZYXHVFFVFR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1114")]
		public LegacyCV2Result<None> XEDQCQUWLZV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1115")]
		public LegacyCV2Result<None> REVTEHELZDA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1116")]
		public LegacyCV2Result<None> WTVPWVVHMOK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1117")]
		public LegacyCV2Result<None> ZUZCZGWIHEW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1118")]
		public LegacyCV2Result<None> AKIRWWXMKDA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1119")]
		public LegacyCV2Result<None> JJCTMSJSAHN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1120")]
		public LegacyCV2Result<None> UXOCLKSUGQU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1121")]
		public LegacyCV2Result<None> OAWOXDSSQYM(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1122")]
		public LegacyCV2Result<None> FFLWWNPTRKA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1123")]
		public LegacyCV2Result<None> PEFTXUUNZVB(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1124")]
		public LegacyCV2Result<None> MBCNIXEBDHZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1125")]
		public LegacyCV2Result<None> BPNMMJSDPUH(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1126")]
		public LegacyCV2Result<None> GEYOEVNVIOT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1127")]
		public LegacyCV2Result<None> ZWJHYQEBPOL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1128")]
		public LegacyCV2Result<None> KIJEKHGOVUT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1129")]
		public LegacyCV2Result<None> SXIWOVIQGZP(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1130")]
		public LegacyCV2Result<None> BPHRVJEWYNY(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1131")]
		public LegacyCV2Result<None> MKKVBNDHPEL(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1132")]
		public LegacyCV2Result<None> EWPZKXXMZTI(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1133")]
		public LegacyCV2Result<None> IODFRFGUOHF(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1134")]
		public LegacyCV2Result<None> MHNFPYLOCPJ(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1135")]
		public LegacyCV2Result<None> WTMIXCUKWYI(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1136")]
		public LegacyCV2Result<None> MOUJXYOVEAA(YRRNONXIVNU e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1140")]
		public LegacyCV2Result<None> VFVXCTVJTKI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1166")]
		public LegacyCV2Result<None> UCIQWVRCFOK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1168")]
		public LegacyCV2Result<None> ZVZWIVPDZSU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1169")]
		public LegacyCV2Result<None> ILCQOVVTFDJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1170")]
		public LegacyCV2Result<None> IXJHJIMQARQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1171")]
		public LegacyCV2Result<None> DQUWMEKBUXR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1182")]
		public LegacyCV2Result<None> SZVVGXZHEOT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1183")]
		public LegacyCV2Result<None> BVGFYYBHMYJ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1184")]
		public LegacyCV2Result<None> FZCNDIBRPZX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1185")]
		public LegacyCV2Result<None> QJRGREZRSWT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1186")]
		public LegacyCV2Result<None> BCPQWPWPKPS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1187")]
		public LegacyCV2Result<None> NXXJZFNFMPK(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1188")]
		public LegacyCV2Result<None> ROTHRNPZZNI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1189")]
		public LegacyCV2Result<None> CQTIVJEJBJY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1190")]
		public LegacyCV2Result<None> CKMXPUOCFKZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1191")]
		public LegacyCV2Result<None> JRPMYEHMQND(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1192")]
		public LegacyCV2Result<None> LBZPALEPDFQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1193")]
		public LegacyCV2Result<None> VLWJRKLWWOX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "184")]
		public LegacyCV2Result<None> JTDBEPCLDKH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B362F0", Offset = "0x2B34CF0", VA = "0x182B362F0", Slot = "191")]
		public bool FUYFRUJGUKJ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1194")]
		public LegacyCV2Result<None> RNKIEXUZFDR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1195")]
		public LegacyCV2Result<None> HDPRTBIISBU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1196")]
		public LegacyCV2Result<None> OFNSDLUINEV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(MHFTIKCGLDX e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1205")]
		public LegacyCV2Result<None> MXXKGPVVGCG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1206")]
		public LegacyCV2Result<None> OGHWBBDAOVM(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(MHFTIKCGLDX e, InOut io, LFYGOUEBTWC objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "250")]
		public LegacyCV2Result<None> HVRUEFAIUBB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "251")]
		public LegacyCV2Result<None> PEEHNWSLRNL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "252")]
		public LegacyCV2Result<None> NMBOVOMXMDP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "254")]
		public LegacyCV2Result<None> SQDXHTXTDGC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "255")]
		public LegacyCV2Result<None> FSJHRQIFPPQ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "256")]
		public LegacyCV2Result<None> JUTIYCXVQPI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "257")]
		public LegacyCV2Result<None> QHNPRKMRVTP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "258")]
		public LegacyCV2Result<None> CHODPXRQVKF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "259")]
		public LegacyCV2Result<None> FQZLGYXRDRU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "260")]
		public LegacyCV2Result<None> UMKIHKOASDI(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "261")]
		public LegacyCV2Result<None> UOEADYDUQWE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "262")]
		public LegacyCV2Result<None> ZMUZTTUHBPC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "263")]
		public LegacyCV2Result<None> DJMULSSFMOX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "264")]
		public LegacyCV2Result<None> KMGBZZWCCXB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "265")]
		public LegacyCV2Result<None> ZHISOAZCDUF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "266")]
		public LegacyCV2Result<None> TGAHLNUISYB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "267")]
		public LegacyCV2Result<None> DIYVXTYOLVX(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "268")]
		public LegacyCV2Result<None> WMTUJSVRVRN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "269")]
		public LegacyCV2Result<None> ELHCHWRPRQL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0")]
		private static LegacyCV2Result<None> Default(MHFTIKCGLDX e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B36380", Offset = "0x2B34D80", VA = "0x182B36380", Slot = "1209")]
		public LegacyCV2Result<None> KLHGRAINLTS(MHFTIKCGLDX a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1212")]
		public LegacyCV2Result<None> VYKSVYTKOOP(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1213")]
		public LegacyCV2Result<None> DXLEAPLBWER(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1214")]
		public LegacyCV2Result<None> DRSKNKZFDLH(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1215")]
		public LegacyCV2Result<None> TYCELCRJRLU(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(MHFTIKCGLDX e, InOut io, EQKMPOPRFDE quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1036")]
		public LegacyCV2Result<None> TLPZPTJHNDV(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1037")]
		public LegacyCV2Result<None> PGSNREHKKMT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1038")]
		public LegacyCV2Result<None> JZTFTVXOKUB(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1039")]
		public LegacyCV2Result<None> GUTMCKNRTDL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1040")]
		public LegacyCV2Result<None> BTBEQWHQNBN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1041")]
		public LegacyCV2Result<None> HVUTSDSVFLN(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1042")]
		public LegacyCV2Result<None> VKTPCGBWLLZ(MHFTIKCGLDX a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1043")]
		public LegacyCV2Result<None> ZLHTNAXWBON(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1044")]
		public LegacyCV2Result<None> CSTERDUPKLT(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1045")]
		public LegacyCV2Result<None> SMIQJHVBFJO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1046")]
		public LegacyCV2Result<None> DTALUAKASTC(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZPPWEZWPYHC(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1234")]
		public LegacyCV2Result<None> ZIKWVDAWSTZ(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1236")]
		public LegacyCV2Result<None> KAMTNZUPPCS(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1229")]
		public LegacyCV2Result<None> KBKKJUYHWQY(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1241")]
		public LegacyCV2Result<None> OOQVZAEEMFG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1242")]
		public LegacyCV2Result<None> OXPJVZWTHYD(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1243")]
		public LegacyCV2Result<None> VNMETZTRQCL(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1244")]
		public LegacyCV2Result<None> XFSFIDGZXQF(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1245")]
		public LegacyCV2Result<None> MKBFFDIYHMO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FWGMHFFGUYU(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TXFPHWVBJHO(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WNOXRFPRLAW(MHFTIKCGLDX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1259")]
		public LegacyCV2Result<None> FSJFXHJIWOW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1260")]
		public LegacyCV2Result<None> LWVACATNRPG(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1261")]
		public LegacyCV2Result<None> WZMAALGWXRO(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1262")]
		public LegacyCV2Result<None> WYQVDKUPCKE(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B36450", Offset = "0x2B34E50", VA = "0x182B36450")]
		public KQNVXECCNWB([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(MHFTIKCGLDX e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1280")]
		public LegacyCV2Result<None> RMPIMPFCTNR(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1281")]
		public LegacyCV2Result<None> FVHPXNAZLIW(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "599")]
		public LegacyCV2Result<None> VOQGFVEZFCA(MHFTIKCGLDX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1293")]
		public LegacyCV2Result<None> JRJHAGCIOVV(YRRNONXIVNU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1294")]
		public LegacyCV2Result<None> GQMIONSQCUO(YRRNONXIVNU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1295")]
		public LegacyCV2Result<None> JVWGRLKQLLJ(YRRNONXIVNU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1296")]
		public LegacyCV2Result<None> DVGBJHXCOOJ(YRRNONXIVNU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1297")]
		public LegacyCV2Result<None> XTHPQREJWRK(YRRNONXIVNU e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0")]
		public LegacyCV2Result<None> ConstantStorefrontItem(MHFTIKCGLDX e, InOut io, [In] UQTEMXPBCZZ storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(MHFTIKCGLDX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> XULFWTEPIYQ(MHFTIKCGLDX a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, FFFNKWYJXLW.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZGAOVVXHGQS(MHFTIKCGLDX a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, FFFNKWYJXLW.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1207")]
		private LegacyCV2Result<None> QCJCQTKJMDD(MHFTIKCGLDX a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1216")]
		private LegacyCV2Result<None> LLNAIKNHRXY(MHFTIKCGLDX a, InOut b, [In] UQTEMXPBCZZ storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0", Slot = "1257")]
		private LegacyCV2Result<None> ULIZELTDTWO(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class VMRDSMXRZUE : CTROCSSJSFL
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(ZEQQZNTFFEW node);

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly VMRDSMXRZUE XYCVWQEIWWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate TKBKHMEAJHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate WDJLGTTLZCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private bool HWAXYLPWPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private bool NMZYBAKZPGP;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2B412D0", Offset = "0x2B3FCD0", VA = "0x182B412D0", Slot = "4")]
		public Task<bool> CRZABLTDKRM(ZEQQZNTFFEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2B48380", Offset = "0x2B46D80", VA = "0x182B48380", Slot = "5")]
		public Task<bool> ASDGTAMBVJT(ZEQQZNTFFEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2B48450", Offset = "0x2B46E50", VA = "0x182B48450")]
		public VMRDSMXRZUE([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2B483B0", Offset = "0x2B46DB0", VA = "0x182B483B0", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? EREOBAOSHHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xD159F0", Offset = "0xD143F0", VA = "0x180D159F0", Slot = "7")]
		public bool DAEDPWDZVOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x1623EE0", Offset = "0x16228E0", VA = "0x181623EE0", Slot = "8")]
		public bool ZDBVSQNXSVZ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class VHUVKGWFIEA : GOVGVSHMLGT
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid VSYXREIHHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xF35A80", Offset = "0xF34480", VA = "0x180F35A80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
		public void Bind(WWMIZIDKQDB pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x1131B20", Offset = "0x1130520", VA = "0x181131B20")]
		public VHUVKGWFIEA(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2B48320", Offset = "0x2B46D20", VA = "0x182B48320")]
		public static VHUVKGWFIEA New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class JOGCWKGUSXI : WKJPEKOLCLW
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<SZWXGBXMTIF> nodeDefId, Id128<JNHEPOTZQDV>? legacyInnerGraphId, IReadOnlyDictionary<Id128<JNHEPOTZQDV>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IsNodeRestrictedDelegate? XTNWRUGHSGN;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool GXMCPXEGNEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool AEALGVIRRVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2B41DE0", Offset = "0x2B407E0", VA = "0x182B41DE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool TIUMATOEGBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x1138E90", Offset = "0x1137890", VA = "0x181138E90", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "6")]
		public bool VIUOYYFNIOX(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "7")]
		public CanSaveObjectIntoInventionResultType LBXDSGCRSMQ(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2B41DF0", Offset = "0x2B407F0", VA = "0x182B41DF0", Slot = "8")]
		public bool JPWVTGNQCUP(Id128<SZWXGBXMTIF> nodeDefId, Id128<JNHEPOTZQDV>? legacyInnerGraphId, IReadOnlyDictionary<Id128<JNHEPOTZQDV>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "9")]
		public bool EWUORTTSEEE(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "10")]
		public bool JIPIAYAIQLE(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2B41E40", Offset = "0x2B40840", VA = "0x182B41E40")]
		public JOGCWKGUSXI(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class KIJUQLSOLJK : OSKOVGZFRAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly KIJUQLSOLJK XYCVWQEIWWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly ShouldLogEventSenderToMakerPenDelegate QTPTNEPWVSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate CUHWLRXXCTU;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool AGXYAIARWCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x12DAB80", Offset = "0x12D9580", VA = "0x1812DAB80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool TIUXXGIVRYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2B41F10", Offset = "0x2B40910", VA = "0x182B41F10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2B41FB0", Offset = "0x2B409B0", VA = "0x182B41FB0")]
		public KIJUQLSOLJK([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class EQVNCNLCYRM : HUOSGZFVSJI<HRDYSUFEMPY>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class OFDZLNFKNMZ : HRDYSUFEMPY, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly OFDZLNFKNMZ UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool KRFCYIIVZMT
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2B44730", Offset = "0x2B43130", VA = "0x182B44730", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			public void ZADHFYCTPZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public OFDZLNFKNMZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly EQVNCNLCYRM UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private EQVNCNLCYRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B41930", Offset = "0x2B40330", VA = "0x182B41930", Slot = "4")]
		public HRDYSUFEMPY SNLTNYBYHWT()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class CBYJFRFNFDK<a, b> : IDisposable, BBNEQAUDUTJ where a : notnull where b : notnull, HBRQOLRRFMG.SWOGATQYSMU<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly b FHQCWCTTOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly a VXWCWPYFENV;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<HGRDVVOSLAK> CIKXZKSDOLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<HGRDVVOSLAK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x5063090", Offset = "0x5061A90", VA = "0x185063090")]
		public CBYJFRFNFDK(b a, a b, Id32<HGRDVVOSLAK> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x5060EF0", Offset = "0x505F8F0", VA = "0x185060EF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x5061BA0", Offset = "0x50605A0", VA = "0x185061BA0")]
		public Id32<TBNPHTPCKFD> KKQRWRQVRWA([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<TBNPHTPCKFD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x5061910", Offset = "0x5060310", VA = "0x185061910", Slot = "6")]
		public void HDDCMKRVSZN(Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x5061430", Offset = "0x505FE30", VA = "0x185061430", Slot = "7")]
		public void GERGMYXIDCJ(Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x5061330", Offset = "0x505FD30", VA = "0x185061330", Slot = "8")]
		public void GCYTTCUHVUW(Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x5061680", Offset = "0x5060080", VA = "0x185061680", Slot = "10")]
		public void GWNGUEHDASF(Id32<TBNPHTPCKFD> objectId, Id32<HGRDVVOSLAK> clientId, FPSIMBBGQNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x5062100", Offset = "0x5060B00", VA = "0x185062100", Slot = "9")]
		public void NVGXJDHBZTN(Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x5061E70", Offset = "0x5060870", VA = "0x185061E70", Slot = "11")]
		public void MAOFQTOBGJJ(Id32<TBNPHTPCKFD> objectId, FWGYWSERRIW? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x50628B0", Offset = "0x50612B0", VA = "0x1850628B0", Slot = "12")]
		public Id32<HGRDVVOSLAK> WCLPDTZCLVO(Id32<TBNPHTPCKFD> objectId)
		{
			return default(Id32<HGRDVVOSLAK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x5062C00", Offset = "0x5061600", VA = "0x185062C00", Slot = "13")]
		public Id32<KGCIRRULOJF> WTREUOCVIWU(Id32<TBNPHTPCKFD> objectId, string a, object b, bool c, RBBGDVTZCDL d, LQEKLSRKXJV e)
		{
			return default(Id32<KGCIRRULOJF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x50625D0", Offset = "0x5060FD0", VA = "0x1850625D0", Slot = "14")]
		public void QFHHBEAISFS(Id32<KGCIRRULOJF> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x5062860", Offset = "0x5061260", VA = "0x185062860", Slot = "15")]
		public void SYZGFZNTDJM(Id32<KGCIRRULOJF> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class HBRQOLRRFMG
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface SWOGATQYSMU<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void VMZTZMGOPKI(a a, Id32<HGRDVVOSLAK> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<HGRDVVOSLAK>? BFGCKXFYKLR(a a);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<TBNPHTPCKFD> KKQRWRQVRWA(a a, Id32<HGRDVVOSLAK> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void HDDCMKRVSZN(a a, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void GERGMYXIDCJ(a a, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void GWNGUEHDASF(a a, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW b);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void NVGXJDHBZTN(a a, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW b);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void MAOFQTOBGJJ(a a, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FWGYWSERRIW? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<HGRDVVOSLAK>? WCLPDTZCLVO(a a, Id32<TBNPHTPCKFD> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<KGCIRRULOJF> WTREUOCVIWU(a a, Id32<HGRDVVOSLAK> clientId, string b, object c, RBBGDVTZCDL d, LQEKLSRKXJV e);

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void QFHHBEAISFS(a a, Id32<HGRDVVOSLAK> clientId, Id32<KGCIRRULOJF> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void SYZGFZNTDJM(a a, Id32<HGRDVVOSLAK> clientId, Id32<KGCIRRULOJF> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class YKGWJMASUJS
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly HashSet<Id32<TBNPHTPCKFD>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAId32Field<KGCIRRULOJF, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public readonly Dictionary<Id32<KGCIRRULOJF>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<KGCIRRULOJF>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public SOAField<TBNPHTPCKFD, FWGYWSERRIW?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2B43550", Offset = "0x2B41F50", VA = "0x182B43550")]
			private MockCV2DynamicNetSys(HashSet<Id32<TBNPHTPCKFD>> authorityOf, [In] SOAId32Field<KGCIRRULOJF, MockCV2SyncField> syncFields, Dictionary<Id32<KGCIRRULOJF>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<KGCIRRULOJF>> mockSyncFieldToSyncField, [In] SOAField<TBNPHTPCKFD, FWGYWSERRIW?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2B43390", Offset = "0x2B41D90", VA = "0x182B43390")]
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
			public Id32<HGRDVVOSLAK>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2B435F0", Offset = "0x2B41FF0", VA = "0x182B435F0")]
			public MockCV2ObjectShared(Id32<HGRDVVOSLAK> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public LQEKLSRKXJV SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public RBBGDVTZCDL SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
			internal MockCV2SyncField(LQEKLSRKXJV syncField, RBBGDVTZCDL syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2B43710", Offset = "0x2B42110", VA = "0x182B43710")]
			public static MockCV2SyncField New(LQEKLSRKXJV syncField, RBBGDVTZCDL syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x2B436C0", Offset = "0x2B420C0", VA = "0x182B436C0")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2B43670", Offset = "0x2B42070", VA = "0x182B43670")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<TBNPHTPCKFD, MockCV2ObjectShared> BYNNWYXCOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<TBNPHTPCKFD>> HZTDVDDAINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> OQPEZXVHFWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> XFZCXCYFIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private SOAField<HGRDVVOSLAK, MockCV2DynamicNetSys> MZKTVMLTAWB;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<TBNPHTPCKFD>? SWIZFDAIRVL
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xDE9810", Offset = "0xDE8210", VA = "0x180DE9810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x12B52B0", Offset = "0x12B3CB0", VA = "0x1812B52B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2B48660", Offset = "0x2B47060", VA = "0x182B48660")]
		public void Destroy([In] SOAId32<HGRDVVOSLAK> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B48B60", Offset = "0x2B47560", VA = "0x182B48B60")]
		public void JJNSKKTPWVC(Id32<HGRDVVOSLAK> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2B49BF0", Offset = "0x2B485F0", VA = "0x182B49BF0")]
		public void VMZTZMGOPKI(Id32<HGRDVVOSLAK> clientId, Id32<HGRDVVOSLAK>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2B48FC0", Offset = "0x2B479C0", VA = "0x182B48FC0")]
		public Id32<TBNPHTPCKFD> KKQRWRQVRWA(Id32<HGRDVVOSLAK> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<HGRDVVOSLAK> clientIds)
		{
			return default(Id32<TBNPHTPCKFD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B49F90", Offset = "0x2B48990", VA = "0x182B49F90")]
		public Id32<KGCIRRULOJF> WTREUOCVIWU(Id32<HGRDVVOSLAK> clientId, string a, object b, RBBGDVTZCDL c, LQEKLSRKXJV d)
		{
			return default(Id32<KGCIRRULOJF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x2B49620", Offset = "0x2B48020", VA = "0x182B49620")]
		public void QFHHBEAISFS(Id32<HGRDVVOSLAK> clientId, Id32<KGCIRRULOJF> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2B49B20", Offset = "0x2B48520", VA = "0x182B49B20")]
		public Id32<TBNPHTPCKFD>? TERJUCBQAOB([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2B48AE0", Offset = "0x2B474E0", VA = "0x182B48AE0")]
		public void HDDCMKRVSZN([In] SOAId32<HGRDVVOSLAK> clientIds, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2B488A0", Offset = "0x2B472A0", VA = "0x182B488A0")]
		public void GERGMYXIDCJ(Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2B489E0", Offset = "0x2B473E0", VA = "0x182B489E0")]
		public void GWNGUEHDASF(Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2B494A0", Offset = "0x2B47EA0", VA = "0x182B494A0")]
		public void NVGXJDHBZTN([In] SOAId32<HGRDVVOSLAK> clientIds, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2B493D0", Offset = "0x2B47DD0", VA = "0x182B493D0")]
		public void MAOFQTOBGJJ(Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FWGYWSERRIW? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B49F40", Offset = "0x2B48940", VA = "0x182B49F40")]
		public Id32<HGRDVVOSLAK>? WCLPDTZCLVO(Id32<TBNPHTPCKFD> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B497B0", Offset = "0x2B481B0", VA = "0x182B497B0")]
		public void SYZGFZNTDJM([In] SOAId32<HGRDVVOSLAK> clientIds, Id32<HGRDVVOSLAK> clientId, Id32<KGCIRRULOJF> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A1F0", Offset = "0x2B48BF0", VA = "0x182B4A1F0")]
		public YKGWJMASUJS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class MQJPBGDVSRN
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x2B42CD0", Offset = "0x2B416D0", VA = "0x182B42CD0")]
		public static void Destroy(this YKGWJMASUJS.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class GTWQMWMCPOT : OUQHWESAABZ.EDIRCJTODTF
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static GTWQMWMCPOT PCRFCUFWFDK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate VPXLLLSPACZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate KPNGUCWLOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xD13D90", Offset = "0xD12790", VA = "0x180D13D90")]
		public GTWQMWMCPOT(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class LWWLBIHZXST : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : OPEKJLKYGKI.FUAHARUPYCB<PZJVNVFLVDC, LWWLBIHZXST>
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
				public AsyncTaskMethodBuilder<Result<object, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public LWWLBIHZXST root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public Id32<HGRDVVOSLAK> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public PZJVNVFLVDC action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				private TaskAwaiter<Result<object, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B47170", Offset = "0x2B45B70", VA = "0x182B47170", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B473B0", Offset = "0x2B45DB0", VA = "0x182B473B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
			public int UOFFTWRMUCJ(LWWLBIHZXST a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2B44ED0", Offset = "0x2B438D0", VA = "0x182B44ED0", Slot = "5")]
			public int WJRTLBQAYVF(LWWLBIHZXST a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2B44D10", Offset = "0x2B43710", VA = "0x182B44D10", Slot = "6")]
			public int DQRIOHRLWSI(LWWLBIHZXST a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B44CF0", Offset = "0x2B436F0", VA = "0x182B44CF0", Slot = "7")]
			public int AUJNWHPLWZS(LWWLBIHZXST a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B44E80", Offset = "0x2B43880", VA = "0x182B44E80", Slot = "8")]
			public void JZKFDFQOANF(LWWLBIHZXST a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "9")]
			public bool VYGVEXEQISU(LWWLBIHZXST a, Id32<HGRDVVOSLAK> actorId, PZJVNVFLVDC[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "10")]
			public bool JANQPHUMUFM(LWWLBIHZXST a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B44D30", Offset = "0x2B43730", VA = "0x182B44D30", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, LSNRXVKTUTI>> ETHZSTORPJA(LWWLBIHZXST a, Id32<HGRDVVOSLAK> senderId, PZJVNVFLVDC b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : OPEKJLKYGKI.SWYTVHETLJM<ActionDeps, WVKEVWTACCJ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps EZESLREZLXA
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public WVKEVWTACCJ.StaticNetSysReceiverDeps WBCJRZAEHOZ
			{
				[Cpp2IlInjected.Token(Token = "0x60007AD")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "5")]
				get
				{
					return default(WVKEVWTACCJ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps KWZYCCDKLZG
			{
				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : QKRAHFWMUMC.SWOGATQYSMU<LWWLBIHZXST>
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
				public AsyncTaskMethodBuilder<Result<object?, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public LWWLBIHZXST root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public Id32<HGRDVVOSLAK> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public PZJVNVFLVDC action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				private TaskAwaiter<Result<object?, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B46E50", Offset = "0x2B45850", VA = "0x182B46E50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B47100", Offset = "0x2B45B00", VA = "0x182B47100", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B43750", Offset = "0x2B42150", VA = "0x182B43750", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, LSNRXVKTUTI>> ETHZSTORPJA(LWWLBIHZXST a, Id32<HGRDVVOSLAK> clientId, PZJVNVFLVDC b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : HBRQOLRRFMG.SWOGATQYSMU<LWWLBIHZXST>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B432A0", Offset = "0x2B41CA0", VA = "0x182B432A0", Slot = "4")]
			public void VMZTZMGOPKI(LWWLBIHZXST a, Id32<HGRDVVOSLAK> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xF90830", Offset = "0xF8F230", VA = "0x180F90830", Slot = "5")]
			public Id32<HGRDVVOSLAK>? BFGCKXFYKLR(LWWLBIHZXST a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x2B42F60", Offset = "0x2B41960", VA = "0x182B42F60")]
			public Id32<TBNPHTPCKFD> KKQRWRQVRWA(LWWLBIHZXST a, Id32<HGRDVVOSLAK> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<TBNPHTPCKFD>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2B42ED0", Offset = "0x2B418D0", VA = "0x182B42ED0", Slot = "7")]
			public void HDDCMKRVSZN(LWWLBIHZXST a, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x2B42D30", Offset = "0x2B41730", VA = "0x182B42D30", Slot = "8")]
			public void GERGMYXIDCJ(LWWLBIHZXST a, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x2B42E90", Offset = "0x2B41890", VA = "0x182B42E90", Slot = "9")]
			public void GWNGUEHDASF(LWWLBIHZXST a, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2B430A0", Offset = "0x2B41AA0", VA = "0x182B430A0", Slot = "10")]
			public void NVGXJDHBZTN(LWWLBIHZXST a, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FPSIMBBGQNW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B42FC0", Offset = "0x2B419C0", VA = "0x182B42FC0", Slot = "11")]
			public void MAOFQTOBGJJ(LWWLBIHZXST a, Id32<HGRDVVOSLAK> clientId, Id32<TBNPHTPCKFD> objectId, FWGYWSERRIW? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x2B432D0", Offset = "0x2B41CD0", VA = "0x182B432D0", Slot = "12")]
			public Id32<HGRDVVOSLAK>? WCLPDTZCLVO(LWWLBIHZXST a, Id32<TBNPHTPCKFD> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B43330", Offset = "0x2B41D30", VA = "0x182B43330", Slot = "13")]
			public Id32<KGCIRRULOJF> WTREUOCVIWU(LWWLBIHZXST a, Id32<HGRDVVOSLAK> clientId, string b, object c, RBBGDVTZCDL d, LQEKLSRKXJV e)
			{
				return default(Id32<KGCIRRULOJF>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B430D0", Offset = "0x2B41AD0", VA = "0x182B430D0", Slot = "14")]
			public void QFHHBEAISFS(LWWLBIHZXST a, Id32<HGRDVVOSLAK> clientId, Id32<KGCIRRULOJF> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2B43270", Offset = "0x2B41C70", VA = "0x182B43270", Slot = "15")]
			public void SYZGFZNTDJM(LWWLBIHZXST a, Id32<HGRDVVOSLAK> clientId, Id32<KGCIRRULOJF> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2B42F60", Offset = "0x2B41960", VA = "0x182B42F60", Slot = "6")]
			private Id32<TBNPHTPCKFD> YQTQOOFBXTO(LWWLBIHZXST a, Id32<HGRDVVOSLAK> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<TBNPHTPCKFD>);
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
			public LWWLBIHZXST <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public Id32<TBNPHTPCKFD>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public KGZAGFPSONW deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private Id32<HGRDVVOSLAK> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private NSSIEQQRQOQ<LWWLBIHZXST, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private CBYJFRFNFDK<LWWLBIHZXST, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private WVKEVWTACCJ <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B46790", Offset = "0x2B45190", VA = "0x182B46790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B46DE0", Offset = "0x2B457E0", VA = "0x182B46DE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly WJKQCQJVCSQ<PZJVNVFLVDC, None, WVKEVWTACCJ, ActionDeps, WVKEVWTACCJ.StaticNetSysReceiverDeps, RootDeps, LWWLBIHZXST, Deps> YVECXWLEOJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly YKGWJMASUJS CYGOKTFQQPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAId32<HGRDVVOSLAK> AHJPUFETIQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private SOAField<HGRDVVOSLAK, None> MZKTVMLTAWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private SOAField<HGRDVVOSLAK, WVKEVWTACCJ> AMRDIKLOHWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Id32<HGRDVVOSLAK>? NJOZDTEMPLQ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate MLLHCNTMOEY
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xD14190", Offset = "0xD12B90", VA = "0x180D14190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x2B42970", Offset = "0x2B41370", VA = "0x182B42970")]
		public LWWLBIHZXST(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x2B422B0", Offset = "0x2B40CB0", VA = "0x182B422B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x2B42480", Offset = "0x2B40E80", VA = "0x182B42480")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> JJNSKKTPWVC(KGZAGFPSONW a, RegistryV2 b, Id32<TBNPHTPCKFD>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B426E0", Offset = "0x2B410E0", VA = "0x182B426E0")]
		private void VMZTZMGOPKI(Id32<HGRDVVOSLAK> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B42600", Offset = "0x2B41000", VA = "0x182B42600")]
		[CompilerGenerated]
		private Id32<TBNPHTPCKFD>? MQRFOZULVME([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class TRJNPZRYGVA : XMAUPUIQGZI.EDIRCJTODTF
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<IXGBGWAFRHJ> DeserializeCircuitsJunctionAsyncDelegate(WVKEVWTACCJ circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<IXGBGWAFRHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public TRJNPZRYGVA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public WVKEVWTACCJ circuitsManager;

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
			private TaskAwaiter<IXGBGWAFRHJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B45480", Offset = "0x2B43E80", VA = "0x182B45480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B45680", Offset = "0x2B44080", VA = "0x182B45680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate PNPPGICSJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly LifecycleDidInitializeDelegate? EZDDTYWXWXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly LifecycleWillDestroyDelegate? SZYSNWXVYJQ;

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B45120", Offset = "0x2B43B20", VA = "0x182B45120", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<IXGBGWAFRHJ> JXAYLNMNNNM(WVKEVWTACCJ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
		public void NPAUFLDLWVE(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x1022AA0", Offset = "0x10214A0", VA = "0x181022AA0", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x10BC520", Offset = "0x10BAF20", VA = "0x1810BC520", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B45290", Offset = "0x2B43C90", VA = "0x182B45290")]
		public TRJNPZRYGVA([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class NIYQVXSRWYY : SSKFXZAJUJK.EDIRCJTODTF
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate VQEUHQUVGGC GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<KUEIBMPATGS> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<MFIDGFMFPEG> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<SSKFXZAJUJK.EDIRCJTODTF.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<SSKFXZAJUJK.EDIRCJTODTF.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public NIYQVXSRWYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter<SSKFXZAJUJK.EDIRCJTODTF.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B456F0", Offset = "0x2B440F0", VA = "0x182B456F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B458E0", Offset = "0x2B442E0", VA = "0x182B458E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<MFIDGFMFPEG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public NIYQVXSRWYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			private TaskAwaiter<MFIDGFMFPEG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B45950", Offset = "0x2B44350", VA = "0x182B45950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B45B40", Offset = "0x2B44540", VA = "0x182B45B40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<KUEIBMPATGS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public NIYQVXSRWYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private TaskAwaiter<KUEIBMPATGS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B45BB0", Offset = "0x2B445B0", VA = "0x182B45BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B45DA0", Offset = "0x2B447A0", VA = "0x182B45DA0", Slot = "5")]
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
			public NIYQVXSRWYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B45E10", Offset = "0x2B44810", VA = "0x182B45E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B46000", Offset = "0x2B44A00", VA = "0x182B46000", Slot = "5")]
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
			public NIYQVXSRWYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B46070", Offset = "0x2B44A70", VA = "0x182B46070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B46260", Offset = "0x2B44C60", VA = "0x182B46260", Slot = "5")]
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
			public NIYQVXSRWYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B462D0", Offset = "0x2B44CD0", VA = "0x182B462D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B464C0", Offset = "0x2B44EC0", VA = "0x182B464C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetCV2DependenciesDelegate CHVKUTZSXHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomDataAsyncDelegate CVFLPZECTQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetSuperRoomDataAsyncDelegate QTMOSEVBJWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetRoomAssetDataAsyncDelegate BUNTXQNVDWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetPlayerSaveDataAsyncDelegate FKFGKLJEKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate ZXNTJYBPSYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly GetStaticCircuitsConfigAsyncDelegate WYONPBAXNPC;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public VQEUHQUVGGC VQEUHQUVGGC
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x12DAB80", Offset = "0x12D9580", VA = "0x1812DAB80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B43BE0", Offset = "0x2B425E0", VA = "0x182B43BE0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> RFGVKSPIKYL(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B43E00", Offset = "0x2B42800", VA = "0x182B43E00", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> XUMABOWBPMO(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B43CF0", Offset = "0x2B426F0", VA = "0x182B43CF0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<KUEIBMPATGS> RVCHJSGQBMF(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B438B0", Offset = "0x2B422B0", VA = "0x182B438B0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<MFIDGFMFPEG> HHLBTDSPWMK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B439C0", Offset = "0x2B423C0", VA = "0x182B439C0", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<SSKFXZAJUJK.EDIRCJTODTF.CircuitGraphToolMapping> KCXBQXUCSZZ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B43AD0", Offset = "0x2B424D0", VA = "0x182B43AD0", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> NNYOLVZAGDE(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F10", Offset = "0x2B42910", VA = "0x182B43F10")]
		public NIYQVXSRWYY(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class RMPSXCZNQZC : CV2Request.EDIRCJTODTF
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly CV2Request.EDIRCJTODTF UIOXUQVVXGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly GetCanSendRequestsDelegate SGUXQCXEEIY;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public RMPSXCZNQZC(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x12DAB80", Offset = "0x12D9580", VA = "0x1812DAB80", Slot = "4")]
		public bool CPQMNYHHFVS()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class AOPPUCGKAPB : FAUMPQIMSBQ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, CBUCXYTAOGI> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly TryReportErrToUserDelegate TXGIHXQJREY;

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2B412D0", Offset = "0x2B3FCD0", VA = "0x182B412D0")]
		public bool YDZRUFWJMFM([In] Result<None, CBUCXYTAOGI> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2B41300", Offset = "0x2B3FD00", VA = "0x182B41300")]
		public AOPPUCGKAPB([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2B412D0", Offset = "0x2B3FCD0", VA = "0x182B412D0", Slot = "4")]
		private bool WZKPXIHOOJH([In] Result<None, CBUCXYTAOGI> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class AUVGBZHCJZI : ZIVHGNLPODZ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate MHFTIKCGLDX CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly AUVGBZHCJZI UIOXUQVVXGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CurrentExecParamsDelegate? ORNLPWKCUVS;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public MHFTIKCGLDX PTDDOYEWTUU
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x12DAB80", Offset = "0x12D9580", VA = "0x1812DAB80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public AUVGBZHCJZI([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class RCINKSHOCQQ : DNRVFIQUYRJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly DNRVFIQUYRJ UIOXUQVVXGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly GetGameColorFromIdDelegate NWBWYTRYQNO;

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2B412D0", Offset = "0x2B3FCD0", VA = "0x182B412D0", Slot = "4")]
		public CircuitsColor MGUQZKDZTJA(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2B449C0", Offset = "0x2B433C0", VA = "0x182B449C0")]
		public RCINKSHOCQQ([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class VANNHDXDNLC : GPWQFBHBUSL
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
			public VANNHDXDNLC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x2B46530", Offset = "0x2B44F30", VA = "0x182B46530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x2B46720", Offset = "0x2B45120", VA = "0x182B46720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly IsStringPureAsyncDelegate ATYSDUOQXPV;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x2B48020", Offset = "0x2B46A20", VA = "0x182B48020", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> QGQWSSTVEXJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2B48160", Offset = "0x2B46B60", VA = "0x182B48160")]
		public VANNHDXDNLC([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class TCIXWBBNKHU : KXKYWNBNZAB
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate ZAMWBUKOEFT? GetNodeVisualizationConfigDelegate([In] Id128<SZWXGBXMTIF> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly KXKYWNBNZAB UIOXUQVVXGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly GetNodeVisualizationConfigDelegate JBYDLYGBSUK;

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2B412D0", Offset = "0x2B3FCD0", VA = "0x182B412D0")]
		public ZAMWBUKOEFT? HGRTZDYBDQI([In] Id128<SZWXGBXMTIF> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2B44F60", Offset = "0x2B43960", VA = "0x182B44F60")]
		public TCIXWBBNKHU([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2B412D0", Offset = "0x2B3FCD0", VA = "0x182B412D0", Slot = "4")]
		private ZAMWBUKOEFT NGZPBHCXCEU([In] Id128<SZWXGBXMTIF> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class KFOUWVCBGMR : HFOGEYCEIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2B41EC0", Offset = "0x2B408C0", VA = "0x182B41EC0", Slot = "4")]
		public CWAEHDAESDL XNBWYWJKXCR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KFOUWVCBGMR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class CZIIROPPHTR : HCKWIMUSVHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, bool> BSTHJQJLFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, float> LWOSUGXBJQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, double> CWPDPSITJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, int> RLILFCGBLRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, long> ZBTQXOPAHVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, string> CTOYIYLCIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly Dictionary<string, uint> RNIORCTWIWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly Dictionary<string, ulong> BSESADFPRCR;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2B41540", Offset = "0x2B3FF40", VA = "0x182B41540", Slot = "4")]
		public bool? UKVIGMFTOEG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2B415E0", Offset = "0x2B3FFE0", VA = "0x182B415E0")]
		public CZIIROPPHTR()
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
