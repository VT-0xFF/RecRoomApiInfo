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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B06AF0", Offset = "0x2B05AF0", VA = "0x182B06AF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		internal sealed class SHBOMZODBBA : OMPZDKSFJUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public SHBOMZODBBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0", Slot = "4")]
			public OMPZDKSFJUN HTAYBOUZQRH(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0", Slot = "5")]
			public OMPZDKSFJUN LIODAILIIGU(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0", Slot = "6")]
			public OMPZDKSFJUN IDVFIDFJARG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
			public void ZQHOKUWTOCH()
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
	public static class GXCWNAPVOHR
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public ZOGEUBJOXII ZZZBEZROYWF;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B06640", Offset = "0x2B05640", VA = "0x182B06640")]
			internal ZGVEFLJMWTI IMVRLLYZGCM(GetNetworkObjectDelegate a)
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
			public ITTJCCLXRJK dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LHNTXVRCRQX network;

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
			[Cpp2IlInjected.Address(RVA = "0x2B09650", Offset = "0x2B08650", VA = "0x182B09650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B09CF0", Offset = "0x2B08CF0", VA = "0x182B09CF0", Slot = "5")]
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
			public LHNTXVRCRQX network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ITTJCCLXRJK dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<ZKEUEWDMUHX>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private COWOBFPVIKZ <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B09D60", Offset = "0x2B08D60", VA = "0x182B09D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A2F0", Offset = "0x2B092F0", VA = "0x182B0A2F0", Slot = "5")]
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
			public ZOGEUBJOXII roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A360", Offset = "0x2B09360", VA = "0x182B0A360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A870", Offset = "0x2B09870", VA = "0x182B0A870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B02C90", Offset = "0x2B01C90", VA = "0x182B02C90")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? XXTMRWLRDEW([Optional] ZOGEUBJOXII? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B02A10", Offset = "0x2B01A10", VA = "0x182B02A10")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> UYFHVUASJQP(LHNTXVRCRQX a, [Optional] ITTJCCLXRJK? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B02880", Offset = "0x2B01880", VA = "0x182B02880")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> UYFHVUASJQP(LHNTXVRCRQX a, ITTJCCLXRJK b, RegistryV2 c, Id32<ZKEUEWDMUHX>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B027B0", Offset = "0x2B017B0", VA = "0x182B027B0")]
		public static (RuntimeFnRegistry, RuntimeFns) TIGKGNKBNPV()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B02B90", Offset = "0x2B01B90", VA = "0x182B02B90")]
		public static (ExternalFnRegistry, ExternalFns) WRZUCQTRJDO()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B02730", Offset = "0x2B01730", VA = "0x182B02730")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static LHNTXVRCRQX DWUNVPOXKZD(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class SGSKTFWFREL
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate ZGVEFLJMWTI CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public SGSKTFWFREL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B09260", Offset = "0x2B08260", VA = "0x182B09260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B095E0", Offset = "0x2B085E0", VA = "0x182B095E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly LHNTXVRCRQX AXUAXIKIYRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? FIYTUPDDPBL;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		private SGSKTFWFREL(LHNTXVRCRQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B07130", Offset = "0x2B06130", VA = "0x182B07130")]
		public static SGSKTFWFREL FACRFPUWRCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B071E0", Offset = "0x2B061E0", VA = "0x182B071E0")]
		public SGSKTFWFREL UOIHXIQXFWS(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B07200", Offset = "0x2B06200", VA = "0x182B07200")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> ZQHOKUWTOCH()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class IFQOCVPHVWF : COWOBFPVIKZ.UYPXTMTCQYP
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate RZKCOKFPWZF NewCircuitsLifecycleDelegate(VWOBBTEHFZU.UYPXTMTCQYP deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(COWOBFPVIKZ circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(COWOBFPVIKZ circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate WKKTFOPURAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate UCUGLPAOJSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate ZBFTVLBLZFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate QAUYILQXBYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate IHWXXURLAVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate SQWQLYGAFXG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int TGLERDWXTFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x12C44A0", Offset = "0x12C34A0", VA = "0x1812C44A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B059F0", Offset = "0x2B049F0", VA = "0x182B059F0", Slot = "6")]
		public void PIUMIAWMBPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B059C0", Offset = "0x2B049C0", VA = "0x182B059C0", Slot = "7")]
		public void DCEQZLTZWHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B05A20", Offset = "0x2B04A20", VA = "0x182B05A20", Slot = "5")]
		public RZKCOKFPWZF UGOFEYAQNZW(VWOBBTEHFZU.UYPXTMTCQYP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF097E0", Offset = "0xF087E0", VA = "0x180F097E0", Slot = "8")]
		public void FGQGFVNGOBH(COWOBFPVIKZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF09810", Offset = "0xF08810", VA = "0x180F09810", Slot = "9")]
		public void OIMJRSDSENM(COWOBFPVIKZ a, PYPEGOPZPPS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B05A50", Offset = "0x2B04A50", VA = "0x182B05A50")]
		public IFQOCVPHVWF([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly YFDAPENMPOM<LHNTXVRCRQX, LHNTXVRCRQX.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly RFWPTPAMTQY<LHNTXVRCRQX, LHNTXVRCRQX.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly COWOBFPVIKZ CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<WNPWZNYIVVQ> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly LHNTXVRCRQX Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B02670", Offset = "0x2B01670", VA = "0x182B02670")]
		public EVCreationResult(YFDAPENMPOM<LHNTXVRCRQX, LHNTXVRCRQX.MockStaticNetSysDeps> staticNetSys, RFWPTPAMTQY<LHNTXVRCRQX, LHNTXVRCRQX.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, COWOBFPVIKZ circuitsManager, Id32<WNPWZNYIVVQ> clientId, LHNTXVRCRQX network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly COWOBFPVIKZ _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 PCPGISLQBPT
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B06940", Offset = "0x2B05940", VA = "0x182B06940")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request DCYTPWEWWSH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B06970", Offset = "0x2B05970", VA = "0x182B06970")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public SEQOFYDKXBO? KBPURTNFGWH
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2B069A0", Offset = "0x2B059A0", VA = "0x182B069A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public FZLXAJZQSFG? DNGQBKSNALR
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2B06A90", Offset = "0x2B05A90", VA = "0x182B06A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		internal LimitedCircuits(COWOBFPVIKZ circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class BWFROQECPEB : ITTJCCLXRJK
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class VQGYMAEOONZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ZGVEFLJMWTI QCBADUJDCDA;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VQGYMAEOONZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			internal ZGVEFLJMWTI TKILWCKIYPC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public VWOBBTEHFZU.UYPXTMTCQYP XXRHGSDVDGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public COWOBFPVIKZ.UYPXTMTCQYP NRNPGXXKVKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ZJXORRQKNEA.UYPXTMTCQYP BTQPUYQWRZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ> WKZLHXAPLUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.UYPXTMTCQYP RPJYXJCXWYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MTGSWKHGETU KUVBRNXXCXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RYRAUZOHXNB PTRPROVCCXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HRTUZVSWSVJ VZLAGHYLIGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ETFDRUOMIST HJOPHRGSYEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public STIVPCHXXDL CHTEPJGYIBK
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B00E80", Offset = "0x2AFFE80", VA = "0x182B00E80")]
		private BWFROQECPEB(VWOBBTEHFZU.UYPXTMTCQYP a, COWOBFPVIKZ.UYPXTMTCQYP b, ZJXORRQKNEA.UYPXTMTCQYP c, XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ> d, CV2Request.UYPXTMTCQYP e, MTGSWKHGETU f, RYRAUZOHXNB g, HRTUZVSWSVJ h, ETFDRUOMIST i, STIVPCHXXDL j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B007A0", Offset = "0x2AFF7A0", VA = "0x182B007A0")]
		public static BWFROQECPEB? PDOZLURDGWS(ZJXORRQKNEA.UYPXTMTCQYP cv2RootSysDeps, [Optional] VWOBBTEHFZU.UYPXTMTCQYP? a, [Optional] COWOBFPVIKZ.UYPXTMTCQYP? b, [Optional] XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>? reducerDeps, [Optional] CV2Request.UYPXTMTCQYP? c, [Optional] MTGSWKHGETU? d, [Optional] RYRAUZOHXNB? e, [Optional] HRTUZVSWSVJ? f, [Optional] ETFDRUOMIST? g, [Optional] STIVPCHXXDL? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B00650", Offset = "0x2AFF650", VA = "0x182B00650")]
		public static BWFROQECPEB DFFADDEJOZQ(ZGVEFLJMWTI a, [Optional] VWOBBTEHFZU.UYPXTMTCQYP? circuitsLifecycleDeps, [Optional] COWOBFPVIKZ.UYPXTMTCQYP? circuitsManagerDeps, [Optional] XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B00B00", Offset = "0x2AFFB00", VA = "0x182B00B00")]
		public static BWFROQECPEB WROGHZXIWMU(GetNetworkObjectDelegate a, [Optional] VWOBBTEHFZU.UYPXTMTCQYP? circuitsLifecycleDeps, [Optional] COWOBFPVIKZ.UYPXTMTCQYP? circuitsManagerDeps, [Optional] XIDNEOUUSCG.IULAIVKNAGW<ActionKind, PYPEGOPZPPS, COWOBFPVIKZ>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class ADHXGUWXIDG
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GZTFKPJKAMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public GetNetworkObjectDelegate MFRTNDYVKUQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int EWLTBOFDVBY;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GZTFKPJKAMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B02E30", Offset = "0x2B01E30", VA = "0x182B02E30")]
			internal RQAWMUULEWV VIQNFCISYWD(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2B02EA0", Offset = "0x2B01EA0", VA = "0x182B02EA0")]
			internal RQAWMUULEWV[] VJQVRKEFUAW(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			internal int GKWNTGEABAC()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class GZNYNIPMRAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public DynamicEnvironmentNetworkId HGMFXORDRFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public GZTFKPJKAMH LWPGXDDEGGX;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GZNYNIPMRAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B02D80", Offset = "0x2B01D80", VA = "0x182B02D80")]
			internal RQAWMUULEWV BKVLQTLIFTR(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly CICCQXNQDHP HTDPNBVYJHI;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB890", Offset = "0x2AFA890", VA = "0x182AFB890")]
		public static RQAWMUULEWV? SKSODAHMTZY(Id32<ZKEUEWDMUHX>? networkObject, [Optional] BPYESIKPMVO.SerializesIntoSavesDelegate? a, [Optional] BPYESIKPMVO.SerializesIntoInventionsDelegate? b, [Optional] BPYESIKPMVO.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB8B0", Offset = "0x2AFA8B0", VA = "0x182AFB8B0")]
		public static ZGVEFLJMWTI? YEAFNAEXJAH(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] ZTOKIRXYVVD? b, [Optional] JGMCRFMZQTH? c, [Optional] CANLMMVKSHD? d, [Optional] ZOGEUBJOXII? e, int f = 300000, bool g = false, bool h = false, [Optional] MUEQVVHJGCN? i, [Optional] FUMFFHDWUJT? j, [Optional] DTYNJUEFQQO? k, [Optional] CTIPDVQYPIR? l, [Optional] ZTXKWPAGFFI? m, [Optional] HHOYTZPGKUR? n, [Optional] ZMMVBSVWDCT.UYPXTMTCQYP? o, [Optional] EqualsNodeV2.UYPXTMTCQYP? p, [Optional] IDFTFFZBPOV? q, [Optional] ZGVEFLJMWTI.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] ZGVEFLJMWTI.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] ZGVEFLJMWTI.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] ZGVEFLJMWTI.GetLocalRoomIdDelegate? u, [Optional] ZGVEFLJMWTI.GetLocalSubroomIdDelegate? v, [Optional] ZGVEFLJMWTI.GetSubroomIdsForLocalRoomDelegate? w, [Optional] ZGVEFLJMWTI.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] ZGVEFLJMWTI.SaveRoomOnPlayerBehalfDelegate? z, [Optional] ZGVEFLJMWTI.ReportCloudDataLedgerChangedDelegate? ba, [Optional] ZGVEFLJMWTI.GetColorNameByIdDelegate? bb, [Optional] ZGVEFLJMWTI.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] ZGVEFLJMWTI.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] ZGVEFLJMWTI.GetTaggableNameFromSignalDelegate? be, [Optional] ZGVEFLJMWTI.GetAudioNameFromSignalDelegate? bf, [Optional] ZGVEFLJMWTI.GetDestinationNameFromSignalDelegate? bg, [Optional] ZGVEFLJMWTI.GetPlayerEventNameFromSignalDelegate? bh, [Optional] ZGVEFLJMWTI.GetRoomKeyNameFromSignalDelegate? bi, [Optional] ZGVEFLJMWTI.GetRewardNameFromSignalDelegate? bj, [Optional] ZGVEFLJMWTI.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] ZGVEFLJMWTI.ReportPreloadedAudioChangedDelegate? bl, [Optional] ZGVEFLJMWTI.ReportRewardDataChangedDelegate? bm, [Optional] ZGVEFLJMWTI.GetConsumableNameFromSignalDelegate? bn, [Optional] ZGVEFLJMWTI.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] ZGVEFLJMWTI.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] ZGVEFLJMWTI.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] ZGVEFLJMWTI.GetInventoryItemNameFromSignalDelegate? br, [Optional] ZGVEFLJMWTI.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] ZGVEFLJMWTI.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] ZGVEFLJMWTI.GetRoomOfferNameFromSignalDelegate? bu, [Optional] ZGVEFLJMWTI.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] ZGVEFLJMWTI.GetObjectIdFromCreationObjectDelegate? bw, [Optional] ZGVEFLJMWTI.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] ZGVEFLJMWTI.GetCostInBytesDelegate? by, [Optional] ZGVEFLJMWTI.GetAvatarItemNameFromSignalDelegate? bz, [Optional] ZGVEFLJMWTI.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] ZGVEFLJMWTI.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] ZGVEFLJMWTI.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] ZGVEFLJMWTI.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] ZGVEFLJMWTI.GetStoreItemNameFromSignalDelegate? ce, [Optional] ZGVEFLJMWTI.GetBodyPartNameFromSignalDelegate? cf, [Optional] ZGVEFLJMWTI.GetDependenciesForGraphInstanceDelegate? cg, [Optional] ZGVEFLJMWTI.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] ZGVEFLJMWTI.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] ZGVEFLJMWTI.GetRecNetImageNameFromSignalDelegate? cj, [Optional] ZGVEFLJMWTI.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] ZGVEFLJMWTI.IsFunctionValidForAIDelegate? cm, [Optional] ZGVEFLJMWTI.GetAIFunctionNameFromSignalDelegate? cn, [Optional] ZGVEFLJMWTI.FromSerializableObjectDelegate? co, [Optional] ZGVEFLJMWTI.ToSerializableObjectDelegate? cp)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<ZKEUEWDMUHX>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class KHIWPYXNQEX : DTYNJUEFQQO
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly KHIWPYXNQEX CIARLSLMHCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly GetLocalPlayerDelegate? GVKUQWHYHTQ;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2B06550", Offset = "0x2B05550", VA = "0x182B06550", Slot = "4")]
		public (KKKCNDDXQVJ, KKKCNDDXQVJ, KKKCNDDXQVJ, KKKCNDDXQVJ, KKKCNDDXQVJ) MCFAKGWNQIF(object a)
		{
			return default((KKKCNDDXQVJ, KKKCNDDXQVJ, KKKCNDDXQVJ, KKKCNDDXQVJ, KKKCNDDXQVJ));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B06520", Offset = "0x2B05520", VA = "0x182B06520", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "6")]
		public bool GJGEGYFMMBK(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD5A580", Offset = "0xD59580", VA = "0x180D5A580", Slot = "7")]
		public string QOXGGEJDGZM(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public KHIWPYXNQEX([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class BPYESIKPMVO : RQAWMUULEWV
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(BPYESIKPMVO self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(BPYESIKPMVO self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(BPYESIKPMVO self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly SerializesIntoSavesDelegate KKWRQGAXARV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly SerializesIntoInventionsDelegate CWDSMJRCRAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly CanPublishInInventionsDelegate NMUAWOCQGJP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private YOBCWGOMCTR? NONQGWJVIYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId BHUBLIKKZYK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xFCA0E0", Offset = "0xFC90E0", VA = "0x180FCA0E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool TLMYWVRGGFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B00620", Offset = "0x2AFF620", VA = "0x182B00620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool VAYKPMIWBWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B005F0", Offset = "0x2AFF5F0", VA = "0x182B005F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool RUOOVSNQCNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B005C0", Offset = "0x2AFF5C0", VA = "0x182B005C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IOXRTCWXSRE? YVEALIXXOTP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<ZKEUEWDMUHX>? QRHDVOUWTWD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B00470", Offset = "0x2AFF470", VA = "0x182B00470", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFF00", Offset = "0x2AFEF00", VA = "0x182AFFF00", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(CICCQXNQDHP e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30", Slot = "13")]
		public void Bind(YOBCWGOMCTR controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B00510", Offset = "0x2AFF510", VA = "0x182B00510")]
		private BPYESIKPMVO(Id32<ZKEUEWDMUHX>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFFA0", Offset = "0x2AFEFA0", VA = "0x182AFFFA0")]
		public static BPYESIKPMVO? New(Id32<ZKEUEWDMUHX>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class IBVSLKJWNFW : MUEQVVHJGCN
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
		public static readonly IBVSLKJWNFW CIARLSLMHCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly RoundToDecimalPlaceDelegate? AZADFOEHTFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly TruncateToDecimalPlaceDelegate? XVTDJKFZLIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsColorLerpDelegate? QPOCYHZEQNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsColorInverseLerpDelegate? LHCDEHAKXUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4GetPositionDelegate? OVHPNCGOXRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4GetRotationDelegate? GVHNKRAKQDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsMtx4x4InverseDelegate? SJEZPNKGBWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsMtx4x4MultiplyDelegate? ZEYJHGHYRXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? LRDBAHVFPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatDotDelegate? FOLVBNXNQKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromAngleAxisDelegate? RQRDBTJALRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? PUPMTSXATUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatFromFromToRotationDelegate? JPSEIVOPNGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatFromLookRotationDelegate? BSUQYCNRWTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? TBBZQCBNQHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseDelegate? SUVXLWAYUQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatLerpDelegate? BEAWJMYQBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatLerpUnclampedDelegate? MUOVJFEEZBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatInverseLerpDelegate? IQTGOMMQXGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatMultiplyDelegate? RUUHCAIJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatNormalizeDelegate? HKGMMGGZNUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatRotateTowardsDelegate? WSETGKKIELT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatRotateVectorDelegate? HZAVACCHXIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatSlerpDelegate? IUFJHJGSCTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsQuatToAngleAxisDelegate? YUMGRTLPEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsQuatToEulerAnglesDelegate? SUKZJYLNEWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3AddDelegate? CHVLJSCMIEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? IBGQCGPZZMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? UEXPZIQOOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3CrossDelegate? CLKQUALGFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3DotDelegate? YMMUVWCJLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3AngleDelegate? TZFNQNQSRRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3GetMagnitudeDelegate? URKTDFHTJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3LerpDelegate? EUXROUNUWAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3LerpUnclampedDelegate? TXNEKYMTMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3InverseLerpDelegate? GFLTWYZQJUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3MoveTowardsDelegate? CGBOCQRNHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3NegateDelegate? CDRSFDXAVOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3NormalizeDelegate? CXLUXVDVYVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ProjectDelegate? WJZOJTCBVUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? PDSIXGSYFAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3ScaleDelegate? OJWWJPWLRAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SmoothDampDelegate? MGXGSPMDAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3SubtractDelegate? NBYECFZMVKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3SlerpDelegate? MDVNNOFMXBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly CircuitsVec3TransformDelegate? DOLROKQUVPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CircuitsVec3InverseTransformDelegate? EKYNCMAMGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly RealtimeSinceStartupDelegate? TPEJNXPWYDL;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B054E0", Offset = "0x2B044E0", VA = "0x182B054E0")]
		public IBVSLKJWNFW([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B049A0", Offset = "0x2B039A0", VA = "0x182B049A0")]
		public float PXXUQTWQHJH([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B04600", Offset = "0x2B03600", VA = "0x182B04600")]
		public float WWQAMWUQXDV([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B04E70", Offset = "0x2B03E70", VA = "0x182B04E70")]
		public CircuitsColor UVPZMWVIVUQ([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B04970", Offset = "0x2B03970", VA = "0x182B04970")]
		public float XLEFMZQJYEG([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B047A0", Offset = "0x2B037A0", VA = "0x182B047A0")]
		public CircuitsVec3 NBEQQLMLPKW([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B04800", Offset = "0x2B03800", VA = "0x182B04800")]
		public CircuitsQuat NUQYYMYIPSL([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B04390", Offset = "0x2B03390", VA = "0x182B04390")]
		public CircuitsMtx4x4 JQPCYDMNKDL([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B04730", Offset = "0x2B03730", VA = "0x182B04730")]
		public CircuitsMtx4x4 MOLPVVEYKEP([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B04B80", Offset = "0x2B03B80", VA = "0x182B04B80")]
		public CircuitsMtx4x4 RKPDXUTAOAP([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B04F30", Offset = "0x2B03F30", VA = "0x182B04F30")]
		public float VZWSTVXOVRC([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B03E70", Offset = "0x2B02E70", VA = "0x182B03E70")]
		public CircuitsQuat SWSPJRGLCTL(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B03700", Offset = "0x2B02700", VA = "0x182B03700")]
		public CircuitsQuat CBECGQWEPHE([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B03490", Offset = "0x2B02490", VA = "0x182B03490")]
		public CircuitsQuat KSDCRWSGXCS([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B04090", Offset = "0x2B03090", VA = "0x182B04090")]
		public CircuitsQuat IEZMMQSFOCI([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B03660", Offset = "0x2B02660", VA = "0x182B03660")]
		public CircuitsQuat YCLOKIEVVKT([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B04400", Offset = "0x2B03400", VA = "0x182B04400")]
		public CircuitsQuat JRRZVCWHWGM([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B03C70", Offset = "0x2B02C70", VA = "0x182B03C70")]
		public CircuitsQuat YYNVFSUZRXJ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B04700", Offset = "0x2B03700", VA = "0x182B04700")]
		public float MOHWFBEBVVM([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B03F20", Offset = "0x2B02F20", VA = "0x182B03F20")]
		public CircuitsQuat HUIOGNZDECJ([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B03A80", Offset = "0x2B02A80", VA = "0x182B03A80")]
		public CircuitsQuat VDMDJWSGEGA([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B03930", Offset = "0x2B02930", VA = "0x182B03930")]
		public CircuitsQuat FPKFEIQYMSG([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B041D0", Offset = "0x2B031D0", VA = "0x182B041D0")]
		public CircuitsVec3 IUPSHNFSZWR([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B03B90", Offset = "0x2B02B90", VA = "0x182B03B90")]
		public CircuitsQuat KQYAUGGDSNV([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B048C0", Offset = "0x2B038C0", VA = "0x182B048C0")]
		public void OVMQAGJMBHQ([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B04A30", Offset = "0x2B03A30", VA = "0x182B04A30")]
		public CircuitsVec3 QHHRIZTRWZP([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B04F50", Offset = "0x2B03F50", VA = "0x182B04F50")]
		public CircuitsVec3 VZEQIZKAMTW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B035F0", Offset = "0x2B025F0", VA = "0x182B035F0")]
		public CircuitsVec3 BPVLBTMHFFM([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B03D90", Offset = "0x2B02D90", VA = "0x182B03D90")]
		public CircuitsVec3 HJZYNFRMCQL([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B04FF0", Offset = "0x2B03FF0", VA = "0x182B04FF0")]
		public CircuitsVec3 XDBZXARQCOX([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B04B60", Offset = "0x2B03B60", VA = "0x182B04B60")]
		public float QTZODEZFPPG([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B039F0", Offset = "0x2B029F0", VA = "0x182B039F0")]
		public float EUQNBASGFSA([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B03C50", Offset = "0x2B02C50", VA = "0x182B03C50")]
		public float ISUWKFQBMBB([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B04850", Offset = "0x2B03850", VA = "0x182B04850")]
		public CircuitsVec3 OJGIBFRIWEY([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B05060", Offset = "0x2B04060", VA = "0x182B05060")]
		public CircuitsVec3 XDTVFJQZJZF([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B041A0", Offset = "0x2B031A0", VA = "0x182B041A0")]
		public float YRHEFVUTFXY([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B03420", Offset = "0x2B02420", VA = "0x182B03420")]
		public CircuitsVec3 AFKSRMGCMVG([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B038D0", Offset = "0x2B028D0", VA = "0x182B038D0")]
		public CircuitsVec3 DPKBDHOSPRV([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B044C0", Offset = "0x2B034C0", VA = "0x182B044C0")]
		public CircuitsVec3 JSGGLCRJRZG([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B03B20", Offset = "0x2B02B20", VA = "0x182B03B20")]
		public CircuitsVec3 FFOICWDURQK([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B04620", Offset = "0x2B03620", VA = "0x182B04620")]
		public CircuitsVec3 KXSOFUTNFBJ([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B04240", Offset = "0x2B03240", VA = "0x182B04240")]
		public CircuitsVec3 JHIVQTDBJCB([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B05140", Offset = "0x2B04140", VA = "0x182B05140")]
		public CircuitsVec3 XWEIGKZPXBX([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B04E00", Offset = "0x2B03E00", VA = "0x182B04E00")]
		public CircuitsVec3 TKQQYVPLVQF([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B03860", Offset = "0x2B02860", VA = "0x182B03860")]
		public CircuitsVec3 DODNUEXXMBF([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B04CB0", Offset = "0x2B03CB0", VA = "0x182B04CB0")]
		public CircuitsVec3 SDIAPAQZEFB([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B04900", Offset = "0x2B03900", VA = "0x182B04900")]
		public CircuitsVec3 PAJDQGFAZGF([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B04FC0", Offset = "0x2B03FC0", VA = "0x182B04FC0", Slot = "50")]
		public Task XBCEUDOGQQT(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "51")]
		public void AAAZLOOTSIH([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B041F0", VA = "0x182B051F0", Slot = "52")]
		public VOKBUVCZHVM<OJVRFOETZQC> XWYWKFWOVDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B035A0", Offset = "0x2B025A0", VA = "0x182B035A0", Slot = "53")]
		public VOKBUVCZHVM<OJVRFOETZQC> BMQXMNGZCTQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B03390", Offset = "0x2B02390", VA = "0x182B03390", Slot = "54")]
		public float ABNWLMVPNTG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B049A0", Offset = "0x2B039A0", VA = "0x182B049A0", Slot = "4")]
		private float UPFRQNIMRMH([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B04600", Offset = "0x2B03600", VA = "0x182B04600", Slot = "5")]
		private float KSKXZUBIELD([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B04140", Offset = "0x2B03140", VA = "0x182B04140", Slot = "6")]
		private CircuitsColor IOCRXQMJYLI([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B04970", Offset = "0x2B03970", VA = "0x182B04970", Slot = "7")]
		private float PNRUIMWIDFG([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B03800", Offset = "0x2B02800", VA = "0x182B03800", Slot = "8")]
		private CircuitsVec3 CPVXLFIZBPG([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C60", Offset = "0x2B03C60", VA = "0x182B04C60", Slot = "9")]
		private CircuitsQuat RYJDWDBPTWF([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B05240", Offset = "0x2B04240", VA = "0x182B05240", Slot = "10")]
		private CircuitsMtx4x4 YSXBFHKMISL([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B03540", Offset = "0x2B02540", VA = "0x182B03540", Slot = "11")]
		private CircuitsMtx4x4 BEFQSHVGIQR([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B037A0", Offset = "0x2B027A0", VA = "0x182B037A0", Slot = "12")]
		private CircuitsMtx4x4 CEXLGIDLOOB([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B04F30", Offset = "0x2B03F30", VA = "0x182B04F30", Slot = "13")]
		private float UYQBRCRDITM([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B03E70", Offset = "0x2B02E70", VA = "0x182B03E70", Slot = "14")]
		private CircuitsQuat HPGLNZCKQZV(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B03700", Offset = "0x2B02700", VA = "0x182B03700", Slot = "15")]
		private CircuitsQuat OFTKYXPLTVK([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2B03490", Offset = "0x2B02490", VA = "0x182B03490", Slot = "16")]
		private CircuitsQuat ALUXYXWYRGQ([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2B04090", Offset = "0x2B03090", VA = "0x182B04090", Slot = "17")]
		private CircuitsQuat XHEPEUJDBIS([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B03660", Offset = "0x2B02660", VA = "0x182B03660", Slot = "18")]
		private CircuitsQuat BZVJMYUVTQN([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B04400", Offset = "0x2B03400", VA = "0x182B04400", Slot = "19")]
		private CircuitsQuat WSUQBCXOGOK([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B03C70", Offset = "0x2B02C70", VA = "0x182B03C70", Slot = "20")]
		private CircuitsQuat GFHRYJCRCLH([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B04700", Offset = "0x2B03700", VA = "0x182B04700", Slot = "21")]
		private float THSBQBNMKXG([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B03F20", Offset = "0x2B02F20", VA = "0x182B03F20", Slot = "22")]
		private CircuitsQuat OFRMXOPDQZF([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B03A80", Offset = "0x2B02A80", VA = "0x182B03A80", Slot = "23")]
		private CircuitsQuat FEBUVRANVPA([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B03930", Offset = "0x2B02930", VA = "0x182B03930", Slot = "24")]
		private CircuitsQuat DXKZEXZJQNO([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B052A0", Offset = "0x2B042A0", VA = "0x182B052A0", Slot = "25")]
		private CircuitsVec3 ZXNKQHUEVMX([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B03B90", Offset = "0x2B02B90", VA = "0x182B03B90", Slot = "26")]
		private CircuitsQuat FQLBINDMANT([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B048C0", Offset = "0x2B038C0", VA = "0x182B048C0", Slot = "27")]
		private void VPTGTLYEWCU([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B03D30", Offset = "0x2B02D30", VA = "0x182B03D30", Slot = "28")]
		private CircuitsVec3 HJOATGCLIYL([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B03E00", Offset = "0x2B02E00", VA = "0x182B03E00", Slot = "29")]
		private CircuitsVec3 HNGQNLZPWAG([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B04D90", Offset = "0x2B03D90", VA = "0x182B04D90", Slot = "30")]
		private CircuitsVec3 SXVJFBRQDOU([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2B03A10", Offset = "0x2B02A10", VA = "0x182B03A10", Slot = "31")]
		private CircuitsVec3 FDFWGXPNXBL([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2B04AF0", Offset = "0x2B03AF0", VA = "0x182B04AF0", Slot = "32")]
		private CircuitsVec3 QNKIMLNNTXX([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2B04520", Offset = "0x2B03520", VA = "0x182B04520", Slot = "33")]
		private CircuitsVec3 KDAQYIIXYXH([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B04D20", Offset = "0x2B03D20", VA = "0x182B04D20", Slot = "34")]
		private CircuitsVec3 STDSKZIJDIX([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2B04B60", Offset = "0x2B03B60", VA = "0x182B04B60", Slot = "35")]
		private float XRZVIJUPVPM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B039F0", Offset = "0x2B029F0", VA = "0x182B039F0", Slot = "36")]
		private float XNYWUXZSYZY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B03C50", Offset = "0x2B02C50", VA = "0x182B03C50", Slot = "37")]
		private float FYMEKRDJTVX([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B033B0", Offset = "0x2B023B0", VA = "0x182B033B0", Slot = "38")]
		private CircuitsVec3 ABXAFHAWJFE([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B050D0", Offset = "0x2B040D0", VA = "0x182B050D0", Slot = "39")]
		private CircuitsVec3 XJFTGYRPUAR([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B041A0", Offset = "0x2B031A0", VA = "0x182B041A0", Slot = "40")]
		private float IQXRBRWAPPG([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B04590", Offset = "0x2B03590", VA = "0x182B04590", Slot = "41")]
		private CircuitsVec3 KGCIDBCMPHI([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B04A90", Offset = "0x2B03A90", VA = "0x182B04A90", Slot = "42")]
		private CircuitsVec3 QKGSZZJXUZH([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B04ED0", Offset = "0x2B03ED0", VA = "0x182B04ED0", Slot = "43")]
		private CircuitsVec3 UYCLXPMNXEC([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B042B0", Offset = "0x2B032B0", VA = "0x182B042B0", Slot = "44")]
		private CircuitsVec3 JLITYLGXNZK([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B04320", Offset = "0x2B03320", VA = "0x182B04320", Slot = "45")]
		private CircuitsVec3 JNHUYRZKCTT([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2B04BF0", Offset = "0x2B03BF0", VA = "0x182B04BF0", Slot = "46")]
		private CircuitsVec3 RKQPBRQEHTR([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2B03FD0", Offset = "0x2B02FD0", VA = "0x182B03FD0", Slot = "47")]
		private CircuitsVec3 HUTHHTQSZBR([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B04690", Offset = "0x2B03690", VA = "0x182B04690", Slot = "48")]
		private CircuitsVec3 LOESNKLNLRZ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B049C0", Offset = "0x2B039C0", VA = "0x182B049C0", Slot = "49")]
		private CircuitsVec3 QBMDRVQJZBD([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class GJHHFTKCFAQ : HTHIIGWDLBH
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x132CAF0", Offset = "0x132BAF0", VA = "0x18132CAF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x11327E0", Offset = "0x11317E0", VA = "0x1811327E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2B026E0", Offset = "0x2B016E0", VA = "0x182B026E0")]
		public GJHHFTKCFAQ(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class XVCJHCLIRLK : FUMFFHDWUJT
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(DVEOKZPITUG e, IQHYCGXSJVP invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly XVCJHCLIRLK CIARLSLMHCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly GetCircuitsColorFromColorIndexDelegate? MPGJQTNXWMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? GSDJIKHHSTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly InvisibleCollisionSetEnabledDelegate? BJACHLUBCNW;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xDDB9F0", Offset = "0xDDA9F0", VA = "0x180DDB9F0")]
		public XVCJHCLIRLK([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BA60", Offset = "0x2B0AA60", VA = "0x182B0BA60", Slot = "4")]
		public CircuitsColor BXYCLBIEYQE(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BA40", Offset = "0x2B0AA40", VA = "0x182B0BA40")]
		public int AJHTLLFGPCE([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BA40", Offset = "0x2B0AA40", VA = "0x182B0BA40", Slot = "5")]
		private int BJXNQQIKMJL([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class DVEQCOADMLF : MUGXSQEAGJK
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class VQOOCMRMWLS
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid KJKUTSYVYPO
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long AIXZMHKRXLX
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int ONLOMXZJQLJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xCFBA70", Offset = "0xCFAA70", VA = "0x180CFBA70")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool QCJHQKNOHHU
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x1B09BD0", Offset = "0x1B08BD0", VA = "0x181B09BD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool SFVPKKRLGEG
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x1B09490", Offset = "0x1B08490", VA = "0x181B09490")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool VLAZEAYPUWD
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B0B9C0", Offset = "0x2B0A9C0", VA = "0x182B0B9C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B9E0", Offset = "0x2B0A9E0", VA = "0x182B0B9E0")]
			public VQOOCMRMWLS(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<Id128<ISSDUATOTVT>, VQOOCMRMWLS> HGHVNGHKQEF;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2B02120", Offset = "0x2B01120", VA = "0x182B02120")]
		public bool BLGCGKCFAOU([In] Id128<ISSDUATOTVT> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B02230", Offset = "0x2B01230", VA = "0x182B02230")]
		public void CPPIYJVZUAM([In] Id128<ISSDUATOTVT> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2B02300", Offset = "0x2B01300", VA = "0x182B02300")]
		public void CPPIYJVZUAM([In] Id128<ISSDUATOTVT> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B02440", Offset = "0x2B01440", VA = "0x182B02440")]
		public void IDIQYRHOBFP([In] Id128<ISSDUATOTVT> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2B023E0", Offset = "0x2B013E0", VA = "0x182B023E0")]
		public void NYXDKNXIIFM([In] Id128<ISSDUATOTVT> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2B02560", Offset = "0x2B01560", VA = "0x182B02560")]
		public bool QCJHQKNOHHU([In] Id128<ISSDUATOTVT> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2B025F0", Offset = "0x2B015F0", VA = "0x182B025F0")]
		public DVEQCOADMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2B02120", Offset = "0x2B01120", VA = "0x182B02120", Slot = "4")]
		private bool DVQXALNMSON([In] Id128<ISSDUATOTVT> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2B02230", Offset = "0x2B01230", VA = "0x182B02230", Slot = "5")]
		private void CYAHQBHUDGF([In] Id128<ISSDUATOTVT> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2B02440", Offset = "0x2B01440", VA = "0x182B02440", Slot = "6")]
		private void IFOLBLORJZG([In] Id128<ISSDUATOTVT> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2B023E0", Offset = "0x2B013E0", VA = "0x182B023E0", Slot = "7")]
		private void DYXIPPWFKFJ([In] Id128<ISSDUATOTVT> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2B02560", Offset = "0x2B01560", VA = "0x182B02560", Slot = "8")]
		private bool KCLWNEITTJL([In] Id128<ISSDUATOTVT> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class RZZSQJRMZKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B06C20", Offset = "0x2B05C20", VA = "0x182B06C20")]
		public static LogDeps DFKUGBEFFMP()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class UDESVRCMEVD : MeshLibrary.UYPXTMTCQYP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
		public byte[]? ZWOHDKFPKMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
		public void MOKYBWBNCQV(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public UDESVRCMEVD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class SJEWSOJWSZU : ZTOKIRXYVVD
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
		public delegate void ConfigureAttachedObjectDelegate(FMYNRNNNIYD controlPanel, SNXISRUYHOD staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<SKCKNIYGNEU> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, MCRZZCNKUJE>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, MCRZZCNKUJE>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, MCRZZCNKUJE>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, MCRZZCNKUJE>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public Task<Result<MultiResult, MCRZZCNKUJE>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private TaskAwaiter<Result<MultiResult, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A8E0", Offset = "0x2B098E0", VA = "0x182B0A8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2B0ABA0", Offset = "0x2B09BA0", VA = "0x182B0ABA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AC10", Offset = "0x2B09C10", VA = "0x182B0AC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AED0", Offset = "0x2B09ED0", VA = "0x182B0AED0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Task<Result<None, MCRZZCNKUJE>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private TaskAwaiter<Result<None, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AF40", Offset = "0x2B09F40", VA = "0x182B0AF40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2B0B200", Offset = "0x2B0A200", VA = "0x182B0B200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Dictionary<string, EnumChoiceData> CRRWKCJQHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Dictionary<int, string> DNMBFUZBERA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly List<object> RZLNVWQVIRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly List<Guid> IADAPJEYGVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly CanLocalPlayerCreateCurrencyDelegate TJDFMMNLUJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ShowRoomCurrencyCreationUIDelegate PDBLLGNZRKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipOptionsDelegate WWOMJDRFSUD;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<Guid, int> XJLAZIAKDLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipGuidToIndexMapDelegate IXKLHQAFIHT;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<int, Guid> RFJCTUFYSEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAudioClipIndexToGuidMapDelegate NQUCJLAOWAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipOptionsDelegate QJCFYXIIKXQ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<Guid, int> OCRGEUEGCUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate IYLDHJITRAC;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly IReadOnlyDictionary<int, Guid> XDDKACYMDBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate WBBPWXSKIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly PlayAudioPreviewDelegate EWCYHFYVMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly StopAudioPreviewDelegate OZAOCRVTDUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly SubscriptionIsActiveDelegate JEFNGGAGXAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate OKKRSCHLBYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Dictionary<string, EnumChoiceData> UAZFCFFXOCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly ShowQuickChatEditMenuDelegate KRDLBWRJFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly ConfigureAttachedObjectDelegate NBMUSIDQFUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly DisplayInvalidNameErrorMessageDelegate RXYQWUHZQWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly IsStringPureDelegate RTVKWWGQCQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly TryGetSpecificChipConfigSummaryDelegate CBDPTPVETUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReleaseIconIdDelegate DHHDIVXZVNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate XYRQIBAOYIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 AIRVXJNUHYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 AIXCUQHRRJT;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment CKMNKPYCOVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool LMOJEUBOYZM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xD4AD80", Offset = "0xD49D80", VA = "0x180D4AD80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> JMXEWIICVWR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> CMGTNIPYWGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> RRNZDDODKFR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> XLTHVNFLGYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD01390", Offset = "0xD00390", VA = "0x180D01390", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion HNAFIDASFVR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1000CE0", Offset = "0xFFFCE0", VA = "0x181000CE0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool XRRDYZXXKSN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xEF2FF0", Offset = "0xEF1FF0", VA = "0x180EF2FF0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool FWBCSCIEOBU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B07560", Offset = "0x2B06560", VA = "0x182B07560", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool FWSUXXBHHKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B07C10", Offset = "0x2B06C10", VA = "0x182B07C10", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool MVWKJHLSFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xCFD9C0", Offset = "0xCFC9C0", VA = "0x180CFD9C0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B07DD0", Offset = "0x2B06DD0", VA = "0x182B07DD0")]
		public SJEWSOJWSZU([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B079D0", Offset = "0x2B069D0", VA = "0x182B079D0", Slot = "9")]
		public bool VIPRVFBXBEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0")]
		public static bool AEUTIUTIPGC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B076F0", Offset = "0x2B066F0", VA = "0x182B076F0", Slot = "10")]
		public bool NQYCNZXYMCF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void CCGVKJFIFBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB90", Offset = "0xF0BB90", VA = "0x180F0CB90", Slot = "11")]
		public void GKGXBNAUEDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B07690", Offset = "0x2B06690", VA = "0x182B07690")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> MDBTTMHGZPH(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B07BE0", Offset = "0x2B06BE0", VA = "0x182B07BE0", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZBLHIWKJWDO(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B07B20", Offset = "0x2B06B20", VA = "0x182B07B20")]
		private static IReadOnlyDictionary<Guid, int> WTGXJZFXEYZ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B07660", Offset = "0x2B06660", VA = "0x182B07660", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> LLEEOLGGERS(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B07320", Offset = "0x2B06320", VA = "0x182B07320")]
		private static IReadOnlyDictionary<int, Guid> ANUOZPXERZX(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B07BB0", Offset = "0x2B06BB0", VA = "0x182B07BB0", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> YXNFTYGYTWQ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B07570", Offset = "0x2B06570", VA = "0x182B07570")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> KCJPKPMDJZC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3A80", Offset = "0x2AF2A80", VA = "0x182AF3A80", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> OXRMGDRISXR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B07610", Offset = "0x2B06610", VA = "0x182B07610")]
		private static IReadOnlyDictionary<Guid, int> LILXFTFLKNM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B079A0", Offset = "0x2B069A0", VA = "0x182B079A0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> TPPEYKKCYOZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B07C20", Offset = "0x2B06C20", VA = "0x182B07C20", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> ZINIDBBEHCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private static void BSTJVMRAOAT(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B075A0", Offset = "0x2B065A0", VA = "0x182B075A0", Slot = "18")]
		public void KGHUGBVJYIO(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private static void MLYWBRXHJCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B07720", Offset = "0x2B06720", VA = "0x182B07720", Slot = "19")]
		public void QQZATDISFRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0")]
		private static bool WHTQUCZLLKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B074C0", Offset = "0x2B064C0", VA = "0x182B074C0", Slot = "20")]
		public bool HDATFIGWJQV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0")]
		public static bool PRMZKXVHFOB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B07370", Offset = "0x2B06370", VA = "0x182B07370", Slot = "21")]
		public bool BCXXMPFTVZO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B072F0", Offset = "0x2B062F0", VA = "0x182B072F0", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ABAYCADETMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> RMXWONPSQPZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> YUTDJAQTZXB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B075E0", Offset = "0x2B065E0", VA = "0x182B075E0", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> KREYBZXRGRM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> TZUBJKOWPNY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> DOWABLEKYVY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void HFFMQOXKFGU(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B07B70", Offset = "0x2B06B70", VA = "0x182B07B70", Slot = "29")]
		public void WXUMOLYVEJR(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private static void WASCXMSJVLU(FMYNRNNNIYD a, SNXISRUYHOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B07930", Offset = "0x2B06930", VA = "0x182B07930", Slot = "35")]
		public void QZTFALDSXTL(FMYNRNNNIYD a, SNXISRUYHOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "36")]
		public Dictionary<string, EnumChoiceData> RKLNXQUEAMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "37")]
		public Dictionary<string, EnumChoiceData> CXRXKIDCZUY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private static void ZUUNXSUMCEC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B074F0", Offset = "0x2B064F0", VA = "0x182B074F0")]
		private static Task<bool> HNWIEOXELHU(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B076C0", Offset = "0x2B066C0", VA = "0x182B076C0", Slot = "38")]
		public Task<bool> NLQTOMYIZBP(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B07550", Offset = "0x2B06550", VA = "0x182B07550")]
		private static bool IRHIDWNRYWY(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B07960", Offset = "0x2B06960", VA = "0x182B07960", Slot = "39")]
		public bool SQPELAXLIAT(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private static void WMKIBXBDWTO(Id32<SKCKNIYGNEU> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B07490", Offset = "0x2B06490", VA = "0x182B07490", Slot = "40")]
		public void EEUSPNNINRN(Id32<SKCKNIYGNEU> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B073A0", Offset = "0x2B063A0", VA = "0x182B073A0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, MCRZZCNKUJE>> CNPJSTZQJVY(Task<Result<None, MCRZZCNKUJE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B07A90", Offset = "0x2B06A90", VA = "0x182B07A90", Slot = "41")]
		public Task<Result<None, MCRZZCNKUJE>> WCKHSJFEKBD(Task<Result<None, MCRZZCNKUJE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B07750", Offset = "0x2B06750", VA = "0x182B07750")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, MCRZZCNKUJE>> QTYORNXUFQQ(Task<Result<MultiResult, MCRZZCNKUJE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B07AF0", Offset = "0x2B06AF0", VA = "0x182B07AF0", Slot = "42")]
		public Task<Result<MultiResult, MCRZZCNKUJE>> WCKHSJFEKBD(Task<Result<MultiResult, MCRZZCNKUJE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B07840", Offset = "0x2B06840", VA = "0x182B07840")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> QUDVOURRPBZ(Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B07AC0", Offset = "0x2B06AC0", VA = "0x182B07AC0", Slot = "43")]
		public Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> WCKHSJFEKBD(Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class CANLMMVKSHD : ENYCAMCUJJK
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(CICCQXNQDHP e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? MVATJRGSDAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly InteropDelegate KDZVALJNSNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly InteropDelegate FCQNVTVBJDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private InteropDelegate? OHIMXCWTTGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private InvokeStudioFunctionDelegate? VEQCMZRQJWD;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "5")]
		public LegacyCV2Result<None> FVDFIFRUYOL(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20")]
		private static LegacyCV2Result<None> Default(CICCQXNQDHP _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "6")]
		public LegacyCV2Result<None> BOEEVORNOWS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "7")]
		public LegacyCV2Result<None> BRVWQFTOEMH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "8")]
		public LegacyCV2Result<None> EAEOKGQRSAS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "9")]
		public LegacyCV2Result<None> QQNASKTMVTM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "15")]
		public LegacyCV2Result<None> JUHFVGBNFBJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JPGIPECGLCJ(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DFXPOWZMIDB(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DYCQEDWZLBG(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NXMRYTAOLZL(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NGTJBOSNOGC(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LWJGIDBWMUE(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DDZDWPXHPYL(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "93")]
		public LegacyCV2Result<None> CWEDTBJUCEO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "94")]
		public LegacyCV2Result<None> JALNHIINWNK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "95")]
		public LegacyCV2Result<None> AYFPDITLUSF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YBUHFNSHIAJ(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(CICCQXNQDHP e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OFTBYNBMVYH(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XZWDBDOTDGX(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NQCYZGNAHYY(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RTSEWKWNXMJ(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JBIJGUDHWAA(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TQSSIUDQVPA(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZTXDVVVTNJM(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YTLQASZLGCT(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x151BCF0", Offset = "0x151ACF0", VA = "0x18151BCF0", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RBKLUEDWBWK(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RZYVBNINSHT(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "119")]
		public LegacyCV2Result<None> ZUFKWGSHHAN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PZNWRCFHFMS(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "121")]
		public LegacyCV2Result<None> WUXAUOYDOMW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "122")]
		public LegacyCV2Result<None> KKPINZXOWXU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "123")]
		public LegacyCV2Result<None> BNYHUHGCHTA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "124")]
		public LegacyCV2Result<None> DJCQRLWTCGC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "125")]
		public LegacyCV2Result<None> GBGDRGGAMOI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "126")]
		public LegacyCV2Result<None> DDYQPETHZJH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "818")]
		public LegacyCV2Result<None> ABKQWUQBMEX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "819")]
		public LegacyCV2Result<None> ABYNLJXTGGD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "147")]
		public LegacyCV2Result<None> TUXHKKYAUNH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "148")]
		public LegacyCV2Result<None> ICICMQVKKPX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "149")]
		public LegacyCV2Result<None> RCVMCMHZJDW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "150")]
		public LegacyCV2Result<None> LKHWLSNMZIY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "151")]
		public LegacyCV2Result<None> ILMNMFWIVOZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(CICCQXNQDHP e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(CICCQXNQDHP e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(CICCQXNQDHP e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, ENYCAMCUJJK.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(CICCQXNQDHP e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, ENYCAMCUJJK.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "174")]
		public LegacyCV2Result<None> XGRFOAGMSYM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "175")]
		public LegacyCV2Result<None> NEOIJQCBIQJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "176")]
		public LegacyCV2Result<None> LZKUXQAGEFD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "197")]
		public LegacyCV2Result<None> JQGMYWSZJYH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "198")]
		public LegacyCV2Result<None> LYAEIQGPOSS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "199")]
		public LegacyCV2Result<None> BNADYJDZQQZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "200")]
		public LegacyCV2Result<None> YLRBCXOUYAB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "201")]
		public LegacyCV2Result<None> NAVJSTIVMUX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "202")]
		public LegacyCV2Result<None> UYZKNKTCAUW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "203")]
		public LegacyCV2Result<None> VYSNEQSTFZO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "204")]
		public LegacyCV2Result<None> OEKQFLQZYYE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "205")]
		public LegacyCV2Result<None> YEVAJCTIFOY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "206")]
		public LegacyCV2Result<None> TTLIPCMAVTK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "207")]
		public LegacyCV2Result<None> OPDKXJPRIDS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "208")]
		public LegacyCV2Result<None> WTQWDSGJNTW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "209")]
		public LegacyCV2Result<None> IEKCJFRONKQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "210")]
		public LegacyCV2Result<None> RUNMHWCSWLF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "211")]
		public LegacyCV2Result<None> IMJZZZREMJY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "212")]
		public LegacyCV2Result<None> DGXJVUIYRIP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "213")]
		public LegacyCV2Result<None> PNOSRIEJRNK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "214")]
		public LegacyCV2Result<None> ULTTMKSNSCV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "215")]
		public LegacyCV2Result<None> TQIUMWLUDTK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "274")]
		public LegacyCV2Result<None> XOLPDKBWNEE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "277")]
		public LegacyCV2Result<None> TNFHZHONDHA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "279")]
		public LegacyCV2Result<None> ZMAYHYLZFUH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "280")]
		public LegacyCV2Result<None> OZFDCPQVZLP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "281")]
		public LegacyCV2Result<None> RCANYLNQNYS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "282")]
		public LegacyCV2Result<None> KODDVSNFSHB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "283")]
		public LegacyCV2Result<None> DHYDDAKCZWK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "287")]
		public LegacyCV2Result<None> LJNVQJDOKIH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "288")]
		public LegacyCV2Result<None> CPUQNINFPBE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "317")]
		public LegacyCV2Result<None> YCMHAPOSMTJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "406")]
		public LegacyCV2Result<None> XWIVGUTFZPQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TEZEGTJNPMV(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ICHAEQBQVFP(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WKOYXLYERXB(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KRDRWAVGBMQ(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AIHHCABKTTZ(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "416")]
		public LegacyCV2Result<LWMZQIIPILR.CV2DiscoverySectionType> ZTFIJVRMXBK(CICCQXNQDHP e, CircuitSignal a)
		{
			return default(LegacyCV2Result<LWMZQIIPILR.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "417")]
		public LegacyCV2Result<None> NITYPWXIQDG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(CICCQXNQDHP e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UANTLDJSBZG(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NREGUCFEXHF(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JDSVANOOIHC(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "462")]
		public LegacyCV2Result<None> HHWRKNFGQTR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "463")]
		public LegacyCV2Result<None> QFTAOLIKAZY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "464")]
		public LegacyCV2Result<None> LEDISIACXLL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "465")]
		public LegacyCV2Result<None> KQTRWTQYQXG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "466")]
		public LegacyCV2Result<None> QUVZAHZPOEC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "467")]
		public LegacyCV2Result<None> CDBYBKKDHRA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "468")]
		public LegacyCV2Result<None> VUMOHKFZRXD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "469")]
		public LegacyCV2Result<None> QKVYBWHFRMD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "474")]
		public LegacyCV2Result<None> FSBUYBJEIHN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "475")]
		public LegacyCV2Result<None> GHGRIIYHSJP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "476")]
		public LegacyCV2Result<None> OCWFZIUDJRM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "477")]
		public LegacyCV2Result<None> LXTCXSYWKMX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "478")]
		public LegacyCV2Result<None> IERLOSWAHQR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "479")]
		public LegacyCV2Result<None> AMAJPTTVVDE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(CICCQXNQDHP executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(CICCQXNQDHP executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "472")]
		public LegacyCV2Result<None> HJTKJOHLDHA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "473")]
		public LegacyCV2Result<None> NEINVLUDTSG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "480")]
		public LegacyCV2Result<None> IVSDMKQQVUQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "481")]
		public LegacyCV2Result<None> SMDHTBLDGTY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "482")]
		public LegacyCV2Result<None> SLNSRBAQJJB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "483")]
		public LegacyCV2Result<None> QPICAIGXFNX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "484")]
		public LegacyCV2Result<None> WJBWAHISQAR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "485")]
		public LegacyCV2Result<None> GWTZNAGJZFB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "486")]
		public LegacyCV2Result<None> SAMGMIRVAGN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "487")]
		public LegacyCV2Result<None> YPPMYZBKAWX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "488")]
		public LegacyCV2Result<None> FHIEUOVEVFX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "489")]
		public LegacyCV2Result<None> PJQEIRQENTP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "490")]
		public LegacyCV2Result<None> JUIZPAWMSBR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "491")]
		public LegacyCV2Result<None> DSRJSPGPODP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "492")]
		public LegacyCV2Result<None> RFONDILFOXB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "493")]
		public LegacyCV2Result<None> JDCXCDGTPQR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "494")]
		public LegacyCV2Result<None> TJQQCJVWKVX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "495")]
		public LegacyCV2Result<None> LADSFEIZDHF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "496")]
		public LegacyCV2Result<None> VDOKYYJDQLF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "497")]
		public LegacyCV2Result<None> PENXUUBXYLV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "498")]
		public LegacyCV2Result<None> OVPKHKPMMZB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "499")]
		public LegacyCV2Result<None> ZQWKAHQOMGV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B01090", Offset = "0x2B00090", VA = "0x182B01090", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "507")]
		public LegacyCV2Result<None> JMJBWUUTYXH(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "508")]
		public LegacyCV2Result<None> WAPPODMTZFZ(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "509")]
		public LegacyCV2Result<None> IICNUHQFJOX(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "510")]
		public LegacyCV2Result<None> PXYJSMJJDGW(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(CICCQXNQDHP e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(CICCQXNQDHP e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(CICCQXNQDHP e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.ERWRSYEVZNB> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "522")]
		public LegacyCV2Result<None> CFSSWXXNSFA(CICCQXNQDHP e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "525")]
		public LegacyCV2Result<None> XFBDBODWDAG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "527")]
		public LegacyCV2Result<None> FAAGKVTAKFV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "528")]
		public LegacyCV2Result<None> PJLOJLWGVNX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "530")]
		public LegacyCV2Result<None> VIAMCERVPEV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "531")]
		public LegacyCV2Result<None> TEYHZLTSIRC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F80", Offset = "0x2AFFF80", VA = "0x182B00F80", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "533")]
		public LegacyCV2Result<None> UUOKOZHWGMG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2B010D0", Offset = "0x2B000D0", VA = "0x182B010D0", Slot = "535")]
		public LegacyCV2Result<None> XLQDAXHXJMA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "534")]
		public LegacyCV2Result<None> RPLVAMLITQV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "536")]
		public LegacyCV2Result<None> HCVWDWGQMTZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "537")]
		public LegacyCV2Result<None> NPQOLXDXPHK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "538")]
		public LegacyCV2Result<None> HNTXEIYGNTI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "539")]
		public LegacyCV2Result<None> QUAIMMPLWRQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "540")]
		public LegacyCV2Result<None> DZZBWJNXITK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "583")]
		public LegacyCV2Result<None> Raycast(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "584")]
		public LegacyCV2Result<None> ZEYAPZUOKRD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "587")]
		public LegacyCV2Result<None> YQDSCWPZZLC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "591")]
		public LegacyCV2Result<None> RLETRTDXTOP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "592")]
		public LegacyCV2Result<None> RGSAPPJILKU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "641")]
		public LegacyCV2Result<None> WZRUHFTSZAB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "642")]
		public LegacyCV2Result<None> BTEKBJKMFDH(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "643")]
		public LegacyCV2Result<None> DBXWSSLOWZW(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "644")]
		public LegacyCV2Result<None> AYQPGRPJLDZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "645")]
		public LegacyCV2Result<None> PSZDCGWBCYD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "646")]
		public LegacyCV2Result<None> LDVLELTBYZC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "649")]
		public LegacyCV2Result<None> DMMTITVKJEP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "650")]
		public LegacyCV2Result<None> LDZAIJDJDBZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "651")]
		public LegacyCV2Result<None> XRFWDNLBADW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "661")]
		public LegacyCV2Result<None> PWHBOLLJTCT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "660")]
		public LegacyCV2Result<None> MGWJFOFIQXE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "662")]
		public LegacyCV2Result<None> BXGNRUQXJRT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "663")]
		public LegacyCV2Result<None> WBEQWBVQNVS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "670")]
		public LegacyCV2Result<None> GNDOHSNUECL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "671")]
		public LegacyCV2Result<None> SUVCTCRIODE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "674")]
		public LegacyCV2Result<None> LQVDPCAVACM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "675")]
		public LegacyCV2Result<None> FGWQKJKVHNJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(CICCQXNQDHP e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "696")]
		public LegacyCV2Result<None> NJXMEIAZNMV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "697")]
		public LegacyCV2Result<None> HMOLNHSSFNF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "698")]
		public LegacyCV2Result<None> WDHLTJIABFD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "699")]
		public LegacyCV2Result<None> JBUNIVUFQNY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "700")]
		public LegacyCV2Result<None> CRGZNCMDBHS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "676")]
		public LegacyCV2Result<None> ANEREGYNDSL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "677")]
		public LegacyCV2Result<None> BJDZGKDTBSN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "678")]
		public LegacyCV2Result<None> TAMEBSQRVIM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "679")]
		public LegacyCV2Result<None> VFOWEXPYORL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "680")]
		public LegacyCV2Result<None> VCWHDSSJGHU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "681")]
		public LegacyCV2Result<None> TMYGGZLSXHJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "682")]
		public LegacyCV2Result<None> JVRJFTFEFHT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "683")]
		public LegacyCV2Result<None> XJGTIJTADLW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "684")]
		public LegacyCV2Result<None> PGONCKSDKUW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "685")]
		public LegacyCV2Result<None> YHKDAVTIZCB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "686")]
		public LegacyCV2Result<None> JSYLHTBNGYN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "687")]
		public LegacyCV2Result<None> KMBZXMTGCZK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "688")]
		public LegacyCV2Result<None> HNMXYNTLVBN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "689")]
		public LegacyCV2Result<None> TCZZLLNMVVN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "690")]
		public LegacyCV2Result<None> JUUFPBEZWPW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "691")]
		public LegacyCV2Result<None> ZGUTWRQCXPA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "692")]
		public LegacyCV2Result<None> GKRWFCQJFKQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "693")]
		public LegacyCV2Result<None> UIMILDFDWIP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "765")]
		public LegacyCV2Result<None> RCZQOWUDNBL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "711")]
		public LegacyCV2Result<None> UUDKJIXLOUO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "712")]
		public LegacyCV2Result<None> PUEEIMCMPLE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "713")]
		public LegacyCV2Result<None> TWVYILRZASY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "714")]
		public LegacyCV2Result<None> FWFTIQJJOOK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "717")]
		public LegacyCV2Result<None> XUXQQDHVLMY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "721")]
		public LegacyCV2Result<None> XJBXCUYKBKJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "722")]
		public LegacyCV2Result<None> QEUVWJUGRNZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "723")]
		public LegacyCV2Result<None> LQHQPQNYVNQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "724")]
		public LegacyCV2Result<None> YDBTBJPCZSW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "725")]
		public LegacyCV2Result<None> UPPYZOWUOLU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "726")]
		public LegacyCV2Result<None> NJEISRJDONX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "727")]
		public LegacyCV2Result<None> HFEXBFLSTEY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "728")]
		public LegacyCV2Result<None> PLXOQKEBAYH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "729")]
		public LegacyCV2Result<None> HNMHYZLPYZP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "730")]
		public LegacyCV2Result<None> YNOOOWZZYSP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "731")]
		public LegacyCV2Result<None> LBFTGZYTGVB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "732")]
		public LegacyCV2Result<None> MQYNEAVKVQN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "733")]
		public LegacyCV2Result<None> JSNOIIFDYTP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "734")]
		public LegacyCV2Result<None> LINEMBLOSKY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "735")]
		public LegacyCV2Result<None> BDOHSXAUPMF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "736")]
		public LegacyCV2Result<None> VOIADCYEYHB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "737")]
		public LegacyCV2Result<None> NYZECUBFVEC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "738")]
		public LegacyCV2Result<None> EWLNZJTHUKV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "740")]
		public LegacyCV2Result<None> YYNOKEOWHQT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "739")]
		public LegacyCV2Result<None> AAWPNNMSSQP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "741")]
		public LegacyCV2Result<None> ZXVBXLKFOAW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "742")]
		public LegacyCV2Result<None> CVPAPFRNQMF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "743")]
		public LegacyCV2Result<None> ELZGRQIUJPM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "744")]
		public LegacyCV2Result<None> MJDQVVDLDXO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "745")]
		public LegacyCV2Result<None> JMGYKRXZLLN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "746")]
		public LegacyCV2Result<None> NFMPZTBRNZA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "747")]
		public LegacyCV2Result<None> HRJUWFGSJMS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "748")]
		public LegacyCV2Result<None> WYGEVVTPSAN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "749")]
		public LegacyCV2Result<None> COUDRIQNZNV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "750")]
		public LegacyCV2Result<None> YYVWVAZIGKT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "751")]
		public LegacyCV2Result<None> NZIBURACPVL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "752")]
		public LegacyCV2Result<None> GHFWIHTZJMN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "753")]
		public LegacyCV2Result<None> LGUNJLGWCBD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "754")]
		public LegacyCV2Result<None> DSNLLSAJCMJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "755")]
		public LegacyCV2Result<None> NUJBJFABSPK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "756")]
		public LegacyCV2Result<None> ZEDHLNWORIG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "757")]
		public LegacyCV2Result<None> XEMYFRTAODQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "758")]
		public LegacyCV2Result<None> WBHNNTJHFIC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "759")]
		public LegacyCV2Result<None> YDBDAEEPYKN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "760")]
		public LegacyCV2Result<None> RBYYYZXDRWH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "761")]
		public LegacyCV2Result<None> MHJYBMADDJD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "762")]
		public LegacyCV2Result<None> XYNUNYAAWLM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "763")]
		public LegacyCV2Result<None> HOYHDQGYXYE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "764")]
		public LegacyCV2Result<None> RKXHYRZZMMR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "771")]
		public LegacyCV2Result<None> KYELUQNSJMH(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "772")]
		public LegacyCV2Result<None> QQCTJYIKUSR(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "773")]
		public LegacyCV2Result<None> MURDDGWSCEG(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(CICCQXNQDHP ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "775")]
		public LegacyCV2Result<None> SIPCIXZSOVO(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "776")]
		public LegacyCV2Result<None> HEDZMXLFAGI(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "777")]
		public LegacyCV2Result<None> NSBJQJIZBVF(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "778")]
		public LegacyCV2Result<None> QTHXMHLKFWZ(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "779")]
		public LegacyCV2Result<None> SRHBATOZTWZ(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "707")]
		public LegacyCV2Result<None> RFWBRSRRFTR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "801")]
		public LegacyCV2Result<None> EGLNOGMHROR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "802")]
		public LegacyCV2Result<None> ENTMLZXFHQF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "803")]
		public LegacyCV2Result<None> VPEBBLJNYOD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "804")]
		public LegacyCV2Result<None> HDKZZWMFPHF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "805")]
		public LegacyCV2Result<None> WALECKZJKSZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "806")]
		public LegacyCV2Result<None> TXTVDUANHBX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "807")]
		public LegacyCV2Result<None> PRLNPQQLMET(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "808")]
		public LegacyCV2Result<None> RYSBGLJLAPV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "809")]
		public LegacyCV2Result<None> QAVSNZVZNTX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "810")]
		public LegacyCV2Result<None> FTPGHJMQVTF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "811")]
		public LegacyCV2Result<None> XLRJMIOEUTJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "812")]
		public LegacyCV2Result<None> IBNTZHOLCJC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "817")]
		public LegacyCV2Result<None> XEFFUAWYRKD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "821")]
		public LegacyCV2Result<None> LCKMOXKOKOA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "822")]
		public LegacyCV2Result<None> SBMINWAMSBW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "823")]
		public LegacyCV2Result<None> NJRLSFQWNLM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "824")]
		public LegacyCV2Result<None> ZEFPUERGPTA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "826")]
		public LegacyCV2Result<None> TKLDWMGVYDQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "827")]
		public LegacyCV2Result<None> EEROXRZFDPT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "828")]
		public LegacyCV2Result<None> HDNHMNOSOSH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "831")]
		public LegacyCV2Result<None> HMSEFFHRBAR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "832")]
		public LegacyCV2Result<None> PICMCKFJSMS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "833")]
		public LegacyCV2Result<None> PUVYCKGXPFP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(CICCQXNQDHP e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(CICCQXNQDHP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "836")]
		public LegacyCV2Result<None> XQZBDZZPIAM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TTUJGQQTGEG(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KWXOIMRMAXO(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WVGCOWYKTGL(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UVQNDXYPKHS(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HNWZULTMGDL(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(CICCQXNQDHP e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(CICCQXNQDHP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(CICCQXNQDHP e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(CICCQXNQDHP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(CICCQXNQDHP e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(CICCQXNQDHP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(CICCQXNQDHP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "856")]
		public LegacyCV2Result<None> URDBIOFQAOQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "859")]
		public LegacyCV2Result<None> PBVYULRMMCU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "860")]
		public LegacyCV2Result<None> IOKXJJJPSAO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "861")]
		public LegacyCV2Result<None> XDLXPRQZAFI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "862")]
		public LegacyCV2Result<None> GSFLFFYZDKL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "864")]
		public LegacyCV2Result<None> WFUBAKYBLDG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "865")]
		public LegacyCV2Result<None> WFJMXJXHVKO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(CICCQXNQDHP e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "869")]
		public LegacyCV2Result<None> TPQTUJWJJOC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "879")]
		public LegacyCV2Result<None> EESDYIHIEXW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "880")]
		public LegacyCV2Result<None> IGTKXAAADFA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "881")]
		public LegacyCV2Result<None> AADCZZFSXPN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "882")]
		public LegacyCV2Result<None> XGDXUMHYOHM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(CICCQXNQDHP e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(CICCQXNQDHP e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(CICCQXNQDHP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(CICCQXNQDHP e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(CICCQXNQDHP e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "889")]
		public LegacyCV2Result<None> OBYMKSUXIKO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "890")]
		public LegacyCV2Result<None> DVMQLYVFNPT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "891")]
		public LegacyCV2Result<None> CESAUEJJHEA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "892")]
		public LegacyCV2Result<None> PSJXDELEQIA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "893")]
		public LegacyCV2Result<None> UJUFSNHDXFY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "897")]
		public LegacyCV2Result<None> BJVXTTWQIJJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "898")]
		public LegacyCV2Result<None> YIJLEOOBQWT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "899")]
		public LegacyCV2Result<None> CMTLDKRBKEG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "901")]
		public LegacyCV2Result<None> QUKQBUGXPRU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "900")]
		public LegacyCV2Result<None> TSOUDWAARNI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "902")]
		public LegacyCV2Result<None> SMILETMKJDN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "904")]
		public LegacyCV2Result<None> ACEOMUAULKT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "903")]
		public LegacyCV2Result<None> ILKCKFVPCTP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "905")]
		public LegacyCV2Result<None> FBLYDKYOCCW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "906")]
		public LegacyCV2Result<None> USNPHNOPOJM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "907")]
		public LegacyCV2Result<None> HWFHADZQNHN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "908")]
		public LegacyCV2Result<None> EKAQWVTYULT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "909")]
		public LegacyCV2Result<None> VMJKSPLTPWB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "910")]
		public LegacyCV2Result<None> BLAQCYSKZVH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "911")]
		public LegacyCV2Result<None> AQYCWQECNEV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "918")]
		public LegacyCV2Result<None> ZPZOHOYEJTB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "919")]
		public LegacyCV2Result<None> KEDUXNOXQDV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(CICCQXNQDHP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(CICCQXNQDHP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(CICCQXNQDHP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(CICCQXNQDHP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(CICCQXNQDHP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(CICCQXNQDHP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(CICCQXNQDHP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(CICCQXNQDHP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(CICCQXNQDHP e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "941")]
		public LegacyCV2Result<None> XKMTOTNQTMJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "942")]
		public LegacyCV2Result<None> QZGRQXOWWEV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "943")]
		public LegacyCV2Result<None> JOGYWWORQUO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "944")]
		public LegacyCV2Result<None> UADCQPNNVKI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "945")]
		public LegacyCV2Result<None> RASWWZMUSBB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "946")]
		public LegacyCV2Result<None> OUAXSWPSZMR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "947")]
		public LegacyCV2Result<None> KHEKFTYBGEQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "948")]
		public LegacyCV2Result<None> GWKYDSHQUQQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "949")]
		public LegacyCV2Result<None> HGZZZGGXVYQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "950")]
		public LegacyCV2Result<None> YEZJRYUZVCX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "968")]
		public LegacyCV2Result<None> XXROLJRGBDR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "967")]
		public LegacyCV2Result<None> PVBFDHRSVJC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "969")]
		public LegacyCV2Result<None> KNJQVONTKOS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "970")]
		public LegacyCV2Result<None> HYNPAESEDCL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "971")]
		public LegacyCV2Result<None> UTEOMXENHQE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "972")]
		public LegacyCV2Result<None> BSSWHFUERJE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "973")]
		public LegacyCV2Result<None> FQEFJKBXXEH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "975")]
		public LegacyCV2Result<None> TNEWORYLRHG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "982")]
		public LegacyCV2Result<None> FUOASGNHIXB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "983")]
		public LegacyCV2Result<None> VEYPPOAXZPP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "991")]
		public LegacyCV2Result<None> YPJKGMMBVGQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "993")]
		public LegacyCV2Result<None> NJAIVRNFRSA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "994")]
		public LegacyCV2Result<None> WVDHDHPIKVG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "995")]
		public LegacyCV2Result<None> CFIXGOJCCXQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "996")]
		public LegacyCV2Result<None> KAYNEZTRSEW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "997")]
		public LegacyCV2Result<None> XDCWIQQWGRG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "998")]
		public LegacyCV2Result<None> PWAWGMCAACQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "999")]
		public LegacyCV2Result<None> PPFVTAZGOAG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1000")]
		public LegacyCV2Result<None> RZOQIXFLLHQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1001")]
		public LegacyCV2Result<None> IILRSVJWFJQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1002")]
		public LegacyCV2Result<None> KDJGMFYTSOW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1009")]
		public LegacyCV2Result<None> MMLBVFSILVO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1017")]
		public LegacyCV2Result<None> TVISTKFWXJF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1018")]
		public LegacyCV2Result<None> YMKIYUQJOLU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1019")]
		public LegacyCV2Result<None> PYUWORPUKRN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1020")]
		public LegacyCV2Result<None> GRTJJVEWWFE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1021")]
		public LegacyCV2Result<None> LRWPIQSMWQL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1022")]
		public LegacyCV2Result<None> SRRULPJMOFC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1023")]
		public LegacyCV2Result<None> KMWJYSVHXWR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1024")]
		public LegacyCV2Result<None> PDKCQNJWSZD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1025")]
		public LegacyCV2Result<None> KEAMKXVMWME(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1026")]
		public LegacyCV2Result<None> YIGFZJNPORB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1027")]
		public LegacyCV2Result<None> YSHADZPUSGL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1028")]
		public LegacyCV2Result<None> RVRUAPSRAVW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1029")]
		public LegacyCV2Result<None> WGDIATKZJKU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1030")]
		public LegacyCV2Result<None> YGZSLCWYUET(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1031")]
		public LegacyCV2Result<None> AGNOOBTYJSA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1032")]
		public LegacyCV2Result<None> MZQQJRADKYH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1033")]
		public LegacyCV2Result<None> MKSABONCSBF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1047")]
		public LegacyCV2Result<None> TOASOCHKAFT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1048")]
		public LegacyCV2Result<None> FWPSFAUAWUZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1049")]
		public LegacyCV2Result<None> KLGOUMWURJX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1050")]
		public LegacyCV2Result<None> PMFPBIKNUZX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1051")]
		public LegacyCV2Result<None> WYNKOFEPPUC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1052")]
		public LegacyCV2Result<None> SZLWLCWXPPI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1053")]
		public LegacyCV2Result<None> MJALYRIZLNX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1054")]
		public LegacyCV2Result<None> GETLFMYLXLG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1055")]
		public LegacyCV2Result<None> THRWRFOFKLV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1056")]
		public LegacyCV2Result<None> FDMLADWFJRK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1057")]
		public LegacyCV2Result<None> BHWRNURTHEE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1058")]
		public LegacyCV2Result<None> SHVBSWVWUNP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1059")]
		public LegacyCV2Result<None> JPZWVEOSUCI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1060")]
		public LegacyCV2Result<None> QRZNMBXVPVI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1061")]
		public LegacyCV2Result<None> VRLGWNVYACW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1062")]
		public LegacyCV2Result<None> IIAKQTGMXIC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1063")]
		public LegacyCV2Result<None> NHZNXOAVICW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1064")]
		public LegacyCV2Result<None> PBATPDRONWX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1065")]
		public LegacyCV2Result<None> QIFRFUJXRHJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1066")]
		public LegacyCV2Result<None> JXJLASYQNPG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1067")]
		public LegacyCV2Result<None> IWKXOMAHMBC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1068")]
		public LegacyCV2Result<None> DAJYDKMAUQK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1069")]
		public LegacyCV2Result<None> JZUMMECWIZM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1070")]
		public LegacyCV2Result<None> CDVWGHEIZDV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1071")]
		public LegacyCV2Result<None> IYKVDAIAPEH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B01050", Offset = "0x2B00050", VA = "0x182B01050", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(CICCQXNQDHP e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(CICCQXNQDHP e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1092")]
		public LegacyCV2Result<None> TBVSUUDJLEG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1093")]
		public LegacyCV2Result<None> EQDNFOCYOMV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1094")]
		public LegacyCV2Result<None> LXQWQHCREWN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1095")]
		public LegacyCV2Result<None> NJNHLHCRIAN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1096")]
		public LegacyCV2Result<None> XNTYQAUBKJH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1097")]
		public LegacyCV2Result<None> FTMIYJSFAHF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1098")]
		public LegacyCV2Result<None> SIFMMREEAHJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1099")]
		public LegacyCV2Result<None> MKXADRPIZMP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1100")]
		public LegacyCV2Result<None> XFJSGRVBFQL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1101")]
		public LegacyCV2Result<None> RFWBAEQGUXN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1102")]
		public LegacyCV2Result<None> FFPTRLOELYD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1103")]
		public LegacyCV2Result<None> SMLXKWVZOPG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1104")]
		public LegacyCV2Result<None> HJUVYHOYAYA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1105")]
		public LegacyCV2Result<None> YLCDRYBWEHW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1106")]
		public LegacyCV2Result<None> DTMTWKSEYQA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1107")]
		public LegacyCV2Result<None> PEHDLNAYPLZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1108")]
		public LegacyCV2Result<None> WDYTVCKVILR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1109")]
		public LegacyCV2Result<None> ZOLRAAKHRWS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1110")]
		public LegacyCV2Result<None> OHXUMERBKWC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1111")]
		public LegacyCV2Result<None> SFNKAXPWHJE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1112")]
		public LegacyCV2Result<None> CANNOIIFYYW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1113")]
		public LegacyCV2Result<None> CDBNKXADZJZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1114")]
		public LegacyCV2Result<None> UACINBMOZNV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1115")]
		public LegacyCV2Result<None> MYXVQUMUJLI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1116")]
		public LegacyCV2Result<None> PSJISDWLGEW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1117")]
		public LegacyCV2Result<None> SHJSFTEAONQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1118")]
		public LegacyCV2Result<None> FDMZRUSHDTU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1119")]
		public LegacyCV2Result<None> XMNFKUDAUYT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1120")]
		public LegacyCV2Result<None> ICRFEQKJJXK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1121")]
		public LegacyCV2Result<None> XSVLXCASJPS(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1122")]
		public LegacyCV2Result<None> DHTWVRBIJSI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1123")]
		public LegacyCV2Result<None> LTJRFJGGVXV(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1124")]
		public LegacyCV2Result<None> LKNUOHWTUIL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1125")]
		public LegacyCV2Result<None> GOFPDEINMZB(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1126")]
		public LegacyCV2Result<None> OUCQLHLFUUH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1127")]
		public LegacyCV2Result<None> JLNOTZMZPCD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1128")]
		public LegacyCV2Result<None> RRAMRZOWUXJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1129")]
		public LegacyCV2Result<None> LNMOJINVVNT(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1130")]
		public LegacyCV2Result<None> ARZSEXUKWOG(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1131")]
		public LegacyCV2Result<None> TVAIASHDCVF(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1132")]
		public LegacyCV2Result<None> RVWQMOPVNOS(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1133")]
		public LegacyCV2Result<None> GEPTJGVBDMX(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1134")]
		public LegacyCV2Result<None> BFYYIVEYTMT(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1135")]
		public LegacyCV2Result<None> YKUMTDRUVYM(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1136")]
		public LegacyCV2Result<None> DGLRFVVDYAQ(DVEOKZPITUG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1140")]
		public LegacyCV2Result<None> IKMMQAYJAAI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1166")]
		public LegacyCV2Result<None> PEVDOFQRYXM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1168")]
		public LegacyCV2Result<None> YUCQRLUMASA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1169")]
		public LegacyCV2Result<None> GDNVGORUTJN(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1170")]
		public LegacyCV2Result<None> XXMRQZZUWTU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1171")]
		public LegacyCV2Result<None> ACCEKVGYFQL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1182")]
		public LegacyCV2Result<None> QHKMYFQHFWP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1183")]
		public LegacyCV2Result<None> RFGTZVAOYJX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1184")]
		public LegacyCV2Result<None> LDRPSFXPUUV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1185")]
		public LegacyCV2Result<None> WGDPBBWRWXZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1186")]
		public LegacyCV2Result<None> EJOAQMFYUNG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1187")]
		public LegacyCV2Result<None> ICRPENRPZHW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1188")]
		public LegacyCV2Result<None> SWIKKDMFCYW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1189")]
		public LegacyCV2Result<None> FTQZAZWXQJM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1190")]
		public LegacyCV2Result<None> PWGNLTUPHEF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1191")]
		public LegacyCV2Result<None> IXJZHDCJZKV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1192")]
		public LegacyCV2Result<None> WQIZGQPWBRY(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1193")]
		public LegacyCV2Result<None> AAIUZOGSPRV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "184")]
		public LegacyCV2Result<None> HNFNOBQYZBR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F70", Offset = "0x2AFFF70", VA = "0x182B00F70", Slot = "191")]
		public bool CPCYAVTWIGB(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1194")]
		public LegacyCV2Result<None> FXYHKGLHBZF(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1195")]
		public LegacyCV2Result<None> PEUWTADEGKK(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1196")]
		public LegacyCV2Result<None> ODFCNBOWRWB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(CICCQXNQDHP e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1205")]
		public LegacyCV2Result<None> KLQQUNGRQRI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1206")]
		public LegacyCV2Result<None> KWGALGLESOS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(CICCQXNQDHP e, InOut io, OUVIEYVTDCK objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "250")]
		public LegacyCV2Result<None> OFMUSEOKHMH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "251")]
		public LegacyCV2Result<None> LCACGCSLGRP(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "252")]
		public LegacyCV2Result<None> DGRSRMOSGRD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "254")]
		public LegacyCV2Result<None> GZMNYNUMRZE(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "255")]
		public LegacyCV2Result<None> FWEAOLOZKCW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "256")]
		public LegacyCV2Result<None> OYNMEZVCABM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "257")]
		public LegacyCV2Result<None> JKSUKCDDTVD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "258")]
		public LegacyCV2Result<None> BDJZMDDIUJD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "259")]
		public LegacyCV2Result<None> LPUVKKORFQW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "260")]
		public LegacyCV2Result<None> LBIDJISSULA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "261")]
		public LegacyCV2Result<None> RLBKEIXYRPW(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "262")]
		public LegacyCV2Result<None> NZTJBPULXTC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "263")]
		public LegacyCV2Result<None> SDXLXMIAWNR(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "264")]
		public LegacyCV2Result<None> XXEZQLTJLCX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "265")]
		public LegacyCV2Result<None> VQFJGFAAGMJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "266")]
		public LegacyCV2Result<None> KTQTRQAWPSZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "267")]
		public LegacyCV2Result<None> JDCXXTQEEGJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "268")]
		public LegacyCV2Result<None> ATVSJUGRRIX(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "269")]
		public LegacyCV2Result<None> DTMHSFRKDVJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20")]
		private static LegacyCV2Result<None> Default(CICCQXNQDHP e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B00FC0", Offset = "0x2AFFFC0", VA = "0x182B00FC0", Slot = "1209")]
		public LegacyCV2Result<None> IELSABHGLGM(CICCQXNQDHP a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1212")]
		public LegacyCV2Result<None> XKDBXBFVKJJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1213")]
		public LegacyCV2Result<None> XLCHZNYGHNL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1214")]
		public LegacyCV2Result<None> SCJTQSMEWMZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1215")]
		public LegacyCV2Result<None> LHBZCYIZDBA(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(CICCQXNQDHP e, InOut io, RJRFXZVKNEC quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1036")]
		public LegacyCV2Result<None> JMPMAWZKLLV(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1037")]
		public LegacyCV2Result<None> DFAXKRDBTTB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1038")]
		public LegacyCV2Result<None> MPGXBKBWLRL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1039")]
		public LegacyCV2Result<None> VNGZVUVPPAZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1040")]
		public LegacyCV2Result<None> GJJIZLDONYH(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1041")]
		public LegacyCV2Result<None> SRBKDCTJFYL(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1042")]
		public LegacyCV2Result<None> HPRPBWZDDBV(CICCQXNQDHP a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1043")]
		public LegacyCV2Result<None> CHJUFCJBAVD(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1044")]
		public LegacyCV2Result<None> LUTYDQNSVZT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1045")]
		public LegacyCV2Result<None> JJFHUITLAJS(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1046")]
		public LegacyCV2Result<None> OOUGYOQXZIM(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WYVEXSMQHWY(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1234")]
		public LegacyCV2Result<None> UTKQBGXEOLZ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1236")]
		public LegacyCV2Result<None> XJSBYIILWVI(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1229")]
		public LegacyCV2Result<None> UYDQSZREYUQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1241")]
		public LegacyCV2Result<None> YPJJRHTJSJO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1242")]
		public LegacyCV2Result<None> IFTKCTTNATB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1243")]
		public LegacyCV2Result<None> CXGVSVIMWHJ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1244")]
		public LegacyCV2Result<None> MLUXYSUZEYB(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1245")]
		public LegacyCV2Result<None> RPGTWDTXWCO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XJQPRDTYFPK(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MKLGVMDBFSA(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WUVRHDBVXMO(CICCQXNQDHP a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1259")]
		public LegacyCV2Result<None> OKXUKYIOUXU(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1260")]
		public LegacyCV2Result<None> SMAPHHEXMLC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1261")]
		public LegacyCV2Result<None> KYJXQDOZBPC(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1262")]
		public LegacyCV2Result<None> OYXDKOFINSQ(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B01110", Offset = "0x2B00110", VA = "0x182B01110")]
		public CANLMMVKSHD([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(CICCQXNQDHP e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1280")]
		public LegacyCV2Result<None> GIPOHLQYVUT(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1281")]
		public LegacyCV2Result<None> DKEKAWKSYKG(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "599")]
		public LegacyCV2Result<None> NYPAOGWILXO(CICCQXNQDHP e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1293")]
		public LegacyCV2Result<None> LKYMGBIGBET(DVEOKZPITUG e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1294")]
		public LegacyCV2Result<None> VPVRGVYHOAO(DVEOKZPITUG e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1295")]
		public LegacyCV2Result<None> OFVFEEDRJCD(DVEOKZPITUG e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1296")]
		public LegacyCV2Result<None> VTGKUVPEGLH(DVEOKZPITUG e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1297")]
		public LegacyCV2Result<None> CEHOAIXVFDK(DVEOKZPITUG e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20")]
		public LegacyCV2Result<None> ConstantStorefrontItem(CICCQXNQDHP e, InOut io, [In] LABAEZAPVIH storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(CICCQXNQDHP e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> PDEKDZWKZVC(CICCQXNQDHP a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, ENYCAMCUJJK.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> MEKJQYVWMGG(CICCQXNQDHP a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, ENYCAMCUJJK.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1207")]
		private LegacyCV2Result<None> AUZNCBYJKSF(CICCQXNQDHP a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1216")]
		private LegacyCV2Result<None> DSDVOPUNPAW(CICCQXNQDHP a, InOut b, [In] LABAEZAPVIH storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20", Slot = "1257")]
		private LegacyCV2Result<None> VTISQZIBIQW(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class RIHPQPFYZKQ : JGMCRFMZQTH
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(KKXUVYMCRCC node);

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly RIHPQPFYZKQ QXGJXOUJRCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate AJYNDWPFZVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate BZQOFVOUFZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private bool DJTIATDVDCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private bool VTXOQJSVVQT;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D300", Offset = "0x2B0C300", VA = "0x182B0D300", Slot = "4")]
		public Task<bool> PIUYUPMEKBU(KKXUVYMCRCC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E6C0", Offset = "0x2B0D6C0", VA = "0x182B0E6C0", Slot = "5")]
		public Task<bool> CZTEYTTDLVD(KKXUVYMCRCC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E790", Offset = "0x2B0D790", VA = "0x182B0E790")]
		public RIHPQPFYZKQ([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E6F0", Offset = "0x2B0D6F0", VA = "0x182B0E6F0", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? PAWFWCCSNKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xCFC420", Offset = "0xCFB420", VA = "0x180CFC420", Slot = "7")]
		public bool NBBPHDDDVIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x15FA5D0", Offset = "0x15F95D0", VA = "0x1815FA5D0", Slot = "8")]
		public bool VFCTZRZBVWD()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class DDGUIIWPUCU : SSVDOWKZSPV
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid BPZCIKPPSZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
		public void Bind(ZMBQQHORWEH pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x1128C30", Offset = "0x1127C30", VA = "0x181128C30")]
		public DDGUIIWPUCU(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BBD0", Offset = "0x2B0ABD0", VA = "0x182B0BBD0")]
		public static DDGUIIWPUCU New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class HHOIYPNHPBI : ZOGEUBJOXII
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<ATOQASVPSNP> nodeDefId, Id128<YUFXTHDQAZB>? legacyInnerGraphId, IReadOnlyDictionary<Id128<YUFXTHDQAZB>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IsNodeRestrictedDelegate? QSIFTQOOVCR;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool XRRDYZXXKSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xD4AD80", Offset = "0xD49D80", VA = "0x180D4AD80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool GXAKWJQNMUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C2D0", Offset = "0x2B0B2D0", VA = "0x182B0C2D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HUPNPHHRMDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x11327E0", Offset = "0x11317E0", VA = "0x1811327E0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "6")]
		public bool EWEFMIXTDWL(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "7")]
		public CanSaveObjectIntoInventionResultType WSCKSNNIJFC(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C2E0", Offset = "0x2B0B2E0", VA = "0x182B0C2E0", Slot = "8")]
		public bool URYKDTGIQUH(Id128<ATOQASVPSNP> nodeDefId, Id128<YUFXTHDQAZB>? legacyInnerGraphId, IReadOnlyDictionary<Id128<YUFXTHDQAZB>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "9")]
		public bool GBDEDOHZMTG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "10")]
		public bool PWHAGXHHICG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C330", Offset = "0x2B0B330", VA = "0x182B0C330")]
		public HHOIYPNHPBI(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class MRKDKYAKIXK : IDFTFFZBPOV
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly MRKDKYAKIXK QXGJXOUJRCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly ShouldLogEventSenderToMakerPenDelegate FWPFSIDBMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate HKXFETBYOQK;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MGSHYYXDQCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x12C44A0", Offset = "0x12C34A0", VA = "0x1812C44A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool YGFRVMEJQNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2B0D6D0", Offset = "0x2B0C6D0", VA = "0x182B0D6D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D770", Offset = "0x2B0C770", VA = "0x182B0D770")]
		public MRKDKYAKIXK([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class YAKWGZNULPE : VOKBUVCZHVM<OJVRFOETZQC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class GWNRBOEOGYN : OJVRFOETZQC, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly GWNRBOEOGYN CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool ZVNLFAIRQUH
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C180", Offset = "0x2B0B180", VA = "0x182B0C180", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			public void JLOKKFUDLRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWNRBOEOGYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly YAKWGZNULPE CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private YAKWGZNULPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B148D0", Offset = "0x2B138D0", VA = "0x182B148D0", Slot = "4")]
		public OJVRFOETZQC HGAVPXFRNFN()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class RFWPTPAMTQY<a, b> : IDisposable, BAULKDCDPAL where a : notnull where b : notnull, PQSQGIARATU.IUAMOHWSHKE<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly b BIQCNNIQICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly a PZAFNKPBANV;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<WNPWZNYIVVQ> EYHHRNOAXBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<WNPWZNYIVVQ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x50D49B0", Offset = "0x50D39B0", VA = "0x1850D49B0")]
		public RFWPTPAMTQY(b a, a b, Id32<WNPWZNYIVVQ> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x781D5C0", Offset = "0x781C5C0", VA = "0x18781D5C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x781EDE0", Offset = "0x781DDE0", VA = "0x18781EDE0")]
		public Id32<ZKEUEWDMUHX> YYSIJTPJHQU([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<ZKEUEWDMUHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x781D0E0", Offset = "0x781C0E0", VA = "0x18781D0E0", Slot = "6")]
		public void BYINADOXFPF(Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x781F050", Offset = "0x781E050", VA = "0x18781F050", Slot = "7")]
		public void ZFOCAKHOJKR(Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x781E680", Offset = "0x781D680", VA = "0x18781E680", Slot = "8")]
		public void XMFKDHFPFRU(Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x781D850", Offset = "0x781C850", VA = "0x18781D850", Slot = "10")]
		public void EFHHZCRZOQR(Id32<ZKEUEWDMUHX> objectId, Id32<WNPWZNYIVVQ> clientId, BQTXGPOIMTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x781E640", Offset = "0x781D640", VA = "0x18781E640", Slot = "9")]
		public void QLWRATPKEGL(Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x781DAE0", Offset = "0x781CAE0", VA = "0x18781DAE0", Slot = "11")]
		public void JBCDOXHVXTR(Id32<ZKEUEWDMUHX> objectId, SYXGFCHGOJQ? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x781E320", Offset = "0x781D320", VA = "0x18781E320", Slot = "12")]
		public Id32<WNPWZNYIVVQ> QDUQRSNZFBW(Id32<ZKEUEWDMUHX> objectId)
		{
			return default(Id32<WNPWZNYIVVQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x781E030", Offset = "0x781D030", VA = "0x18781E030", Slot = "13")]
		public Id32<KEPQSWAPNBZ> OGFHGXXLWSE(Id32<ZKEUEWDMUHX> objectId, string a, object b, bool c, XWRQSPGOEYJ d, WCVMITZTDDZ e)
		{
			return default(Id32<KEPQSWAPNBZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x781D360", Offset = "0x781C360", VA = "0x18781D360", Slot = "14")]
		public void DFYMZBTYXYA(Id32<KEPQSWAPNBZ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x781DB20", Offset = "0x781CB20", VA = "0x18781DB20", Slot = "15")]
		public void JDDYQCYFYMK(Id32<KEPQSWAPNBZ> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class PQSQGIARATU
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface IUAMOHWSHKE<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DQMXWCGFIAQ(a a, Id32<WNPWZNYIVVQ> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<WNPWZNYIVVQ>? MQGLFPJWHMT(a a);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<ZKEUEWDMUHX> YYSIJTPJHQU(a a, Id32<WNPWZNYIVVQ> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void BYINADOXFPF(a a, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ZFOCAKHOJKR(a a, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void EFHHZCRZOQR(a a, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK b);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void QLWRATPKEGL(a a, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK b);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void JBCDOXHVXTR(a a, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, SYXGFCHGOJQ? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<WNPWZNYIVVQ>? QDUQRSNZFBW(a a, Id32<ZKEUEWDMUHX> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<KEPQSWAPNBZ> OGFHGXXLWSE(a a, Id32<WNPWZNYIVVQ> clientId, string b, object c, XWRQSPGOEYJ d, WCVMITZTDDZ e);

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void DFYMZBTYXYA(a a, Id32<WNPWZNYIVVQ> clientId, Id32<KEPQSWAPNBZ> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void JDDYQCYFYMK(a a, Id32<WNPWZNYIVVQ> clientId, Id32<KEPQSWAPNBZ> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class WZLWXKHLVBG
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly HashSet<Id32<ZKEUEWDMUHX>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAId32Field<KEPQSWAPNBZ, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public readonly Dictionary<Id32<KEPQSWAPNBZ>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<KEPQSWAPNBZ>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public SOAField<ZKEUEWDMUHX, SYXGFCHGOJQ?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E290", Offset = "0x2B0D290", VA = "0x182B0E290")]
			private MockCV2DynamicNetSys(HashSet<Id32<ZKEUEWDMUHX>> authorityOf, [In] SOAId32Field<KEPQSWAPNBZ, MockCV2SyncField> syncFields, Dictionary<Id32<KEPQSWAPNBZ>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<KEPQSWAPNBZ>> mockSyncFieldToSyncField, [In] SOAField<ZKEUEWDMUHX, SYXGFCHGOJQ?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E0D0", Offset = "0x2B0D0D0", VA = "0x182B0E0D0")]
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
			public Id32<WNPWZNYIVVQ>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E330", Offset = "0x2B0D330", VA = "0x182B0E330")]
			public MockCV2ObjectShared(Id32<WNPWZNYIVVQ> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public WCVMITZTDDZ SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public XWRQSPGOEYJ SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			internal MockCV2SyncField(WCVMITZTDDZ syncField, XWRQSPGOEYJ syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E450", Offset = "0x2B0D450", VA = "0x182B0E450")]
			public static MockCV2SyncField New(WCVMITZTDDZ syncField, XWRQSPGOEYJ syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x2B0E400", Offset = "0x2B0D400", VA = "0x182B0E400")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E3B0", Offset = "0x2B0D3B0", VA = "0x182B0E3B0")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<ZKEUEWDMUHX, MockCV2ObjectShared> XJIKIYCBEER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<ZKEUEWDMUHX>> BGZSSKHUWCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> KPEVRNZXLZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> CDJKOGDCQVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private SOAField<WNPWZNYIVVQ, MockCV2DynamicNetSys> URJQYJYOSQN;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<ZKEUEWDMUHX>? PEAGVVZNGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xDD3B70", Offset = "0xDD2B70", VA = "0x180DD3B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x12817F0", Offset = "0x12807F0", VA = "0x1812817F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2B131B0", Offset = "0x2B121B0", VA = "0x182B131B0")]
		public void Destroy([In] SOAId32<WNPWZNYIVVQ> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B12870", Offset = "0x2B11870", VA = "0x182B12870")]
		public void CLODALYKQJK(Id32<WNPWZNYIVVQ> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2B12E60", Offset = "0x2B11E60", VA = "0x182B12E60")]
		public void DQMXWCGFIAQ(Id32<WNPWZNYIVVQ> clientId, Id32<WNPWZNYIVVQ>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2B13E30", Offset = "0x2B12E30", VA = "0x182B13E30")]
		public Id32<ZKEUEWDMUHX> YYSIJTPJHQU(Id32<WNPWZNYIVVQ> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<WNPWZNYIVVQ> clientIds)
		{
			return default(Id32<ZKEUEWDMUHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B13930", Offset = "0x2B12930", VA = "0x182B13930")]
		public Id32<KEPQSWAPNBZ> OGFHGXXLWSE(Id32<WNPWZNYIVVQ> clientId, string a, object b, XWRQSPGOEYJ c, WCVMITZTDDZ d)
		{
			return default(Id32<KEPQSWAPNBZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x2B12CD0", Offset = "0x2B11CD0", VA = "0x182B12CD0")]
		public void DFYMZBTYXYA(Id32<WNPWZNYIVVQ> clientId, Id32<KEPQSWAPNBZ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2B13B90", Offset = "0x2B12B90", VA = "0x182B13B90")]
		public Id32<ZKEUEWDMUHX>? PGQWAVXPTMR([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2B127F0", Offset = "0x2B117F0", VA = "0x182B127F0")]
		public void BYINADOXFPF([In] SOAId32<WNPWZNYIVVQ> clientIds, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2B14240", Offset = "0x2B13240", VA = "0x182B14240")]
		public void ZFOCAKHOJKR(Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2B133F0", Offset = "0x2B123F0", VA = "0x182B133F0")]
		public void EFHHZCRZOQR(Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2B13CB0", Offset = "0x2B12CB0", VA = "0x182B13CB0")]
		public void QLWRATPKEGL([In] SOAId32<WNPWZNYIVVQ> clientIds, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2B134F0", Offset = "0x2B124F0", VA = "0x182B134F0")]
		public void JBCDOXHVXTR(Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, SYXGFCHGOJQ? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B13C60", Offset = "0x2B12C60", VA = "0x182B13C60")]
		public Id32<WNPWZNYIVVQ>? QDUQRSNZFBW(Id32<ZKEUEWDMUHX> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B135C0", Offset = "0x2B125C0", VA = "0x182B135C0")]
		public void JDDYQCYFYMK([In] SOAId32<WNPWZNYIVVQ> clientIds, Id32<WNPWZNYIVVQ> clientId, Id32<KEPQSWAPNBZ> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B14380", Offset = "0x2B13380", VA = "0x182B14380")]
		public WZLWXKHLVBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class UXJRISKOJFR
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x2B11900", Offset = "0x2B10900", VA = "0x182B11900")]
		public static void Destroy(this WZLWXKHLVBG.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class EHDEEXDXOJB : ZMMVBSVWDCT.UYPXTMTCQYP
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static EHDEEXDXOJB FDKEFNLBJEI;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate UARZAAYHMEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate YMJXBTWWBUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2A0", Offset = "0xCFA2A0", VA = "0x180CFB2A0")]
		public EHDEEXDXOJB(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class LHNTXVRCRQX : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : DZRBQUPXGSQ.RHUCFMBNWHH<PYPEGOPZPPS, LHNTXVRCRQX>
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
				public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public LHNTXVRCRQX root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public Id32<WNPWZNYIVVQ> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public PYPEGOPZPPS action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B10A50", Offset = "0x2B0FA50", VA = "0x182B10A50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B10C90", Offset = "0x2B0FC90", VA = "0x182B10C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			public int FDEGIOXLPFX(LHNTXVRCRQX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EBB0", Offset = "0x2B0DBB0", VA = "0x182B0EBB0", Slot = "5")]
			public int DTRKSXRBFJR(LHNTXVRCRQX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EBF0", Offset = "0x2B0DBF0", VA = "0x182B0EBF0", Slot = "6")]
			public int PEULEIYOSKA(LHNTXVRCRQX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EBD0", Offset = "0x2B0DBD0", VA = "0x182B0EBD0", Slot = "7")]
			public int GTFDDLUNWDO(LHNTXVRCRQX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EB60", Offset = "0x2B0DB60", VA = "0x182B0EB60", Slot = "8")]
			public void ANMNTYRHGPB(LHNTXVRCRQX a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "9")]
			public bool RTRMJRKTARW(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> actorId, PYPEGOPZPPS[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "10")]
			public bool GCLNRUDHTPE(LHNTXVRCRQX a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EC10", Offset = "0x2B0DC10", VA = "0x182B0EC10", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, MCRZZCNKUJE>> TXBWXIKUHFQ(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> senderId, PYPEGOPZPPS b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : DZRBQUPXGSQ.IULAIVKNAGW<ActionDeps, COWOBFPVIKZ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps EYKBEKPNGJQ
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public COWOBFPVIKZ.StaticNetSysReceiverDeps NZQKMTVCVBT
			{
				[Cpp2IlInjected.Token(Token = "0x60007AD")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "5")]
				get
				{
					return default(COWOBFPVIKZ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps YJDSXHZAHFO
			{
				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : HNTMWTIPKQK.IUAMOHWSHKE<LHNTXVRCRQX>
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
				public AsyncTaskMethodBuilder<Result<object?, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public LHNTXVRCRQX root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public Id32<WNPWZNYIVVQ> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public PYPEGOPZPPS action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				private TaskAwaiter<Result<object?, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B10730", Offset = "0x2B0F730", VA = "0x182B10730", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B109E0", Offset = "0x2B0F9E0", VA = "0x182B109E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E490", Offset = "0x2B0D490", VA = "0x182B0E490", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, MCRZZCNKUJE>> TXBWXIKUHFQ(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> clientId, PYPEGOPZPPS b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : PQSQGIARATU.IUAMOHWSHKE<LHNTXVRCRQX>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DCA0", Offset = "0x2B0CCA0", VA = "0x182B0DCA0", Slot = "4")]
			public void DQMXWCGFIAQ(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xF62ED0", Offset = "0xF61ED0", VA = "0x180F62ED0", Slot = "5")]
			public Id32<WNPWZNYIVVQ>? MQGLFPJWHMT(LHNTXVRCRQX a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DF10", Offset = "0x2B0CF10", VA = "0x182B0DF10")]
			public Id32<ZKEUEWDMUHX> YYSIJTPJHQU(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<ZKEUEWDMUHX>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DA70", Offset = "0x2B0CA70", VA = "0x182B0DA70", Slot = "7")]
			public void BYINADOXFPF(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DF70", Offset = "0x2B0CF70", VA = "0x182B0DF70", Slot = "8")]
			public void ZFOCAKHOJKR(LHNTXVRCRQX a, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DCD0", Offset = "0x2B0CCD0", VA = "0x182B0DCD0", Slot = "9")]
			public void EFHHZCRZOQR(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DEE0", Offset = "0x2B0CEE0", VA = "0x182B0DEE0", Slot = "10")]
			public void QLWRATPKEGL(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, BQTXGPOIMTK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DD10", Offset = "0x2B0CD10", VA = "0x182B0DD10", Slot = "11")]
			public void JBCDOXHVXTR(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> clientId, Id32<ZKEUEWDMUHX> objectId, SYXGFCHGOJQ? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DE80", Offset = "0x2B0CE80", VA = "0x182B0DE80", Slot = "12")]
			public Id32<WNPWZNYIVVQ>? QDUQRSNZFBW(LHNTXVRCRQX a, Id32<ZKEUEWDMUHX> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DE20", Offset = "0x2B0CE20", VA = "0x182B0DE20", Slot = "13")]
			public Id32<KEPQSWAPNBZ> OGFHGXXLWSE(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> clientId, string b, object c, XWRQSPGOEYJ d, WCVMITZTDDZ e)
			{
				return default(Id32<KEPQSWAPNBZ>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DB00", Offset = "0x2B0CB00", VA = "0x182B0DB00", Slot = "14")]
			public void DFYMZBTYXYA(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> clientId, Id32<KEPQSWAPNBZ> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DDF0", Offset = "0x2B0CDF0", VA = "0x182B0DDF0", Slot = "15")]
			public void JDDYQCYFYMK(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> clientId, Id32<KEPQSWAPNBZ> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DF10", Offset = "0x2B0CF10", VA = "0x182B0DF10", Slot = "6")]
			private Id32<ZKEUEWDMUHX> QNAFMNEGAAA(LHNTXVRCRQX a, Id32<WNPWZNYIVVQ> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<ZKEUEWDMUHX>);
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
			public LHNTXVRCRQX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public Id32<ZKEUEWDMUHX>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public ITTJCCLXRJK deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private Id32<WNPWZNYIVVQ> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private YFDAPENMPOM<LHNTXVRCRQX, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private RFWPTPAMTQY<LHNTXVRCRQX, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private COWOBFPVIKZ <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B10070", Offset = "0x2B0F070", VA = "0x182B10070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B106C0", Offset = "0x2B0F6C0", VA = "0x182B106C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly XUIVHTTEOJS<PYPEGOPZPPS, None, COWOBFPVIKZ, ActionDeps, COWOBFPVIKZ.StaticNetSysReceiverDeps, RootDeps, LHNTXVRCRQX, Deps> JHHHCUQHYTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly WZLWXKHLVBG TJQZXCHFEDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAId32<WNPWZNYIVVQ> TXTWYSUPYFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private SOAField<WNPWZNYIVVQ, None> URJQYJYOSQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private SOAField<WNPWZNYIVVQ, COWOBFPVIKZ> JBHLJGDZIUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Id32<WNPWZNYIVVQ>? ZUHRZZLVZHY;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate TCWYLGPSOZG
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B60", Offset = "0xCF6B60", VA = "0x180CF7B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CFA0", Offset = "0x2B0BFA0", VA = "0x182B0CFA0")]
		public LHNTXVRCRQX(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CCF0", Offset = "0x2B0BCF0", VA = "0x182B0CCF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C8E0", Offset = "0x2B0B8E0", VA = "0x182B0C8E0")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> CLODALYKQJK(ITTJCCLXRJK a, RegistryV2 b, Id32<ZKEUEWDMUHX>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CA60", Offset = "0x2B0BA60", VA = "0x182B0CA60")]
		private void DQMXWCGFIAQ(Id32<WNPWZNYIVVQ> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CEC0", Offset = "0x2B0BEC0", VA = "0x182B0CEC0")]
		[CompilerGenerated]
		private Id32<ZKEUEWDMUHX>? GQEMXAKWFVC([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class DXDRUNOGROK : VWOBBTEHFZU.UYPXTMTCQYP
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<GIIFHFQKBOL> DeserializeCircuitsJunctionAsyncDelegate(COWOBFPVIKZ circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<GIIFHFQKBOL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public DXDRUNOGROK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public COWOBFPVIKZ circuitsManager;

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
			private TaskAwaiter<GIIFHFQKBOL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B0ED60", Offset = "0x2B0DD60", VA = "0x182B0ED60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EF60", Offset = "0x2B0DF60", VA = "0x182B0EF60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate NZZQSPAHIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly LifecycleDidInitializeDelegate? UUVZHRNVASH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly LifecycleWillDestroyDelegate? SKACDNYTCPM;

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BC30", Offset = "0x2B0AC30", VA = "0x182B0BC30", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<GIIFHFQKBOL> DXNFTVSWGVQ(COWOBFPVIKZ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
		public void TXLETOGGZNA(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x100B5B0", Offset = "0x100A5B0", VA = "0x18100B5B0", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x1097590", Offset = "0x1096590", VA = "0x181097590", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BDA0", Offset = "0x2B0ADA0", VA = "0x182B0BDA0")]
		public DXDRUNOGROK([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class VNNYYSOMAVG : ZJXORRQKNEA.UYPXTMTCQYP
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate ZGVEFLJMWTI GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<UPLRFRLNHUO> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<SZARDBYZIVI> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<ZJXORRQKNEA.UYPXTMTCQYP.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<ZJXORRQKNEA.UYPXTMTCQYP.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public VNNYYSOMAVG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter<ZJXORRQKNEA.UYPXTMTCQYP.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EFD0", Offset = "0x2B0DFD0", VA = "0x182B0EFD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F1C0", Offset = "0x2B0E1C0", VA = "0x182B0F1C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<SZARDBYZIVI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public VNNYYSOMAVG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			private TaskAwaiter<SZARDBYZIVI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F230", Offset = "0x2B0E230", VA = "0x182B0F230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F420", Offset = "0x2B0E420", VA = "0x182B0F420", Slot = "5")]
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
			public AsyncTaskMethodBuilder<UPLRFRLNHUO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public VNNYYSOMAVG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private TaskAwaiter<UPLRFRLNHUO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F490", Offset = "0x2B0E490", VA = "0x182B0F490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F680", Offset = "0x2B0E680", VA = "0x182B0F680", Slot = "5")]
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
			public VNNYYSOMAVG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F6F0", Offset = "0x2B0E6F0", VA = "0x182B0F6F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F8E0", Offset = "0x2B0E8E0", VA = "0x182B0F8E0", Slot = "5")]
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
			public VNNYYSOMAVG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F950", Offset = "0x2B0E950", VA = "0x182B0F950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FB40", Offset = "0x2B0EB40", VA = "0x182B0FB40", Slot = "5")]
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
			public VNNYYSOMAVG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FBB0", Offset = "0x2B0EBB0", VA = "0x182B0FBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0FDA0", Offset = "0x2B0EDA0", VA = "0x182B0FDA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetCV2DependenciesDelegate KOHWXWCTYZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomDataAsyncDelegate BPXGEAQGLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetSuperRoomDataAsyncDelegate ECETUIDDZYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetRoomAssetDataAsyncDelegate PMCWNEZSSFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetPlayerSaveDataAsyncDelegate VIPQHYTUKZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate ULSDJBBIEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly GetStaticCircuitsConfigAsyncDelegate NSNJTSOGSKY;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public ZGVEFLJMWTI ZGVEFLJMWTI
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x12C44A0", Offset = "0x12C34A0", VA = "0x1812C44A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C90", Offset = "0x2B10C90", VA = "0x182B11C90", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> PGFEIBYZKAD(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B11B80", Offset = "0x2B10B80", VA = "0x182B11B80", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> NEFIEAVAYKW(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B11EB0", Offset = "0x2B10EB0", VA = "0x182B11EB0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<UPLRFRLNHUO> YYPWYKDEEOV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B11960", Offset = "0x2B10960", VA = "0x182B11960", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<SZARDBYZIVI> KRVJFTEAIWW(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B11A70", Offset = "0x2B10A70", VA = "0x182B11A70", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<ZJXORRQKNEA.UYPXTMTCQYP.CircuitGraphToolMapping> MPIYUBIWZQH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B11DA0", Offset = "0x2B10DA0", VA = "0x182B11DA0", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> RSGLGJEUCLU(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B11FC0", Offset = "0x2B10FC0", VA = "0x182B11FC0")]
		public VNNYYSOMAVG(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class XREGOSSAWHW : CV2Request.UYPXTMTCQYP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly CV2Request.UYPXTMTCQYP CIARLSLMHCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly GetCanSendRequestsDelegate YSIPMOKDBJC;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public XREGOSSAWHW(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x12C44A0", Offset = "0x12C34A0", VA = "0x1812C44A0", Slot = "4")]
		public bool UANPAZAQMOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class RROVVRFKJKP : MTGSWKHGETU
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, YCREHOYWOHO> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly TryReportErrToUserDelegate TTGDTXIVSGA;

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D300", Offset = "0x2B0C300", VA = "0x182B0D300")]
		public bool VAWKBDYBCOK([In] Result<None, YCREHOYWOHO> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E9A0", Offset = "0x2B0D9A0", VA = "0x182B0E9A0")]
		public RROVVRFKJKP([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D300", Offset = "0x2B0C300", VA = "0x182B0D300", Slot = "4")]
		private bool XWXLOAIMORX([In] Result<None, YCREHOYWOHO> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class NFQVJZQDKIG : RYRAUZOHXNB
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate CICCQXNQDHP CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly NFQVJZQDKIG CIARLSLMHCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CurrentExecParamsDelegate? RIQQABWKAKA;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public CICCQXNQDHP PPGJETOORYU
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x12C44A0", Offset = "0x12C34A0", VA = "0x1812C44A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public NFQVJZQDKIG([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class LQSJLGNTGII : HRTUZVSWSVJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly HRTUZVSWSVJ CIARLSLMHCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly GetGameColorFromIdDelegate IPOHGAUBSOU;

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D300", Offset = "0x2B0C300", VA = "0x182B0D300", Slot = "4")]
		public CircuitsColor SNWDDBRWGXA(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D520", Offset = "0x2B0C520", VA = "0x182B0D520")]
		public LQSJLGNTGII([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class KZUFMXZURNW : ETFDRUOMIST
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
			public KZUFMXZURNW <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x2B0FE10", Offset = "0x2B0EE10", VA = "0x182B0FE10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x2B10000", Offset = "0x2B0F000", VA = "0x182B10000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly IsStringPureAsyncDelegate KVZMKCAKAPB;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C5E0", Offset = "0x2B0B5E0", VA = "0x182B0C5E0", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> WTJEPKNKJBJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C720", Offset = "0x2B0B720", VA = "0x182B0C720")]
		public KZUFMXZURNW([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class XIMQHZITJGS : STIVPCHXXDL
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate TZDJKXENXJH? GetNodeVisualizationConfigDelegate([In] Id128<ATOQASVPSNP> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly STIVPCHXXDL CIARLSLMHCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly GetNodeVisualizationConfigDelegate ZEYFXWWGLSS;

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D300", Offset = "0x2B0C300", VA = "0x182B0D300")]
		public TZDJKXENXJH? YXFGZREAJFW([In] Id128<ATOQASVPSNP> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2B14590", Offset = "0x2B13590", VA = "0x182B14590")]
		public XIMQHZITJGS([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D300", Offset = "0x2B0C300", VA = "0x182B0D300", Slot = "4")]
		private TZDJKXENXJH FPIAKIZJZHK([In] Id128<ATOQASVPSNP> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class PZUNNAVVSYZ : GUQFFNFRVWI
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E670", Offset = "0x2B0D670", VA = "0x182B0E670", Slot = "4")]
		public OMPZDKSFJUN OBGOWUHFIQJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public PZUNNAVVSYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class ZKPAXAHVRRN : HESTTNCLENK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, bool> LVPGEEOEVFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, float> ESJKOZIVRXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, double> FBOAQTWUKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, int> WNHVIKVIAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, long> EDTBAXEGWHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, string> WORBQHCMKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly Dictionary<string, uint> NGDTOCGWEMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly Dictionary<string, ulong> UNZJUVRJZJL;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2B14990", Offset = "0x2B13990", VA = "0x182B14990", Slot = "4")]
		public bool? ZMUORHBRXMC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2B14A30", Offset = "0x2B13A30", VA = "0x182B14A30")]
		public ZKPAXAHVRRN()
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
