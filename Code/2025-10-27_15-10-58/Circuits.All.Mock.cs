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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B002B0", Offset = "0x2AFF2B0", VA = "0x182B002B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		internal sealed class TPGBPSABQLV : DAKHVQKUFGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public TPGBPSABQLV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0", Slot = "4")]
			public DAKHVQKUFGW WZLPCOQFMTW(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0", Slot = "5")]
			public DAKHVQKUFGW JJVLPSJELLF(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0", Slot = "6")]
			public DAKHVQKUFGW TOBKNLFNWJV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
			public void YTBFAQLEKEG()
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
	public static class INNNBULQJEG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class XDIBTWVITXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public DHDIWDIOMXF NQHNCZVDPZK;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XDIBTWVITXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B08650", Offset = "0x2B07650", VA = "0x182B08650")]
			internal ZZZJGZASNDB VQMOYBDRLXF(GetNetworkObjectDelegate a)
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
			public JVEJJWJVKSR dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public OJTYTSYFGFU network;

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
			[Cpp2IlInjected.Address(RVA = "0x2B05B90", Offset = "0x2B04B90", VA = "0x182B05B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B06230", Offset = "0x2B05230", VA = "0x182B06230", Slot = "5")]
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
			public OJTYTSYFGFU network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public JVEJJWJVKSR dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<LDCKCJVHREK>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ICGXRSEYDCA <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B062A0", Offset = "0x2B052A0", VA = "0x182B062A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B06830", Offset = "0x2B05830", VA = "0x182B06830", Slot = "5")]
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
			public DHDIWDIOMXF roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B068A0", Offset = "0x2B058A0", VA = "0x182B068A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B06DB0", Offset = "0x2B05DB0", VA = "0x182B06DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCA40", Offset = "0x2AFBA40", VA = "0x182AFCA40")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? RPRGRBPLUNT([Optional] DHDIWDIOMXF? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC30", Offset = "0x2AFBC30", VA = "0x182AFCC30")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> VDYIUAAITMG(OJTYTSYFGFU a, [Optional] JVEJJWJVKSR? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCDB0", Offset = "0x2AFBDB0", VA = "0x182AFCDB0")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> VDYIUAAITMG(OJTYTSYFGFU a, JVEJJWJVKSR b, RegistryV2 c, Id32<LDCKCJVHREK>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC970", Offset = "0x2AFB970", VA = "0x182AFC970")]
		public static (RuntimeFnRegistry, RuntimeFns) KHXSVJPGKZC()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCB30", Offset = "0x2AFBB30", VA = "0x182AFCB30")]
		public static (ExternalFnRegistry, ExternalFns) TKCWDBCKOKZ()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC8F0", Offset = "0x2AFB8F0", VA = "0x182AFC8F0")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static OJTYTSYFGFU CZELHSTLUMS(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class DPVHLCVSJKW
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate ZZZJGZASNDB CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public DPVHLCVSJKW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B057A0", Offset = "0x2B047A0", VA = "0x182B057A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B05B20", Offset = "0x2B04B20", VA = "0x182B05B20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly OJTYTSYFGFU VUGYTEUNJGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? GNNFCMWYMFO;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		private DPVHLCVSJKW(OJTYTSYFGFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBF60", Offset = "0x2AFAF60", VA = "0x182AFBF60")]
		public static DPVHLCVSJKW PZMODGNNSPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC010", Offset = "0x2AFB010", VA = "0x182AFC010")]
		public DPVHLCVSJKW SOENXNDKKOT(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC030", Offset = "0x2AFB030", VA = "0x182AFC030")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> YTBFAQLEKEG()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class NNYQQBGNXOI : ICGXRSEYDCA.ICTTKLBYQGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate ZBDLQYWPAME NewCircuitsLifecycleDelegate(VFCMMUNYJTZ.ICTTKLBYQGC deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(ICGXRSEYDCA circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(ICGXRSEYDCA circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate SLHALHVXXWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate CFUOQCTOEOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate RKYBCRSHSPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate BKTEJSXLOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate UISBSJFQJWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate VKPCEBFAFAZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int UVNQWCUIGRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1389710", Offset = "0x1388710", VA = "0x181389710", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF9A0", Offset = "0x2AFE9A0", VA = "0x182AFF9A0", Slot = "6")]
		public void GTYVTIEZIJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF9D0", Offset = "0x2AFE9D0", VA = "0x182AFF9D0", Slot = "7")]
		public void ZYOXWTOMFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF970", Offset = "0x2AFE970", VA = "0x182AFF970", Slot = "5")]
		public ZBDLQYWPAME DDGSJNGYEUP(VFCMMUNYJTZ.ICTTKLBYQGC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xFD6C10", Offset = "0xFD5C10", VA = "0x180FD6C10", Slot = "8")]
		public void HOYSMFAEHEU(ICGXRSEYDCA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xFD6BE0", Offset = "0xFD5BE0", VA = "0x180FD6BE0", Slot = "9")]
		public void YPAMYJIIZAR(ICGXRSEYDCA a, AGLENQQYPWD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFA00", Offset = "0x2AFEA00", VA = "0x182AFFA00")]
		public NNYQQBGNXOI([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly QUFIWQZKMRB<OJTYTSYFGFU, OJTYTSYFGFU.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly QBYDPTCZCSP<OJTYTSYFGFU, OJTYTSYFGFU.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly ICGXRSEYDCA CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<DQQOGREBWGB> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly OJTYTSYFGFU Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC120", Offset = "0x2AFB120", VA = "0x182AFC120")]
		public EVCreationResult(QUFIWQZKMRB<OJTYTSYFGFU, OJTYTSYFGFU.MockStaticNetSysDeps> staticNetSys, QBYDPTCZCSP<OJTYTSYFGFU, OJTYTSYFGFU.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, ICGXRSEYDCA circuitsManager, Id32<DQQOGREBWGB> clientId, OJTYTSYFGFU network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly ICGXRSEYDCA _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 PCGPMKSFGFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF3F0", Offset = "0x2AFE3F0", VA = "0x182AFF3F0")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request QDTWMNGQOPY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF3C0", Offset = "0x2AFE3C0", VA = "0x182AFF3C0")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AGDBBCFQBWL? JHRYTXTXSWG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF2D0", Offset = "0x2AFE2D0", VA = "0x182AFF2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SDUXUOJZYIJ? SJCOOQFJORS
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF270", Offset = "0x2AFE270", VA = "0x182AFF270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
		internal LimitedCircuits(ICGXRSEYDCA circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class RTMPRAZYUGG : JVEJJWJVKSR
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ULCVYJVRYIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ZZZJGZASNDB LSWZGCMQPOL;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public ULCVYJVRYIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			internal ZZZJGZASNDB DLRFBHWQPLL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public VFCMMUNYJTZ.ICTTKLBYQGC JBBUTJZDDDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ICGXRSEYDCA.ICTTKLBYQGC QHTVSOSZHGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DEAYNPZYJML.ICTTKLBYQGC CKPYCFTRELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA> CAKQIGJUQSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.ICTTKLBYQGC OQRIIKETKQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DUQMTWSATKX EBSKGPJZCIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public YVVNDNVNRHU WFSNWXDAMMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public XDGOQWUJYOU FXOHAPKJXTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public QMQBHLTBDHS KRYVXSVOULN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xACEE90", Offset = "0xACDE90", VA = "0x180ACEE90", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FTANEFSKGGW JPCFVWXLNYV
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xACEE70", Offset = "0xACDE70", VA = "0x180ACEE70", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B01050", Offset = "0x2B00050", VA = "0x182B01050")]
		private RTMPRAZYUGG(VFCMMUNYJTZ.ICTTKLBYQGC a, ICGXRSEYDCA.ICTTKLBYQGC b, DEAYNPZYJML.ICTTKLBYQGC c, WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA> d, CV2Request.ICTTKLBYQGC e, DUQMTWSATKX f, YVVNDNVNRHU g, XDGOQWUJYOU h, QMQBHLTBDHS i, FTANEFSKGGW j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B00CF0", Offset = "0x2AFFCF0", VA = "0x182B00CF0")]
		public static RTMPRAZYUGG? XQTUAFQQZQB(DEAYNPZYJML.ICTTKLBYQGC cv2RootSysDeps, [Optional] VFCMMUNYJTZ.ICTTKLBYQGC? a, [Optional] ICGXRSEYDCA.ICTTKLBYQGC? b, [Optional] WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>? reducerDeps, [Optional] CV2Request.ICTTKLBYQGC? c, [Optional] DUQMTWSATKX? d, [Optional] YVVNDNVNRHU? e, [Optional] XDGOQWUJYOU? f, [Optional] QMQBHLTBDHS? g, [Optional] FTANEFSKGGW? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B00BA0", Offset = "0x2AFFBA0", VA = "0x182B00BA0")]
		public static RTMPRAZYUGG LPREMOWKSWX(ZZZJGZASNDB a, [Optional] VFCMMUNYJTZ.ICTTKLBYQGC? circuitsLifecycleDeps, [Optional] ICGXRSEYDCA.ICTTKLBYQGC? circuitsManagerDeps, [Optional] WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B00840", Offset = "0x2AFF840", VA = "0x182B00840")]
		public static RTMPRAZYUGG KLJIQLJRAIX(GetNetworkObjectDelegate a, [Optional] VFCMMUNYJTZ.ICTTKLBYQGC? circuitsLifecycleDeps, [Optional] ICGXRSEYDCA.ICTTKLBYQGC? circuitsManagerDeps, [Optional] WCTDSBTONCL.XRRCBJBDPQX<ActionKind, AGLENQQYPWD, ICGXRSEYDCA>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class SLHYEFIGLQT
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class LCEQAKIHZSA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public GetNetworkObjectDelegate LSHUDPOIJYT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int DMEJUEMYPNN;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public LCEQAKIHZSA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF150", Offset = "0x2AFE150", VA = "0x182AFF150")]
			internal TIVPUTBUVWI GDPRVVOZNJZ(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEFF0", Offset = "0x2AFDFF0", VA = "0x182AFEFF0")]
			internal TIVPUTBUVWI[] GDKKYOVCDYQ(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0")]
			internal int VAOPSQSCZMQ()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class LCJWXRCFJDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public DynamicEnvironmentNetworkId DEFHIIWJWCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public LCEQAKIHZSA OYIFPNPIBTY;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public LCJWXRCFJDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF1C0", Offset = "0x2AFE1C0", VA = "0x182AFF1C0")]
			internal TIVPUTBUVWI BEOYFQRUNIH(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly VBDHXKKGPBY YJKZYGJYFPZ;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B011F0", Offset = "0x2B001F0", VA = "0x182B011F0")]
		public static TIVPUTBUVWI? GCAIJCAURVZ(Id32<LDCKCJVHREK>? networkObject, [Optional] VAQVBPDUBEX.SerializesIntoSavesDelegate? a, [Optional] VAQVBPDUBEX.SerializesIntoInventionsDelegate? b, [Optional] VAQVBPDUBEX.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B01210", Offset = "0x2B00210", VA = "0x182B01210")]
		public static ZZZJGZASNDB? RDGMCZXYHTU(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] RRPMJEEQJEK? b, [Optional] AMNDPFWHNKI? c, [Optional] IHDRNCRJSLE? d, [Optional] DHDIWDIOMXF? e, int f = 300000, bool g = false, bool h = false, [Optional] FCCFZFMJBAQ? i, [Optional] ZHZFUFTMDLS? j, [Optional] ORIVMHCKQXB? k, [Optional] OTMBQSUFRSO? l, [Optional] FMAFFTQCCOX? m, [Optional] VZTYKJEGQCC? n, [Optional] CIEXTHALXFY.ICTTKLBYQGC? o, [Optional] EqualsNodeV2.ICTTKLBYQGC? p, [Optional] JQBXOMLBUJO? q, [Optional] ZZZJGZASNDB.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] ZZZJGZASNDB.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] ZZZJGZASNDB.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] ZZZJGZASNDB.GetLocalRoomIdDelegate? u, [Optional] ZZZJGZASNDB.GetLocalSubroomIdDelegate? v, [Optional] ZZZJGZASNDB.GetSubroomIdsForLocalRoomDelegate? w, [Optional] ZZZJGZASNDB.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] ZZZJGZASNDB.SaveRoomOnPlayerBehalfDelegate? z, [Optional] ZZZJGZASNDB.ReportCloudDataLedgerChangedDelegate? ba, [Optional] ZZZJGZASNDB.GetColorNameByIdDelegate? bb, [Optional] ZZZJGZASNDB.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] ZZZJGZASNDB.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] ZZZJGZASNDB.GetTaggableNameFromSignalDelegate? be, [Optional] ZZZJGZASNDB.GetAudioNameFromSignalDelegate? bf, [Optional] ZZZJGZASNDB.GetDestinationNameFromSignalDelegate? bg, [Optional] ZZZJGZASNDB.GetPlayerEventNameFromSignalDelegate? bh, [Optional] ZZZJGZASNDB.GetRoomKeyNameFromSignalDelegate? bi, [Optional] ZZZJGZASNDB.GetRewardNameFromSignalDelegate? bj, [Optional] ZZZJGZASNDB.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] ZZZJGZASNDB.ReportPreloadedAudioChangedDelegate? bl, [Optional] ZZZJGZASNDB.ReportRewardDataChangedDelegate? bm, [Optional] ZZZJGZASNDB.GetConsumableNameFromSignalDelegate? bn, [Optional] ZZZJGZASNDB.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] ZZZJGZASNDB.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] ZZZJGZASNDB.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] ZZZJGZASNDB.GetInventoryItemNameFromSignalDelegate? br, [Optional] ZZZJGZASNDB.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] ZZZJGZASNDB.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] ZZZJGZASNDB.GetRoomOfferNameFromSignalDelegate? bu, [Optional] ZZZJGZASNDB.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] ZZZJGZASNDB.GetObjectIdFromCreationObjectDelegate? bw, [Optional] ZZZJGZASNDB.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] ZZZJGZASNDB.GetCostInBytesDelegate? by, [Optional] ZZZJGZASNDB.GetAvatarItemNameFromSignalDelegate? bz, [Optional] ZZZJGZASNDB.PersistenceViewExistsAsReplicatorWithGraphDelegate? ca, [Optional] ZZZJGZASNDB.DownloadCircuitTemplateRootDataDelegate? cb, [Optional] ZZZJGZASNDB.GetDiscoverySectionNameFromSignalDelegate? cc, [Optional] ZZZJGZASNDB.GetStoreItemNameFromSignalDelegate? cd, [Optional] ZZZJGZASNDB.GetBodyPartNameFromSignalDelegate? ce, [Optional] ZZZJGZASNDB.GetDependenciesForGraphInstanceDelegate? cf, [Optional] ZZZJGZASNDB.GetAllDependenciesForEnvironmentDelegate? cg, [Optional] ZZZJGZASNDB.GetPlayerAccountNameFromSignalDelegate? ch, [Optional] ZZZJGZASNDB.GetRecNetImageNameFromSignalDelegate? ci, [Optional] ZZZJGZASNDB.GetRecNetMeshNameFromSignalDelegate? cj, [Optional] LogDeps? ck, [Optional] ZZZJGZASNDB.IsFunctionValidForAIDelegate? cl, [Optional] ZZZJGZASNDB.GetAIFunctionNameFromSignalDelegate? cm)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<LDCKCJVHREK>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class TUGASKDYNZS : ORIVMHCKQXB
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly TUGASKDYNZS HNQVBJEYTYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly GetLocalPlayerDelegate? JJYSKDZTEQH;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2B055D0", Offset = "0x2B045D0", VA = "0x182B055D0", Slot = "4")]
		public (LILOZAEUCBM, LILOZAEUCBM, LILOZAEUCBM, LILOZAEUCBM, LILOZAEUCBM) OUBLPABJXIG(object a)
		{
			return default((LILOZAEUCBM, LILOZAEUCBM, LILOZAEUCBM, LILOZAEUCBM, LILOZAEUCBM));
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2B055A0", Offset = "0x2B045A0", VA = "0x182B055A0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "6")]
		public bool ZRJXSFPYKWJ(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xB2FB20", Offset = "0xB2EB20", VA = "0x180B2FB20", Slot = "7")]
		public string UPPJSRUCQIJ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public TUGASKDYNZS([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class VAQVBPDUBEX : TIVPUTBUVWI
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(VAQVBPDUBEX self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(VAQVBPDUBEX self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(VAQVBPDUBEX self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly SerializesIntoSavesDelegate FKWROGAHDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoInventionsDelegate OKDUAGGIKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly CanPublishInInventionsDelegate KSFJQUCECAQ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private EOYLHKWAWHG? AWBCZQBZHJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId BWETHJDGSYR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1097F30", Offset = "0x1096F30", VA = "0x181097F30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CPJFXHWSXKW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B08620", Offset = "0x2B07620", VA = "0x182B08620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool HIEXUTPVVTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2B085F0", Offset = "0x2B075F0", VA = "0x182B085F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool GKGTCIHVGRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2B085C0", Offset = "0x2B075C0", VA = "0x182B085C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KGYRQSTBRMP? IWCPKWKBFPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<LDCKCJVHREK>? UPPUPRDQRLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B08470", Offset = "0x2B07470", VA = "0x182B08470", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B07F00", Offset = "0x2B06F00", VA = "0x182B07F00", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(VBDHXKKGPBY e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490", Slot = "13")]
		public void Bind(EOYLHKWAWHG controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B08510", Offset = "0x2B07510", VA = "0x182B08510")]
		private VAQVBPDUBEX(Id32<LDCKCJVHREK>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B07FA0", Offset = "0x2B06FA0", VA = "0x182B07FA0")]
		public static VAQVBPDUBEX? New(Id32<LDCKCJVHREK>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class CQLASECPMXF : FCCFZFMJBAQ
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
		public static readonly CQLASECPMXF HNQVBJEYTYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly RoundToDecimalPlaceDelegate? UUBJGZJRHXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly TruncateToDecimalPlaceDelegate? GICKZEEFTAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly CircuitsColorLerpDelegate? QKTRNHPYPZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorInverseLerpDelegate? TZZTTDESUES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsMtx4x4GetPositionDelegate? PZPBZEBPNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetRotationDelegate? XLERMRQBDWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4InverseDelegate? MEFARGMTBIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4MultiplyDelegate? EFIWIHGYCXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? BTLVJJXTIDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsQuatDotDelegate? TFXFKULXUWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatFromAngleAxisDelegate? RXUBMLRAZUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? IHHNGAQCDTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromFromToRotationDelegate? NMREOHOZWDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromLookRotationDelegate? STEHKTIQPVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? MYOHGDIUZXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatInverseDelegate? BVHBHYCXXPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatLerpDelegate? DYRSSZBGHQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpUnclampedDelegate? RVOVQWSOPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseLerpDelegate? NWVEHCYMEXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatMultiplyDelegate? RJLCXOWZPCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatNormalizeDelegate? GHZVMIZRGKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatRotateTowardsDelegate? FHHBMVUZUTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateVectorDelegate? MDWDQUEZBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatSlerpDelegate? RDBPROYYPBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatToAngleAxisDelegate? PJUWQIJUGCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToEulerAnglesDelegate? XSYVKTNOPRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsVec3AddDelegate? GPZQABDISEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? MIMQMENVRCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? JGXMOXIMXVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3CrossDelegate? DJKKXLCKCPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3DotDelegate? OWUSIDPCGNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3AngleDelegate? OQADJRIUADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3GetMagnitudeDelegate? EVWMDHQLPXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3LerpDelegate? CVRAYJSSFYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpUnclampedDelegate? BQVDOWZKOKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3InverseLerpDelegate? TJLXMQSCAXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3MoveTowardsDelegate? VCVCVWMACYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3NegateDelegate? AQVFJENVIAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NormalizeDelegate? WMVEDYUUPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3ProjectDelegate? YNVQAXKZTQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? RATWWHOHJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ScaleDelegate? AWXRQLGDFER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3SmoothDampDelegate? QNKACALSCUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SubtractDelegate? QSKBOITKPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SlerpDelegate? DVIKRWHABOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3TransformDelegate? XDYKEFOSSRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3InverseTransformDelegate? XVRFYCTXHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly RealtimeSinceStartupDelegate? DAOTIANWCLW;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAB10", Offset = "0x2AF9B10", VA = "0x182AFAB10")]
		public CQLASECPMXF([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA700", Offset = "0x2AF9700", VA = "0x182AFA700")]
		public float WUNHDFQWQSM([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8B60", Offset = "0x2AF7B60", VA = "0x182AF8B60")]
		public float BCGOYAOBXCU([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA4A0", Offset = "0x2AF94A0", VA = "0x182AFA4A0")]
		public CircuitsColor VIMBYOXUPQR([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA7F0", Offset = "0x2AF97F0", VA = "0x182AFA7F0")]
		public float XENISWPMFJD([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9A80", Offset = "0x2AF8A80", VA = "0x182AF9A80")]
		public CircuitsVec3 LKVDRUJTNZJ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA640", Offset = "0x2AF9640", VA = "0x182AFA640")]
		public CircuitsQuat WNWLWAMYANY([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA210", Offset = "0x2AF9210", VA = "0x182AFA210")]
		public CircuitsMtx4x4 TERISGAZZLS([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA8D0", Offset = "0x2AF98D0", VA = "0x182AFA8D0")]
		public CircuitsMtx4x4 ZGWHOLGLNSA([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF89C0", Offset = "0x2AF79C0", VA = "0x182AF89C0")]
		public CircuitsMtx4x4 AAWIZGMJXJW([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9620", Offset = "0x2AF8620", VA = "0x182AF9620")]
		public float IFSZTPUNDWR([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9120", Offset = "0x2AF8120", VA = "0x182AF9120")]
		public CircuitsQuat ERBEVCFAJEY(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8C80", Offset = "0x2AF7C80", VA = "0x182AF8C80")]
		public CircuitsQuat BYKYGPJPVJB([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9D20", Offset = "0x2AF8D20", VA = "0x182AF9D20")]
		public CircuitsQuat NJHGUXFENOR([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF99D0", Offset = "0x2AF89D0", VA = "0x182AF99D0")]
		public CircuitsQuat LSFBEJRUCJN([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9640", Offset = "0x2AF8640", VA = "0x182AF9640")]
		public CircuitsQuat SIHHIOFSRQO([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8AA0", Offset = "0x2AF7AA0", VA = "0x182AF8AA0")]
		public CircuitsQuat ESENJLNRPSX([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8EA0", Offset = "0x2AF7EA0", VA = "0x182AF8EA0")]
		public CircuitsQuat DHQMUAOLBFA([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9310", Offset = "0x2AF8310", VA = "0x182AF9310")]
		public float HGATOMPYXRB([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9DD0", Offset = "0x2AF8DD0", VA = "0x182AF9DD0")]
		public CircuitsQuat NZCBAIUTGUC([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA090", Offset = "0x2AF9090", VA = "0x182AFA090")]
		public CircuitsQuat PMWDZNDTGEJ([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8DE0", Offset = "0x2AF7DE0", VA = "0x182AF8DE0")]
		public CircuitsQuat DALOZIRSNXJ([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF90B0", Offset = "0x2AF80B0", VA = "0x182AF90B0")]
		public CircuitsVec3 EIOIXKPUXUS([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8B80", Offset = "0x2AF7B80", VA = "0x182AF8B80")]
		public CircuitsQuat BIDUYYKTTFM([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8C40", Offset = "0x2AF7C40", VA = "0x182AF8C40")]
		public void ICOXODLSUTN([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA790", Offset = "0x2AF9790", VA = "0x182AFA790")]
		public CircuitsVec3 XCUFGZUGWBK([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA720", Offset = "0x2AF9720", VA = "0x182AFA720")]
		public CircuitsVec3 WWLSHJFJXPD([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9410", Offset = "0x2AF8410", VA = "0x182AF9410")]
		public CircuitsVec3 HWBNQISPZUB([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9AE0", Offset = "0x2AF8AE0", VA = "0x182AF9AE0")]
		public CircuitsVec3 LLPZRJFSFLU([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF93A0", Offset = "0x2AF83A0", VA = "0x182AF93A0")]
		public CircuitsVec3 HJORMPKRESC([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9090", Offset = "0x2AF8090", VA = "0x182AF9090")]
		public float EBENAMVYAPP([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9D00", Offset = "0x2AF8D00", VA = "0x182AF9D00")]
		public float NHRQFBOFKAV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA020", Offset = "0x2AF9020", VA = "0x182AFA020")]
		public float WXZQQAEVEIM([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9BB0", Offset = "0x2AF8BB0", VA = "0x182AF9BB0")]
		public CircuitsVec3 LTCTTUNVTBF([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9020", Offset = "0x2AF8020", VA = "0x182AF9020")]
		public CircuitsVec3 EASVVYQVWMC([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D20", Offset = "0x2AF7D20", VA = "0x182AF8D20")]
		public float CPFQITEPIQL([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF92A0", Offset = "0x2AF82A0", VA = "0x182AF92A0")]
		public CircuitsVec3 HBCMFONCJIN([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9970", Offset = "0x2AF8970", VA = "0x182AF9970")]
		public CircuitsVec3 KGVBGMSKBNC([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9340", Offset = "0x2AF8340", VA = "0x182AF9340")]
		public CircuitsVec3 HJEYJMIPSCR([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8A30", Offset = "0x2AF7A30", VA = "0x182AF8A30")]
		public CircuitsVec3 ALPJYUAXFWX([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9900", Offset = "0x2AF8900", VA = "0x182AF9900")]
		public CircuitsVec3 KBRTQAMXKBS([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9F40", Offset = "0x2AF8F40", VA = "0x182AF9F40")]
		public CircuitsVec3 ONVTGCDOREQ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA820", Offset = "0x2AF9820", VA = "0x182AFA820")]
		public CircuitsVec3 YPUSVNCBOWG([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA280", Offset = "0x2AF9280", VA = "0x182AFA280")]
		public CircuitsVec3 TRIEGTHXGXU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF95B0", Offset = "0x2AF85B0", VA = "0x182AF95B0")]
		public CircuitsVec3 ICZMUAIOXNA([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA560", Offset = "0x2AF9560", VA = "0x182AFA560")]
		public CircuitsVec3 WKPIJCOUPFY([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AF97C0", Offset = "0x2AF87C0", VA = "0x182AF97C0")]
		public CircuitsVec3 JJLHNZIJLFA([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA1E0", Offset = "0x2AF91E0", VA = "0x182AFA1E0", Slot = "50")]
		public Task SZRFWMWSDDY(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "51")]
		public void MLOKZBMVYAS([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA130", Offset = "0x2AF9130", VA = "0x182AFA130", Slot = "52")]
		public WKUYAUAYQMR<JCUVPIZWEBL> QIPEGVNWZBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA040", Offset = "0x2AF9040", VA = "0x182AFA040", Slot = "53")]
		public WKUYAUAYQMR<JCUVPIZWEBL> PLUQNWGRDKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D50", Offset = "0x2AF7D50", VA = "0x182AF8D50", Slot = "54")]
		public float CRQUWBLWYZF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA700", Offset = "0x2AF9700", VA = "0x182AFA700", Slot = "4")]
		private float WSWNNTYEXAO([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8B60", Offset = "0x2AF7B60", VA = "0x182AF8B60", Slot = "5")]
		private float TXJMLDVQYCO([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9B50", Offset = "0x2AF8B50", VA = "0x182AF9B50", Slot = "6")]
		private CircuitsColor LRBMMMBIAUL([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA7F0", Offset = "0x2AF97F0", VA = "0x182AFA7F0", Slot = "7")]
		private float ZKJCIDALMCH([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9240", Offset = "0x2AF8240", VA = "0x182AF9240", Slot = "8")]
		private CircuitsVec3 GYYYNVYSHYR([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9480", Offset = "0x2AF8480", VA = "0x182AF9480", Slot = "9")]
		private CircuitsQuat HWUFBGJNDZS([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA2F0", Offset = "0x2AF92F0", VA = "0x182AFA2F0", Slot = "10")]
		private CircuitsMtx4x4 TTENNPSVGTY([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF98A0", Offset = "0x2AF88A0", VA = "0x182AF98A0", Slot = "11")]
		private CircuitsMtx4x4 JQMGTSTFEDY([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA180", Offset = "0x2AF9180", VA = "0x182AFA180", Slot = "12")]
		private CircuitsMtx4x4 QRACBZVRKRE([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9620", Offset = "0x2AF8620", VA = "0x182AF9620", Slot = "13")]
		private float PFXIOMULPFB([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9120", Offset = "0x2AF8120", VA = "0x182AF9120", Slot = "14")]
		private CircuitsQuat HHCAPDQGNHU(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8C80", Offset = "0x2AF7C80", VA = "0x182AF8C80", Slot = "15")]
		private CircuitsQuat YZJHWTITHWN([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9D20", Offset = "0x2AF8D20", VA = "0x182AF9D20", Slot = "16")]
		private CircuitsQuat SHLFFMKBWXV([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2AF99D0", Offset = "0x2AF89D0", VA = "0x182AF99D0", Slot = "17")]
		private CircuitsQuat KMAVCBBBBZH([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9640", Offset = "0x2AF8640", VA = "0x182AF9640", Slot = "18")]
		private CircuitsQuat IMUPZBOTZFO([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8AA0", Offset = "0x2AF7AA0", VA = "0x182AF8AA0", Slot = "19")]
		private CircuitsQuat ASBDNBKHKZP([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8EA0", Offset = "0x2AF7EA0", VA = "0x182AF8EA0", Slot = "20")]
		private CircuitsQuat WNRANECCMOQ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9310", Offset = "0x2AF8310", VA = "0x182AF9310", Slot = "21")]
		private float XTVMQBPWHGN([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9DD0", Offset = "0x2AF8DD0", VA = "0x182AF9DD0", Slot = "22")]
		private CircuitsQuat QLEYMAUPVWI([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA090", Offset = "0x2AF9090", VA = "0x182AFA090", Slot = "23")]
		private CircuitsQuat RPMNBVRMZUP([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8DE0", Offset = "0x2AF7DE0", VA = "0x182AF8DE0", Slot = "24")]
		private CircuitsQuat FACLINURJWV([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9750", Offset = "0x2AF8750", VA = "0x182AF9750", Slot = "25")]
		private CircuitsVec3 JGBBAKTECOY([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8B80", Offset = "0x2AF7B80", VA = "0x182AF8B80", Slot = "26")]
		private CircuitsQuat PVPODFPSEIM([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8C40", Offset = "0x2AF7C40", VA = "0x182AF8C40", Slot = "27")]
		private void BIXNHOOVTQB([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8FC0", Offset = "0x2AF7FC0", VA = "0x182AF8FC0", Slot = "28")]
		private CircuitsVec3 DQKWPHWVODE([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF94D0", Offset = "0x2AF84D0", VA = "0x182AF94D0", Slot = "29")]
		private CircuitsVec3 IAYSIMXHIWH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF96E0", Offset = "0x2AF86E0", VA = "0x182AF96E0", Slot = "30")]
		private CircuitsVec3 JFMOHQRUHBN([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA5D0", Offset = "0x2AF95D0", VA = "0x182AFA5D0", Slot = "31")]
		private CircuitsVec3 WMOGHCUAYSM([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA3C0", Offset = "0x2AF93C0", VA = "0x182AFA3C0", Slot = "32")]
		private CircuitsVec3 UGEAZWJEGVW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA430", Offset = "0x2AF9430", VA = "0x182AFA430", Slot = "33")]
		private CircuitsVec3 UHOKFVZODAY([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2AF91D0", Offset = "0x2AF81D0", VA = "0x182AF91D0", Slot = "34")]
		private CircuitsVec3 GEQSRBJIELC([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9090", Offset = "0x2AF8090", VA = "0x182AF9090", Slot = "35")]
		private float NUCQCTLKCRN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9D00", Offset = "0x2AF8D00", VA = "0x182AF9D00", Slot = "36")]
		private float YJPMMSBZMDF([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA020", Offset = "0x2AF9020", VA = "0x182AFA020", Slot = "37")]
		private float PEMASNIEZLA([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9C90", Offset = "0x2AF8C90", VA = "0x182AF9C90", Slot = "38")]
		private CircuitsVec3 NHKJOTQNWUZ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9540", Offset = "0x2AF8540", VA = "0x182AF9540", Slot = "39")]
		private CircuitsVec3 ICBDYRWJUFK([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D20", Offset = "0x2AF7D20", VA = "0x182AF8D20", Slot = "40")]
		private float QWKZXKYRJLT([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA350", Offset = "0x2AF9350", VA = "0x182AFA350", Slot = "41")]
		private CircuitsVec3 TXNZFGJYYJN([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA500", Offset = "0x2AF9500", VA = "0x182AFA500", Slot = "42")]
		private CircuitsVec3 VKZVWBRJTHY([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8F60", Offset = "0x2AF7F60", VA = "0x182AF8F60", Slot = "43")]
		private CircuitsVec3 DMEOGOIQANB([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA690", Offset = "0x2AF9690", VA = "0x182AFA690", Slot = "44")]
		private CircuitsVec3 WRHDQMPEKWZ([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9830", Offset = "0x2AF8830", VA = "0x182AF9830", Slot = "45")]
		private CircuitsVec3 JJLYHHUEHEG([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9C20", Offset = "0x2AF8C20", VA = "0x182AF9C20", Slot = "46")]
		private CircuitsVec3 MTJEDWQLCSG([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9E80", Offset = "0x2AF8E80", VA = "0x182AF9E80", Slot = "47")]
		private CircuitsVec3 OMXHPJCDYVO([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D70", Offset = "0x2AF7D70", VA = "0x182AF8D70", Slot = "48")]
		private CircuitsVec3 CVHKYKSNLAA([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9FB0", Offset = "0x2AF8FB0", VA = "0x182AF9FB0", Slot = "49")]
		private CircuitsVec3 OOJBQYSWYEM([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class XHQYGVEUQLB : SRDURDKBZQY
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1401F40", Offset = "0x1400F40", VA = "0x181401F40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2173AB0", Offset = "0x2172AB0", VA = "0x182173AB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2B08940", Offset = "0x2B07940", VA = "0x182B08940")]
		public XHQYGVEUQLB(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class DKCOTBMXLAD : ZHZFUFTMDLS
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(HZVEPBQCNVR e, ATGBVKSGZZE invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly DKCOTBMXLAD HNQVBJEYTYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly GetCircuitsColorFromColorIndexDelegate? NEHTNSUPSHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? YCOGDARTGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly InvisibleCollisionSetEnabledDelegate? TWCUBIXNART;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xE84FF0", Offset = "0xE83FF0", VA = "0x180E84FF0")]
		public DKCOTBMXLAD([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBE50", Offset = "0x2AFAE50", VA = "0x182AFBE50", Slot = "4")]
		public CircuitsColor BFUADBNKIKT(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBEA0", Offset = "0x2AFAEA0", VA = "0x182AFBEA0")]
		public int XMMCRCJMEFX([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBEA0", Offset = "0x2AFAEA0", VA = "0x182AFBEA0", Slot = "5")]
		private int FKUYMBRSETM([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class MCKXWKKHBYG : BAFPLEMWXHZ
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class FFJXIIVMHJR
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid ZOECLIKSSGP
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xF91B80", Offset = "0xF90B80", VA = "0x180F91B80")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long CLKKOSOFEGA
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int NHOIMXYLPAW
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAD13C0", Offset = "0xAD03C0", VA = "0x180AD13C0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool TNCNIEZCDAL
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x1B95AF0", Offset = "0x1B94AF0", VA = "0x181B95AF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool DRAOPSNHLMR
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x1B95AE0", Offset = "0x1B94AE0", VA = "0x181B95AE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool HFOYMYDFKWS
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x2AFC190", Offset = "0x2AFB190", VA = "0x182AFC190")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2AFC1B0", Offset = "0x2AFB1B0", VA = "0x182AFC1B0")]
			public FFJXIIVMHJR(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Dictionary<Id128<GOPNEBMAEKM>, FFJXIIVMHJR> KSYGCQTVRZU;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF550", Offset = "0x2AFE550", VA = "0x182AFF550")]
		public bool WMEUNWVQSJJ([In] Id128<GOPNEBMAEKM> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF480", Offset = "0x2AFE480", VA = "0x182AFF480")]
		public void SOTOUWGHNJJ([In] Id128<GOPNEBMAEKM> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF660", Offset = "0x2AFE660", VA = "0x182AFF660")]
		public void SOTOUWGHNJJ([In] Id128<GOPNEBMAEKM> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF740", Offset = "0x2AFE740", VA = "0x182AFF740")]
		public void TIHXXJBLKDY([In] Id128<GOPNEBMAEKM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF420", Offset = "0x2AFE420", VA = "0x182AFF420")]
		public void DJDAQZLJZZX([In] Id128<GOPNEBMAEKM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF860", Offset = "0x2AFE860", VA = "0x182AFF860")]
		public bool TNCNIEZCDAL([In] Id128<GOPNEBMAEKM> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF8F0", Offset = "0x2AFE8F0", VA = "0x182AFF8F0")]
		public MCKXWKKHBYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF550", Offset = "0x2AFE550", VA = "0x182AFF550", Slot = "4")]
		private bool PIHEMEXQSJG([In] Id128<GOPNEBMAEKM> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF480", Offset = "0x2AFE480", VA = "0x182AFF480", Slot = "5")]
		private void FKFUBGKQQUM([In] Id128<GOPNEBMAEKM> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF740", Offset = "0x2AFE740", VA = "0x182AFF740", Slot = "6")]
		private void YZGTIPEQVGF([In] Id128<GOPNEBMAEKM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF420", Offset = "0x2AFE420", VA = "0x182AFF420", Slot = "7")]
		private void QQGEJOSBNZY([In] Id128<GOPNEBMAEKM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF860", Offset = "0x2AFE860", VA = "0x182AFF860", Slot = "8")]
		private bool VAZKNBTJTLE([In] Id128<GOPNEBMAEKM> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class QCUHGLNTMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B003E0", Offset = "0x2AFF3E0", VA = "0x182B003E0")]
		public static LogDeps NYXVBNHZMHM()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class IOJVWOCTRPG : MeshLibrary.ICTTKLBYQGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "4")]
		public byte[]? IKFCXSPQOJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
		public void JYOOARWWVBS(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public IOJVWOCTRPG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class JNJREMZGXNN : RRPMJEEQJEK
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
		public delegate void ConfigureAttachedObjectDelegate(SMEPOWYSJWI controlPanel, VBGMMRXSCJI staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<SEUZJGPNHQJ> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, BGYAXKJXFCB>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, BGYAXKJXFCB>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, BGYAXKJXFCB>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, BGYAXKJXFCB>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public Task<Result<MultiResult, BGYAXKJXFCB>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private TaskAwaiter<Result<MultiResult, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2B06E20", Offset = "0x2B05E20", VA = "0x182B06E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2B070E0", Offset = "0x2B060E0", VA = "0x182B070E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private TaskAwaiter<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2B07150", Offset = "0x2B06150", VA = "0x182B07150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2B07410", Offset = "0x2B06410", VA = "0x182B07410", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public Task<Result<None, BGYAXKJXFCB>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<Result<None, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2B07480", Offset = "0x2B06480", VA = "0x182B07480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2B07740", Offset = "0x2B06740", VA = "0x182B07740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<string, EnumChoiceData> JDODSCGZZSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<int, string> BUDVAGWSEGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly List<object> QHTHLJTSXIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<Guid> HVTLEOSVVMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly CanLocalPlayerCreateCurrencyDelegate OTGRUVJQXCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ShowRoomCurrencyCreationUIDelegate JGUJEKWQCCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly GetAudioClipOptionsDelegate HVRLTJIVNIM;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly IReadOnlyDictionary<Guid, int> AINTMUMETSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly GetAudioClipGuidToIndexMapDelegate HLVLJXOVYMY;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly IReadOnlyDictionary<int, Guid> AXQUTDWRAPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly GetAudioClipIndexToGuidMapDelegate ONKEOVVMWVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAllAudioClipOptionsDelegate HQZWRIYXXWD;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<Guid, int> VWPJHRSGYBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate TTBODKFUOXL;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly IReadOnlyDictionary<int, Guid> PSMOIVTUKXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate RQIAZBEDNIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly PlayAudioPreviewDelegate QGEODZHFYRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly StopAudioPreviewDelegate GMRJAWGOPEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly SubscriptionIsActiveDelegate SAJCHBXPVHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate VSLQZQGEAVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Dictionary<string, EnumChoiceData> FRHPMKGDFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly ShowQuickChatEditMenuDelegate XTUIXBAUKPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly ConfigureAttachedObjectDelegate FPAHYIXVGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly DisplayInvalidNameErrorMessageDelegate DHTXPFQTUMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly IsStringPureDelegate GEKYZZKPKSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly TryGetSpecificChipConfigSummaryDelegate ORSURNOLKPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly ReleaseIconIdDelegate JRYFILAVGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReportCreationErrorToUserAsyncDelegate YQQYXWNVICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 QHBJJJDECDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 QGWCMCJGSSK;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment PWHTDWCUMWU
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool VBQKLGKDKYT
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB21E00", Offset = "0xB20E00", VA = "0x180B21E00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> JSYRGDCJHZG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> CVMBLPRGPTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> SRAKAHDRINK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> MJYAGJYQYXG
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xAD68C0", Offset = "0xAD58C0", VA = "0x180AD68C0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion TKUCXTSMOVI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xC1E5F0", Offset = "0xC1D5F0", VA = "0x180C1E5F0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool DDTWZZVEOAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xC1E590", Offset = "0xC1D590", VA = "0x180C1E590", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool RWOXEZQTJBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2AFDA50", Offset = "0x2AFCA50", VA = "0x182AFDA50", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool NXIXGMHWIXC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD720", Offset = "0x2AFC720", VA = "0x182AFD720", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool AFLRROSRXKG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xADB460", Offset = "0xADA460", VA = "0x180ADB460", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDC40", Offset = "0x2AFCC40", VA = "0x182AFDC40")]
		public JNJREMZGXNN([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD890", Offset = "0x2AFC890", VA = "0x182AFD890", Slot = "9")]
		public bool TITJRZIBBJC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		public static bool CDYDGUCSAPZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD7F0", Offset = "0x2AFC7F0", VA = "0x182AFD7F0", Slot = "10")]
		public bool ODFKOPXSORQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public static void VRDDIXKFYLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xFD06F0", Offset = "0xFCF6F0", VA = "0x180FD06F0", Slot = "11")]
		public void RZPECPGMVUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDA90", Offset = "0x2AFCA90", VA = "0x182AFDA90")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZWRLURQZJGK(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD820", Offset = "0x2AFC820", VA = "0x182AFD820", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> PPNTLLULCUZ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD760", Offset = "0x2AFC760", VA = "0x182AFD760")]
		private static IReadOnlyDictionary<Guid, int> LQSXDPYQGRO(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD730", Offset = "0x2AFC730", VA = "0x182AFD730", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> LMVCLSAZJGP(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD430", Offset = "0x2AFC430", VA = "0x182AFD430")]
		private static IReadOnlyDictionary<int, Guid> BYXMAKZVMQU(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD6F0", Offset = "0x2AFC6F0", VA = "0x182AFD6F0", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> JNDGHJNXMDF(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD990", Offset = "0x2AFC990", VA = "0x182AFD990")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> VCXVSIJTWXP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF00B0", Offset = "0x2AEF0B0", VA = "0x182AF00B0", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BFJSTQQZUAQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD3A0", Offset = "0x2AFC3A0", VA = "0x182AFD3A0")]
		private static IReadOnlyDictionary<Guid, int> BNQDGNXWHLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDA20", Offset = "0x2AFCA20", VA = "0x182AFDA20", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> YQIJVYKYEMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD9F0", Offset = "0x2AFC9F0", VA = "0x182AFD9F0", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> WUFGBVMOSEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void KOCMROHWOOK(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD7B0", Offset = "0x2AFC7B0", VA = "0x182AFD7B0", Slot = "18")]
		public void LZDJEAKPIBD(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void EDFAJUTEQYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD600", Offset = "0x2AFC600", VA = "0x182AFD600", Slot = "19")]
		public void HNWEVSTRIIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		private static bool OSXMCHPZAWL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDA60", Offset = "0x2AFCA60", VA = "0x182AFDA60", Slot = "20")]
		public bool ZHLDALZBMGO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		public static bool UVATLWMPHHQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD190", Offset = "0x2AFC190", VA = "0x182AFD190", Slot = "21")]
		public bool BBVPVPESDGR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD5D0", Offset = "0x2AFC5D0", VA = "0x182AFD5D0", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GPCTBABOTFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> BBGIEAPOXVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> QLLTUVOMVCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD160", Offset = "0x2AFC160", VA = "0x182AFD160", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> AGMCRIKKLVV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> MZFCTQBPEBX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> SFJLOXKEAHX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public static void QSNFALCXXNR(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD850", Offset = "0x2AFC850", VA = "0x182AFD850", Slot = "29")]
		public void QQNVGMGERLI(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void PNKFWKJXNIR(SMEPOWYSJWI a, VBGMMRXSCJI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD960", Offset = "0x2AFC960", VA = "0x182AFD960", Slot = "35")]
		public void UDJWYVSEELS(SMEPOWYSJWI a, VBGMMRXSCJI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "36")]
		public Dictionary<string, EnumChoiceData> KAGXNLTFUNQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "37")]
		public Dictionary<string, EnumChoiceData> XLMEQVFETQD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void ZWBNDUBCXJV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD570", Offset = "0x2AFC570", VA = "0x182AFD570")]
		private static Task<bool> FWQATNFDFBZ(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD630", Offset = "0x2AFC630", VA = "0x182AFD630", Slot = "38")]
		public Task<bool> IJFDHMZBDYO(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD950", Offset = "0x2AFC950", VA = "0x182AFD950")]
		private static bool TNUZNCIPWYD(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD3F0", Offset = "0x2AFC3F0", VA = "0x182AFD3F0", Slot = "39")]
		public bool BVYUWMZAEHI(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void FWHSLCCHTHV(Id32<SEUZJGPNHQJ> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD9C0", Offset = "0x2AFC9C0", VA = "0x182AFD9C0", Slot = "40")]
		public void VWZRJAPUEXM(Id32<SEUZJGPNHQJ> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD480", Offset = "0x2AFC480", VA = "0x182AFD480")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, BGYAXKJXFCB>> FJKDLOTFHET(Task<Result<None, BGYAXKJXFCB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD690", Offset = "0x2AFC690", VA = "0x182AFD690", Slot = "41")]
		public Task<Result<None, BGYAXKJXFCB>> IRVMIEYCMFA(Task<Result<None, BGYAXKJXFCB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD2B0", Offset = "0x2AFC2B0", VA = "0x182AFD2B0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, BGYAXKJXFCB>> BEKHSROWZAT(Task<Result<MultiResult, BGYAXKJXFCB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD6C0", Offset = "0x2AFC6C0", VA = "0x182AFD6C0", Slot = "42")]
		public Task<Result<MultiResult, BGYAXKJXFCB>> IRVMIEYCMFA(Task<Result<MultiResult, BGYAXKJXFCB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD1C0", Offset = "0x2AFC1C0", VA = "0x182AFD1C0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> BEFAVKUZPPK(Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD660", Offset = "0x2AFC660", VA = "0x182AFD660", Slot = "43")]
		public Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> IRVMIEYCMFA(Task<Result<Id32<MMFHTWDPFRA>, BGYAXKJXFCB>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class IHDRNCRJSLE : RDPHCEASFGR
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(VBDHXKKGPBY e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private InteropDelegate? FQJBATAKDIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly InteropDelegate VUZESMLBRVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate HYDSZXDKCWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? PEGYLLUFUHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InvokeStudioFunctionDelegate? XOACEJPFPIM;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "5")]
		public LegacyCV2Result<None> TXGNQDVVJFW(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10")]
		private static LegacyCV2Result<None> Default(VBDHXKKGPBY _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "6")]
		public LegacyCV2Result<None> MWJXNFJKTWN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "7")]
		public LegacyCV2Result<None> ZZQFZYJVASG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "8")]
		public LegacyCV2Result<None> WMSDOENQMZB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "9")]
		public LegacyCV2Result<None> WFYZGZUSNJB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "15")]
		public LegacyCV2Result<None> ARBHYBVUAZC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XPYWWUTLZZW(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YGJNQFLNMDO(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YJZOUDJKDLR(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VFQHKEOHGUC(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VFPHOHGDKYZ(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FEXLGOUWWCZ(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DVFFNWHCXAU(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "93")]
		public LegacyCV2Result<None> EEKYISAMPVP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "94")]
		public LegacyCV2Result<None> WXWCOXPDLFH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "95")]
		public LegacyCV2Result<None> VUHNLUWKWKO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EKVVDIHTVWW(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(VBDHXKKGPBY e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RQQCBLQCZZC(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SCZZXORCRZG(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XCEYAFPPJAD(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UQCJCUMSUHU(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EYFDATUQRNN(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FJZCSLMCYXP(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CXNFSTXHKSB(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CGPPWOXPCDS(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1240")]
		public LegacyCV2Result<None> MakeChatAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1241")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1242")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1243")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1245")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1244")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1247")]
		public LegacyCV2Result<None> GetAIFunction(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x15DA710", Offset = "0x15D9710", VA = "0x1815DA710", Slot = "1249")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OGMOATGMFTF(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XKBTVYYKTZS(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "119")]
		public LegacyCV2Result<None> ZOZABDBQBNG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QEVZRPPRVEF(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "121")]
		public LegacyCV2Result<None> BFEOVYZSWUB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "122")]
		public LegacyCV2Result<None> ZTGWVOVEZEJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "123")]
		public LegacyCV2Result<None> RGOKNRCOMEN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "124")]
		public LegacyCV2Result<None> RQGSBPKYHNT(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "125")]
		public LegacyCV2Result<None> QKOFAFZLSBX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "126")]
		public LegacyCV2Result<None> ILNOPYSUQWW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "809")]
		public LegacyCV2Result<None> MLGYMTODIJK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "810")]
		public LegacyCV2Result<None> OOZOKLXYIBO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "147")]
		public LegacyCV2Result<None> QQYTWLKJFJG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "148")]
		public LegacyCV2Result<None> HXODLWXNRUU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "149")]
		public LegacyCV2Result<None> ECPMFQCXICL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "150")]
		public LegacyCV2Result<None> OERCZBUASPV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "151")]
		public LegacyCV2Result<None> HQUZSUEZREW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(VBDHXKKGPBY e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "153")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "154")]
		public LegacyCV2Result<None> EquipAvatarItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "155")]
		public LegacyCV2Result<None> UnequipAvatarItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "156")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "157")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "158")]
		public LegacyCV2Result<None> MotionTrailSetColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailGetColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "164")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "165")]
		public LegacyCV2Result<None> BeaconSetEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "166")]
		public LegacyCV2Result<None> BeaconGetEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "167")]
		public LegacyCV2Result<None> BeaconSetHeight(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "168")]
		public LegacyCV2Result<None> BeaconGetHeight(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "169")]
		public LegacyCV2Result<None> BeaconSetColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "170")]
		public LegacyCV2Result<None> BeaconGetColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "171")]
		public LegacyCV2Result<None> CWDZYMRJPPZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "172")]
		public LegacyCV2Result<None> SHCTJFEXZHO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "173")]
		public LegacyCV2Result<None> UXJXJGSFBHS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "174")]
		public LegacyCV2Result<None> GetLocalCameraForward(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "175")]
		public LegacyCV2Result<None> GetLocalCameraUp(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "176")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraPosition(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "178")]
		public LegacyCV2Result<None> SetCameraShake(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "179")]
		public LegacyCV2Result<None> StopCameraShake(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "180")]
		public LegacyCV2Result<None> SnapCameraImage(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "189")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "190")]
		public LegacyCV2Result<None> CollisionDataGetObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "191")]
		public LegacyCV2Result<None> CollisionDataGetDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPosition(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetNormal(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "194")]
		public LegacyCV2Result<None> MIFPWSIPOQC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "195")]
		public LegacyCV2Result<None> MINJDVHYMUF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "196")]
		public LegacyCV2Result<None> ITBVVQKRPWE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "197")]
		public LegacyCV2Result<None> SBQFRHXRADS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "198")]
		public LegacyCV2Result<None> LQGOXOYCHOU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "199")]
		public LegacyCV2Result<None> AZSAPSZZHUN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "200")]
		public LegacyCV2Result<None> SBODTEIAVNB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "201")]
		public LegacyCV2Result<None> OHSGMCYSACF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "202")]
		public LegacyCV2Result<None> SUIKFLKEUZH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "203")]
		public LegacyCV2Result<None> ECAYFCWAPQJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "204")]
		public LegacyCV2Result<None> VTGZTZWSHID(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "205")]
		public LegacyCV2Result<None> BFPPPPFNIOX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "206")]
		public LegacyCV2Result<None> DDOSEJAUDHL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "207")]
		public LegacyCV2Result<None> STDGUFGRFCY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "208")]
		public LegacyCV2Result<None> NGYYNXQORUJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "209")]
		public LegacyCV2Result<None> XNNTXDZQLJS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "210")]
		public LegacyCV2Result<None> ULYEPEMAAFV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "211")]
		public LegacyCV2Result<None> AYQARRKOKTW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "212")]
		public LegacyCV2Result<None> RDMJSMUHSCF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "213")]
		public LegacyCV2Result<None> CombatantGetHealthAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "214")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "215")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "216")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "217")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "218")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "225")]
		public LegacyCV2Result<None> CombatantSetHealthAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "226")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "227")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "231")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "232")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "233")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "239")]
		public LegacyCV2Result<None> CombatantToCombatantAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "240")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "241")]
		public LegacyCV2Result<None> CombatantSplit(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "242")]
		public LegacyCV2Result<None> CostumeEquip(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "243")]
		public LegacyCV2Result<None> CostumeUnEquip(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "244")]
		public LegacyCV2Result<None> CostumeGetWearer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "245")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "271")]
		public LegacyCV2Result<None> IHKUTTYAQFH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "272")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "273")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "274")]
		public LegacyCV2Result<None> QSSTCFWLUAH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "276")]
		public LegacyCV2Result<None> RCZYQZQUZVI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "277")]
		public LegacyCV2Result<None> SLZUBCIVNEY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "278")]
		public LegacyCV2Result<None> XTJRLNXOJYF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "279")]
		public LegacyCV2Result<None> FTRAOZUZUDQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "280")]
		public LegacyCV2Result<None> XLLZSWFQOFZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "281")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "282")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "283")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "284")]
		public LegacyCV2Result<None> LPNHYNBVSOW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "285")]
		public LegacyCV2Result<None> SQQWHGGOALF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "286")]
		public LegacyCV2Result<None> ToCreationObjectAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "287")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "288")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectButton(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectContainer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectRotator(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectPiston(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectSeat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectDice(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectCostume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "314")]
		public LegacyCV2Result<None> AOBNDFUYHQQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "317")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "342")]
		public LegacyCV2Result<None> FromCreationObjectAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "343")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "344")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "345")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "346")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectButton(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectContainer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectDie(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectPiston(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRotator(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectText(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectSeat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectCostume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "399")]
		public LegacyCV2Result<None> ZQNNNYTIZAH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "400")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UAEIUIZDWYC(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "401")]
		public LegacyCV2Result<None> DiceRollFinished(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "402")]
		public LegacyCV2Result<None> DiceResult(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "403")]
		public LegacyCV2Result<None> DicePlayerRolled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "404")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "405")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DIBCZGCRLWC(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "406")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XZKPHOWYMDK(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VSSKJOZDKNF(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "408")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MYIJMYVZHGQ(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "409")]
		public LegacyCV2Result<BSJYNYCJRXG.CV2DiscoverySectionType> SZQLRKSLSNZ(VBDHXKKGPBY e, CircuitSignal a)
		{
			return default(LegacyCV2Result<BSJYNYCJRXG.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "410")]
		public LegacyCV2Result<None> PNOKYSKCEZV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "411")]
		public LegacyCV2Result<None> EmitterStart(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "412")]
		public LegacyCV2Result<None> EmitterStop(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "413")]
		public LegacyCV2Result<None> EmitterSetLooping(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "414")]
		public LegacyCV2Result<None> EmitterSetSize(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "415")]
		public LegacyCV2Result<None> EmitterSetSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "416")]
		public LegacyCV2Result<None> EmitterSetColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "417")]
		public LegacyCV2Result<None> EmitterSetColorNew(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "418")]
		public LegacyCV2Result<None> EmitterGetLooping(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "419")]
		public LegacyCV2Result<None> EmitterGetSize(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "420")]
		public LegacyCV2Result<None> EmitterGetSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "421")]
		public LegacyCV2Result<None> EmitterGetPlaying(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "422")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(VBDHXKKGPBY e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "423")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XJKDBGBBEFJ(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "424")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IYIUCYTSTLC(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "425")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GFAXEYACHZP(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "426")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "427")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "428")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "429")]
		public LegacyCV2Result<None> GetFriendlyNameAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "430")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "182")]
		public LegacyCV2Result<None> GetFriendlyNameColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "434")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "431")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "432")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "433")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "435")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameReward(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "453")]
		public LegacyCV2Result<None> EYTVJVWYKJS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "454")]
		public LegacyCV2Result<None> WYTNDHZQQTP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "455")]
		public LegacyCV2Result<None> JTLRQPYBHLU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "456")]
		public LegacyCV2Result<None> NAAPWUUJNBV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "457")]
		public LegacyCV2Result<None> OTXYLBGKXWD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "458")]
		public LegacyCV2Result<None> EECCEFUTIEJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "459")]
		public LegacyCV2Result<None> GIFKJARBYUW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "460")]
		public LegacyCV2Result<None> QBYMGSZYQDW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "465")]
		public LegacyCV2Result<None> JQCBGPRGVVM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "466")]
		public LegacyCV2Result<None> XQFCKAHUIVA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "467")]
		public LegacyCV2Result<None> BICGICUPULV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "468")]
		public LegacyCV2Result<None> ETLPAUROZWW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "469")]
		public LegacyCV2Result<None> RVDAIGOKYNU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "470")]
		public LegacyCV2Result<None> IWOGICROUEP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "461")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(VBDHXKKGPBY executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "462")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(VBDHXKKGPBY executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "463")]
		public LegacyCV2Result<None> QKDKYEZIIAF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "464")]
		public LegacyCV2Result<None> NCQLHUFJJOB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "471")]
		public LegacyCV2Result<None> RVEOXNTFNXH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "472")]
		public LegacyCV2Result<None> NQJPCAFOIYV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "473")]
		public LegacyCV2Result<None> FJYDSEENUUS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "474")]
		public LegacyCV2Result<None> CBNBTEDKFBO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "475")]
		public LegacyCV2Result<None> LBMIITDWNVE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "476")]
		public LegacyCV2Result<None> FLPCELKHPBY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "477")]
		public LegacyCV2Result<None> OOMCVHZJCCA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "478")]
		public LegacyCV2Result<None> RNKZJVODCUG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "479")]
		public LegacyCV2Result<None> XGZBYHZTKXG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "480")]
		public LegacyCV2Result<None> DWHDYFVAEVS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "481")]
		public LegacyCV2Result<None> VSPEFJCXWLE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "482")]
		public LegacyCV2Result<None> JWBRIQCZQLA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "483")]
		public LegacyCV2Result<None> DHUEUAKXWLO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "484")]
		public LegacyCV2Result<None> QKBPBOPEROY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "485")]
		public LegacyCV2Result<None> HXIBYUPGAFW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "486")]
		public LegacyCV2Result<None> SWGVMFOSXSK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "487")]
		public LegacyCV2Result<None> IZWFRYQXMEC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "488")]
		public LegacyCV2Result<None> JHUJRHVFAVE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "489")]
		public LegacyCV2Result<None> AEDWMPDVTDO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "490")]
		public LegacyCV2Result<None> OJREAUQJDYW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC670", Offset = "0x2AFB670", VA = "0x182AFC670", Slot = "491")]
		public LegacyCV2Result<None> SendLogString(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "492")]
		public LegacyCV2Result<None> LerpColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "493")]
		public LegacyCV2Result<None> LerpUnclampedColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "494")]
		public LegacyCV2Result<None> InverseLerpVec3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "495")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "496")]
		public LegacyCV2Result<None> InverseLerpColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "497")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "498")]
		public LegacyCV2Result<None> JAWSUDJNHVW(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "499")]
		public LegacyCV2Result<None> QSLPCWFSNDU(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "500")]
		public LegacyCV2Result<None> PBKBKYJMIDA(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "501")]
		public LegacyCV2Result<None> YVRNLFOLZFP(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "502")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "503")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "504")]
		public LegacyCV2Result<None> FogConstantValues(VBDHXKKGPBY e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "505")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "506")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "507")]
		public LegacyCV2Result<None> SunConstantValues(VBDHXKKGPBY e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "508")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "509")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "510")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(VBDHXKKGPBY e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.SIJZEWOSVWI> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "511")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "512")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "513")]
		public LegacyCV2Result<None> UUBSQHGLYFN(VBDHXKKGPBY e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "516")]
		public LegacyCV2Result<None> LLYCOYADLOD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "517")]
		public LegacyCV2Result<None> TextScreenClearScreen(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "518")]
		public LegacyCV2Result<None> HJLLHYCSIKE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "519")]
		public LegacyCV2Result<None> RRHSQGJHEVQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "520")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "521")]
		public LegacyCV2Result<None> DDJFWYASOVE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "522")]
		public LegacyCV2Result<None> ZCAIMSVUKVH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC5B0", Offset = "0x2AFB5B0", VA = "0x182AFC5B0", Slot = "523")]
		public LegacyCV2Result<None> GetLocalPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "524")]
		public LegacyCV2Result<None> POSOXYDUBGR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC630", Offset = "0x2AFB630", VA = "0x182AFC630", Slot = "526")]
		public LegacyCV2Result<None> SGWIOUSGACH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "525")]
		public LegacyCV2Result<None> ETLPKNBCNKM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "527")]
		public LegacyCV2Result<None> TCTMJHSXBFC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "528")]
		public LegacyCV2Result<None> ORRVWTGBFHN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "529")]
		public LegacyCV2Result<None> XBCTFPCSEQZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "530")]
		public LegacyCV2Result<None> HVRJUMCIDAB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "531")]
		public LegacyCV2Result<None> JCRRIBOQMWD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "532")]
		public LegacyCV2Result<None> DistanceAI_AI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "533")]
		public LegacyCV2Result<None> DistanceAI_Combatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "534")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "535")]
		public LegacyCV2Result<None> DistanceAI_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "536")]
		public LegacyCV2Result<None> DistanceAI_Vector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "537")]
		public LegacyCV2Result<None> DistanceCombatant_AI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "538")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "539")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "540")]
		public LegacyCV2Result<None> DistanceCombatant_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "541")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "542")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "543")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "544")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "545")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "546")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "547")]
		public LegacyCV2Result<None> DistancePlayer_AI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "548")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "549")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "550")]
		public LegacyCV2Result<None> DistancePlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "551")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "552")]
		public LegacyCV2Result<None> DistanceVector3_AI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "553")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "554")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "555")]
		public LegacyCV2Result<None> DistanceVector3_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "556")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "557")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "558")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "559")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "560")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "561")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "562")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "563")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "564")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "565")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "566")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "567")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "568")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "569")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "570")]
		public LegacyCV2Result<None> GetPositionAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "571")]
		public LegacyCV2Result<None> GetPositionCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "572")]
		public LegacyCV2Result<None> GetPositionCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "573")]
		public LegacyCV2Result<None> GetPositionPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "574")]
		public LegacyCV2Result<None> Raycast(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "575")]
		public LegacyCV2Result<None> PNSAMWASTQY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "576")]
		public LegacyCV2Result<None> RaycastAll(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "577")]
		public LegacyCV2Result<None> Spherecast(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "578")]
		public LegacyCV2Result<None> RAJTUYYWBZR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "579")]
		public LegacyCV2Result<None> SpherecastAll(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "580")]
		public LegacyCV2Result<None> OverlapSphere(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "581")]
		public LegacyCV2Result<None> OverlapBox(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "582")]
		public LegacyCV2Result<None> EZPEJRHKFLE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "583")]
		public LegacyCV2Result<None> NYZNFZCXRJH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "584")]
		public LegacyCV2Result<None> SetPositionPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "585")]
		public LegacyCV2Result<None> SetPositionCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "586")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "587")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "588")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "589")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "591")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "592")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "593")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "594")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "595")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "596")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "597")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "598")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "599")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "600")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "601")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "602")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "603")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "604")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "605")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "606")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "607")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "608")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "609")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "610")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "611")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "612")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "613")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "614")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "615")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "616")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "617")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "618")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "619")]
		public LegacyCV2Result<None> PistonGetDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "620")]
		public LegacyCV2Result<None> PistonSetDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "621")]
		public LegacyCV2Result<None> PistonGetSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "622")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "623")]
		public LegacyCV2Result<None> PistonSetSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "624")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "625")]
		public LegacyCV2Result<None> PistonGetAcceleration(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "626")]
		public LegacyCV2Result<None> PistonSetAcceleration(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "627")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "628")]
		public LegacyCV2Result<None> PistonGetMaxDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "629")]
		public LegacyCV2Result<None> PistonSetMaxDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "630")]
		public LegacyCV2Result<None> PistonGetTargetDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "631")]
		public LegacyCV2Result<None> PistonSetTargetDistance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "632")]
		public LegacyCV2Result<None> BGMDGKLMIFQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "633")]
		public LegacyCV2Result<None> SMDNGWTJTQO(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "634")]
		public LegacyCV2Result<None> UPQVERKGBYX(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "635")]
		public LegacyCV2Result<None> QQQSJGINXMI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "636")]
		public LegacyCV2Result<None> DZWCOLVPQHG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "637")]
		public LegacyCV2Result<None> HMYPBVGBECR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "638")]
		public LegacyCV2Result<None> PlayerAddRole(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "639")]
		public LegacyCV2Result<None> PlayerRemoveRole(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "640")]
		public LegacyCV2Result<None> KYSQWUFIPQO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "641")]
		public LegacyCV2Result<None> QRCQJIAPVBM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "642")]
		public LegacyCV2Result<None> GALNPZDSAGD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "643")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "644")]
		public LegacyCV2Result<None> PlayerRightHandPosition(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "645")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "646")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "647")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "648")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "649")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "650")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "652")]
		public LegacyCV2Result<None> GSDPFTHOKMQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "651")]
		public LegacyCV2Result<None> VLJJVBLFBIH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "653")]
		public LegacyCV2Result<None> QMGLNAGMLWC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "654")]
		public LegacyCV2Result<None> EMJEEYMISPT(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "655")]
		public LegacyCV2Result<None> PlayerHeadPosition(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "656")]
		public LegacyCV2Result<None> PlayerHeadOrientation(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "657")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "658")]
		public LegacyCV2Result<None> PlayerHeadUpVector(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "659")]
		public LegacyCV2Result<None> PlayerHeadVelocity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "660")]
		public LegacyCV2Result<None> PlayerHeadHeight(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "661")]
		public LegacyCV2Result<None> NMMBUUKVMPI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "662")]
		public LegacyCV2Result<None> HIXNHNKTPPT(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "663")]
		public LegacyCV2Result<None> PlayerBodyPosition(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "664")]
		public LegacyCV2Result<None> PlayerBodyOrientation(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "665")]
		public LegacyCV2Result<None> ZOCPVVMNRJV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "666")]
		public LegacyCV2Result<None> ECLVLHFBUXQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "694")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "699")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(VBDHXKKGPBY e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "685")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "686")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "687")]
		public LegacyCV2Result<None> QXMLFHIHBOM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "688")]
		public LegacyCV2Result<None> KWPIDFUNPQC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "689")]
		public LegacyCV2Result<None> LTLDLTHEPTA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "690")]
		public LegacyCV2Result<None> KNDFDJBUHCN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "691")]
		public LegacyCV2Result<None> LWQUCPOPPYF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "692")]
		public LegacyCV2Result<None> PlayerGetCostume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "693")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "667")]
		public LegacyCV2Result<None> IQBEVPWENBU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "668")]
		public LegacyCV2Result<None> PYJSQLVOEIQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "669")]
		public LegacyCV2Result<None> FEXROUUWKWV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "670")]
		public LegacyCV2Result<None> MQGNXZAIXJK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "671")]
		public LegacyCV2Result<None> WCFIVRERILR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "672")]
		public LegacyCV2Result<None> LAKATCUGXGC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "673")]
		public LegacyCV2Result<None> VYQQHFIMDDC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "674")]
		public LegacyCV2Result<None> NITUSDKMFON(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "675")]
		public LegacyCV2Result<None> NMUPDDSPOVX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "676")]
		public LegacyCV2Result<None> QKJXNQGEXBK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "677")]
		public LegacyCV2Result<None> UKEXYRXGXBQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "678")]
		public LegacyCV2Result<None> RHVIGXNVDDV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "679")]
		public LegacyCV2Result<None> NUURVGEUYGI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "680")]
		public LegacyCV2Result<None> BIBSLXZWMQM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "681")]
		public LegacyCV2Result<None> LDDNFQUZZMZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "682")]
		public LegacyCV2Result<None> LEOJTFRCXFV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "683")]
		public LegacyCV2Result<None> DYPGQKLBIEB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "684")]
		public LegacyCV2Result<None> XGQTZFFEKGG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "695")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "696")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "756")]
		public LegacyCV2Result<None> XLTNVQFIWQC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "757")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "758")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "700")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "702")]
		public LegacyCV2Result<None> VQXINQPADJB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "703")]
		public LegacyCV2Result<None> LSXOHMVTPQB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "704")]
		public LegacyCV2Result<None> CRVEZJVRPNZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "705")]
		public LegacyCV2Result<None> IRUAZUGKWMJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "707")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "708")]
		public LegacyCV2Result<None> TSPMEUGUYXL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "709")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "710")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "711")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "712")]
		public LegacyCV2Result<None> UWLADVXYVWE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "713")]
		public LegacyCV2Result<None> YZBKIJVQPIO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "714")]
		public LegacyCV2Result<None> ZSNRWVPJONL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "715")]
		public LegacyCV2Result<None> FXYLLHSNVVB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "716")]
		public LegacyCV2Result<None> ERWXPIYYURN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "717")]
		public LegacyCV2Result<None> TUOEBBSGUYG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "718")]
		public LegacyCV2Result<None> ROSVGKAMMDN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "719")]
		public LegacyCV2Result<None> NUCDECTMIDM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "720")]
		public LegacyCV2Result<None> KNSZUJGKULU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "721")]
		public LegacyCV2Result<None> ZQGEJQYPWRM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "722")]
		public LegacyCV2Result<None> OQAKETVQZJQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "723")]
		public LegacyCV2Result<None> GYLXAFVHWSC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "724")]
		public LegacyCV2Result<None> PBWFPPSAWOM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "725")]
		public LegacyCV2Result<None> RMGCMCRCGBZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "726")]
		public LegacyCV2Result<None> QXQOBNJGGGG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "727")]
		public LegacyCV2Result<None> NZPGIGOTSSM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "728")]
		public LegacyCV2Result<None> MMKUMRKUBZF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "729")]
		public LegacyCV2Result<None> SADMVFLUKHK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "731")]
		public LegacyCV2Result<None> OLJIPRKFGVQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "730")]
		public LegacyCV2Result<None> EMZUVNYJFMM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "732")]
		public LegacyCV2Result<None> FBFJTXKLCNL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "733")]
		public LegacyCV2Result<None> VMQJBHGAQFG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "734")]
		public LegacyCV2Result<None> ZBFJXAMNRNB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "735")]
		public LegacyCV2Result<None> DPVYYAOQSYD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "736")]
		public LegacyCV2Result<None> DVCCDJYAFBI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "737")]
		public LegacyCV2Result<None> FDOWWDJBROP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "738")]
		public LegacyCV2Result<None> HWFJBABFVWH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "739")]
		public LegacyCV2Result<None> GWKMPNLMNVO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "740")]
		public LegacyCV2Result<None> EFNYAKYOAFY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "741")]
		public LegacyCV2Result<None> ZLTJZEZNZHS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "742")]
		public LegacyCV2Result<None> EQZEXWGGFIU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "743")]
		public LegacyCV2Result<None> DTJNVQJKQWO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "744")]
		public LegacyCV2Result<None> HUMYTWQGPJI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "745")]
		public LegacyCV2Result<None> RLBDEBGHWBU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "746")]
		public LegacyCV2Result<None> FGUGXJVXROL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "747")]
		public LegacyCV2Result<None> WGHNGFMPFRR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "748")]
		public LegacyCV2Result<None> HDIFHBNGOHH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "749")]
		public LegacyCV2Result<None> WVVQYOJCQST(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "750")]
		public LegacyCV2Result<None> YHUVQLQAGZO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "751")]
		public LegacyCV2Result<None> EAZTRGFMZHG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "752")]
		public LegacyCV2Result<None> CJBEEYKVKOA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "753")]
		public LegacyCV2Result<None> VWGNTPIIQQJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "754")]
		public LegacyCV2Result<None> FCPIBTFGHWP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "755")]
		public LegacyCV2Result<None> XDINCERWKYM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "759")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "760")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "761")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "762")]
		public LegacyCV2Result<None> QVZMOSXISNK(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "763")]
		public LegacyCV2Result<None> VDTHGRMHKRY(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "764")]
		public LegacyCV2Result<None> XBANIZCJOYP(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "765")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(VBDHXKKGPBY ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "766")]
		public LegacyCV2Result<None> PMATQATKRLL(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "767")]
		public LegacyCV2Result<None> UNSUDPOOSWD(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "768")]
		public LegacyCV2Result<None> TJPTFDQGDJM(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "769")]
		public LegacyCV2Result<None> ZRFVHARLTNQ(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "770")]
		public LegacyCV2Result<None> NNOBHNKHKPO(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "697")]
		public LegacyCV2Result<None> PlayerGetProfileImage(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "698")]
		public LegacyCV2Result<None> NEQCDBKBOWA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "771")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "772")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "773")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "774")]
		public LegacyCV2Result<None> ShowPlayerProfile(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "775")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "776")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "777")]
		public LegacyCV2Result<None> RequestPostGameRewards(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "778")]
		public LegacyCV2Result<None> SetPlayerWorldUI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "779")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "780")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "781")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "782")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "783")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "784")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "785")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "786")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "788")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "791")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "792")]
		public LegacyCV2Result<None> BZNEAPKBNVW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "793")]
		public LegacyCV2Result<None> PDDQTOPKHHS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "794")]
		public LegacyCV2Result<None> XUAWHBDROHW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "795")]
		public LegacyCV2Result<None> HSXOQRXLDMS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "796")]
		public LegacyCV2Result<None> BRRMHVHVNBK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "797")]
		public LegacyCV2Result<None> IVDYHHHFVPW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "798")]
		public LegacyCV2Result<None> FIQDZEYHGTC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "799")]
		public LegacyCV2Result<None> WQIPRORTRGC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "800")]
		public LegacyCV2Result<None> ANFWHGJDSMM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "801")]
		public LegacyCV2Result<None> YBUZELRYXJC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "802")]
		public LegacyCV2Result<None> SMGAEKDAVVY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "803")]
		public LegacyCV2Result<None> BYRLGVPVIGF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "804")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "805")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "806")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "807")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "808")]
		public LegacyCV2Result<None> WMCTALOFJDA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "811")]
		public LegacyCV2Result<None> GetProjectile(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "812")]
		public LegacyCV2Result<None> PYTIZCMOMRH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "813")]
		public LegacyCV2Result<None> ECYMWXPENGL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "814")]
		public LegacyCV2Result<None> RNRLRVRZRCX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "815")]
		public LegacyCV2Result<None> ZXESRESFUOV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "816")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "817")]
		public LegacyCV2Result<None> PLBGQQMZGJP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "818")]
		public LegacyCV2Result<None> LWPAZTMKYHY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "819")]
		public LegacyCV2Result<None> WLWRQFIALYE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "820")]
		public LegacyCV2Result<None> ResetRoom(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "821")]
		public LegacyCV2Result<None> ResetObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "822")]
		public LegacyCV2Result<None> DKDSCXQAMHS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "823")]
		public LegacyCV2Result<None> UYJIGEJYUUR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "824")]
		public LegacyCV2Result<None> RZTILWQHZZO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "825")]
		public LegacyCV2Result<None> ConstantReward(VBDHXKKGPBY e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "826")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(VBDHXKKGPBY e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "827")]
		public LegacyCV2Result<None> XXLYGAPRYBJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "828")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WDEMUWSIYRH(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "829")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UAAEURLXQWF(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "830")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ILKNZGITXSA(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "831")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RHPMCMTRUFL(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "832")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DPTDCAUBAZA(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "833")]
		public LegacyCV2Result<None> ActivateConsumable(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "834")]
		public LegacyCV2Result<None> DeactivateConsumable(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "835")]
		public LegacyCV2Result<None> ConstantConsumable(VBDHXKKGPBY e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "836")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(VBDHXKKGPBY e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "837")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "840")]
		public LegacyCV2Result<None> ConstantRoomKey(VBDHXKKGPBY e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "842")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(VBDHXKKGPBY e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "843")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "844")]
		public LegacyCV2Result<None> ConstantInventoryItem(VBDHXKKGPBY e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(VBDHXKKGPBY e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "846")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(VBDHXKKGPBY e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "847")]
		public LegacyCV2Result<None> QKVAHOMWFEX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "849")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "850")]
		public LegacyCV2Result<None> QCJEPBBLIMH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "851")]
		public LegacyCV2Result<None> QNQVNDJPJLH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "852")]
		public LegacyCV2Result<None> VDTZDSVVRFF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "853")]
		public LegacyCV2Result<None> DSKEZWWMGWG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "854")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "855")]
		public LegacyCV2Result<None> QSHQULCAGOD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "856")]
		public LegacyCV2Result<None> HOHGBSRAJTB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "857")]
		public LegacyCV2Result<None> ConstantRoomOffer(VBDHXKKGPBY e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "858")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "859")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "860")]
		public LegacyCV2Result<None> HWYHRJKGQPP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "861")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "862")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "863")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "864")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "865")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "866")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "867")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "868")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "869")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "870")]
		public LegacyCV2Result<None> QVRXRAAGNTB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "871")]
		public LegacyCV2Result<None> OVFSYQCBXAD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "872")]
		public LegacyCV2Result<None> QVBCTKGYKPA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "873")]
		public LegacyCV2Result<None> WYBEEEOTBCX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "874")]
		public LegacyCV2Result<None> ConstantRoomCurrency(VBDHXKKGPBY e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "875")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(VBDHXKKGPBY e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "876")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(VBDHXKKGPBY e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "877")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(VBDHXKKGPBY e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "878")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(VBDHXKKGPBY e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "879")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "880")]
		public LegacyCV2Result<None> PLVABLLVBXL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "881")]
		public LegacyCV2Result<None> OATVMSDVPTQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "882")]
		public LegacyCV2Result<None> UWUIKMENYOV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "883")]
		public LegacyCV2Result<None> MLPBDUGBMNP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "884")]
		public LegacyCV2Result<None> FWWSXOKXLRZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "888")]
		public LegacyCV2Result<None> FFOLNLTFQHK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "889")]
		public LegacyCV2Result<None> IOVCYITHTDK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "890")]
		public LegacyCV2Result<None> XUGPHERLFVV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "892")]
		public LegacyCV2Result<None> GXJIPURRNVZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "891")]
		public LegacyCV2Result<None> QBANTQOGIHL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "893")]
		public LegacyCV2Result<None> QFYPSFGOYIM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "895")]
		public LegacyCV2Result<None> RVCUWLQUYNO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "894")]
		public LegacyCV2Result<None> QEULWETSNII(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "896")]
		public LegacyCV2Result<None> ELPTGDETYOB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "897")]
		public LegacyCV2Result<None> KQCUMRUAEYZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "898")]
		public LegacyCV2Result<None> PIPFITRWRQW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "899")]
		public LegacyCV2Result<None> ZSWWRENCLUM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "900")]
		public LegacyCV2Result<None> TVTNXBJBTXU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "901")]
		public LegacyCV2Result<None> QHWUNACIHJQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "902")]
		public LegacyCV2Result<None> FDHEDQNWZDI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "903")]
		public LegacyCV2Result<None> AllowDressUp(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "904")]
		public LegacyCV2Result<None> ForbidDressUp(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "905")]
		public LegacyCV2Result<None> OpenStore(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "906")]
		public LegacyCV2Result<None> OpenCheckout(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "907")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "908")]
		public LegacyCV2Result<None> GetTrialItemQuantity(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "909")]
		public LegacyCV2Result<None> MKHHUDUEWBC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "910")]
		public LegacyCV2Result<None> MMAXDIDAECG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "911")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "912")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "913")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "914")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "915")]
		public LegacyCV2Result<None> StorefrontGetOffersList(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "916")]
		public LegacyCV2Result<None> StorefrontSetOffersList(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "917")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "918")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "919")]
		public LegacyCV2Result<None> GetStoreItemDetails(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "920")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "921")]
		public LegacyCV2Result<None> MannequinSetStoreItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "922")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "923")]
		public LegacyCV2Result<None> RaiseStudioEvent(VBDHXKKGPBY e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "924")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(VBDHXKKGPBY e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "925")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(VBDHXKKGPBY e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "926")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(VBDHXKKGPBY e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "927")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(VBDHXKKGPBY e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "928")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(VBDHXKKGPBY e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "929")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(VBDHXKKGPBY e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "930")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(VBDHXKKGPBY e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "931")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(VBDHXKKGPBY e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "932")]
		public LegacyCV2Result<None> CXNLJIFXZEU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "933")]
		public LegacyCV2Result<None> XMFHKPGYXPA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "934")]
		public LegacyCV2Result<None> MNNTWTMXYSN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "935")]
		public LegacyCV2Result<None> CDYNKWVYXTH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "936")]
		public LegacyCV2Result<None> YFIIWLKPWWA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "937")]
		public LegacyCV2Result<None> AWACTMNZVNC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "938")]
		public LegacyCV2Result<None> GVCRFEAZPLN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "939")]
		public LegacyCV2Result<None> NHZUCRFTKTH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "940")]
		public LegacyCV2Result<None> PPPQBWWKHPV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "941")]
		public LegacyCV2Result<None> QEGDTXSXLNI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "942")]
		public LegacyCV2Result<None> GetFromSyncIdAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "943")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "944")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "945")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "946")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "947")]
		public LegacyCV2Result<None> GetSyncIdAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "948")]
		public LegacyCV2Result<None> GetSyncIdCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "949")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "950")]
		public LegacyCV2Result<None> GetSyncIdPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "951")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "959")]
		public LegacyCV2Result<None> CICTNEZDWPA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "958")]
		public LegacyCV2Result<None> ILWUCXFAAPX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "960")]
		public LegacyCV2Result<None> GHDZQIIUKYF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "961")]
		public LegacyCV2Result<None> KXOAWIDMTJC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "962")]
		public LegacyCV2Result<None> PVAZPFJYRPH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "963")]
		public LegacyCV2Result<None> KANABCJQFSP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "964")]
		public LegacyCV2Result<None> LGNCMRLDTHS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "952")]
		public LegacyCV2Result<None> TextToolGetText(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "953")]
		public LegacyCV2Result<None> TextToolSetText(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "954")]
		public LegacyCV2Result<None> TextToolSetColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "955")]
		public LegacyCV2Result<None> TextToolSetColorNew(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "956")]
		public LegacyCV2Result<None> TextToolSetMaterial(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "957")]
		public LegacyCV2Result<None> TextToolGetColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "965")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "966")]
		public LegacyCV2Result<None> JMTMOVDGUTR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "972")]
		public LegacyCV2Result<None> GetParticleVfx(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "973")]
		public LegacyCV2Result<None> COSBYJQOQCK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "974")]
		public LegacyCV2Result<None> GGBDHQWTPAW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "975")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "976")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "977")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "978")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "979")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "980")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "981")]
		public LegacyCV2Result<None> GoToRoom(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "982")]
		public LegacyCV2Result<None> RDERAZWEKZH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "967")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "968")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "969")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "970")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "971")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "983")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "984")]
		public LegacyCV2Result<None> XNMRUUOWSER(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "985")]
		public LegacyCV2Result<None> WZPPFJXYYZN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "986")]
		public LegacyCV2Result<None> BLRVQSZKBRV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "987")]
		public LegacyCV2Result<None> VPAGKJWRRFP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "988")]
		public LegacyCV2Result<None> THCAVOMQRTB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "989")]
		public LegacyCV2Result<None> IUXNBZSRYVF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "990")]
		public LegacyCV2Result<None> SJPPKVAAMUJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "991")]
		public LegacyCV2Result<None> QTWWIYCXIAF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "992")]
		public LegacyCV2Result<None> FNMTOGEDBIJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "993")]
		public LegacyCV2Result<None> UMQXVYZQPGR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "997")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "998")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "994")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "995")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "996")]
		public LegacyCV2Result<None> PlayerGetXp(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "999")]
		public LegacyCV2Result<None> PerlinNoise(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1000")]
		public LegacyCV2Result<None> FTKBAEVKENL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1001")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1002")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1003")]
		public LegacyCV2Result<None> SeatSetLockOut(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1004")]
		public LegacyCV2Result<None> SeatSetLockIn(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1005")]
		public LegacyCV2Result<None> SeatUnseatPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1006")]
		public LegacyCV2Result<None> SeatGetLockIn(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1007")]
		public LegacyCV2Result<None> SeatGetLockOut(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1008")]
		public LegacyCV2Result<None> OHGTUTSBZBW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1009")]
		public LegacyCV2Result<None> SZAOVDBOHQT(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1010")]
		public LegacyCV2Result<None> IVRIIRLBIWU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1011")]
		public LegacyCV2Result<None> CTGBLCUDUFZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1012")]
		public LegacyCV2Result<None> NWCOAIPHLBA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1013")]
		public LegacyCV2Result<None> IFAEUUZFWHN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1014")]
		public LegacyCV2Result<None> MBSROWJULAK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1015")]
		public LegacyCV2Result<None> YAFKBYMQLIW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1016")]
		public LegacyCV2Result<None> SQIGCVJVYCZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1017")]
		public LegacyCV2Result<None> FWWLRFGTISY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1018")]
		public LegacyCV2Result<None> CNWMXKCRGAK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1019")]
		public LegacyCV2Result<None> DQTSEPTDDPJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1020")]
		public LegacyCV2Result<None> SVIILYLGQWJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1021")]
		public LegacyCV2Result<None> ISCQSBOZZNQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1022")]
		public LegacyCV2Result<None> HGIVWOMWEFP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1023")]
		public LegacyCV2Result<None> SLDCYRSONAO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1024")]
		public LegacyCV2Result<None> DUOPDSJGICW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1025")]
		public LegacyCV2Result<None> NavMeshSamplePosition(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1026")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1038")]
		public LegacyCV2Result<None> SJLXCBBIZRI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1039")]
		public LegacyCV2Result<None> DVEMVHSLBMO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1040")]
		public LegacyCV2Result<None> HNRTCSCEWCU(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1041")]
		public LegacyCV2Result<None> KTXNMIGUOPO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1042")]
		public LegacyCV2Result<None> QWWTUQPQAXP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1043")]
		public LegacyCV2Result<None> VGXQVHAQVWB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1044")]
		public LegacyCV2Result<None> NPCIAEPGWDS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1045")]
		public LegacyCV2Result<None> BXBJJZXDAXD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1046")]
		public LegacyCV2Result<None> PPZFCMZLKHK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1047")]
		public LegacyCV2Result<None> YPPDWUHMFRF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1048")]
		public LegacyCV2Result<None> QVWNUIMSINT(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1049")]
		public LegacyCV2Result<None> LCQLDQKNGWM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1050")]
		public LegacyCV2Result<None> NUIELDNGWLR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1051")]
		public LegacyCV2Result<None> TPBDGFKUAMB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1052")]
		public LegacyCV2Result<None> CNINMKIZPZH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1053")]
		public LegacyCV2Result<None> FISQURDNCLH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1054")]
		public LegacyCV2Result<None> XWDMVRZZUIR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1055")]
		public LegacyCV2Result<None> ASEMIYSGIAY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1056")]
		public LegacyCV2Result<None> ZHVEGQTSISY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1057")]
		public LegacyCV2Result<None> VRAIWNBZPCD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1058")]
		public LegacyCV2Result<None> ZTGPWAJSYNN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1059")]
		public LegacyCV2Result<None> CJQXYEQCJOZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1060")]
		public LegacyCV2Result<None> RVCMJGBZTMZ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1061")]
		public LegacyCV2Result<None> WDYIRTWGJWM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1062")]
		public LegacyCV2Result<None> OWGSKJSHBFC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1063")]
		public LegacyCV2Result<None> IsValidAI(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1064")]
		public LegacyCV2Result<None> IsValidCombatant(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC5F0", Offset = "0x2AFB5F0", VA = "0x182AFC5F0", Slot = "1065")]
		public LegacyCV2Result<None> IsValidPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1066")]
		public LegacyCV2Result<None> IsValidReward(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1067")]
		public LegacyCV2Result<None> IsValidAudio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1068")]
		public LegacyCV2Result<None> IsValidRecNetMesh(VBDHXKKGPBY e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1069")]
		public LegacyCV2Result<None> ValidIfNotNull(VBDHXKKGPBY e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1070")]
		public LegacyCV2Result<None> GetVelocityCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1071")]
		public LegacyCV2Result<None> GetVelocityPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1072")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1073")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1074")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1075")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1076")]
		public LegacyCV2Result<None> GetUpVectorPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1077")]
		public LegacyCV2Result<None> GetOrientationCreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1078")]
		public LegacyCV2Result<None> GetOrientationPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1079")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1080")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1081")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1082")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1083")]
		public LegacyCV2Result<None> YQYTCTSQKMF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1084")]
		public LegacyCV2Result<None> XAUOUSKHGFO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1085")]
		public LegacyCV2Result<None> CPAPLWAPQGY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1086")]
		public LegacyCV2Result<None> XQQVXSULYBK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1087")]
		public LegacyCV2Result<None> OKWDTDFFPJC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1088")]
		public LegacyCV2Result<None> VHEASQWVSHW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1089")]
		public LegacyCV2Result<None> VZVHQIQSXSQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1090")]
		public LegacyCV2Result<None> SAVSLAJFLUO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1091")]
		public LegacyCV2Result<None> QNKFMEMUPWG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1092")]
		public LegacyCV2Result<None> AEXDLYQGVHQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1093")]
		public LegacyCV2Result<None> PMPPACZURFY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1094")]
		public LegacyCV2Result<None> FMXOTDCKWRD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1095")]
		public LegacyCV2Result<None> BNFILCIMCWF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1096")]
		public LegacyCV2Result<None> YCXDFPCXPIB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1097")]
		public LegacyCV2Result<None> OSGLAGUIHPP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1098")]
		public LegacyCV2Result<None> AIYBNTQGRIQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1099")]
		public LegacyCV2Result<None> RQQIYYIOSOM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1100")]
		public LegacyCV2Result<None> UCWNHEJOBCX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1101")]
		public LegacyCV2Result<None> AFFJHRYRUBJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1102")]
		public LegacyCV2Result<None> QPSRZLCCJEJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1103")]
		public LegacyCV2Result<None> FLLWOXQFKOV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1104")]
		public LegacyCV2Result<None> JWVPXKSBLVO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1105")]
		public LegacyCV2Result<None> WOTLSFTMUAI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1106")]
		public LegacyCV2Result<None> BSTMRZXKNPT(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1107")]
		public LegacyCV2Result<None> ZVISLPZRYIR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1108")]
		public LegacyCV2Result<None> DCKLBJTIKQF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1109")]
		public LegacyCV2Result<None> LNUTSWUEANX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1110")]
		public LegacyCV2Result<None> FKXXZNACVHO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1111")]
		public LegacyCV2Result<None> PZVBNASQGLX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1112")]
		public LegacyCV2Result<None> WCCXAXGGDYL(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1113")]
		public LegacyCV2Result<None> MTEPQHDTSKX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1114")]
		public LegacyCV2Result<None> AUEGOIAAYWS(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1115")]
		public LegacyCV2Result<None> OZSGDFPKXHA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1116")]
		public LegacyCV2Result<None> UKMGCQYYCBS(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1117")]
		public LegacyCV2Result<None> QMTROSLFFSY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1118")]
		public LegacyCV2Result<None> MKPNRVNPHVY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1119")]
		public LegacyCV2Result<None> SGUTWJYDHGS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1120")]
		public LegacyCV2Result<None> KBHDOZHKZCO(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1121")]
		public LegacyCV2Result<None> ZYRGHAHEVVJ(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1122")]
		public LegacyCV2Result<None> UJEJXMKEMHK(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1123")]
		public LegacyCV2Result<None> KVSVJOYGNIT(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1124")]
		public LegacyCV2Result<None> KNSDCSSNNYA(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1125")]
		public LegacyCV2Result<None> LLUJGNGBPGQ(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1126")]
		public LegacyCV2Result<None> TRJKEMOHJWX(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1127")]
		public LegacyCV2Result<None> UMNIIEVWVGH(HZVEPBQCNVR e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1128")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1129")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1130")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1131")]
		public LegacyCV2Result<None> JJRYGWDUWQF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1132")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1133")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1134")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1135")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1136")]
		public LegacyCV2Result<None> HolotarProjectorPlay(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1137")]
		public LegacyCV2Result<None> HolotarProjectorResume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1138")]
		public LegacyCV2Result<None> HolotarProjectorPause(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1139")]
		public LegacyCV2Result<None> HolotarProjectorStop(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1140")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1141")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1142")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1143")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1144")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1145")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1146")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1147")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1148")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1149")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1150")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1151")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1152")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1153")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1154")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1155")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1156")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1157")]
		public LegacyCV2Result<None> PLJJEUYUHRF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1158")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1159")]
		public LegacyCV2Result<None> VMMYKNLVGET(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1160")]
		public LegacyCV2Result<None> VBNQIGCGZBA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1161")]
		public LegacyCV2Result<None> ZXAXHWYHPER(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1162")]
		public LegacyCV2Result<None> CKLHVTULZUA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1166")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1168")]
		public LegacyCV2Result<None> GunHandleGetCanReload(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1169")]
		public LegacyCV2Result<None> GunHandleSetCanReload(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1170")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1171")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1172")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1173")]
		public LegacyCV2Result<None> ZGNGYEXBCMM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1174")]
		public LegacyCV2Result<None> BWAJXDLXDDS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1175")]
		public LegacyCV2Result<None> NLBQEIKPQOW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1176")]
		public LegacyCV2Result<None> BZEUHZBYYYC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1177")]
		public LegacyCV2Result<None> VTKKVPRPKZX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1178")]
		public LegacyCV2Result<None> ULCUIOOEBTJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1179")]
		public LegacyCV2Result<None> GCYAXDVQPXR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1180")]
		public LegacyCV2Result<None> VSQFCRNZFYR(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1181")]
		public LegacyCV2Result<None> SJMFJJAAQDS(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1182")]
		public LegacyCV2Result<None> MROAJXKCKUM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1183")]
		public LegacyCV2Result<None> FATKRRDJRRF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1184")]
		public LegacyCV2Result<None> PGMHEDSVISE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "181")]
		public LegacyCV2Result<None> WKEDSNFZYVM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "183")]
		public LegacyCV2Result<None> GetIntFromRROColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "184")]
		public LegacyCV2Result<None> GetColorFromRGB(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "185")]
		public LegacyCV2Result<None> GetColorFromHSV(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "186")]
		public LegacyCV2Result<None> GetRGBFromColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "187")]
		public LegacyCV2Result<None> GetHSVFromColor(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC5A0", Offset = "0x2AFB5A0", VA = "0x182AFC5A0", Slot = "188")]
		public bool GYIHMKTKWQI(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1185")]
		public LegacyCV2Result<None> WPIEEYWDQDG(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1186")]
		public LegacyCV2Result<None> HGHOPWRALVF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1187")]
		public LegacyCV2Result<None> YBWSXWXSGDO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(VBDHXKKGPBY e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1199")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1188")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1189")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1190")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1191")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1192")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1193")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1194")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1195")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1196")]
		public LegacyCV2Result<None> GYELHVNCWRH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1197")]
		public LegacyCV2Result<None> CKMGIHNMCAF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "246")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(VBDHXKKGPBY e, InOut io, SYFUDICJKVX objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "247")]
		public LegacyCV2Result<None> EWIHZCNPTII(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "248")]
		public LegacyCV2Result<None> DGVHQXHBSZC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "249")]
		public LegacyCV2Result<None> LOSQWWESIGE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "250")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "251")]
		public LegacyCV2Result<None> PINEXRZUPBP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "252")]
		public LegacyCV2Result<None> OJJTAPGYJRV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "253")]
		public LegacyCV2Result<None> XLEAFFVSSGD(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "254")]
		public LegacyCV2Result<None> UDGOZWUYHEI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "255")]
		public LegacyCV2Result<None> YQZURUBAKPK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "256")]
		public LegacyCV2Result<None> TFKMQFBURKF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "257")]
		public LegacyCV2Result<None> NLYGEVEUUCN(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "258")]
		public LegacyCV2Result<None> UKIHNDSBDEH(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "259")]
		public LegacyCV2Result<None> AVWNSDJWSTJ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "260")]
		public LegacyCV2Result<None> HBXYKLXHHKI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "261")]
		public LegacyCV2Result<None> ZLEAWEVCRKE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "262")]
		public LegacyCV2Result<None> HGARLBFFUPW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "263")]
		public LegacyCV2Result<None> MADLKOWICVM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "264")]
		public LegacyCV2Result<None> VMRHXLJLDDY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "265")]
		public LegacyCV2Result<None> TUAQHRHDWLW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "266")]
		public LegacyCV2Result<None> SKHGAXILVCA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "267")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "268")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "269")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10")]
		private static LegacyCV2Result<None> Default(VBDHXKKGPBY e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC6B0", Offset = "0x2AFB6B0", VA = "0x182AFC6B0", Slot = "1200")]
		public LegacyCV2Result<None> YAFPVQLFRKH(VBDHXKKGPBY a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1203")]
		public LegacyCV2Result<None> XWJABRLEOIC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1204")]
		public LegacyCV2Result<None> UIJHIJMCLRO(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1205")]
		public LegacyCV2Result<None> IBUFNTDVDTM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1206")]
		public LegacyCV2Result<None> IPTVSYOKVKX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1201")]
		public LegacyCV2Result<None> ConstantQuickChatTable(VBDHXKKGPBY e, InOut io, ZWVAXNGBMGX quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1202")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1027")]
		public LegacyCV2Result<None> UPVRLVJUZUY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1028")]
		public LegacyCV2Result<None> XRQSAGJPJPW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1029")]
		public LegacyCV2Result<None> HIAUPIQYEFK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1030")]
		public LegacyCV2Result<None> IZKGFTZISAA(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1031")]
		public LegacyCV2Result<None> EVSYSSKQAQC(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1032")]
		public LegacyCV2Result<None> CCMDAJBSMDQ(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1033")]
		public LegacyCV2Result<None> KFTCDXELLIY(VBDHXKKGPBY a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1034")]
		public LegacyCV2Result<None> MBELJRVZHHI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1035")]
		public LegacyCV2Result<None> BVVHPMCRTDE(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1036")]
		public LegacyCV2Result<None> MNHAHKVGGBX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1037")]
		public LegacyCV2Result<None> NLOEAINNUIV(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1210")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1211")]
		public LegacyCV2Result<None> HandleSetControlLabel(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1212")]
		public LegacyCV2Result<None> HandleGetControlLabel(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1213")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1214")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1215")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1216")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1217")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NCQRIWGNQCH(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1224")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1225")]
		public LegacyCV2Result<None> HULBNLFHGZM(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1226")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1227")]
		public LegacyCV2Result<None> XJDCUHJMTCF(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1228")]
		public LegacyCV2Result<None> ElementSnapToElement(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1229")]
		public LegacyCV2Result<None> ElementUnsnap(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1230")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1231")]
		public LegacyCV2Result<None> SnapPointUnsnap(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1218")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1219")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1220")]
		public LegacyCV2Result<None> WMZDRLBBXZP(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1221")]
		public LegacyCV2Result<None> GetTexture(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1222")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1223")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1232")]
		public LegacyCV2Result<None> GMDZTOTYMOX(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1233")]
		public LegacyCV2Result<None> OUJNAIUSKGW(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1234")]
		public LegacyCV2Result<None> AMCLIAHPYZI(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1235")]
		public LegacyCV2Result<None> PVTYDELJZTY(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1236")]
		public LegacyCV2Result<None> ARKSYCVCJIL(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1237")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ERLIVNAOIFV(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1238")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GYJPNMCJEHN(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1239")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SFAZTRTOORZ(VBDHXKKGPBY a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC740", Offset = "0x2AFB740", VA = "0x182AFC740")]
		public IHDRNCRJSLE([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1256")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1257")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1258")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1259")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1260")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1261")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1262")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1266")]
		public LegacyCV2Result<None> ConstantBodyPart(VBDHXKKGPBY e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1267")]
		public LegacyCV2Result<None> VPWIWRADOAK(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1268")]
		public LegacyCV2Result<None> GGXRAIQIGTB(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1269")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "590")]
		public LegacyCV2Result<None> QESJNPXIZCT(VBDHXKKGPBY e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1270")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1271")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1272")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1273")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1274")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1275")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1276")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1277")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1278")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1279")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1280")]
		public LegacyCV2Result<None> YXIENCUKEZC(HZVEPBQCNVR e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1281")]
		public LegacyCV2Result<None> VTAXTKXZIUD(HZVEPBQCNVR e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1282")]
		public LegacyCV2Result<None> EQOJOGJWENO(HZVEPBQCNVR e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1283")]
		public LegacyCV2Result<None> DMIITIGZBEM(HZVEPBQCNVR e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1284")]
		public LegacyCV2Result<None> RPEHEFHSNJB(HZVEPBQCNVR e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10")]
		public LegacyCV2Result<None> ConstantStorefrontItem(VBDHXKKGPBY e, InOut io, [In] OZPEAZUXJHE storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1209")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(VBDHXKKGPBY e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1198")]
		private LegacyCV2Result<None> LSOZUNCBTZM(VBDHXKKGPBY a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1207")]
		private LegacyCV2Result<None> NAHAKNXUEGF(VBDHXKKGPBY a, InOut b, [In] OZPEAZUXJHE storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x11A3E10", Offset = "0x11A2E10", VA = "0x1811A3E10", Slot = "1248")]
		private LegacyCV2Result<None> GAQMVTBDBYT(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class IUIEXEAKBLB : AMNDPFWHNKI
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(KCBSOWUROYL node);

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly IUIEXEAKBLB KUUVBNWAQPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate ZCKVBXXJCAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate VNKBUWVCDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private bool QQQOEOWLLBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool QHMGACEBRGW;

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200", Slot = "4")]
		public Task<bool> VEGLKDWOSON(KCBSOWUROYL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x2B091B0", Offset = "0x2B081B0", VA = "0x182B091B0", Slot = "5")]
		public Task<bool> OBRNUHPMMUE(KCBSOWUROYL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x2B092B0", Offset = "0x2B082B0", VA = "0x182B092B0")]
		public IUIEXEAKBLB([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x2B091E0", Offset = "0x2B081E0", VA = "0x182B091E0", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? SHBRDISNWXV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xAD8BC0", Offset = "0xAD7BC0", VA = "0x180AD8BC0", Slot = "7")]
		public bool LKOEIRJVQXQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x16A89A0", Offset = "0x16A79A0", VA = "0x1816A89A0", Slot = "8")]
		public bool MSXEZUYEQJE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class ZHTRSCMZSTL : HMAGXBXIHZK
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid IHQEVJPWJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0xF91B80", Offset = "0xF90B80", VA = "0x180F91B80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
		public void Bind(IGXYACVXNXI pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x11E0A20", Offset = "0x11DFA20", VA = "0x1811E0A20")]
		public ZHTRSCMZSTL(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2B11950", Offset = "0x2B10950", VA = "0x182B11950")]
		public static ZHTRSCMZSTL New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class FFWNIRQRXXN : DHDIWDIOMXF
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<ZOMVBRTCATC> nodeDefId, Id128<LNVRVOESCOU>? legacyInnerGraphId, IReadOnlyDictionary<Id128<LNVRVOESCOU>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private IsNodeRestrictedDelegate? TJAFDGXFTMY;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool DDTWZZVEOAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0xB21E00", Offset = "0xB20E00", VA = "0x180B21E00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool QNKWPUJJEDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x2B09070", Offset = "0x2B08070", VA = "0x182B09070", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool QEJMVDHKKZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2173AB0", Offset = "0x2172AB0", VA = "0x182173AB0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "6")]
		public bool FJACGZPPPRS(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "7")]
		public CanSaveObjectIntoInventionResultType ZQXOSHLARLH(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2B09020", Offset = "0x2B08020", VA = "0x182B09020", Slot = "8")]
		public bool TNNAFHOBQEI(Id128<ZOMVBRTCATC> nodeDefId, Id128<LNVRVOESCOU>? legacyInnerGraphId, IReadOnlyDictionary<Id128<LNVRVOESCOU>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "9")]
		public bool ZLQKNTFAQCH(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "10")]
		public bool QVINZTYTAML(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x2B09080", Offset = "0x2B08080", VA = "0x182B09080")]
		public FFWNIRQRXXN(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class XMJEFGVVHLF : JQBXOMLBUJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly XMJEFGVVHLF KUUVBNWAQPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly ShouldLogEventSenderToMakerPenDelegate FJCUIRIUWCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate FQUFIQIAERJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LCEKEDVXLSP
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x1389710", Offset = "0x1388710", VA = "0x181389710", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool IABCICNBYDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2B113F0", Offset = "0x2B103F0", VA = "0x182B113F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x2B11490", Offset = "0x2B10490", VA = "0x182B11490")]
		public XMJEFGVVHLF([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ULKTDJDOLYH : WKUYAUAYQMR<JCUVPIZWEBL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class EMVOQIEHUKQ : JCUVPIZWEBL, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public static readonly EMVOQIEHUKQ HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool NYIDVADDLVI
			{
				[Cpp2IlInjected.Token(Token = "0x600074E")]
				[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x2B08F80", Offset = "0x2B07F80", VA = "0x182B08F80", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			public void FAKBZIEIFKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public EMVOQIEHUKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly ULKTDJDOLYH HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private ULKTDJDOLYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2B11030", Offset = "0x2B10030", VA = "0x182B11030", Slot = "4")]
		public JCUVPIZWEBL LAVWNHZCBUM()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class QBYDPTCZCSP<a, b> : IDisposable, YYFDGRCCPXY where a : notnull where b : notnull, OGWXACRVNZL.XSBPVWOYINP<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly b RAESGKCNHZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly a CRYNISDMEBU;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<DQQOGREBWGB> RCVFUAVSNTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<DQQOGREBWGB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A6B0", Offset = "0x5E296B0", VA = "0x185E2A6B0")]
		public QBYDPTCZCSP(b a, a b, Id32<DQQOGREBWGB> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x5E28960", Offset = "0x5E27960", VA = "0x185E28960", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x5E28460", Offset = "0x5E27460", VA = "0x185E28460")]
		public Id32<LDCKCJVHREK> CIOZYXOEZYT([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<LDCKCJVHREK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x5E28E80", Offset = "0x5E27E80", VA = "0x185E28E80", Slot = "6")]
		public void MDDQGQJWNSU(Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x5E29170", Offset = "0x5E28170", VA = "0x185E29170", Slot = "7")]
		public void VFYMRTPAJWO(Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A5B0", Offset = "0x5E295B0", VA = "0x185E2A5B0", Slot = "8")]
		public void ZWVMSLCZDAX(Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x5E293D0", Offset = "0x5E283D0", VA = "0x185E293D0", Slot = "10")]
		public void WWLRJYNFWZO(Id32<LDCKCJVHREK> objectId, Id32<DQQOGREBWGB> clientId, QXODCZYRTYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x5E29950", Offset = "0x5E28950", VA = "0x185E29950", Slot = "9")]
		public void ZIHJKFINYVQ(Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x5E289A0", Offset = "0x5E279A0", VA = "0x185E289A0", Slot = "11")]
		public void GGEHAASOMUI(Id32<LDCKCJVHREK> objectId, VKKUIVYOEIX? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x5E29E60", Offset = "0x5E28E60", VA = "0x185E29E60", Slot = "12")]
		public Id32<DQQOGREBWGB> ZQXTETLBYDN(Id32<LDCKCJVHREK> objectId)
		{
			return default(Id32<DQQOGREBWGB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x5E298E0", Offset = "0x5E288E0", VA = "0x185E298E0", Slot = "13")]
		public Id32<QQPDWFLGPJE> XEHCUYPDZFH(Id32<LDCKCJVHREK> objectId, string a, object b, bool c, BLUYRSGGJVM d, HHQAWKBEXNQ e)
		{
			return default(Id32<QQPDWFLGPJE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x5E29E20", Offset = "0x5E28E20", VA = "0x185E29E20", Slot = "14")]
		public void ZJEXOAWXZTJ(Id32<QQPDWFLGPJE> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x5E29120", Offset = "0x5E28120", VA = "0x185E29120", Slot = "15")]
		public void NCENUUAEBOD(Id32<QQPDWFLGPJE> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class OGWXACRVNZL
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface XSBPVWOYINP<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SNOFSDZULEN(a a, Id32<DQQOGREBWGB> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<DQQOGREBWGB>? NUBACVUDVAO(a a);

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<LDCKCJVHREK> CIOZYXOEZYT(a a, Id32<DQQOGREBWGB> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void MDDQGQJWNSU(a a, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ b);

			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void VFYMRTPAJWO(a a, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ b);

			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void WWLRJYNFWZO(a a, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ b);

			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void ZIHJKFINYVQ(a a, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ b);

			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void GGEHAASOMUI(a a, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, VKKUIVYOEIX? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<DQQOGREBWGB>? ZQXTETLBYDN(a a, Id32<LDCKCJVHREK> objectId);

			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<QQPDWFLGPJE> XEHCUYPDZFH(a a, Id32<DQQOGREBWGB> clientId, string b, object c, BLUYRSGGJVM d, HHQAWKBEXNQ e);

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void ZJEXOAWXZTJ(a a, Id32<DQQOGREBWGB> clientId, Id32<QQPDWFLGPJE> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void NCENUUAEBOD(a a, Id32<DQQOGREBWGB> clientId, Id32<QQPDWFLGPJE> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class POHFKDOWUJL
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public readonly HashSet<Id32<LDCKCJVHREK>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public SOAId32Field<QQPDWFLGPJE, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public readonly Dictionary<Id32<QQPDWFLGPJE>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<QQPDWFLGPJE>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAField<LDCKCJVHREK, VKKUIVYOEIX?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B450", Offset = "0x2B0A450", VA = "0x182B0B450")]
			private MockCV2DynamicNetSys(HashSet<Id32<LDCKCJVHREK>> authorityOf, [In] SOAId32Field<QQPDWFLGPJE, MockCV2SyncField> syncFields, Dictionary<Id32<QQPDWFLGPJE>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<QQPDWFLGPJE>> mockSyncFieldToSyncField, [In] SOAField<LDCKCJVHREK, VKKUIVYOEIX?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B290", Offset = "0x2B0A290", VA = "0x182B0B290")]
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
			public Id32<DQQOGREBWGB>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B4F0", Offset = "0x2B0A4F0", VA = "0x182B0B4F0")]
			public MockCV2ObjectShared(Id32<DQQOGREBWGB> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public HHQAWKBEXNQ SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public BLUYRSGGJVM SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
			internal MockCV2SyncField(HHQAWKBEXNQ syncField, BLUYRSGGJVM syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B610", Offset = "0x2B0A610", VA = "0x182B0B610")]
			public static MockCV2SyncField New(HHQAWKBEXNQ syncField, BLUYRSGGJVM syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x2B0B5C0", Offset = "0x2B0A5C0", VA = "0x182B0B5C0")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B570", Offset = "0x2B0A570", VA = "0x182B0B570")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private SOAId32Field<LDCKCJVHREK, MockCV2ObjectShared> SGNAKCUWGOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<LDCKCJVHREK>> UFWJNQUJGVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> PALZEQFSDGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> NBFCEXPSPTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private SOAField<DQQOGREBWGB, MockCV2DynamicNetSys> SODLOGAMPBI;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<LDCKCJVHREK>? ECMHNWHOJCO
		{
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0xC1E610", Offset = "0xC1D610", VA = "0x180C1E610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x133E090", Offset = "0x133D090", VA = "0x18133E090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C760", Offset = "0x2B0B760", VA = "0x182B0C760")]
		public void Destroy([In] SOAId32<DQQOGREBWGB> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C9A0", Offset = "0x2B0B9A0", VA = "0x182B0C9A0")]
		public void EYNHNMWDQST(Id32<DQQOGREBWGB> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D2C0", Offset = "0x2B0C2C0", VA = "0x182B0D2C0")]
		public void SNOFSDZULEN(Id32<DQQOGREBWGB> clientId, Id32<DQQOGREBWGB>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C350", Offset = "0x2B0B350", VA = "0x182B0C350")]
		public Id32<LDCKCJVHREK> CIOZYXOEZYT(Id32<DQQOGREBWGB> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<DQQOGREBWGB> clientIds)
		{
			return default(Id32<LDCKCJVHREK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D920", Offset = "0x2B0C920", VA = "0x182B0D920")]
		public Id32<QQPDWFLGPJE> XEHCUYPDZFH(Id32<DQQOGREBWGB> clientId, string a, object b, BLUYRSGGJVM c, HHQAWKBEXNQ d)
		{
			return default(Id32<QQPDWFLGPJE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DD00", Offset = "0x2B0CD00", VA = "0x182B0DD00")]
		public void ZJEXOAWXZTJ(Id32<DQQOGREBWGB> clientId, Id32<QQPDWFLGPJE> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D610", Offset = "0x2B0C610", VA = "0x182B0D610")]
		public Id32<LDCKCJVHREK>? SRNSFSUMHDA([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CED0", Offset = "0x2B0BED0", VA = "0x182B0CED0")]
		public void MDDQGQJWNSU([In] SOAId32<DQQOGREBWGB> clientIds, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D6E0", Offset = "0x2B0C6E0", VA = "0x182B0D6E0")]
		public void VFYMRTPAJWO(Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D820", Offset = "0x2B0C820", VA = "0x182B0D820")]
		public void WWLRJYNFWZO(Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DB80", Offset = "0x2B0CB80", VA = "0x182B0DB80")]
		public void ZIHJKFINYVQ([In] SOAId32<DQQOGREBWGB> clientIds, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CE00", Offset = "0x2B0BE00", VA = "0x182B0CE00")]
		public void GGEHAASOMUI(Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, VKKUIVYOEIX? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DE90", Offset = "0x2B0CE90", VA = "0x182B0DE90")]
		public Id32<DQQOGREBWGB>? ZQXTETLBYDN(Id32<LDCKCJVHREK> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CF50", Offset = "0x2B0BF50", VA = "0x182B0CF50")]
		public void NCENUUAEBOD([In] SOAId32<DQQOGREBWGB> clientIds, Id32<DQQOGREBWGB> clientId, Id32<QQPDWFLGPJE> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DEE0", Offset = "0x2B0CEE0", VA = "0x182B0DEE0")]
		public POHFKDOWUJL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class CMLQQCMRPQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B08DF0", Offset = "0x2B07DF0", VA = "0x182B08DF0")]
		public static void Destroy(this POHFKDOWUJL.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ZKZINDMOBLM : CIEXTHALXFY.ICTTKLBYQGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static ZKZINDMOBLM ZMADFVIQRIP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate IKJNIEFSUAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate HUERKWPQKCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xAD9FF0", Offset = "0xAD8FF0", VA = "0x180AD9FF0")]
		public ZKZINDMOBLM(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class OJTYTSYFGFU : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : DYPZVZBTZVR.NAOLIBVLUKE<AGLENQQYPWD, OJTYTSYFGFU>
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
				public AsyncTaskMethodBuilder<Result<object, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public OJTYTSYFGFU root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public Id32<DQQOGREBWGB> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public AGLENQQYPWD action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				private TaskAwaiter<Result<object, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000798")]
				[Cpp2IlInjected.Address(RVA = "0x2B10180", Offset = "0x2B0F180", VA = "0x182B10180", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000799")]
				[Cpp2IlInjected.Address(RVA = "0x2B103C0", Offset = "0x2B0F3C0", VA = "0x182B103C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "4")]
			public int PCEFNSABJBI(OJTYTSYFGFU a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E470", Offset = "0x2B0D470", VA = "0x182B0E470", Slot = "5")]
			public int WEXLKHIUPDU(OJTYTSYFGFU a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E400", Offset = "0x2B0D400", VA = "0x182B0E400", Slot = "6")]
			public int KTSWPXIPLBL(OJTYTSYFGFU a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x1032510", Offset = "0x1031510", VA = "0x181032510", Slot = "7")]
			public int ECODOPBRDOF(OJTYTSYFGFU a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E420", Offset = "0x2B0D420", VA = "0x182B0E420", Slot = "8")]
			public void VOYNRHJEXFS(OJTYTSYFGFU a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "9")]
			public bool GDVQVJEJIVL(OJTYTSYFGFU a, Id32<DQQOGREBWGB> actorId, AGLENQQYPWD[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "10")]
			public bool FBVFPCBLFVJ(OJTYTSYFGFU a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E2B0", Offset = "0x2B0D2B0", VA = "0x182B0E2B0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, BGYAXKJXFCB>> CDPQVGWXFFF(OJTYTSYFGFU a, Id32<DQQOGREBWGB> senderId, AGLENQQYPWD b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : DYPZVZBTZVR.XRRCBJBDPQX<ActionDeps, ICGXRSEYDCA.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps NHHGFLRBIOF
			{
				[Cpp2IlInjected.Token(Token = "0x600079A")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public ICGXRSEYDCA.StaticNetSysReceiverDeps HWOFRMPSQIS
			{
				[Cpp2IlInjected.Token(Token = "0x600079B")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "5")]
				get
				{
					return default(ICGXRSEYDCA.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps YEHKPGJTORZ
			{
				[Cpp2IlInjected.Token(Token = "0x600079C")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : LSGYORSAZLX.XSBPVWOYINP<OJTYTSYFGFU>
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
				public AsyncTaskMethodBuilder<Result<object?, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				public OJTYTSYFGFU root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public Id32<DQQOGREBWGB> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public AGLENQQYPWD action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				private TaskAwaiter<Result<object?, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x2B0FE60", Offset = "0x2B0EE60", VA = "0x182B0FE60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079F")]
				[Cpp2IlInjected.Address(RVA = "0x2B10110", Offset = "0x2B0F110", VA = "0x182B10110", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B650", Offset = "0x2B0A650", VA = "0x182B0B650", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, BGYAXKJXFCB>> CDPQVGWXFFF(OJTYTSYFGFU a, Id32<DQQOGREBWGB> clientId, AGLENQQYPWD b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : OGWXACRVNZL.XSBPVWOYINP<OJTYTSYFGFU>
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AE30", Offset = "0x2B09E30", VA = "0x182B0AE30", Slot = "4")]
			public void SNOFSDZULEN(OJTYTSYFGFU a, Id32<DQQOGREBWGB> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x10326F0", Offset = "0x10316F0", VA = "0x1810326F0", Slot = "5")]
			public Id32<DQQOGREBWGB>? NUBACVUDVAO(OJTYTSYFGFU a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AC30", Offset = "0x2B09C30", VA = "0x182B0AC30")]
			public Id32<LDCKCJVHREK> CIOZYXOEZYT(OJTYTSYFGFU a, Id32<DQQOGREBWGB> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<LDCKCJVHREK>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AD70", Offset = "0x2B09D70", VA = "0x182B0AD70", Slot = "7")]
			public void MDDQGQJWNSU(OJTYTSYFGFU a, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AE60", Offset = "0x2B09E60", VA = "0x182B0AE60", Slot = "8")]
			public void VFYMRTPAJWO(OJTYTSYFGFU a, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AFC0", Offset = "0x2B09FC0", VA = "0x182B0AFC0", Slot = "9")]
			public void WWLRJYNFWZO(OJTYTSYFGFU a, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B060", Offset = "0x2B0A060", VA = "0x182B0B060", Slot = "10")]
			public void ZIHJKFINYVQ(OJTYTSYFGFU a, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, QXODCZYRTYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AC90", Offset = "0x2B09C90", VA = "0x182B0AC90", Slot = "11")]
			public void GGEHAASOMUI(OJTYTSYFGFU a, Id32<DQQOGREBWGB> clientId, Id32<LDCKCJVHREK> objectId, VKKUIVYOEIX? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B230", Offset = "0x2B0A230", VA = "0x182B0B230", Slot = "12")]
			public Id32<DQQOGREBWGB>? ZQXTETLBYDN(OJTYTSYFGFU a, Id32<LDCKCJVHREK> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B000", Offset = "0x2B0A000", VA = "0x182B0B000", Slot = "13")]
			public Id32<QQPDWFLGPJE> XEHCUYPDZFH(OJTYTSYFGFU a, Id32<DQQOGREBWGB> clientId, string b, object c, BLUYRSGGJVM d, HHQAWKBEXNQ e)
			{
				return default(Id32<QQPDWFLGPJE>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B090", Offset = "0x2B0A090", VA = "0x182B0B090", Slot = "14")]
			public void ZJEXOAWXZTJ(OJTYTSYFGFU a, Id32<DQQOGREBWGB> clientId, Id32<QQPDWFLGPJE> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AE00", Offset = "0x2B09E00", VA = "0x182B0AE00", Slot = "15")]
			public void NCENUUAEBOD(OJTYTSYFGFU a, Id32<DQQOGREBWGB> clientId, Id32<QQPDWFLGPJE> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AC30", Offset = "0x2B09C30", VA = "0x182B0AC30", Slot = "6")]
			private Id32<LDCKCJVHREK> GGBUPTTBFYR(OJTYTSYFGFU a, Id32<DQQOGREBWGB> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<LDCKCJVHREK>);
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
			public OJTYTSYFGFU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public Id32<LDCKCJVHREK>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public JVEJJWJVKSR deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private Id32<DQQOGREBWGB> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC8")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private QUFIWQZKMRB<OJTYTSYFGFU, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private QBYDPTCZCSP<OJTYTSYFGFU, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private ICGXRSEYDCA <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F7A0", Offset = "0x2B0E7A0", VA = "0x182B0F7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FDF0", Offset = "0x2B0EDF0", VA = "0x182B0FDF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly HLPEPMUAOMN<AGLENQQYPWD, None, ICGXRSEYDCA, ActionDeps, ICGXRSEYDCA.StaticNetSysReceiverDeps, RootDeps, OJTYTSYFGFU, Deps> OLQJBDWNFFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly POHFKDOWUJL HWNPSDTCZYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private SOAId32<DQQOGREBWGB> JVTXUCPAUMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAField<DQQOGREBWGB, None> SODLOGAMPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<DQQOGREBWGB, ICGXRSEYDCA> UMYHXCAANGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Id32<DQQOGREBWGB>? DZYKMAHZEOT;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate PCRDWCPDQHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xACEBB0", Offset = "0xACDBB0", VA = "0x180ACEBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BE70", Offset = "0x2B0AE70", VA = "0x182B0BE70")]
		public OJTYTSYFGFU(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B7B0", Offset = "0x2B0A7B0", VA = "0x182B0B7B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B980", Offset = "0x2B0A980", VA = "0x182B0B980")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> EYNHNMWDQST(JVEJJWJVKSR a, RegistryV2 b, Id32<LDCKCJVHREK>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BB00", Offset = "0x2B0AB00", VA = "0x182B0BB00")]
		private void SNOFSDZULEN(Id32<DQQOGREBWGB> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BD90", Offset = "0x2B0AD90", VA = "0x182B0BD90")]
		[CompilerGenerated]
		private Id32<LDCKCJVHREK>? WCJYUTCIVEN([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class ANMLIERMYZR : VFCMMUNYJTZ.ICTTKLBYQGC
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<SATWJHVPDBI> DeserializeCircuitsJunctionAsyncDelegate(ICGXRSEYDCA circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<SATWJHVPDBI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public ANMLIERMYZR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public ICGXRSEYDCA circuitsManager;

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
			private TaskAwaiter<SATWJHVPDBI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E490", Offset = "0x2B0D490", VA = "0x182B0E490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E690", Offset = "0x2B0D690", VA = "0x182B0E690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate WHWMHJMDCVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly LifecycleDidInitializeDelegate? SEMLYDCCXAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleWillDestroyDelegate? XUIMNFPAKAH;

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B08A10", Offset = "0x2B07A10", VA = "0x182B08A10", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<SATWJHVPDBI> AYOHULDUPUD(ICGXRSEYDCA a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x10C11E0", Offset = "0x10C01E0", VA = "0x1810C11E0", Slot = "5")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x11649D0", Offset = "0x11639D0", VA = "0x1811649D0", Slot = "6")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B08B80", Offset = "0x2B07B80", VA = "0x182B08B80")]
		public ANMLIERMYZR([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class KEDETVLBTAL : DEAYNPZYJML.ICTTKLBYQGC
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate ZZZJGZASNDB GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<VIDZMMRWGND> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<RMSEJYRZGFH> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<DEAYNPZYJML.ICTTKLBYQGC.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<DEAYNPZYJML.ICTTKLBYQGC.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public KEDETVLBTAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			private TaskAwaiter<DEAYNPZYJML.ICTTKLBYQGC.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E700", Offset = "0x2B0D700", VA = "0x182B0E700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E8F0", Offset = "0x2B0D8F0", VA = "0x182B0E8F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<RMSEJYRZGFH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public KEDETVLBTAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private TaskAwaiter<RMSEJYRZGFH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E960", Offset = "0x2B0D960", VA = "0x182B0E960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EB50", Offset = "0x2B0DB50", VA = "0x182B0EB50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<VIDZMMRWGND> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public KEDETVLBTAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			private TaskAwaiter<VIDZMMRWGND> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EBC0", Offset = "0x2B0DBC0", VA = "0x182B0EBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EDB0", Offset = "0x2B0DDB0", VA = "0x182B0EDB0", Slot = "5")]
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
			public KEDETVLBTAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EE20", Offset = "0x2B0DE20", VA = "0x182B0EE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F010", Offset = "0x2B0E010", VA = "0x182B0F010", Slot = "5")]
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
			public KEDETVLBTAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F080", Offset = "0x2B0E080", VA = "0x182B0F080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F270", Offset = "0x2B0E270", VA = "0x182B0F270", Slot = "5")]
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
			public KEDETVLBTAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F2E0", Offset = "0x2B0E2E0", VA = "0x182B0F2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F4D0", Offset = "0x2B0E4D0", VA = "0x182B0F4D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly GetCV2DependenciesDelegate ZHHXECNBYVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetRoomDataAsyncDelegate ERAWLCVCNUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetSuperRoomDataAsyncDelegate PSZWCRHLKQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetRoomAssetDataAsyncDelegate PZTYSQQGTHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetPlayerSaveDataAsyncDelegate MZKQDAAXNCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate XIEQGPGREDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetStaticCircuitsConfigAsyncDelegate LKCFVCRCMVP;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public ZZZJGZASNDB ZZZJGZASNDB
		{
			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x1389710", Offset = "0x1388710", VA = "0x181389710", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B09C20", Offset = "0x2B08C20", VA = "0x182B09C20", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> ITENEJUIYBW(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B09D30", Offset = "0x2B08D30", VA = "0x182B09D30", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> PAPRICEPMLZ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B09B10", Offset = "0x2B08B10", VA = "0x182B09B10", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<VIDZMMRWGND> HKAWSNNRQPK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B09F50", Offset = "0x2B08F50", VA = "0x182B09F50", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<RMSEJYRZGFH> VCXIBUPMMFX(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B09E40", Offset = "0x2B08E40", VA = "0x182B09E40", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<DEAYNPZYJML.ICTTKLBYQGC.CircuitGraphToolMapping> RRQLKSMRGDA(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B09A00", Offset = "0x2B08A00", VA = "0x182B09A00", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> ECYOKOJPDPT(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A060", Offset = "0x2B09060", VA = "0x182B0A060")]
		public KEDETVLBTAL(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class PKLQPJRENNR : CV2Request.ICTTKLBYQGC
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly CV2Request.ICTTKLBYQGC HNQVBJEYTYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly GetCanSendRequestsDelegate VVGPYHOQAVF;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public PKLQPJRENNR(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x1389710", Offset = "0x1388710", VA = "0x181389710", Slot = "4")]
		public bool CSGMXSBOHFB()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class YKMKBINKKDC : DUQMTWSATKX
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, TBKCGNLOMPR> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly TryReportErrToUserDelegate EIMQRLHBNDT;

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200")]
		public bool PBPQUFKUWQF([In] Result<None, TBKCGNLOMPR> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B11790", Offset = "0x2B10790", VA = "0x182B11790")]
		public YKMKBINKKDC([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200", Slot = "4")]
		private bool LARJXPNYQCW([In] Result<None, TBKCGNLOMPR> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class BLZKYFLSJLT : YVVNDNVNRHU
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate VBDHXKKGPBY CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public static readonly BLZKYFLSJLT HNQVBJEYTYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly CurrentExecParamsDelegate? MNHTCOVQRTR;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public VBDHXKKGPBY EVGGHXOZBIV
		{
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x1389710", Offset = "0x1388710", VA = "0x181389710", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public BLZKYFLSJLT([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class KNLXYIUGGWZ : XDGOQWUJYOU
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly XDGOQWUJYOU HNQVBJEYTYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly GetGameColorFromIdDelegate UUAFZBUPDGF;

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200", Slot = "4")]
		public CircuitsColor ZWSKNQEFCKN(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AA80", Offset = "0x2B09A80", VA = "0x182B0AA80")]
		public KNLXYIUGGWZ([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class WLOHRRUOBPT : QMQBHLTBDHS
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
			public WLOHRRUOBPT <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x2B0F540", Offset = "0x2B0E540", VA = "0x182B0F540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080F")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F730", Offset = "0x2B0E730", VA = "0x182B0F730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly IsStringPureAsyncDelegate KDKJCJXXQQE;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2B110F0", Offset = "0x2B100F0", VA = "0x182B110F0", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> WEMRIFHACEW(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2B11230", Offset = "0x2B10230", VA = "0x182B11230")]
		public WLOHRRUOBPT([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class RSAWSKTMWYL : FTANEFSKGGW
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate FIFOCXACINM? GetNodeVisualizationConfigDelegate([In] Id128<ZOMVBRTCATC> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly FTANEFSKGGW HNQVBJEYTYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly GetNodeVisualizationConfigDelegate BLRFFSXKDHF;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200")]
		public FIFOCXACINM? OTVTHECDBTN([In] Id128<ZOMVBRTCATC> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E0F0", Offset = "0x2B0D0F0", VA = "0x182B0E0F0")]
		public RSAWSKTMWYL([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200", Slot = "4")]
		private FIFOCXACINM GKHHPTJFHRT([In] Id128<ZOMVBRTCATC> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class CSIFHEASXYK : CZELBKTCHRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x2B08E50", Offset = "0x2B07E50", VA = "0x182B08E50", Slot = "4")]
		public DAKHVQKUFGW GPZNFONSKBE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public CSIFHEASXYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class JBMKPRZVKYG : TAUFXFXZSLV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly Dictionary<string, bool> THBDOINNPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, float> CFMWUGDUDSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, double> GFRAVUAQPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, int> IWCLQIWSMVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, long> BBZQBTJJNVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, string> RUBVQIOSABW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, uint> VXELVPGKVOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, ulong> OSDSJBEGNUY;

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2B096F0", Offset = "0x2B086F0", VA = "0x182B096F0", Slot = "4")]
		public bool? ZYHVOEBBLHF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x2B09790", Offset = "0x2B08790", VA = "0x182B09790")]
		public JBMKPRZVKYG()
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
