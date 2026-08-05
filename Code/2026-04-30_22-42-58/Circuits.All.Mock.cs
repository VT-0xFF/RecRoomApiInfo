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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B03DF0", Offset = "0x2B031F0", VA = "0x182B03DF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		internal sealed class YWLMYXBUJNI : RXPKFMSOGUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public YWLMYXBUJNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120", Slot = "4")]
			public RXPKFMSOGUZ RURUWCUXGOF(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120", Slot = "5")]
			public RXPKFMSOGUZ SLDQJBWYGZW(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120", Slot = "6")]
			public RXPKFMSOGUZ VGEBCEAZCTC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
			public void ISHNKJMJOID()
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
	public static class XQGAGUYFCDB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class VUGRTXXDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public KIRCHECAFFG QKATXGSJKXD;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B0BA70", Offset = "0x2B0AE70", VA = "0x182B0BA70")]
			internal YCULPWATBNY YQMJHYZZFRS(GetNetworkObjectDelegate a)
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
			public ZVMBXFNFHDW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public MGQGRHRPFYH network;

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
			[Cpp2IlInjected.Address(RVA = "0x2B05410", Offset = "0x2B04810", VA = "0x182B05410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B05AB0", Offset = "0x2B04EB0", VA = "0x182B05AB0", Slot = "5")]
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
			public MGQGRHRPFYH network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ZVMBXFNFHDW dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<QXDOXFETTHL>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private SCQFSPRNDPD <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B05B20", Offset = "0x2B04F20", VA = "0x182B05B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B060B0", Offset = "0x2B054B0", VA = "0x182B060B0", Slot = "5")]
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
			public KIRCHECAFFG roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B06120", Offset = "0x2B05520", VA = "0x182B06120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B06630", Offset = "0x2B05A30", VA = "0x182B06630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C100", Offset = "0x2B0B500", VA = "0x182B0C100")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? KRXANMHDLMO([Optional] KIRCHECAFFG? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BD70", Offset = "0x2B0B170", VA = "0x182B0BD70")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> EBVCWFGYJNV(MGQGRHRPFYH a, [Optional] ZVMBXFNFHDW? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BEF0", Offset = "0x2B0B2F0", VA = "0x182B0BEF0")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> EBVCWFGYJNV(MGQGRHRPFYH a, ZVMBXFNFHDW b, RegistryV2 c, Id32<QXDOXFETTHL>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C2F0", Offset = "0x2B0B6F0", VA = "0x182B0C2F0")]
		public static (RuntimeFnRegistry, RuntimeFns) RSWNCWRZSFN()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C1F0", Offset = "0x2B0B5F0", VA = "0x182B0C1F0")]
		public static (ExternalFnRegistry, ExternalFns) PXZJVWKJHHG()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C080", Offset = "0x2B0B480", VA = "0x182B0C080")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static MGQGRHRPFYH KDHAESJDYTP(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class AQQNNPZPTYD
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate YCULPWATBNY CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public AQQNNPZPTYD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B05020", Offset = "0x2B04420", VA = "0x182B05020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B053A0", Offset = "0x2B047A0", VA = "0x182B053A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly MGQGRHRPFYH DXLWJUFEMZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? SZRRPHBYALD;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		private AQQNNPZPTYD(MGQGRHRPFYH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF310", Offset = "0x2AFE710", VA = "0x182AFF310")]
		public static AQQNNPZPTYD GYMJYDCNRDR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF4B0", Offset = "0x2AFE8B0", VA = "0x182AFF4B0")]
		public AQQNNPZPTYD TIYHIXDAEZY(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF3C0", Offset = "0x2AFE7C0", VA = "0x182AFF3C0")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> ISHNKJMJOID()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class LWVUUNLEOCJ : SCQFSPRNDPD.TVWXLXTXIIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate YVXKSJHRTOX NewCircuitsLifecycleDelegate(PWJKHDEOEOW.TVWXLXTXIIP deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(SCQFSPRNDPD circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(SCQFSPRNDPD circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate WMUMUJDRXWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate ECTBJOOVGYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate SWSFMQCMXUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate KEEDWHRNCZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate ZXKOQHKWBLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate OYLPOCMZNZS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int DGAUNDCEHSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x12B7D60", Offset = "0x12B7160", VA = "0x1812B7D60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B03340", Offset = "0x2B02740", VA = "0x182B03340", Slot = "6")]
		public void NFQLUSXTKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B03370", Offset = "0x2B02770", VA = "0x182B03370", Slot = "7")]
		public void PXDUYRFEYBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B033A0", Offset = "0x2B027A0", VA = "0x182B033A0", Slot = "5")]
		public YVXKSJHRTOX SSCCOFUGOTW(PWJKHDEOEOW.TVWXLXTXIIP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF17030", Offset = "0xF16430", VA = "0x180F17030", Slot = "8")]
		public void EUSIJIPEQSN(SCQFSPRNDPD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF16FD0", Offset = "0xF163D0", VA = "0x180F16FD0", Slot = "9")]
		public void ZCTAUDWYFVQ(SCQFSPRNDPD a, PXBFMCKNGBK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B033D0", Offset = "0x2B027D0", VA = "0x182B033D0")]
		public LWVUUNLEOCJ([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly DDBBEEAJJTS<MGQGRHRPFYH, MGQGRHRPFYH.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly SQNVNHLDELG<MGQGRHRPFYH, MGQGRHRPFYH.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly SCQFSPRNDPD CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<BVHHKRGRDMC> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly MGQGRHRPFYH Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B00880", Offset = "0x2AFFC80", VA = "0x182B00880")]
		public EVCreationResult(DDBBEEAJJTS<MGQGRHRPFYH, MGQGRHRPFYH.MockStaticNetSysDeps> staticNetSys, SQNVNHLDELG<MGQGRHRPFYH, MGQGRHRPFYH.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, SCQFSPRNDPD circuitsManager, Id32<BVHHKRGRDMC> clientId, MGQGRHRPFYH network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly SCQFSPRNDPD _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 QUSDGOHSRZH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B03DC0", Offset = "0x2B031C0", VA = "0x182B03DC0")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request CKKCUEZVRXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B03D30", Offset = "0x2B03130", VA = "0x182B03D30")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public KDLKXLCXLMQ? YYJLDUDBMSP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2B03C30", Offset = "0x2B03030", VA = "0x182B03C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public UOXIAFFGFEM? GTAENSCVUIX
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2B03D60", Offset = "0x2B03160", VA = "0x182B03D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		internal LimitedCircuits(SCQFSPRNDPD circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class QZKGRZJBLON : ZVMBXFNFHDW
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class QBHNKVVMFQX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public YCULPWATBNY MJWVQSOUZCO;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public QBHNKVVMFQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			internal YCULPWATBNY KYLQXQOFOOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public PWJKHDEOEOW.TVWXLXTXIIP WXXFCGPXNMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public SCQFSPRNDPD.TVWXLXTXIIP JFDRWMKNJMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MRKIPKACQWY.TVWXLXTXIIP IOMTYGDYRLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD> ERJGCPEQSUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.TVWXLXTXIIP VDVGISORCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IKBVPHFPXCS FLFQZBOOYEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public WFYONVKPUQH UZRIBIRYRIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public VRZNIJEJJRF UMJDUIZGJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PBRLRHMSVSH FOLHVPVJCVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DF0", Offset = "0xCF41F0", VA = "0x180CF4DF0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EXVISPQHAEV TDIXQUWTTXC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF4020", VA = "0x180CF4C20", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C90", Offset = "0x2B04090", VA = "0x182B04C90")]
		private QZKGRZJBLON(PWJKHDEOEOW.TVWXLXTXIIP a, SCQFSPRNDPD.TVWXLXTXIIP b, MRKIPKACQWY.TVWXLXTXIIP c, VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD> d, CV2Request.TVWXLXTXIIP e, IKBVPHFPXCS f, WFYONVKPUQH g, VRZNIJEJJRF h, PBRLRHMSVSH i, EXVISPQHAEV j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B047F0", Offset = "0x2B03BF0", VA = "0x182B047F0")]
		public static QZKGRZJBLON? WLWHIKUFUWS(MRKIPKACQWY.TVWXLXTXIIP cv2RootSysDeps, [Optional] PWJKHDEOEOW.TVWXLXTXIIP? a, [Optional] SCQFSPRNDPD.TVWXLXTXIIP? b, [Optional] VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>? reducerDeps, [Optional] CV2Request.TVWXLXTXIIP? c, [Optional] IKBVPHFPXCS? d, [Optional] WFYONVKPUQH? e, [Optional] VRZNIJEJJRF? f, [Optional] PBRLRHMSVSH? g, [Optional] EXVISPQHAEV? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B04B40", Offset = "0x2B03F40", VA = "0x182B04B40")]
		public static QZKGRZJBLON XJJFAKHNNSC(YCULPWATBNY a, [Optional] PWJKHDEOEOW.TVWXLXTXIIP? circuitsLifecycleDeps, [Optional] SCQFSPRNDPD.TVWXLXTXIIP? circuitsManagerDeps, [Optional] VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B04470", Offset = "0x2B03870", VA = "0x182B04470")]
		public static QZKGRZJBLON JLHQTBMJZGU(GetNetworkObjectDelegate a, [Optional] PWJKHDEOEOW.TVWXLXTXIIP? circuitsLifecycleDeps, [Optional] SCQFSPRNDPD.TVWXLXTXIIP? circuitsManagerDeps, [Optional] VZLHKDLMKIS.MDFEQTCPLCK<ActionKind, PXBFMCKNGBK, SCQFSPRNDPD>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class VJUMJPPIGNK
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KDEBKHUDUUH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public GetNetworkObjectDelegate GJXIDSSRHFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int THERSJRZDSO;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public KDEBKHUDUUH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B032D0", Offset = "0x2B026D0", VA = "0x182B032D0")]
			internal YAPLSWVVQAZ GCWIPQETNTN(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2B03170", Offset = "0x2B02570", VA = "0x182B03170")]
			internal YAPLSWVVQAZ[] GAQKTTTWNYS(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50")]
			internal int RFCJDUAAPXM()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class KCYUNBAGLIY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public DynamicEnvironmentNetworkId FHVLIXKOILQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public KDEBKHUDUUH IYWFXXOWUJJ;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public KCYUNBAGLIY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B030C0", Offset = "0x2B024C0", VA = "0x182B030C0")]
			internal YAPLSWVVQAZ MBVATDAYZRN(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly ZGJZLOXSVLX BPEUZUVWWSO;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B950", Offset = "0x2B0AD50", VA = "0x182B0B950")]
		public static YAPLSWVVQAZ? HEGRXUYHBWO(Id32<QXDOXFETTHL>? networkObject, [Optional] AMONWFFEBEE.SerializesIntoSavesDelegate? a, [Optional] AMONWFFEBEE.SerializesIntoInventionsDelegate? b, [Optional] AMONWFFEBEE.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B07780", Offset = "0x2B06B80", VA = "0x182B07780")]
		public static YCULPWATBNY? EAWZUGTMYFZ(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] DLADXAUDIQZ? b, [Optional] FJKHTKMOEYF? c, [Optional] INDKNEJEOQB? d, [Optional] KIRCHECAFFG? e, int f = 300000, bool g = false, bool h = false, [Optional] OUDQSJFGPBT? i, [Optional] BOTGZRNPIPX? j, [Optional] SUAOKWARRZI? k, [Optional] IQCKFZTPFKV? l, [Optional] OJDDANHBPRY? m, [Optional] JRPBOKHDZQN? n, [Optional] CAKAFQMVBWD.TVWXLXTXIIP? o, [Optional] EqualsNodeV2.TVWXLXTXIIP? p, [Optional] MLSLADSATQB? q, [Optional] YCULPWATBNY.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] YCULPWATBNY.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] YCULPWATBNY.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] YCULPWATBNY.GetLocalRoomIdDelegate? u, [Optional] YCULPWATBNY.GetLocalSubroomIdDelegate? v, [Optional] YCULPWATBNY.GetSubroomIdsForLocalRoomDelegate? w, [Optional] YCULPWATBNY.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] YCULPWATBNY.SaveRoomOnPlayerBehalfDelegate? z, [Optional] YCULPWATBNY.ReportCloudDataLedgerChangedDelegate? ba, [Optional] YCULPWATBNY.GetColorNameByIdDelegate? bb, [Optional] YCULPWATBNY.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] YCULPWATBNY.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] YCULPWATBNY.GetTaggableNameFromSignalDelegate? be, [Optional] YCULPWATBNY.GetAudioNameFromSignalDelegate? bf, [Optional] YCULPWATBNY.GetDestinationNameFromSignalDelegate? bg, [Optional] YCULPWATBNY.GetPlayerEventNameFromSignalDelegate? bh, [Optional] YCULPWATBNY.GetRoomKeyNameFromSignalDelegate? bi, [Optional] YCULPWATBNY.GetRewardNameFromSignalDelegate? bj, [Optional] YCULPWATBNY.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] YCULPWATBNY.ReportPreloadedAudioChangedDelegate? bl, [Optional] YCULPWATBNY.ReportRewardDataChangedDelegate? bm, [Optional] YCULPWATBNY.GetConsumableNameFromSignalDelegate? bn, [Optional] YCULPWATBNY.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] YCULPWATBNY.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] YCULPWATBNY.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] YCULPWATBNY.GetInventoryItemNameFromSignalDelegate? br, [Optional] YCULPWATBNY.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] YCULPWATBNY.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] YCULPWATBNY.GetRoomOfferNameFromSignalDelegate? bu, [Optional] YCULPWATBNY.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] YCULPWATBNY.GetObjectIdFromCreationObjectDelegate? bw, [Optional] YCULPWATBNY.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] YCULPWATBNY.GetCostInBytesDelegate? by, [Optional] YCULPWATBNY.GetAvatarItemNameFromSignalDelegate? bz, [Optional] YCULPWATBNY.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] YCULPWATBNY.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] YCULPWATBNY.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] YCULPWATBNY.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] YCULPWATBNY.GetStoreItemNameFromSignalDelegate? ce, [Optional] YCULPWATBNY.GetBodyPartNameFromSignalDelegate? cf, [Optional] YCULPWATBNY.GetDependenciesForGraphInstanceDelegate? cg, [Optional] YCULPWATBNY.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] YCULPWATBNY.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] YCULPWATBNY.GetRecNetImageNameFromSignalDelegate? cj, [Optional] YCULPWATBNY.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] YCULPWATBNY.IsFunctionValidForAIDelegate? cm, [Optional] YCULPWATBNY.GetAIFunctionNameFromSignalDelegate? cn, [Optional] YCULPWATBNY.FromSerializableObjectDelegate? co, [Optional] YCULPWATBNY.ToSerializableObjectDelegate? cp)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<QXDOXFETTHL>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class CBZNBNEBTKX : SUAOKWARRZI
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly CBZNBNEBTKX LDHSFMFGGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly GetLocalPlayerDelegate? MMYNQREJWZI;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF500", Offset = "0x2AFE900", VA = "0x182AFF500", Slot = "4")]
		public (CHHVKWPEXLB, CHHVKWPEXLB, CHHVKWPEXLB, CHHVKWPEXLB, CHHVKWPEXLB) QOVHAOSADVH(object a)
		{
			return default((CHHVKWPEXLB, CHHVKWPEXLB, CHHVKWPEXLB, CHHVKWPEXLB, CHHVKWPEXLB));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF4D0", Offset = "0x2AFE8D0", VA = "0x182AFF4D0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "6")]
		public bool EBAROFIKFFG(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD59F10", Offset = "0xD59310", VA = "0x180D59F10", Slot = "7")]
		public string TRIXLILWIJE(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public CBZNBNEBTKX([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class AMONWFFEBEE : YAPLSWVVQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(AMONWFFEBEE self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(AMONWFFEBEE self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(AMONWFFEBEE self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly SerializesIntoSavesDelegate YBFIYIFUXBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly SerializesIntoInventionsDelegate NGZONOPOGJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly CanPublishInInventionsDelegate RVYLDHDIDGR;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private BBGMZWNXEBN? YOFMHJRHPNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId VWVLJLFZYZU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xFC8130", Offset = "0xFC7530", VA = "0x180FC8130", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GBANOULHWAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF2E0", Offset = "0x2AFE6E0", VA = "0x182AFF2E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool WQLLVVDBZGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF2B0", Offset = "0x2AFE6B0", VA = "0x182AFF2B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool AUVCMCUEUDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF280", Offset = "0x2AFE680", VA = "0x182AFF280", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ZQHFXXMIHCW? SBQKKERLIJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<QXDOXFETTHL>? NRJGTDPHUAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF130", Offset = "0x2AFE530", VA = "0x182AFF130", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEBE0", Offset = "0x2AFDFE0", VA = "0x182AFEBE0", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(ZGJZLOXSVLX e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10", Slot = "13")]
		public void Bind(BBGMZWNXEBN controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1D0", Offset = "0x2AFE5D0", VA = "0x182AFF1D0")]
		private AMONWFFEBEE(Id32<QXDOXFETTHL>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEC80", Offset = "0x2AFE080", VA = "0x182AFEC80")]
		public static AMONWFFEBEE? New(Id32<QXDOXFETTHL>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class ZQAXNGPRLOE : OUDQSJFGPBT
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
		public static readonly ZQAXNGPRLOE LDHSFMFGGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly RoundToDecimalPlaceDelegate? DLTOTUJLWPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly TruncateToDecimalPlaceDelegate? IWLPHXIDDWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsColorLerpDelegate? MQEEGMATMUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsColorInverseLerpDelegate? IHIQAZAHWKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4GetPositionDelegate? AKLDGHLWIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4GetRotationDelegate? KTZAJKDICLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsMtx4x4InverseDelegate? ZTDHCHBBUPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsMtx4x4MultiplyDelegate? SCQBBCWUQSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? AKCWTLPEVVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatDotDelegate? DJKHEYNIVTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromAngleAxisDelegate? UTSEHJHLJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? UXYMOSPPELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatFromFromToRotationDelegate? BKYKVRYGLKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatFromLookRotationDelegate? YKGGLFCJFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? KAYLDYFANRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseDelegate? DPDARSQFNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatLerpDelegate? BTWQBLVVKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatLerpUnclampedDelegate? XRZOXAUGAKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatInverseLerpDelegate? SYKVPKHQXCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatMultiplyDelegate? UHXFZVDEUHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatNormalizeDelegate? BXHWKCNUZVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatRotateTowardsDelegate? BOLCGSYHJOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatRotateVectorDelegate? IYMDQEINBUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatSlerpDelegate? PYHXZQMZLBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsQuatToAngleAxisDelegate? URXPUINAWVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsQuatToEulerAnglesDelegate? MVSHDYULAQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3AddDelegate? WZDXJLRDVKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? FIGOKGUGMMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? XKGMOETDGJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3CrossDelegate? NZXTDELORUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3DotDelegate? IUOQDJDITKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3AngleDelegate? UUWWGCLCAKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3GetMagnitudeDelegate? GJJLNQUSCRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3LerpDelegate? YQVOZKUOECR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3LerpUnclampedDelegate? LLBYFFVSHRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3InverseLerpDelegate? ETURPDVFAMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3MoveTowardsDelegate? RSRMZDZPBRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3NegateDelegate? BMDOYCYPPMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3NormalizeDelegate? GNJHIVTSANV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ProjectDelegate? GNUJAATWSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? EMMLYGJGQQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3ScaleDelegate? OVIVEJFLWFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SmoothDampDelegate? QXMTLCXXDYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3SubtractDelegate? JOZDFTXUAQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3SlerpDelegate? LMDLIHZYTCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly CircuitsVec3TransformDelegate? QWIEVFHKKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CircuitsVec3InverseTransformDelegate? SJPQVTLJMWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly RealtimeSinceStartupDelegate? BTAVXNSQTQF;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E500", Offset = "0x2B0D900", VA = "0x182B0E500")]
		public ZQAXNGPRLOE([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C510", Offset = "0x2B0B910", VA = "0x182B0C510")]
		public float FIGXSYBXMYN([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C430", Offset = "0x2B0B830", VA = "0x182B0C430")]
		public float DJKFILQFZPV([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E0C0", Offset = "0x2B0D4C0", VA = "0x182B0E0C0")]
		public CircuitsColor XXAGLKJJWWI([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D3C0", Offset = "0x2B0C7C0", VA = "0x182B0D3C0")]
		public float ZHNFJJBTHHE([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D0B0", Offset = "0x2B0C4B0", VA = "0x182B0D0B0")]
		public CircuitsVec3 FXJJHPIBYOS([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DA70", Offset = "0x2B0CE70", VA = "0x182B0DA70")]
		public CircuitsQuat QMGWUPNPZTJ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D040", Offset = "0x2B0C440", VA = "0x182B0D040")]
		public CircuitsMtx4x4 FVFBJMCVVTH([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DE40", Offset = "0x2B0D240", VA = "0x182B0DE40")]
		public CircuitsMtx4x4 UEZTRPWSZZJ([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DEB0", Offset = "0x2B0D2B0", VA = "0x182B0DEB0")]
		public CircuitsMtx4x4 UYLOEUMAZWP([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D2F0", Offset = "0x2B0C6F0", VA = "0x182B0D2F0")]
		public float HAYQSIMLXWI([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C820", Offset = "0x2B0BC20", VA = "0x182B0C820")]
		public CircuitsQuat VHAJUZUZIMR(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CEC0", Offset = "0x2B0C2C0", VA = "0x182B0CEC0")]
		public CircuitsQuat FGHXFECNPOO([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D3F0", Offset = "0x2B0C7F0", VA = "0x182B0D3F0")]
		public CircuitsQuat IVYMPMDEVRM([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D110", Offset = "0x2B0C510", VA = "0x182B0D110")]
		public CircuitsQuat GKSFMUBHVSU([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DAC0", Offset = "0x2B0CEC0", VA = "0x182B0DAC0")]
		public CircuitsQuat QZHOKUPGBDZ([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C8F0", Offset = "0x2B0BCF0", VA = "0x182B0C8F0")]
		public CircuitsQuat DBQRRXSRUMA([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C610", Offset = "0x2B0BA10", VA = "0x182B0C610")]
		public CircuitsQuat QTXOCCRIVNN([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CC00", Offset = "0x2B0C000", VA = "0x182B0CC00")]
		public float OFUYXUYZFJM([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D310", Offset = "0x2B0C710", VA = "0x182B0D310")]
		public CircuitsQuat TBLEGKKMLSN([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CA90", Offset = "0x2B0BE90", VA = "0x182B0CA90")]
		public CircuitsQuat DMPVMNKCVTC([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C450", Offset = "0x2B0B850", VA = "0x182B0C450")]
		public CircuitsQuat PUEOBJSKWCG([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E200", Offset = "0x2B0D600", VA = "0x182B0E200")]
		public CircuitsVec3 ZLQDTKMLIHL([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CD00", Offset = "0x2B0C100", VA = "0x182B0CD00")]
		public CircuitsQuat EKSMYMURIMP([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D760", Offset = "0x2B0CB60", VA = "0x182B0D760")]
		public void MKVCWYLSCVY([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D7A0", Offset = "0x2B0CBA0", VA = "0x182B0D7A0")]
		public CircuitsVec3 NJLCSUKUNJD([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C9B0", Offset = "0x2B0BDB0", VA = "0x182B0C9B0")]
		public CircuitsVec3 DEHOWBJNHXC([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E270", Offset = "0x2B0D670", VA = "0x182B0E270")]
		public CircuitsVec3 ZLZPCXOWFMW([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C3C0", Offset = "0x2B0B7C0", VA = "0x182B0C3C0")]
		public CircuitsVec3 AAAPGNAMMHF([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C5A0", Offset = "0x2B0B9A0", VA = "0x182B0C5A0")]
		public CircuitsVec3 AZNXFQJOGNZ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C8D0", Offset = "0x2B0BCD0", VA = "0x182B0C8D0")]
		public float CZLWEVFPUPK([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CDC0", Offset = "0x2B0C1C0", VA = "0x182B0CDC0")]
		public float ESTQNDHSTDW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D930", Offset = "0x2B0CD30", VA = "0x182B0D930")]
		public float WAQVCLNVMIT([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D510", Offset = "0x2B0C910", VA = "0x182B0D510")]
		public CircuitsVec3 JKMWTHYQZOQ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DC40", Offset = "0x2B0D040", VA = "0x182B0DC40")]
		public CircuitsVec3 RWSLSQORWRZ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C7F0", Offset = "0x2B0BBF0", VA = "0x182B0C7F0")]
		public float BTVHLRSUALE([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CDE0", Offset = "0x2B0C1E0", VA = "0x182B0CDE0")]
		public CircuitsVec3 EWQHYWCGPAE([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E2E0", Offset = "0x2B0D6E0", VA = "0x182B0E2E0")]
		public CircuitsVec3 ZVHXPFRUJRF([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D5F0", Offset = "0x2B0C9F0", VA = "0x182B0D5F0")]
		public CircuitsVec3 JUSTJFNNDGE([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DD20", Offset = "0x2B0D120", VA = "0x182B0DD20")]
		public CircuitsVec3 TBMHZISNUWC([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DA00", Offset = "0x2B0CE00", VA = "0x182B0DA00")]
		public CircuitsVec3 ORYBZDJCANF([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CFD0", Offset = "0x2B0C3D0", VA = "0x182B0CFD0")]
		public CircuitsVec3 FPJTIIPXKFH([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D950", Offset = "0x2B0CD50", VA = "0x182B0D950")]
		public CircuitsVec3 OPBEZUMCKVT([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CA20", Offset = "0x2B0BE20", VA = "0x182B0CA20")]
		public CircuitsVec3 DKCUFDOASXL([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CF60", Offset = "0x2B0C360", VA = "0x182B0CF60")]
		public CircuitsVec3 FKZHPUONIYH([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D800", Offset = "0x2B0CC00", VA = "0x182B0D800")]
		public CircuitsVec3 NWSRXPLSVOD([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CB30", Offset = "0x2B0BF30", VA = "0x182B0CB30")]
		public CircuitsVec3 DQCBOMDZBIB([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D730", Offset = "0x2B0CB30", VA = "0x182B0D730", Slot = "50")]
		public Task MJZMDJLVJUH(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "51")]
		public void BUCCHQKDBJJ([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C7A0", Offset = "0x2B0BBA0", VA = "0x182B0C7A0", Slot = "52")]
		public VPRVIMXHXTY<TQNVKMZRYRU> BNHOUJEYKPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DD90", Offset = "0x2B0D190", VA = "0x182B0DD90", Slot = "53")]
		public VPRVIMXHXTY<TQNVKMZRYRU> TGCJDPPJZJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E120", Offset = "0x2B0D520", VA = "0x182B0E120", Slot = "54")]
		public float YLNYDJYGFSQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C510", Offset = "0x2B0B910", VA = "0x182B0C510", Slot = "4")]
		private float AKDDLIBOOKP([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C430", Offset = "0x2B0B830", VA = "0x182B0C430", Slot = "5")]
		private float AEJIPITZWXD([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DDE0", Offset = "0x2B0D1E0", VA = "0x182B0DDE0", Slot = "6")]
		private CircuitsColor TXQIMPGGLPE([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D3C0", Offset = "0x2B0C7C0", VA = "0x182B0D3C0", Slot = "7")]
		private float IUTWZLMJTNW([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CBA0", Offset = "0x2B0BFA0", VA = "0x182B0CBA0", Slot = "8")]
		private CircuitsVec3 DUHTSTWBSXK([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D870", Offset = "0x2B0CC70", VA = "0x182B0D870", Slot = "9")]
		private CircuitsQuat NWVKKCZPIYF([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E060", Offset = "0x2B0D460", VA = "0x182B0E060", Slot = "10")]
		private CircuitsMtx4x4 XCNRTJWJZCH([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E000", Offset = "0x2B0D400", VA = "0x182B0E000", Slot = "11")]
		private CircuitsMtx4x4 WVNSZDYVBVL([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E140", Offset = "0x2B0D540", VA = "0x182B0E140", Slot = "12")]
		private CircuitsMtx4x4 YUVKCNHZWTH([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D2F0", Offset = "0x2B0C6F0", VA = "0x182B0D2F0", Slot = "13")]
		private float NIJOIIJWDGC([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C820", Offset = "0x2B0BC20", VA = "0x182B0C820", Slot = "14")]
		private CircuitsQuat CUBSQOWFDID(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CEC0", Offset = "0x2B0C2C0", VA = "0x182B0CEC0", Slot = "15")]
		private CircuitsQuat ZBZVERPTWLK([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D3F0", Offset = "0x2B0C7F0", VA = "0x182B0D3F0", Slot = "16")]
		private CircuitsQuat LDPOYBKWUMQ([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D110", Offset = "0x2B0C510", VA = "0x182B0D110", Slot = "17")]
		private CircuitsQuat OBZTQAGLXQC([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DAC0", Offset = "0x2B0CEC0", VA = "0x182B0DAC0", Slot = "18")]
		private CircuitsQuat UBUJFHDPDHP([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C8F0", Offset = "0x2B0BCF0", VA = "0x182B0C8F0", Slot = "19")]
		private CircuitsQuat EKDOONDYQFU([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C610", Offset = "0x2B0BA10", VA = "0x182B0C610", Slot = "20")]
		private CircuitsQuat BBHYHWQUISZ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CC00", Offset = "0x2B0C000", VA = "0x182B0CC00", Slot = "21")]
		private float DYMEYTNTUCQ([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D310", Offset = "0x2B0C710", VA = "0x182B0D310", Slot = "22")]
		private CircuitsQuat IPMNDEEBXFJ([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CA90", Offset = "0x2B0BE90", VA = "0x182B0CA90", Slot = "23")]
		private CircuitsQuat JJYLUJPQYAK([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C450", Offset = "0x2B0B850", VA = "0x182B0C450", Slot = "24")]
		private CircuitsQuat AJPDTZKLPDO([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D280", Offset = "0x2B0C680", VA = "0x182B0D280", Slot = "25")]
		private CircuitsVec3 GUJWCKOYSZZ([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CD00", Offset = "0x2B0C100", VA = "0x182B0CD00", Slot = "26")]
		private CircuitsQuat IVWQJKPRCCJ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D760", Offset = "0x2B0CB60", VA = "0x182B0D760", Slot = "27")]
		private void ZNRNNYAWRGY([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C6D0", Offset = "0x2B0BAD0", VA = "0x182B0C6D0", Slot = "28")]
		private CircuitsVec3 BITJCOTCIQL([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C530", Offset = "0x2B0B930", VA = "0x182B0C530", Slot = "29")]
		private CircuitsVec3 AZDPPNZRFUK([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D4A0", Offset = "0x2B0C8A0", VA = "0x182B0D4A0", Slot = "30")]
		private CircuitsVec3 JKLKSVHJEUE([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CE50", Offset = "0x2B0C250", VA = "0x182B0CE50", Slot = "31")]
		private CircuitsVec3 FDGSVJOYWXT([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DF20", Offset = "0x2B0D320", VA = "0x182B0DF20", Slot = "32")]
		private CircuitsVec3 VEPQWPCSXFL([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DBD0", Offset = "0x2B0CFD0", VA = "0x182B0DBD0", Slot = "33")]
		private CircuitsVec3 RVQNEKJNXBP([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D650", Offset = "0x2B0CA50", VA = "0x182B0D650", Slot = "34")]
		private CircuitsVec3 LHLZUXTYRTR([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C8D0", Offset = "0x2B0BCD0", VA = "0x182B0C8D0", Slot = "35")]
		private float NFYMNBQQPLM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CDC0", Offset = "0x2B0C1C0", VA = "0x182B0CDC0", Slot = "36")]
		private float JTZVYWVPNCK([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D930", Offset = "0x2B0CD30", VA = "0x182B0D930", Slot = "37")]
		private float ONPHYLZMBNP([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CC30", Offset = "0x2B0C030", VA = "0x182B0CC30", Slot = "38")]
		private CircuitsVec3 DZCRXIQPWNQ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D8C0", Offset = "0x2B0CCC0", VA = "0x182B0D8C0", Slot = "39")]
		private CircuitsVec3 OIMVZNFMHZL([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C7F0", Offset = "0x2B0BBF0", VA = "0x182B0C7F0", Slot = "40")]
		private float RQGLWFHQCKU([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D6C0", Offset = "0x2B0CAC0", VA = "0x182B0D6C0", Slot = "41")]
		private CircuitsVec3 LRMXOQKAATU([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E1A0", Offset = "0x2B0D5A0", VA = "0x182B0E1A0", Slot = "42")]
		private CircuitsVec3 ZBYHKFOUFMV([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CCA0", Offset = "0x2B0C0A0", VA = "0x182B0CCA0", Slot = "43")]
		private CircuitsVec3 ECLKRGFIUHQ([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D580", Offset = "0x2B0C980", VA = "0x182B0D580", Slot = "44")]
		private CircuitsVec3 JUCQRMAXGGM([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DF90", Offset = "0x2B0D390", VA = "0x182B0DF90", Slot = "45")]
		private CircuitsVec3 WKHUHXQQQTD([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DCB0", Offset = "0x2B0D0B0", VA = "0x182B0DCB0", Slot = "46")]
		private CircuitsVec3 SBZNRFYCCKH([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D1C0", Offset = "0x2B0C5C0", VA = "0x182B0D1C0", Slot = "47")]
		private CircuitsVec3 GORIWKCDPML([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C730", Offset = "0x2B0BB30", VA = "0x182B0C730", Slot = "48")]
		private CircuitsVec3 BMRRVYJOSIH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DB60", Offset = "0x2B0CF60", VA = "0x182B0DB60", Slot = "49")]
		private CircuitsVec3 RAWLJZLUYDT([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class JHHGHXXIEEE : SEAAKQRIMWR
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x135B8F0", Offset = "0x135ACF0", VA = "0x18135B8F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x11198C0", Offset = "0x1118CC0", VA = "0x1811198C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2B03070", Offset = "0x2B02470", VA = "0x182B03070")]
		public JHHGHXXIEEE(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class TWSOCLELGNC : BOTGZRNPIPX
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(GOCFXIZVABA e, FALDHCTZJRX invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly TWSOCLELGNC LDHSFMFGGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly GetCircuitsColorFromColorIndexDelegate? WZNNISHKCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? TFDOCTYNIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly InvisibleCollisionSetEnabledDelegate? ROZYBDNNCYA;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xDE3B70", Offset = "0xDE2F70", VA = "0x180DE3B70")]
		public TWSOCLELGNC([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2B04E50", Offset = "0x2B04250", VA = "0x182B04E50", Slot = "4")]
		public CircuitsColor MITQJWXGEVK(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B04E30", Offset = "0x2B04230", VA = "0x182B04E30")]
		public int PGJTMWMRITW([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2B04E30", Offset = "0x2B04230", VA = "0x182B04E30", Slot = "5")]
		private int EJVOQOIMGVT([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class OSSSKASIZZV : FCKQCEANQRS
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class VJVGCRWEOVG
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid ZJUCLDBBOFS
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xF151B0", Offset = "0xF145B0", VA = "0x180F151B0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long XRGMWUIYAAB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int RCZQBLCXCMP
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xCFB3C0", Offset = "0xCFA7C0", VA = "0x180CFB3C0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool GXYIJFVZROG
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x1AFE6C0", Offset = "0x1AFDAC0", VA = "0x181AFE6C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool LAAGSLBRBQK
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x1AFEB30", Offset = "0x1AFDF30", VA = "0x181AFEB30")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool FFULNYIMGCT
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B9F0", Offset = "0x2B0ADF0", VA = "0x182B0B9F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0BA10", Offset = "0x2B0AE10", VA = "0x182B0BA10")]
			public VJVGCRWEOVG(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<Id128<IHXSJTKSKEJ>, VJVGCRWEOVG> YOZRSXSFFPD;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2B03F90", Offset = "0x2B03390", VA = "0x182B03F90")]
		public bool DGUKXHUCXZK([In] Id128<IHXSJTKSKEJ> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B04130", Offset = "0x2B03530", VA = "0x182B04130")]
		public void UYDTVDSKUAM([In] Id128<IHXSJTKSKEJ> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2B04260", Offset = "0x2B03660", VA = "0x182B04260")]
		public void UYDTVDSKUAM([In] Id128<IHXSJTKSKEJ> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B03E70", Offset = "0x2B03270", VA = "0x182B03E70")]
		public void QSFDARDZEDX([In] Id128<IHXSJTKSKEJ> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2B04200", Offset = "0x2B03600", VA = "0x182B04200")]
		public void QJFYECRJSGK([In] Id128<IHXSJTKSKEJ> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2B040A0", Offset = "0x2B034A0", VA = "0x182B040A0")]
		public bool GXYIJFVZROG([In] Id128<IHXSJTKSKEJ> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2B04340", Offset = "0x2B03740", VA = "0x182B04340")]
		public OSSSKASIZZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2B03F90", Offset = "0x2B03390", VA = "0x182B03F90", Slot = "4")]
		private bool UGTXDBLNPNT([In] Id128<IHXSJTKSKEJ> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2B04130", Offset = "0x2B03530", VA = "0x182B04130", Slot = "5")]
		private void GOXRSMEVNWN([In] Id128<IHXSJTKSKEJ> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2B03E70", Offset = "0x2B03270", VA = "0x182B03E70", Slot = "6")]
		private void BEOCIGJAECQ([In] Id128<IHXSJTKSKEJ> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2B04200", Offset = "0x2B03600", VA = "0x182B04200", Slot = "7")]
		private void RDSXAQSTYBB([In] Id128<IHXSJTKSKEJ> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2B040A0", Offset = "0x2B034A0", VA = "0x182B040A0", Slot = "8")]
		private bool GFGYOFTVOMJ([In] Id128<IHXSJTKSKEJ> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class CDHHRIPTSCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF5F0", Offset = "0x2AFE9F0", VA = "0x182AFF5F0")]
		public static LogDeps ETZAYWRGHCL()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class LABSXKFZQYV : MeshLibrary.TVWXLXTXIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
		public byte[]? LCTHULIIKTY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
		public void QILUWWDBZAB(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public LABSXKFZQYV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class FSGHYSRMSCS : DLADXAUDIQZ
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
		public delegate void ConfigureAttachedObjectDelegate(ADKNULQXEWP controlPanel, FEGMTBIBNYX staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<QJYZSAZIQYY> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, SKKNIPYCQUO>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, SKKNIPYCQUO>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, SKKNIPYCQUO>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, SKKNIPYCQUO>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public Task<Result<MultiResult, SKKNIPYCQUO>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private TaskAwaiter<Result<MultiResult, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2B066A0", Offset = "0x2B05AA0", VA = "0x182B066A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2B06960", Offset = "0x2B05D60", VA = "0x182B06960", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2B069D0", Offset = "0x2B05DD0", VA = "0x182B069D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2B06C90", Offset = "0x2B06090", VA = "0x182B06C90", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Task<Result<None, SKKNIPYCQUO>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private TaskAwaiter<Result<None, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2B06D00", Offset = "0x2B06100", VA = "0x182B06D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2B06FC0", Offset = "0x2B063C0", VA = "0x182B06FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Dictionary<string, EnumChoiceData> ATRQHXETOVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Dictionary<int, string> MTUJPDJUMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly List<object> VMKYCUCLGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly List<Guid> YXTEIFWWRRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly CanLocalPlayerCreateCurrencyDelegate LLTHNYVEYBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ShowRoomCurrencyCreationUIDelegate AQQIIBCNGMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipOptionsDelegate PAOFOMHEHHB;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<Guid, int> RWUACOLWZTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipGuidToIndexMapDelegate EQORCDMZWXD;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<int, Guid> NSSZJLTCQXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAudioClipIndexToGuidMapDelegate QYGDARMCPBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipOptionsDelegate AASYKLOYUCS;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<Guid, int> KUYEIMFYPBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate JIWEBSQGZIS;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly IReadOnlyDictionary<int, Guid> QGMVKQNFZZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate SXYCTTFVIQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly PlayAudioPreviewDelegate LHOYHSIIAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly StopAudioPreviewDelegate SGIJPLVQBDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly SubscriptionIsActiveDelegate DYWJJXDKKXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate UTLVASNEJTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Dictionary<string, EnumChoiceData> ZCFUDPCSWGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly ShowQuickChatEditMenuDelegate GNTCUFJOGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly ConfigureAttachedObjectDelegate IZEYPSEJEYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly DisplayInvalidNameErrorMessageDelegate IDQSMZPFBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly IsStringPureDelegate ZQOXAFGKNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly TryGetSpecificChipConfigSummaryDelegate HVATCSIIOVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReleaseIconIdDelegate WMBOFYEACMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate CCOKTYWUNVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 QKLYFBQOFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 QKRFCIKLONP;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment IQYFFVHOEBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool RNRVDBFWFBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xD4A700", Offset = "0xD49B00", VA = "0x180D4A700", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> HPEJWFFYMNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> IINAZEZYNAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> CUDMPQVJQNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> FXUPQHIFYDL
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xCF7A30", Offset = "0xCF6E30", VA = "0x180CF7A30", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion AHAUEJMXXFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x100C900", Offset = "0x100BD00", VA = "0x18100C900", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool DVVWYSJXHND
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xEDE680", Offset = "0xEDDA80", VA = "0x180EDE680", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool WMJXHKJNKZU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B00FF0", Offset = "0x2B003F0", VA = "0x182B00FF0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool SBDTIPKAZNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B00DE0", Offset = "0x2B001E0", VA = "0x182B00DE0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool XKNXXNXRORJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xCFE180", Offset = "0xCFD580", VA = "0x180CFE180", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B013C0", Offset = "0x2B007C0", VA = "0x182B013C0")]
		public FSGHYSRMSCS([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B00B00", Offset = "0x2AFFF00", VA = "0x182B00B00", Slot = "9")]
		public bool BCKWMGKPNYH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0")]
		public static bool XPWTMYXVLWS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B01030", Offset = "0x2B00430", VA = "0x182B01030", Slot = "10")]
		public bool RFJSKXTZNUN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		public static void SXGOZHKSGMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xF177C0", Offset = "0xF16BC0", VA = "0x180F177C0", Slot = "11")]
		public void ACYKPRTFYVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F90", Offset = "0x2B00390", VA = "0x182B00F90")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> OKGULZVRMHL(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B01060", Offset = "0x2B00460", VA = "0x182B01060", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> RPELZLRFDEI(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B01190", Offset = "0x2B00590", VA = "0x182B01190")]
		private static IReadOnlyDictionary<Guid, int> XKACRUORWLL(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B00BC0", Offset = "0x2AFFFC0", VA = "0x182B00BC0", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> BGKFOJSXIBC(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B00EE0", Offset = "0x2B002E0", VA = "0x182B00EE0")]
		private static IReadOnlyDictionary<int, Guid> MVGHMIXKMMV(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B00C90", Offset = "0x2B00090", VA = "0x182B00C90", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> DTHFBTFEWFW(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F60", Offset = "0x2B00360", VA = "0x182B00F60")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> NIYODFBXZWI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7C40", Offset = "0x2AF7040", VA = "0x182AF7C40", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> LVWGVPSCDWP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B01090", Offset = "0x2B00490", VA = "0x182B01090")]
		private static IReadOnlyDictionary<Guid, int> SNTLIZEVKDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B00AD0", Offset = "0x2AFFED0", VA = "0x182B00AD0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> ATLDTOSSYXH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B01220", Offset = "0x2B00620", VA = "0x182B01220", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> XVBAEALEWZP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		private static void IRCRGUNBERR(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B01150", Offset = "0x2B00550", VA = "0x182B01150", Slot = "18")]
		public void WCLISEPXRMK(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		private static void JXTGIJFJXHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B01120", Offset = "0x2B00520", VA = "0x182B01120", Slot = "19")]
		public void TDIWNQYZESA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0")]
		private static bool TUBOPXXQKUC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B01000", Offset = "0x2B00400", VA = "0x182B01000", Slot = "20")]
		public bool QNFRAGZITJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0")]
		public static bool KTWOWVKHBNT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F30", Offset = "0x2B00330", VA = "0x182B00F30", Slot = "21")]
		public bool NBFLTEUVOCY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B00EB0", Offset = "0x2B002B0", VA = "0x182B00EB0", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> LOFLHYLSFLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> NOVONAKONDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> KYVUCSPBGET()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B00DF0", Offset = "0x2B001F0", VA = "0x182B00DF0", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GWZMVSKYHAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> ERTDJJXJBRY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> CQSQVKBBDLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		public static void TVZWVZLDUMM(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B010E0", Offset = "0x2B004E0", VA = "0x182B010E0", Slot = "29")]
		public void TACHFNBKBYX(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		private static void LRSBEQZAVNQ(ADKNULQXEWP a, FEGMTBIBNYX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B00E20", Offset = "0x2B00220", VA = "0x182B00E20", Slot = "35")]
		public void HIBTKIJDQSR(ADKNULQXEWP a, FEGMTBIBNYX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "36")]
		public Dictionary<string, EnumChoiceData> OEOAOJTRJGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "37")]
		public Dictionary<string, EnumChoiceData> TNBYHYMAEMU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		private static void YSVTYVKNOUC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B00E50", Offset = "0x2B00250", VA = "0x182B00E50")]
		private static Task<bool> IORXSLTALBI(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B00DB0", Offset = "0x2B001B0", VA = "0x182B00DB0", Slot = "38")]
		public Task<bool> GMLWPGUKOTP(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B00BF0", Offset = "0x2AFFFF0", VA = "0x182B00BF0")]
		private static bool CSGRLWRIQQE(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B011E0", Offset = "0x2B005E0", VA = "0x182B011E0", Slot = "39")]
		public bool XNAPSZXXXTR(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		private static void MFOTMWKIWMU(Id32<QJYZSAZIQYY> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B00FC0", Offset = "0x2B003C0", VA = "0x182B00FC0", Slot = "40")]
		public void OTSRGRMSCIL(Id32<QJYZSAZIQYY> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B00CC0", Offset = "0x2B000C0", VA = "0x182B00CC0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, SKKNIPYCQUO>> EDEVBAOSSCK(Task<Result<None, SKKNIPYCQUO>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B00C30", Offset = "0x2B00030", VA = "0x182B00C30", Slot = "41")]
		public Task<Result<None, SKKNIPYCQUO>> DSYAJDMECPP(Task<Result<None, SKKNIPYCQUO>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B008F0", Offset = "0x2AFFCF0", VA = "0x182B008F0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, SKKNIPYCQUO>> AQAMKBCGFEA(Task<Result<MultiResult, SKKNIPYCQUO>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B00C00", Offset = "0x2B00000", VA = "0x182B00C00", Slot = "42")]
		public Task<Result<MultiResult, SKKNIPYCQUO>> DSYAJDMECPP(Task<Result<MultiResult, SKKNIPYCQUO>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B009E0", Offset = "0x2AFFDE0", VA = "0x182B009E0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> AQFTHHWDOPJ(Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B00C60", Offset = "0x2B00060", VA = "0x182B00C60", Slot = "43")]
		public Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> DSYAJDMECPP(Task<Result<Id32<IWTLBCZPUHH>, SKKNIPYCQUO>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class INDKNEJEOQB : DEFWHCCFMTK
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(ZGJZLOXSVLX e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? UHCRQIMZAGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly InteropDelegate RYDMOWEYIVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly InteropDelegate YPJSAUKKIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private InteropDelegate? ELJNNSLFJZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private InvokeStudioFunctionDelegate? LEFDVCDKFPR;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "5")]
		public LegacyCV2Result<None> JAOHXMWENUT(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
		private static LegacyCV2Result<None> Default(ZGJZLOXSVLX _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "6")]
		public LegacyCV2Result<None> QTQILGLZLMK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "7")]
		public LegacyCV2Result<None> WLJPJINPLJJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "8")]
		public LegacyCV2Result<None> WCQJHSBMQVI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "9")]
		public LegacyCV2Result<None> XFBBPZUUVJY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "15")]
		public LegacyCV2Result<None> DNRIEIDTFNJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OIOBRHYZKWF(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IYILAZGVWXB(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NCSCDPOBVJG(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UTCGBWINHHP(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> APRHIYKMNIS(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AUHQGHKTSJK(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UWAJFYWERWX(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "93")]
		public LegacyCV2Result<None> ANWNTTAQOBE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "94")]
		public LegacyCV2Result<None> FVJGCTVKHFW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "95")]
		public LegacyCV2Result<None> QSAMFADBPQF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IABOGFESGIR(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(ZGJZLOXSVLX e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VVCJLIDPMKX(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CZVFSPTFMKT(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZKSCLNOSURC(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IIGRVNSQANL(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OYMVWJPHMGE(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DURPVYORFVU(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EBFHQNQCVFU(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WJHTIYNCPRZ(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x153DD30", Offset = "0x153D130", VA = "0x18153DD30", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EFHNRDYWDTI(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ITCRVEWBOOV(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "119")]
		public LegacyCV2Result<None> CDKWRQHWOVP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TNFKABKOHDE(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "121")]
		public LegacyCV2Result<None> VWKBJWJEGBU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "122")]
		public LegacyCV2Result<None> HLLWUBGTWVI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "123")]
		public LegacyCV2Result<None> PBFEVMAKEKO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "124")]
		public LegacyCV2Result<None> HGJKVQRMWEW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "125")]
		public LegacyCV2Result<None> YJNESWIYWUM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "126")]
		public LegacyCV2Result<None> HDMTJJACUAF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "818")]
		public LegacyCV2Result<None> IHWKHRXITML(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "819")]
		public LegacyCV2Result<None> FKDFHIVNPAD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "147")]
		public LegacyCV2Result<None> URVINSXZQFX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "148")]
		public LegacyCV2Result<None> HPRVIRRUKCB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "149")]
		public LegacyCV2Result<None> YHTMVCQRFCY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "150")]
		public LegacyCV2Result<None> BESUIHIJARC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "151")]
		public LegacyCV2Result<None> FTSCRLFFGPL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(ZGJZLOXSVLX e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(ZGJZLOXSVLX e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(ZGJZLOXSVLX e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, DEFWHCCFMTK.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(ZGJZLOXSVLX e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, DEFWHCCFMTK.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "174")]
		public LegacyCV2Result<None> XMBQHXOUVVG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "175")]
		public LegacyCV2Result<None> YSTVVJKHMKN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "176")]
		public LegacyCV2Result<None> HMVJMTXHIRL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "197")]
		public LegacyCV2Result<None> CEFMMCXRNDR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "198")]
		public LegacyCV2Result<None> XPIMORETELY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "199")]
		public LegacyCV2Result<None> MPFPASOXEWV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "200")]
		public LegacyCV2Result<None> QUODVZVGDMF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "201")]
		public LegacyCV2Result<None> VUVLMYGEPGX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "202")]
		public LegacyCV2Result<None> PIYHECMNDEK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "203")]
		public LegacyCV2Result<None> HQSEXURMEFK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "204")]
		public LegacyCV2Result<None> GALVYLDYVQQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "205")]
		public LegacyCV2Result<None> GHPZKGPXXHW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "206")]
		public LegacyCV2Result<None> RKXEVICEHOM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "207")]
		public LegacyCV2Result<None> EKAKHZEHNWI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "208")]
		public LegacyCV2Result<None> UXKBFWNXIZW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "209")]
		public LegacyCV2Result<None> SMIBOVVGULS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "210")]
		public LegacyCV2Result<None> KEBZCWDTTWT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "211")]
		public LegacyCV2Result<None> YJARMKECQVY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "212")]
		public LegacyCV2Result<None> HIHBBFJMHQP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "213")]
		public LegacyCV2Result<None> AEGCPUBLMPC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "214")]
		public LegacyCV2Result<None> PYGVBQHIWIZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "215")]
		public LegacyCV2Result<None> CAKJJLVOAXG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "274")]
		public LegacyCV2Result<None> JEXQMSDAWMI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "277")]
		public LegacyCV2Result<None> BUQLFVZYDBM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "279")]
		public LegacyCV2Result<None> MPXWJVDKXTZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "280")]
		public LegacyCV2Result<None> EKXZJGPNCMJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "281")]
		public LegacyCV2Result<None> VMZKSQSACXA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "282")]
		public LegacyCV2Result<None> SNBTKAAGYVN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "283")]
		public LegacyCV2Result<None> HANIDTINWQC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "287")]
		public LegacyCV2Result<None> NHUEFCZKFID(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "288")]
		public LegacyCV2Result<None> VYZDFMGEHGS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "317")]
		public LegacyCV2Result<None> FXGYPDICSKD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "406")]
		public LegacyCV2Result<None> NWHNYFSACOG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JJHBQRZZFRT(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MZMAZJKKITP(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KDRXUGWBFZN(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WNISYQOLPOU(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QPUXQXYKMCH(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "416")]
		public LegacyCV2Result<GOZEXXHYTZZ.CV2DiscoverySectionType> APKUNWXLKXS(ZGJZLOXSVLX e, CircuitSignal a)
		{
			return default(LegacyCV2Result<GOZEXXHYTZZ.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "417")]
		public LegacyCV2Result<None> PXIUABUJCBC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(ZGJZLOXSVLX e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WUXZSVFMOCA(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> USZYUKZXWJV(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BASFZIESCNW(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "462")]
		public LegacyCV2Result<None> KDRCSPPWYAX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "463")]
		public LegacyCV2Result<None> IMZIQKQUYRA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "464")]
		public LegacyCV2Result<None> YQQHTYHCAJD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "465")]
		public LegacyCV2Result<None> UCMCJUDZZKU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "466")]
		public LegacyCV2Result<None> XELJOQKMEBY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "467")]
		public LegacyCV2Result<None> VIOIRUIGXZQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "468")]
		public LegacyCV2Result<None> AIBRLZDJHQJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "469")]
		public LegacyCV2Result<None> WVIGSWRPKOD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "474")]
		public LegacyCV2Result<None> NSICRSSYCPN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "475")]
		public LegacyCV2Result<None> FQWRQBLHSAB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "476")]
		public LegacyCV2Result<None> HSXSTBTEGIS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "477")]
		public LegacyCV2Result<None> GUNJRKPCIHZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "478")]
		public LegacyCV2Result<None> KMQOUVETQMV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "479")]
		public LegacyCV2Result<None> YTSRLBMPZJA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(ZGJZLOXSVLX executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(ZGJZLOXSVLX executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "472")]
		public LegacyCV2Result<None> YQUFNEBPBIG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "473")]
		public LegacyCV2Result<None> RKIRMHMZQVM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "480")]
		public LegacyCV2Result<None> KSKIRCSSKBS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "481")]
		public LegacyCV2Result<None> GGMKJVFPCBU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "482")]
		public LegacyCV2Result<None> CPEBKWRWXVZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "483")]
		public LegacyCV2Result<None> ENUUSJOOXQB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "484")]
		public LegacyCV2Result<None> OYWNOFALAWF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "485")]
		public LegacyCV2Result<None> AUWPMAHPBCH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "486")]
		public LegacyCV2Result<None> XOWRVXPDEQR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "487")]
		public LegacyCV2Result<None> IADJAJCGWXN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "488")]
		public LegacyCV2Result<None> SQZQQGFDEAN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "489")]
		public LegacyCV2Result<None> IRAMGVAPYSN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "490")]
		public LegacyCV2Result<None> CHTDPZTNVWD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "491")]
		public LegacyCV2Result<None> AAGGUBAGFNP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "492")]
		public LegacyCV2Result<None> CHSOLKKEMSL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "493")]
		public LegacyCV2Result<None> PPVOQRJUSND(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "494")]
		public LegacyCV2Result<None> LVGOZYFFOKF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "495")]
		public LegacyCV2Result<None> CNKLLJRUHOP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "496")]
		public LegacyCV2Result<None> LUQUROCDSYT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "497")]
		public LegacyCV2Result<None> WPLNLPWDHAP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "498")]
		public LegacyCV2Result<None> NCVENGGHYSH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "499")]
		public LegacyCV2Result<None> ULYRSRTHCDL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B02C60", Offset = "0x2B02060", VA = "0x182B02C60", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "507")]
		public LegacyCV2Result<None> QQAUTXHIWYF(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "508")]
		public LegacyCV2Result<None> WQLUGKJHQDJ(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "509")]
		public LegacyCV2Result<None> BDZWDINXUQP(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "510")]
		public LegacyCV2Result<None> KYLIRTIYHBI(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(ZGJZLOXSVLX e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(ZGJZLOXSVLX e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(ZGJZLOXSVLX e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.XNCJUGEENFB> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "522")]
		public LegacyCV2Result<None> FCHMXXQWTWC(ZGJZLOXSVLX e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "525")]
		public LegacyCV2Result<None> UMCYKQTTRLQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "527")]
		public LegacyCV2Result<None> IGCRZMYWSHJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "528")]
		public LegacyCV2Result<None> WSIQPAFTBFX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "530")]
		public LegacyCV2Result<None> NMEMIOYAJFD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "531")]
		public LegacyCV2Result<None> HHSCBFXLDUY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2B02BD0", Offset = "0x2B01FD0", VA = "0x182B02BD0", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "533")]
		public LegacyCV2Result<None> BOJKIZIFSFM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2B02B00", Offset = "0x2B01F00", VA = "0x182B02B00", Slot = "535")]
		public LegacyCV2Result<None> EFDSGWCVUUM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "534")]
		public LegacyCV2Result<None> IIPDCUWBKTL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "536")]
		public LegacyCV2Result<None> XKDCJDNFDFJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "537")]
		public LegacyCV2Result<None> RITSZEBDTCE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "538")]
		public LegacyCV2Result<None> VEZQXYJQPUO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "539")]
		public LegacyCV2Result<None> TXUXNQIYSEC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "540")]
		public LegacyCV2Result<None> NXMMHSVLMLS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "583")]
		public LegacyCV2Result<None> Raycast(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "584")]
		public LegacyCV2Result<None> VHDYAXCNHKV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "587")]
		public LegacyCV2Result<None> SBQZOUUVMIM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "591")]
		public LegacyCV2Result<None> GWLIGHCNAXZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "592")]
		public LegacyCV2Result<None> QWWMUVUFZDC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "641")]
		public LegacyCV2Result<None> YWHJOXGAYGB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "642")]
		public LegacyCV2Result<None> YWHJXCZYLSB(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "643")]
		public LegacyCV2Result<None> YDCRVGFLFVC(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "644")]
		public LegacyCV2Result<None> ZDSBDTDUVEH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "645")]
		public LegacyCV2Result<None> BHSSRLPVNIP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "646")]
		public LegacyCV2Result<None> JVZEIWZSAGQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "649")]
		public LegacyCV2Result<None> YTZPQYNORTB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "650")]
		public LegacyCV2Result<None> NBDINVQYMQP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "651")]
		public LegacyCV2Result<None> VUIBCFWAHYY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "661")]
		public LegacyCV2Result<None> XFXUMEERLIP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "660")]
		public LegacyCV2Result<None> XJMFLRSEROC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "662")]
		public LegacyCV2Result<None> FIPWEKXJSAB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "663")]
		public LegacyCV2Result<None> ZTXPTDUUYUI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "670")]
		public LegacyCV2Result<None> APWLRGIOTPV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "671")]
		public LegacyCV2Result<None> VGHTSUDPJYG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "674")]
		public LegacyCV2Result<None> LZJGDGKMNKI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "675")]
		public LegacyCV2Result<None> GOWCCFPMELJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(ZGJZLOXSVLX e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "696")]
		public LegacyCV2Result<None> NWTTJVNHLSJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "697")]
		public LegacyCV2Result<None> NAHYZVQKJHJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "698")]
		public LegacyCV2Result<None> LBIZCSHCBKJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "699")]
		public LegacyCV2Result<None> GOEIIRDFNMW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "700")]
		public LegacyCV2Result<None> SGTTXRBDJAQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "676")]
		public LegacyCV2Result<None> XJPBQZZVEDF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "677")]
		public LegacyCV2Result<None> HCCOZLPJDRX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "678")]
		public LegacyCV2Result<None> QPVKLXCGXXO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "679")]
		public LegacyCV2Result<None> AVHRCDYEUCR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "680")]
		public LegacyCV2Result<None> DXXOLOJRNXQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "681")]
		public LegacyCV2Result<None> BBYMBAULXHJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "682")]
		public LegacyCV2Result<None> WYOWAKEFFSV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "683")]
		public LegacyCV2Result<None> CMQPQDVWJVC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "684")]
		public LegacyCV2Result<None> OKSKWVLWZLE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "685")]
		public LegacyCV2Result<None> SVACSFILUIJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "686")]
		public LegacyCV2Result<None> IBFNSWTOWNL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "687")]
		public LegacyCV2Result<None> VOCMZIILLUI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "688")]
		public LegacyCV2Result<None> TZNUFXSDLNV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "689")]
		public LegacyCV2Result<None> IWZTMRMXRGT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "690")]
		public LegacyCV2Result<None> TXENNMADCKQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "691")]
		public LegacyCV2Result<None> OCFMSBWYCFQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "692")]
		public LegacyCV2Result<None> SATVPXRVRJC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "693")]
		public LegacyCV2Result<None> BHRDZAJZIRV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "765")]
		public LegacyCV2Result<None> EYQLCGDXWYJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "711")]
		public LegacyCV2Result<None> HPNIXYRFNBY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "712")]
		public LegacyCV2Result<None> ULJBUULKBNA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "713")]
		public LegacyCV2Result<None> KFDIBXOZWUU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "714")]
		public LegacyCV2Result<None> WBNANYPZSWC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "717")]
		public LegacyCV2Result<None> ZZWNNMHEAHW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "721")]
		public LegacyCV2Result<None> YSUIRSDSKHL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "722")]
		public LegacyCV2Result<None> RGAUDNXJWZN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "723")]
		public LegacyCV2Result<None> FXEXANOZFNA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "724")]
		public LegacyCV2Result<None> UROIOETSLBQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "725")]
		public LegacyCV2Result<None> CAOXBXNGGJA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "726")]
		public LegacyCV2Result<None> FTIWJCYVUYZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "727")]
		public LegacyCV2Result<None> LVFLRODFOBK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "728")]
		public LegacyCV2Result<None> JOCDIADVLFR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "729")]
		public LegacyCV2Result<None> PQZQHPBKISF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "730")]
		public LegacyCV2Result<None> MFMJUZMUWRB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "731")]
		public LegacyCV2Result<None> LVGNCUETIZZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "732")]
		public LegacyCV2Result<None> FWEXRGZTUEJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "733")]
		public LegacyCV2Result<None> MGTMWRNNKGR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "734")]
		public LegacyCV2Result<None> PMVSPGMLQSA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "735")]
		public LegacyCV2Result<None> TIXBQHZFHTP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "736")]
		public LegacyCV2Result<None> RVOQJASYBHV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "737")]
		public LegacyCV2Result<None> GHNWTEJWLTE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "738")]
		public LegacyCV2Result<None> BXUXMCRWAUR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "740")]
		public LegacyCV2Result<None> CCQNLOHOSPJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "739")]
		public LegacyCV2Result<None> HEZRPWHTJDF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "741")]
		public LegacyCV2Result<None> UIZVHLNCJNY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "742")]
		public LegacyCV2Result<None> MQUWILPSSWJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "743")]
		public LegacyCV2Result<None> TNKJBUEJRLE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "744")]
		public LegacyCV2Result<None> DGDDCSOTVYU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "745")]
		public LegacyCV2Result<None> QFVXEXATHIT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "746")]
		public LegacyCV2Result<None> JPJTDZDPYIW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "747")]
		public LegacyCV2Result<None> FOMHDOWVDJI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "748")]
		public LegacyCV2Result<None> VPVMLAPCGJT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "749")]
		public LegacyCV2Result<None> EPMPFKSRUIT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "750")]
		public LegacyCV2Result<None> TAEUTXYKUCD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "751")]
		public LegacyCV2Result<None> PDVQFWDBRWZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "752")]
		public LegacyCV2Result<None> CZPFXRFCOQB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "753")]
		public LegacyCV2Result<None> TDQJYIKOKQV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "754")]
		public LegacyCV2Result<None> IRUFPKYQBYV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "755")]
		public LegacyCV2Result<None> COIFMVZRNRS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "756")]
		public LegacyCV2Result<None> FIIIGCKZDOS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "757")]
		public LegacyCV2Result<None> ZENDMLHWDUK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "758")]
		public LegacyCV2Result<None> FQRQRTPVMHI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "759")]
		public LegacyCV2Result<None> JEFYKMQMSQJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "760")]
		public LegacyCV2Result<None> ACBUQIICSLR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "761")]
		public LegacyCV2Result<None> WNNIZPACJGJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "762")]
		public LegacyCV2Result<None> XCVSTMNHOZQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "763")]
		public LegacyCV2Result<None> OEQJAFWBFEE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "764")]
		public LegacyCV2Result<None> AYZZUUWFORP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "771")]
		public LegacyCV2Result<None> JLJUPWVNCKH(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "772")]
		public LegacyCV2Result<None> QQRJWPIIRKF(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "773")]
		public LegacyCV2Result<None> DQWXDJMRFZY(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(ZGJZLOXSVLX ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "775")]
		public LegacyCV2Result<None> DJTSGUZYZZC(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "776")]
		public LegacyCV2Result<None> BHIXQPEGWMU(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "777")]
		public LegacyCV2Result<None> IAGKSURTUUL(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "778")]
		public LegacyCV2Result<None> RFCVSSPFGDT(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "779")]
		public LegacyCV2Result<None> XZBJUQQUJXH(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "707")]
		public LegacyCV2Result<None> GHFGQGLDMYL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "801")]
		public LegacyCV2Result<None> DXESBOAWLKR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "802")]
		public LegacyCV2Result<None> DIEFBQSRMYZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "803")]
		public LegacyCV2Result<None> ZDDFQDALRIT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "804")]
		public LegacyCV2Result<None> POIALGOXMWD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "805")]
		public LegacyCV2Result<None> VHVNXXKOQVT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "806")]
		public LegacyCV2Result<None> FUTOWYPWATP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "807")]
		public LegacyCV2Result<None> AGKZSJRMYFJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "808")]
		public LegacyCV2Result<None> WJXISRNFLXR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "809")]
		public LegacyCV2Result<None> KMUTMGTJESN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "810")]
		public LegacyCV2Result<None> CNRGWXFCMJF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "811")]
		public LegacyCV2Result<None> RINQDHDIFUD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "812")]
		public LegacyCV2Result<None> HRJBJXQEINC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "817")]
		public LegacyCV2Result<None> SSHBFSIYNLB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "821")]
		public LegacyCV2Result<None> ZQKOMGLROVK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "822")]
		public LegacyCV2Result<None> SGJXTCCXQVW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "823")]
		public LegacyCV2Result<None> BEOALIYMQIW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "824")]
		public LegacyCV2Result<None> QOKNTJCYTQW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "826")]
		public LegacyCV2Result<None> YVSBLZMBRFA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "827")]
		public LegacyCV2Result<None> TZPGUGJIHTL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "828")]
		public LegacyCV2Result<None> WGCJJSGDVLB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "831")]
		public LegacyCV2Result<None> BSSSOGJDHGV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "832")]
		public LegacyCV2Result<None> UYPLYWMGYBI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "833")]
		public LegacyCV2Result<None> YLEILUPOPCN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(ZGJZLOXSVLX e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(ZGJZLOXSVLX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "836")]
		public LegacyCV2Result<None> CZJQOHHIWFC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OHLAJFZJFRA(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LFHVSKIGGWY(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DCEAAIWJFQP(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BWYUYUVQDHO(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CFCUBQLAYAZ(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(ZGJZLOXSVLX e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(ZGJZLOXSVLX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(ZGJZLOXSVLX e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(ZGJZLOXSVLX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(ZGJZLOXSVLX e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(ZGJZLOXSVLX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(ZGJZLOXSVLX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "856")]
		public LegacyCV2Result<None> SFWDNUQGTPC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "859")]
		public LegacyCV2Result<None> WSCUCZYAHRK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "860")]
		public LegacyCV2Result<None> NWGGBRRCXNI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "861")]
		public LegacyCV2Result<None> VYHWNRAVHUO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "862")]
		public LegacyCV2Result<None> YTSIQIZBTRN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "864")]
		public LegacyCV2Result<None> QYMGMCMSGLK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "865")]
		public LegacyCV2Result<None> SVQMGVGSEKS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(ZGJZLOXSVLX e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "869")]
		public LegacyCV2Result<None> GYETTJGKTFE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "879")]
		public LegacyCV2Result<None> PODYZLZKUVC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "880")]
		public LegacyCV2Result<None> FYGNUOILFSG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "881")]
		public LegacyCV2Result<None> DRMYKJFUCXZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "882")]
		public LegacyCV2Result<None> OCDJWEAAMAS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(ZGJZLOXSVLX e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(ZGJZLOXSVLX e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(ZGJZLOXSVLX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(ZGJZLOXSVLX e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(ZGJZLOXSVLX e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "889")]
		public LegacyCV2Result<None> TNQIJMVQTNU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "890")]
		public LegacyCV2Result<None> XTRKURHGRZP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "891")]
		public LegacyCV2Result<None> GEWXYBWNNVW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "892")]
		public LegacyCV2Result<None> PHRTFIQSYFW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "893")]
		public LegacyCV2Result<None> CSYCQGSZZUC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "897")]
		public LegacyCV2Result<None> JDABSLUOBBN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "898")]
		public LegacyCV2Result<None> PNPNNVJSVQL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "899")]
		public LegacyCV2Result<None> YDNPPPEVLUK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "901")]
		public LegacyCV2Result<None> STBOVQFQKYS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "900")]
		public LegacyCV2Result<None> HVJNJXDOOHI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "902")]
		public LegacyCV2Result<None> MLDHDIMPDID(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "904")]
		public LegacyCV2Result<None> WJLTEYGMBVF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "903")]
		public LegacyCV2Result<None> SXLXIKGXHMJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "905")]
		public LegacyCV2Result<None> TKOYUDUPRHY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "906")]
		public LegacyCV2Result<None> SDJSINGBFPM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "907")]
		public LegacyCV2Result<None> CXICKCQQNFZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "908")]
		public LegacyCV2Result<None> KDEJNLFPFPH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "909")]
		public LegacyCV2Result<None> RWBEXMKUSXL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "910")]
		public LegacyCV2Result<None> VRNLZBYJGAF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "911")]
		public LegacyCV2Result<None> UDZJVGEOZUN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "918")]
		public LegacyCV2Result<None> DAIIPROQMKH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "919")]
		public LegacyCV2Result<None> OCXAINQWNZF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(ZGJZLOXSVLX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(ZGJZLOXSVLX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(ZGJZLOXSVLX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(ZGJZLOXSVLX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(ZGJZLOXSVLX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(ZGJZLOXSVLX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(ZGJZLOXSVLX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(ZGJZLOXSVLX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(ZGJZLOXSVLX e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "941")]
		public LegacyCV2Result<None> CJMOHGHKUUN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "942")]
		public LegacyCV2Result<None> VJTJBWMRQHP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "943")]
		public LegacyCV2Result<None> SELBRZOUJHM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "944")]
		public LegacyCV2Result<None> GIUOABUMKPC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "945")]
		public LegacyCV2Result<None> WNNSKNVFMFR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "946")]
		public LegacyCV2Result<None> BIIWNRAPSIV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "947")]
		public LegacyCV2Result<None> ZGMVGUCAZCY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "948")]
		public LegacyCV2Result<None> FXRGBBTKLKY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "949")]
		public LegacyCV2Result<None> ZVVEKEFRVYI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "950")]
		public LegacyCV2Result<None> SWVGDRSHHNZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "968")]
		public LegacyCV2Result<None> DYJZQTESSSP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "967")]
		public LegacyCV2Result<None> TSKSBLCFDKQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "969")]
		public LegacyCV2Result<None> OLDYLVJGUJM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "970")]
		public LegacyCV2Result<None> KIFHVFCTGZZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "971")]
		public LegacyCV2Result<None> IKXCXIKHDPW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "972")]
		public LegacyCV2Result<None> XQOHHGVOFJM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "973")]
		public LegacyCV2Result<None> ZXXKHZKKUDN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "975")]
		public LegacyCV2Result<None> JRSZUIWXMVG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "982")]
		public LegacyCV2Result<None> VWZZOSXGLED(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "983")]
		public LegacyCV2Result<None> NNVPHDMKXWB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "991")]
		public LegacyCV2Result<None> BADEUNWYJEE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "993")]
		public LegacyCV2Result<None> AZAEGJTLEWU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "994")]
		public LegacyCV2Result<None> LWYMCNHUZWY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "995")]
		public LegacyCV2Result<None> SVTNAJQQDKW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "996")]
		public LegacyCV2Result<None> ZJASLMKSXNI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "997")]
		public LegacyCV2Result<None> VITWERDXMDK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "998")]
		public LegacyCV2Result<None> NDQCGXNABSE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "999")]
		public LegacyCV2Result<None> ZRTYBWWXMOS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1000")]
		public LegacyCV2Result<None> HKGJKVFNCAC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1001")]
		public LegacyCV2Result<None> ZKZCSRTFXIS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1002")]
		public LegacyCV2Result<None> SSDFAGVRWTM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1009")]
		public LegacyCV2Result<None> XTIIRROMLVG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1017")]
		public LegacyCV2Result<None> PLTGRDMAFCL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1018")]
		public LegacyCV2Result<None> AMRZTDXRAQC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1019")]
		public LegacyCV2Result<None> NOFZKYQQNYD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1020")]
		public LegacyCV2Result<None> DVMSRVYXZES(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1021")]
		public LegacyCV2Result<None> LOCOEGDMJMP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1022")]
		public LegacyCV2Result<None> LQMPILYMFVO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1023")]
		public LegacyCV2Result<None> DOIDAGJBRRT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1024")]
		public LegacyCV2Result<None> QRODONRJBEJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1025")]
		public LegacyCV2Result<None> KMBCSJGCOOY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1026")]
		public LegacyCV2Result<None> AZPZXTORYAL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1027")]
		public LegacyCV2Result<None> HHUIWJAACRV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1028")]
		public LegacyCV2Result<None> DTONSUMYZSA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1029")]
		public LegacyCV2Result<None> QKEPNEKEIQM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1030")]
		public LegacyCV2Result<None> KCZOLIYPPTR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1031")]
		public LegacyCV2Result<None> XSFRDTVDKTS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1032")]
		public LegacyCV2Result<None> BROCIUWZBGX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1033")]
		public LegacyCV2Result<None> JKZABMIPJIT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1047")]
		public LegacyCV2Result<None> FHYJKQJXVBH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1048")]
		public LegacyCV2Result<None> YKPKDUTOOIZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1049")]
		public LegacyCV2Result<None> SPANOVRQYAN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1050")]
		public LegacyCV2Result<None> WGEWXNLRBEN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1051")]
		public LegacyCV2Result<None> KXIPNNJQLPE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1052")]
		public LegacyCV2Result<None> DLQLROQLVTQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1053")]
		public LegacyCV2Result<None> TQTQVFYKKWB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1054")]
		public LegacyCV2Result<None> FOXFDFGJCSM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1055")]
		public LegacyCV2Result<None> JBUNWKVMFIX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1056")]
		public LegacyCV2Result<None> PGSGHROVEDC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1057")]
		public LegacyCV2Result<None> ZOQXBHBADOA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1058")]
		public LegacyCV2Result<None> AOLINOLISLT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1059")]
		public LegacyCV2Result<None> JVJTSDAXRSE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1060")]
		public LegacyCV2Result<None> QKNWQLKZKNU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1061")]
		public LegacyCV2Result<None> LXUHINKFZAG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1062")]
		public LegacyCV2Result<None> BVWHGPKAJRI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1063")]
		public LegacyCV2Result<None> FODQKIXNJKK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1064")]
		public LegacyCV2Result<None> UQLRFVNOJMT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1065")]
		public LegacyCV2Result<None> NRSVAZBIXRN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1066")]
		public LegacyCV2Result<None> FIYWNMXXPCA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1067")]
		public LegacyCV2Result<None> INHUCYLPEDW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1068")]
		public LegacyCV2Result<None> EBZYPXDVRYW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1069")]
		public LegacyCV2Result<None> IMSLYJLRCWS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1070")]
		public LegacyCV2Result<None> MUBSOKDEWNF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1071")]
		public LegacyCV2Result<None> ISXWLPXKJXJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B02C10", Offset = "0x2B02010", VA = "0x182B02C10", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(ZGJZLOXSVLX e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(ZGJZLOXSVLX e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1092")]
		public LegacyCV2Result<None> VBLBBGBNSZQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1093")]
		public LegacyCV2Result<None> JPVGOSHDUOZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1094")]
		public LegacyCV2Result<None> LQHWBMODILD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1095")]
		public LegacyCV2Result<None> MOFBLIJUQCJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1096")]
		public LegacyCV2Result<None> RDFPHNXKQPT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1097")]
		public LegacyCV2Result<None> IZHJYHQOLZV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1098")]
		public LegacyCV2Result<None> ZGFAPZLLMGD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1099")]
		public LegacyCV2Result<None> MDWLNJGJPPZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1100")]
		public LegacyCV2Result<None> EGIOJGDBBOX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1101")]
		public LegacyCV2Result<None> HHAUZNAJLTJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1102")]
		public LegacyCV2Result<None> NNNODGNBELB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1103")]
		public LegacyCV2Result<None> CJIHIHUVIOQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1104")]
		public LegacyCV2Result<None> RPNFTAINOCE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1105")]
		public LegacyCV2Result<None> TIIFQPKNPDS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1106")]
		public LegacyCV2Result<None> SDJACIQUDNK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1107")]
		public LegacyCV2Result<None> LGXJCIQPVRV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1108")]
		public LegacyCV2Result<None> XXJSQQMBRKP(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1109")]
		public LegacyCV2Result<None> FSYAQBMJUXE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1110")]
		public LegacyCV2Result<None> OQGAUHMWKXY(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1111")]
		public LegacyCV2Result<None> FRXWWDFDHGC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1112")]
		public LegacyCV2Result<None> TOJWZMLCFUK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1113")]
		public LegacyCV2Result<None> UZYHOHFWLNJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1114")]
		public LegacyCV2Result<None> NWAWSRUCTBN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1115")]
		public LegacyCV2Result<None> JFLVDCBTGLU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1116")]
		public LegacyCV2Result<None> JIPHJYECYAG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1117")]
		public LegacyCV2Result<None> EBRDLMAIEOW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1118")]
		public LegacyCV2Result<None> ZEBVEDSAVAK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1119")]
		public LegacyCV2Result<None> ARHGXUOTFTB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1120")]
		public LegacyCV2Result<None> NCOOQIBILRO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1121")]
		public LegacyCV2Result<None> QCEMLOGELCE(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1122")]
		public LegacyCV2Result<None> JQWTBVTWEPS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1123")]
		public LegacyCV2Result<None> MGJPFNCJHJJ(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1124")]
		public LegacyCV2Result<None> RUVQEZRWEKX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1125")]
		public LegacyCV2Result<None> DJBLPVNEPJV(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1126")]
		public LegacyCV2Result<None> ATNLMJJNAVF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1127")]
		public LegacyCV2Result<None> TGRTIODXSNR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1128")]
		public LegacyCV2Result<None> VXKFPIOENZZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1129")]
		public LegacyCV2Result<None> BHHKPAKBJZT(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1130")]
		public LegacyCV2Result<None> HIWCADSAXOK(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1131")]
		public LegacyCV2Result<None> YZUFEVOYVFZ(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1132")]
		public LegacyCV2Result<None> HFBYUNDODKS(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1133")]
		public LegacyCV2Result<None> HCJUTTEEKML(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1134")]
		public LegacyCV2Result<None> FUVWYDQDFNB(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1135")]
		public LegacyCV2Result<None> SAOJEASGSFO(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1136")]
		public LegacyCV2Result<None> BUTMUVTVTXW(GOCFXIZVABA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1140")]
		public LegacyCV2Result<None> VROCSFEXCEQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1166")]
		public LegacyCV2Result<None> MZFWXJCDIUS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1168")]
		public LegacyCV2Result<None> PFNLSCCCYGA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1169")]
		public LegacyCV2Result<None> KNRVKFVSYIL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1170")]
		public LegacyCV2Result<None> RJQQZJMSXEO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1171")]
		public LegacyCV2Result<None> MISPZGBZRRB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1182")]
		public LegacyCV2Result<None> QOZMHQTCXRZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1183")]
		public LegacyCV2Result<None> HLNAHKHHIPL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1184")]
		public LegacyCV2Result<None> HVSORTUIKEN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1185")]
		public LegacyCV2Result<None> PGAACNKOZDF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1186")]
		public LegacyCV2Result<None> CASIXPWAUPK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1187")]
		public LegacyCV2Result<None> VQOKECVVZIE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1188")]
		public LegacyCV2Result<None> GEVUWMRFJWW(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1189")]
		public LegacyCV2Result<None> AGETIYAZSRM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1190")]
		public LegacyCV2Result<None> HXOWLCCWCIB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1191")]
		public LegacyCV2Result<None> RTVNIFZUKWZ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1192")]
		public LegacyCV2Result<None> ZFJMDOREHVQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1193")]
		public LegacyCV2Result<None> ODOOKZDIDQH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "184")]
		public LegacyCV2Result<None> CFLTTGHWGOD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B02C50", Offset = "0x2B02050", VA = "0x182B02C50", Slot = "191")]
		public bool KFLPSJVFXRH(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1194")]
		public LegacyCV2Result<None> TKWZDLBGPXB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1195")]
		public LegacyCV2Result<None> VLIMLWYAUZE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1196")]
		public LegacyCV2Result<None> CHTETCXXUTT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(ZGJZLOXSVLX e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1205")]
		public LegacyCV2Result<None> RSPSAYYAMLU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1206")]
		public LegacyCV2Result<None> MLRLYPJDTYK(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(ZGJZLOXSVLX e, InOut io, XVGTUJVAJNU objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "250")]
		public LegacyCV2Result<None> XVPDASYOUIT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "251")]
		public LegacyCV2Result<None> MNISCXXGNAN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "252")]
		public LegacyCV2Result<None> XUVHCFLAVCV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "254")]
		public LegacyCV2Result<None> CDMVSMYNDVE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "255")]
		public LegacyCV2Result<None> IHQSZWZDLFM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "256")]
		public LegacyCV2Result<None> KAMPLIQTYZM(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "257")]
		public LegacyCV2Result<None> NQTBETQRKZH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "258")]
		public LegacyCV2Result<None> SEDJDIPIVAR(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "259")]
		public LegacyCV2Result<None> FWDRBXJAJUO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "260")]
		public LegacyCV2Result<None> EWVXSGUTQZU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "261")]
		public LegacyCV2Result<None> MAMWNTBFTLG(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "262")]
		public LegacyCV2Result<None> METJUJBFCSI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "263")]
		public LegacyCV2Result<None> RYULVZYVMSH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "264")]
		public LegacyCV2Result<None> NTTGLWXYVXN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "265")]
		public LegacyCV2Result<None> GTAOTDANJKB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "266")]
		public LegacyCV2Result<None> IFZJUVGBQWN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "267")]
		public LegacyCV2Result<None> DJKAKWKQNPT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "268")]
		public LegacyCV2Result<None> NQQHFPGKPXJ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "269")]
		public LegacyCV2Result<None> NVYGEDQRAQH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
		private static LegacyCV2Result<None> Default(ZGJZLOXSVLX e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B02B40", Offset = "0x2B01F40", VA = "0x182B02B40", Slot = "1209")]
		public LegacyCV2Result<None> FQMKSSLSAME(ZGJZLOXSVLX a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1212")]
		public LegacyCV2Result<None> LYXNUEWIODV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1213")]
		public LegacyCV2Result<None> KMILNKGNYGN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1214")]
		public LegacyCV2Result<None> UPFSLCYWBPH(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1215")]
		public LegacyCV2Result<None> MRSEQNRUKZE(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(ZGJZLOXSVLX e, InOut io, AXMXOAUNAPY quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1036")]
		public LegacyCV2Result<None> MMQJYZZMJHN(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1037")]
		public LegacyCV2Result<None> NCNSMWITELF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1038")]
		public LegacyCV2Result<None> PVAKGWYGCWF(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1039")]
		public LegacyCV2Result<None> RCWTFHMXLDT(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1040")]
		public LegacyCV2Result<None> RFDHMCRWBEX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1041")]
		public LegacyCV2Result<None> DLWKTTUXVUL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1042")]
		public LegacyCV2Result<None> UBCBVPEDBMX(ZGJZLOXSVLX a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1043")]
		public LegacyCV2Result<None> IPDPSDMRWJL(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1044")]
		public LegacyCV2Result<None> RDYSMBBRPQV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1045")]
		public LegacyCV2Result<None> VKDJXRMHWTO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1046")]
		public LegacyCV2Result<None> FQTRHBTVPRS(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DHLVIPDYTIM(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1234")]
		public LegacyCV2Result<None> SZZPGRFOEQX(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1236")]
		public LegacyCV2Result<None> DKMOYTUHJDI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1229")]
		public LegacyCV2Result<None> JXCSJUPEEGU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1241")]
		public LegacyCV2Result<None> NUJKZZKGYAQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1242")]
		public LegacyCV2Result<None> JOHUUJBOHID(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1243")]
		public LegacyCV2Result<None> TDFZQNDJYFV(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1244")]
		public LegacyCV2Result<None> TUCZQFLNNVD(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1245")]
		public LegacyCV2Result<None> HBQXBVWBWOO(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QUAOFEPECIE(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DMCLSXKQPSI(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BYQWLXNVHKK(ZGJZLOXSVLX a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1259")]
		public LegacyCV2Result<None> CZJKZPCXWVA(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1260")]
		public LegacyCV2Result<None> MCOCZUCIPSQ(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1261")]
		public LegacyCV2Result<None> HKSHROEEVYI(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1262")]
		public LegacyCV2Result<None> MAUXIIXZHJC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B02CA0", Offset = "0x2B020A0", VA = "0x182B02CA0")]
		public INDKNEJEOQB([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(ZGJZLOXSVLX e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1280")]
		public LegacyCV2Result<None> AJTXWPZXOHB(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1281")]
		public LegacyCV2Result<None> AQINHJGDSTU(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "599")]
		public LegacyCV2Result<None> ZSXCEIJBBJC(ZGJZLOXSVLX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1293")]
		public LegacyCV2Result<None> ZBYRRGWYJOX(GOCFXIZVABA e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1294")]
		public LegacyCV2Result<None> CJOJEZCCTDM(GOCFXIZVABA e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1295")]
		public LegacyCV2Result<None> UMEGPWZWMFZ(GOCFXIZVABA e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1296")]
		public LegacyCV2Result<None> ZTCQLCOACWR(GOCFXIZVABA e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1297")]
		public LegacyCV2Result<None> TRYZNCXXRCM(GOCFXIZVABA e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
		public LegacyCV2Result<None> ConstantStorefrontItem(ZGJZLOXSVLX e, InOut io, [In] ITOZXKHQQGP storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(ZGJZLOXSVLX e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> YKVAGDNYQJW(ZGJZLOXSVLX a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, DEFWHCCFMTK.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> TOJTOHSDTUO(ZGJZLOXSVLX a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, DEFWHCCFMTK.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1207")]
		private LegacyCV2Result<None> OHCXZCSFGBH(ZGJZLOXSVLX a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1216")]
		private LegacyCV2Result<None> OTVCFJTAWIK(ZGJZLOXSVLX a, InOut b, [In] ITOZXKHQQGP storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530", Slot = "1257")]
		private LegacyCV2Result<None> UNUNGHXKDSG(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class NEVAZRELDVK : FJKHTKMOEYF
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(IYJACMBKULE node);

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly NEVAZRELDVK EDBLDZCISQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate BGCOKTHIQRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate KLJWSSTSERE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private bool OZKWWEELARA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private bool YINXCQEPQBF;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2B10C20", Offset = "0x2B10020", VA = "0x182B10C20", Slot = "4")]
		public Task<bool> LMODEKUWPIS(IYJACMBKULE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2B10E70", Offset = "0x2B10270", VA = "0x182B10E70", Slot = "5")]
		public Task<bool> ATSBWONXKBX(IYJACMBKULE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2B10F40", Offset = "0x2B10340", VA = "0x182B10F40")]
		public NEVAZRELDVK([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2B10EA0", Offset = "0x2B102A0", VA = "0x182B10EA0", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? EIPVANVUBBU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xCF5530", Offset = "0xCF4930", VA = "0x180CF5530", Slot = "7")]
		public bool KSMOWPIZBWL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x15FD360", Offset = "0x15FC760", VA = "0x1815FD360", Slot = "8")]
		public bool LHHDYMHIGIL()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class PDFCWFVPCVW : PSFWPHWAKUD
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid UUVPJZSVJCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xF151B0", Offset = "0xF145B0", VA = "0x180F151B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
		public void Bind(HZWQOYIILYL pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x110C990", Offset = "0x110BD90", VA = "0x18110C990")]
		public PDFCWFVPCVW(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2B116E0", Offset = "0x2B10AE0", VA = "0x182B116E0")]
		public static PDFCWFVPCVW New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class NPVXKLSRAMO : KIRCHECAFFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<VOUYFSSRGER> nodeDefId, Id128<EVDWFGHNUCH>? legacyInnerGraphId, IReadOnlyDictionary<Id128<EVDWFGHNUCH>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IsNodeRestrictedDelegate? UBVJKKZWTZL;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool DVVWYSJXHND
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xD4A700", Offset = "0xD49B00", VA = "0x180D4A700", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool DKHAVVZBHGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2B11140", Offset = "0x2B10540", VA = "0x182B11140", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool KPVIWSNRFOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x11198C0", Offset = "0x1118CC0", VA = "0x1811198C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "6")]
		public bool AJKEPMTHZIX(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "7")]
		public CanSaveObjectIntoInventionResultType NPIBQYQTNZK(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2B11150", Offset = "0x2B10550", VA = "0x182B11150", Slot = "8")]
		public bool VMRBBPIQFNR(Id128<VOUYFSSRGER> nodeDefId, Id128<EVDWFGHNUCH>? legacyInnerGraphId, IReadOnlyDictionary<Id128<EVDWFGHNUCH>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "9")]
		public bool ODMJWNCCGRS(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "10")]
		public bool WPXVVEPVENQ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2B111A0", Offset = "0x2B105A0", VA = "0x182B111A0")]
		public NPVXKLSRAMO(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class VHFDYICOYCU : MLSLADSATQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly VHFDYICOYCU EDBLDZCISQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly ShouldLogEventSenderToMakerPenDelegate TYMDVHDTOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate LHPDXSIXTXA;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool PGPPRJDXWOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x12B7D60", Offset = "0x12B7160", VA = "0x1812B7D60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool INMBBAEKYTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2B154A0", Offset = "0x2B148A0", VA = "0x182B154A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2B15540", Offset = "0x2B14940", VA = "0x182B15540")]
		public VHFDYICOYCU([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class VRZZEQRNALI : VPRVIMXHXTY<TQNVKMZRYRU>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class DJVVFHFPXRP : TQNVKMZRYRU, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly DJVVFHFPXRP LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool FCMKGLSMPJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EA60", Offset = "0x2B0DE60", VA = "0x182B0EA60", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			public void YVIESLQOYIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public DJVVFHFPXRP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly VRZZEQRNALI LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private VRZZEQRNALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B17550", Offset = "0x2B16950", VA = "0x182B17550", Slot = "4")]
		public TQNVKMZRYRU UXGKLJIPXNN()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class SQNVNHLDELG<a, b> : IDisposable, VYUTWWCJPWH where a : notnull where b : notnull, LRKLURSCSPE.MCUQWFOUSFS<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly b RATSQORCBWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly a SOWSTSWRDPN;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<BVHHKRGRDMC> JMPYBRFMZMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<BVHHKRGRDMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x5330040", Offset = "0x532F440", VA = "0x185330040")]
		public SQNVNHLDELG(b a, a b, Id32<BVHHKRGRDMC> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x793F250", Offset = "0x793E650", VA = "0x18793F250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x7940480", Offset = "0x793F880", VA = "0x187940480")]
		public Id32<QXDOXFETTHL> WAVOYBZULAU([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<QXDOXFETTHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x793FF70", Offset = "0x793F370", VA = "0x18793FF70", Slot = "6")]
		public void RITIFJCKJLN(Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x793FD00", Offset = "0x793F100", VA = "0x18793FD00", Slot = "7")]
		public void QHAAXIZSLJL(Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x7940380", Offset = "0x793F780", VA = "0x187940380", Slot = "8")]
		public void RURZAIYIQUK(Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x793EDC0", Offset = "0x793E1C0", VA = "0x18793EDC0", Slot = "10")]
		public void BTWOSNSMYTL(Id32<QXDOXFETTHL> objectId, Id32<BVHHKRGRDMC> clientId, ISAERBMVTGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x7940730", Offset = "0x793FB30", VA = "0x187940730", Slot = "9")]
		public void XGVLXKOJEAX(Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x793ED80", Offset = "0x793E180", VA = "0x18793ED80", Slot = "11")]
		public void AWOAIIBQXHJ(Id32<QXDOXFETTHL> objectId, EBBCGXLPIMK? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x793F540", Offset = "0x793E940", VA = "0x18793F540", Slot = "12")]
		public Id32<BVHHKRGRDMC> FYFOPLXQVBG(Id32<QXDOXFETTHL> objectId)
		{
			return default(Id32<BVHHKRGRDMC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x793F280", Offset = "0x793E680", VA = "0x18793F280", Slot = "13")]
		public Id32<KVBJFKAQQAH> FELJHCJFCPK(Id32<QXDOXFETTHL> objectId, string a, object b, bool c, EWHTDQCKTSR d, KBAXVSULPAP e)
		{
			return default(Id32<KVBJFKAQQAH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x79409A0", Offset = "0x793FDA0", VA = "0x1879409A0", Slot = "14")]
		public void ZXKYAUWJHVO(Id32<KVBJFKAQQAH> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x793F880", Offset = "0x793EC80", VA = "0x18793F880", Slot = "15")]
		public void GLBEJTJXRFE(Id32<KVBJFKAQQAH> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class LRKLURSCSPE
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface MCUQWFOUSFS<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ZHUNHONDTBC(a a, Id32<BVHHKRGRDMC> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<BVHHKRGRDMC>? LYQLSQEDJHN(a a);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<QXDOXFETTHL> WAVOYBZULAU(a a, Id32<BVHHKRGRDMC> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void RITIFJCKJLN(a a, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void QHAAXIZSLJL(a a, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void BTWOSNSMYTL(a a, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ b);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void XGVLXKOJEAX(a a, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ b);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void AWOAIIBQXHJ(a a, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, EBBCGXLPIMK? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<BVHHKRGRDMC>? FYFOPLXQVBG(a a, Id32<QXDOXFETTHL> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<KVBJFKAQQAH> FELJHCJFCPK(a a, Id32<BVHHKRGRDMC> clientId, string b, object c, EWHTDQCKTSR d, KBAXVSULPAP e);

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void ZXKYAUWJHVO(a a, Id32<BVHHKRGRDMC> clientId, Id32<KVBJFKAQQAH> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void GLBEJTJXRFE(a a, Id32<BVHHKRGRDMC> clientId, Id32<KVBJFKAQQAH> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class VKNRGMOPOOY
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly HashSet<Id32<QXDOXFETTHL>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAId32Field<KVBJFKAQQAH, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public readonly Dictionary<Id32<KVBJFKAQQAH>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<KVBJFKAQQAH>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public SOAField<QXDOXFETTHL, EBBCGXLPIMK?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2B108C0", Offset = "0x2B0FCC0", VA = "0x182B108C0")]
			private MockCV2DynamicNetSys(HashSet<Id32<QXDOXFETTHL>> authorityOf, [In] SOAId32Field<KVBJFKAQQAH, MockCV2SyncField> syncFields, Dictionary<Id32<KVBJFKAQQAH>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<KVBJFKAQQAH>> mockSyncFieldToSyncField, [In] SOAField<QXDOXFETTHL, EBBCGXLPIMK?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2B10700", Offset = "0x2B0FB00", VA = "0x182B10700")]
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
			public Id32<BVHHKRGRDMC>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2B10960", Offset = "0x2B0FD60", VA = "0x182B10960")]
			public MockCV2ObjectShared(Id32<BVHHKRGRDMC> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public KBAXVSULPAP SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public EWHTDQCKTSR SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
			internal MockCV2SyncField(KBAXVSULPAP syncField, EWHTDQCKTSR syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2B10A80", Offset = "0x2B0FE80", VA = "0x182B10A80")]
			public static MockCV2SyncField New(KBAXVSULPAP syncField, EWHTDQCKTSR syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x2B10A30", Offset = "0x2B0FE30", VA = "0x182B10A30")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2B109E0", Offset = "0x2B0FDE0", VA = "0x182B109E0")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<QXDOXFETTHL, MockCV2ObjectShared> QSQYPMIVIUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<QXDOXFETTHL>> NZISHHBHQXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> MDTJIQRQYNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> UPJUEJLGERR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private SOAField<BVHHKRGRDMC, MockCV2DynamicNetSys> BEBGMLFPZTT;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<QXDOXFETTHL>? PNMOWHIPNVL
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xDCCCD0", Offset = "0xDCC0D0", VA = "0x180DCCCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x1291AC0", Offset = "0x1290EC0", VA = "0x181291AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2B15AD0", Offset = "0x2B14ED0", VA = "0x182B15AD0")]
		public void Destroy([In] SOAId32<BVHHKRGRDMC> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B16330", Offset = "0x2B15730", VA = "0x182B16330")]
		public void OOQAABLUGUM(Id32<BVHHKRGRDMC> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2B16EE0", Offset = "0x2B162E0", VA = "0x182B16EE0")]
		public void ZHUNHONDTBC(Id32<BVHHKRGRDMC> clientId, Id32<BVHHKRGRDMC>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2B16950", Offset = "0x2B15D50", VA = "0x182B16950")]
		public Id32<QXDOXFETTHL> WAVOYBZULAU(Id32<BVHHKRGRDMC> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<BVHHKRGRDMC> clientIds)
		{
			return default(Id32<QXDOXFETTHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B15D10", Offset = "0x2B15110", VA = "0x182B15D10")]
		public Id32<KVBJFKAQQAH> FELJHCJFCPK(Id32<BVHHKRGRDMC> clientId, string a, object b, EWHTDQCKTSR c, KBAXVSULPAP d)
		{
			return default(Id32<KVBJFKAQQAH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x2B17220", Offset = "0x2B16620", VA = "0x182B17220")]
		public void ZXKYAUWJHVO(Id32<BVHHKRGRDMC> clientId, Id32<KVBJFKAQQAH> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2B15830", Offset = "0x2B14C30", VA = "0x182B15830")]
		public Id32<QXDOXFETTHL>? AAQYHOJVWDX([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2B168D0", Offset = "0x2B15CD0", VA = "0x182B168D0")]
		public void RITIFJCKJLN([In] SOAId32<BVHHKRGRDMC> clientIds, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2B16790", Offset = "0x2B15B90", VA = "0x182B16790")]
		public void QHAAXIZSLJL(Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2B159D0", Offset = "0x2B14DD0", VA = "0x182B159D0")]
		public void BTWOSNSMYTL(Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2B16D60", Offset = "0x2B16160", VA = "0x182B16D60")]
		public void XGVLXKOJEAX([In] SOAId32<BVHHKRGRDMC> clientIds, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2B15900", Offset = "0x2B14D00", VA = "0x182B15900")]
		public void AWOAIIBQXHJ(Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, EBBCGXLPIMK? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B15F70", Offset = "0x2B15370", VA = "0x182B15F70")]
		public Id32<BVHHKRGRDMC>? FYFOPLXQVBG(Id32<QXDOXFETTHL> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B15FC0", Offset = "0x2B153C0", VA = "0x182B15FC0")]
		public void GLBEJTJXRFE([In] SOAId32<BVHHKRGRDMC> clientIds, Id32<BVHHKRGRDMC> clientId, Id32<KVBJFKAQQAH> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B173B0", Offset = "0x2B167B0", VA = "0x182B173B0")]
		public VKNRGMOPOOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class YXFTQNOGJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x2B17610", Offset = "0x2B16A10", VA = "0x182B17610")]
		public static void Destroy(this VKNRGMOPOOY.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class HHZVFJWTRDJ : CAKAFQMVBWD.TVWXLXTXIIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static HHZVFJWTRDJ CMJEATWSBIA;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate WKUTJXZYBTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate RGBDOAQBSPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xCFB220", Offset = "0xCFA620", VA = "0x180CFB220")]
		public HHZVFJWTRDJ(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class MGQGRHRPFYH : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : UXOUZHAFSJC.FWOEJNVWAJL<PXBFMCKNGBK, MGQGRHRPFYH>
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
				public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public MGQGRHRPFYH root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public Id32<BVHHKRGRDMC> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public PXBFMCKNGBK action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B145F0", Offset = "0x2B139F0", VA = "0x182B145F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B14830", Offset = "0x2B13C30", VA = "0x182B14830", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			public int KYLVYZAKZUZ(MGQGRHRPFYH a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2B125F0", Offset = "0x2B119F0", VA = "0x182B125F0", Slot = "5")]
			public int MZXFTEGTODR(MGQGRHRPFYH a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2B12610", Offset = "0x2B11A10", VA = "0x182B12610", Slot = "6")]
			public int NYJIWCTCCNK(MGQGRHRPFYH a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B125D0", Offset = "0x2B119D0", VA = "0x182B125D0", Slot = "7")]
			public int KMWLZYRAKAM(MGQGRHRPFYH a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B12580", Offset = "0x2B11980", VA = "0x182B12580", Slot = "8")]
			public void BZOACXAHRRZ(MGQGRHRPFYH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "9")]
			public bool PXSXXPTSZAM(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> actorId, PXBFMCKNGBK[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "10")]
			public bool KNXLLWQUBHM(MGQGRHRPFYH a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B12630", Offset = "0x2B11A30", VA = "0x182B12630", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> senderId, PXBFMCKNGBK b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : UXOUZHAFSJC.MDFEQTCPLCK<ActionDeps, SCQFSPRNDPD.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps CPHRSEMEXMO
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public SCQFSPRNDPD.StaticNetSysReceiverDeps KYKJOFKQEMR
			{
				[Cpp2IlInjected.Token(Token = "0x60007AD")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "5")]
				get
				{
					return default(SCQFSPRNDPD.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps CXRYLDTXRXC
			{
				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : FKOWIFAOFJE.MCUQWFOUSFS<MGQGRHRPFYH>
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
				public AsyncTaskMethodBuilder<Result<object?, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public MGQGRHRPFYH root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public Id32<BVHHKRGRDMC> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public PXBFMCKNGBK action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				private TaskAwaiter<Result<object?, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B142D0", Offset = "0x2B136D0", VA = "0x182B142D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B14580", Offset = "0x2B13980", VA = "0x182B14580", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B10AC0", Offset = "0x2B0FEC0", VA = "0x182B10AC0", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> clientId, PXBFMCKNGBK b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : LRKLURSCSPE.MCUQWFOUSFS<MGQGRHRPFYH>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B10530", Offset = "0x2B0F930", VA = "0x182B10530", Slot = "4")]
			public void ZHUNHONDTBC(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xF71540", Offset = "0xF70940", VA = "0x180F71540", Slot = "5")]
			public Id32<BVHHKRGRDMC>? LYQLSQEDJHN(MGQGRHRPFYH a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x2B102B0", Offset = "0x2B0F6B0", VA = "0x182B102B0")]
			public Id32<QXDOXFETTHL> WAVOYBZULAU(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<QXDOXFETTHL>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2B10470", Offset = "0x2B0F870", VA = "0x182B10470", Slot = "7")]
			public void RITIFJCKJLN(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x2B10310", Offset = "0x2B0F710", VA = "0x182B10310", Slot = "8")]
			public void QHAAXIZSLJL(MGQGRHRPFYH a, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x2B10180", Offset = "0x2B0F580", VA = "0x182B10180", Slot = "9")]
			public void BTWOSNSMYTL(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2B10500", Offset = "0x2B0F900", VA = "0x182B10500", Slot = "10")]
			public void XGVLXKOJEAX(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, ISAERBMVTGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B100A0", Offset = "0x2B0F4A0", VA = "0x182B100A0", Slot = "11")]
			public void AWOAIIBQXHJ(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> clientId, Id32<QXDOXFETTHL> objectId, EBBCGXLPIMK? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x2B10220", Offset = "0x2B0F620", VA = "0x182B10220", Slot = "12")]
			public Id32<BVHHKRGRDMC>? FYFOPLXQVBG(MGQGRHRPFYH a, Id32<QXDOXFETTHL> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B101C0", Offset = "0x2B0F5C0", VA = "0x182B101C0", Slot = "13")]
			public Id32<KVBJFKAQQAH> FELJHCJFCPK(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> clientId, string b, object c, EWHTDQCKTSR d, KBAXVSULPAP e)
			{
				return default(Id32<KVBJFKAQQAH>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B10560", Offset = "0x2B0F960", VA = "0x182B10560", Slot = "14")]
			public void ZXKYAUWJHVO(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> clientId, Id32<KVBJFKAQQAH> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2B10280", Offset = "0x2B0F680", VA = "0x182B10280", Slot = "15")]
			public void GLBEJTJXRFE(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> clientId, Id32<KVBJFKAQQAH> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2B102B0", Offset = "0x2B0F6B0", VA = "0x182B102B0", Slot = "6")]
			private Id32<QXDOXFETTHL> GUMGRJSKWYA(MGQGRHRPFYH a, Id32<BVHHKRGRDMC> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<QXDOXFETTHL>);
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
			public MGQGRHRPFYH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public Id32<QXDOXFETTHL>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public ZVMBXFNFHDW deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private Id32<BVHHKRGRDMC> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private DDBBEEAJJTS<MGQGRHRPFYH, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private SQNVNHLDELG<MGQGRHRPFYH, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private SCQFSPRNDPD <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B13C10", Offset = "0x2B13010", VA = "0x182B13C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B14260", Offset = "0x2B13660", VA = "0x182B14260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly MHHBPHJUUGA<PXBFMCKNGBK, None, SCQFSPRNDPD, ActionDeps, SCQFSPRNDPD.StaticNetSysReceiverDeps, RootDeps, MGQGRHRPFYH, Deps> WQZSYPLGHDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly VKNRGMOPOOY OBZSTWDYXDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAId32<BVHHKRGRDMC> TRNJAXZYEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private SOAField<BVHHKRGRDMC, None> BEBGMLFPZTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private SOAField<BVHHKRGRDMC, SCQFSPRNDPD> ALYNJCCVGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Id32<BVHHKRGRDMC>? JNWBMFQCXXQ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate KWOUIAOUZQM
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xCF5540", Offset = "0xCF4940", VA = "0x180CF5540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FD40", Offset = "0x2B0F140", VA = "0x182B0FD40")]
		public MGQGRHRPFYH(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F680", Offset = "0x2B0EA80", VA = "0x182B0F680", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F930", Offset = "0x2B0ED30", VA = "0x182B0F930")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> OOQAABLUGUM(ZVMBXFNFHDW a, RegistryV2 b, Id32<QXDOXFETTHL>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FAB0", Offset = "0x2B0EEB0", VA = "0x182B0FAB0")]
		private void ZHUNHONDTBC(Id32<BVHHKRGRDMC> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F850", Offset = "0x2B0EC50", VA = "0x182B0F850")]
		[CompilerGenerated]
		private Id32<QXDOXFETTHL>? OHYDZWTJLYM([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class IOTRLMYDZSC : PWJKHDEOEOW.TVWXLXTXIIP
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<FXFXXQDTBDJ> DeserializeCircuitsJunctionAsyncDelegate(SCQFSPRNDPD circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<FXFXXQDTBDJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public IOTRLMYDZSC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public SCQFSPRNDPD circuitsManager;

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
			private TaskAwaiter<FXFXXQDTBDJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B12900", Offset = "0x2B11D00", VA = "0x182B12900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B12B00", Offset = "0x2B11F00", VA = "0x182B12B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate YUZMUYUTUQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly LifecycleDidInitializeDelegate? IHCDKKHFRUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly LifecycleWillDestroyDelegate? YZZTPEZQOWW;

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F100", Offset = "0x2B0E500", VA = "0x182B0F100", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<FXFXXQDTBDJ> VKFPPDLQNNM(SCQFSPRNDPD a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
		public void XCWICRNSSVE(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x10007F0", Offset = "0xFFFBF0", VA = "0x1810007F0", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x10984D0", Offset = "0x10978D0", VA = "0x1810984D0", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F270", Offset = "0x2B0E670", VA = "0x182B0F270")]
		public IOTRLMYDZSC([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class PJVVJKTECPS : MRKIPKACQWY.TVWXLXTXIIP
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate YCULPWATBNY GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<AGCAQUBJINY> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<KWFNBZIYXRE> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<MRKIPKACQWY.TVWXLXTXIIP.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<MRKIPKACQWY.TVWXLXTXIIP.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public PJVVJKTECPS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter<MRKIPKACQWY.TVWXLXTXIIP.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B12B70", Offset = "0x2B11F70", VA = "0x182B12B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B12D60", Offset = "0x2B12160", VA = "0x182B12D60", Slot = "5")]
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
			public AsyncTaskMethodBuilder<KWFNBZIYXRE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public PJVVJKTECPS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			private TaskAwaiter<KWFNBZIYXRE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B12DD0", Offset = "0x2B121D0", VA = "0x182B12DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B12FC0", Offset = "0x2B123C0", VA = "0x182B12FC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<AGCAQUBJINY> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public PJVVJKTECPS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private TaskAwaiter<AGCAQUBJINY> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B13030", Offset = "0x2B12430", VA = "0x182B13030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B13220", Offset = "0x2B12620", VA = "0x182B13220", Slot = "5")]
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
			public PJVVJKTECPS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B13290", Offset = "0x2B12690", VA = "0x182B13290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B13480", Offset = "0x2B12880", VA = "0x182B13480", Slot = "5")]
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
			public PJVVJKTECPS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B134F0", Offset = "0x2B128F0", VA = "0x182B134F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B136E0", Offset = "0x2B12AE0", VA = "0x182B136E0", Slot = "5")]
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
			public PJVVJKTECPS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B13750", Offset = "0x2B12B50", VA = "0x182B13750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B13940", Offset = "0x2B12D40", VA = "0x182B13940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetCV2DependenciesDelegate KHNUQKYWSBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomDataAsyncDelegate QGUHGGSIBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetSuperRoomDataAsyncDelegate CICNAGSUTSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetRoomAssetDataAsyncDelegate WWSOEIRWKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetPlayerSaveDataAsyncDelegate TWGRKQRIUJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate CVNQJNGVOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly GetStaticCircuitsConfigAsyncDelegate KKIFFKVMAYM;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public YCULPWATBNY YCULPWATBNY
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x12B7D60", Offset = "0x12B7160", VA = "0x1812B7D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B11850", Offset = "0x2B10C50", VA = "0x182B11850", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> EYVMOXETNRF(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B11A70", Offset = "0x2B10E70", VA = "0x182B11A70", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> GASTZJKRRTY(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B11960", Offset = "0x2B10D60", VA = "0x182B11960", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<AGCAQUBJINY> FTGJZLWEYWN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B11740", Offset = "0x2B10B40", VA = "0x182B11740", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<KWFNBZIYXRE> DELLMRPYBPA(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B11B80", Offset = "0x2B10F80", VA = "0x182B11B80", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<MRKIPKACQWY.TVWXLXTXIIP.CircuitGraphToolMapping> GVQDTUPMPYH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C90", Offset = "0x2B11090", VA = "0x182B11C90", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> RFHWXQJHTKK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B11DA0", Offset = "0x2B111A0", VA = "0x182B11DA0")]
		public PJVVJKTECPS(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class TAXABRZCHWE : CV2Request.TVWXLXTXIIP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly CV2Request.TVWXLXTXIIP LDHSFMFGGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly GetCanSendRequestsDelegate OFMEIGHKLVC;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public TAXABRZCHWE(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x12B7D60", Offset = "0x12B7160", VA = "0x1812B7D60", Slot = "4")]
		public bool ARPSZOJKKGU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class ORFSXRGRWJV : IKBVPHFPXCS
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, FWOTOTOBXEY> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly TryReportErrToUserDelegate NYQJNQJPZYY;

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2B10C20", Offset = "0x2B10020", VA = "0x182B10C20")]
		public bool EPWKVWMGEBE([In] Result<None, FWOTOTOBXEY> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2B11530", Offset = "0x2B10930", VA = "0x182B11530")]
		public ORFSXRGRWJV([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2B10C20", Offset = "0x2B10020", VA = "0x182B10C20", Slot = "4")]
		private bool ZPFQIYLPMAZ([In] Result<None, FWOTOTOBXEY> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class ENFLNHJOAZE : WFYONVKPUQH
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate ZGJZLOXSVLX CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly ENFLNHJOAZE LDHSFMFGGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CurrentExecParamsDelegate? DEOXCMZSLWE;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public ZGJZLOXSVLX CZOLNAMGODK
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x12B7D60", Offset = "0x12B7160", VA = "0x1812B7D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public ENFLNHJOAZE([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class YXRTBYTRZJK : VRZNIJEJJRF
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly VRZNIJEJJRF LDHSFMFGGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly GetGameColorFromIdDelegate ADGXBKHJNKI;

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2B10C20", Offset = "0x2B10020", VA = "0x182B10C20", Slot = "4")]
		public CircuitsColor KVBXYIIWLEC(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2B17850", Offset = "0x2B16C50", VA = "0x182B17850")]
		public YXRTBYTRZJK([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class FHTILUWWVWE : PBRLRHMSVSH
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
			public FHTILUWWVWE <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x2B139B0", Offset = "0x2B12DB0", VA = "0x182B139B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x2B13BA0", Offset = "0x2B12FA0", VA = "0x182B13BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly IsStringPureAsyncDelegate NHBDDQDZPIL;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EC60", Offset = "0x2B0E060", VA = "0x182B0EC60", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> HMVXOFBXMOL(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EDA0", Offset = "0x2B0E1A0", VA = "0x182B0EDA0")]
		public FHTILUWWVWE([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class NDXTRFJYVWS : EXVISPQHAEV
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate SKJGKTEEOIF? GetNodeVisualizationConfigDelegate([In] Id128<VOUYFSSRGER> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly EXVISPQHAEV LDHSFMFGGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly GetNodeVisualizationConfigDelegate DKDTNXEOBDY;

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2B10C20", Offset = "0x2B10020", VA = "0x182B10C20")]
		public SKJGKTEEOIF? VGECUOROSXG([In] Id128<VOUYFSSRGER> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2B10CC0", Offset = "0x2B100C0", VA = "0x182B10CC0")]
		public NDXTRFJYVWS([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2B10C20", Offset = "0x2B10020", VA = "0x182B10C20", Slot = "4")]
		private SKJGKTEEOIF OODCGMEDJUQ([In] Id128<VOUYFSSRGER> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class ZGXQFMZHBQF : UOFJVIBRITC
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2B179F0", Offset = "0x2B16DF0", VA = "0x182B179F0", Slot = "4")]
		public RXPKFMSOGUZ HHKNBOETJRD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public ZGXQFMZHBQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class ODODXSERTZN : PINDEHVTQDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, bool> VOXSUZWNKQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, float> RUCXBATHPTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, double> YHSRPTIMMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, int> FOJRFZAIIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, long> ECNWAAPLWXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, string> DDWXQPNYGXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly Dictionary<string, uint> DZNGLJOJZVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly Dictionary<string, ulong> PYDLWHHCLAN;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2B11220", Offset = "0x2B10620", VA = "0x182B11220", Slot = "4")]
		public bool? BDTXOXSSQAG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2B112C0", Offset = "0x2B106C0", VA = "0x182B112C0")]
		public ODODXSERTZN()
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
