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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x27FADB0", Offset = "0x27FA1B0", VA = "0x1827FADB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		internal sealed class UFKXZASBDNA : JUWRUXWLBDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UFKXZASBDNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00", Slot = "4")]
			public JUWRUXWLBDH FXGTGZNNVQN(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00", Slot = "5")]
			public JUWRUXWLBDH CAPMJDSZAKE(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00", Slot = "6")]
			public JUWRUXWLBDH QDTWGNCGXHG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			public void EQHRYZKONUP()
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
	public static class DJUQSKPKMUP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OFEBALTHFAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public RLVJBATMCRS HDUJPKLUQTT;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OFEBALTHFAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x27FAE30", Offset = "0x27FA230", VA = "0x1827FAE30")]
			internal IAPPTVDTDES YGPYXWKPJTG(GetNetworkObjectDelegate a)
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
			public PHMKKHZLINW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public GFLGYSGBDOL network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public RegistryV2? registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC8")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x27FFC90", Offset = "0x27FF090", VA = "0x1827FFC90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2800330", Offset = "0x27FF730", VA = "0x182800330", Slot = "5")]
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
			public GFLGYSGBDOL network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public PHMKKHZLINW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<LPULDJDRFFP>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private AUQKPBYPMDP <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x28003A0", Offset = "0x27FF7A0", VA = "0x1828003A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2800930", Offset = "0x27FFD30", VA = "0x182800930", Slot = "5")]
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
			public RLVJBATMCRS roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x28009A0", Offset = "0x27FFDA0", VA = "0x1828009A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2800EB0", Offset = "0x28002B0", VA = "0x182800EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27F7E90", Offset = "0x27F7290", VA = "0x1827F7E90")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? YRVPGEEKGCW([Optional] RLVJBATMCRS? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x27F7A80", Offset = "0x27F6E80", VA = "0x1827F7A80")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> PKGQYLXCDMP(GFLGYSGBDOL a, [Optional] PHMKKHZLINW? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x27F7C00", Offset = "0x27F7000", VA = "0x1827F7C00")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> PKGQYLXCDMP(GFLGYSGBDOL a, PHMKKHZLINW b, RegistryV2 c, Id32<LPULDJDRFFP>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x27F7930", Offset = "0x27F6D30", VA = "0x1827F7930")]
		public static (RuntimeFnRegistry, RuntimeFns) ABEZCXSQHNZ()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x27F7D90", Offset = "0x27F7190", VA = "0x1827F7D90")]
		public static (ExternalFnRegistry, ExternalFns) PRAMDKRHOUA()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x27F7A00", Offset = "0x27F6E00", VA = "0x1827F7A00")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static GFLGYSGBDOL CALWLWHJTXD(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class PUNIYVKYPRZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate IAPPTVDTDES CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public PUNIYVKYPRZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x27FF8A0", Offset = "0x27FECA0", VA = "0x1827FF8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x27FFC20", Offset = "0x27FF020", VA = "0x1827FFC20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly GFLGYSGBDOL NWYNWBEKMFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? SKWNMDBGHMF;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		private PUNIYVKYPRZ(GFLGYSGBDOL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x27FB210", Offset = "0x27FA610", VA = "0x1827FB210")]
		public static PUNIYVKYPRZ WOHFYTHXWCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x27FB2C0", Offset = "0x27FA6C0", VA = "0x1827FB2C0")]
		public PUNIYVKYPRZ ZITMLNKPLHQ(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27FB120", Offset = "0x27FA520", VA = "0x1827FB120")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> EQHRYZKONUP()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class GBHCTAMBKTP : AUQKPBYPMDP.ALXXNXZFOSL
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate GNWDQRYJEFF NewCircuitsLifecycleDelegate(AYAZJFNSIFY.ALXXNXZFOSL deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(AUQKPBYPMDP circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(AUQKPBYPMDP circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate PRTLVVTHJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate PUQVJJTCEWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate VUOVPJBWKXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate HRECHJTSNJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate ERKRQEDWXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate DVPISEFRUSE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int ZVIYHVBCGVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xFB7610", Offset = "0xFB6A10", VA = "0x180FB7610", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x27F8340", Offset = "0x27F7740", VA = "0x1827F8340", Slot = "6")]
		public void CKKEVZKOCQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x27F8370", Offset = "0x27F7770", VA = "0x1827F8370", Slot = "7")]
		public void FIBNMYMZWQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27F83A0", Offset = "0x27F77A0", VA = "0x1827F83A0", Slot = "5")]
		public GNWDQRYJEFF LUUWKQXAUXO(AYAZJFNSIFY.ALXXNXZFOSL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xBF7150", Offset = "0xBF6550", VA = "0x180BF7150", Slot = "8")]
		public void RMKERTAHZRT(AUQKPBYPMDP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBF7120", Offset = "0xBF6520", VA = "0x180BF7120", Slot = "9")]
		public void CUMSSDFNYBM(AUQKPBYPMDP a, VLXCXCSSZAI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x27F83D0", Offset = "0x27F77D0", VA = "0x1827F83D0")]
		public GBHCTAMBKTP([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly AFUEATRNTFO<GFLGYSGBDOL, GFLGYSGBDOL.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly BINWPURGJUI<GFLGYSGBDOL, GFLGYSGBDOL.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly AUQKPBYPMDP CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<FJSVDCFYEAW> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly GFLGYSGBDOL Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x27F7F80", Offset = "0x27F7380", VA = "0x1827F7F80")]
		public EVCreationResult(AFUEATRNTFO<GFLGYSGBDOL, GFLGYSGBDOL.MockStaticNetSysDeps> staticNetSys, BINWPURGJUI<GFLGYSGBDOL, GFLGYSGBDOL.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, AUQKPBYPMDP circuitsManager, Id32<FJSVDCFYEAW> clientId, GFLGYSGBDOL network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly AUQKPBYPMDP _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 BZNAMHDGIPX
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x27FAC00", Offset = "0x27FA000", VA = "0x1827FAC00")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request IGVOWTPJRQX
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x27FAC90", Offset = "0x27FA090", VA = "0x1827FAC90")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MCGUTYIFENK? HGSVFTBABQP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x27FACC0", Offset = "0x27FA0C0", VA = "0x1827FACC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public KXJXLLGOBKY? ETIPBFENWNV
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x27FAC30", Offset = "0x27FA030", VA = "0x1827FAC30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
		internal LimitedCircuits(AUQKPBYPMDP circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class HJSGWTQBRUR : PHMKKHZLINW
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ZXABQVGZVDZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public IAPPTVDTDES WQGSAHHLBJY;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ZXABQVGZVDZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			internal IAPPTVDTDES BGWSJPLTKSU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AYAZJFNSIFY.ALXXNXZFOSL IGMGNSJIQBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AUQKPBYPMDP.ALXXNXZFOSL ZPCSKYYTWMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HGEHYAJDPNG.ALXXNXZFOSL JOUDFCYGGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP> VRQYXACKGZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.ALXXNXZFOSL BWRJSSVQRZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public WTTLBDSHSXM YXHITRENJNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BSBAJWUIWZV NMRGTZVZSAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JKZPZKKOTQX VXKWKFOKFNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DYPXEDJBIXJ QVPTAXTVMFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public REEYAUJRNNP BVRLFSWXCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x27F97C0", Offset = "0x27F8BC0", VA = "0x1827F97C0")]
		private HJSGWTQBRUR(AYAZJFNSIFY.ALXXNXZFOSL a, AUQKPBYPMDP.ALXXNXZFOSL b, HGEHYAJDPNG.ALXXNXZFOSL c, RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP> d, CV2Request.ALXXNXZFOSL e, WTTLBDSHSXM f, BSBAJWUIWZV g, JKZPZKKOTQX h, DYPXEDJBIXJ i, REEYAUJRNNP j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x27F8FC0", Offset = "0x27F83C0", VA = "0x1827F8FC0")]
		public static HJSGWTQBRUR? EFXOCBOUBSG(HGEHYAJDPNG.ALXXNXZFOSL cv2RootSysDeps, [Optional] AYAZJFNSIFY.ALXXNXZFOSL? a, [Optional] AUQKPBYPMDP.ALXXNXZFOSL? b, [Optional] RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>? reducerDeps, [Optional] CV2Request.ALXXNXZFOSL? c, [Optional] WTTLBDSHSXM? d, [Optional] BSBAJWUIWZV? e, [Optional] JKZPZKKOTQX? f, [Optional] DYPXEDJBIXJ? g, [Optional] REEYAUJRNNP? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x27F9310", Offset = "0x27F8710", VA = "0x1827F9310")]
		public static HJSGWTQBRUR QTPCNMCCWOW(IAPPTVDTDES a, [Optional] AYAZJFNSIFY.ALXXNXZFOSL? circuitsLifecycleDeps, [Optional] AUQKPBYPMDP.ALXXNXZFOSL? circuitsManagerDeps, [Optional] RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x27F9460", Offset = "0x27F8860", VA = "0x1827F9460")]
		public static HJSGWTQBRUR QXNGCHRBAXW(GetNetworkObjectDelegate a, [Optional] AYAZJFNSIFY.ALXXNXZFOSL? circuitsLifecycleDeps, [Optional] AUQKPBYPMDP.ALXXNXZFOSL? circuitsManagerDeps, [Optional] RJDGBEODRNE.GIAVPBUDCZA<ActionKind, VLXCXCSSZAI, AUQKPBYPMDP>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class PYCMVOOQLBW
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class SYKSUEBHFID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public GetNetworkObjectDelegate FZGWEASUYOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int GHXVBARXGLA;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public SYKSUEBHFID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x27FF5F0", Offset = "0x27FE9F0", VA = "0x1827FF5F0")]
			internal WBDRXWGHZKJ SQHULSQCLQQ(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x27FF660", Offset = "0x27FEA60", VA = "0x1827FF660")]
			internal WBDRXWGHZKJ[] SQNBIZJZVBZ(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			internal int ESLTNEKJZQX()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class SYFLWXHJVWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public DynamicEnvironmentNetworkId VHARLEXJTZY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public SYKSUEBHFID AAFJFKGKTGT;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public SYFLWXHJVWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x27FF540", Offset = "0x27FE940", VA = "0x1827FF540")]
			internal WBDRXWGHZKJ YUXXQMXMBUI(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly YJUHLGNCLGJ LNIFIMQIXYW;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x27FB400", Offset = "0x27FA800", VA = "0x1827FB400")]
		public static WBDRXWGHZKJ? DENPDIMUUTQ(Id32<LPULDJDRFFP>? networkObject, [Optional] JCTXLSMOAHC.SerializesIntoSavesDelegate? a, [Optional] JCTXLSMOAHC.SerializesIntoInventionsDelegate? b, [Optional] JCTXLSMOAHC.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x27FB420", Offset = "0x27FA820", VA = "0x1827FB420")]
		public static IAPPTVDTDES? YDFNFGASYBJ(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] RWPWJSQETXX? b, [Optional] BGVXMUJRESR? c, [Optional] FIADIHRJNGJ? d, [Optional] RLVJBATMCRS? e, int f = 300000, bool g = false, bool h = false, [Optional] TNQBFZGPRNT? i, [Optional] KLDEYUYBTMR? j, [Optional] KCXVZIKDHAS? k, [Optional] HYYYWFLZLHT? l, [Optional] JDFNNTYATAS? m, [Optional] AQRQGKSRGAR? n, [Optional] TKWDIMFKAOX.ALXXNXZFOSL? o, [Optional] EqualsNodeV2.ALXXNXZFOSL? p, [Optional] MBZVONPYOWB? q, [Optional] IAPPTVDTDES.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] IAPPTVDTDES.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] IAPPTVDTDES.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] IAPPTVDTDES.GetLocalRoomIdDelegate? u, [Optional] IAPPTVDTDES.GetLocalSubroomIdDelegate? v, [Optional] IAPPTVDTDES.GetSubroomIdsForLocalRoomDelegate? w, [Optional] IAPPTVDTDES.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] IAPPTVDTDES.SaveRoomOnPlayerBehalfDelegate? z, [Optional] IAPPTVDTDES.ReportCloudDataLedgerChangedDelegate? ba, [Optional] IAPPTVDTDES.GetColorNameByIdDelegate? bb, [Optional] IAPPTVDTDES.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] IAPPTVDTDES.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] IAPPTVDTDES.GetTaggableNameFromSignalDelegate? be, [Optional] IAPPTVDTDES.GetAudioNameFromSignalDelegate? bf, [Optional] IAPPTVDTDES.GetDestinationNameFromSignalDelegate? bg, [Optional] IAPPTVDTDES.GetPlayerEventNameFromSignalDelegate? bh, [Optional] IAPPTVDTDES.GetRoomKeyNameFromSignalDelegate? bi, [Optional] IAPPTVDTDES.GetRewardNameFromSignalDelegate? bj, [Optional] IAPPTVDTDES.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] IAPPTVDTDES.ReportPreloadedAudioChangedDelegate? bl, [Optional] IAPPTVDTDES.ReportRewardDataChangedDelegate? bm, [Optional] IAPPTVDTDES.GetConsumableNameFromSignalDelegate? bn, [Optional] IAPPTVDTDES.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] IAPPTVDTDES.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] IAPPTVDTDES.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] IAPPTVDTDES.GetInventoryItemNameFromSignalDelegate? br, [Optional] IAPPTVDTDES.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] IAPPTVDTDES.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] IAPPTVDTDES.GetRoomOfferNameFromSignalDelegate? bu, [Optional] IAPPTVDTDES.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] IAPPTVDTDES.GetObjectIdFromCreationObjectDelegate? bw, [Optional] IAPPTVDTDES.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] IAPPTVDTDES.GetCostInBytesDelegate? by, [Optional] IAPPTVDTDES.GetAvatarItemNameFromSignalDelegate? bz, [Optional] IAPPTVDTDES.PersistenceViewExistsAsReplicatorWithGraphDelegate? ca, [Optional] IAPPTVDTDES.DownloadCircuitTemplateRootDataDelegate? cb, [Optional] IAPPTVDTDES.GetDiscoverySectionNameFromSignalDelegate? cc, [Optional] IAPPTVDTDES.GetStoreItemNameFromSignalDelegate? cd, [Optional] IAPPTVDTDES.GetBodyPartNameFromSignalDelegate? ce, [Optional] IAPPTVDTDES.GetDependenciesForGraphInstanceDelegate? cf, [Optional] IAPPTVDTDES.GetAllDependenciesForEnvironmentDelegate? cg, [Optional] IAPPTVDTDES.GetPlayerAccountNameFromSignalDelegate? ch, [Optional] IAPPTVDTDES.GetRecNetImageNameFromSignalDelegate? ci, [Optional] IAPPTVDTDES.GetRecNetMeshNameFromSignalDelegate? cj, [Optional] LogDeps? ck, [Optional] IAPPTVDTDES.IsFunctionValidForAIDelegate? cl, [Optional] IAPPTVDTDES.GetAIFunctionNameFromSignalDelegate? cm)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<LPULDJDRFFP>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class PXHNFXIFTJJ : KCXVZIKDHAS
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly PXHNFXIFTJJ LVYKDVFRYUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly GetLocalPlayerDelegate? PAJMPIGIYOO;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x27FB310", Offset = "0x27FA710", VA = "0x1827FB310", Slot = "4")]
		public (BILRNMKXHUH, BILRNMKXHUH, BILRNMKXHUH, BILRNMKXHUH, BILRNMKXHUH) ONRNTUZJVLD(object a)
		{
			return default((BILRNMKXHUH, BILRNMKXHUH, BILRNMKXHUH, BILRNMKXHUH, BILRNMKXHUH));
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x27FB2E0", Offset = "0x27FA6E0", VA = "0x1827FB2E0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "6")]
		public bool TJTYNZBKWRC(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xB04860", Offset = "0xB03C60", VA = "0x180B04860", Slot = "7")]
		public string XHULETXXDPM(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public PXHNFXIFTJJ([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class JCTXLSMOAHC : WBDRXWGHZKJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(JCTXLSMOAHC self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(JCTXLSMOAHC self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(JCTXLSMOAHC self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly SerializesIntoSavesDelegate YVLRNURXCQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoInventionsDelegate GPSYAVDYPKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly CanPublishInInventionsDelegate NQBUHMXXESV;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private GCSDMJYCIWL? YNIBPDZIFGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId RMUVRONFQAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCDA830", Offset = "0xCD9C30", VA = "0x180CDA830", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool RQKMZNSSCHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x27FABD0", Offset = "0x27F9FD0", VA = "0x1827FABD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool XHCKXIBWXIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x27FABA0", Offset = "0x27F9FA0", VA = "0x1827FABA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool IVNCOBKVWOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x27FAB70", Offset = "0x27F9F70", VA = "0x1827FAB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IZIXSIHXHSW? SGPUHFIPQSB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<LPULDJDRFFP>? DMEFDMDQUED
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x27FAA20", Offset = "0x27F9E20", VA = "0x1827FAA20", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x27FA4D0", Offset = "0x27F98D0", VA = "0x1827FA4D0", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(YJUHLGNCLGJ e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120", Slot = "13")]
		public void Bind(GCSDMJYCIWL controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x27FAAC0", Offset = "0x27F9EC0", VA = "0x1827FAAC0")]
		private JCTXLSMOAHC(Id32<LPULDJDRFFP>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x27FA570", Offset = "0x27F9970", VA = "0x1827FA570")]
		public static JCTXLSMOAHC? New(Id32<LPULDJDRFFP>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class CFQJUAKHTYI : TNQBFZGPRNT
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
		public static readonly CFQJUAKHTYI LVYKDVFRYUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly RoundToDecimalPlaceDelegate? TLXMXLQQDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly TruncateToDecimalPlaceDelegate? QLUPBYSVHLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly CircuitsColorLerpDelegate? XGIESNJYLIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorInverseLerpDelegate? EHQIMEBAKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsMtx4x4GetPositionDelegate? VKRDPKKHLFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetRotationDelegate? PFNQZXMSYWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4InverseDelegate? FLTDIRUKJUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4MultiplyDelegate? DSLJDOIEPQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? WXBHEYADQGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsQuatDotDelegate? HBOOKVNOYOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatFromAngleAxisDelegate? WNZEWRSQHXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? TBSDMJMXCSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromFromToRotationDelegate? JXSVLPBISYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromLookRotationDelegate? OWFJKIZFSGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? DNAMKBCIYKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatInverseDelegate? VZVECBNXJCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatLerpDelegate? LWNCPPCVHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpUnclampedDelegate? UDKJAVTWVLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseLerpDelegate? REUCAEUATRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatMultiplyDelegate? EOMUTJCNSIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatNormalizeDelegate? HPYCTXYEAVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatRotateTowardsDelegate? WNLLQBSEUOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateVectorDelegate? ROMGNOVQMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatSlerpDelegate? SWOBFKALAJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatToAngleAxisDelegate? IHWHEBFOJTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToEulerAnglesDelegate? FVJDVINCDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsVec3AddDelegate? ZBPCSOJSNVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? NDOBZLNWGGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? WGIBIYUIIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3CrossDelegate? XYOTZQGTISA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3DotDelegate? QOHNUDLFJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3AngleDelegate? QOTGEVYPPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3GetMagnitudeDelegate? RIIQUFEHRLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3LerpDelegate? EXPTTHLRMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpUnclampedDelegate? LQERQCXWNIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3InverseLerpDelegate? ATRDITDOWON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3MoveTowardsDelegate? RDDJCDHKSQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3NegateDelegate? KQRYCCJZQNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NormalizeDelegate? DVKGXEAMXGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3ProjectDelegate? DXDCWVTINQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? ABKFQKAMYFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ScaleDelegate? HXGCHLXPGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3SmoothDampDelegate? GLFFAKBAYCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SubtractDelegate? XKHEJYEJETC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SlerpDelegate? YVXVSSIXYOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3TransformDelegate? RGWVFINLBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3InverseTransformDelegate? KLTCBMSFWQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly RealtimeSinceStartupDelegate? HRSXJDAVJKZ;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x27F65F0", Offset = "0x27F59F0", VA = "0x1827F65F0")]
		public CFQJUAKHTYI([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x27F4C10", Offset = "0x27F4010", VA = "0x1827F4C10")]
		public float FEWHIVKBQUN([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x27F55D0", Offset = "0x27F49D0", VA = "0x1827F55D0")]
		public float ORYDBIZYDZJ([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x27F61E0", Offset = "0x27F55E0", VA = "0x1827F61E0")]
		public CircuitsColor WQEVPSZFVYQ([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x27F5C20", Offset = "0x27F5020", VA = "0x1827F5C20")]
		public float YYYXSRTYEDY([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x27F52B0", Offset = "0x27F46B0", VA = "0x1827F52B0")]
		public CircuitsVec3 IGGNQSAVFTU([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x27F44B0", Offset = "0x27F38B0", VA = "0x1827F44B0")]
		public CircuitsQuat ADTOJOADHQX([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x27F4CA0", Offset = "0x27F40A0", VA = "0x1827F4CA0")]
		public CircuitsMtx4x4 DQJJYGXKKFP([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x27F50F0", Offset = "0x27F44F0", VA = "0x1827F50F0")]
		public CircuitsMtx4x4 GHRCSKBKUPZ([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x27F5E40", Offset = "0x27F5240", VA = "0x1827F5E40")]
		public CircuitsMtx4x4 UFBPMIRHJVZ([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x27F5720", Offset = "0x27F4B20", VA = "0x1827F5720")]
		public float YITIFXJLPRC([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x27F5040", Offset = "0x27F4440", VA = "0x1827F5040")]
		public CircuitsQuat GHGDBJAWNXP(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x27F5210", Offset = "0x27F4610", VA = "0x1827F5210")]
		public CircuitsQuat ZJVMMWVCGDA([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x27F45E0", Offset = "0x27F39E0", VA = "0x1827F45E0")]
		public CircuitsQuat EDIUZAYFBQW([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x27F49E0", Offset = "0x27F3DE0", VA = "0x1827F49E0")]
		public CircuitsQuat JCNPGZFTJWE([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x27F55F0", Offset = "0x27F49F0", VA = "0x1827F55F0")]
		public CircuitsQuat WPGFDZWWUBJ([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x27F5F00", Offset = "0x27F5300", VA = "0x1827F5F00")]
		public CircuitsQuat YOFOGRWEGRW([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x27F5A10", Offset = "0x27F4E10", VA = "0x1827F5A10")]
		public CircuitsQuat YOEEYINSVFF([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x27F4B00", Offset = "0x27F3F00", VA = "0x1827F4B00")]
		public float CYNUEDPWWSO([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x27F5160", Offset = "0x27F4560", VA = "0x1827F5160")]
		public CircuitsQuat GJAJNOTTTBX([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x27F4F10", Offset = "0x27F4310", VA = "0x1827F4F10")]
		public CircuitsQuat RBLSXHJMANK([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x27F5740", Offset = "0x27F4B40", VA = "0x1827F5740")]
		public CircuitsQuat UJLSMJVZXRM([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x27F4760", Offset = "0x27F3B60", VA = "0x1827F4760")]
		public CircuitsVec3 AOIRFITVHEF([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x27F5950", Offset = "0x27F4D50", VA = "0x1827F5950")]
		public CircuitsQuat RIRWZGBYJML([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x27F5D80", Offset = "0x27F5180", VA = "0x1827F5D80")]
		public void TTRZVUBOAQK([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x27F4700", Offset = "0x27F3B00", VA = "0x1827F4700")]
		public CircuitsVec3 AOIAGCLDUGF([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x27F53B0", Offset = "0x27F47B0", VA = "0x1827F53B0")]
		public CircuitsVec3 ILPQTJCQXFG([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x27F6030", Offset = "0x27F5430", VA = "0x1827F6030")]
		public CircuitsVec3 VAUQDSKLWUS([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x27F5690", Offset = "0x27F4A90", VA = "0x1827F5690")]
		public CircuitsVec3 NREYAAUKFDB([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x27F4500", Offset = "0x27F3900", VA = "0x1827F4500")]
		public CircuitsVec3 AEYKTVPNRKL([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x27F5700", Offset = "0x27F4B00", VA = "0x1827F5700")]
		public float NSKNCRSRIBO([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x27F5020", Offset = "0x27F4420", VA = "0x1827F5020")]
		public float IBRBJPGIQIY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x27F5E20", Offset = "0x27F5220", VA = "0x1827F5E20")]
		public float TYRRXZDQUCP([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x27F4A90", Offset = "0x27F3E90", VA = "0x1827F4A90")]
		public CircuitsVec3 CVTIRTUHRDO([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x27F4C30", Offset = "0x27F4030", VA = "0x1827F4C30")]
		public CircuitsVec3 DKLOJMHOSYT([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x27F5800", Offset = "0x27F4C00", VA = "0x1827F5800")]
		public float PRTGYIJZBMW([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x27F4FB0", Offset = "0x27F43B0", VA = "0x1827F4FB0")]
		public CircuitsVec3 FWMDLJYXBSI([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x27F4D10", Offset = "0x27F4110", VA = "0x1827F4D10")]
		public CircuitsVec3 EBZVJOPFBBV([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x27F60A0", Offset = "0x27F54A0", VA = "0x1827F60A0")]
		public CircuitsVec3 VETWEEMHIMM([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x27F4570", Offset = "0x27F3970", VA = "0x1827F4570")]
		public CircuitsVec3 AGIXTRDRTLM([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x27F5420", Offset = "0x27F4820", VA = "0x1827F5420")]
		public CircuitsVec3 KKDORVOVYAX([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x27F4B30", Offset = "0x27F3F30", VA = "0x1827F4B30")]
		public CircuitsVec3 DEGLLGLVDHH([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x27F5830", Offset = "0x27F4C30", VA = "0x1827F5830")]
		public CircuitsVec3 QCLQZNZMNRH([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x27F5D10", Offset = "0x27F5110", VA = "0x1827F5D10")]
		public CircuitsVec3 TNZCOWYPCUJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x27F5B40", Offset = "0x27F4F40", VA = "0x1827F5B40")]
		public CircuitsVec3 RQTINMZALVJ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x27F62A0", Offset = "0x27F56A0", VA = "0x1827F62A0")]
		public CircuitsVec3 YBGVCKBZJWT([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x27F6170", Offset = "0x27F5570", VA = "0x1827F6170")]
		public CircuitsVec3 WECRXTNTLIB([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x27F5310", Offset = "0x27F4710", VA = "0x1827F5310", Slot = "50")]
		public Task IGIBMXJMWZB(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "51")]
		public void XRYJOUAMOVN([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x27F4E40", Offset = "0x27F4240", VA = "0x1827F4E40", Slot = "52")]
		public KWWIFHUGOFY<PXOECLXUDAS> EMUXLWFJPNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x27F5EB0", Offset = "0x27F52B0", VA = "0x1827F5EB0", Slot = "53")]
		public KWWIFHUGOFY<PXOECLXUDAS> UIFCBRMOBQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x27F4EF0", Offset = "0x27F42F0", VA = "0x1827F4EF0", Slot = "54")]
		public float EUKRCUCPRNS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x27F4C10", Offset = "0x27F4010", VA = "0x1827F4C10", Slot = "4")]
		private float DKHILWTEWLN([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x27F55D0", Offset = "0x27F49D0", VA = "0x1827F55D0", Slot = "5")]
		private float MZNLALRDDMF([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x27F5C50", Offset = "0x27F5050", VA = "0x1827F5C50", Slot = "6")]
		private CircuitsColor SXUEYOLEENM([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x27F5C20", Offset = "0x27F5020", VA = "0x1827F5C20", Slot = "7")]
		private float SUWTOQIJGSQ([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x27F5570", Offset = "0x27F4970", VA = "0x1827F5570", Slot = "8")]
		private CircuitsVec3 MZIUHSMHKRO([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x27F6380", Offset = "0x27F5780", VA = "0x1827F6380", Slot = "9")]
		private CircuitsQuat YXEXTWXJHBX([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x27F4DE0", Offset = "0x27F41E0", VA = "0x1827F4DE0", Slot = "10")]
		private CircuitsMtx4x4 EIJRMSBTEVV([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x27F4E90", Offset = "0x27F4290", VA = "0x1827F4E90", Slot = "11")]
		private CircuitsMtx4x4 ETSCYHFCZNL([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x27F5DC0", Offset = "0x27F51C0", VA = "0x1827F5DC0", Slot = "12")]
		private CircuitsMtx4x4 TXLVDZADIDX([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x27F5720", Offset = "0x27F4B20", VA = "0x1827F5720", Slot = "13")]
		private float OGRXGBABNLY([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x27F5040", Offset = "0x27F4440", VA = "0x1827F5040", Slot = "14")]
		private CircuitsQuat OZURNSOLTSH(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x27F5210", Offset = "0x27F4610", VA = "0x1827F5210", Slot = "15")]
		private CircuitsQuat GVFBWEGITBK([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x27F45E0", Offset = "0x27F39E0", VA = "0x1827F45E0", Slot = "16")]
		private CircuitsQuat ALQPBARRYVG([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x27F49E0", Offset = "0x27F3DE0", VA = "0x1827F49E0", Slot = "17")]
		private CircuitsQuat CJUYCEZBZCO([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x27F55F0", Offset = "0x27F49F0", VA = "0x1827F55F0", Slot = "18")]
		private CircuitsQuat NLZEACNYNVL([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x27F5F00", Offset = "0x27F5300", VA = "0x1827F5F00", Slot = "19")]
		private CircuitsQuat UIPRNFABKEG([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x27F5A10", Offset = "0x27F4E10", VA = "0x1827F5A10", Slot = "20")]
		private CircuitsQuat RKYNHBMCXMB([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x27F4B00", Offset = "0x27F3F00", VA = "0x1827F4B00", Slot = "21")]
		private float GAPACXQMAOY([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x27F5160", Offset = "0x27F4560", VA = "0x1827F5160", Slot = "22")]
		private CircuitsQuat HRUFDPKKCZF([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x27F4F10", Offset = "0x27F4310", VA = "0x1827F4F10", Slot = "23")]
		private CircuitsQuat FCXIZYSHUQK([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x27F5740", Offset = "0x27F4B40", VA = "0x1827F5740", Slot = "24")]
		private CircuitsQuat OTHXAMTCTJS([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x27F4BA0", Offset = "0x27F3FA0", VA = "0x1827F4BA0", Slot = "25")]
		private CircuitsVec3 DEXTBAFEOHV([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x27F5950", Offset = "0x27F4D50", VA = "0x1827F5950", Slot = "26")]
		private CircuitsQuat ZOVSVFHKUDH([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x27F5D80", Offset = "0x27F5180", VA = "0x1827F5D80", Slot = "27")]
		private void XTYYWYFHCLC([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x27F5CB0", Offset = "0x27F50B0", VA = "0x1827F5CB0", Slot = "28")]
		private CircuitsVec3 TFINSOKCYVR([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x27F4900", Offset = "0x27F3D00", VA = "0x1827F4900", Slot = "29")]
		private CircuitsVec3 BEMTEOMHIGC([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x27F5500", Offset = "0x27F4900", VA = "0x1827F5500", Slot = "30")]
		private CircuitsVec3 MVMILGIZJZW([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x27F5AD0", Offset = "0x27F4ED0", VA = "0x1827F5AD0", Slot = "31")]
		private CircuitsVec3 RMFQYISJNAN([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x27F4690", Offset = "0x27F3A90", VA = "0x1827F4690", Slot = "32")]
		private CircuitsVec3 AMECWCMJQHD([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x27F5FC0", Offset = "0x27F53C0", VA = "0x1827F5FC0", Slot = "33")]
		private CircuitsVec3 USCQOGMJEZD([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x27F4970", Offset = "0x27F3D70", VA = "0x1827F4970", Slot = "34")]
		private CircuitsVec3 BHFFUXFHBDR([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x27F5700", Offset = "0x27F4B00", VA = "0x1827F5700", Slot = "35")]
		private float RCTLJDUNRWG([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x27F5020", Offset = "0x27F4420", VA = "0x1827F5020", Slot = "36")]
		private float GBNOTTPDOLU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x27F5E20", Offset = "0x27F5220", VA = "0x1827F5E20", Slot = "37")]
		private float WQPRAKBIDZH([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x27F58E0", Offset = "0x27F4CE0", VA = "0x1827F58E0", Slot = "38")]
		private CircuitsVec3 QDQYPJTBJQO([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x27F6100", Offset = "0x27F5500", VA = "0x1827F6100", Slot = "39")]
		private CircuitsVec3 VVTOXALLLHP([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x27F5800", Offset = "0x27F4C00", VA = "0x1827F5800", Slot = "40")]
		private float TLPWITUKSJW([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x27F5490", Offset = "0x27F4890", VA = "0x1827F5490", Slot = "41")]
		private CircuitsVec3 KXWGHPSRZXI([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x27F63D0", Offset = "0x27F57D0", VA = "0x1827F63D0", Slot = "42")]
		private CircuitsVec3 ZZCEHNOXSON([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x27F6240", Offset = "0x27F5640", VA = "0x1827F6240", Slot = "43")]
		private CircuitsVec3 XKPKQIRVSBE([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x27F4D70", Offset = "0x27F4170", VA = "0x1827F4D70", Slot = "44")]
		private CircuitsVec3 EEFJKOBNZVS([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x27F6310", Offset = "0x27F5710", VA = "0x1827F6310", Slot = "45")]
		private CircuitsVec3 YTGIYESULWR([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x27F5340", Offset = "0x27F4740", VA = "0x1827F5340", Slot = "46")]
		private CircuitsVec3 IIZXZAMHIAT([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x27F4840", Offset = "0x27F3C40", VA = "0x1827F4840", Slot = "47")]
		private CircuitsVec3 BCUBEZZAQSL([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x27F47D0", Offset = "0x27F3BD0", VA = "0x1827F47D0", Slot = "48")]
		private CircuitsVec3 AQOHCFXFCGL([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x27F5BB0", Offset = "0x27F4FB0", VA = "0x1827F5BB0", Slot = "49")]
		private CircuitsVec3 SBDQTWAFTWJ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class XVGMTMNPXUY : BYUTDJSJABT
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1021B40", Offset = "0x1020F40", VA = "0x181021B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1108B00", Offset = "0x1107F00", VA = "0x181108B00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2802000", Offset = "0x2801400", VA = "0x182802000")]
		public XVGMTMNPXUY(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class ZPBXVQGRXEA : KLDEYUYBTMR
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(QVMTSXADWLM e, ZCXIDDXNHTD invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly ZPBXVQGRXEA LVYKDVFRYUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly GetCircuitsColorFromColorIndexDelegate? VHVJWFWDCWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? JIGLYBQJQFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly InvisibleCollisionSetEnabledDelegate? IADADGXVSGM;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xD92220", Offset = "0xD91620", VA = "0x180D92220")]
		public ZPBXVQGRXEA([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2803ED0", Offset = "0x28032D0", VA = "0x182803ED0", Slot = "4")]
		public CircuitsColor FARBAUSWIQE(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2803F20", Offset = "0x2803320", VA = "0x182803F20")]
		public int ZXVSRXUXSKA([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2803F20", Offset = "0x2803320", VA = "0x182803F20", Slot = "5")]
		private int NHGGASPHQUV([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class HUZNOQWMCAT : NYLFNCOLEFS
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class IAABJQAJNHW
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid BEHUPKBBWZS
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long YUXFVRBGNGZ
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int FBDJYCBBUDZ
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool VHLUXQMZGCC
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x17F0050", Offset = "0x17EF450", VA = "0x1817F0050")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool LERADAFZDVY
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x17EFD70", Offset = "0x17EF170", VA = "0x1817EFD70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool CNZAKHJXBLN
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x27F9E00", Offset = "0x27F9200", VA = "0x1827F9E00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x27F9E20", Offset = "0x27F9220", VA = "0x1827F9E20")]
			public IAABJQAJNHW(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Dictionary<Id128<FRZIQAPUPIV>, IAABJQAJNHW> LFAYBNHLOUV;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x27F9B90", Offset = "0x27F8F90", VA = "0x1827F9B90")]
		public bool TPUHNNSKBSQ([In] Id128<FRZIQAPUPIV> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x27F9AC0", Offset = "0x27F8EC0", VA = "0x1827F9AC0")]
		public void XDXYRZHZMGA([In] Id128<FRZIQAPUPIV> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x27F9CA0", Offset = "0x27F90A0", VA = "0x1827F9CA0")]
		public void XDXYRZHZMGA([In] Id128<FRZIQAPUPIV> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x27F99A0", Offset = "0x27F8DA0", VA = "0x1827F99A0")]
		public void PAPVJUSXSMN([In] Id128<FRZIQAPUPIV> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x27F9940", Offset = "0x27F8D40", VA = "0x1827F9940")]
		public void CWEPSEPSRBQ([In] Id128<FRZIQAPUPIV> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x27F98B0", Offset = "0x27F8CB0", VA = "0x1827F98B0")]
		public bool VHLUXQMZGCC([In] Id128<FRZIQAPUPIV> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x27F9D80", Offset = "0x27F9180", VA = "0x1827F9D80")]
		public HUZNOQWMCAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x27F9B90", Offset = "0x27F8F90", VA = "0x1827F9B90", Slot = "4")]
		private bool MEOIEPFYVYN([In] Id128<FRZIQAPUPIV> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x27F9AC0", Offset = "0x27F8EC0", VA = "0x1827F9AC0", Slot = "5")]
		private void LLJNRRYDZWV([In] Id128<FRZIQAPUPIV> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x27F99A0", Offset = "0x27F8DA0", VA = "0x1827F99A0", Slot = "6")]
		private void JNCSPNECVHS([In] Id128<FRZIQAPUPIV> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x27F9940", Offset = "0x27F8D40", VA = "0x1827F9940", Slot = "7")]
		private void EDSXJIUBCJR([In] Id128<FRZIQAPUPIV> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x27F98B0", Offset = "0x27F8CB0", VA = "0x1827F98B0", Slot = "8")]
		private bool CPHQZGYPRJD([In] Id128<FRZIQAPUPIV> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class JBHXJPZEZXC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x27FA0A0", Offset = "0x27F94A0", VA = "0x1827FA0A0")]
		public static LogDeps AKMPJTHXUXF()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class JUFCWQZGAVD : MeshLibrary.ALXXNXZFOSL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "4")]
		public byte[]? HPREVTPJCDY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
		public void CGPQIXEPUGB(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public JUFCWQZGAVD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class ZLXEEFROYSC : RWPWJSQETXX
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
		public delegate void ConfigureAttachedObjectDelegate(LDQXCEYRGBB controlPanel, COLFGFXWPZV staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<VXBDDQUHKWU> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, RAGLFGQXJZI>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, RAGLFGQXJZI>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, RAGLFGQXJZI>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, RAGLFGQXJZI>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public Task<Result<MultiResult, RAGLFGQXJZI>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private TaskAwaiter<Result<MultiResult, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2800F20", Offset = "0x2800320", VA = "0x182800F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x28011E0", Offset = "0x28005E0", VA = "0x1828011E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private TaskAwaiter<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2801250", Offset = "0x2800650", VA = "0x182801250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2801510", Offset = "0x2800910", VA = "0x182801510", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public Task<Result<None, RAGLFGQXJZI>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<Result<None, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2801580", Offset = "0x2800980", VA = "0x182801580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2801840", Offset = "0x2800C40", VA = "0x182801840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<string, EnumChoiceData> KXZMFNWRYUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<int, string> TZMXDDUZGQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly List<object> QCTEFGRUFAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<Guid> DBPKYQMGWQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly CanLocalPlayerCreateCurrencyDelegate JJNEWPERMXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ShowRoomCurrencyCreationUIDelegate TPHEDIDQIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly GetAudioClipOptionsDelegate YGSBIHLINLZ;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly IReadOnlyDictionary<Guid, int> AQQLFNSRPJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly GetAudioClipGuidToIndexMapDelegate IQASADQSDSR;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly IReadOnlyDictionary<int, Guid> JGPBISPEWJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly GetAudioClipIndexToGuidMapDelegate XBATHFIQGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAllAudioClipOptionsDelegate BEJFFYTDOCK;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<Guid, int> JLFJUYGNSTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate YPYJYHCWRFY;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly IReadOnlyDictionary<int, Guid> NTOMUUETZQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate IBBGDKLRKRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly PlayAudioPreviewDelegate ZJJGDHBAQWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly StopAudioPreviewDelegate BDMVRKJMPAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly SubscriptionIsActiveDelegate ECKKBUANEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate FPSTXNKSENR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Dictionary<string, EnumChoiceData> XSXZQVAYXJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly ShowQuickChatEditMenuDelegate SLYDHWLMFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly ConfigureAttachedObjectDelegate OLBNWIWBROK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly DisplayInvalidNameErrorMessageDelegate AYYOYGOPCYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly IsStringPureDelegate CZEULLTFYTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly TryGetSpecificChipConfigSummaryDelegate UJAMUAQVLYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly ReleaseIconIdDelegate XXPXHXJZIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReportCreationErrorToUserAsyncDelegate SPUJTNYXCSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 VLAEMNWDSPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 VLFLJUQBCAZ;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment LQISLJELWZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool RNIIXKQBSVU
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> AEYNZQPKNFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> LJPZKTDJXRO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> BJMUHSFGFKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> IUUHLOHCHAN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9C0", Offset = "0xAABDC0", VA = "0x180AAC9C0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion WRGKUFTINWH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4B00", Offset = "0xCF3F00", VA = "0x180CF4B00", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BZMCSQZMIJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xBBDC80", Offset = "0xBBD080", VA = "0x180BBDC80", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool NFSHFMVOLWO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x28025D0", Offset = "0x28019D0", VA = "0x1828025D0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ORGEUQZOZZV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2802970", Offset = "0x2801D70", VA = "0x182802970", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool FEJEKSORKGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xAB35B0", Offset = "0xAB29B0", VA = "0x180AB35B0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2802B20", Offset = "0x2801F20", VA = "0x182802B20")]
		public ZLXEEFROYSC([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x28026F0", Offset = "0x2801AF0", VA = "0x1828026F0", Slot = "9")]
		public bool MNHFUUEADRF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
		public static bool GUIAVDXSWIS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x28025E0", Offset = "0x28019E0", VA = "0x1828025E0", Slot = "10")]
		public bool JZGDGYPRVHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void NCMJWVVKBTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xBE5990", Offset = "0xBE4D90", VA = "0x180BE5990", Slot = "11")]
		public void OKWVVRPITNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2802320", Offset = "0x2801720", VA = "0x182802320")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> CZQXQCPTOMJ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2802350", Offset = "0x2801750", VA = "0x182802350", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> DALYRTQOYIM(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2802580", Offset = "0x2801980", VA = "0x182802580")]
		private static IReadOnlyDictionary<Guid, int> IYBAOKASGIZ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2802980", Offset = "0x2801D80", VA = "0x182802980", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> ZTZCZFFWYGA(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x28023C0", Offset = "0x28017C0", VA = "0x1828023C0")]
		private static IReadOnlyDictionary<int, Guid> EMIBKZGFZDL(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2802050", Offset = "0x2801450", VA = "0x182802050", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> BKUQYKTQXWA(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x28026C0", Offset = "0x2801AC0", VA = "0x1828026C0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> MNAADCMCCBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x27EC7C0", Offset = "0x27EBBC0", VA = "0x1827EC7C0", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> PGDCMMBGETR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2802670", Offset = "0x2801A70", VA = "0x182802670")]
		private static IReadOnlyDictionary<Guid, int> LCDEKLSHUKS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2802940", Offset = "0x2801D40", VA = "0x182802940", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> YCCUDAFJFIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2802260", Offset = "0x2801660", VA = "0x182802260", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> CBPETRKNQBX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private static void JRERPHYMOZJ(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2802450", Offset = "0x2801850", VA = "0x182802450", Slot = "18")]
		public void HVWGXHHWIWK(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private static void IIDIBKBBXUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x28027F0", Offset = "0x2801BF0", VA = "0x1828027F0", Slot = "19")]
		public void RVKMMEXHGGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
		private static bool CQFCVGSOHOS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2802820", Offset = "0x2801C20", VA = "0x182802820", Slot = "20")]
		public bool SDONKKNKBZL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
		public static bool NXICTQCRVWB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2802910", Offset = "0x2801D10", VA = "0x182802910", Slot = "21")]
		public bool XADPOFEKYNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2802610", Offset = "0x2801A10", VA = "0x182802610", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> KIUZVCKAMCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> LCCCGCMYUJV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> ZXRUROJZBWL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x28028E0", Offset = "0x2801CE0", VA = "0x1828028E0", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> WYMLAOWGTRQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> TWSCDFZCBSO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> WBEWGPBIBBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void OTQTQVQTQKY(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2802380", Offset = "0x2801780", VA = "0x182802380", Slot = "29")]
		public void DGXHGJTSZEX(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private static void XTVZFYLHJBY(LDQXCEYRGBB a, COLFGFXWPZV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2802850", Offset = "0x2801C50", VA = "0x182802850", Slot = "35")]
		public void TQYKGFGUVOF(LDQXCEYRGBB a, COLFGFXWPZV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "36")]
		public Dictionary<string, EnumChoiceData> VBIHCAEGUHV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "37")]
		public Dictionary<string, EnumChoiceData> ZVDWVBIABUI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private static void FFZHVRIIOEC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2802880", Offset = "0x2801C80", VA = "0x182802880")]
		private static Task<bool> VVFPCHTYXPE(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x28027B0", Offset = "0x2801BB0", VA = "0x1828027B0", Slot = "38")]
		public Task<bool> QOHJDBDMGGZ(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x28027E0", Offset = "0x2801BE0", VA = "0x1828027E0")]
		private static bool RARUUXORHKU(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2802410", Offset = "0x2801810", VA = "0x182802410", Slot = "39")]
		public bool FABDHAEEJDZ(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private static void LKJEFNXIROM(Id32<VXBDDQUHKWU> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2802640", Offset = "0x2801A40", VA = "0x182802640", Slot = "40")]
		public void KVJVQDWQZFV(Id32<VXBDDQUHKWU> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2802490", Offset = "0x2801890", VA = "0x182802490")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, RAGLFGQXJZI>> IMDYFUJSYXI(Task<Result<None, RAGLFGQXJZI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x28022C0", Offset = "0x28016C0", VA = "0x1828022C0", Slot = "41")]
		public Task<Result<None, RAGLFGQXJZI>> CFLRXJSFUZD(Task<Result<None, RAGLFGQXJZI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2802080", Offset = "0x2801480", VA = "0x182802080")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, RAGLFGQXJZI>> CBCEUGBJKSQ(Task<Result<MultiResult, RAGLFGQXJZI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2802290", Offset = "0x2801690", VA = "0x182802290", Slot = "42")]
		public Task<Result<MultiResult, RAGLFGQXJZI>> CFLRXJSFUZD(Task<Result<MultiResult, RAGLFGQXJZI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2802170", Offset = "0x2801570", VA = "0x182802170")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> CBHLRMVGUDZ(Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x28022F0", Offset = "0x28016F0", VA = "0x1828022F0", Slot = "43")]
		public Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> CFLRXJSFUZD(Task<Result<Id32<RWZXBCGZCJT>, RAGLFGQXJZI>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class FIADIHRJNGJ : UZUIWZWPYWU
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(YJUHLGNCLGJ e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private InteropDelegate? FTUBNWNTJIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly InteropDelegate ADSIYEXSZOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate GWBHSDLJTUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? JQZKHZDYNUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InvokeStudioFunctionDelegate? VSXLSBLTYIL;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "5")]
		public LegacyCV2Result<None> NJXXEWFEBRJ(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0")]
		private static LegacyCV2Result<None> Default(YJUHLGNCLGJ _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "6")]
		public LegacyCV2Result<None> BZMYEKZIXAC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "7")]
		public LegacyCV2Result<None> OHWPQFEYXCP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "8")]
		public LegacyCV2Result<None> BUNOBSIKBMG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "9")]
		public LegacyCV2Result<None> EVCASEENFZI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "15")]
		public LegacyCV2Result<None> DJAQIMFBROX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TCGGKLJNLDX(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FIRKIDZWURF(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SIZLXWVSTSE(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VFHJLOUSGON(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NOYSUPDZYZM(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LPZIDDNGOEM(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KBVONUBDXMT(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "93")]
		public LegacyCV2Result<None> DHUROGIESQW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "94")]
		public LegacyCV2Result<None> SZKMFCLHVUI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "95")]
		public LegacyCV2Result<None> TZNZTWVUFCJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ADYKREPAPMN(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(YJUHLGNCLGJ e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HZLWEKBXEUL(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WRDBEIQCEDZ(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ITDTFEJXCEM(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XTBIZLHQCIN(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BCKTLUGYYAQ(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FZCBIWCWPMW(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EIDZPUFFPOC(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SBHIRRRTVKX(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1240")]
		public LegacyCV2Result<None> MakeChatAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1241")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1242")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1243")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1245")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1244")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1247")]
		public LegacyCV2Result<None> GetAIFunction(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x11F8AF0", Offset = "0x11F7EF0", VA = "0x1811F8AF0", Slot = "1249")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LPRLXSBRLJM(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PHQKPAUGIYJ(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "119")]
		public LegacyCV2Result<None> JPWOJGXKCHT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZNYVLPZIDJQ(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "121")]
		public LegacyCV2Result<None> DRUFJSMYLVA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "122")]
		public LegacyCV2Result<None> XXRFAPUZSOW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "123")]
		public LegacyCV2Result<None> FJCCMYHAYRA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "124")]
		public LegacyCV2Result<None> TRJFBUEVVBY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "125")]
		public LegacyCV2Result<None> HHNJOFFRDMY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "126")]
		public LegacyCV2Result<None> WRLCTKMWJPT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "809")]
		public LegacyCV2Result<None> XCDHXDLSSWD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "810")]
		public LegacyCV2Result<None> EQWQHLIUVSH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "147")]
		public LegacyCV2Result<None> ZMSIQUYSNLX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "148")]
		public LegacyCV2Result<None> JUEEJTDBYUV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "149")]
		public LegacyCV2Result<None> IUXGJCAFALK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "150")]
		public LegacyCV2Result<None> UTBCVIOVFDC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "151")]
		public LegacyCV2Result<None> UBFWUPEGFLH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(YJUHLGNCLGJ e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "153")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "154")]
		public LegacyCV2Result<None> EquipAvatarItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "155")]
		public LegacyCV2Result<None> UnequipAvatarItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "156")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "157")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "158")]
		public LegacyCV2Result<None> MotionTrailSetColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailGetColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "164")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "165")]
		public LegacyCV2Result<None> BeaconSetEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "166")]
		public LegacyCV2Result<None> BeaconGetEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "167")]
		public LegacyCV2Result<None> BeaconSetHeight(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "168")]
		public LegacyCV2Result<None> BeaconGetHeight(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "169")]
		public LegacyCV2Result<None> BeaconSetColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "170")]
		public LegacyCV2Result<None> BeaconGetColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "171")]
		public LegacyCV2Result<None> TBNMWPVITTK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "172")]
		public LegacyCV2Result<None> UZCWUQSJYIJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "173")]
		public LegacyCV2Result<None> JLSYVLBLUSJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "174")]
		public LegacyCV2Result<None> GetLocalCameraForward(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "175")]
		public LegacyCV2Result<None> GetLocalCameraUp(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "176")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraPosition(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "178")]
		public LegacyCV2Result<None> SetCameraShake(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "179")]
		public LegacyCV2Result<None> StopCameraShake(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "180")]
		public LegacyCV2Result<None> SnapCameraImage(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "189")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "190")]
		public LegacyCV2Result<None> CollisionDataGetObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "191")]
		public LegacyCV2Result<None> CollisionDataGetDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPosition(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetNormal(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "194")]
		public LegacyCV2Result<None> HKVOSJYHQTN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "195")]
		public LegacyCV2Result<None> JXUZQVJIKBU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "196")]
		public LegacyCV2Result<None> EFJABJJUQTD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "197")]
		public LegacyCV2Result<None> WIWOXRMZZDX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "198")]
		public LegacyCV2Result<None> UYQHPNOZMAP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "199")]
		public LegacyCV2Result<None> ABUPTUMNPWO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "200")]
		public LegacyCV2Result<None> MMHVHAIKKKY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "201")]
		public LegacyCV2Result<None> GEOFQQUPQJK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "202")]
		public LegacyCV2Result<None> LZRKPMHJLZK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "203")]
		public LegacyCV2Result<None> SXRCJFCPDKU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "204")]
		public LegacyCV2Result<None> VWHSMLKGBLW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "205")]
		public LegacyCV2Result<None> RFMHXZYRPUE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "206")]
		public LegacyCV2Result<None> OBYMOVSTMYA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "207")]
		public LegacyCV2Result<None> KXDEIFMLPWL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "208")]
		public LegacyCV2Result<None> QUYTXBBJSUK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "209")]
		public LegacyCV2Result<None> MITHGDWPEFJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "210")]
		public LegacyCV2Result<None> CHQVBWSEIFW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "211")]
		public LegacyCV2Result<None> LQDLXCHPMZH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "212")]
		public LegacyCV2Result<None> MWVZHOFLQDO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "213")]
		public LegacyCV2Result<None> CombatantGetHealthAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "214")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "215")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "216")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "217")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "218")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "225")]
		public LegacyCV2Result<None> CombatantSetHealthAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "226")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "227")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "231")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "232")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "233")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "239")]
		public LegacyCV2Result<None> CombatantToCombatantAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "240")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "241")]
		public LegacyCV2Result<None> CombatantSplit(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "242")]
		public LegacyCV2Result<None> CostumeEquip(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "243")]
		public LegacyCV2Result<None> CostumeUnEquip(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "244")]
		public LegacyCV2Result<None> CostumeGetWearer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "245")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "271")]
		public LegacyCV2Result<None> HMZONHGNSWE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "272")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "273")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "274")]
		public LegacyCV2Result<None> GMIAFENNFGS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "276")]
		public LegacyCV2Result<None> JKMPLRLGSDV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "277")]
		public LegacyCV2Result<None> YAOOEICCNYV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "278")]
		public LegacyCV2Result<None> RWWJOLRDZHU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "279")]
		public LegacyCV2Result<None> OKPEZPCXYRV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "280")]
		public LegacyCV2Result<None> YBZSNYGKQCG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "281")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "282")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "283")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "284")]
		public LegacyCV2Result<None> QMZMWDRJBUL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "285")]
		public LegacyCV2Result<None> VHPQVJPIONI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "286")]
		public LegacyCV2Result<None> ToCreationObjectAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "287")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "288")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectButton(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectContainer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectRotator(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectPiston(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectSeat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectDice(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectCostume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "314")]
		public LegacyCV2Result<None> XWVUIELBEWD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "317")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "342")]
		public LegacyCV2Result<None> FromCreationObjectAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "343")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "344")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "345")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "346")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectButton(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectContainer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectDie(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectPiston(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRotator(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectText(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectSeat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectCostume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "399")]
		public LegacyCV2Result<None> SMKGNPKXHEG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "400")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VFIKOLZFHNL(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "401")]
		public LegacyCV2Result<None> DiceRollFinished(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "402")]
		public LegacyCV2Result<None> DiceResult(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "403")]
		public LegacyCV2Result<None> DicePlayerRolled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "404")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "405")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CGEZLLDCWLP(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "406")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OQRTCXAZJRF(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GQEKRZWVTHS(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "408")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XPMFFEPACMT(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "409")]
		public LegacyCV2Result<UQGXAXIHMGT.CV2DiscoverySectionType> NPHQQAKSHGY(YJUHLGNCLGJ e, CircuitSignal a)
		{
			return default(LegacyCV2Result<UQGXAXIHMGT.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "410")]
		public LegacyCV2Result<None> MDPYRDRQNQQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "411")]
		public LegacyCV2Result<None> EmitterStart(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "412")]
		public LegacyCV2Result<None> EmitterStop(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "413")]
		public LegacyCV2Result<None> EmitterSetLooping(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "414")]
		public LegacyCV2Result<None> EmitterSetSize(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "415")]
		public LegacyCV2Result<None> EmitterSetSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "416")]
		public LegacyCV2Result<None> EmitterSetColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "417")]
		public LegacyCV2Result<None> EmitterSetColorNew(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "418")]
		public LegacyCV2Result<None> EmitterGetLooping(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "419")]
		public LegacyCV2Result<None> EmitterGetSize(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "420")]
		public LegacyCV2Result<None> EmitterGetSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "421")]
		public LegacyCV2Result<None> EmitterGetPlaying(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "422")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(YJUHLGNCLGJ e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "423")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LTHAYKATVSE(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "424")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XMEVUFIVGKT(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "425")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OCPGWSXNSPS(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "426")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "427")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "428")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "429")]
		public LegacyCV2Result<None> GetFriendlyNameAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "430")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "182")]
		public LegacyCV2Result<None> GetFriendlyNameColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "434")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "431")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "432")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "433")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "435")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameReward(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "453")]
		public LegacyCV2Result<None> TFSSCRGHETZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "454")]
		public LegacyCV2Result<None> FCAUQXONJNE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "455")]
		public LegacyCV2Result<None> OFLVIMFJWCB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "456")]
		public LegacyCV2Result<None> ULUYTSQIYJC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "457")]
		public LegacyCV2Result<None> ONJFTUCPGMS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "458")]
		public LegacyCV2Result<None> BMMYCOARPNI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "459")]
		public LegacyCV2Result<None> LATSNBDWQYV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "460")]
		public LegacyCV2Result<None> MJASZAEPNOP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "465")]
		public LegacyCV2Result<None> ODOJKNWQBMH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "466")]
		public LegacyCV2Result<None> QZJLAISJRRD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "467")]
		public LegacyCV2Result<None> IFSNGXVNPDQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "468")]
		public LegacyCV2Result<None> WWUQODKGOUH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "469")]
		public LegacyCV2Result<None> MYXOBGTTQND(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "470")]
		public LegacyCV2Result<None> KEJCYGZGRCW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "461")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(YJUHLGNCLGJ executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "462")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(YJUHLGNCLGJ executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "463")]
		public LegacyCV2Result<None> QPJZZSTDXPQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "464")]
		public LegacyCV2Result<None> FDGVNGKFKGC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "471")]
		public LegacyCV2Result<None> RIOKSQBPSSY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "472")]
		public LegacyCV2Result<None> EAKAIYMHLVQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "473")]
		public LegacyCV2Result<None> WCKJZXUZCTB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "474")]
		public LegacyCV2Result<None> LJLMSTOVANL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "475")]
		public LegacyCV2Result<None> AQCQXWFMGMR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "476")]
		public LegacyCV2Result<None> STFBMYMWFMD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "477")]
		public LegacyCV2Result<None> RAJBIYWQWPT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "478")]
		public LegacyCV2Result<None> ROVJWYEHCGH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "479")]
		public LegacyCV2Result<None> WDLKAYBNHFX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "480")]
		public LegacyCV2Result<None> ENQPSZWEYYR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "481")]
		public LegacyCV2Result<None> NOPBLQJADQH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "482")]
		public LegacyCV2Result<None> TNYVDAFPWRD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "483")]
		public LegacyCV2Result<None> TZWUADRPNTN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "484")]
		public LegacyCV2Result<None> LHVMSWHPLMJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "485")]
		public LegacyCV2Result<None> GNRPNZVJCAR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "486")]
		public LegacyCV2Result<None> OUCRBKCUJXF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "487")]
		public LegacyCV2Result<None> TOHOTNBJQRJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "488")]
		public LegacyCV2Result<None> APMIHDQCFDZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "489")]
		public LegacyCV2Result<None> TXARTBYSUHF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "490")]
		public LegacyCV2Result<None> ELVNAFFBYBP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x27F8110", Offset = "0x27F7510", VA = "0x1827F8110", Slot = "491")]
		public LegacyCV2Result<None> SendLogString(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "492")]
		public LegacyCV2Result<None> LerpColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "493")]
		public LegacyCV2Result<None> LerpUnclampedColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "494")]
		public LegacyCV2Result<None> InverseLerpVec3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "495")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "496")]
		public LegacyCV2Result<None> InverseLerpColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "497")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "498")]
		public LegacyCV2Result<None> LEVTTGIWVIR(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "499")]
		public LegacyCV2Result<None> PEILIXPLJNJ(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "500")]
		public LegacyCV2Result<None> ZKCQRMFIJKH(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "501")]
		public LegacyCV2Result<None> JWHNYAOBZKW(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "502")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "503")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "504")]
		public LegacyCV2Result<None> FogConstantValues(YJUHLGNCLGJ e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "505")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "506")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "507")]
		public LegacyCV2Result<None> SunConstantValues(YJUHLGNCLGJ e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "508")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "509")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "510")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(YJUHLGNCLGJ e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.FHIVTZJVWPZ> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "511")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "512")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "513")]
		public LegacyCV2Result<None> ARTMCQGGXNU(YJUHLGNCLGJ e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "516")]
		public LegacyCV2Result<None> JOLRJUCPSGG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "517")]
		public LegacyCV2Result<None> TextScreenClearScreen(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "518")]
		public LegacyCV2Result<None> ULWRNNNXNGH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "519")]
		public LegacyCV2Result<None> PUAMIGAGVMB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "520")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "521")]
		public LegacyCV2Result<None> YILRYDUKDMN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "522")]
		public LegacyCV2Result<None> WKJCKXYLEMM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x27F7FF0", Offset = "0x27F73F0", VA = "0x1827F7FF0", Slot = "523")]
		public LegacyCV2Result<None> GetLocalPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "524")]
		public LegacyCV2Result<None> DQIZFFPVCRM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x27F8150", Offset = "0x27F7550", VA = "0x1827F8150", Slot = "526")]
		public LegacyCV2Result<None> ZWOCQRWAAQU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "525")]
		public LegacyCV2Result<None> PHSQWCKVTBT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "527")]
		public LegacyCV2Result<None> PRCSLUHJKXR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "528")]
		public LegacyCV2Result<None> XDYEFDKJWCA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "529")]
		public LegacyCV2Result<None> LJLFJJBNCHU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "530")]
		public LegacyCV2Result<None> UFSCZKPVYHM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "531")]
		public LegacyCV2Result<None> IADFOTJWQLS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "532")]
		public LegacyCV2Result<None> DistanceAI_AI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "533")]
		public LegacyCV2Result<None> DistanceAI_Combatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "534")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "535")]
		public LegacyCV2Result<None> DistanceAI_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "536")]
		public LegacyCV2Result<None> DistanceAI_Vector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "537")]
		public LegacyCV2Result<None> DistanceCombatant_AI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "538")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "539")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "540")]
		public LegacyCV2Result<None> DistanceCombatant_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "541")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "542")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "543")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "544")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "545")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "546")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "547")]
		public LegacyCV2Result<None> DistancePlayer_AI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "548")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "549")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "550")]
		public LegacyCV2Result<None> DistancePlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "551")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "552")]
		public LegacyCV2Result<None> DistanceVector3_AI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "553")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "554")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "555")]
		public LegacyCV2Result<None> DistanceVector3_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "556")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "557")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "558")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "559")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "560")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "561")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "562")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "563")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "564")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "565")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "566")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "567")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "568")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "569")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "570")]
		public LegacyCV2Result<None> GetPositionAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "571")]
		public LegacyCV2Result<None> GetPositionCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "572")]
		public LegacyCV2Result<None> GetPositionCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "573")]
		public LegacyCV2Result<None> GetPositionPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "574")]
		public LegacyCV2Result<None> Raycast(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "575")]
		public LegacyCV2Result<None> LWWCVHCYFAR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "576")]
		public LegacyCV2Result<None> RaycastAll(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "577")]
		public LegacyCV2Result<None> Spherecast(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "578")]
		public LegacyCV2Result<None> NIGCOSGZPVG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "579")]
		public LegacyCV2Result<None> SpherecastAll(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "580")]
		public LegacyCV2Result<None> OverlapSphere(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "581")]
		public LegacyCV2Result<None> OverlapBox(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "582")]
		public LegacyCV2Result<None> NBXKGFVJFNB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "583")]
		public LegacyCV2Result<None> QKPYXLAXVDK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "584")]
		public LegacyCV2Result<None> SetPositionPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "585")]
		public LegacyCV2Result<None> SetPositionCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "586")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "587")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "588")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "589")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "591")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "592")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "593")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "594")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "595")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "596")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "597")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "598")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "599")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "600")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "601")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "602")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "603")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "604")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "605")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "606")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "607")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "608")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "609")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "610")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "611")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "612")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "613")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "614")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "615")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "616")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "617")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "618")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "619")]
		public LegacyCV2Result<None> PistonGetDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "620")]
		public LegacyCV2Result<None> PistonSetDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "621")]
		public LegacyCV2Result<None> PistonGetSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "622")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "623")]
		public LegacyCV2Result<None> PistonSetSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "624")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "625")]
		public LegacyCV2Result<None> PistonGetAcceleration(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "626")]
		public LegacyCV2Result<None> PistonSetAcceleration(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "627")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "628")]
		public LegacyCV2Result<None> PistonGetMaxDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "629")]
		public LegacyCV2Result<None> PistonSetMaxDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "630")]
		public LegacyCV2Result<None> PistonGetTargetDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "631")]
		public LegacyCV2Result<None> PistonSetTargetDistance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "632")]
		public LegacyCV2Result<None> OOKRMEDKAZL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "633")]
		public LegacyCV2Result<None> VSUHOOWKUER(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "634")]
		public LegacyCV2Result<None> AZTQNRJORAE(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "635")]
		public LegacyCV2Result<None> ETZNFSQYXLB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "636")]
		public LegacyCV2Result<None> RSEJTMQMRQP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "637")]
		public LegacyCV2Result<None> TSDCHGIKGSY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "638")]
		public LegacyCV2Result<None> PlayerAddRole(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "639")]
		public LegacyCV2Result<None> PlayerRemoveRole(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "640")]
		public LegacyCV2Result<None> SZQVWHCMRWL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "641")]
		public LegacyCV2Result<None> UVCFAMPDCDJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "642")]
		public LegacyCV2Result<None> XSQVBJUOMCY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "643")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "644")]
		public LegacyCV2Result<None> PlayerRightHandPosition(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "645")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "646")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "647")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "648")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "649")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "650")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "652")]
		public LegacyCV2Result<None> MYRKPMCLJWD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "651")]
		public LegacyCV2Result<None> OHLVXQTTFWC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "653")]
		public LegacyCV2Result<None> JWYDKCERNTP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "654")]
		public LegacyCV2Result<None> JJPGGFLSWPK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "655")]
		public LegacyCV2Result<None> PlayerHeadPosition(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "656")]
		public LegacyCV2Result<None> PlayerHeadOrientation(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "657")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "658")]
		public LegacyCV2Result<None> PlayerHeadUpVector(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "659")]
		public LegacyCV2Result<None> PlayerHeadVelocity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "660")]
		public LegacyCV2Result<None> PlayerHeadHeight(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "661")]
		public LegacyCV2Result<None> UVRYFPAOYWD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "662")]
		public LegacyCV2Result<None> DCNEXSICBNE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "663")]
		public LegacyCV2Result<None> PlayerBodyPosition(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "664")]
		public LegacyCV2Result<None> PlayerBodyOrientation(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "665")]
		public LegacyCV2Result<None> PHGHRMTPMJW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "666")]
		public LegacyCV2Result<None> AVUVPKTDIDZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "694")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "699")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(YJUHLGNCLGJ e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "685")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "686")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "687")]
		public LegacyCV2Result<None> UTDKEJUTZGB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "688")]
		public LegacyCV2Result<None> FNJBGUUYHBV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "689")]
		public LegacyCV2Result<None> LCBLQHAIBYF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "690")]
		public LegacyCV2Result<None> FLIXMTKIQHM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "691")]
		public LegacyCV2Result<None> EIVTTPAXSQU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "692")]
		public LegacyCV2Result<None> PlayerGetCostume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "693")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "667")]
		public LegacyCV2Result<None> SJRSFDXIAPN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "668")]
		public LegacyCV2Result<None> JWFRRESYWCR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "669")]
		public LegacyCV2Result<None> ZNDQBMYLKFG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "670")]
		public LegacyCV2Result<None> HRUTLGGQDFP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "671")]
		public LegacyCV2Result<None> BZBDHAKIJCC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "672")]
		public LegacyCV2Result<None> XJUGWWEASML(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "673")]
		public LegacyCV2Result<None> NZRLZEZMPUJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "674")]
		public LegacyCV2Result<None> UQKRHPOHJRK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "675")]
		public LegacyCV2Result<None> CXPPKYTGPLU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "676")]
		public LegacyCV2Result<None> JLCXKYOAYQZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "677")]
		public LegacyCV2Result<None> CUGYBJSXAIV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "678")]
		public LegacyCV2Result<None> LAPREAHUAEU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "679")]
		public LegacyCV2Result<None> SOOREBJSIBZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "680")]
		public LegacyCV2Result<None> TRSAHAMNZNF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "681")]
		public LegacyCV2Result<None> YJHZRWFAIUU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "682")]
		public LegacyCV2Result<None> JTHUMHIMDJM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "683")]
		public LegacyCV2Result<None> QAPRVBYQOKE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "684")]
		public LegacyCV2Result<None> PUECCRRRROH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "695")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "696")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "756")]
		public LegacyCV2Result<None> MQKYVBLJBTX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "757")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "758")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "700")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "702")]
		public LegacyCV2Result<None> IIQDXCWXMNM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "703")]
		public LegacyCV2Result<None> ZZCYKYRZRLU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "704")]
		public LegacyCV2Result<None> AROTSUZOGZS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "705")]
		public LegacyCV2Result<None> ZJQKXULBXZY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "707")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "708")]
		public LegacyCV2Result<None> XNDVNXYIBUY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "709")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "710")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "711")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "712")]
		public LegacyCV2Result<None> OZXCDTGHMBP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "713")]
		public LegacyCV2Result<None> CASEMCDLQCT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "714")]
		public LegacyCV2Result<None> QUYBEWSPYZU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "715")]
		public LegacyCV2Result<None> WLUVTABILCO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "716")]
		public LegacyCV2Result<None> HVGYHRRHBFM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "717")]
		public LegacyCV2Result<None> LSABDLBGSKN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "718")]
		public LegacyCV2Result<None> ODIOQFFVCYM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "719")]
		public LegacyCV2Result<None> NTZHEXAAOPR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "720")]
		public LegacyCV2Result<None> UVDSHEKONOB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "721")]
		public LegacyCV2Result<None> UXISSQVMSID(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "722")]
		public LegacyCV2Result<None> ZCDSNLZKSXF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "723")]
		public LegacyCV2Result<None> AKKGPMIMWZP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "724")]
		public LegacyCV2Result<None> MAUVSLIBLXL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "725")]
		public LegacyCV2Result<None> RQBLQGAEUFC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "726")]
		public LegacyCV2Result<None> URSUVYMEVOJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "727")]
		public LegacyCV2Result<None> UOADHAXGUEP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "728")]
		public LegacyCV2Result<None> TZBBPDKEVKO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "729")]
		public LegacyCV2Result<None> QUNHJFPADSR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "731")]
		public LegacyCV2Result<None> KLNETSYHSQP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "730")]
		public LegacyCV2Result<None> INJSSIGDVRR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "732")]
		public LegacyCV2Result<None> KEFHFMBVYLQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "733")]
		public LegacyCV2Result<None> DIQJYHUIXIZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "734")]
		public LegacyCV2Result<None> QFETPKTHGRM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "735")]
		public LegacyCV2Result<None> NLCIFSTSEZO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "736")]
		public LegacyCV2Result<None> BIYCZAJARUD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "737")]
		public LegacyCV2Result<None> FDPEYZKFWYW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "738")]
		public LegacyCV2Result<None> TQXPEPRSHBY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "739")]
		public LegacyCV2Result<None> YGNWHFLAKPP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "740")]
		public LegacyCV2Result<None> OZEFNHKUMRZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "741")]
		public LegacyCV2Result<None> YPHPCVSJKTR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "742")]
		public LegacyCV2Result<None> TRVZAICJEMZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "743")]
		public LegacyCV2Result<None> PEZEGYGKLAV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "744")]
		public LegacyCV2Result<None> LHBRXKWZTZH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "745")]
		public LegacyCV2Result<None> KJXVUVWEYAB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "746")]
		public LegacyCV2Result<None> BMSNKIQISYY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "747")]
		public LegacyCV2Result<None> POOEVFZCQJQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "748")]
		public LegacyCV2Result<None> UVNIXKDMMTI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "749")]
		public LegacyCV2Result<None> RGBIKOTYEGC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "750")]
		public LegacyCV2Result<None> GXIGZOVCSTD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "751")]
		public LegacyCV2Result<None> SELJONPNDRB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "752")]
		public LegacyCV2Result<None> SVNNPILEQOF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "753")]
		public LegacyCV2Result<None> CYOZSINPBGK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "754")]
		public LegacyCV2Result<None> XEDRNFAQTFS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "755")]
		public LegacyCV2Result<None> TVJOOMVMEDT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "759")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "760")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "761")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "762")]
		public LegacyCV2Result<None> UYIUPJQTCNB(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "763")]
		public LegacyCV2Result<None> WMQWNDRKHTL(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "764")]
		public LegacyCV2Result<None> NBBNEEVAXBQ(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "765")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(YJUHLGNCLGJ ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "766")]
		public LegacyCV2Result<None> QTYDMZBVZEU(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "767")]
		public LegacyCV2Result<None> HOVBSUGUWEM(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "768")]
		public LegacyCV2Result<None> JMIQHNPLFLJ(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "769")]
		public LegacyCV2Result<None> CJKVOCGOAMR(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "770")]
		public LegacyCV2Result<None> DAKCOSCJFHH(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "697")]
		public LegacyCV2Result<None> PlayerGetProfileImage(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "698")]
		public LegacyCV2Result<None> XCSREDZPLVF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "771")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "772")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "773")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "774")]
		public LegacyCV2Result<None> ShowPlayerProfile(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "775")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "776")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "777")]
		public LegacyCV2Result<None> RequestPostGameRewards(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "778")]
		public LegacyCV2Result<None> SetPlayerWorldUI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "779")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "780")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "781")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "782")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "783")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "784")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "785")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "786")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "788")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "791")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "792")]
		public LegacyCV2Result<None> HYJFQQRXYHL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "793")]
		public LegacyCV2Result<None> DCDDHFETTRL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "794")]
		public LegacyCV2Result<None> XSDBFZDRSIH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "795")]
		public LegacyCV2Result<None> QBDWGSGRWEH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "796")]
		public LegacyCV2Result<None> TIRKIYKLYTX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "797")]
		public LegacyCV2Result<None> HOTBZRYDGVT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "798")]
		public LegacyCV2Result<None> RUQOEYUAIQT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "799")]
		public LegacyCV2Result<None> JYWOHDDDYJB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "800")]
		public LegacyCV2Result<None> WDTADUNXJSB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "801")]
		public LegacyCV2Result<None> MLHYETXEGMX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "802")]
		public LegacyCV2Result<None> KCFUMNZCTHV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "803")]
		public LegacyCV2Result<None> DWKWMBTFUEM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "804")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "805")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "806")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "807")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "808")]
		public LegacyCV2Result<None> HNTHNLAAIXF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "811")]
		public LegacyCV2Result<None> GetProjectile(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "812")]
		public LegacyCV2Result<None> TPLKNRXFUCY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "813")]
		public LegacyCV2Result<None> IAFVTXRAMFG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "814")]
		public LegacyCV2Result<None> WUAVMTAVOTQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "815")]
		public LegacyCV2Result<None> TTDLGUIRROC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "816")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "817")]
		public LegacyCV2Result<None> HBVTWMKPDPM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "818")]
		public LegacyCV2Result<None> QTJBBVEGIPX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "819")]
		public LegacyCV2Result<None> QSSSLAUMSXV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "820")]
		public LegacyCV2Result<None> ResetRoom(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "821")]
		public LegacyCV2Result<None> ResetObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "822")]
		public LegacyCV2Result<None> FUODPIHTEHP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "823")]
		public LegacyCV2Result<None> VIVCUJWSHXY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "824")]
		public LegacyCV2Result<None> UDFMOBSWIVD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "825")]
		public LegacyCV2Result<None> ConstantReward(YJUHLGNCLGJ e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "826")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(YJUHLGNCLGJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "827")]
		public LegacyCV2Result<None> KMBZHFWPJAI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "828")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PVTNBNKONVI(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "829")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SIRJOYVUDVG(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "830")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YCXPRWZRIDN(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "831")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VNKCGCAUTGQ(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "832")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DKNQFRGXGHL(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "833")]
		public LegacyCV2Result<None> ActivateConsumable(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "834")]
		public LegacyCV2Result<None> DeactivateConsumable(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "835")]
		public LegacyCV2Result<None> ConstantConsumable(YJUHLGNCLGJ e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "836")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(YJUHLGNCLGJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "837")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "840")]
		public LegacyCV2Result<None> ConstantRoomKey(YJUHLGNCLGJ e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "842")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(YJUHLGNCLGJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "843")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "844")]
		public LegacyCV2Result<None> ConstantInventoryItem(YJUHLGNCLGJ e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(YJUHLGNCLGJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "846")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(YJUHLGNCLGJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "847")]
		public LegacyCV2Result<None> VDJVLGLPWWA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "849")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "850")]
		public LegacyCV2Result<None> CNXCJEYFSYY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "851")]
		public LegacyCV2Result<None> PDXLLFNWBGO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "852")]
		public LegacyCV2Result<None> HONIKLWEGBQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "853")]
		public LegacyCV2Result<None> XMGPTXFBMLN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "854")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "855")]
		public LegacyCV2Result<None> JRVTOLDJGQI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "856")]
		public LegacyCV2Result<None> IXLGBNBXOPY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "857")]
		public LegacyCV2Result<None> ConstantRoomOffer(YJUHLGNCLGJ e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "858")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "859")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "860")]
		public LegacyCV2Result<None> JKALFOHFHDI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "861")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "862")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "863")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "864")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "865")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "866")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "867")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "868")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "869")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "870")]
		public LegacyCV2Result<None> FOOSAIHLBIA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "871")]
		public LegacyCV2Result<None> FJCIWUFVDBA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "872")]
		public LegacyCV2Result<None> BYXAHUFIDDV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "873")]
		public LegacyCV2Result<None> LFCIZSOFUFA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "874")]
		public LegacyCV2Result<None> ConstantRoomCurrency(YJUHLGNCLGJ e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "875")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(YJUHLGNCLGJ e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "876")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(YJUHLGNCLGJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "877")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(YJUHLGNCLGJ e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "878")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(YJUHLGNCLGJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "879")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "880")]
		public LegacyCV2Result<None> UFGBTXKOBIW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "881")]
		public LegacyCV2Result<None> FGGLRFTKHNH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "882")]
		public LegacyCV2Result<None> PIRBKWYZVFO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "883")]
		public LegacyCV2Result<None> IYGUTBXWFWA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "884")]
		public LegacyCV2Result<None> HERWACJJJWW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "888")]
		public LegacyCV2Result<None> IBVTTZLDLOD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "889")]
		public LegacyCV2Result<None> XGGEIDBVUZV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "890")]
		public LegacyCV2Result<None> PIQZPKHBZHM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "892")]
		public LegacyCV2Result<None> YRKEWDPNYSG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "891")]
		public LegacyCV2Result<None> COTSCFIEQDA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "893")]
		public LegacyCV2Result<None> CEKZDJSFPXF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "895")]
		public LegacyCV2Result<None> CSOQTZRZGIT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "894")]
		public LegacyCV2Result<None> CUEFQZCAHOV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "896")]
		public LegacyCV2Result<None> ZAHOOXDUWHU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "897")]
		public LegacyCV2Result<None> EWGRBROYLVI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "898")]
		public LegacyCV2Result<None> SJADWRQIDWP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "899")]
		public LegacyCV2Result<None> DHXKFXVPTHX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "900")]
		public LegacyCV2Result<None> DMOKHKPGYQR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "901")]
		public LegacyCV2Result<None> CFCZZRKCMLP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "902")]
		public LegacyCV2Result<None> UZEIMPSFBXP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "903")]
		public LegacyCV2Result<None> AllowDressUp(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "904")]
		public LegacyCV2Result<None> ForbidDressUp(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "905")]
		public LegacyCV2Result<None> OpenStore(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "906")]
		public LegacyCV2Result<None> OpenCheckout(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "907")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "908")]
		public LegacyCV2Result<None> GetTrialItemQuantity(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "909")]
		public LegacyCV2Result<None> EYKBGCTXHGD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "910")]
		public LegacyCV2Result<None> AFWOJRBBJZF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "911")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "912")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "913")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "914")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "915")]
		public LegacyCV2Result<None> StorefrontGetOffersList(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "916")]
		public LegacyCV2Result<None> StorefrontSetOffersList(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "917")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "918")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "919")]
		public LegacyCV2Result<None> GetStoreItemDetails(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "920")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "921")]
		public LegacyCV2Result<None> MannequinSetStoreItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "922")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "923")]
		public LegacyCV2Result<None> RaiseStudioEvent(YJUHLGNCLGJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "924")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(YJUHLGNCLGJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "925")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(YJUHLGNCLGJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "926")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(YJUHLGNCLGJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "927")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(YJUHLGNCLGJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "928")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(YJUHLGNCLGJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "929")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(YJUHLGNCLGJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "930")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(YJUHLGNCLGJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "931")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(YJUHLGNCLGJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "932")]
		public LegacyCV2Result<None> UJQDNHWURPD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "933")]
		public LegacyCV2Result<None> ROHMNCVPWGZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "934")]
		public LegacyCV2Result<None> JQOFWVKLVSO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "935")]
		public LegacyCV2Result<None> YUHNGBAUBVC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "936")]
		public LegacyCV2Result<None> VADEZWEFCXN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "937")]
		public LegacyCV2Result<None> ZDJDWBTXRTD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "938")]
		public LegacyCV2Result<None> CBUTHJTSWPK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "939")]
		public LegacyCV2Result<None> EIUCXQHWWQI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "940")]
		public LegacyCV2Result<None> UARRILZOHRG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "941")]
		public LegacyCV2Result<None> ZEPFKGECNGX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "942")]
		public LegacyCV2Result<None> GetFromSyncIdAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "943")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "944")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "945")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "946")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "947")]
		public LegacyCV2Result<None> GetSyncIdAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "948")]
		public LegacyCV2Result<None> GetSyncIdCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "949")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "950")]
		public LegacyCV2Result<None> GetSyncIdPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "951")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "959")]
		public LegacyCV2Result<None> SJAKASZTFUP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "958")]
		public LegacyCV2Result<None> KHPYXAFLXZC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "960")]
		public LegacyCV2Result<None> SUJTIQBWVGO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "961")]
		public LegacyCV2Result<None> KANWZGQHTYH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "962")]
		public LegacyCV2Result<None> UEAFSQVQCMI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "963")]
		public LegacyCV2Result<None> ACMEQDOPSDU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "964")]
		public LegacyCV2Result<None> XOBGBWTXNIX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "952")]
		public LegacyCV2Result<None> TextToolGetText(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "953")]
		public LegacyCV2Result<None> TextToolSetText(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "954")]
		public LegacyCV2Result<None> TextToolSetColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "955")]
		public LegacyCV2Result<None> TextToolSetColorNew(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "956")]
		public LegacyCV2Result<None> TextToolSetMaterial(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "957")]
		public LegacyCV2Result<None> TextToolGetColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "965")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "966")]
		public LegacyCV2Result<None> HGPFPLRLSDK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "972")]
		public LegacyCV2Result<None> GetParticleVfx(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "973")]
		public LegacyCV2Result<None> NUNEMAOUHQT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "974")]
		public LegacyCV2Result<None> HYEBCUNPPKZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "975")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "976")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "977")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "978")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "979")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "980")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "981")]
		public LegacyCV2Result<None> GoToRoom(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "982")]
		public LegacyCV2Result<None> HSGCBIDWVRK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "967")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "968")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "969")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "970")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "971")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "983")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "984")]
		public LegacyCV2Result<None> ZRPBJNSYZCI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "985")]
		public LegacyCV2Result<None> QMGUSAFGQTC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "986")]
		public LegacyCV2Result<None> GZEZJRWCTSO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "987")]
		public LegacyCV2Result<None> HBMSCFHYZRA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "988")]
		public LegacyCV2Result<None> CHTSBDIYUSU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "989")]
		public LegacyCV2Result<None> UDTKWNRJDMY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "990")]
		public LegacyCV2Result<None> CCDMRZAXAIG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "991")]
		public LegacyCV2Result<None> TWSBSJAXDFE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "992")]
		public LegacyCV2Result<None> CAXILHACBCW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "993")]
		public LegacyCV2Result<None> SBPWLKUBIAK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "997")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "998")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "994")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "995")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "996")]
		public LegacyCV2Result<None> PlayerGetXp(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "999")]
		public LegacyCV2Result<None> PerlinNoise(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1000")]
		public LegacyCV2Result<None> RTMVEYONIOY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1001")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1002")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1003")]
		public LegacyCV2Result<None> SeatSetLockOut(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1004")]
		public LegacyCV2Result<None> SeatSetLockIn(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1005")]
		public LegacyCV2Result<None> SeatUnseatPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1006")]
		public LegacyCV2Result<None> SeatGetLockIn(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1007")]
		public LegacyCV2Result<None> SeatGetLockOut(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1008")]
		public LegacyCV2Result<None> HDLHRTFZPTZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1009")]
		public LegacyCV2Result<None> DYTMKDAUQZY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1010")]
		public LegacyCV2Result<None> ACCYDLHALVR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1011")]
		public LegacyCV2Result<None> FYDZMHLJGHY(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1012")]
		public LegacyCV2Result<None> BAPTFEQYRFN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1013")]
		public LegacyCV2Result<None> MKRDCWNAAVK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1014")]
		public LegacyCV2Result<None> TVREWIHHUXT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1015")]
		public LegacyCV2Result<None> YJGOBJQNPGF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1016")]
		public LegacyCV2Result<None> WXWACUPMOJC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1017")]
		public LegacyCV2Result<None> WZUCBQHMRPR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1018")]
		public LegacyCV2Result<None> AMIMOWPUHCP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1019")]
		public LegacyCV2Result<None> CDRHTPXVVTW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1020")]
		public LegacyCV2Result<None> BUKOSWTBJYI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1021")]
		public LegacyCV2Result<None> IKJZMACPQVB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1022")]
		public LegacyCV2Result<None> GZNULYUYIJO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1023")]
		public LegacyCV2Result<None> AUSTFCNGFFR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1024")]
		public LegacyCV2Result<None> MBZHRQPNEHZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1025")]
		public LegacyCV2Result<None> NavMeshSamplePosition(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1026")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1038")]
		public LegacyCV2Result<None> FXBAXIGLQPH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1039")]
		public LegacyCV2Result<None> PXPUNTGYDTP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1040")]
		public LegacyCV2Result<None> TOQTCIAXIWB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1041")]
		public LegacyCV2Result<None> OINTDLBGUDL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1042")]
		public LegacyCV2Result<None> NGEBZGCBGPI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1043")]
		public LegacyCV2Result<None> ACNUHVKVMIK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1044")]
		public LegacyCV2Result<None> TCPQUDHEUCZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1045")]
		public LegacyCV2Result<None> TJRIVAJVKAI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1046")]
		public LegacyCV2Result<None> LZOLCPCPLFN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1047")]
		public LegacyCV2Result<None> VGKSOSGAGWM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1048")]
		public LegacyCV2Result<None> RHCNKGCUXNS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1049")]
		public LegacyCV2Result<None> GIWQGNHMZAN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1050")]
		public LegacyCV2Result<None> IFNZTYWDUBK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1051")]
		public LegacyCV2Result<None> HLXQDEQWYDQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1052")]
		public LegacyCV2Result<None> DBCNWDLMNGK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1053")]
		public LegacyCV2Result<None> YYHCZINYERE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1054")]
		public LegacyCV2Result<None> RPRQNAATGTE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1055")]
		public LegacyCV2Result<None> EMLLAJTQVNB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1056")]
		public LegacyCV2Result<None> SHLVWMPDQUL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1057")]
		public LegacyCV2Result<None> EAMJYVSNEKU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1058")]
		public LegacyCV2Result<None> NBUFRAJGASA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1059")]
		public LegacyCV2Result<None> SFMTFAORQDU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1060")]
		public LegacyCV2Result<None> OTZMUHIFVOO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1061")]
		public LegacyCV2Result<None> LSADEMHVOIX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1062")]
		public LegacyCV2Result<None> LGJAMWOQZNF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1063")]
		public LegacyCV2Result<None> IsValidAI(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1064")]
		public LegacyCV2Result<None> IsValidCombatant(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x27F8030", Offset = "0x27F7430", VA = "0x1827F8030", Slot = "1065")]
		public LegacyCV2Result<None> IsValidPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1066")]
		public LegacyCV2Result<None> IsValidReward(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1067")]
		public LegacyCV2Result<None> IsValidAudio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1068")]
		public LegacyCV2Result<None> IsValidRecNetMesh(YJUHLGNCLGJ e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1069")]
		public LegacyCV2Result<None> ValidIfNotNull(YJUHLGNCLGJ e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1070")]
		public LegacyCV2Result<None> GetVelocityCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1071")]
		public LegacyCV2Result<None> GetVelocityPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1072")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1073")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1074")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1075")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1076")]
		public LegacyCV2Result<None> GetUpVectorPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1077")]
		public LegacyCV2Result<None> GetOrientationCreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1078")]
		public LegacyCV2Result<None> GetOrientationPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1079")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1080")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1081")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1082")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1083")]
		public LegacyCV2Result<None> XSLVXKDSVJE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1084")]
		public LegacyCV2Result<None> DIVUAUGKLJP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1085")]
		public LegacyCV2Result<None> XQDDZDVACJP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1086")]
		public LegacyCV2Result<None> NMASZTJZRIZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1087")]
		public LegacyCV2Result<None> NDEIZKYRRDX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1088")]
		public LegacyCV2Result<None> HRPCDRHKMFB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1089")]
		public LegacyCV2Result<None> TJHIHIPEOST(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1090")]
		public LegacyCV2Result<None> MGZCXTMXVOT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1091")]
		public LegacyCV2Result<None> VPBEAIHJZAL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1092")]
		public LegacyCV2Result<None> HOHUCCCKJDR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1093")]
		public LegacyCV2Result<None> JBWXPBFWAPJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1094")]
		public LegacyCV2Result<None> UBHCQZWRIVC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1095")]
		public LegacyCV2Result<None> PURYRVMDVEM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1096")]
		public LegacyCV2Result<None> CKTOWDHWOOI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1097")]
		public LegacyCV2Result<None> BLNZPQVBIKU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1098")]
		public LegacyCV2Result<None> ZPUALXSKQJJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1099")]
		public LegacyCV2Result<None> MNAROQCFPDV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1100")]
		public LegacyCV2Result<None> TNYUSMAMOQC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1101")]
		public LegacyCV2Result<None> TGFEQGNMRJQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1102")]
		public LegacyCV2Result<None> NZJXNACTEIC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1103")]
		public LegacyCV2Result<None> WNOHDBYDZAC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1104")]
		public LegacyCV2Result<None> KZRJCRKFPJB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1105")]
		public LegacyCV2Result<None> TUCCXSUKCLV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1106")]
		public LegacyCV2Result<None> SCQASIGMPOS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1107")]
		public LegacyCV2Result<None> QPJFODSWKGK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1108")]
		public LegacyCV2Result<None> KFHJXBOUBBM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1109")]
		public LegacyCV2Result<None> OGSPJCQCIAG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1110")]
		public LegacyCV2Result<None> BKTZRJSVWVR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1111")]
		public LegacyCV2Result<None> ZZSDROKDOAM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1112")]
		public LegacyCV2Result<None> ZZYVAGBOBCE(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1113")]
		public LegacyCV2Result<None> HGAVQCXLCJG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1114")]
		public LegacyCV2Result<None> UZFKTVVNRXN(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1115")]
		public LegacyCV2Result<None> YHIVSOXNGXN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1116")]
		public LegacyCV2Result<None> RTDNUCYLRVV(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1117")]
		public LegacyCV2Result<None> VYHOYBLTFBR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1118")]
		public LegacyCV2Result<None> AYKLLVYAFEP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1119")]
		public LegacyCV2Result<None> UPPXNMWTWYP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1120")]
		public LegacyCV2Result<None> DQQRVPRRASV(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1121")]
		public LegacyCV2Result<None> PZNIGWDDVRU(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1122")]
		public LegacyCV2Result<None> MAEZOVYSVZZ(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1123")]
		public LegacyCV2Result<None> CPWCCFHFFEG(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1124")]
		public LegacyCV2Result<None> ZQHXNPDHHNN(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1125")]
		public LegacyCV2Result<None> ZNMDHSCJTEL(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1126")]
		public LegacyCV2Result<None> LNCZNMAXDQM(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1127")]
		public LegacyCV2Result<None> IFQYJERZURG(QVMTSXADWLM e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1128")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1129")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1130")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1131")]
		public LegacyCV2Result<None> KHCBMWEOJRS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1132")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1133")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1134")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1135")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1136")]
		public LegacyCV2Result<None> HolotarProjectorPlay(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1137")]
		public LegacyCV2Result<None> HolotarProjectorResume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1138")]
		public LegacyCV2Result<None> HolotarProjectorPause(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1139")]
		public LegacyCV2Result<None> HolotarProjectorStop(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1140")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1141")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1142")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1143")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1144")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1145")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1146")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1147")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1148")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1149")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1150")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1151")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1152")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1153")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1154")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1155")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1156")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1157")]
		public LegacyCV2Result<None> EQMDQTFZOLM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1158")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1159")]
		public LegacyCV2Result<None> XUUGQPNSMJK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1160")]
		public LegacyCV2Result<None> NLZDRDXVFZN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1161")]
		public LegacyCV2Result<None> HIFSGNECYHU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1162")]
		public LegacyCV2Result<None> ESMCHHJYSCD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1166")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1168")]
		public LegacyCV2Result<None> GunHandleGetCanReload(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1169")]
		public LegacyCV2Result<None> GunHandleSetCanReload(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1170")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1171")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1172")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1173")]
		public LegacyCV2Result<None> SOBWDJRBCIX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1174")]
		public LegacyCV2Result<None> FGXTCSRMBPH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1175")]
		public LegacyCV2Result<None> EKOWJLSQFTD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1176")]
		public LegacyCV2Result<None> JZYVKJSYXLF(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1177")]
		public LegacyCV2Result<None> XLKZFZIUVTG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1178")]
		public LegacyCV2Result<None> GKCZYQDPLNC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1179")]
		public LegacyCV2Result<None> YCPGHQGETJQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1180")]
		public LegacyCV2Result<None> ULVRDFGOWAW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1181")]
		public LegacyCV2Result<None> MUCSORWZNJL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1182")]
		public LegacyCV2Result<None> NVGKEEUHRHD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1183")]
		public LegacyCV2Result<None> EZCGVJGEPVI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1184")]
		public LegacyCV2Result<None> XNMQHQNDMEL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "181")]
		public LegacyCV2Result<None> ZXQLJEJBVYD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "183")]
		public LegacyCV2Result<None> GetIntFromRROColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "184")]
		public LegacyCV2Result<None> GetColorFromRGB(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "185")]
		public LegacyCV2Result<None> GetColorFromHSV(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "186")]
		public LegacyCV2Result<None> GetRGBFromColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "187")]
		public LegacyCV2Result<None> GetHSVFromColor(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x27F8070", Offset = "0x27F7470", VA = "0x1827F8070", Slot = "188")]
		public bool LEGFUYLQUSZ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1185")]
		public LegacyCV2Result<None> WSAVKBHFKQL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1186")]
		public LegacyCV2Result<None> TUEOQBKQQMO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1187")]
		public LegacyCV2Result<None> LSUOXMGVDGR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(YJUHLGNCLGJ e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1199")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1188")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1189")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1190")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1191")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1192")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1193")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1194")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1195")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1196")]
		public LegacyCV2Result<None> ZURLXYVVUJI(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1197")]
		public LegacyCV2Result<None> BDORAUGQCOS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "246")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(YJUHLGNCLGJ e, InOut io, NMZZCSXJRVE objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "247")]
		public LegacyCV2Result<None> ETEPYLHAPPJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "248")]
		public LegacyCV2Result<None> IIUZQJINUUJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "249")]
		public LegacyCV2Result<None> GGJSDSCSAFD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "250")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "251")]
		public LegacyCV2Result<None> YIQDEBTFOKO(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "252")]
		public LegacyCV2Result<None> MAIGTVKYYRQ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "253")]
		public LegacyCV2Result<None> LLVNLJFSRLU(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "254")]
		public LegacyCV2Result<None> UITFQQCITDP(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "255")]
		public LegacyCV2Result<None> ZIBMEXUQVUB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "256")]
		public LegacyCV2Result<None> LBTBJLPHZJM(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "257")]
		public LegacyCV2Result<None> GKSFZQJFJIC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "258")]
		public LegacyCV2Result<None> TUVEXFJABRS(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "259")]
		public LegacyCV2Result<None> QOEKEUDLOCA(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "260")]
		public LegacyCV2Result<None> GBRHCLTAOVB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "261")]
		public LegacyCV2Result<None> HRZRHTBRSWD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "262")]
		public LegacyCV2Result<None> RPRTASJMFWJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "263")]
		public LegacyCV2Result<None> ILTCHORWSDT(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "264")]
		public LegacyCV2Result<None> ZFZHJDSELXD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "265")]
		public LegacyCV2Result<None> UIRJOXOYTZN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "266")]
		public LegacyCV2Result<None> DLGUXJUCVWH(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "267")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "268")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "269")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0")]
		private static LegacyCV2Result<None> Default(YJUHLGNCLGJ e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x27F8080", Offset = "0x27F7480", VA = "0x1827F8080", Slot = "1200")]
		public LegacyCV2Result<None> QPYJEHPEAQU(YJUHLGNCLGJ a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1203")]
		public LegacyCV2Result<None> OWQCUHSBMBR(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1204")]
		public LegacyCV2Result<None> PHBMQXZZKQZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1205")]
		public LegacyCV2Result<None> ZRAHWNHJPDX(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1206")]
		public LegacyCV2Result<None> VYZEPNWNPXE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1201")]
		public LegacyCV2Result<None> ConstantQuickChatTable(YJUHLGNCLGJ e, InOut io, CKVLKEGAWNE quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1202")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1027")]
		public LegacyCV2Result<None> OUCRWBUARED(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1028")]
		public LegacyCV2Result<None> QPQCQJFULGL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1029")]
		public LegacyCV2Result<None> WQHFOESJIDL(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1030")]
		public LegacyCV2Result<None> ZDGDQGGADUZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1031")]
		public LegacyCV2Result<None> CMGQCVZKFDZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1032")]
		public LegacyCV2Result<None> RCBSAYGZNBB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1033")]
		public LegacyCV2Result<None> OYRTXRXMEUL(YJUHLGNCLGJ a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1034")]
		public LegacyCV2Result<None> BZLWYCHIKQV(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1035")]
		public LegacyCV2Result<None> GXMSJIICCGN(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1036")]
		public LegacyCV2Result<None> BMMRKEBVGTW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1037")]
		public LegacyCV2Result<None> AIVAXBSHJUE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1210")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1211")]
		public LegacyCV2Result<None> HandleSetControlLabel(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1212")]
		public LegacyCV2Result<None> HandleGetControlLabel(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1213")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1214")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1215")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1216")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1217")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QPVKXRSSDIU(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1224")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1225")]
		public LegacyCV2Result<None> JQOHVYOMGDJ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1226")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1227")]
		public LegacyCV2Result<None> VPXCFDVCYAK(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1228")]
		public LegacyCV2Result<None> ElementSnapToElement(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1229")]
		public LegacyCV2Result<None> ElementUnsnap(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1230")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1231")]
		public LegacyCV2Result<None> SnapPointUnsnap(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1218")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1219")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1220")]
		public LegacyCV2Result<None> SZJAZFVEECE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1221")]
		public LegacyCV2Result<None> GetTexture(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1222")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1223")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1232")]
		public LegacyCV2Result<None> VFOAWKCWUVG(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1233")]
		public LegacyCV2Result<None> FOTIPMBBIWD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1234")]
		public LegacyCV2Result<None> CBHLNQTCTMD(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1235")]
		public LegacyCV2Result<None> VHZAWWNBNCZ(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1236")]
		public LegacyCV2Result<None> OKKWUNTJMPE(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1237")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KPJOANNNLLC(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1238")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NYQTNQEPOUY(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1239")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UQDXEPHTMIC(YJUHLGNCLGJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x27F8190", Offset = "0x27F7590", VA = "0x1827F8190")]
		public FIADIHRJNGJ([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1256")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1257")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1258")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1259")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1260")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1261")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1262")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1266")]
		public LegacyCV2Result<None> ConstantBodyPart(YJUHLGNCLGJ e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1267")]
		public LegacyCV2Result<None> RRVCRFQLXZB(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1268")]
		public LegacyCV2Result<None> FGQRSDIXNUW(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1269")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "590")]
		public LegacyCV2Result<None> TBXHSEQGJJC(YJUHLGNCLGJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1270")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1271")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1272")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1273")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1274")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1275")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1276")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1277")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1278")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1279")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1280")]
		public LegacyCV2Result<None> FZGSKMRVOOD(QVMTSXADWLM e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1281")]
		public LegacyCV2Result<None> EKHDGHOFZTU(QVMTSXADWLM e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1282")]
		public LegacyCV2Result<None> NPRMFGESXTJ(QVMTSXADWLM e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1283")]
		public LegacyCV2Result<None> UIUREJSNEFD(QVMTSXADWLM e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1284")]
		public LegacyCV2Result<None> LPCFUSCBEXG(QVMTSXADWLM e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0")]
		public LegacyCV2Result<None> ConstantStorefrontItem(YJUHLGNCLGJ e, InOut io, [In] FRUNADSXITN storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1209")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(YJUHLGNCLGJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1198")]
		private LegacyCV2Result<None> GDNMBSNUVOJ(YJUHLGNCLGJ a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1207")]
		private LegacyCV2Result<None> YMJDZKPACQS(YJUHLGNCLGJ a, InOut b, [In] FRUNADSXITN storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "1248")]
		private LegacyCV2Result<None> UGNGAEERBOW(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class IWBEJETEGTC : BGVXMUJRESR
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(EXXELHLDWJQ node);

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly IWBEJETEGTC XHOMZVKVVEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate LAXDTXPSMRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate AGRARTCTTQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private bool XWBUPLZNSXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool PIPUSEGVSFN;

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x2805740", Offset = "0x2804B40", VA = "0x182805740", Slot = "4")]
		public Task<bool> HAHUDZFLYSK(EXXELHLDWJQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x2805770", Offset = "0x2804B70", VA = "0x182805770", Slot = "5")]
		public Task<bool> TUSOMCUGAER(EXXELHLDWJQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x2805820", Offset = "0x2804C20", VA = "0x182805820")]
		public IWBEJETEGTC([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x2805720", Offset = "0x2804B20", VA = "0x182805720", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? DDSRYWDMINY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010", Slot = "7")]
		public bool DIUWAAEZJGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x12D46D0", Offset = "0x12D3AD0", VA = "0x1812D46D0", Slot = "8")]
		public bool UQXQDXNCISH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class GZEVQBOVBNC : SNCTIYNYKWH
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid FIXEZHZXSEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
		public void Bind(YPYXIKNSSYH pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xE21890", Offset = "0xE20C90", VA = "0x180E21890")]
		public GZEVQBOVBNC(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2805610", Offset = "0x2804A10", VA = "0x182805610")]
		public static GZEVQBOVBNC New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class FVKZTWASYMO : RLVJBATMCRS
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<HESNLTWUPXP> nodeDefId, Id128<HUXETNCTSFJ>? legacyInnerGraphId, IReadOnlyDictionary<Id128<HUXETNCTSFJ>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private IsNodeRestrictedDelegate? PTEYLVWQYTL;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool BZMCSQZMIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool WEVJTVDRZCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2804670", Offset = "0x2803A70", VA = "0x182804670", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool KTZJUIKWTVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x1108B00", Offset = "0x1107F00", VA = "0x181108B00", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "6")]
		public bool XOWAUDNVFMH(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "7")]
		public CanSaveObjectIntoInventionResultType GEWZEUQMCUY(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2804680", Offset = "0x2803A80", VA = "0x182804680", Slot = "8")]
		public bool ZHMJYSNNNFR(Id128<HESNLTWUPXP> nodeDefId, Id128<HUXETNCTSFJ>? legacyInnerGraphId, IReadOnlyDictionary<Id128<HUXETNCTSFJ>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "9")]
		public bool VCPBXDMOCZK(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "10")]
		public bool LHAZNFVZUWO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x28046D0", Offset = "0x2803AD0", VA = "0x1828046D0")]
		public FVKZTWASYMO(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class WNOKMHFOQZW : MBZVONPYOWB
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly WNOKMHFOQZW XHOMZVKVVEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly ShouldLogEventSenderToMakerPenDelegate VWJPKUGLHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate KBCQTDTBZGK;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KIZVKGZPOSE
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0xFB7610", Offset = "0xFB6A10", VA = "0x180FB7610", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool GYIJZARORPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x280BCA0", Offset = "0x280B0A0", VA = "0x18280BCA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x280BD40", Offset = "0x280B140", VA = "0x18280BD40")]
		public WNOKMHFOQZW([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class FCBCRMYAPUS : KWWIFHUGOFY<PXOECLXUDAS>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class TOVDSILMOGR : PXOECLXUDAS, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public static readonly TOVDSILMOGR LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool NDERTCEYITZ
			{
				[Cpp2IlInjected.Token(Token = "0x600074E")]
				[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x2808CE0", Offset = "0x28080E0", VA = "0x182808CE0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			public void TCWTICWSHIX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public TOVDSILMOGR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly FCBCRMYAPUS LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private FCBCRMYAPUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x28045B0", Offset = "0x28039B0", VA = "0x1828045B0", Slot = "4")]
		public PXOECLXUDAS VUUHDRRTNGT()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class BINWPURGJUI<a, b> : IDisposable, GUDZVKDXAAH where a : notnull where b : notnull, XNBYFQARZPI.GHQHUOGIKCI<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly b MKZWHJKZWXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly a YRXDBKRTGHZ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<FJSVDCFYEAW> BMUYUDKVXKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<FJSVDCFYEAW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x5477660", Offset = "0x5476A60", VA = "0x185477660")]
		public BINWPURGJUI(b a, a b, Id32<FJSVDCFYEAW> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x6F65030", Offset = "0x6F64430", VA = "0x186F65030", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x6F65FB0", Offset = "0x6F653B0", VA = "0x186F65FB0")]
		public Id32<LPULDJDRFFP> KASDFMDPOOM([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<LPULDJDRFFP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x6F657F0", Offset = "0x6F64BF0", VA = "0x186F657F0", Slot = "6")]
		public void FJKNIUNFXPN(Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x6F66BB0", Offset = "0x6F65FB0", VA = "0x186F66BB0", Slot = "7")]
		public void QCPDVSOTSWN(Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x6F668B0", Offset = "0x6F65CB0", VA = "0x186F668B0", Slot = "8")]
		public void OQLUUZESNKS(Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x6F65A70", Offset = "0x6F64E70", VA = "0x186F65A70", Slot = "10")]
		public void HTOICIXKLDX(Id32<LPULDJDRFFP> objectId, Id32<FJSVDCFYEAW> clientId, RVLJZCKPUDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x6F66EB0", Offset = "0x6F662B0", VA = "0x186F66EB0", Slot = "9")]
		public void XVDJDCQYIWL(Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x6F65AB0", Offset = "0x6F64EB0", VA = "0x186F65AB0", Slot = "11")]
		public void HWFIGETLHIP(Id32<LPULDJDRFFP> objectId, YUCPDLXANTQ? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x6F654E0", Offset = "0x6F648E0", VA = "0x186F654E0", Slot = "12")]
		public Id32<FJSVDCFYEAW> EBCJKALLKNK(Id32<LPULDJDRFFP> objectId)
		{
			return default(Id32<FJSVDCFYEAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x6F66BF0", Offset = "0x6F65FF0", VA = "0x186F66BF0", Slot = "13")]
		public Id32<XWVACCFLESD> UFJQSHXUOZW(Id32<LPULDJDRFFP> objectId, string a, object b, bool c, TMGZVELNEAB d, SJRCXSMXJLR e)
		{
			return default(Id32<XWVACCFLESD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x6F66490", Offset = "0x6F65890", VA = "0x186F66490", Slot = "14")]
		public void MGTDCLFOEOQ(Id32<XWVACCFLESD> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x6F65F70", Offset = "0x6F65370", VA = "0x186F65F70", Slot = "15")]
		public void JCNKJHGJBLQ(Id32<XWVACCFLESD> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class XNBYFQARZPI
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface GHQHUOGIKCI<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void WWIMUQSQPPG(a a, Id32<FJSVDCFYEAW> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<FJSVDCFYEAW>? PYUXRLSJKAH(a a);

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<LPULDJDRFFP> KASDFMDPOOM(a a, Id32<FJSVDCFYEAW> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void FJKNIUNFXPN(a a, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC b);

			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void QCPDVSOTSWN(a a, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC b);

			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void HTOICIXKLDX(a a, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC b);

			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void XVDJDCQYIWL(a a, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC b);

			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void HWFIGETLHIP(a a, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, YUCPDLXANTQ? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<FJSVDCFYEAW>? EBCJKALLKNK(a a, Id32<LPULDJDRFFP> objectId);

			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<XWVACCFLESD> UFJQSHXUOZW(a a, Id32<FJSVDCFYEAW> clientId, string b, object c, TMGZVELNEAB d, SJRCXSMXJLR e);

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void MGTDCLFOEOQ(a a, Id32<FJSVDCFYEAW> clientId, Id32<XWVACCFLESD> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void JCNKJHGJBLQ(a a, Id32<FJSVDCFYEAW> clientId, Id32<XWVACCFLESD> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class NESOHSYJKEU
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public readonly HashSet<Id32<LPULDJDRFFP>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public SOAId32Field<XWVACCFLESD, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public readonly Dictionary<Id32<XWVACCFLESD>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<XWVACCFLESD>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAField<LPULDJDRFFP, YUCPDLXANTQ?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x2806780", Offset = "0x2805B80", VA = "0x182806780")]
			private MockCV2DynamicNetSys(HashSet<Id32<LPULDJDRFFP>> authorityOf, [In] SOAId32Field<XWVACCFLESD, MockCV2SyncField> syncFields, Dictionary<Id32<XWVACCFLESD>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<XWVACCFLESD>> mockSyncFieldToSyncField, [In] SOAField<LPULDJDRFFP, YUCPDLXANTQ?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x28065C0", Offset = "0x28059C0", VA = "0x1828065C0")]
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
			public Id32<FJSVDCFYEAW>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x2806820", Offset = "0x2805C20", VA = "0x182806820")]
			public MockCV2ObjectShared(Id32<FJSVDCFYEAW> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public SJRCXSMXJLR SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public TMGZVELNEAB SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
			internal MockCV2SyncField(SJRCXSMXJLR syncField, TMGZVELNEAB syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x2806940", Offset = "0x2805D40", VA = "0x182806940")]
			public static MockCV2SyncField New(SJRCXSMXJLR syncField, TMGZVELNEAB syncFieldChangeHandler)
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

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x28068F0", Offset = "0x2805CF0", VA = "0x1828068F0")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x28068A0", Offset = "0x2805CA0", VA = "0x1828068A0")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private SOAId32Field<LPULDJDRFFP, MockCV2ObjectShared> ZEWALHCMHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<LPULDJDRFFP>> VJXYVSLPYNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> YWWIRKCKRXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> ZTIJZLVMHCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private SOAField<FJSVDCFYEAW, MockCV2DynamicNetSys> MSEKLIXUIVD;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<LPULDJDRFFP>? TLUVUTYXMON
		{
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0xB9E4B0", Offset = "0xB9D8B0", VA = "0x180B9E4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0xF62EF0", Offset = "0xF622F0", VA = "0x180F62EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2806AE0", Offset = "0x2805EE0", VA = "0x182806AE0")]
		public void Destroy([In] SOAId32<FJSVDCFYEAW> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x28078D0", Offset = "0x2806CD0", VA = "0x1828078D0")]
		public void OZEZQCZXKDW(Id32<FJSVDCFYEAW> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x28080D0", Offset = "0x28074D0", VA = "0x1828080D0")]
		public void WWIMUQSQPPG(Id32<FJSVDCFYEAW> clientId, Id32<FJSVDCFYEAW>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2807330", Offset = "0x2806730", VA = "0x182807330")]
		public Id32<LPULDJDRFFP> KASDFMDPOOM(Id32<FJSVDCFYEAW> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<FJSVDCFYEAW> clientIds)
		{
			return default(Id32<LPULDJDRFFP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2807E70", Offset = "0x2807270", VA = "0x182807E70")]
		public Id32<XWVACCFLESD> UFJQSHXUOZW(Id32<FJSVDCFYEAW> clientId, string a, object b, TMGZVELNEAB c, SJRCXSMXJLR d)
		{
			return default(Id32<XWVACCFLESD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2807740", Offset = "0x2806B40", VA = "0x182807740")]
		public void MGTDCLFOEOQ(Id32<FJSVDCFYEAW> clientId, Id32<XWVACCFLESD> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2808590", Offset = "0x2807990", VA = "0x182808590")]
		public Id32<LPULDJDRFFP>? ZXHBDEXSXTD([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2806D70", Offset = "0x2806170", VA = "0x182806D70")]
		public void FJKNIUNFXPN([In] SOAId32<FJSVDCFYEAW> clientIds, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2807D30", Offset = "0x2807130", VA = "0x182807D30")]
		public void QCPDVSOTSWN(Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2806DF0", Offset = "0x28061F0", VA = "0x182806DF0")]
		public void HTOICIXKLDX(Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2808410", Offset = "0x2807810", VA = "0x182808410")]
		public void XVDJDCQYIWL([In] SOAId32<FJSVDCFYEAW> clientIds, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2806EF0", Offset = "0x28062F0", VA = "0x182806EF0")]
		public void HWFIGETLHIP(Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, YUCPDLXANTQ? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2806D20", Offset = "0x2806120", VA = "0x182806D20")]
		public Id32<FJSVDCFYEAW>? EBCJKALLKNK(Id32<LPULDJDRFFP> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2806FC0", Offset = "0x28063C0", VA = "0x182806FC0")]
		public void JCNKJHGJBLQ([In] SOAId32<FJSVDCFYEAW> clientIds, Id32<FJSVDCFYEAW> clientId, Id32<XWVACCFLESD> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2808660", Offset = "0x2807A60", VA = "0x182808660")]
		public NESOHSYJKEU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class TNWFOHKOINV
	{
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2808C80", Offset = "0x2808080", VA = "0x182808C80")]
		public static void Destroy(this NESOHSYJKEU.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class FYJJEVCFLVF : TKWDIMFKAOX.ALXXNXZFOSL
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static FYJJEVCFLVF REMVMIXVPWM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate FTZLJBFDEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate JLZETZZCTMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public FYJJEVCFLVF(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class GFLGYSGBDOL : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : YTIPMBUMKVK.IFNCQNHDDLL<VLXCXCSSZAI, GFLGYSGBDOL>
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
				public AsyncTaskMethodBuilder<Result<object, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public GFLGYSGBDOL root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public Id32<FJSVDCFYEAW> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public VLXCXCSSZAI action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				private TaskAwaiter<Result<object, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000798")]
				[Cpp2IlInjected.Address(RVA = "0x280AA70", Offset = "0x2809E70", VA = "0x18280AA70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000799")]
				[Cpp2IlInjected.Address(RVA = "0x280ACB0", Offset = "0x280A0B0", VA = "0x18280ACB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "4")]
			public int QAGHEKWISBL(GFLGYSGBDOL a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2808BF0", Offset = "0x2807FF0", VA = "0x182808BF0", Slot = "5")]
			public int QVHKPNEBTNR(GFLGYSGBDOL a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2808C10", Offset = "0x2808010", VA = "0x182808C10", Slot = "6")]
			public int QZQQGPCSCZK(GFLGYSGBDOL a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xC71310", Offset = "0xC70710", VA = "0x180C71310", Slot = "7")]
			public int VGGJFICIEUU(GFLGYSGBDOL a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2808C30", Offset = "0x2808030", VA = "0x182808C30", Slot = "8")]
			public void ZWDWZBNTLLF(GFLGYSGBDOL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "9")]
			public bool GEXEXFUISJG(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> actorId, VLXCXCSSZAI[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "10")]
			public bool TJFWXNXVXYK(GFLGYSGBDOL a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x2808AA0", Offset = "0x2807EA0", VA = "0x182808AA0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, RAGLFGQXJZI>> POBPBVGIKFU(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> senderId, VLXCXCSSZAI b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : YTIPMBUMKVK.GIAVPBUDCZA<ActionDeps, AUQKPBYPMDP.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps KFFNEQFMZVE
			{
				[Cpp2IlInjected.Token(Token = "0x600079A")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public AUQKPBYPMDP.StaticNetSysReceiverDeps HCLLXKAIVCJ
			{
				[Cpp2IlInjected.Token(Token = "0x600079B")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "5")]
				get
				{
					return default(AUQKPBYPMDP.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps BQEEJWMMTSM
			{
				[Cpp2IlInjected.Token(Token = "0x600079C")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : PUVQKBYLHCS.GHQHUOGIKCI<GFLGYSGBDOL>
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
				public AsyncTaskMethodBuilder<Result<object?, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				public GFLGYSGBDOL root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public Id32<FJSVDCFYEAW> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public VLXCXCSSZAI action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				private TaskAwaiter<Result<object?, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x280A750", Offset = "0x2809B50", VA = "0x18280A750", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079F")]
				[Cpp2IlInjected.Address(RVA = "0x280AA00", Offset = "0x2809E00", VA = "0x18280AA00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0x2806980", Offset = "0x2805D80", VA = "0x182806980", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, RAGLFGQXJZI>> POBPBVGIKFU(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> clientId, VLXCXCSSZAI b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : XNBYFQARZPI.GHQHUOGIKCI<GFLGYSGBDOL>
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x2806560", Offset = "0x2805960", VA = "0x182806560", Slot = "4")]
			public void WWIMUQSQPPG(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0xC71150", Offset = "0xC70550", VA = "0x180C71150", Slot = "5")]
			public Id32<FJSVDCFYEAW>? PYUXRLSJKAH(GFLGYSGBDOL a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x28061A0", Offset = "0x28055A0", VA = "0x1828061A0")]
			public Id32<LPULDJDRFFP> KASDFMDPOOM(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<LPULDJDRFFP>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2805FC0", Offset = "0x28053C0", VA = "0x182805FC0", Slot = "7")]
			public void FJKNIUNFXPN(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x28063A0", Offset = "0x28057A0", VA = "0x1828063A0", Slot = "8")]
			public void QCPDVSOTSWN(GFLGYSGBDOL a, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2806050", Offset = "0x2805450", VA = "0x182806050", Slot = "9")]
			public void HTOICIXKLDX(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2806590", Offset = "0x2805990", VA = "0x182806590", Slot = "10")]
			public void XVDJDCQYIWL(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, RVLJZCKPUDC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2806090", Offset = "0x2805490", VA = "0x182806090", Slot = "11")]
			public void HWFIGETLHIP(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> clientId, Id32<LPULDJDRFFP> objectId, YUCPDLXANTQ? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2805F60", Offset = "0x2805360", VA = "0x182805F60", Slot = "12")]
			public Id32<FJSVDCFYEAW>? EBCJKALLKNK(GFLGYSGBDOL a, Id32<LPULDJDRFFP> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2806500", Offset = "0x2805900", VA = "0x182806500", Slot = "13")]
			public Id32<XWVACCFLESD> UFJQSHXUOZW(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> clientId, string b, object c, TMGZVELNEAB d, SJRCXSMXJLR e)
			{
				return default(Id32<XWVACCFLESD>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2806200", Offset = "0x2805600", VA = "0x182806200", Slot = "14")]
			public void MGTDCLFOEOQ(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> clientId, Id32<XWVACCFLESD> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x2806170", Offset = "0x2805570", VA = "0x182806170", Slot = "15")]
			public void JCNKJHGJBLQ(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> clientId, Id32<XWVACCFLESD> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x28061A0", Offset = "0x28055A0", VA = "0x1828061A0", Slot = "6")]
			private Id32<LPULDJDRFFP> JKSJGSUTMYI(GFLGYSGBDOL a, Id32<FJSVDCFYEAW> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<LPULDJDRFFP>);
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
			public GFLGYSGBDOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public Id32<LPULDJDRFFP>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public PHMKKHZLINW deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private Id32<FJSVDCFYEAW> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC8")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private AFUEATRNTFO<GFLGYSGBDOL, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private BINWPURGJUI<GFLGYSGBDOL, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private AUQKPBYPMDP <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x280A090", Offset = "0x2809490", VA = "0x18280A090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x280A6E0", Offset = "0x2809AE0", VA = "0x18280A6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly WSSPQXXCMHO<VLXCXCSSZAI, None, AUQKPBYPMDP, ActionDeps, AUQKPBYPMDP.StaticNetSysReceiverDeps, RootDeps, GFLGYSGBDOL, Deps> RPGSVJGHMGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly NESOHSYJKEU SKBUXQQCIXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private SOAId32<FJSVDCFYEAW> OKZGDLGLWHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAField<FJSVDCFYEAW, None> MSEKLIXUIVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<FJSVDCFYEAW, AUQKPBYPMDP> XYYLALUJZPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Id32<FJSVDCFYEAW>? VCALGLDNUQS;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate PQOLRXGAPBC
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2804F60", Offset = "0x2804360", VA = "0x182804F60")]
		public GFLGYSGBDOL(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x28048A0", Offset = "0x2803CA0", VA = "0x1828048A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2804B50", Offset = "0x2803F50", VA = "0x182804B50")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> OZEZQCZXKDW(PHMKKHZLINW a, RegistryV2 b, Id32<LPULDJDRFFP>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2804CD0", Offset = "0x28040D0", VA = "0x182804CD0")]
		private void WWIMUQSQPPG(Id32<FJSVDCFYEAW> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2804A70", Offset = "0x2803E70", VA = "0x182804A70")]
		[CompilerGenerated]
		private Id32<LPULDJDRFFP>? HGGKDCURSBO([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class GMBOSZWJQDE : AYAZJFNSIFY.ALXXNXZFOSL
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<LBNGUKJCJSD> DeserializeCircuitsJunctionAsyncDelegate(AUQKPBYPMDP circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<LBNGUKJCJSD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public GMBOSZWJQDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public AUQKPBYPMDP circuitsManager;

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
			private TaskAwaiter<LBNGUKJCJSD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2808D80", Offset = "0x2808180", VA = "0x182808D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x2808F80", Offset = "0x2808380", VA = "0x182808F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate FXVIZSRJVDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly LifecycleDidInitializeDelegate? YMYMCECTUDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleWillDestroyDelegate? KGTYSBINBVU;

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x28052C0", Offset = "0x28046C0", VA = "0x1828052C0", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<LBNGUKJCJSD> HUXFUVOJXHQ(AUQKPBYPMDP a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xCE8010", Offset = "0xCE7410", VA = "0x180CE8010", Slot = "5")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xD80900", Offset = "0xD7FD00", VA = "0x180D80900", Slot = "6")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x2805430", Offset = "0x2804830", VA = "0x182805430")]
		public GMBOSZWJQDE([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class ZRMJWLFIAUA : HGEHYAJDPNG.ALXXNXZFOSL
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate IAPPTVDTDES GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<IMMUYPZLBKK> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<YVWXGRBPFFE> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<HGEHYAJDPNG.ALXXNXZFOSL.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<HGEHYAJDPNG.ALXXNXZFOSL.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public ZRMJWLFIAUA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			private TaskAwaiter<HGEHYAJDPNG.ALXXNXZFOSL.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0x2808FF0", Offset = "0x28083F0", VA = "0x182808FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0x28091E0", Offset = "0x28085E0", VA = "0x1828091E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<YVWXGRBPFFE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public ZRMJWLFIAUA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private TaskAwaiter<YVWXGRBPFFE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x2809250", Offset = "0x2808650", VA = "0x182809250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x2809440", Offset = "0x2808840", VA = "0x182809440", Slot = "5")]
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
			public AsyncTaskMethodBuilder<IMMUYPZLBKK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public ZRMJWLFIAUA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			private TaskAwaiter<IMMUYPZLBKK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x28094B0", Offset = "0x28088B0", VA = "0x1828094B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x28096A0", Offset = "0x2808AA0", VA = "0x1828096A0", Slot = "5")]
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
			public ZRMJWLFIAUA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x2809710", Offset = "0x2808B10", VA = "0x182809710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x2809900", Offset = "0x2808D00", VA = "0x182809900", Slot = "5")]
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
			public ZRMJWLFIAUA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x2809970", Offset = "0x2808D70", VA = "0x182809970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x2809B60", Offset = "0x2808F60", VA = "0x182809B60", Slot = "5")]
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
			public ZRMJWLFIAUA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x2809BD0", Offset = "0x2808FD0", VA = "0x182809BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x2809DC0", Offset = "0x28091C0", VA = "0x182809DC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly GetCV2DependenciesDelegate APBHWOTECYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetRoomDataAsyncDelegate NCKLTWWCCZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetSuperRoomDataAsyncDelegate VACMJUKLYRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetRoomAssetDataAsyncDelegate WRJSXXRNWPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetPlayerSaveDataAsyncDelegate GLMFDDOYKAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate QIPWQMTEZDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetStaticCircuitsConfigAsyncDelegate UXXOYIYRZNG;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public IAPPTVDTDES IAPPTVDTDES
		{
			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0xFB7610", Offset = "0xFB6A10", VA = "0x180FB7610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x280C730", Offset = "0x280BB30", VA = "0x18280C730", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> XHPKFUKJHMH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x280C400", Offset = "0x280B800", VA = "0x18280C400", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> DYOLREEIOFA(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x280C1E0", Offset = "0x280B5E0", VA = "0x18280C1E0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<IMMUYPZLBKK> AWRRCUBWSVH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x280C620", Offset = "0x280BA20", VA = "0x18280C620", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<YVWXGRBPFFE> SWZRLXEUJNM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x280C510", Offset = "0x280B910", VA = "0x18280C510", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<HGEHYAJDPNG.ALXXNXZFOSL.CircuitGraphToolMapping> KASVNQHQLQP(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x280C2F0", Offset = "0x280B6F0", VA = "0x18280C2F0", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> CYLWWOXDRGC(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x280C840", Offset = "0x280BC40", VA = "0x18280C840")]
		public ZRMJWLFIAUA(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class ESEWCEYYZUI : CV2Request.ALXXNXZFOSL
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly CV2Request.ALXXNXZFOSL LVYKDVFRYUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly GetCanSendRequestsDelegate QXHNDVZTVBC;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public ESEWCEYYZUI(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xFB7610", Offset = "0xFB6A10", VA = "0x180FB7610", Slot = "4")]
		public bool XXFOQFJZXEE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class WTTQIXBVUYP : WTTLBDSHSXM
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, XOJOHOBKPDS> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly TryReportErrToUserDelegate TCURRZPRUEM;

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x2805740", Offset = "0x2804B40", VA = "0x182805740")]
		public bool NDKAGIQIETY([In] Result<None, XOJOHOBKPDS> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x280C030", Offset = "0x280B430", VA = "0x18280C030")]
		public WTTQIXBVUYP([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x2805740", Offset = "0x2804B40", VA = "0x182805740", Slot = "4")]
		private bool GGNDZSIMRTH([In] Result<None, XOJOHOBKPDS> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class QJVZWVRSVWW : BSBAJWUIWZV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate YJUHLGNCLGJ CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public static readonly QJVZWVRSVWW LVYKDVFRYUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly CurrentExecParamsDelegate? BDQTNDSQKPW;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public YJUHLGNCLGJ ISFCJOCMICU
		{
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0xFB7610", Offset = "0xFB6A10", VA = "0x180FB7610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public QJVZWVRSVWW([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class VUICUFIRNPG : JKZPZKKOTQX
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly JKZPZKKOTQX LVYKDVFRYUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly GetGameColorFromIdDelegate UTBELCFTCMY;

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2805740", Offset = "0x2804B40", VA = "0x182805740", Slot = "4")]
		public CircuitsColor YEKJZVCOCSS(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x280BB00", Offset = "0x280AF00", VA = "0x18280BB00")]
		public VUICUFIRNPG([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class ATUMPKZMPWE : DYPXEDJBIXJ
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
			public ATUMPKZMPWE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public string context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600080E")]
			[Cpp2IlInjected.Address(RVA = "0x2809E30", Offset = "0x2809230", VA = "0x182809E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080F")]
			[Cpp2IlInjected.Address(RVA = "0x280A020", Offset = "0x2809420", VA = "0x18280A020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly IsStringPureAsyncDelegate CEOUGSDRCRN;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2804060", Offset = "0x2803460", VA = "0x182804060", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> FQKOMTSFLQD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x28041A0", Offset = "0x28035A0", VA = "0x1828041A0")]
		public ATUMPKZMPWE([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class OBELYOEOORY : REEYAUJRNNP
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate UVARJVBQTYZ? GetNodeVisualizationConfigDelegate([In] Id128<HESNLTWUPXP> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly REEYAUJRNNP LVYKDVFRYUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly GetNodeVisualizationConfigDelegate NCGBHSPMTXA;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2805740", Offset = "0x2804B40", VA = "0x182805740")]
		public UVARJVBQTYZ? XUZWRKKJLSE([In] Id128<HESNLTWUPXP> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2808870", Offset = "0x2807C70", VA = "0x182808870")]
		public OBELYOEOORY([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2805740", Offset = "0x2804B40", VA = "0x182805740", Slot = "4")]
		private UVARJVBQTYZ BQKGSUZYAIM([In] Id128<HESNLTWUPXP> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class GBRNLKGOAWN : IONTNODDBKQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x2804850", Offset = "0x2803C50", VA = "0x182804850", Slot = "4")]
		public JUWRUXWLBDH YEPRRGOHSQR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GBRNLKGOAWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class JBBMDXEKPPB : EXSBOVGLIDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly Dictionary<string, bool> OQGOQBUUEGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, float> DCDTLRNTONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, double> DLIJNMBSHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, int> SABRCVZAJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, long> ZQMWVIHZFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, string> AHBWZZKWYBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, uint> GJVKUHGOZXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, ulong> SONLDXQJFWJ;

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2805C50", Offset = "0x2805050", VA = "0x182805C50", Slot = "4")]
		public bool? GKSJGBWDQPA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x2805CF0", Offset = "0x28050F0", VA = "0x182805CF0")]
		public JBBMDXEKPPB()
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
