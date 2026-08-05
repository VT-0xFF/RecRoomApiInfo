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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A9F1C0", Offset = "0x2A9DFC0", VA = "0x182A9F1C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
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
		internal sealed class PCGGWIGHCYF : IAFQQJCFIIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public PCGGWIGHCYF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30", Slot = "4")]
			public IAFQQJCFIIQ SMOJGMTZJOC(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30", Slot = "5")]
			public IAFQQJCFIIQ CVJOVUFXROJ(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30", Slot = "6")]
			public IAFQQJCFIIQ BOSXNBAHSGV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
			public void PKVJCOOHHUA()
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
	public static class MGTUQBNEHCY
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OMGLYBCUARB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public NKDETYEKGDX IHWNUXKTNKW;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OMGLYBCUARB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2A9F240", Offset = "0x2A9E040", VA = "0x182A9F240")]
			internal AOAGTNJJCPD JBNATIITCYF(GetNetworkObjectDelegate a)
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
			public RAMVABNVEDJ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public FUAZHRRWMOY network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public RegistryV2? registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2AA45A0", Offset = "0x2AA33A0", VA = "0x182AA45A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4C40", Offset = "0x2AA3A40", VA = "0x182AA4C40", Slot = "5")]
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
			public FUAZHRRWMOY network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public RAMVABNVEDJ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<FQTHCTXUYZW>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private RGZHVGRSJVI <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4CB0", Offset = "0x2AA3AB0", VA = "0x182AA4CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5240", Offset = "0x2AA4040", VA = "0x182AA5240", Slot = "5")]
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
			public NKDETYEKGDX roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2AA52B0", Offset = "0x2AA40B0", VA = "0x182AA52B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AA57C0", Offset = "0x2AA45C0", VA = "0x182AA57C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DB80", Offset = "0x2A9C980", VA = "0x182A9DB80")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? RIULQKFLMJR([Optional] NKDETYEKGDX? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DC70", Offset = "0x2A9CA70", VA = "0x182A9DC70")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> WOOXFJKRHJK(FUAZHRRWMOY a, [Optional] RAMVABNVEDJ? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DDF0", Offset = "0x2A9CBF0", VA = "0x182A9DDF0")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> WOOXFJKRHJK(FUAZHRRWMOY a, RAMVABNVEDJ b, RegistryV2 c, Id32<FQTHCTXUYZW>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DAB0", Offset = "0x2A9C8B0", VA = "0x182A9DAB0")]
		public static (RuntimeFnRegistry, RuntimeFns) MIEJJENGFOC()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D9B0", Offset = "0x2A9C7B0", VA = "0x182A9D9B0")]
		public static (ExternalFnRegistry, ExternalFns) CLBVTBNNLHV()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D930", Offset = "0x2A9C730", VA = "0x182A9D930")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static FUAZHRRWMOY BRUEOZBKULG(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class GDBIXNSTADC
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate AOAGTNJJCPD CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public GDBIXNSTADC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA41B0", Offset = "0x2AA2FB0", VA = "0x182AA41B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA4530", Offset = "0x2AA3330", VA = "0x182AA4530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly FUAZHRRWMOY ALTEGBUKXCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? KADVECMBIBA;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		private GDBIXNSTADC(FUAZHRRWMOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2A97910", Offset = "0x2A96710", VA = "0x182A97910")]
		public static GDBIXNSTADC VHMWPQEADTW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A97800", Offset = "0x2A96600", VA = "0x182A97800")]
		public GDBIXNSTADC FDAUQTLZMIZ(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A97820", Offset = "0x2A96620", VA = "0x182A97820")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> PKVJCOOHHUA()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class MKIKBOZUQBE : RGZHVGRSJVI.XQEIROEEFNO
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate YLCKUADMMIO NewCircuitsLifecycleDelegate(IYEHCMGHYUZ.XQEIROEEFNO deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(RGZHVGRSJVI circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(RGZHVGRSJVI circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate SHXOFXYWJSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate URYKYXCMLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate YDAJDJEPPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate UYHXSLWYJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate JZGRMVRAOQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate YVUFIYOBHGX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int NVRXHSLURFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x12EECA0", Offset = "0x12EDAA0", VA = "0x1812EECA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E8E0", Offset = "0x2A9D6E0", VA = "0x182A9E8E0", Slot = "6")]
		public void ULQWPKIHUFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E8B0", Offset = "0x2A9D6B0", VA = "0x182A9E8B0", Slot = "7")]
		public void SISLSPZBEQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E880", Offset = "0x2A9D680", VA = "0x182A9E880", Slot = "5")]
		public YLCKUADMMIO LOCWXVVXXZL(IYEHCMGHYUZ.XQEIROEEFNO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF797E0", Offset = "0xF785E0", VA = "0x180F797E0", Slot = "8")]
		public void ZXNAZMLQOPY(RGZHVGRSJVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF796F0", Offset = "0xF784F0", VA = "0x180F796F0", Slot = "9")]
		public void LUOTZGKBHFN(RGZHVGRSJVI a, ELPAQFNEADX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E910", Offset = "0x2A9D710", VA = "0x182A9E910")]
		public MKIKBOZUQBE([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly KQGQLMLRMCJ<FUAZHRRWMOY, FUAZHRRWMOY.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly JSYUJENUFLH<FUAZHRRWMOY, FUAZHRRWMOY.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly RGZHVGRSJVI CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<VCZWSUVCRXV> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly FUAZHRRWMOY Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2A97790", Offset = "0x2A96590", VA = "0x182A97790")]
		public EVCreationResult(KQGQLMLRMCJ<FUAZHRRWMOY, FUAZHRRWMOY.MockStaticNetSysDeps> staticNetSys, JSYUJENUFLH<FUAZHRRWMOY, FUAZHRRWMOY.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, RGZHVGRSJVI circuitsManager, Id32<VCZWSUVCRXV> clientId, FUAZHRRWMOY network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly RGZHVGRSJVI _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 GGYAKSZLNPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2A9D800", Offset = "0x2A9C600", VA = "0x182A9D800")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request TLBNIVDFOCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2A9D7D0", Offset = "0x2A9C5D0", VA = "0x182A9D7D0")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public QJDKMJZUZXH? GELCCBWDGVO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2A9D830", Offset = "0x2A9C630", VA = "0x182A9D830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public PPOKMLHFENR? AISMQWVGLVE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2A9D770", Offset = "0x2A9C570", VA = "0x182A9D770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		internal LimitedCircuits(RGZHVGRSJVI circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class MJMNEJTYEFS : RAMVABNVEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LUVYHIUWUHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AOAGTNJJCPD RSDDWQYQNND;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public LUVYHIUWUHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			internal AOAGTNJJCPD WXSBYOKGRQD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IYEHCMGHYUZ.XQEIROEEFNO UGWZVGLBOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RGZHVGRSJVI.XQEIROEEFNO FKKGLUKMDTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HHBELIZAZTL.XQEIROEEFNO NJIXVJOPWFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI> QBILVALNXRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.XQEIROEEFNO IWVMVGFINXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HBKJLPUCFON RGEYZGDJYUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public YTSHAVYTUSY HAFZOOZMFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public SKHEHGRSHLY PERFJBHOVYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ZPSEWEXFJLQ VOHNTVXESAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA19A0", Offset = "0xAA07A0", VA = "0x180AA19A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EAPBZKKMHYU TNXCLFCQOXN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAA1950", Offset = "0xAA0750", VA = "0x180AA1950", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E790", Offset = "0x2A9D590", VA = "0x182A9E790")]
		private MJMNEJTYEFS(IYEHCMGHYUZ.XQEIROEEFNO a, RGZHVGRSJVI.XQEIROEEFNO b, HHBELIZAZTL.XQEIROEEFNO c, MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI> d, CV2Request.XQEIROEEFNO e, HBKJLPUCFON f, YTSHAVYTUSY g, SKHEHGRSHLY h, ZPSEWEXFJLQ i, EAPBZKKMHYU j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DF80", Offset = "0x2A9CD80", VA = "0x182A9DF80")]
		public static MJMNEJTYEFS? FFMPVEDIBUP(HHBELIZAZTL.XQEIROEEFNO cv2RootSysDeps, [Optional] IYEHCMGHYUZ.XQEIROEEFNO? a, [Optional] RGZHVGRSJVI.XQEIROEEFNO? b, [Optional] MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>? reducerDeps, [Optional] CV2Request.XQEIROEEFNO? c, [Optional] HBKJLPUCFON? d, [Optional] YTSHAVYTUSY? e, [Optional] SKHEHGRSHLY? f, [Optional] ZPSEWEXFJLQ? g, [Optional] EAPBZKKMHYU? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E2E0", Offset = "0x2A9D0E0", VA = "0x182A9E2E0")]
		public static MJMNEJTYEFS NIFYFRFPGEF(AOAGTNJJCPD a, [Optional] IYEHCMGHYUZ.XQEIROEEFNO? circuitsLifecycleDeps, [Optional] RGZHVGRSJVI.XQEIROEEFNO? circuitsManagerDeps, [Optional] MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E430", Offset = "0x2A9D230", VA = "0x182A9E430")]
		public static MJMNEJTYEFS VWFZTLGOSDP(GetNetworkObjectDelegate a, [Optional] IYEHCMGHYUZ.XQEIROEEFNO? circuitsLifecycleDeps, [Optional] RGZHVGRSJVI.XQEIROEEFNO? circuitsManagerDeps, [Optional] MKJSBIXJUZX.YUERGOQQINL<ActionKind, ELPAQFNEADX, RGZHVGRSJVI>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class LTHYRPHFPIZ
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class JSZUEIUUAJQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public GetNetworkObjectDelegate PFWBPBFSPIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int ALIAKZWYRKF;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public JSZUEIUUAJQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2A98AD0", Offset = "0x2A978D0", VA = "0x182A98AD0")]
			internal GEIPSZYFMAS SLJUAFVJVWB(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2A98970", Offset = "0x2A97770", VA = "0x182A98970")]
			internal GEIPSZYFMAS[] SLENCZBMMKS(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10")]
			internal int DOAIIXELQWS()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JTFBBPORJUZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public DynamicEnvironmentNetworkId VWXZKLOWJFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public JSZUEIUUAJQ JOWOLGJKVOM;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public JTFBBPORJUZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2A98B40", Offset = "0x2A97940", VA = "0x182A98B40")]
			internal GEIPSZYFMAS KOGZNBYTNSJ(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly MJLOQDUEBTO LEXTTDTLKYN;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2A993C0", Offset = "0x2A981C0", VA = "0x182A993C0")]
		public static GEIPSZYFMAS? TQOGPDUQZFX(Id32<FQTHCTXUYZW>? networkObject, [Optional] KOYIFDBSPMJ.SerializesIntoSavesDelegate? a, [Optional] KOYIFDBSPMJ.SerializesIntoInventionsDelegate? b, [Optional] KOYIFDBSPMJ.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2A993E0", Offset = "0x2A981E0", VA = "0x182A993E0")]
		public static AOAGTNJJCPD? WPMRPZQJDZW(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] BKLHYEYAHLO? b, [Optional] GQGXZCBZHPM? c, [Optional] IBYWUVTLRZW? d, [Optional] NKDETYEKGDX? e, int f = 300000, bool g = false, bool h = false, [Optional] GJSQFSXWHJY? i, [Optional] RJJOFDQNFJQ? j, [Optional] ILDSMOHFGPD? k, [Optional] JIIWDVUBBOQ? l, [Optional] AZYTASPKQMR? m, [Optional] FQHTLHNTUOQ? n, [Optional] WULNELQMSYI.XQEIROEEFNO? o, [Optional] EqualsNodeV2.XQEIROEEFNO? p, [Optional] HRFRXWTKTMO? q, [Optional] AOAGTNJJCPD.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] AOAGTNJJCPD.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] AOAGTNJJCPD.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] AOAGTNJJCPD.GetLocalRoomIdDelegate? u, [Optional] AOAGTNJJCPD.GetLocalSubroomIdDelegate? v, [Optional] AOAGTNJJCPD.GetSubroomIdsForLocalRoomDelegate? w, [Optional] AOAGTNJJCPD.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] AOAGTNJJCPD.SaveRoomOnPlayerBehalfDelegate? z, [Optional] AOAGTNJJCPD.ReportCloudDataLedgerChangedDelegate? ba, [Optional] AOAGTNJJCPD.GetColorNameByIdDelegate? bb, [Optional] AOAGTNJJCPD.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] AOAGTNJJCPD.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] AOAGTNJJCPD.GetTaggableNameFromSignalDelegate? be, [Optional] AOAGTNJJCPD.GetAudioNameFromSignalDelegate? bf, [Optional] AOAGTNJJCPD.GetDestinationNameFromSignalDelegate? bg, [Optional] AOAGTNJJCPD.GetPlayerEventNameFromSignalDelegate? bh, [Optional] AOAGTNJJCPD.GetRoomKeyNameFromSignalDelegate? bi, [Optional] AOAGTNJJCPD.GetRewardNameFromSignalDelegate? bj, [Optional] AOAGTNJJCPD.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] AOAGTNJJCPD.ReportPreloadedAudioChangedDelegate? bl, [Optional] AOAGTNJJCPD.ReportRewardDataChangedDelegate? bm, [Optional] AOAGTNJJCPD.GetConsumableNameFromSignalDelegate? bn, [Optional] AOAGTNJJCPD.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] AOAGTNJJCPD.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] AOAGTNJJCPD.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] AOAGTNJJCPD.GetInventoryItemNameFromSignalDelegate? br, [Optional] AOAGTNJJCPD.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] AOAGTNJJCPD.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] AOAGTNJJCPD.GetRoomOfferNameFromSignalDelegate? bu, [Optional] AOAGTNJJCPD.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] AOAGTNJJCPD.GetObjectIdFromCreationObjectDelegate? bw, [Optional] AOAGTNJJCPD.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] AOAGTNJJCPD.GetCostInBytesDelegate? by, [Optional] AOAGTNJJCPD.GetAvatarItemNameFromSignalDelegate? bz, [Optional] AOAGTNJJCPD.PersistenceViewExistsAsReplicatorWithGraphDelegate? ca, [Optional] AOAGTNJJCPD.DownloadCircuitTemplateRootDataDelegate? cb, [Optional] AOAGTNJJCPD.GetDiscoverySectionNameFromSignalDelegate? cc, [Optional] AOAGTNJJCPD.GetStoreItemNameFromSignalDelegate? cd, [Optional] AOAGTNJJCPD.GetBodyPartNameFromSignalDelegate? ce, [Optional] AOAGTNJJCPD.GetDependenciesForGraphInstanceDelegate? cf, [Optional] AOAGTNJJCPD.GetAllDependenciesForEnvironmentDelegate? cg, [Optional] AOAGTNJJCPD.GetPlayerAccountNameFromSignalDelegate? ch, [Optional] AOAGTNJJCPD.GetRecNetImageNameFromSignalDelegate? ci, [Optional] AOAGTNJJCPD.GetRecNetMeshNameFromSignalDelegate? cj, [Optional] LogDeps? ck, [Optional] AOAGTNJJCPD.IsFunctionValidForAIDelegate? cl, [Optional] AOAGTNJJCPD.GetAIFunctionNameFromSignalDelegate? cm)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<FQTHCTXUYZW>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class TKRJUYYHFSK : ILDSMOHFGPD
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly TKRJUYYHFSK VDCQJFYBFAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly GetLocalPlayerDelegate? QMLMVRHKABH;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3FE0", Offset = "0x2AA2DE0", VA = "0x182AA3FE0", Slot = "4")]
		public (WUEKFRIYKZO, WUEKFRIYKZO, WUEKFRIYKZO, WUEKFRIYKZO, WUEKFRIYKZO) XZZCYXXIHMM(object a)
		{
			return default((WUEKFRIYKZO, WUEKFRIYKZO, WUEKFRIYKZO, WUEKFRIYKZO, WUEKFRIYKZO));
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3FB0", Offset = "0x2AA2DB0", VA = "0x182AA3FB0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "6")]
		public bool DMCQXHZTXXV(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAFD970", Offset = "0xAFC770", VA = "0x180AFD970", Slot = "7")]
		public string KOYROKBXKQT(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public TKRJUYYHFSK([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class KOYIFDBSPMJ : GEIPSZYFMAS
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(KOYIFDBSPMJ self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(KOYIFDBSPMJ self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(KOYIFDBSPMJ self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly SerializesIntoSavesDelegate IXRDGTYGAPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoInventionsDelegate VKERWZCGJNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly CanPublishInInventionsDelegate OQQPNJVHPGW;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private XGYJBZLUAMG? WKDWGPYECYC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId IRFPHVVZMHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x102C9A0", Offset = "0x102B7A0", VA = "0x18102C9A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool QATCVHSOZSM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2A99310", Offset = "0x2A98110", VA = "0x182A99310", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool CCZPFNTATPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2A992E0", Offset = "0x2A980E0", VA = "0x182A992E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool DASSMPRZQNQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A992B0", Offset = "0x2A980B0", VA = "0x182A992B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BGZBAHXKGWF? MPVWFZFDYKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<FQTHCTXUYZW>? GLSESCLAVEY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A99160", Offset = "0x2A97F60", VA = "0x182A99160", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A98BF0", Offset = "0x2A979F0", VA = "0x182A98BF0", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(MJLOQDUEBTO e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0", Slot = "13")]
		public void Bind(XGYJBZLUAMG controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A99200", Offset = "0x2A98000", VA = "0x182A99200")]
		private KOYIFDBSPMJ(Id32<FQTHCTXUYZW>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A98C90", Offset = "0x2A97A90", VA = "0x182A98C90")]
		public static KOYIFDBSPMJ? New(Id32<FQTHCTXUYZW>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SWBCQHREMSJ : GJSQFSXWHJY
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
		public static readonly SWBCQHREMSJ VDCQJFYBFAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly RoundToDecimalPlaceDelegate? NVWIGKEZDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly TruncateToDecimalPlaceDelegate? XODHRRGOGQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly CircuitsColorLerpDelegate? PKYIMTDOWDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorInverseLerpDelegate? EHQEYLYYNXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsMtx4x4GetPositionDelegate? QZNIXYZEIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetRotationDelegate? RYLVGMDXXUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4InverseDelegate? HLUXBDHFXKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4MultiplyDelegate? UYWGPEOTOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? CEEKOOAKATE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsQuatDotDelegate? EUTXBNJOIZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatFromAngleAxisDelegate? UHQUPEZHORV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? TQKLZOGOSPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromFromToRotationDelegate? ZOFANZZUQTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromLookRotationDelegate? JJZSYDMUHUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? RVNPEODOOGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatInverseDelegate? UQJOIXPJRYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatLerpDelegate? OJROCVAEVTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpUnclampedDelegate? DXBPFGBTWTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseLerpDelegate? WWEMBWCPGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatMultiplyDelegate? QPEUOTKFWUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatNormalizeDelegate? GYLOCUIXYGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatRotateTowardsDelegate? TSLUGGJUOMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateVectorDelegate? GTRHSSZFVHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatSlerpDelegate? FERCBYJLELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatToAngleAxisDelegate? NAWJOOFCCQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToEulerAnglesDelegate? RUVWZZCQJXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsVec3AddDelegate? WHPYGSTRCAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? LJIKAYIJAQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? XKZUAGMYELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3CrossDelegate? WLDWPDBCHUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3DotDelegate? PJJQDXPWOYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3AngleDelegate? FGSJKANRYLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3GetMagnitudeDelegate? KJOEVMPMTZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3LerpDelegate? XHKNVIIRQOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpUnclampedDelegate? ELDYZGJYLVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3InverseLerpDelegate? TAGYANYIJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3MoveTowardsDelegate? LJTGPMXHZBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3NegateDelegate? PAEDBWQPDXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NormalizeDelegate? BSCIDVPTLYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3ProjectDelegate? JPPVXMTEJBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? EOYXMZMDRAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ScaleDelegate? CFGNHGCZGSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3SmoothDampDelegate? FJARBGEGIUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SubtractDelegate? RFQILELBPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SlerpDelegate? MJDAOMLYUYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3TransformDelegate? TOTBSFGBNPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3InverseTransformDelegate? FWYXTZKETRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly RealtimeSinceStartupDelegate? BSMLUHWNNTQ;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3AD0", Offset = "0x2AA28D0", VA = "0x182AA3AD0")]
		public SWBCQHREMSJ([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1F20", Offset = "0x2AA0D20", VA = "0x182AA1F20")]
		public float ERDBREJALWK([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1E20", Offset = "0x2AA0C20", VA = "0x182AA1E20")]
		public float DQAHJGBRPYG([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2A10", Offset = "0x2AA1810", VA = "0x182AA2A10")]
		public CircuitsColor KHDPQULHEOH([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1D80", Offset = "0x2AA0B80", VA = "0x182AA1D80")]
		public float SPDVHNKXCUT([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA24F0", Offset = "0x2AA12F0", VA = "0x182AA24F0")]
		public CircuitsVec3 IEJDLLDXBIZ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA32F0", Offset = "0x2AA20F0", VA = "0x182AA32F0")]
		public CircuitsQuat TJAUDMTEAEA([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1A50", Offset = "0x2AA0850", VA = "0x182AA1A50")]
		public CircuitsMtx4x4 AKQTNFQYQWC([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3890", Offset = "0x2AA2690", VA = "0x182AA3890")]
		public CircuitsMtx4x4 ZYFIVKTQAFU([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA23C0", Offset = "0x2AA11C0", VA = "0x182AA23C0")]
		public CircuitsMtx4x4 ICXAQXVNMCK([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2890", Offset = "0x2AA1690", VA = "0x182AA2890")]
		public float OSFUIVCEAUH([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3150", Offset = "0x2AA1F50", VA = "0x182AA3150")]
		public CircuitsQuat ZVHJXJUTZOO(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1F40", Offset = "0x2AA0D40", VA = "0x182AA1F40")]
		public CircuitsQuat HNEFCZGVHZH([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2E80", Offset = "0x2AA1C80", VA = "0x182AA2E80")]
		public CircuitsQuat WBRAHOFYDKT([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3340", Offset = "0x2AA2140", VA = "0x182AA3340")]
		public CircuitsQuat TKTLFMMZVEB([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA28B0", Offset = "0x2AA16B0", VA = "0x182AA28B0")]
		public CircuitsQuat JXSLWETFTRW([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA21C0", Offset = "0x2AA0FC0", VA = "0x182AA21C0")]
		public CircuitsQuat HDLYHDPVVAV([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2430", Offset = "0x2AA1230", VA = "0x182AA2430")]
		public CircuitsQuat IDIGWVBMCVK([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3600", Offset = "0x2AA2400", VA = "0x182AA3600")]
		public float ZHLOLCZMXVP([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1B30", Offset = "0x2AA0930", VA = "0x182AA1B30")]
		public CircuitsQuat ATXPQXBAZWI([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA26A0", Offset = "0x2AA14A0", VA = "0x182AA26A0")]
		public CircuitsQuat JCOKEFXWUTV([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2950", Offset = "0x2AA1750", VA = "0x182AA2950")]
		public CircuitsQuat SLZUJNYUEIF([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA22E0", Offset = "0x2AA10E0", VA = "0x182AA22E0")]
		public CircuitsVec3 HMGMGOTHEWA([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2F30", Offset = "0x2AA1D30", VA = "0x182AA2F30")]
		public CircuitsQuat RMPPHJXLJSE([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2A70", Offset = "0x2AA1870", VA = "0x182AA2A70")]
		public void KWPCGHXAYTP([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2AB0", Offset = "0x2AA18B0", VA = "0x182AA2AB0")]
		public CircuitsVec3 KZJLNPTIEVY([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2C40", Offset = "0x2AA1A40", VA = "0x182AA2C40")]
		public CircuitsVec3 MSWCTSZGWCH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1980", Offset = "0x2AA0780", VA = "0x182AA1980")]
		public CircuitsVec3 ABGKUHELPTZ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1DB0", Offset = "0x2AA0BB0", VA = "0x182AA1DB0")]
		public CircuitsVec3 DBDQGQKFEYQ([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA27B0", Offset = "0x2AA15B0", VA = "0x182AA27B0")]
		public CircuitsVec3 JJDAQFBBGRO([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA20B0", Offset = "0x2AA0EB0", VA = "0x182AA20B0")]
		public float FSRWACXZDML([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1F00", Offset = "0x2AA0D00", VA = "0x182AA1F00")]
		public float EMZCIIWWGDN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2130", Offset = "0x2AA0F30", VA = "0x182AA2130")]
		public float GWJYZJCVHTY([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1AC0", Offset = "0x2AA08C0", VA = "0x182AA1AC0")]
		public CircuitsVec3 ATBNDRSTJMV([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2FF0", Offset = "0x2AA1DF0", VA = "0x182AA2FF0")]
		public CircuitsVec3 RNUPLAHKBYY([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3120", Offset = "0x2AA1F20", VA = "0x182AA3120")]
		public float UQFMFPMALGN([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA33F0", Offset = "0x2AA21F0", VA = "0x182AA33F0")]
		public CircuitsVec3 VNEOLDFPOWD([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2D90", Offset = "0x2AA1B90", VA = "0x182AA2D90")]
		public CircuitsVec3 NHOTSTSAWAC([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1C40", Offset = "0x2AA0A40", VA = "0x182AA1C40")]
		public CircuitsVec3 BKPRDMNETUX([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3460", Offset = "0x2AA2260", VA = "0x182AA3460")]
		public CircuitsVec3 VRNRKNREQBL([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2630", Offset = "0x2AA1430", VA = "0x182AA2630")]
		public CircuitsVec3 IMICHVMBBQW([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1FE0", Offset = "0x2AA0DE0", VA = "0x182AA1FE0")]
		public CircuitsVec3 EYIOCCBKIGW([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3700", Offset = "0x2AA2500", VA = "0x182AA3700")]
		public CircuitsVec3 YHHBSGUQZZC([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1E90", Offset = "0x2AA0C90", VA = "0x182AA1E90")]
		public CircuitsVec3 EAKMTXUKKIE([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1D10", Offset = "0x2AA0B10", VA = "0x182AA1D10")]
		public CircuitsVec3 COXIMTSDYLG([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2820", Offset = "0x2AA1620", VA = "0x182AA2820")]
		public CircuitsVec3 JRYTSUWHWQM([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3630", Offset = "0x2AA2430", VA = "0x182AA3630")]
		public CircuitsVec3 YCKVMKTVHQU([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA32C0", Offset = "0x2AA20C0", VA = "0x182AA32C0", Slot = "50")]
		public Task THHBFCVNSRS(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "51")]
		public void NWODIZSCJII([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1E40", Offset = "0x2AA0C40", VA = "0x182AA1E40", Slot = "52")]
		public RSUANDFJWHW DYHVPDQGJBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3060", Offset = "0x2AA1E60", VA = "0x182AA3060", Slot = "53")]
		public RSUANDFJWHW RPEXFJNMMWP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2DF0", Offset = "0x2AA1BF0", VA = "0x182AA2DF0", Slot = "54")]
		public float OWEWNXAEKFL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1F20", Offset = "0x2AA0D20", VA = "0x182AA1F20", Slot = "4")]
		private float MBTWBFIVOXW([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1E20", Offset = "0x2AA0C20", VA = "0x182AA1E20", Slot = "5")]
		private float VJYXOZMQZUM([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3200", Offset = "0x2AA2000", VA = "0x182AA3200", Slot = "6")]
		private CircuitsColor SRLQXUMWBHH([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1D80", Offset = "0x2AA0B80", VA = "0x182AA1D80", Slot = "7")]
		private float CUTMWYXCIGR([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA19F0", Offset = "0x2AA07F0", VA = "0x182AA19F0", Slot = "8")]
		private CircuitsVec3 AIQLVGMXFFV([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA34D0", Offset = "0x2AA22D0", VA = "0x182AA34D0", Slot = "9")]
		private CircuitsQuat VVGAOHRQKDA([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2280", Offset = "0x2AA1080", VA = "0x182AA2280", Slot = "10")]
		private CircuitsMtx4x4 HICSZLAUJEM([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA36A0", Offset = "0x2AA24A0", VA = "0x182AA36A0", Slot = "11")]
		private CircuitsMtx4x4 YETVDLLALZW([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1BE0", Offset = "0x2AA09E0", VA = "0x182AA1BE0", Slot = "12")]
		private CircuitsMtx4x4 BGCGUSRSDMM([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2890", Offset = "0x2AA1690", VA = "0x182AA2890", Slot = "13")]
		private float JXGDUVZYEEN([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3150", Offset = "0x2AA1F50", VA = "0x182AA3150", Slot = "14")]
		private CircuitsQuat SLRSVYZASTC(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1F40", Offset = "0x2AA0D40", VA = "0x182AA1F40", Slot = "15")]
		private CircuitsQuat EWCSHLJPUGX([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2E80", Offset = "0x2AA1C80", VA = "0x182AA2E80", Slot = "16")]
		private CircuitsQuat QNDBRFKYBGN([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3340", Offset = "0x2AA2140", VA = "0x182AA3340", Slot = "17")]
		private CircuitsQuat XWVFCGWVXGL([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2AA28B0", Offset = "0x2AA16B0", VA = "0x182AA28B0", Slot = "18")]
		private CircuitsQuat NYIRCCYQGEO([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2AA21C0", Offset = "0x2AA0FC0", VA = "0x182AA21C0", Slot = "19")]
		private CircuitsQuat JUAJVDDXEOP([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2430", Offset = "0x2AA1230", VA = "0x182AA2430", Slot = "20")]
		private CircuitsQuat RIKLEEZSBCS([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3600", Offset = "0x2AA2400", VA = "0x182AA3600", Slot = "21")]
		private float XKPXQQZPKYT([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1B30", Offset = "0x2AA0930", VA = "0x182AA1B30", Slot = "22")]
		private CircuitsQuat LMRJYZXCLHU([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2AA26A0", Offset = "0x2AA14A0", VA = "0x182AA26A0", Slot = "23")]
		private CircuitsQuat KFLVNUNEESB([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2950", Offset = "0x2AA1750", VA = "0x182AA2950", Slot = "24")]
		private CircuitsQuat JYUTMXQDDXV([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2740", Offset = "0x2AA1540", VA = "0x182AA2740", Slot = "25")]
		private CircuitsVec3 JIVIMRDGBCC([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2F30", Offset = "0x2AA1D30", VA = "0x182AA2F30", Slot = "26")]
		private CircuitsQuat XLWGTRDWWEO([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2A70", Offset = "0x2AA1870", VA = "0x182AA2A70", Slot = "27")]
		private void ZFCBPSFKUIX([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2050", Offset = "0x2AA0E50", VA = "0x182AA2050", Slot = "28")]
		private CircuitsVec3 FACVCHJYHJC([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2BD0", Offset = "0x2AA19D0", VA = "0x182AA2BD0", Slot = "29")]
		private CircuitsVec3 LZMHWYWEFOJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA37B0", Offset = "0x2AA25B0", VA = "0x182AA37B0", Slot = "30")]
		private CircuitsVec3 YJQMMHEPKEJ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA30B0", Offset = "0x2AA1EB0", VA = "0x182AA30B0", Slot = "31")]
		private CircuitsVec3 RQMDUULNYDM([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3820", Offset = "0x2AA2620", VA = "0x182AA3820", Slot = "32")]
		private CircuitsVec3 ZURBPLPBIIK([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2D20", Offset = "0x2AA1B20", VA = "0x182AA2D20", Slot = "33")]
		private CircuitsVec3 NFGCVSAIOIS([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2CB0", Offset = "0x2AA1AB0", VA = "0x182AA2CB0", Slot = "34")]
		private CircuitsVec3 MVRWGLALNNE([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2AA20B0", Offset = "0x2AA0EB0", VA = "0x182AA20B0", Slot = "35")]
		private float TNEJRQASWTD([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1F00", Offset = "0x2AA0D00", VA = "0x182AA1F00", Slot = "36")]
		private float IXZRDMAZLSZ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2130", Offset = "0x2AA0F30", VA = "0x182AA2130", Slot = "37")]
		private float LTVSUMTFSPS([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2E10", Offset = "0x2AA1C10", VA = "0x182AA2E10", Slot = "38")]
		private CircuitsVec3 PFFDKDSITRB([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2150", Offset = "0x2AA0F50", VA = "0x182AA2150", Slot = "39")]
		private CircuitsVec3 GXOVEULVFNI([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3120", Offset = "0x2AA1F20", VA = "0x182AA3120", Slot = "40")]
		private float SDPNZXMILNB([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3590", Offset = "0x2AA2390", VA = "0x182AA3590", Slot = "41")]
		private CircuitsVec3 WCAPTMEZAKB([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3260", Offset = "0x2AA2060", VA = "0x182AA3260", Slot = "42")]
		private CircuitsVec3 TBPJQAMDZTK([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA20D0", Offset = "0x2AA0ED0", VA = "0x182AA20D0", Slot = "43")]
		private CircuitsVec3 GOXBZCLLYRX([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA25C0", Offset = "0x2AA13C0", VA = "0x182AA25C0", Slot = "44")]
		private CircuitsVec3 IKGAXQJUMQT([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2350", Offset = "0x2AA1150", VA = "0x182AA2350", Slot = "45")]
		private CircuitsVec3 HPMXSPLTVOI([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1CA0", Offset = "0x2AA0AA0", VA = "0x182AA1CA0", Slot = "46")]
		private CircuitsVec3 CFWHYWICRGY([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2B10", Offset = "0x2AA1910", VA = "0x182AA2B10", Slot = "47")]
		private CircuitsVec3 LWVWGYYKXTM([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2550", Offset = "0x2AA1350", VA = "0x182AA2550", Slot = "48")]
		private CircuitsVec3 IFFISVMUVZY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3520", Offset = "0x2AA2320", VA = "0x182AA3520", Slot = "49")]
		private CircuitsVec3 WBQRWPOWUHU([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class IIZAYFCIGGN : MDIDIVGEYMW
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1389BA0", Offset = "0x13889A0", VA = "0x181389BA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x21117B0", Offset = "0x21105B0", VA = "0x1821117B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2A981B0", Offset = "0x2A96FB0", VA = "0x182A981B0")]
		public IIZAYFCIGGN(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class HKPPUNDXKHT : RJJOFDQNFJQ
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(JGPDTZSNOTP e, QIYHLYOWFQM invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly HKPPUNDXKHT VDCQJFYBFAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly GetCircuitsColorFromColorIndexDelegate? VCJJERBFSOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? CUPIKWUBZLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly InvisibleCollisionSetEnabledDelegate? YKCGHPMPTHV;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xE40350", Offset = "0xE3F150", VA = "0x180E40350")]
		public HKPPUNDXKHT([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2A97D70", Offset = "0x2A96B70", VA = "0x182A97D70", Slot = "4")]
		public CircuitsColor WSGWTVGGZWR(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2A97D50", Offset = "0x2A96B50", VA = "0x182A97D50")]
		public int HQTRNRAPEMD([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2A97D50", Offset = "0x2A96B50", VA = "0x182A97D50", Slot = "5")]
		private int VZJJYMVOGCE([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class JJKOFPANBHW : FVBVRIHKWVP
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class KSMSMGIMEBH
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid DGQWDKMHVFT
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xF319E0", Offset = "0xF307E0", VA = "0x180F319E0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long TLEMNHZFUJY
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int AWVAIUEIXUY
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7120", Offset = "0xAA5F20", VA = "0x180AA7120")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool EDXJWRTAKHL
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x1B27120", Offset = "0x1B25F20", VA = "0x181B27120")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool HQUCWQGUQYT
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x1B27400", Offset = "0x1B26200", VA = "0x181B27400")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool BIVXUICHECY
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x2A99340", Offset = "0x2A98140", VA = "0x182A99340")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A99360", Offset = "0x2A98160", VA = "0x182A99360")]
			public KSMSMGIMEBH(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Dictionary<Id128<LQPAJNJDNAW>, KSMSMGIMEBH> EURRTBTZXAQ;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2A984B0", Offset = "0x2A972B0", VA = "0x182A984B0")]
		public bool ETIRFBUDUFH([In] Id128<LQPAJNJDNAW> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2A98820", Offset = "0x2A97620", VA = "0x182A98820")]
		public void MIHDKTPRMTH([In] Id128<LQPAJNJDNAW> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2A98740", Offset = "0x2A97540", VA = "0x182A98740")]
		public void MIHDKTPRMTH([In] Id128<LQPAJNJDNAW> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2A985C0", Offset = "0x2A973C0", VA = "0x182A985C0")]
		public void FLCQGMPMCHO([In] Id128<LQPAJNJDNAW> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2A986E0", Offset = "0x2A974E0", VA = "0x182A986E0")]
		public void TJDBTRQPKOP([In] Id128<LQPAJNJDNAW> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2A98420", Offset = "0x2A97220", VA = "0x182A98420")]
		public bool EDXJWRTAKHL([In] Id128<LQPAJNJDNAW> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2A988F0", Offset = "0x2A976F0", VA = "0x182A988F0")]
		public JJKOFPANBHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2A984B0", Offset = "0x2A972B0", VA = "0x182A984B0", Slot = "4")]
		private bool PNVMAEDANGW([In] Id128<LQPAJNJDNAW> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2A98820", Offset = "0x2A97620", VA = "0x182A98820", Slot = "5")]
		private void YYESNZJLBJM([In] Id128<LQPAJNJDNAW> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2A985C0", Offset = "0x2A973C0", VA = "0x182A985C0", Slot = "6")]
		private void HJJXYNGNSQL([In] Id128<LQPAJNJDNAW> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2A986E0", Offset = "0x2A974E0", VA = "0x182A986E0", Slot = "7")]
		private void LKSILGJDWXO([In] Id128<LQPAJNJDNAW> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2A98420", Offset = "0x2A97220", VA = "0x182A98420", Slot = "8")]
		private bool NWWUHXADRCA([In] Id128<LQPAJNJDNAW> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class OOYVZVFZNOX
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F530", Offset = "0x2A9E330", VA = "0x182A9F530")]
		public static LogDeps MVCHUBOUFII()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class YSSCFUOGRZY : MeshLibrary.XQEIROEEFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "4")]
		public byte[]? PHEEFWTEFGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
		public void ZJKOHRBDVDM(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public YSSCFUOGRZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class PRWRZLFZMNT : BKLHYEYAHLO
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
		public delegate void ConfigureAttachedObjectDelegate(OCIFJFJKOVU controlPanel, WVHJGQESRCU staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<OYBSQMSSBDV> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, SJKUUBAWOPB>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, SJKUUBAWOPB>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, SJKUUBAWOPB>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, SJKUUBAWOPB>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public Task<Result<MultiResult, SJKUUBAWOPB>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private TaskAwaiter<Result<MultiResult, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5830", Offset = "0x2AA4630", VA = "0x182AA5830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5AF0", Offset = "0x2AA48F0", VA = "0x182AA5AF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private TaskAwaiter<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5B60", Offset = "0x2AA4960", VA = "0x182AA5B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5E20", Offset = "0x2AA4C20", VA = "0x182AA5E20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public Task<Result<None, SJKUUBAWOPB>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<Result<None, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5E90", Offset = "0x2AA4C90", VA = "0x182AA5E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6150", Offset = "0x2AA4F50", VA = "0x182AA6150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<string, EnumChoiceData> JBZWJKJMAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<int, string> IQSPZRPYEPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly List<object> ORRGLPCSHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<Guid> IUGNKHXCSUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly CanLocalPlayerCreateCurrencyDelegate RXUMDNGDKET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ShowRoomCurrencyCreationUIDelegate YZOEYKJSDJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly GetAudioClipOptionsDelegate VHGRMBUEQOS;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly IReadOnlyDictionary<Guid, int> XEQCEUZTYVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly GetAudioClipGuidToIndexMapDelegate EFKIQGISMFM;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly IReadOnlyDictionary<int, Guid> CXOFJLQVHIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly GetAudioClipIndexToGuidMapDelegate PXUFVETGOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAllAudioClipOptionsDelegate DYXJWQKYEGZ;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<Guid, int> QUNEPDPJSAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate ENDAFPSUMNZ;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly IReadOnlyDictionary<int, Guid> TTRGJSHLKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate PPOIDPXTUYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly PlayAudioPreviewDelegate ILHYYGNFZZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly StopAudioPreviewDelegate YVOLHFGZEFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly SubscriptionIsActiveDelegate GOFUKTUNGHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate DJPPDRAAKNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Dictionary<string, EnumChoiceData> IQDCPFQPSJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly ShowQuickChatEditMenuDelegate HWTZRWFHSRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly ConfigureAttachedObjectDelegate HKXBBFYZBTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly DisplayInvalidNameErrorMessageDelegate CACUBZPYAXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly IsStringPureDelegate TQYTVECHOEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly TryGetSpecificChipConfigSummaryDelegate LHBOHNUXEFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly ReleaseIconIdDelegate DBAFMBYDVYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReportCreationErrorToUserAsyncDelegate RXVDGTJKYVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 VYPFNJPLNOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 VYJYQCVOEDK;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment XFUTNQHMTXU
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool OARZGUWCMBH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF1380", Offset = "0xAF0180", VA = "0x180AF1380", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> FYAHUWNDWHI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> AFJBPQADWZX
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> WRZQIWYKZKS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> RFQQTDSMZSK
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED60", Offset = "0xA9DB60", VA = "0x180A9ED60", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion FPSGNVQQGSI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xBDB1A0", Offset = "0xBD9FA0", VA = "0x180BDB1A0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool WUPTFRLXGAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xBDB530", Offset = "0xBDA330", VA = "0x180BDB530", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool QTSGTGLEEYN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A9FCC0", Offset = "0x2A9EAC0", VA = "0x182A9FCC0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UHEJFETBRUS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2AA02E0", Offset = "0x2A9F0E0", VA = "0x182AA02E0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool MPEMVZTPVQI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xAA9C20", Offset = "0xAA8A20", VA = "0x180AA9C20", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0470", Offset = "0x2A9F270", VA = "0x182AA0470")]
		public PRWRZLFZMNT([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA01F0", Offset = "0x2A9EFF0", VA = "0x182AA01F0", Slot = "9")]
		public bool XZZPXIRAOQW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40")]
		public static bool FMMOYWAVUZD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FD30", Offset = "0x2A9EB30", VA = "0x182A9FD30", Slot = "10")]
		public bool GAZHNIUNWYY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		public static void JTTIMETFNZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xF7AC80", Offset = "0xF79A80", VA = "0x180F7AC80", Slot = "11")]
		public void MSTMTDYNBEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F990", Offset = "0x2A9E790", VA = "0x182A9F990")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ANFFFQJHSQA(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FD90", Offset = "0x2A9EB90", VA = "0x182A9FD90", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ICLBIMGXNMD(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0170", Offset = "0x2A9EF70", VA = "0x182AA0170")]
		private static IReadOnlyDictionary<Guid, int> WLBIRDMIFNA(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FC90", Offset = "0x2A9EA90", VA = "0x182A9FC90", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> EHIEFTEWWFD(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FFD0", Offset = "0x2A9EDD0", VA = "0x182A9FFD0")]
		private static IReadOnlyDictionary<int, Guid> MVVZPTJZXIO(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA01C0", Offset = "0x2A9EFC0", VA = "0x182AA01C0", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> XVXJKBZRCLD(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0050", Offset = "0x2A9EE50", VA = "0x182AA0050")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> QGKHYVDPXBR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E770", Offset = "0x2A8D570", VA = "0x182A8E770", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BDHIGMEBTMW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0120", Offset = "0x2A9EF20", VA = "0x182AA0120")]
		private static IReadOnlyDictionary<Guid, int> VDGOABNAYFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FEB0", Offset = "0x2A9ECB0", VA = "0x182A9FEB0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> LSKJTGDETUO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0080", Offset = "0x2A9EE80", VA = "0x182AA0080", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> SGWALZZOXUC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		private static void EBBNJVTQBVW(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA00B0", Offset = "0x2A9EEB0", VA = "0x182AA00B0", Slot = "18")]
		public void TFDPBEYEOFB(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		private static void CKALALICCKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FD60", Offset = "0x2A9EB60", VA = "0x182A9FD60", Slot = "19")]
		public void HGBFYBABWZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40")]
		private static bool DHRIEGDPPZP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0020", Offset = "0x2A9EE20", VA = "0x182AA0020", Slot = "20")]
		public bool OARUNGCMFFK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40")]
		public static bool PYRJPFXYAEY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FE80", Offset = "0x2A9EC80", VA = "0x182A9FE80", Slot = "21")]
		public bool LRXPZYROFRZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FBE0", Offset = "0x2A9E9E0", VA = "0x182A9FBE0", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BJQJFHFXLYE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> AMFVTJLLDLW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> YQCRZGNBREA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FDC0", Offset = "0x2A9EBC0", VA = "0x182A9FDC0", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> JUFPLMLLNUV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> SFJGXPKEGVF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> XQXXZTRLRST()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		public static void EWKYPNIQUYF(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FBA0", Offset = "0x2A9E9A0", VA = "0x182A9FBA0", Slot = "29")]
		public void BABBQXEGREM(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		private static void WQSSPDPDKDF(OCIFJFJKOVU a, WVHJGQESRCU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FC20", Offset = "0x2A9EA20", VA = "0x182A9FC20", Slot = "35")]
		public void DHBWQGMBOIO(OCIFJFJKOVU a, WVHJGQESRCU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "36")]
		public Dictionary<string, EnumChoiceData> XVPDROAKLEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "37")]
		public Dictionary<string, EnumChoiceData> MEMSDWDTGPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		private static void WCRKRZJKSWZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FCD0", Offset = "0x2A9EAD0", VA = "0x182A9FCD0")]
		private static Task<bool> FPENVCSYXLT(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA00F0", Offset = "0x2A9EEF0", VA = "0x182AA00F0", Slot = "38")]
		public Task<bool> UWJMFQJDZDW(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FC10", Offset = "0x2A9EA10", VA = "0x182A9FC10")]
		private static bool CBAUEYAGFFH(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FC50", Offset = "0x2A9EA50", VA = "0x182A9FC50", Slot = "39")]
		public bool DQVIIKHNRVS(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		private static void CBDAPVPNOUF(Id32<OYBSQMSSBDV> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA02B0", Offset = "0x2A9F0B0", VA = "0x182AA02B0", Slot = "40")]
		public void ZAERJRPFRDW(Id32<OYBSQMSSBDV> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FEE0", Offset = "0x2A9ECE0", VA = "0x182A9FEE0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, SJKUUBAWOPB>> MPNLZGVUBZD(Task<Result<None, SJKUUBAWOPB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FE50", Offset = "0x2A9EC50", VA = "0x182A9FE50", Slot = "41")]
		public Task<Result<None, SJKUUBAWOPB>> KUMTXWGZUGY(Task<Result<None, SJKUUBAWOPB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FAB0", Offset = "0x2A9E8B0", VA = "0x182A9FAB0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, SJKUUBAWOPB>> BAANXCYRLUN(Task<Result<MultiResult, SJKUUBAWOPB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FDF0", Offset = "0x2A9EBF0", VA = "0x182A9FDF0", Slot = "42")]
		public Task<Result<MultiResult, SJKUUBAWOPB>> KUMTXWGZUGY(Task<Result<MultiResult, SJKUUBAWOPB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F9C0", Offset = "0x2A9E7C0", VA = "0x182A9F9C0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> AZVGZWEUCJE(Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FE20", Offset = "0x2A9EC20", VA = "0x182A9FE20", Slot = "43")]
		public Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> KUMTXWGZUGY(Task<Result<Id32<TOCKAIBKNWY>, SJKUUBAWOPB>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class IBYWUVTLRZW : OWWVWPHWJYX
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(MJLOQDUEBTO e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private InteropDelegate? TZWACLAKNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly InteropDelegate EZALAHMTXFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate FZFZOVXRMLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? EULUPMQRYLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InvokeStudioFunctionDelegate? HCWDJPLNAJE;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "5")]
		public LegacyCV2Result<None> IHWJBIDJCSG(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0")]
		private static LegacyCV2Result<None> Default(MJLOQDUEBTO _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "6")]
		public LegacyCV2Result<None> UBCRBNULJSL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "7")]
		public LegacyCV2Result<None> QETBNSRZDJK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "8")]
		public LegacyCV2Result<None> TYXQKVOPPUZ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "9")]
		public LegacyCV2Result<None> HVOVCUFUGIR(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "15")]
		public LegacyCV2Result<None> MZBHBIDUMLI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KEVFQOGINUO(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> APMCWAZPZCO(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JZKQZVVQCLH(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JASPZNIZIWI(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> URXLFTREHQX(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OJBDLWFRABN(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CPZNYNKHQWO(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "93")]
		public LegacyCV2Result<None> GKZMGAPHKWT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "94")]
		public LegacyCV2Result<None> PNLJACRXDNN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "95")]
		public LegacyCV2Result<None> OMPYUYGUCHK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AWDNCVQMTQI(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(MJLOQDUEBTO e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NSDBLYSWXQG(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZHKZTVBTURM(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LRNQMSVRHQJ(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QRJKLWCYQRK(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QOGIWSGRTHP(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WWTUSKYLDXR(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NSQCCGSESKD(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SDAMPUBXWAG(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1239")]
		public LegacyCV2Result<None> MakeChatAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1240")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1241")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1242")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1244")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1243")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1245")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1246")]
		public LegacyCV2Result<None> GetAIFunction(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x156AFF0", Offset = "0x1569DF0", VA = "0x18156AFF0", Slot = "1248")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LRQVJYESKVX(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VONVQCNIFLE(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "119")]
		public LegacyCV2Result<None> HXIUFKVRSKC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KOWXYORQFCP(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "121")]
		public LegacyCV2Result<None> YBDYCZJSUAT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "122")]
		public LegacyCV2Result<None> BGNEMJITVID(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "123")]
		public LegacyCV2Result<None> NVCMEAIASYD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "124")]
		public LegacyCV2Result<None> UDNHONTYQFB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "125")]
		public LegacyCV2Result<None> CZSJBVSNGKP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "126")]
		public LegacyCV2Result<None> EZJXPYDEVMQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "809")]
		public LegacyCV2Result<None> WYZILJHAVLA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "810")]
		public LegacyCV2Result<None> DEKVTOGLVEK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "147")]
		public LegacyCV2Result<None> IYFNORSRXZM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "148")]
		public LegacyCV2Result<None> QVBGLWBBIBM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "149")]
		public LegacyCV2Result<None> JMCAWRUYFCR(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "150")]
		public LegacyCV2Result<None> MTAIHUHMQTP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "151")]
		public LegacyCV2Result<None> FKSFWLBWVFO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(MJLOQDUEBTO e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "153")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "154")]
		public LegacyCV2Result<None> EquipAvatarItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "155")]
		public LegacyCV2Result<None> UnequipAvatarItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "156")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "157")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "158")]
		public LegacyCV2Result<None> MotionTrailSetColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailGetColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "164")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "165")]
		public LegacyCV2Result<None> BeaconSetEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "166")]
		public LegacyCV2Result<None> BeaconGetEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "167")]
		public LegacyCV2Result<None> BeaconSetHeight(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "168")]
		public LegacyCV2Result<None> BeaconGetHeight(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "169")]
		public LegacyCV2Result<None> BeaconSetColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "170")]
		public LegacyCV2Result<None> BeaconGetColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "171")]
		public LegacyCV2Result<None> QMGBPVGKPUV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "172")]
		public LegacyCV2Result<None> KAHPMTEZYGW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "173")]
		public LegacyCV2Result<None> HYZFXNXDSRU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "174")]
		public LegacyCV2Result<None> GetLocalCameraForward(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "175")]
		public LegacyCV2Result<None> GetLocalCameraUp(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "176")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraPosition(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "178")]
		public LegacyCV2Result<None> SetCameraShake(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "179")]
		public LegacyCV2Result<None> StopCameraShake(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "180")]
		public LegacyCV2Result<None> SnapCameraImage(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "189")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "190")]
		public LegacyCV2Result<None> CollisionDataGetObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "191")]
		public LegacyCV2Result<None> CollisionDataGetDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPosition(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetNormal(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "194")]
		public LegacyCV2Result<None> BISVJSTXMMQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "195")]
		public LegacyCV2Result<None> SIOENXZMBHB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "196")]
		public LegacyCV2Result<None> TKZATWRGUPI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "197")]
		public LegacyCV2Result<None> YYRSVJQVGNI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "198")]
		public LegacyCV2Result<None> BQDENXIBUXM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "199")]
		public LegacyCV2Result<None> JZWYHWIPCKP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "200")]
		public LegacyCV2Result<None> XMNMVYAXFYJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "201")]
		public LegacyCV2Result<None> BKCMAMIARAP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "202")]
		public LegacyCV2Result<None> ZGHIIVGJXKL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "203")]
		public LegacyCV2Result<None> YOIVEVMKAJF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "204")]
		public LegacyCV2Result<None> OCOOVFWAFJD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "205")]
		public LegacyCV2Result<None> EMITRQZNHYN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "206")]
		public LegacyCV2Result<None> DPYPRGUFRWH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "207")]
		public LegacyCV2Result<None> PMHLGFSVDSW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "208")]
		public LegacyCV2Result<None> KEKBBGTXBGP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "209")]
		public LegacyCV2Result<None> DQUYYSGFEES(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "210")]
		public LegacyCV2Result<None> RFBBMOAUGFT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "211")]
		public LegacyCV2Result<None> KFVFUXDWVLQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "212")]
		public LegacyCV2Result<None> MXPHMHILODF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "213")]
		public LegacyCV2Result<None> CombatantGetHealthAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "214")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "215")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "216")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "217")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "218")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "225")]
		public LegacyCV2Result<None> CombatantSetHealthAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "226")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "227")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "231")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "232")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "233")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "239")]
		public LegacyCV2Result<None> CombatantToCombatantAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "240")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "241")]
		public LegacyCV2Result<None> CombatantSplit(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "242")]
		public LegacyCV2Result<None> CostumeEquip(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "243")]
		public LegacyCV2Result<None> CostumeUnEquip(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "244")]
		public LegacyCV2Result<None> CostumeGetWearer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "245")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "271")]
		public LegacyCV2Result<None> WTXPYSEZLPF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "272")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "273")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "274")]
		public LegacyCV2Result<None> SVBKDQECXFD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "276")]
		public LegacyCV2Result<None> TBAYLNEWFHW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "277")]
		public LegacyCV2Result<None> JDWCSKUAXJM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "278")]
		public LegacyCV2Result<None> OBJCBTKVSOL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "279")]
		public LegacyCV2Result<None> MITVGOOAJFC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "280")]
		public LegacyCV2Result<None> YFOCREDXHOF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "281")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "282")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "283")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "284")]
		public LegacyCV2Result<None> VSRPECUPVUM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "285")]
		public LegacyCV2Result<None> TGHIOXUOHHD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "286")]
		public LegacyCV2Result<None> ToCreationObjectAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "287")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "288")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectButton(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectContainer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectRotator(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectPiston(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectSeat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectDice(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectCostume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "314")]
		public LegacyCV2Result<None> QBDVEFYXKPY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "317")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "342")]
		public LegacyCV2Result<None> FromCreationObjectAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "343")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "344")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "345")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "346")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectButton(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectContainer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectDie(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectPiston(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRotator(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectText(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectSeat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectCostume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "399")]
		public LegacyCV2Result<None> JWXBYYUGOGF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "400")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CJKEVZMUUXG(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "401")]
		public LegacyCV2Result<None> DiceRollFinished(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "402")]
		public LegacyCV2Result<None> DiceResult(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "403")]
		public LegacyCV2Result<None> DicePlayerRolled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "404")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "405")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YXAZTGCIBNS(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "406")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NKBRAPDKPOC(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ICFUKJFMBRX(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "408")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DTMZKCQRRXE(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "409")]
		public LegacyCV2Result<DKZUFMQILBY.CV2DiscoverySectionType> ZPZCRIPQGKF(MJLOQDUEBTO e, CircuitSignal a)
		{
			return default(LegacyCV2Result<DKZUFMQILBY.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "410")]
		public LegacyCV2Result<None> SCYHHJLBTZD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "411")]
		public LegacyCV2Result<None> EmitterStart(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "412")]
		public LegacyCV2Result<None> EmitterStop(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "413")]
		public LegacyCV2Result<None> EmitterSetLooping(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "414")]
		public LegacyCV2Result<None> EmitterSetSize(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "415")]
		public LegacyCV2Result<None> EmitterSetSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "416")]
		public LegacyCV2Result<None> EmitterSetColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "417")]
		public LegacyCV2Result<None> EmitterSetColorNew(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "418")]
		public LegacyCV2Result<None> EmitterGetLooping(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "419")]
		public LegacyCV2Result<None> EmitterGetSize(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "420")]
		public LegacyCV2Result<None> EmitterGetSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "421")]
		public LegacyCV2Result<None> EmitterGetPlaying(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "422")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(MJLOQDUEBTO e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "423")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WNSUKPCMVAV(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "424")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TNMASYAKXUS(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "425")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BTIWXZOHBLB(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "426")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "427")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "428")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "429")]
		public LegacyCV2Result<None> GetFriendlyNameAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "430")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "182")]
		public LegacyCV2Result<None> GetFriendlyNameColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "434")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "431")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "432")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "433")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "435")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameReward(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "453")]
		public LegacyCV2Result<None> QUUCJWXROCS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "454")]
		public LegacyCV2Result<None> DBSECPOFNZJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "455")]
		public LegacyCV2Result<None> YORHGZINHTC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "456")]
		public LegacyCV2Result<None> JXHFDBIEHNL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "457")]
		public LegacyCV2Result<None> GNHMTRPYDEZ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "458")]
		public LegacyCV2Result<None> NEASBGJNKGX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "459")]
		public LegacyCV2Result<None> BXOIYSNRQQE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "460")]
		public LegacyCV2Result<None> GCROVHLUPBI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "465")]
		public LegacyCV2Result<None> SYHVPTHXGLS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "466")]
		public LegacyCV2Result<None> MOOXEZSQGOE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "467")]
		public LegacyCV2Result<None> TQDNWZRJLHL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "468")]
		public LegacyCV2Result<None> YENENTFZBPS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "469")]
		public LegacyCV2Result<None> EHQXDERJCFK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "470")]
		public LegacyCV2Result<None> MXMVGYPOJMV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "461")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(MJLOQDUEBTO executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "462")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(MJLOQDUEBTO executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "463")]
		public LegacyCV2Result<None> LPVRISIIDUT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "464")]
		public LegacyCV2Result<None> XHSFTPBSCOX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "471")]
		public LegacyCV2Result<None> KKRYDGJVTHF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "472")]
		public LegacyCV2Result<None> VYHZMHHMHZN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "473")]
		public LegacyCV2Result<None> NZDHIWQAXVG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "474")]
		public LegacyCV2Result<None> YTIAIYIBJGG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "475")]
		public LegacyCV2Result<None> IHQMUYZTRPG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "476")]
		public LegacyCV2Result<None> GDFIIACNXBW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "477")]
		public LegacyCV2Result<None> YPTSLBFKQQS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "478")]
		public LegacyCV2Result<None> HBTYTQWOCBK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "479")]
		public LegacyCV2Result<None> FGGTLRGCQIK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "480")]
		public LegacyCV2Result<None> EZPFNSJTHTE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "481")]
		public LegacyCV2Result<None> ZWHVCIVEAQU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "482")]
		public LegacyCV2Result<None> TGQTICTYQBK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "483")]
		public LegacyCV2Result<None> NSNKUJPWKOS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "484")]
		public LegacyCV2Result<None> FSAFWJADNXY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "485")]
		public LegacyCV2Result<None> JCGZATZSACW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "486")]
		public LegacyCV2Result<None> LHJFPPATWAY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "487")]
		public LegacyCV2Result<None> TLFKFXDHATK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "488")]
		public LegacyCV2Result<None> ZSCKZYQBIKE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "489")]
		public LegacyCV2Result<None> NLZOGCPIWAS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "490")]
		public LegacyCV2Result<None> WEQJEGXXTNC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A97F30", Offset = "0x2A96D30", VA = "0x182A97F30", Slot = "491")]
		public LegacyCV2Result<None> SendLogString(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "492")]
		public LegacyCV2Result<None> LerpColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "493")]
		public LegacyCV2Result<None> LerpUnclampedColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "494")]
		public LegacyCV2Result<None> InverseLerpVec3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "495")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "496")]
		public LegacyCV2Result<None> InverseLerpColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "497")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "498")]
		public LegacyCV2Result<None> WKKCZOHFREW(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "499")]
		public LegacyCV2Result<None> AVHIIEDZZQI(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "500")]
		public LegacyCV2Result<None> NEDSFITDMAI(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "501")]
		public LegacyCV2Result<None> DUWUVONZLZR(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "502")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "503")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "504")]
		public LegacyCV2Result<None> FogConstantValues(MJLOQDUEBTO e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "505")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "506")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "507")]
		public LegacyCV2Result<None> SunConstantValues(MJLOQDUEBTO e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "508")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "509")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "510")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(MJLOQDUEBTO e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.ABAJWKLIDCK> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "511")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "512")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "513")]
		public LegacyCV2Result<None> PNVWDJITUDT(MJLOQDUEBTO e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "516")]
		public LegacyCV2Result<None> PTTPANMQTGZ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "517")]
		public LegacyCV2Result<None> TextScreenClearScreen(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "518")]
		public LegacyCV2Result<None> SBAJPAZJBCO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "519")]
		public LegacyCV2Result<None> EIHPAYNVSWA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "520")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "521")]
		public LegacyCV2Result<None> TTUQYNXALTW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "522")]
		public LegacyCV2Result<None> SXDVWABHGJF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2A97EA0", Offset = "0x2A96CA0", VA = "0x182A97EA0", Slot = "523")]
		public LegacyCV2Result<None> GetLocalPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "524")]
		public LegacyCV2Result<None> QJKVBPFPTFF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2A97E60", Offset = "0x2A96C60", VA = "0x182A97E60", Slot = "526")]
		public LegacyCV2Result<None> DMPBQVAZAHX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "525")]
		public LegacyCV2Result<None> CEZWZAHWFDM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "527")]
		public LegacyCV2Result<None> GGEZTOQCELY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "528")]
		public LegacyCV2Result<None> KQSQKMJQYMF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "529")]
		public LegacyCV2Result<None> XQGBGTLYOFF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "530")]
		public LegacyCV2Result<None> DNZXLXHBOBV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "531")]
		public LegacyCV2Result<None> CDCHNBNMXPH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "532")]
		public LegacyCV2Result<None> DistanceAI_AI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "533")]
		public LegacyCV2Result<None> DistanceAI_Combatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "534")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "535")]
		public LegacyCV2Result<None> DistanceAI_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "536")]
		public LegacyCV2Result<None> DistanceAI_Vector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "537")]
		public LegacyCV2Result<None> DistanceCombatant_AI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "538")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "539")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "540")]
		public LegacyCV2Result<None> DistanceCombatant_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "541")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "542")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "543")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "544")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "545")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "546")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "547")]
		public LegacyCV2Result<None> DistancePlayer_AI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "548")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "549")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "550")]
		public LegacyCV2Result<None> DistancePlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "551")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "552")]
		public LegacyCV2Result<None> DistanceVector3_AI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "553")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "554")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "555")]
		public LegacyCV2Result<None> DistanceVector3_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "556")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "557")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "558")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "559")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "560")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "561")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "562")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "563")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "564")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "565")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "566")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "567")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "568")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "569")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "570")]
		public LegacyCV2Result<None> GetPositionAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "571")]
		public LegacyCV2Result<None> GetPositionCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "572")]
		public LegacyCV2Result<None> GetPositionCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "573")]
		public LegacyCV2Result<None> GetPositionPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "574")]
		public LegacyCV2Result<None> Raycast(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "575")]
		public LegacyCV2Result<None> OQJTEGNBGHU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "576")]
		public LegacyCV2Result<None> RaycastAll(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "577")]
		public LegacyCV2Result<None> Spherecast(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "578")]
		public LegacyCV2Result<None> DPTQWEPVTNX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "579")]
		public LegacyCV2Result<None> SpherecastAll(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "580")]
		public LegacyCV2Result<None> OverlapSphere(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "581")]
		public LegacyCV2Result<None> OverlapBox(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "582")]
		public LegacyCV2Result<None> WKWOWEFIYKI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "583")]
		public LegacyCV2Result<None> LKRSLGXJCAL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "584")]
		public LegacyCV2Result<None> SetPositionPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "585")]
		public LegacyCV2Result<None> SetPositionCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "586")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "587")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "588")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "589")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "591")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "592")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "593")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "594")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "595")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "596")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "597")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "598")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "599")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "600")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "601")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "602")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "603")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "604")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "605")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "606")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "607")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "608")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "609")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "610")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "611")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "612")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "613")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "614")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "615")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "616")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "617")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "618")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "619")]
		public LegacyCV2Result<None> PistonGetDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "620")]
		public LegacyCV2Result<None> PistonSetDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "621")]
		public LegacyCV2Result<None> PistonGetSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "622")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "623")]
		public LegacyCV2Result<None> PistonSetSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "624")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "625")]
		public LegacyCV2Result<None> PistonGetAcceleration(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "626")]
		public LegacyCV2Result<None> PistonSetAcceleration(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "627")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "628")]
		public LegacyCV2Result<None> PistonGetMaxDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "629")]
		public LegacyCV2Result<None> PistonSetMaxDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "630")]
		public LegacyCV2Result<None> PistonGetTargetDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "631")]
		public LegacyCV2Result<None> PistonSetTargetDistance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "632")]
		public LegacyCV2Result<None> QVEOOUZYMSM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "633")]
		public LegacyCV2Result<None> MKIOULELNQE(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "634")]
		public LegacyCV2Result<None> UQFGIJZMCBP(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "635")]
		public LegacyCV2Result<None> DQNTRGSDPZE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "636")]
		public LegacyCV2Result<None> DHEMSBKQPGW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "637")]
		public LegacyCV2Result<None> JXORXKIOMGX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "638")]
		public LegacyCV2Result<None> PlayerAddRole(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "639")]
		public LegacyCV2Result<None> PlayerRemoveRole(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "640")]
		public LegacyCV2Result<None> RIBAWNUCXAQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "641")]
		public LegacyCV2Result<None> VWQOXMETEFK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "642")]
		public LegacyCV2Result<None> MGLDJCIPPFL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "643")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "644")]
		public LegacyCV2Result<None> PlayerRightHandPosition(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "645")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "646")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "647")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "648")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "649")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "650")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "652")]
		public LegacyCV2Result<None> CBRRQLUSMXM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "651")]
		public LegacyCV2Result<None> DCSETDYPEAN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "653")]
		public LegacyCV2Result<None> GQMAAHYXPRS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "654")]
		public LegacyCV2Result<None> RSPWJSMWJZB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "655")]
		public LegacyCV2Result<None> PlayerHeadPosition(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "656")]
		public LegacyCV2Result<None> PlayerHeadOrientation(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "657")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "658")]
		public LegacyCV2Result<None> PlayerHeadUpVector(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "659")]
		public LegacyCV2Result<None> PlayerHeadVelocity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "660")]
		public LegacyCV2Result<None> PlayerHeadHeight(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "661")]
		public LegacyCV2Result<None> TBZLQUJHTUA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "662")]
		public LegacyCV2Result<None> YFIRLRAPLJR(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "663")]
		public LegacyCV2Result<None> PlayerBodyPosition(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "664")]
		public LegacyCV2Result<None> PlayerBodyOrientation(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "665")]
		public LegacyCV2Result<None> MPKQRSQLKOR(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "666")]
		public LegacyCV2Result<None> FKCXKMETTKY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "694")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "699")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(MJLOQDUEBTO e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "685")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "686")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "687")]
		public LegacyCV2Result<None> KVUEJSRBWFM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "688")]
		public LegacyCV2Result<None> HQTERGPFCEY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "689")]
		public LegacyCV2Result<None> FXSFDIWGTUI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "690")]
		public LegacyCV2Result<None> IFURYMPXLCH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "691")]
		public LegacyCV2Result<None> AHINFDSZUPB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "692")]
		public LegacyCV2Result<None> PlayerGetCostume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "693")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "667")]
		public LegacyCV2Result<None> QSDALXKYXVW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "668")]
		public LegacyCV2Result<None> COWKMFLHDBU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "669")]
		public LegacyCV2Result<None> YMGELYFJXKP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "670")]
		public LegacyCV2Result<None> ERZEBHIHJKC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "671")]
		public LegacyCV2Result<None> TILUJDSKDCF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "672")]
		public LegacyCV2Result<None> KEGULQSXGWM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "673")]
		public LegacyCV2Result<None> GUZCCTBNALI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "674")]
		public LegacyCV2Result<None> NGSAUACRLBR(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "675")]
		public LegacyCV2Result<None> YOHXEPTOPRV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "676")]
		public LegacyCV2Result<None> RMOLCWXERMC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "677")]
		public LegacyCV2Result<None> SMFCOADXFOQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "678")]
		public LegacyCV2Result<None> OROPFXYBOXP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "679")]
		public LegacyCV2Result<None> QBDFKINFQJU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "680")]
		public LegacyCV2Result<None> RQGCHPHMCGS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "681")]
		public LegacyCV2Result<None> LJSWPXJDHHF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "682")]
		public LegacyCV2Result<None> NWACJQCOIPP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "683")]
		public LegacyCV2Result<None> IBZSAZKVOJZ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "684")]
		public LegacyCV2Result<None> TQOHGWJNCVG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "695")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "696")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "756")]
		public LegacyCV2Result<None> LFJIECPZBAU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "757")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "758")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "700")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "702")]
		public LegacyCV2Result<None> TNGRXTQIHCN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "703")]
		public LegacyCV2Result<None> ALTBRESQSAP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "704")]
		public LegacyCV2Result<None> MENAZIFASKV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "705")]
		public LegacyCV2Result<None> WMMDTLFFFCT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "707")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "708")]
		public LegacyCV2Result<None> DRUVQMXJISH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "709")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "710")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "711")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "712")]
		public LegacyCV2Result<None> ZOXINJZPHGO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "713")]
		public LegacyCV2Result<None> LZJGFWMUPKU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "714")]
		public LegacyCV2Result<None> HTDNYWSGTVV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "715")]
		public LegacyCV2Result<None> OWORDKTNTHH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "716")]
		public LegacyCV2Result<None> EKBKKSPLRNT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "717")]
		public LegacyCV2Result<None> LKXYAOJZQKY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "718")]
		public LegacyCV2Result<None> FEVFMOOJFOZ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "719")]
		public LegacyCV2Result<None> HKIBCUUJVFO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "720")]
		public LegacyCV2Result<None> EEPUBTVAIJW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "721")]
		public LegacyCV2Result<None> ODLOIMVHXRS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "722")]
		public LegacyCV2Result<None> ZUEWXMZUPAU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "723")]
		public LegacyCV2Result<None> FGLLNZVQJBW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "724")]
		public LegacyCV2Result<None> WSTFOEMNRYC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "725")]
		public LegacyCV2Result<None> FLYTJELHQLP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "726")]
		public LegacyCV2Result<None> OJZGVLZRNWQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "727")]
		public LegacyCV2Result<None> CLSJEZJHJLY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "728")]
		public LegacyCV2Result<None> ALXGUMHUNAJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "729")]
		public LegacyCV2Result<None> PGPCGYWESDU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "731")]
		public LegacyCV2Result<None> IZAYTOWJSKE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "730")]
		public LegacyCV2Result<None> CRJCQMLAGFQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "732")]
		public LegacyCV2Result<None> SJFHIHAIPOX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "733")]
		public LegacyCV2Result<None> BEUKTCMUDGC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "734")]
		public LegacyCV2Result<None> CFVEWBRKZOR(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "735")]
		public LegacyCV2Result<None> FKWEBDGYYYN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "736")]
		public LegacyCV2Result<None> WMLFFBHTVJO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "737")]
		public LegacyCV2Result<None> FNYWWJWKPMV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "738")]
		public LegacyCV2Result<None> VNIXNWLGYQJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "739")]
		public LegacyCV2Result<None> PVGOCZXWLCK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "740")]
		public LegacyCV2Result<None> ADJEGDSBLRK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "741")]
		public LegacyCV2Result<None> NCKTWAEPLJE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "742")]
		public LegacyCV2Result<None> QEIHBOMTTGO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "743")]
		public LegacyCV2Result<None> MIBSOTWCLIY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "744")]
		public LegacyCV2Result<None> BANJFOOLADO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "745")]
		public LegacyCV2Result<None> ZFXZCIVZKLO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "746")]
		public LegacyCV2Result<None> QSTXMBDBLYJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "747")]
		public LegacyCV2Result<None> VHOEZJTKZIF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "748")]
		public LegacyCV2Result<None> EZOTXXLLQKX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "749")]
		public LegacyCV2Result<None> HEKJDGTUYXL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "750")]
		public LegacyCV2Result<None> CHYKZRUHDHE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "751")]
		public LegacyCV2Result<None> EATLLFBVWXU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "752")]
		public LegacyCV2Result<None> WYVHYOVCCTI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "753")]
		public LegacyCV2Result<None> XFHTLDAVCQX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "754")]
		public LegacyCV2Result<None> ANQMPADTRON(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "755")]
		public LegacyCV2Result<None> QVPDJIIZLHM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "759")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "760")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "761")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "762")]
		public LegacyCV2Result<None> TDALJIJNHXI(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "763")]
		public LegacyCV2Result<None> ONKZHJXRYPW(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "764")]
		public LegacyCV2Result<None> VRAPRUYATIN(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "765")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(MJLOQDUEBTO ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "766")]
		public LegacyCV2Result<None> RJHQEPIREOL(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "767")]
		public LegacyCV2Result<None> QQTQSHQZAYB(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "768")]
		public LegacyCV2Result<None> JMDSVLHGELC(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "769")]
		public LegacyCV2Result<None> NODWSPEQWQE(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "770")]
		public LegacyCV2Result<None> YQFXSGDHVHM(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "697")]
		public LegacyCV2Result<None> PlayerGetProfileImage(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "698")]
		public LegacyCV2Result<None> BNXXZOBYULA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "771")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "772")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "773")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "774")]
		public LegacyCV2Result<None> ShowPlayerProfile(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "775")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "776")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "777")]
		public LegacyCV2Result<None> RequestPostGameRewards(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "778")]
		public LegacyCV2Result<None> SetPlayerWorldUI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "779")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "780")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "781")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "782")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "783")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "784")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "785")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "786")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "788")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "791")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "792")]
		public LegacyCV2Result<None> SQFCNWDMHAO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "793")]
		public LegacyCV2Result<None> VDPNTUVQFRA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "794")]
		public LegacyCV2Result<None> XZLUIUUAJJM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "795")]
		public LegacyCV2Result<None> SGSGTDOQBGU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "796")]
		public LegacyCV2Result<None> CRWRBOXJVLI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "797")]
		public LegacyCV2Result<None> KQMGJADXXXM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "798")]
		public LegacyCV2Result<None> RHWACXVZIJQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "799")]
		public LegacyCV2Result<None> NDEBPEYKBQI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "800")]
		public LegacyCV2Result<None> JXMPHGQUMYC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "801")]
		public LegacyCV2Result<None> FUOAJFAWTAO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "802")]
		public LegacyCV2Result<None> YWUOVQCXMLG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "803")]
		public LegacyCV2Result<None> OEADFSXSZCX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "804")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "805")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "806")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "807")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "808")]
		public LegacyCV2Result<None> BHRXSSUZXXS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "811")]
		public LegacyCV2Result<None> GetProjectile(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "812")]
		public LegacyCV2Result<None> DLHHDIJDKQP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "813")]
		public LegacyCV2Result<None> BTEALJCDVKB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "814")]
		public LegacyCV2Result<None> DHCZYNYLPUJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "815")]
		public LegacyCV2Result<None> QEPIQKOVALB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "816")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "817")]
		public LegacyCV2Result<None> UAYIXYQWWKX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "818")]
		public LegacyCV2Result<None> OSUBJVIKCCA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "819")]
		public LegacyCV2Result<None> XPMMCRYMZQK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "820")]
		public LegacyCV2Result<None> ResetRoom(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "821")]
		public LegacyCV2Result<None> ResetObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "822")]
		public LegacyCV2Result<None> SUTWFOXCVKS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "823")]
		public LegacyCV2Result<None> YIAURYBJIAT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "824")]
		public LegacyCV2Result<None> HDCXSZGHNEC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "825")]
		public LegacyCV2Result<None> ConstantReward(MJLOQDUEBTO e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "826")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(MJLOQDUEBTO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "827")]
		public LegacyCV2Result<None> FTODDXPTYFT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "828")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OYPWYXNTRVN(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "829")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WDFGAYCHUHF(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "830")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BCFBCJLYGVU(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "831")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CHDHOVXONHJ(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "832")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LBAOPWOITKQ(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "833")]
		public LegacyCV2Result<None> ActivateConsumable(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "834")]
		public LegacyCV2Result<None> DeactivateConsumable(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "835")]
		public LegacyCV2Result<None> ConstantConsumable(MJLOQDUEBTO e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "836")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(MJLOQDUEBTO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "837")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "840")]
		public LegacyCV2Result<None> ConstantRoomKey(MJLOQDUEBTO e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "842")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(MJLOQDUEBTO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "843")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "844")]
		public LegacyCV2Result<None> ConstantInventoryItem(MJLOQDUEBTO e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(MJLOQDUEBTO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "846")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(MJLOQDUEBTO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "847")]
		public LegacyCV2Result<None> FYFWNXSSFWJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "849")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "850")]
		public LegacyCV2Result<None> DGKYRGINEIN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "851")]
		public LegacyCV2Result<None> ZNFRDEJPHNZ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "852")]
		public LegacyCV2Result<None> RPGLSESVRYN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "853")]
		public LegacyCV2Result<None> SNDIACEXTOQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "854")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "855")]
		public LegacyCV2Result<None> YKRYSQFUQUF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "856")]
		public LegacyCV2Result<None> FLPXCAKJAZD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "857")]
		public LegacyCV2Result<None> ConstantRoomOffer(MJLOQDUEBTO e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "858")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "859")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "860")]
		public LegacyCV2Result<None> MSFKMBCBBQX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "861")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "862")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "863")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "864")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "865")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "866")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "867")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "868")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "869")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "870")]
		public LegacyCV2Result<None> YSLZKLNPTSJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "871")]
		public LegacyCV2Result<None> OAJNPKBDYTX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "872")]
		public LegacyCV2Result<None> QPNIBJDFKMM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "873")]
		public LegacyCV2Result<None> YGNDOOWRSYF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "874")]
		public LegacyCV2Result<None> ConstantRoomCurrency(MJLOQDUEBTO e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "875")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(MJLOQDUEBTO e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "876")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(MJLOQDUEBTO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "877")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(MJLOQDUEBTO e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "878")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(MJLOQDUEBTO e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "879")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "880")]
		public LegacyCV2Result<None> QISHQNOLUCP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "881")]
		public LegacyCV2Result<None> ZXIGXUFTRFS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "882")]
		public LegacyCV2Result<None> YZMMXABOZMX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "883")]
		public LegacyCV2Result<None> MDCQFYFSZBN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "884")]
		public LegacyCV2Result<None> BJFLLPYCZKV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "888")]
		public LegacyCV2Result<None> XZAWLSWHPKK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "889")]
		public LegacyCV2Result<None> YMYXSIYLOUG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "890")]
		public LegacyCV2Result<None> BPKSCWBAAOZ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "892")]
		public LegacyCV2Result<None> ZYDBVCWAWHT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "891")]
		public LegacyCV2Result<None> PDXLDRNHDPJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "893")]
		public LegacyCV2Result<None> MCVGJDCGTIW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "895")]
		public LegacyCV2Result<None> SBCCXRQJGZE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "894")]
		public LegacyCV2Result<None> ADCOUMLOWTE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "896")]
		public LegacyCV2Result<None> NOUTPSNKKNN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "897")]
		public LegacyCV2Result<None> VBEGLHYQYQD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "898")]
		public LegacyCV2Result<None> WJOKNZVYIOY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "899")]
		public LegacyCV2Result<None> ZMSZIBVOJVM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "900")]
		public LegacyCV2Result<None> CSCZEJMIAJO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "901")]
		public LegacyCV2Result<None> RVTBADCJHSA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "902")]
		public LegacyCV2Result<None> XVTRQDPNICQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "903")]
		public LegacyCV2Result<None> AllowDressUp(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "904")]
		public LegacyCV2Result<None> ForbidDressUp(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "905")]
		public LegacyCV2Result<None> OpenStore(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "906")]
		public LegacyCV2Result<None> OpenCheckout(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "907")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "908")]
		public LegacyCV2Result<None> GetTrialItemQuantity(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "909")]
		public LegacyCV2Result<None> UQHRGUVPDAK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "910")]
		public LegacyCV2Result<None> DOOLBTRWCGI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "911")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "912")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "913")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "914")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "915")]
		public LegacyCV2Result<None> StorefrontGetOffersList(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "916")]
		public LegacyCV2Result<None> StorefrontSetOffersList(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "917")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "918")]
		public LegacyCV2Result<None> GetStoreItemDetails(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "919")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "920")]
		public LegacyCV2Result<None> MannequinSetStoreItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "921")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "922")]
		public LegacyCV2Result<None> RaiseStudioEvent(MJLOQDUEBTO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "923")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(MJLOQDUEBTO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "924")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(MJLOQDUEBTO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "925")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(MJLOQDUEBTO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "926")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(MJLOQDUEBTO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "927")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(MJLOQDUEBTO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "928")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(MJLOQDUEBTO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "929")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(MJLOQDUEBTO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "930")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(MJLOQDUEBTO e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "931")]
		public LegacyCV2Result<None> OTLWBCGXJXI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "932")]
		public LegacyCV2Result<None> TTPHYTAQDVO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "933")]
		public LegacyCV2Result<None> BNVNIUEKZQD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "934")]
		public LegacyCV2Result<None> RGVCGZDBLIT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "935")]
		public LegacyCV2Result<None> SXNZTLOEXAO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "936")]
		public LegacyCV2Result<None> YQONFHZYKNU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "937")]
		public LegacyCV2Result<None> OLKHZGMQOTT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "938")]
		public LegacyCV2Result<None> EHRWGWIFIFJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "939")]
		public LegacyCV2Result<None> JYHTMXLOTRH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "940")]
		public LegacyCV2Result<None> KJVARXBUJHO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "941")]
		public LegacyCV2Result<None> GetFromSyncIdAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "942")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "943")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "944")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "945")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "946")]
		public LegacyCV2Result<None> GetSyncIdAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "947")]
		public LegacyCV2Result<None> GetSyncIdCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "948")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "949")]
		public LegacyCV2Result<None> GetSyncIdPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "950")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "958")]
		public LegacyCV2Result<None> KLQTMBATQUU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "957")]
		public LegacyCV2Result<None> QLFQKPOYJFV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "959")]
		public LegacyCV2Result<None> PHGZUQQRLZN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "960")]
		public LegacyCV2Result<None> NAFKWUBZJVU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "961")]
		public LegacyCV2Result<None> NMPFUKYAAEL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "962")]
		public LegacyCV2Result<None> DHMUWXJODFD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "963")]
		public LegacyCV2Result<None> MKRXULKBKOK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "951")]
		public LegacyCV2Result<None> TextToolGetText(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "952")]
		public LegacyCV2Result<None> TextToolSetText(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "953")]
		public LegacyCV2Result<None> TextToolSetColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "954")]
		public LegacyCV2Result<None> TextToolSetColorNew(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "955")]
		public LegacyCV2Result<None> TextToolSetMaterial(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "956")]
		public LegacyCV2Result<None> TextToolGetColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "964")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "965")]
		public LegacyCV2Result<None> ICHJIPYJRRD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "971")]
		public LegacyCV2Result<None> GetParticleVfx(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "972")]
		public LegacyCV2Result<None> VHNRUUCIDRC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "973")]
		public LegacyCV2Result<None> ZQIQHKNJOLW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "974")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "975")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "976")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "977")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "978")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "979")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "980")]
		public LegacyCV2Result<None> GoToRoom(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "981")]
		public LegacyCV2Result<None> KGGQTBGWFXJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "966")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "967")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "968")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "969")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "970")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "982")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "983")]
		public LegacyCV2Result<None> MRHLGTOGJAH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "984")]
		public LegacyCV2Result<None> PMWGNPLVAXD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "985")]
		public LegacyCV2Result<None> QBQSPDANSXT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "986")]
		public LegacyCV2Result<None> BFAKZWOJVLZ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "987")]
		public LegacyCV2Result<None> ZVQVSNTZMKB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "988")]
		public LegacyCV2Result<None> WIVWIXABERX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "989")]
		public LegacyCV2Result<None> RSFENYOWPST(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "990")]
		public LegacyCV2Result<None> OTQOQFYHWPJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "991")]
		public LegacyCV2Result<None> XNJULFKVYWH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "992")]
		public LegacyCV2Result<None> WKFBVJJCSIX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "996")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "997")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "993")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "994")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "995")]
		public LegacyCV2Result<None> PlayerGetXp(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "998")]
		public LegacyCV2Result<None> PerlinNoise(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "999")]
		public LegacyCV2Result<None> GDBFGRCUPHB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1000")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1001")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1002")]
		public LegacyCV2Result<None> SeatSetLockOut(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1003")]
		public LegacyCV2Result<None> SeatSetLockIn(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1004")]
		public LegacyCV2Result<None> SeatUnseatPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1005")]
		public LegacyCV2Result<None> SeatGetLockIn(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1006")]
		public LegacyCV2Result<None> SeatGetLockOut(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1007")]
		public LegacyCV2Result<None> UWONLMANPZM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1008")]
		public LegacyCV2Result<None> BLVMTXXFCZH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1009")]
		public LegacyCV2Result<None> IFFJQYIPHBY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1010")]
		public LegacyCV2Result<None> XTAGOTNWFOF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1011")]
		public LegacyCV2Result<None> YRXXBOQYYTO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1012")]
		public LegacyCV2Result<None> FSHZXQKPEPL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1013")]
		public LegacyCV2Result<None> ODPMPIAGBGQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1014")]
		public LegacyCV2Result<None> UJPBPTYXLZO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1015")]
		public LegacyCV2Result<None> RHSFELXOPDJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1016")]
		public LegacyCV2Result<None> VBNIUNJSYEG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1017")]
		public LegacyCV2Result<None> FWKNNQORSBO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1018")]
		public LegacyCV2Result<None> IQROZNLZLEB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1019")]
		public LegacyCV2Result<None> VVGPNNIOWGX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1020")]
		public LegacyCV2Result<None> NMUCNEAINCE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1021")]
		public LegacyCV2Result<None> ICMDQNTASLB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1022")]
		public LegacyCV2Result<None> OXKBFMVPWGE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1023")]
		public LegacyCV2Result<None> DNDJUOUNIXK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1024")]
		public LegacyCV2Result<None> NavMeshSamplePosition(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1025")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1037")]
		public LegacyCV2Result<None> SBVTEIFWDCI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1038")]
		public LegacyCV2Result<None> FVWTELDGMCY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1039")]
		public LegacyCV2Result<None> SFPNKNCWNDA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1040")]
		public LegacyCV2Result<None> OYYZNSNDODY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1041")]
		public LegacyCV2Result<None> UWBDFPNLTCH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1042")]
		public LegacyCV2Result<None> MNLHXWXGXSD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1043")]
		public LegacyCV2Result<None> LUPMJNNVAAO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1044")]
		public LegacyCV2Result<None> TOTWIYGXDYX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1045")]
		public LegacyCV2Result<None> YPSJYOBTRLY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1046")]
		public LegacyCV2Result<None> DOVBNHFSYRD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1047")]
		public LegacyCV2Result<None> LCGLLPCGUTF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1048")]
		public LegacyCV2Result<None> IFMLXCQMPHE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1049")]
		public LegacyCV2Result<None> EKTAKAFKLBT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1050")]
		public LegacyCV2Result<None> KWRQRLXGBDJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1051")]
		public LegacyCV2Result<None> BLHVTZFKHFB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1052")]
		public LegacyCV2Result<None> VSOIFOCNCXF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1053")]
		public LegacyCV2Result<None> HGDQRLRBRZB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1054")]
		public LegacyCV2Result<None> SYEXEGCIKWO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1055")]
		public LegacyCV2Result<None> GZFFCXKGAJU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1056")]
		public LegacyCV2Result<None> LPOTOTUIZTL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1057")]
		public LegacyCV2Result<None> PMEGKQMEIKV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1058")]
		public LegacyCV2Result<None> VNGDTAWFBDF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1059")]
		public LegacyCV2Result<None> AAICAGRIDOD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1060")]
		public LegacyCV2Result<None> OMNUJCASCWC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1061")]
		public LegacyCV2Result<None> XQURKJJLWRQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1062")]
		public LegacyCV2Result<None> IsValidAI(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1063")]
		public LegacyCV2Result<None> IsValidCombatant(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2A97EE0", Offset = "0x2A96CE0", VA = "0x182A97EE0", Slot = "1064")]
		public LegacyCV2Result<None> IsValidPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1065")]
		public LegacyCV2Result<None> IsValidReward(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1066")]
		public LegacyCV2Result<None> IsValidAudio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1067")]
		public LegacyCV2Result<None> IsValidRecNetMesh(MJLOQDUEBTO e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1068")]
		public LegacyCV2Result<None> ValidIfNotNull(MJLOQDUEBTO e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1069")]
		public LegacyCV2Result<None> GetVelocityCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1070")]
		public LegacyCV2Result<None> GetVelocityPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1071")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1072")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1073")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1074")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1075")]
		public LegacyCV2Result<None> GetUpVectorPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1076")]
		public LegacyCV2Result<None> GetOrientationCreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1077")]
		public LegacyCV2Result<None> GetOrientationPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1078")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1079")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1080")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1081")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1082")]
		public LegacyCV2Result<None> EYQYHAIPEYX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1083")]
		public LegacyCV2Result<None> YGEEPRXGYQW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1084")]
		public LegacyCV2Result<None> YCGQMTAFZEW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1085")]
		public LegacyCV2Result<None> FMJOQZUIRFI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1086")]
		public LegacyCV2Result<None> GRVRMMJEFOC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1087")]
		public LegacyCV2Result<None> QUIRKUINUHU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1088")]
		public LegacyCV2Result<None> XTQUXCKZVOO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1089")]
		public LegacyCV2Result<None> IWYMBAOWHWE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1090")]
		public LegacyCV2Result<None> AQQMBYRCSMQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1091")]
		public LegacyCV2Result<None> XICMMRKYCCI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1092")]
		public LegacyCV2Result<None> VVCISGUNIHK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1093")]
		public LegacyCV2Result<None> XCASTYBOHYD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1094")]
		public LegacyCV2Result<None> QDOSUUFCQAL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1095")]
		public LegacyCV2Result<None> SGFHXTIBCUH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1096")]
		public LegacyCV2Result<None> JAIUVNWISGH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1097")]
		public LegacyCV2Result<None> YINAZGELNSK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1098")]
		public LegacyCV2Result<None> KQPVDYBZYZU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1099")]
		public LegacyCV2Result<None> GPKWTLUSJEJ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1100")]
		public LegacyCV2Result<None> VRUPIBEWYSN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1101")]
		public LegacyCV2Result<None> WHWWDGWNSVF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1102")]
		public LegacyCV2Result<None> VNBCHVFPWNB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1103")]
		public LegacyCV2Result<None> PWLQBFPWCEW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1104")]
		public LegacyCV2Result<None> XCENIIUHBEG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1105")]
		public LegacyCV2Result<None> EPFOVWIZPWH(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1106")]
		public LegacyCV2Result<None> DWYZLXCRNFF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1107")]
		public LegacyCV2Result<None> WXLBJGDIYEX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1108")]
		public LegacyCV2Result<None> TBDYAGQDFVF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1109")]
		public LegacyCV2Result<None> PRLYIZMIFVQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1110")]
		public LegacyCV2Result<None> MEFHDEVNBQL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1111")]
		public LegacyCV2Result<None> ZZDKOMXQTEZ(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1112")]
		public LegacyCV2Result<None> VQLOTMHVWVP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1113")]
		public LegacyCV2Result<None> CQMYLEKELGQ(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1114")]
		public LegacyCV2Result<None> QKIOFNENPDK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1115")]
		public LegacyCV2Result<None> KVZLJMZJRDE(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1116")]
		public LegacyCV2Result<None> QHODGEQZGAC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1117")]
		public LegacyCV2Result<None> VAWNQHQCQUQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1118")]
		public LegacyCV2Result<None> XZJTEZUMDIQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1119")]
		public LegacyCV2Result<None> SNHHOMYXEAY(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1120")]
		public LegacyCV2Result<None> FWGTPVBIDUV(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1121")]
		public LegacyCV2Result<None> PJGIGIUPTXY(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1122")]
		public LegacyCV2Result<None> TJOZXZZGQTX(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1123")]
		public LegacyCV2Result<None> RKRWLUYNZZA(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1124")]
		public LegacyCV2Result<None> PPXYQUZDNTI(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1125")]
		public LegacyCV2Result<None> VDZLLINCLAV(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1126")]
		public LegacyCV2Result<None> MDMPTTEUOOV(JGPDTZSNOTP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1127")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1128")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1129")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1130")]
		public LegacyCV2Result<None> APUHCMCEALF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1131")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1132")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1133")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1134")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1135")]
		public LegacyCV2Result<None> HolotarProjectorPlay(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1136")]
		public LegacyCV2Result<None> HolotarProjectorResume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1137")]
		public LegacyCV2Result<None> HolotarProjectorPause(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1138")]
		public LegacyCV2Result<None> HolotarProjectorStop(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1139")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1140")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1141")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1142")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1143")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1144")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1145")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1146")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1147")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1148")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1149")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1150")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1151")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1152")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1153")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1154")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1155")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1156")]
		public LegacyCV2Result<None> CAAINHLTSNL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1157")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1158")]
		public LegacyCV2Result<None> YDOEHEFYLPP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1159")]
		public LegacyCV2Result<None> OHLQPZNUVYU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1160")]
		public LegacyCV2Result<None> PNIVTFZDGWD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1161")]
		public LegacyCV2Result<None> ZROXVQRDFYW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1166")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleGetCanReload(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1168")]
		public LegacyCV2Result<None> GunHandleSetCanReload(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1169")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1170")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1171")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1172")]
		public LegacyCV2Result<None> ZGKGKPMNEWG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1173")]
		public LegacyCV2Result<None> DRZZLFLEVZU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1174")]
		public LegacyCV2Result<None> VPFPYGBXRNO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1175")]
		public LegacyCV2Result<None> CVFXZOURWHW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1176")]
		public LegacyCV2Result<None> DYPBWSVVCRV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1177")]
		public LegacyCV2Result<None> WBWENBYZHPP(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1178")]
		public LegacyCV2Result<None> EMJGJOZHYKR(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1179")]
		public LegacyCV2Result<None> YCDCSASUKWD(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1180")]
		public LegacyCV2Result<None> SNEJFPEAPBU(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1181")]
		public LegacyCV2Result<None> CHHUMEFCGCS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1182")]
		public LegacyCV2Result<None> WFEBCMJBRYB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1183")]
		public LegacyCV2Result<None> PFFMSGVGYLI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "181")]
		public LegacyCV2Result<None> WLCWSKLVTWI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "183")]
		public LegacyCV2Result<None> GetIntFromRROColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "184")]
		public LegacyCV2Result<None> GetColorFromRGB(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "185")]
		public LegacyCV2Result<None> GetColorFromHSV(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "186")]
		public LegacyCV2Result<None> GetRGBFromColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "187")]
		public LegacyCV2Result<None> GetHSVFromColor(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2A97F20", Offset = "0x2A96D20", VA = "0x182A97F20", Slot = "188")]
		public bool OJFPPKTMTEK(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1184")]
		public LegacyCV2Result<None> XLOZHFQARZQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1185")]
		public LegacyCV2Result<None> BANMVRKKFUF(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1186")]
		public LegacyCV2Result<None> BFLKQRRRGKS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(MJLOQDUEBTO e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1198")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1187")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1188")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1189")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1190")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1191")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1192")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1193")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1194")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1195")]
		public LegacyCV2Result<None> AFCNHUFULCX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1196")]
		public LegacyCV2Result<None> MLQKBQLODIX(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "246")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(MJLOQDUEBTO e, InOut io, KQRGXPNRAVV objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "247")]
		public LegacyCV2Result<None> KWURKBAZIAW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "248")]
		public LegacyCV2Result<None> JVWHWYPPRSO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "249")]
		public LegacyCV2Result<None> MGIOABBVZAO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "250")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "251")]
		public LegacyCV2Result<None> EDKITIZZBXN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "252")]
		public LegacyCV2Result<None> NEELLGDLVQV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "253")]
		public LegacyCV2Result<None> ZSPSBOLZAZL(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "254")]
		public LegacyCV2Result<None> NBEUOTHTDNE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "255")]
		public LegacyCV2Result<None> VPRSGBFRMMO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "256")]
		public LegacyCV2Result<None> ZLWCRSDGDJV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "257")]
		public LegacyCV2Result<None> WCXBDKOVIPZ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "258")]
		public LegacyCV2Result<None> MMFKNSBSRQN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "259")]
		public LegacyCV2Result<None> WOQLPTPNSYV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "260")]
		public LegacyCV2Result<None> SDSKLQUNNUW(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "261")]
		public LegacyCV2Result<None> QYCPENXNPZA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "262")]
		public LegacyCV2Result<None> EZMQLCZDQTA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "263")]
		public LegacyCV2Result<None> DNYVTRRKKYM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "264")]
		public LegacyCV2Result<None> EITUFWWQISM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "265")]
		public LegacyCV2Result<None> IIQSALSNIAO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "266")]
		public LegacyCV2Result<None> VLPINQRQZCS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "267")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "268")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "269")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0")]
		private static LegacyCV2Result<None> Default(MJLOQDUEBTO e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A97F70", Offset = "0x2A96D70", VA = "0x182A97F70", Slot = "1199")]
		public LegacyCV2Result<None> TREXXJPDVRD(MJLOQDUEBTO a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1202")]
		public LegacyCV2Result<None> WOZCTHPBACY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1203")]
		public LegacyCV2Result<None> LHKWXODUPTM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1204")]
		public LegacyCV2Result<None> NTQSTCCKPKY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1205")]
		public LegacyCV2Result<None> TCIFTLYBEHT(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1200")]
		public LegacyCV2Result<None> ConstantQuickChatTable(MJLOQDUEBTO e, InOut io, LDKENXEIMQF quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1201")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1026")]
		public LegacyCV2Result<None> GLOGZJLPEHI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1027")]
		public LegacyCV2Result<None> HYHTOSCDZIG(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1028")]
		public LegacyCV2Result<None> ECOJBXDONXM(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1029")]
		public LegacyCV2Result<None> FJJFJPZZKXE(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1030")]
		public LegacyCV2Result<None> CJMOAHRVAIQ(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1031")]
		public LegacyCV2Result<None> WILFQCUIPUY(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1032")]
		public LegacyCV2Result<None> RGTOAKQENFQ(MJLOQDUEBTO a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1033")]
		public LegacyCV2Result<None> TKBJODCBJPC(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1034")]
		public LegacyCV2Result<None> HPXDGSKRVRK(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1035")]
		public LegacyCV2Result<None> XYNYVDAEQPB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1036")]
		public LegacyCV2Result<None> OFIPVGVQDRN(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1209")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1210")]
		public LegacyCV2Result<None> HandleSetControlLabel(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1211")]
		public LegacyCV2Result<None> HandleGetControlLabel(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1212")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1213")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1214")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1215")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1216")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QSVPJYWEZIN(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1223")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1224")]
		public LegacyCV2Result<None> KWQAQACSYXS(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1225")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1226")]
		public LegacyCV2Result<None> LNTLMOXRGID(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1227")]
		public LegacyCV2Result<None> ElementSnapToElement(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1228")]
		public LegacyCV2Result<None> ElementUnsnap(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1229")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1230")]
		public LegacyCV2Result<None> SnapPointUnsnap(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1217")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1218")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1219")]
		public LegacyCV2Result<None> PVEWMZAILVV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1220")]
		public LegacyCV2Result<None> GetTexture(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1221")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1222")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1231")]
		public LegacyCV2Result<None> EFOLJDLRSOB(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1232")]
		public LegacyCV2Result<None> IPVSVHOFDNO(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1233")]
		public LegacyCV2Result<None> JGGONKEIUOI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1234")]
		public LegacyCV2Result<None> HPGJRDTUOQA(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1235")]
		public LegacyCV2Result<None> WCVHLPVRYSV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1236")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GEQNEVGXJQZ(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1237")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JWCSGVDMRJT(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1238")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HGKRBTKPRER(MJLOQDUEBTO a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A98000", Offset = "0x2A96E00", VA = "0x182A98000")]
		public IBYWUVTLRZW([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1249")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1256")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1257")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1258")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1259")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1260")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1261")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1262")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1265")]
		public LegacyCV2Result<None> ConstantBodyPart(MJLOQDUEBTO e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1266")]
		public LegacyCV2Result<None> WJNBHCFIRUI(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1267")]
		public LegacyCV2Result<None> SGESCKKYUOV(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1268")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "590")]
		public LegacyCV2Result<None> GKHFRYNRSGR(MJLOQDUEBTO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1269")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1270")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1271")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1272")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1273")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1274")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1275")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1276")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1277")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1278")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1279")]
		public LegacyCV2Result<None> DKXPQVRYAMO(JGPDTZSNOTP e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1280")]
		public LegacyCV2Result<None> PMCXSWWUVZH(JGPDTZSNOTP e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1281")]
		public LegacyCV2Result<None> BBWUVDKKKCO(JGPDTZSNOTP e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1282")]
		public LegacyCV2Result<None> YRJEJMLQEGW(JGPDTZSNOTP e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1283")]
		public LegacyCV2Result<None> SHJOMNRFAVD(JGPDTZSNOTP e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0")]
		public LegacyCV2Result<None> ConstantStorefrontItem(MJLOQDUEBTO e, InOut io, [In] CJMOJYLGWMU storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1207")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(MJLOQDUEBTO e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1197")]
		private LegacyCV2Result<None> GCCQAJZDHOQ(MJLOQDUEBTO a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1206")]
		private LegacyCV2Result<None> TASZTYPDTTB(MJLOQDUEBTO a, InOut b, [In] CJMOJYLGWMU storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x114FFB0", Offset = "0x114EDB0", VA = "0x18114FFB0", Slot = "1247")]
		private LegacyCV2Result<None> SQUJHAROVOB(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class WURIGIXSFXX : GQGXZCBZHPM
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(YOJXWXHUCEF node);

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly WURIGIXSFXX ADQZGMDDDFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate DBAFYOYOMIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate HESBHLAVGXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private bool WJBLJSQLLOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool LFXOBJYQOIA;

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8B70", Offset = "0x2AA7970", VA = "0x182AA8B70", Slot = "4")]
		public Task<bool> VPJXZXNSCRV(YOJXWXHUCEF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF010", Offset = "0x2AADE10", VA = "0x182AAF010", Slot = "5")]
		public Task<bool> JCRONNWBZLI(YOJXWXHUCEF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF0E0", Offset = "0x2AADEE0", VA = "0x182AAF0E0")]
		public WURIGIXSFXX([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF040", Offset = "0x2AADE40", VA = "0x182AAF040", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? ODGEVQVTAWJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xAA0BB0", Offset = "0xA9F9B0", VA = "0x180AA0BB0", Slot = "7")]
		public bool JGBXEPJIDBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x163F330", Offset = "0x163E130", VA = "0x18163F330", Slot = "8")]
		public bool ACUNUSCJHTC()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class YMWXGMLYSHR : VHMNKGVTWBU
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid EBKWTFIADJV
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xF319E0", Offset = "0xF307E0", VA = "0x180F319E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
		public void Bind(YJQUSGABTPK pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x1160A20", Offset = "0x115F820", VA = "0x181160A20")]
		public YMWXGMLYSHR(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF9D0", Offset = "0x2AAE7D0", VA = "0x182AAF9D0")]
		public static YMWXGMLYSHR New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class GGCARJHXKYF : NKDETYEKGDX
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<PXJWRZNPPPA> nodeDefId, Id128<TROAQNNIZMC>? legacyInnerGraphId, IReadOnlyDictionary<Id128<TROAQNNIZMC>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private IsNodeRestrictedDelegate? UEGFURTFUNQ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool WUPTFRLXGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0xAF1380", Offset = "0xAF0180", VA = "0x180AF1380", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool VURFDBXRTIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7610", Offset = "0x2AA6410", VA = "0x182AA7610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FTASSYECJYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x21117B0", Offset = "0x21105B0", VA = "0x1821117B0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "6")]
		public bool JHRANWYEYEW(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "7")]
		public CanSaveObjectIntoInventionResultType PQEQNFIWNEL(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7620", Offset = "0x2AA6420", VA = "0x182AA7620", Slot = "8")]
		public bool ZGZCTLMWJUW(Id128<PXJWRZNPPPA> nodeDefId, Id128<TROAQNNIZMC>? legacyInnerGraphId, IReadOnlyDictionary<Id128<TROAQNNIZMC>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "9")]
		public bool EEWEQHCCIMR(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "10")]
		public bool XICCIXJJDNH(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7670", Offset = "0x2AA6470", VA = "0x182AA7670")]
		public GGCARJHXKYF(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class YHLYVCAFEMR : HRFRXWTKTMO
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly YHLYVCAFEMR ADQZGMDDDFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly ShouldLogEventSenderToMakerPenDelegate BGWZTXQDRLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate ZJXVKXGGVHL;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool QZIHMIHKNNL
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x12EECA0", Offset = "0x12EDAA0", VA = "0x1812EECA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KJCKIMYTIAR
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF630", Offset = "0x2AAE430", VA = "0x182AAF630", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF6D0", Offset = "0x2AAE4D0", VA = "0x182AAF6D0")]
		public YHLYVCAFEMR([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class RMRDEKBVXXL : RSUANDFJWHW
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class LWIVDVCNONE : UCACHYHCFNN, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public static readonly LWIVDVCNONE VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool IBDLNTIKOFS
			{
				[Cpp2IlInjected.Token(Token = "0x600074D")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8DC0", Offset = "0x2AA7BC0", VA = "0x182AA8DC0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			public void EZELIDFGKBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public LWIVDVCNONE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly RMRDEKBVXXL VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private RMRDEKBVXXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2AABA50", Offset = "0x2AAA850", VA = "0x182AABA50", Slot = "4")]
		public UCACHYHCFNN MVJWFIIVRYG()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class JSYUJENUFLH<a, b> : IDisposable, REYULGVCMLG where a : notnull where b : notnull, LJWWYDZZUNB.YTUDMBCVPQT<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly b RHEDUJJJYXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly a XWVVTFFLJBC;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<VCZWSUVCRXV> OOUJPTZLKJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<VCZWSUVCRXV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x52BE590", Offset = "0x52BD390", VA = "0x1852BE590")]
		public JSYUJENUFLH(b a, a b, Id32<VCZWSUVCRXV> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x52BC770", Offset = "0x52BB570", VA = "0x1852BC770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x52BE2F0", Offset = "0x52BD0F0", VA = "0x1852BE2F0")]
		public Id32<FQTHCTXUYZW> ZNNMJZQMKHP([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<FQTHCTXUYZW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x52BC9D0", Offset = "0x52BB7D0", VA = "0x1852BC9D0", Slot = "6")]
		public void FRZLKGIDXMW(Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x52BDB20", Offset = "0x52BC920", VA = "0x1852BDB20", Slot = "7")]
		public void VEQZMRGASRC(Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x52BD350", Offset = "0x52BC150", VA = "0x1852BD350", Slot = "8")]
		public void IWTEJHXANSF(Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x52BDE10", Offset = "0x52BCC10", VA = "0x1852BDE10", Slot = "10")]
		public void WXFTJJLRMSK(Id32<FQTHCTXUYZW> objectId, Id32<VCZWSUVCRXV> clientId, XIKUPAMMEQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x52BD8F0", Offset = "0x52BC6F0", VA = "0x1852BD8F0", Slot = "9")]
		public void QWPWOJNSTNC(Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x52BE2B0", Offset = "0x52BD0B0", VA = "0x1852BE2B0", Slot = "11")]
		public void XZOOGKETUTM(Id32<FQTHCTXUYZW> objectId, WOVAONPGCSF? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x52BCC60", Offset = "0x52BBA60", VA = "0x1852BCC60", Slot = "12")]
		public Id32<VCZWSUVCRXV> IWADKNKYAZT(Id32<FQTHCTXUYZW> objectId)
		{
			return default(Id32<VCZWSUVCRXV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x52BDB60", Offset = "0x52BC960", VA = "0x1852BDB60", Slot = "13")]
		public Id32<UACOCYSWUWU> VHZYYHWVFDV(Id32<FQTHCTXUYZW> objectId, string a, object b, bool c, OYGAHFARWRG d, HVXPYDFAQPW e)
		{
			return default(Id32<UACOCYSWUWU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x52BCC20", Offset = "0x52BBA20", VA = "0x1852BCC20", Slot = "14")]
		public void IFCKZSGTMUJ(Id32<UACOCYSWUWU> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x52BD450", Offset = "0x52BC250", VA = "0x1852BD450", Slot = "15")]
		public void KLMEHFZVJBP(Id32<UACOCYSWUWU> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class LJWWYDZZUNB
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface YTUDMBCVPQT<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void USVJFAMMEDV(a a, Id32<VCZWSUVCRXV> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<VCZWSUVCRXV>? YWJITKSNYEA(a a);

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<FQTHCTXUYZW> ZNNMJZQMKHP(a a, Id32<VCZWSUVCRXV> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void FRZLKGIDXMW(a a, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL b);

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void VEQZMRGASRC(a a, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL b);

			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void WXFTJJLRMSK(a a, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL b);

			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void QWPWOJNSTNC(a a, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL b);

			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void XZOOGKETUTM(a a, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, WOVAONPGCSF? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<VCZWSUVCRXV>? IWADKNKYAZT(a a, Id32<FQTHCTXUYZW> objectId);

			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<UACOCYSWUWU> VHZYYHWVFDV(a a, Id32<VCZWSUVCRXV> clientId, string b, object c, OYGAHFARWRG d, HVXPYDFAQPW e);

			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void IFCKZSGTMUJ(a a, Id32<VCZWSUVCRXV> clientId, Id32<UACOCYSWUWU> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void KLMEHFZVJBP(a a, Id32<VCZWSUVCRXV> clientId, Id32<UACOCYSWUWU> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class ORSVDPMMHCT
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public readonly HashSet<Id32<FQTHCTXUYZW>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public SOAId32Field<UACOCYSWUWU, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public readonly Dictionary<Id32<UACOCYSWUWU>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<UACOCYSWUWU>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAField<FQTHCTXUYZW, WOVAONPGCSF?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9680", Offset = "0x2AA8480", VA = "0x182AA9680")]
			private MockCV2DynamicNetSys(HashSet<Id32<FQTHCTXUYZW>> authorityOf, [In] SOAId32Field<UACOCYSWUWU, MockCV2SyncField> syncFields, Dictionary<Id32<UACOCYSWUWU>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<UACOCYSWUWU>> mockSyncFieldToSyncField, [In] SOAField<FQTHCTXUYZW, WOVAONPGCSF?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA94C0", Offset = "0x2AA82C0", VA = "0x182AA94C0")]
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
			public Id32<VCZWSUVCRXV>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9720", Offset = "0x2AA8520", VA = "0x182AA9720")]
			public MockCV2ObjectShared(Id32<VCZWSUVCRXV> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public HVXPYDFAQPW SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public OYGAHFARWRG SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
			internal MockCV2SyncField(HVXPYDFAQPW syncField, OYGAHFARWRG syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9840", Offset = "0x2AA8640", VA = "0x182AA9840")]
			public static MockCV2SyncField New(HVXPYDFAQPW syncField, OYGAHFARWRG syncFieldChangeHandler)
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

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x2AA97F0", Offset = "0x2AA85F0", VA = "0x182AA97F0")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x2AA97A0", Offset = "0x2AA85A0", VA = "0x182AA97A0")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private SOAId32Field<FQTHCTXUYZW, MockCV2ObjectShared> UHYBFQEIHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<FQTHCTXUYZW>> LMOXLJEUIBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> WRAERLVWUXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> OGFKDHZPQFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private SOAField<VCZWSUVCRXV, MockCV2DynamicNetSys> ETXXFGQLFDK;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<FQTHCTXUYZW>? ISNILSKRHAE
		{
			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0xBDB170", Offset = "0xBD9F70", VA = "0x180BDB170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x12DD1A0", Offset = "0x12DBFA0", VA = "0x1812DD1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA99E0", Offset = "0x2AA87E0", VA = "0x182AA99E0")]
		public void Destroy([In] SOAId32<VCZWSUVCRXV> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAC20", Offset = "0x2AA9A20", VA = "0x182AAAC20")]
		public void XEXEALGVYVD(Id32<VCZWSUVCRXV> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA440", Offset = "0x2AA9240", VA = "0x182AAA440")]
		public void USVJFAMMEDV(Id32<VCZWSUVCRXV> clientId, Id32<VCZWSUVCRXV>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB150", Offset = "0x2AA9F50", VA = "0x182AAB150")]
		public Id32<FQTHCTXUYZW> ZNNMJZQMKHP(Id32<VCZWSUVCRXV> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<VCZWSUVCRXV> clientIds)
		{
			return default(Id32<FQTHCTXUYZW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA8C0", Offset = "0x2AA96C0", VA = "0x182AAA8C0")]
		public Id32<UACOCYSWUWU> VHZYYHWVFDV(Id32<VCZWSUVCRXV> clientId, string a, object b, OYGAHFARWRG c, HVXPYDFAQPW d)
		{
			return default(Id32<UACOCYSWUWU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9CA0", Offset = "0x2AA8AA0", VA = "0x182AA9CA0")]
		public void IFCKZSGTMUJ(Id32<VCZWSUVCRXV> clientId, Id32<UACOCYSWUWU> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA1F0", Offset = "0x2AA8FF0", VA = "0x182AAA1F0")]
		public Id32<FQTHCTXUYZW>? QHBAKRABXYM([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9C20", Offset = "0x2AA8A20", VA = "0x182AA9C20")]
		public void FRZLKGIDXMW([In] SOAId32<VCZWSUVCRXV> clientIds, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA780", Offset = "0x2AA9580", VA = "0x182AAA780")]
		public void VEQZMRGASRC(Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAB20", Offset = "0x2AA9920", VA = "0x182AAAB20")]
		public void WXFTJJLRMSK(Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA2C0", Offset = "0x2AA90C0", VA = "0x182AAA2C0")]
		public void QWPWOJNSTNC([In] SOAId32<VCZWSUVCRXV> clientIds, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB080", Offset = "0x2AA9E80", VA = "0x182AAB080")]
		public void XZOOGKETUTM(Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, WOVAONPGCSF? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9E30", Offset = "0x2AA8C30", VA = "0x182AA9E30")]
		public Id32<VCZWSUVCRXV>? IWADKNKYAZT(Id32<FQTHCTXUYZW> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9E80", Offset = "0x2AA8C80", VA = "0x182AA9E80")]
		public void KLMEHFZVJBP([In] SOAId32<VCZWSUVCRXV> clientIds, Id32<VCZWSUVCRXV> clientId, Id32<UACOCYSWUWU> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB560", Offset = "0x2AAA360", VA = "0x182AAB560")]
		public ORSVDPMMHCT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class LHEQMZVYRKS
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8D60", Offset = "0x2AA7B60", VA = "0x182AA8D60")]
		public static void Destroy(this ORSVDPMMHCT.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class XBDYEIEZRDO : WULNELQMSYI.XQEIROEEFNO
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static XBDYEIEZRDO SQJSFISGSDP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate QMNEUIKBRYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate VTSHMKWHXHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xAA5770", Offset = "0xAA4570", VA = "0x180AA5770")]
		public XBDYEIEZRDO(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class FUAZHRRWMOY : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : ELLZGADELWZ.FMDFQZYEHTU<ELPAQFNEADX, FUAZHRRWMOY>
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
				public AsyncTaskMethodBuilder<Result<object, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public FUAZHRRWMOY root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public Id32<VCZWSUVCRXV> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public ELPAQFNEADX action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				private TaskAwaiter<Result<object, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x2AAE0E0", Offset = "0x2AACEE0", VA = "0x182AAE0E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000798")]
				[Cpp2IlInjected.Address(RVA = "0x2AAE320", Offset = "0x2AAD120", VA = "0x182AAE320", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "4")]
			public int DMTTQFWTEDG(FUAZHRRWMOY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2AABB10", Offset = "0x2AAA910", VA = "0x182AABB10", Slot = "5")]
			public int ASUODZTOWAE(FUAZHRRWMOY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2AABC80", Offset = "0x2AAAA80", VA = "0x182AABC80", Slot = "6")]
			public int XHSTINAOAPN(FUAZHRRWMOY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0xFD3A70", Offset = "0xFD2870", VA = "0x180FD3A70", Slot = "7")]
			public int EMFCDWYYTLV(FUAZHRRWMOY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x2AABCA0", Offset = "0x2AAAAA0", VA = "0x182AABCA0", Slot = "8")]
			public void XZZWNENXRDU(FUAZHRRWMOY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "9")]
			public bool HWNLDEIWMBF(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> actorId, ELPAQFNEADX[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "10")]
			public bool BTQNSYLBMWR(FUAZHRRWMOY a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2AABB30", Offset = "0x2AAA930", VA = "0x182AABB30", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, SJKUUBAWOPB>> CMMOBWCVPLD(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> senderId, ELPAQFNEADX b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : ELLZGADELWZ.YUERGOQQINL<ActionDeps, RGZHVGRSJVI.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps SVNCPQCMXVR
			{
				[Cpp2IlInjected.Token(Token = "0x6000799")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public RGZHVGRSJVI.StaticNetSysReceiverDeps NNWJILXMSXW
			{
				[Cpp2IlInjected.Token(Token = "0x600079A")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "5")]
				get
				{
					return default(RGZHVGRSJVI.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps FJBEGZAIDYN
			{
				[Cpp2IlInjected.Token(Token = "0x600079B")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : FCAYKYIDQOT.YTUDMBCVPQT<FUAZHRRWMOY>
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
				public AsyncTaskMethodBuilder<Result<object?, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				public FUAZHRRWMOY root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public Id32<VCZWSUVCRXV> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public ELPAQFNEADX action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				private TaskAwaiter<Result<object?, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x2AADDC0", Offset = "0x2AACBC0", VA = "0x182AADDC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x2AAE070", Offset = "0x2AACE70", VA = "0x182AAE070", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9880", Offset = "0x2AA8680", VA = "0x182AA9880", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, SJKUUBAWOPB>> CMMOBWCVPLD(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> clientId, ELPAQFNEADX b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : LJWWYDZZUNB.YTUDMBCVPQT<FUAZHRRWMOY>
		{
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA91B0", Offset = "0x2AA7FB0", VA = "0x182AA91B0", Slot = "4")]
			public void USVJFAMMEDV(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xFD3AB0", Offset = "0xFD28B0", VA = "0x180FD3AB0", Slot = "5")]
			public Id32<VCZWSUVCRXV>? YWJITKSNYEA(FUAZHRRWMOY a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9120", Offset = "0x2AA7F20", VA = "0x182AA9120")]
			public Id32<FQTHCTXUYZW> ZNNMJZQMKHP(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<FQTHCTXUYZW>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8E60", Offset = "0x2AA7C60", VA = "0x182AA8E60", Slot = "7")]
			public void FRZLKGIDXMW(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2AA91E0", Offset = "0x2AA7FE0", VA = "0x182AA91E0", Slot = "8")]
			public void VEQZMRGASRC(FUAZHRRWMOY a, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2AA93A0", Offset = "0x2AA81A0", VA = "0x182AA93A0", Slot = "9")]
			public void WXFTJJLRMSK(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9180", Offset = "0x2AA7F80", VA = "0x182AA9180", Slot = "10")]
			public void QWPWOJNSTNC(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, XIKUPAMMEQL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2AA93E0", Offset = "0x2AA81E0", VA = "0x182AA93E0", Slot = "11")]
			public void XZOOGKETUTM(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> clientId, Id32<FQTHCTXUYZW> objectId, WOVAONPGCSF? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9090", Offset = "0x2AA7E90", VA = "0x182AA9090", Slot = "12")]
			public Id32<VCZWSUVCRXV>? IWADKNKYAZT(FUAZHRRWMOY a, Id32<FQTHCTXUYZW> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9340", Offset = "0x2AA8140", VA = "0x182AA9340", Slot = "13")]
			public Id32<UACOCYSWUWU> VHZYYHWVFDV(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> clientId, string b, object c, OYGAHFARWRG d, HVXPYDFAQPW e)
			{
				return default(Id32<UACOCYSWUWU>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8EF0", Offset = "0x2AA7CF0", VA = "0x182AA8EF0", Slot = "14")]
			public void IFCKZSGTMUJ(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> clientId, Id32<UACOCYSWUWU> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2AA90F0", Offset = "0x2AA7EF0", VA = "0x182AA90F0", Slot = "15")]
			public void KLMEHFZVJBP(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> clientId, Id32<UACOCYSWUWU> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9120", Offset = "0x2AA7F20", VA = "0x182AA9120", Slot = "6")]
			private Id32<FQTHCTXUYZW> OPXGIYEAMPV(FUAZHRRWMOY a, Id32<VCZWSUVCRXV> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<FQTHCTXUYZW>);
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
			public FUAZHRRWMOY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public Id32<FQTHCTXUYZW>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public RAMVABNVEDJ deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private Id32<VCZWSUVCRXV> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private KQGQLMLRMCJ<FUAZHRRWMOY, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private JSYUJENUFLH<FUAZHRRWMOY, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private RGZHVGRSJVI <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD700", Offset = "0x2AAC500", VA = "0x182AAD700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AADD50", Offset = "0x2AACB50", VA = "0x182AADD50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly MQUGSDDWTGP<ELPAQFNEADX, None, RGZHVGRSJVI, ActionDeps, RGZHVGRSJVI.StaticNetSysReceiverDeps, RootDeps, FUAZHRRWMOY, Deps> JTYMBAQRJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly ORSVDPMMHCT ZMKPLUNFHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private SOAId32<VCZWSUVCRXV> OAQKJHCJVSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAField<VCZWSUVCRXV, None> ETXXFGQLFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<VCZWSUVCRXV, RGZHVGRSJVI> CEVGHBDCNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Id32<VCZWSUVCRXV>? FRDCICAOAKR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate MXLACYTMBBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA0F10", VA = "0x180AA2110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA72B0", Offset = "0x2AA60B0", VA = "0x182AA72B0")]
		public FUAZHRRWMOY(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6BF0", Offset = "0x2AA59F0", VA = "0x182AA6BF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7130", Offset = "0x2AA5F30", VA = "0x182AA7130")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> XEXEALGVYVD(RAMVABNVEDJ a, RegistryV2 b, Id32<FQTHCTXUYZW>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6DC0", Offset = "0x2AA5BC0", VA = "0x182AA6DC0")]
		private void USVJFAMMEDV(Id32<VCZWSUVCRXV> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7050", Offset = "0x2AA5E50", VA = "0x182AA7050")]
		[CompilerGenerated]
		private Id32<FQTHCTXUYZW>? VHMILEZOXFB([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class TKZGQFDTJRD : IYEHCMGHYUZ.XQEIROEEFNO
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<TCDWQQVTIFG> DeserializeCircuitsJunctionAsyncDelegate(RGZHVGRSJVI circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<TCDWQQVTIFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public TKZGQFDTJRD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public RGZHVGRSJVI circuitsManager;

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
			private TaskAwaiter<TCDWQQVTIFG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2AAC3F0", Offset = "0x2AAB1F0", VA = "0x182AAC3F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2AAC5F0", Offset = "0x2AAB3F0", VA = "0x182AAC5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate KBJSKMWTPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly LifecycleDidInitializeDelegate? SFICZPXDKRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleWillDestroyDelegate? VNCHUDTAIXX;

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AABCF0", Offset = "0x2AAAAF0", VA = "0x182AABCF0", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<TCDWQQVTIFG> RYUTOFKJKNL(RGZHVGRSJVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x1061A40", Offset = "0x1060840", VA = "0x181061A40", Slot = "5")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x10F24D0", Offset = "0x10F12D0", VA = "0x1810F24D0", Slot = "6")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AABE60", Offset = "0x2AAAC60", VA = "0x182AABE60")]
		public TKZGQFDTJRD([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class HHAOOFMBBBP : HHBELIZAZTL.XQEIROEEFNO
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate AOAGTNJJCPD GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<ZISFUTTVJRN> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<WNJQWAUFPBV> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<HHBELIZAZTL.XQEIROEEFNO.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<HHBELIZAZTL.XQEIROEEFNO.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public HHAOOFMBBBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			private TaskAwaiter<HHBELIZAZTL.XQEIROEEFNO.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007DD")]
			[Cpp2IlInjected.Address(RVA = "0x2AAC660", Offset = "0x2AAB460", VA = "0x182AAC660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0x2AAC850", Offset = "0x2AAB650", VA = "0x182AAC850", Slot = "5")]
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
			public AsyncTaskMethodBuilder<WNJQWAUFPBV> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public HHAOOFMBBBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private TaskAwaiter<WNJQWAUFPBV> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0x2AAC8C0", Offset = "0x2AAB6C0", VA = "0x182AAC8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x2AACAB0", Offset = "0x2AAB8B0", VA = "0x182AACAB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<ZISFUTTVJRN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public HHAOOFMBBBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			private TaskAwaiter<ZISFUTTVJRN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x2AACB20", Offset = "0x2AAB920", VA = "0x182AACB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x2AACD10", Offset = "0x2AABB10", VA = "0x182AACD10", Slot = "5")]
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
			public HHAOOFMBBBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x2AACD80", Offset = "0x2AABB80", VA = "0x182AACD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x2AACF70", Offset = "0x2AABD70", VA = "0x182AACF70", Slot = "5")]
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
			public HHAOOFMBBBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x2AACFE0", Offset = "0x2AABDE0", VA = "0x182AACFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD1D0", Offset = "0x2AABFD0", VA = "0x182AAD1D0", Slot = "5")]
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
			public HHAOOFMBBBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD240", Offset = "0x2AAC040", VA = "0x182AAD240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD430", Offset = "0x2AAC230", VA = "0x182AAD430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly GetCV2DependenciesDelegate GKOFFQRQTFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetRoomDataAsyncDelegate KUWAOGOGVXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetSuperRoomDataAsyncDelegate JJRSECEIAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetRoomAssetDataAsyncDelegate DKKGAZXYUEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetPlayerSaveDataAsyncDelegate PWQTCWDAHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate NJYHTGLNHHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetStaticCircuitsConfigAsyncDelegate COLINOVVBGH;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AOAGTNJJCPD AOAGTNJJCPD
		{
			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x12EECA0", Offset = "0x12EDAA0", VA = "0x1812EECA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA78B0", Offset = "0x2AA66B0", VA = "0x182AA78B0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> EKNSRJOJMVQ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA79C0", Offset = "0x2AA67C0", VA = "0x182AA79C0", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> GRDISRSROHH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7AD0", Offset = "0x2AA68D0", VA = "0x182AA7AD0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<ZISFUTTVJRN> LKSWFICDDGG(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA77A0", Offset = "0x2AA65A0", VA = "0x182AA77A0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<WNJQWAUFPBV> ABUGSKMZKKH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7BE0", Offset = "0x2AA69E0", VA = "0x182AA7BE0", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<HHBELIZAZTL.XQEIROEEFNO.CircuitGraphToolMapping> OKFCYFIBJXC(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7CF0", Offset = "0x2AA6AF0", VA = "0x182AA7CF0", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> XJSCBWVWLKP(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7E00", Offset = "0x2AA6C00", VA = "0x182AA7E00")]
		public HHAOOFMBBBP(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class AZTOQIIOYJP : CV2Request.XQEIROEEFNO
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly CV2Request.XQEIROEEFNO VDCQJFYBFAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly GetCanSendRequestsDelegate ZDMFJCYLGAB;

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public AZTOQIIOYJP(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x12EECA0", Offset = "0x12EDAA0", VA = "0x1812EECA0", Slot = "4")]
		public bool KSEMDFVAWKJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class KZRLEELYACS : HBKJLPUCFON
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, HEYQXAVABBH> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly TryReportErrToUserDelegate SSBEPOBUQKH;

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8B70", Offset = "0x2AA7970", VA = "0x182AA8B70")]
		public bool BPIJXXNOVRB([In] Result<None, HEYQXAVABBH> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8BA0", Offset = "0x2AA79A0", VA = "0x182AA8BA0")]
		public KZRLEELYACS([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8B70", Offset = "0x2AA7970", VA = "0x182AA8B70", Slot = "4")]
		private bool LVYMEPQEQUY([In] Result<None, HEYQXAVABBH> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class WTHNUPYAUQT : YTSHAVYTUSY
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate MJLOQDUEBTO CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public static readonly WTHNUPYAUQT VDCQJFYBFAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly CurrentExecParamsDelegate? YXCDMWARCVL;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public MJLOQDUEBTO NNRKKJPGEGT
		{
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x12EECA0", Offset = "0x12EDAA0", VA = "0x1812EECA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public WTHNUPYAUQT([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class TMWNYQGNFVR : SKHEHGRSHLY
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly SKHEHGRSHLY VDCQJFYBFAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly GetGameColorFromIdDelegate XMIJBISSWZB;

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8B70", Offset = "0x2AA7970", VA = "0x182AA8B70", Slot = "4")]
		public CircuitsColor NXVCIGDAOQT(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC240", Offset = "0x2AAB040", VA = "0x182AAC240")]
		public TMWNYQGNFVR([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class PFOLIBABHWT : ZPSEWEXFJLQ
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
			public PFOLIBABHWT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public string context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD4A0", Offset = "0x2AAC2A0", VA = "0x182AAD4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080E")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD690", Offset = "0x2AAC490", VA = "0x182AAD690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly IsStringPureAsyncDelegate LWZBCGBZCUW;

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB700", Offset = "0x2AAA500", VA = "0x182AAB700", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> NBFBOFCEUBK(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB840", Offset = "0x2AAA640", VA = "0x182AAB840")]
		public PFOLIBABHWT([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class YCOWAGAEIIJ : EAPBZKKMHYU
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate MRXXYBMJXQA? GetNodeVisualizationConfigDelegate([In] Id128<PXJWRZNPPPA> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly EAPBZKKMHYU VDCQJFYBFAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly GetNodeVisualizationConfigDelegate UWCHNFZPOFL;

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8B70", Offset = "0x2AA7970", VA = "0x182AA8B70")]
		public MRXXYBMJXQA? UVSCQOIEIUJ([In] Id128<PXJWRZNPPPA> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF470", Offset = "0x2AAE270", VA = "0x182AAF470")]
		public YCOWAGAEIIJ([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8B70", Offset = "0x2AA7970", VA = "0x182AA8B70", Slot = "4")]
		private MRXXYBMJXQA IVHEAOEFBZB([In] Id128<PXJWRZNPPPA> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class REXOBLCWKMM : RKOCWUGHZBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x2AABA00", Offset = "0x2AAA800", VA = "0x182AABA00", Slot = "4")]
		public IAFQQJCFIIQ YNAIRBCLZEU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public REXOBLCWKMM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class KFPRQTPFAAI : WPOMOYRBFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly Dictionary<string, bool> GGVLMPWTWSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, float> SAEHDAVIGHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, double> ZHZXJUFWBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, int> ONZQYZRLSKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, long> GSSBUGYYDUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, string> MVVFMYNWUPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, uint> MJKLGEYNHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, ulong> MSPBHZMLZOS;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8860", Offset = "0x2AA7660", VA = "0x182AA8860", Slot = "4")]
		public bool? KMKPNWBEWZL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8900", Offset = "0x2AA7700", VA = "0x182AA8900")]
		public KFPRQTPFAAI()
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
